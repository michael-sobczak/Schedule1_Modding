using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using FishNet;
using FishNet.Connection;
using FishNet.Object;
using HarmonyLib;
using MelonLoader;
using S1API.Entities;
using S1API.Entities.Relation;
using S1API.Internal.Entities;
using S1API.Internal.Lifecycle;
using S1API.Internal.Utils;
using S1API.Logging;
using S1API.Map;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using ScheduleOne.GameTime;
using ScheduleOne.ItemFramework;
using ScheduleOne.Map;
using ScheduleOne.Money;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.Relation;
using ScheduleOne.NPCs.Schedules;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.Quests;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace S1API.Internal.Patches;

[HarmonyPatch]
internal class NPCPatches
{
	private static readonly Log Logger = new Log("NPCPatches");

	private static readonly HashSet<string> _loadingDealers = new HashSet<string>();

	public static bool CustomNpcsReady = false;

	private static readonly List<Type> _pendingCustomNpcTypes = new List<Type>();

	private static readonly HashSet<string> BaseNpcAdditionalKeys = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "Relationship", "Inventory", "CustomerData", "MessageConversation", "Health" };

	private static readonly Dictionary<Customer, float> _savedCurrentAddiction = new Dictionary<Customer, float>();

	private static int CompareNPCActions(NPCAction a, NPCAction b)
	{
		int num = a.StartTime.CompareTo(b.StartTime);
		if (num != 0)
		{
			return num;
		}
		if (a.IsSignal == b.IsSignal)
		{
			return 0;
		}
		return (!a.IsSignal) ? 1 : (-1);
	}

	private static bool HasConsolidatedSave(string mainPath)
	{
		string path = Directory.GetParent(mainPath)?.FullName ?? mainPath;
		string path2 = Path.Combine(path, "NPCs.json");
		return File.Exists(path2);
	}

	private static void RebuildPendingCustomNpcTypes(bool useConsolidatedFlow)
	{
		_pendingCustomNpcTypes.Clear();
		if (!useConsolidatedFlow)
		{
			return;
		}
		List<Type> derivedClasses = ReflectionUtils.GetDerivedClasses<NPC>();
		derivedClasses.Sort((Type a, Type b) => string.Compare(a?.Name, b?.Name, StringComparison.Ordinal));
		foreach (Type item in derivedClasses)
		{
			if (!(item == null) && !item.IsAbstract && !(item.Assembly == Assembly.GetExecutingAssembly()))
			{
				_pendingCustomNpcTypes.Add(item);
			}
		}
	}

	private static bool IsLikelyCustomDynamicSaveData(DynamicSaveData saveData)
	{
		if (saveData == null)
		{
			return false;
		}
		try
		{
			List<AdditionalData> additionalDatas = saveData.AdditionalDatas;
			if (additionalDatas == null)
			{
				return false;
			}
			int count = additionalDatas.Count;
			for (int i = 0; i < count; i++)
			{
				AdditionalData val = additionalDatas[i];
				if (val != null)
				{
					string name = val.Name;
					if (!string.IsNullOrEmpty(name) && !BaseNpcAdditionalKeys.Contains(name))
					{
						return true;
					}
				}
			}
		}
		catch
		{
		}
		return false;
	}

	private static void RegisterCustomNpcForNetworking(NPC customNPC)
	{
		if (customNPC == null || (Object)(object)customNPC.gameObject == (Object)null)
		{
			return;
		}
		try
		{
			NetworkObject val = customNPC.gameObject.GetComponent<NetworkObject>();
			if ((Object)(object)val == (Object)null)
			{
				try
				{
					val = customNPC.gameObject.AddComponent<NetworkObject>();
				}
				catch
				{
				}
			}
			if ((Object)(object)val != (Object)null)
			{
				NPCNetworkBootstrap.RegisterPendingNetworkSpawn(customNPC, val, 3f, 6f);
			}
		}
		catch
		{
		}
	}

	private static NPC TryInstantiateCustomNpcForSaveId(string npcId, string reasonTag)
	{
		if (_pendingCustomNpcTypes.Count == 0)
		{
			return null;
		}
		NPC val = FindBaseNpcById(npcId);
		if ((Object)(object)val != (Object)null)
		{
			NPC nPC = FindWrapperForS1Npc(val);
			if (nPC != null)
			{
				for (int num = _pendingCustomNpcTypes.Count - 1; num >= 0; num--)
				{
					Type type = _pendingCustomNpcTypes[num];
					if (type != null && nPC.GetType() == type)
					{
						_pendingCustomNpcTypes.RemoveAt(num);
						break;
					}
				}
				return nPC;
			}
			return null;
		}
		for (int i = 0; i < _pendingCustomNpcTypes.Count; i++)
		{
			Type type2 = _pendingCustomNpcTypes[i];
			NPC nPC2 = null;
			try
			{
				nPC2 = (NPC)Activator.CreateInstance(type2, nonPublic: true);
			}
			catch (Exception ex)
			{
				Logger.Warning("[S1API] Failed to instantiate custom NPC type '" + (type2?.FullName ?? "<null>") + "' for save ID '" + npcId + "': " + ex.Message);
			}
			if (nPC2 != null)
			{
				string text = null;
				try
				{
					text = nPC2.S1NPC?.ID;
				}
				catch
				{
				}
				if (!string.IsNullOrEmpty(npcId) && !string.IsNullOrEmpty(text) && text.Equals(npcId, StringComparison.OrdinalIgnoreCase))
				{
					_pendingCustomNpcTypes.RemoveAt(i);
					RegisterCustomNpcForNetworking(nPC2);
					return nPC2;
				}
				try
				{
					NPC.All.Remove(nPC2);
				}
				catch
				{
				}
				try
				{
					Object.DestroyImmediate((Object)(object)nPC2.gameObject);
				}
				catch
				{
				}
			}
		}
		return null;
	}

	private static void InstantiateRemainingCustomNpcs(string mainPath)
	{
		if (_pendingCustomNpcTypes.Count == 0)
		{
			return;
		}
		while (_pendingCustomNpcTypes.Count > 0)
		{
			Type type = _pendingCustomNpcTypes[0];
			_pendingCustomNpcTypes.RemoveAt(0);
			NPC nPC = null;
			try
			{
				nPC = (NPC)Activator.CreateInstance(type, nonPublic: true);
			}
			catch (Exception ex)
			{
				Logger.Warning("[S1API] Failed to instantiate custom NPC type '" + (type?.FullName ?? "<null>") + "' with default data: " + ex.Message);
			}
			if (nPC != null)
			{
				try
				{
					string folderPath = Path.Combine(mainPath, nPC.S1NPC.SaveFolderName);
					nPC.LoadInternal(folderPath);
				}
				catch
				{
				}
				RegisterCustomNpcForNetworking(nPC);
			}
		}
	}

	[HarmonyPatch(typeof(NPCsLoader), "Load")]
	[HarmonyPrefix]
	[HarmonyPriority(800)]
	private static void NPCsLoadersLoad(NPCsLoader __instance, string mainPath)
	{
		bool useConsolidatedFlow = HasConsolidatedSave(mainPath);
		RebuildPendingCustomNpcTypes(useConsolidatedFlow);
		if (!IsInMainScene() || !InstanceFinder.IsServer)
		{
			return;
		}
		string path = Directory.GetParent(mainPath)?.FullName ?? mainPath;
		string path2 = Path.Combine(path, "NPCs.json");
		if (File.Exists(path2))
		{
			return;
		}
		int num = 0;
		foreach (Type derivedClass in ReflectionUtils.GetDerivedClasses<NPC>())
		{
			if (derivedClass.IsAbstract)
			{
				continue;
			}
			NPC nPC = (NPC)Activator.CreateInstance(derivedClass, nonPublic: true);
			if (nPC == null)
			{
				throw new Exception("Unable to create instance of " + derivedClass.FullName + "!");
			}
			if (derivedClass.Assembly == Assembly.GetExecutingAssembly())
			{
				continue;
			}
			string text = nPC.S1NPC?.ID ?? "<null>";
			string folderPath = Path.Combine(mainPath, nPC.S1NPC.SaveFolderName);
			nPC.LoadInternal(folderPath);
			try
			{
				NetworkObject val = nPC.gameObject.GetComponent<NetworkObject>();
				if ((Object)(object)val == (Object)null)
				{
					try
					{
						val = nPC.gameObject.AddComponent<NetworkObject>();
					}
					catch
					{
					}
				}
				if ((Object)(object)val != (Object)null)
				{
					NPCNetworkBootstrap.RegisterPendingNetworkSpawn(nPC, val, 3f, 6f);
				}
			}
			catch
			{
			}
			num++;
		}
		_pendingCustomNpcTypes.Clear();
		CustomNpcsReady = true;
	}

	[HarmonyPatch(typeof(NPCsLoader), "Load")]
	[HarmonyPrefix]
	[HarmonyPriority(400)]
	private static bool NPCsLoader_Load_Prefix(NPCsLoader __instance, string mainPath)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		string path = Directory.GetParent(mainPath)?.FullName ?? mainPath;
		string path2 = Path.Combine(path, "NPCs.json");
		if (File.Exists(path2))
		{
			try
			{
				string text = File.ReadAllText(path2);
				NPCCollectionData val = JsonUtility.FromJson<NPCCollectionData>(text);
				if (val != null)
				{
					NPCLoader val2 = new NPCLoader();
					DynamicSaveData[] nPCs = val.NPCs;
					if (_pendingCustomNpcTypes.Count == 0)
					{
						RebuildPendingCustomNpcTypes(useConsolidatedFlow: true);
					}
					int num = 0;
					int num2 = 0;
					DynamicSaveData[] array = nPCs;
					foreach (DynamicSaveData val3 in array)
					{
						if (val3 == null)
						{
							continue;
						}
						try
						{
							NPCData val4 = val3.ExtractBaseData<NPCData>();
							NPC val5 = FindBaseNpcById(val4?.ID ?? string.Empty);
							if ((Object)(object)val5 == (Object)null && _pendingCustomNpcTypes.Count > 0)
							{
								NPC nPC = TryInstantiateCustomNpcForSaveId(val4?.ID, "no-base-npc");
								if (nPC != null)
								{
									val5 = FindBaseNpcById(val4?.ID ?? string.Empty);
								}
							}
							if ((Object)(object)val5 == (Object)null && IsLikelyCustomDynamicSaveData(val3) && _pendingCustomNpcTypes.Count > 0)
							{
								NPC nPC2 = TryInstantiateCustomNpcForSaveId(val4?.ID, "custom-data");
								if (nPC2 != null)
								{
									val5 = FindBaseNpcById(val4?.ID ?? string.Empty);
								}
							}
							if ((Object)(object)val5 != (Object)null)
							{
								((DynamicLoader)val2).Load(val3);
								num++;
							}
						}
						catch (Exception ex)
						{
							num2++;
							string text2 = val3.ExtractBaseData<NPCData>()?.ID ?? "<unknown>";
							Logger.Warning("[S1API] NPCsLoader_Load_Prefix: Failed to load NPC '" + text2 + "': " + ex.Message);
						}
					}
					InstantiateRemainingCustomNpcs(mainPath);
					return false;
				}
			}
			catch (Exception ex2)
			{
				Logger.Warning("[S1API] NPCsLoader_Load_Prefix: Error loading NPCs.json from parent directory: " + ex2.Message);
				Logger.Warning("[S1API] NPCsLoader_Load_Prefix: Stack trace: " + ex2.StackTrace);
			}
		}
		return true;
	}

	[HarmonyPatch(typeof(NPCInventory), "Awake")]
	[HarmonyPrefix]
	[HarmonyPriority(800)]
	private static void EnsureNPCInventorySafeInit(NPCInventory __instance)
	{
		string text = "<unknown>";
		bool flag = false;
		try
		{
			NPC component = ((Component)__instance).GetComponent<NPC>();
			text = component?.ID ?? ((Object)__instance).name ?? "<unknown>";
			flag = (((Object)(object)component != (Object)null) ? FindWrapperForS1Npc(component) : null)?.IsCustomNPC ?? false;
		}
		catch
		{
		}
		if (__instance.TestItems == null)
		{
			__instance.TestItems = Array.Empty<ItemDefinition>();
		}
		if (__instance.StartupItems == null)
		{
			__instance.StartupItems = Array.Empty<ItemDefinition>();
		}
		if (__instance.RandomInventoryItems == null)
		{
			__instance.RandomInventoryItems = Array.Empty<RandomInventoryItem>();
		}
		try
		{
			NPC component2 = ((Component)__instance).GetComponent<NPC>();
			NPC nPC = (((Object)(object)component2 != (Object)null) ? FindWrapperForS1Npc(component2) : null);
			if (nPC == null || !nPC.IsCustomNPC || __instance.StartupItems == null || __instance.ItemSlots == null)
			{
				return;
			}
			bool flag2 = false;
			try
			{
				for (int i = 0; i < __instance.ItemSlots.Count; i++)
				{
					ItemSlot val = __instance.ItemSlots[i];
					if (val != null && val.ItemInstance != null && val.Quantity > 0)
					{
						flag2 = true;
						break;
					}
				}
			}
			catch
			{
			}
			if (flag2)
			{
				ItemDefinition[] startupItems = __instance.StartupItems;
				if (startupItems != null && startupItems.Length != 0)
				{
					__instance.StartupItems = Array.Empty<ItemDefinition>();
				}
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("Failed to check for already-inserted startup items: " + ex.Message);
		}
	}

	[HarmonyPatch(typeof(NPCInventory), "Awake")]
	[HarmonyPostfix]
	[HarmonyPriority(0)]
	private static void NPCInventory_Awake_Postfix(NPCInventory __instance)
	{
		if (!IsInMainScene())
		{
			return;
		}
		try
		{
			NPC component = ((Component)__instance).GetComponent<NPC>();
			NPC nPC = (((Object)(object)component != (Object)null) ? FindWrapperForS1Npc(component) : null);
			if (nPC == null || !nPC.IsCustomNPC)
			{
				return;
			}
			try
			{
				NPCInventory nPCInventory = new NPCInventory(nPC);
				nPCInventory.EnsureInitialized();
			}
			catch (Exception ex)
			{
				Logger.Warning("Failed to ensure inventory initialized in postfix: " + ex.Message);
			}
			if (__instance.StartupItems != null)
			{
				ItemDefinition[] startupItems = __instance.StartupItems;
				if (startupItems != null && startupItems.Length != 0)
				{
					__instance.StartupItems = Array.Empty<ItemDefinition>();
				}
			}
		}
		catch (Exception ex2)
		{
			MelonLogger.Warning("[S1API] NPCInventory.Awake postfix cleanup failed: " + ex2.Message);
		}
	}

	[HarmonyPatch(typeof(NPC), "Start")]
	[HarmonyPostfix]
	private static void NPCStart(NPC __instance)
	{
		try
		{
			NPCPrefabIdentity component = ((Component)__instance).GetComponent<NPCPrefabIdentity>();
			if ((Object)(object)component != (Object)null)
			{
				component.ApplyTo(__instance);
			}
		}
		catch
		{
		}
		NPC nPC = null;
		for (int i = 0; i < NPC.All.Count; i++)
		{
			NPC nPC2 = NPC.All[i];
			if (nPC2.IsCustomNPC && (Object)(object)nPC2.S1NPC == (Object)(object)__instance)
			{
				nPC = nPC2;
				break;
			}
		}
		if (nPC == null && !InstanceFinder.IsServer)
		{
			nPC = NPC.CreateWrapperForNetworkSpawnedNPC(__instance);
		}
		if (nPC != null && nPC.IsCustomNPC)
		{
			nPC.EnsureMessageConversationReady(resetDefaults: false);
			nPC.CreateInternal();
			if (!InstanceFinder.IsServer)
			{
				MelonCoroutines.Start(SetClientVisibilityDelayed(__instance, nPC.IsPhysical));
			}
		}
		try
		{
			if (!((Object)(object)__instance != (Object)null) || !((Object)(object)((Component)__instance).gameObject != (Object)null) || ((Object)((Component)__instance).gameObject).name == null)
			{
				return;
			}
			string name = ((Object)((Component)__instance).gameObject).name;
			if ((((Component)__instance).gameObject.activeInHierarchy && ((Behaviour)__instance).enabled) || !name.StartsWith("S1API_", StringComparison.Ordinal))
			{
				return;
			}
			List<NPC> nPCRegistry = NPCManager.NPCRegistry;
			for (int num = nPCRegistry.Count - 1; num >= 0; num--)
			{
				if ((Object)(object)nPCRegistry[num] == (Object)(object)__instance)
				{
					nPCRegistry.RemoveAt(num);
					break;
				}
			}
		}
		catch
		{
		}
	}

	private static IEnumerator SetClientVisibilityDelayed(NPC npc, bool isPhysical)
	{
		yield return null;
		yield return (object)new WaitForSeconds(0.1f);
		try
		{
			if ((Object)(object)npc != (Object)null && (Object)(object)((Component)npc).gameObject != (Object)null)
			{
				npc.SetVisible(isPhysical, false);
			}
		}
		catch (Exception ex)
		{
			Exception ex2 = ex;
			Logger.Warning("Failed to set visibility for NPC '" + npc?.ID + "' on client: " + ex2.Message);
		}
	}

	[HarmonyPatch(typeof(NPC), "WriteData")]
	[HarmonyPostfix]
	private static void NPCWriteData(NPC __instance, string parentFolderPath, ref List<string> __result)
	{
		string path = Path.Combine(parentFolderPath, "NPCs.json");
		if (File.Exists(path))
		{
			return;
		}
		for (int i = 0; i < NPC.All.Count; i++)
		{
			NPC nPC = NPC.All[i];
			if (nPC.IsCustomNPC && (Object)(object)nPC.S1NPC == (Object)(object)__instance)
			{
				nPC.SaveInternal(parentFolderPath, ref __result);
				break;
			}
		}
	}

	[HarmonyPatch(typeof(NPC), "GetSaveData")]
	[HarmonyPrefix]
	private static bool NPC_GetSaveData_Prefix(NPC __instance, ref DynamicSaveData __result)
	{
		if ((Object)(object)__instance == (Object)null)
		{
			__result = null;
			return false;
		}
		if ((Object)(object)((Component)__instance).gameObject == (Object)null)
		{
			Logger.Warning("[S1API] NPC_GetSaveData_Prefix: NPC '" + (__instance?.ID ?? "<null>") + "' has null GameObject - skipping save");
			__result = null;
			return false;
		}
		try
		{
			string name = ((Object)((Component)__instance).gameObject).name;
			if (!string.IsNullOrEmpty(name) && name.StartsWith("S1API_", StringComparison.Ordinal))
			{
				__result = null;
				return false;
			}
		}
		catch
		{
			__result = null;
			return false;
		}
		return true;
	}

	[HarmonyPatch(typeof(NPC), "GetSaveData")]
	[HarmonyPostfix]
	private static void NPC_GetSaveData(NPC __instance, ref DynamicSaveData __result)
	{
		if (__result != null && !((Object)(object)__instance == (Object)null) && !((Object)(object)((Component)__instance).gameObject == (Object)null))
		{
			FindWrapperForS1Npc(__instance)?.SaveToDynamic(__result);
		}
	}

	[HarmonyPatch(typeof(NPCLoader), "Load")]
	[HarmonyPrefix]
	[HarmonyPriority(800)]
	private static bool NPCLoader_Load_Prefix(DynamicSaveData saveData)
	{
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		if (!IsInMainScene() && !IsInLoadingScene())
		{
			return true;
		}
		if (saveData == null)
		{
			return true;
		}
		NPCData val = saveData.ExtractBaseData<NPCData>();
		if (val == null || string.IsNullOrEmpty(val.ID))
		{
			return true;
		}
		NPC val2 = FindBaseNpcById(val.ID);
		if ((Object)(object)val2 == (Object)null)
		{
			Logger.Warning("[NPCPatches] NPCLoader_Load_Prefix: Could not find base NPC for '" + val.ID + "'.");
			Logger.Warning("The above warning is normal when removing an S1API mod with custom NPCs, because the NPC is saved but doesn't exist anymore.");
			return true;
		}
		try
		{
			if ((Object)(object)((Component)val2).gameObject == (Object)null)
			{
				return false;
			}
			GameObject gameObject = ((Component)val2).gameObject;
			if ((Object)(object)gameObject != (Object)null && (((Object)gameObject).name == "CivilianNPC" || ((Object)gameObject).name == "BaseNPC" || ((Object)gameObject).name.StartsWith("S1API_")))
			{
				return false;
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("NPCLoader_Load_Prefix: Exception in template check for ID '" + val.ID + "': " + ex.Message);
			return false;
		}
		NPC nPC = FindWrapperForS1Npc(val2);
		if (nPC == null || !nPC.IsCustomNPC)
		{
			return true;
		}
		try
		{
			Dealer component = ((Component)val2).GetComponent<Dealer>();
			if ((Object)(object)component != (Object)null)
			{
				EnsureDealerOverflowSlots(component);
			}
			val2.Load(saveData, val);
			RelationshipData val3 = default(RelationshipData);
			if (saveData.TryGetData<RelationshipData>("Relationship", ref val3) && val3 != null && val2.RelationData != null)
			{
				if (!float.IsNaN(val3.RelationDelta) && !float.IsInfinity(val3.RelationDelta))
				{
					val2.RelationData.SetRelationship(val3.RelationDelta);
				}
				if (val3.Unlocked)
				{
					val2.RelationData.Unlock(val3.UnlockType, false);
					try
					{
						nPC = FindWrapperForS1Npc(val2);
						if (nPC != null)
						{
							FieldInfo field = typeof(NPC).GetField("_loadedUnlockType", BindingFlags.Instance | BindingFlags.NonPublic);
							if (field != null)
							{
								EUnlockType val4 = (EUnlockType)(((int)val3.UnlockType != 0) ? 1 : 0);
								field.SetValue(nPC, val4);
							}
						}
					}
					catch
					{
					}
				}
			}
			try
			{
				nPC = FindWrapperForS1Npc(val2);
				if (nPC != null)
				{
					typeof(NPC).GetMethod("MarkLoadedFromSave", BindingFlags.Instance | BindingFlags.NonPublic)?.Invoke(nPC, null);
				}
			}
			catch
			{
			}
			MSGConversationData val5 = default(MSGConversationData);
			if (saveData.TryGetData<MSGConversationData>("MessageConversation", ref val5))
			{
				if (val2.MSGConversation == null)
				{
					Logger.Warning("NPCLoader_Load_Prefix: MSGConversation is null for '" + val.ID + "'");
				}
				else
				{
					val2.MSGConversation.Load(val5);
				}
			}
			CustomerData cust = default(CustomerData);
			if (saveData.TryGetData<CustomerData>("CustomerData", ref cust))
			{
				Customer component2 = ((Component)val2).GetComponent<Customer>();
				if ((Object)(object)component2 == (Object)null)
				{
					Logger.Warning("NPCLoader_Load_Prefix: Customer component is null for '" + val.ID + "'");
				}
				else
				{
					try
					{
						nPC.Customer.EnsureCustomer();
						Type type = nPC.GetType();
						if (NPC.HasCustomerDefaultsForType(type))
						{
							CustomerData val6 = NPC.BuildCustomerDefaultsForType(type);
							if ((Object)(object)val6 != (Object)null && !NPC.TrySetCustomerDataOnComponent(component2, val6))
							{
								try
								{
								}
								catch
								{
								}
							}
						}
						((Behaviour)component2).enabled = true;
						ApplyCustomerDataSafely(component2, cust);
					}
					catch (Exception ex2)
					{
						Logger.Warning("NPCLoader_Load_Prefix: Exception loading Customer data for '" + val.ID + "': " + ex2.Message);
						Logger.Warning("NPCLoader_Load_Prefix: Stack trace: " + ex2.StackTrace);
					}
				}
			}
			string text = default(string);
			if (saveData.TryGetData("Inventory", ref text))
			{
				try
				{
					DeserializedItemSet val7 = default(DeserializedItemSet);
					if (ItemSet.TryDeserialize(text, ref val7))
					{
						val7.LoadTo(val2.Inventory.ItemSlots);
					}
					else
					{
						Logger.Warning("Failed to deserialize inventory data for custom NPC '" + val.ID + "'");
					}
				}
				catch (Exception ex3)
				{
					Logger.Warning("NPCLoader_Load_Prefix: Exception loading Inventory data for '" + val.ID + "': " + ex3.Message);
				}
			}
		}
		catch (Exception ex4)
		{
			Logger.Warning("[S1API] NPCLoader.Load guard failed for custom NPC '" + val.ID + "': " + ex4.Message);
			Logger.Warning("Stack trace: " + ex4.StackTrace);
		}
		try
		{
			NPC nPC2 = FindWrapperForS1Npc(val2);
			if (nPC2 != null)
			{
				typeof(NPC).GetMethod("MarkLoadedFromSave", BindingFlags.Instance | BindingFlags.NonPublic)?.Invoke(nPC2, null);
				Type type2 = nPC2.GetType();
				if (NPC.TypeToRelationshipDefaults.TryGetValue(type2, out Action<NPCRelationshipDataBuilder> value) && value != null)
				{
					NPCRelationshipDataBuilder nPCRelationshipDataBuilder = new NPCRelationshipDataBuilder();
					value(nPCRelationshipDataBuilder);
					NPCRelationData relationData = val2.RelationData;
					if (relationData != null)
					{
						float relationDelta = relationData.RelationDelta;
						bool flag = Math.Abs(relationDelta - 2f) > 0.01f;
						float relationship = relationDelta;
						bool unlocked = relationData.Unlocked;
						nPCRelationshipDataBuilder.ApplyTo(relationData, val2, preserveUnlockState: true);
						if (flag)
						{
							relationData.SetRelationship(relationship);
						}
						bool unlocked2 = relationData.Unlocked;
						if (unlocked && !unlocked2)
						{
							Logger.Warning("[S1API] NPCLoader_Load_Prefix: WARNING - Unlock state was lost after applying defaults for '" + val.ID + "'!");
						}
					}
					else
					{
						Logger.Warning("[S1API] NPCLoader_Load_Prefix: RelationData is null when trying to apply defaults for '" + val.ID + "'");
					}
				}
			}
			else
			{
				Logger.Warning("[S1API] NPCLoader_Load_Prefix: Could not find wrapper NPC for '" + val.ID + "'");
			}
		}
		catch (Exception ex5)
		{
			Logger.Warning("[S1API] NPCLoader_Load_Prefix: Exception in post-load processing: " + ex5.Message);
			Logger.Warning("[S1API] Stack trace: " + ex5.StackTrace);
		}
		return false;
	}

	private static void ApplyCustomerDataSafely(Customer customerComponent, CustomerData cust)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)customerComponent == (Object)null || cust == null)
		{
			return;
		}
		try
		{
			Type type = ((object)customerComponent).GetType();
			try
			{
				FieldInfo field = type.GetField("currentAffinityData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				PropertyInfo property = type.GetProperty("currentAffinityData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				CustomerAffinityData val = null;
				if (field != null)
				{
					if ((object)field != null)
					{
						FieldInfo fieldInfo = field;
						if (true)
						{
							object? value = fieldInfo.GetValue(customerComponent);
							val = (CustomerAffinityData)((value is CustomerAffinityData) ? value : null);
							goto IL_0097;
						}
					}
					if ((object)property != null)
					{
						PropertyInfo propertyInfo = property;
						if (true)
						{
							object? value2 = propertyInfo.GetValue(customerComponent);
							val = (CustomerAffinityData)((value2 is CustomerAffinityData) ? value2 : null);
						}
					}
				}
				goto IL_0097;
				IL_0097:
				if (val == null)
				{
					val = new CustomerAffinityData();
					PropertyInfo property2 = type.GetProperty("CustomerData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
					if (property2 != null)
					{
						object value3 = property2.GetValue(customerComponent);
						if (value3 != null)
						{
							object obj = value3.GetType().GetProperty("DefaultAffinityData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)?.GetValue(value3);
							obj?.GetType().GetMethod("CopyTo", BindingFlags.Instance | BindingFlags.Public)?.Invoke(obj, new object[1] { val });
						}
					}
					if ((object)field != null)
					{
						FieldInfo fieldInfo2 = field;
						if (true)
						{
							fieldInfo2.SetValue(customerComponent, val);
							goto IL_018a;
						}
					}
					if ((object)property != null)
					{
						PropertyInfo propertyInfo2 = property;
						if (propertyInfo2.CanWrite)
						{
							propertyInfo2.SetValue(customerComponent, val);
						}
					}
				}
				goto IL_018a;
				IL_018a:
				if (cust.ProductAffinities != null && val != null)
				{
					object obj2 = ((object)val).GetType().GetProperty("ProductAffinities", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)?.GetValue(val);
					if (obj2 != null)
					{
						PropertyInfo property3 = obj2.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Public);
						int val2 = ((property3 != null) ? ((int)property3.GetValue(obj2)) : 0);
						int num = Math.Min(cust.ProductAffinities.Length, val2);
						for (int i = 0; i < num; i++)
						{
							if (!float.IsNaN(cust.ProductAffinities[i]))
							{
								object obj3 = obj2.GetType().GetProperty("Item", BindingFlags.Instance | BindingFlags.Public)?.GetMethod?.Invoke(obj2, new object[1] { i });
								obj3?.GetType().GetProperty("Affinity", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)?.SetValue(obj3, cust.ProductAffinities[i]);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				Logger.Warning("ApplyCustomerDataSafely currentAffinityData: " + ex.Message);
			}
			try
			{
				if (cust.IsContractOffered && cust.OfferedContract != null)
				{
					PropertyInfo property4 = type.GetProperty("OfferedContractInfo", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
					PropertyInfo property5 = type.GetProperty("OfferedContractTime", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
					if ((object)property4 != null && property4.CanWrite)
					{
						property4.SetValue(customerComponent, cust.OfferedContract);
					}
					if ((object)property5 != null && property5.CanWrite)
					{
						property5.SetValue(customerComponent, cust.OfferedContractTime);
					}
				}
			}
			catch (Exception ex2)
			{
				Logger.Warning("ApplyCustomerDataSafely contract data: " + ex2.Message);
			}
			try
			{
				float num2 = 0f;
				object obj4 = ReflectionUtils.TryGetFieldOrProperty(customerComponent, "CurrentAddiction");
				if (obj4 != null && obj4 is float)
				{
					num2 = (float)obj4;
				}
				float dependence = cust.Dependence;
				float value4 = dependence - num2;
				if (Math.Abs(value4) > 0.0001f)
				{
					ReflectionUtils.TrySetFieldOrProperty(customerComponent, "CurrentAddiction", dependence);
				}
			}
			catch (Exception ex3)
			{
				Logger.Warning("ApplyCustomerDataSafely dependence: " + ex3.Message);
			}
			try
			{
				PropertyInfo property6 = type.GetProperty("TimeSinceLastDealCompleted", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				PropertyInfo property7 = type.GetProperty("TimeSinceLastDealOffered", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				PropertyInfo property8 = type.GetProperty("OfferedDeals", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				PropertyInfo property9 = type.GetProperty("CompletedDeliveries", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				PropertyInfo property10 = type.GetProperty("TimeSincePlayerApproached", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				PropertyInfo property11 = type.GetProperty("TimeSinceInstantDealOffered", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				if ((object)property6 != null && property6.CanWrite)
				{
					property6.SetValue(customerComponent, cust.TimeSinceLastDealCompleted);
				}
				if ((object)property7 != null && property7.CanWrite)
				{
					property7.SetValue(customerComponent, cust.TimeSinceLastDealOffered);
				}
				if ((object)property8 != null && property8.CanWrite)
				{
					property8.SetValue(customerComponent, cust.OfferedDeals);
				}
				if ((object)property9 != null && property9.CanWrite)
				{
					property9.SetValue(customerComponent, cust.CompletedDeals);
				}
				if ((object)property10 != null && property10.CanWrite)
				{
					property10.SetValue(customerComponent, cust.TimeSincePlayerApproached);
				}
				if ((object)property11 != null && property11.CanWrite)
				{
					property11.SetValue(customerComponent, cust.TimeSinceInstantDealOffered);
				}
			}
			catch (Exception ex4)
			{
				Logger.Warning("ApplyCustomerDataSafely basic counters: " + ex4.Message);
			}
		}
		catch (Exception ex5)
		{
			Logger.Warning("ApplyCustomerDataSafely error: " + ex5.Message);
		}
	}

	[HarmonyPatch(typeof(NPC), "OnDestroy")]
	[HarmonyPostfix]
	private static void NPCOnDestroy(NPC __instance)
	{
		try
		{
			NPCEnterableBuilding componentInParent = ((Component)__instance).GetComponentInParent<NPCEnterableBuilding>(true);
			if ((Object)(object)componentInParent != (Object)null)
			{
				global::S1API.Map.Building.Unregister(componentInParent);
			}
		}
		catch
		{
		}
		for (int i = 0; i < NPC.All.Count; i++)
		{
			NPC nPC = NPC.All[i];
			if ((Object)(object)nPC.S1NPC == (Object)(object)__instance)
			{
				NPC.All.Remove(nPC);
				break;
			}
		}
	}

	[HarmonyPatch(typeof(NPC), "ShouldSave")]
	[HarmonyPrefix]
	private static bool NPC_ShouldSave_Prefix(NPC __instance, ref bool __result)
	{
		try
		{
			if ((Object)(object)__instance != (Object)null && (Object)(object)((Component)__instance).gameObject != (Object)null)
			{
				string name = ((Object)((Component)__instance).gameObject).name;
				if (!string.IsNullOrEmpty(name) && name.StartsWith("S1API_", StringComparison.Ordinal))
				{
					__result = false;
					return false;
				}
			}
		}
		catch
		{
		}
		return true;
	}

	[HarmonyPatch(typeof(NPCManager), "GetSaveString")]
	[HarmonyPrefix]
	private static bool NPCManager_GetSaveString_Prefix(ref string __result)
	{
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			List<NPC> nPCRegistry = NPCManager.NPCRegistry;
			if (nPCRegistry == null)
			{
				__result = ((SaveData)new NPCCollectionData((DynamicSaveData[])(object)new DynamicSaveData[0])).GetJson(true);
				return false;
			}
			List<DynamicSaveData> list = new List<DynamicSaveData>();
			for (int i = 0; i < nPCRegistry.Count; i++)
			{
				NPC val = nPCRegistry[i];
				if ((Object)(object)val == (Object)null)
				{
					continue;
				}
				try
				{
					string text = (((Object)(object)((Component)val).gameObject != (Object)null) ? ((Object)((Component)val).gameObject).name : null);
					if ((string.IsNullOrEmpty(text) || !text.StartsWith("S1API_", StringComparison.Ordinal)) && val.ShouldSave())
					{
						DynamicSaveData saveData = val.GetSaveData();
						if (saveData != null)
						{
							list.Add(saveData);
						}
					}
				}
				catch (Exception ex)
				{
					Logger.Warning($"NPCManager_GetSaveString_Prefix: Skipping NPC at index {i} due to exception: {ex.Message}");
				}
			}
			__result = ((SaveData)new NPCCollectionData(list.ToArray())).GetJson(true);
			return false;
		}
		catch (Exception ex2)
		{
			Logger.Warning("NPCManager_GetSaveString_Prefix: Exception building save JSON: " + ex2.Message);
			__result = ((SaveData)new NPCCollectionData((DynamicSaveData[])(object)new DynamicSaveData[0])).GetJson(true);
			return false;
		}
	}

	[HarmonyPatch(typeof(NPCHealth), "Load")]
	[HarmonyPrefix]
	private static bool NPCHealthLoad(NPCHealth __instance, NPCHealthData healthData)
	{
		NPC component = ((Component)__instance).GetComponent<NPC>();
		NPC nPC = FindWrapperForS1Npc(component);
		if (nPC != null && nPC.IsCustomNPC)
		{
			return false;
		}
		return true;
	}

	[HarmonyPatch(typeof(NPCInventory), "OnSleepStart")]
	[HarmonyPrefix]
	private static bool NPCInventory_OnSleepStart_Prefix(NPCInventory __instance)
	{
		if (!IsInMainScene())
		{
			return true;
		}
		NPC component = ((Component)__instance).GetComponent<NPC>();
		NPC nPC = (((Object)(object)component != (Object)null) ? FindWrapperForS1Npc(component) : null);
		if (nPC == null || !nPC.IsCustomNPC)
		{
			return true;
		}
		if (!InstanceFinder.IsServer)
		{
			return false;
		}
		try
		{
			if (__instance.ClearInventoryEachNight)
			{
				for (int i = 0; i < __instance.ItemSlots.Count; i++)
				{
					ItemSlot val = __instance.ItemSlots[i];
					if (val != null)
					{
						val.ClearStoredInstance(true);
					}
				}
			}
			int num = 0;
			for (int j = 0; j < __instance.ItemSlots.Count; j++)
			{
				ItemSlot obj = __instance.ItemSlots[j];
				if (((obj != null) ? obj.ItemInstance : null) != null)
				{
					num++;
				}
			}
			if (num >= 3)
			{
				return false;
			}
			if (__instance.RandomCash)
			{
				int num2 = Random.Range(__instance.RandomCashMin, __instance.RandomCashMax);
				if (num2 > 0)
				{
					CashInstance cashInstance = NetworkSingleton<MoneyManager>.Instance.GetCashInstance((float)num2);
					__instance.InsertItem((ItemInstance)(object)cashInstance, false);
				}
			}
			if (__instance.RandomItems && __instance.RandomInventoryItems != null && __instance.RandomInventoryItems.Length != 0)
			{
				__instance.AddRandomItemsToInventory();
			}
		}
		catch (Exception ex)
		{
			MelonLogger.Warning("[S1API] NPCInventory.OnSleepStart guard failed for custom NPC: " + ex.Message);
		}
		return false;
	}

	[HarmonyPatch(typeof(NPCHealth), "Revive")]
	[HarmonyPrefix]
	private static bool NPCHealth_Revive_Prefix(NPCHealth __instance)
	{
		if (!IsInMainScene())
		{
			return true;
		}
		NPC component = ((Component)__instance).GetComponent<NPC>();
		NPC nPC = (((Object)(object)component != (Object)null) ? FindWrapperForS1Npc(component) : null);
		if (nPC == null || !nPC.IsCustomNPC)
		{
			return true;
		}
		return false;
	}

	[HarmonyPatch(typeof(NPCLoader), "Load")]
	[HarmonyPostfix]
	private static void NPCLoader_Load_Postfix(DynamicSaveData saveData)
	{
		if (!IsInMainScene() || saveData == null)
		{
			return;
		}
		NPCData val = saveData.ExtractBaseData<NPCData>();
		if (val == null || string.IsNullOrEmpty(val.ID))
		{
			return;
		}
		NPC val2 = FindBaseNpcById(val.ID);
		if ((Object)(object)val2 == (Object)null)
		{
			Logger.Warning("[NPCPatches] NPCLoader_Load_Postfix: No base NPC found for '" + val.ID + "'.");
			return;
		}
		NPC nPC = FindWrapperForS1Npc(val2);
		if (nPC != null)
		{
			nPC.LoadFromDynamic(saveData);
			try
			{
				typeof(NPC).GetMethod("MarkLoadedFromSave", BindingFlags.Instance | BindingFlags.NonPublic)?.Invoke(nPC, null);
			}
			catch (Exception ex)
			{
				Logger.Warning("[S1API] NPCLoader_Load_Postfix: Exception marking NPC '" + val.ID + "' as loaded: " + ex.Message);
			}
			CustomNpcsReady = true;
		}
	}

	private static NPC FindBaseNpcById(string id)
	{
		try
		{
			List<NPC> nPCRegistry = NPCManager.NPCRegistry;
			if (nPCRegistry != null)
			{
				for (int i = 0; i < nPCRegistry.Count; i++)
				{
					NPC val = nPCRegistry[i];
					if ((Object)(object)val != (Object)null && val.ID == id)
					{
						return val;
					}
				}
			}
			for (int j = 0; j < NPC.All.Count; j++)
			{
				NPC nPC = NPC.All[j];
				if (nPC != null && (Object)(object)nPC.S1NPC != (Object)null && nPC.S1NPC.ID == id)
				{
					if (!NPCManager.NPCRegistry.Contains(nPC.S1NPC))
					{
						NPCManager.NPCRegistry.Add(nPC.S1NPC);
					}
					return nPC.S1NPC;
				}
			}
			return null;
		}
		catch (Exception ex)
		{
			Logger.Warning("FindBaseNpcById: Exception searching for ID '" + id + "': " + ex.Message);
			return null;
		}
	}

	private static void EnsureDealerOverflowSlots(Dealer dealer)
	{
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		if ((Object)(object)dealer == (Object)null)
		{
			return;
		}
		try
		{
			object obj = ReflectionUtils.TryGetFieldOrProperty(dealer, "overflowSlots");
			bool flag = false;
			int num = 0;
			if (obj == null)
			{
				flag = true;
			}
			else
			{
				PropertyInfo propertyInfo = obj.GetType().GetProperty("Length") ?? obj.GetType().GetProperty("Count");
				if (propertyInfo != null)
				{
					num = (int)propertyInfo.GetValue(obj);
					flag = num == 0;
				}
				else
				{
					flag = true;
				}
			}
			string text = ((NPC)(dealer?)).ID ?? ((dealer != null) ? ((Object)dealer).name : null) ?? "<unknown>";
			if (flag)
			{
				ItemSlot[] array = (ItemSlot[])(object)new ItemSlot[10];
				for (int i = 0; i < 10; i++)
				{
					array[i] = new ItemSlot();
					array[i].SetSlotOwner((IItemSlotOwner)(object)dealer);
				}
				ReflectionUtils.TrySetFieldOrProperty(dealer, "overflowSlots", array);
			}
			else
			{
				if (num <= 0 || !(obj is ItemSlot[] array2))
				{
					return;
				}
				for (int j = 0; j < num && j < array2.Length; j++)
				{
					ItemSlot val = array2[j];
					if (val != null)
					{
						val.SetSlotOwner((IItemSlotOwner)(object)dealer);
					}
				}
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("Exception ensuring dealer overflow slots: " + ex.Message);
		}
	}

	private static NPC FindWrapperForS1Npc(NPC baseNpc)
	{
		try
		{
			if ((Object)(object)baseNpc == (Object)null)
			{
				return null;
			}
			for (int i = 0; i < NPC.All.Count; i++)
			{
				NPC nPC = NPC.All[i];
				if (nPC != null && (Object)(object)nPC.S1NPC == (Object)(object)baseNpc)
				{
					return nPC;
				}
			}
			return null;
		}
		catch (Exception ex)
		{
			Logger.Warning("FindWrapperForS1Npc: Exception searching for base NPC '" + baseNpc?.ID + "': " + ex.Message);
			return null;
		}
	}

	private static bool IsInMainScene()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		Scene activeScene = SceneManager.GetActiveScene();
		string name = ((Scene)(ref activeScene)).name;
		return string.Equals(name, "Main", StringComparison.OrdinalIgnoreCase);
	}

	private static bool IsInLoadingScene()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		Scene activeScene = SceneManager.GetActiveScene();
		string name = ((Scene)(ref activeScene)).name;
		return string.Equals(name, "Loading", StringComparison.OrdinalIgnoreCase) || string.Equals(name, "Persistence", StringComparison.OrdinalIgnoreCase) || name.Contains("Load", StringComparison.OrdinalIgnoreCase);
	}

	[HarmonyPatch(typeof(NPCManager), "GetNPC")]
	[HarmonyPostfix]
	private static void NPCManager_GetNPC_Postfix(string id, ref NPC __result)
	{
		if ((Object)(object)__result != (Object)null || string.IsNullOrWhiteSpace(id))
		{
			return;
		}
		try
		{
			for (int i = 0; i < NPC.All.Count; i++)
			{
				NPC val = NPC.All[i]?.S1NPC;
				if ((Object)(object)val == (Object)null || string.IsNullOrEmpty(val.ID) || !val.ID.Equals(id, StringComparison.OrdinalIgnoreCase))
				{
					continue;
				}
				__result = val;
				try
				{
					List<NPC> nPCRegistry = NPCManager.NPCRegistry;
					if (nPCRegistry != null && !nPCRegistry.Contains(val))
					{
						nPCRegistry.Add(val);
					}
					break;
				}
				catch
				{
					break;
				}
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("NPCManager_GetNPC_Postfix: exception while backfilling registry for id '" + id + "': " + ex.Message);
		}
	}

	[HarmonyPatch(typeof(NPCMovement), "SetGravityMultiplier")]
	[HarmonyPrefix]
	private static bool NPCMovement_SetGravityMultiplier_Prefix(NPCMovement __instance, float multiplier)
	{
		return !(typeof(NPCMovement).GetField("ragdollForceComponents", BindingFlags.Instance | BindingFlags.NonPublic)?.GetValue(__instance) is List<ConstantForce> list) || list.ToArray().All((ConstantForce comp) => (Object)(object)comp != (Object)null);
	}

	[HarmonyPatch(typeof(NPCHealth), "Awake")]
	[HarmonyPrefix]
	private static bool NPCHealth_Awake_Prefix(NPCHealth __instance)
	{
		if (NetworkSingleton<TimeManager>.InstanceExists)
		{
			return true;
		}
		__instance.NetworkInitialize___Early();
		NPC component = ((Component)__instance).GetComponent<NPC>();
		FieldInfo field = typeof(NPCHealth).GetField("npc", BindingFlags.Instance | BindingFlags.NonPublic);
		if (field != null)
		{
			field.SetValue(__instance, component);
		}
		MethodInfo method = typeof(NPCHealth).GetMethod("SleepStart", BindingFlags.Instance | BindingFlags.NonPublic);
		MethodInfo method2 = typeof(NPCHealth).GetMethod("OnHourPass", BindingFlags.Instance | BindingFlags.NonPublic);
		if (method != null)
		{
			Action action = (Action)Delegate.CreateDelegate(typeof(Action), __instance, method);
			TimeManagerShim.Instance.onSleepStart = (Action)Delegate.Remove(TimeManagerShim.Instance.onSleepStart, action);
			TimeManagerShim.Instance.onSleepStart = (Action)Delegate.Combine(TimeManagerShim.Instance.onSleepStart, action);
		}
		if (method2 != null)
		{
			Action b = (Action)Delegate.CreateDelegate(typeof(Action), __instance, method2);
			TimeManagerShim.Instance.onHourPass = (Action)Delegate.Combine(TimeManagerShim.Instance.onHourPass, b);
		}
		__instance.NetworkInitialize__Late();
		return false;
	}

	[HarmonyPatch(typeof(Customer), "Awake")]
	[HarmonyPrefix]
	[HarmonyPriority(800)]
	private static void Customer_Awake_Prefix(Customer __instance)
	{
		try
		{
			object obj = ReflectionUtils.TryGetFieldOrProperty(__instance, "CurrentAddiction");
			if (obj != null && obj is float value)
			{
				if (_savedCurrentAddiction.ContainsKey(__instance))
				{
					_savedCurrentAddiction[__instance] = value;
				}
				else
				{
					_savedCurrentAddiction.Add(__instance, value);
				}
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("[NPCPatches] Customer_Awake_Prefix exception: " + ex.Message);
		}
	}

	[HarmonyPatch(typeof(Customer), "Awake")]
	[HarmonyPostfix]
	[HarmonyPriority(0)]
	private static void Customer_Awake_Postfix(Customer __instance)
	{
		try
		{
			if (_savedCurrentAddiction.TryGetValue(__instance, out var value))
			{
				if (ReflectionUtils.TryGetFieldOrProperty(__instance, "CurrentAddiction") is float num && Math.Abs(num - value) > 0.0001f)
				{
					ReflectionUtils.TrySetFieldOrProperty(__instance, "CurrentAddiction", value);
				}
				_savedCurrentAddiction.Remove(__instance);
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("[NPCPatches] Customer_Awake_Postfix exception: " + ex.Message);
		}
	}

	[HarmonyPatch(typeof(Dealer), "Load", new Type[]
	{
		typeof(DynamicSaveData),
		typeof(NPCData)
	})]
	[HarmonyPrefix]
	private static bool Dealer_Load_Prefix(Dealer __instance, DynamicSaveData dynamicData, NPCData npcData)
	{
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected O, but got Unknown
		if ((Object)(object)__instance == (Object)null)
		{
			return true;
		}
		string iD = ((NPC)__instance).ID;
		if (_loadingDealers.Contains(iD))
		{
			return true;
		}
		bool flag = FindWrapperForS1Npc((NPC)(object)__instance)?.IsCustomNPC ?? false;
		DealerData val = default(DealerData);
		if (!dynamicData.TryExtractBaseData<DealerData>(ref val))
		{
			Logger.Warning("[NPCPatches] Dealer_Load_Prefix: '" + iD + "' missing DealerData. Falling back to original.");
			return true;
		}
		bool flag2 = false;
		if (val.AssignedCustomerIDs != null && val.AssignedCustomerIDs.Length != 0)
		{
			string[] assignedCustomerIDs = val.AssignedCustomerIDs;
			foreach (string customerID in assignedCustomerIDs)
			{
				if (string.IsNullOrEmpty(customerID))
				{
					continue;
				}
				bool flag3 = NPC.All.Any((NPC n) => n.S1NPC?.ID == customerID);
				bool flag4 = false;
				try
				{
					List<NPC> nPCRegistry = NPCManager.NPCRegistry;
					if (nPCRegistry != null)
					{
						for (int num = 0; num < nPCRegistry.Count; num++)
						{
							if (nPCRegistry[num]?.ID == customerID)
							{
								flag4 = true;
								break;
							}
						}
					}
				}
				catch
				{
				}
				if (flag3 || !flag4)
				{
					flag2 = true;
					break;
				}
			}
		}
		if (!flag && !flag2)
		{
			return true;
		}
		_loadingDealers.Add(iD);
		try
		{
			if (!flag)
			{
				((NPC)__instance).Load(dynamicData, npcData);
			}
			DealerData val2 = default(DealerData);
			if (!dynamicData.TryExtractBaseData<DealerData>(ref val2))
			{
				return false;
			}
			if (val2.Recruited)
			{
				__instance.SetIsRecruited((NetworkConnection)null);
			}
			__instance.SetCash(val2.Cash);
			if (val2.AssignedCustomerIDs != null && val2.AssignedCustomerIDs.Length != 0)
			{
				MelonCoroutines.Start(DelayedCustomerAssignment(__instance, val2.AssignedCustomerIDs));
			}
			if (val2.ActiveContractGUIDs != null)
			{
				for (int num2 = 0; num2 < val2.ActiveContractGUIDs.Length; num2++)
				{
					if (!GUIDManager.IsGUIDValid(val2.ActiveContractGUIDs[num2]))
					{
						Logger.Warning("Invalid contract GUID: " + val2.ActiveContractGUIDs[num2]);
						continue;
					}
					Contract val3 = GUIDManager.GetObject<Contract>(new Guid(val2.ActiveContractGUIDs[num2]));
					if ((Object)(object)val3 != (Object)null)
					{
						Type typeFromHandle = typeof(Dealer);
						MethodInfo method = typeFromHandle.GetMethod("AddContract", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
						if (method != null)
						{
							method.Invoke(__instance, new object[1] { val3 });
						}
					}
				}
			}
			if (val2.HasBeenRecommended)
			{
				__instance.MarkAsRecommended();
			}
			if (val2.OverflowItems != null)
			{
				try
				{
					EnsureDealerOverflowSlots(__instance);
					object obj2 = ReflectionUtils.TryGetFieldOrProperty(__instance, "overflowSlots");
					if (obj2 != null)
					{
						PropertyInfo propertyInfo = obj2.GetType().GetProperty("Length") ?? obj2.GetType().GetProperty("Count");
						int num3 = ((propertyInfo != null) ? ((int)propertyInfo.GetValue(obj2)) : 0);
						if (num3 > 0)
						{
							ItemSlot[] array = (ItemSlot[])(object)new ItemSlot[num3];
							bool flag5 = false;
							if (obj2 is ItemSlot[] array2)
							{
								for (int num4 = 0; num4 < num3 && num4 < array2.Length; num4++)
								{
									ItemSlot val4 = array2[num4];
									if (val4 == null)
									{
										flag5 = true;
										val4 = new ItemSlot();
										val4.SetSlotOwner((IItemSlotOwner)(object)__instance);
										array2[num4] = val4;
									}
									array[num4] = val4;
								}
							}
							if (val2.OverflowItems != null && array != null && array.Length != 0)
							{
								val2.OverflowItems.LoadTo(array);
							}
						}
					}
				}
				catch (Exception ex)
				{
					Logger.Warning("Failed to load overflow items for dealer '" + (((NPC)(__instance?)).ID ?? "unknown") + "': " + ex.Message);
					Logger.Warning("Stack trace: " + ex.StackTrace);
				}
			}
		}
		catch (Exception ex2)
		{
			Logger.Warning("Dealer_Load_Prefix failed for '" + ((NPC)(__instance?)).ID + "': " + ex2.Message);
			Logger.Warning("Stack trace: " + ex2.StackTrace);
		}
		finally
		{
			_loadingDealers.Remove(iD);
		}
		return false;
	}

	[HarmonyPatch(typeof(NPCScheduleManager), "GetActionsTotallyOccurringWithinRange")]
	[HarmonyPrefix]
	private static bool NPCScheduleManager_GetActionsTotallyOccurringWithinRange_Prefix(NPCScheduleManager __instance, int min, int max, bool checkShouldStart, ref List<NPCAction> __result)
	{
		if ((Object)(object)__instance == (Object)null)
		{
			return true;
		}
		try
		{
			object obj = ReflectionUtils.TryGetFieldOrProperty(__instance, "ActionList");
			if (obj == null)
			{
				return true;
			}
			int num = 0;
			if (!(obj is List<NPCAction> { Count: var count } list))
			{
				return true;
			}
			List<NPCAction> list2 = new List<NPCAction>();
			for (int i = 0; i < count; i++)
			{
				NPCAction val = null;
				val = list[i];
				if (!((Object)(object)val == (Object)null) && !((Object)(object)((Component)val).gameObject == (Object)null) && ((Component)val).gameObject.activeInHierarchy && (!checkShouldStart || val.ShouldStart()) && TimeManager.IsGivenTimeWithinRange(val.StartTime, min, max) && TimeManager.IsGivenTimeWithinRange(val.GetEndTime(), min, max))
				{
					list2.Add(val);
				}
			}
			try
			{
				object obj2 = ReflectionUtils.TryGetFieldOrProperty(__instance, "orderByDescending");
				if (obj2 != null && obj2 is IComparer<NPCAction> comparer)
				{
					list2.Sort(comparer);
				}
			}
			catch
			{
			}
			__result = list2;
			return false;
		}
		catch (Exception ex)
		{
			Logger.Warning("NPCScheduleManager_GetActionsTotallyOccurringWithinRange_Prefix failed: " + ex.Message);
			Logger.Warning("Stack trace: " + ex.StackTrace);
			return true;
		}
	}

	[HarmonyPatch(typeof(NPCScheduleManager), "InitializeActions")]
	[HarmonyPrefix]
	private static bool NPCScheduleManager_InitializeActions_Prefix(NPCScheduleManager __instance)
	{
		if ((Object)(object)__instance == (Object)null)
		{
			return true;
		}
		try
		{
			NPCAction[] componentsInChildren = ((Component)__instance).gameObject.GetComponentsInChildren<NPCAction>(true);
			List<NPCAction> list = new List<NPCAction>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				if ((Object)(object)componentsInChildren[i] != (Object)null)
				{
					list.Add(componentsInChildren[i]);
				}
			}
			list.Sort(CompareNPCActions);
			if (!Application.isPlaying)
			{
				for (int j = 0; j < list.Count; j++)
				{
					NPCAction val = list[j];
					if ((Object)(object)val != (Object)null && (Object)(object)((Component)val).transform != (Object)null)
					{
						((Object)((Component)val).transform).name = val.GetName() + " (" + val.GetTimeDescription() + ")";
						((Component)val).transform.SetAsLastSibling();
					}
				}
			}
			if (!ReflectionUtils.TrySetFieldOrProperty(__instance, "ActionList", list))
			{
				Logger.Warning("NPCScheduleManager_InitializeActions_Prefix: Failed to set ActionList on " + (((object)__instance)?.GetType().Name ?? "null"));
				try
				{
					PropertyInfo property = ((object)__instance).GetType().GetProperty("ActionList", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
					FieldInfo field = ((object)__instance).GetType().GetField("ActionList", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
					Type obj = property?.PropertyType ?? field?.FieldType;
					Logger.Warning("ActionList member type: " + (obj?.FullName ?? "null") + ", list type: " + list.GetType().FullName);
				}
				catch
				{
				}
				return true;
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("NPCScheduleManager_InitializeActions_Prefix failed: " + ex.Message);
			Logger.Warning("Stack trace: " + ex.StackTrace);
			return true;
		}
		return false;
	}

	private static IEnumerator DelayedCustomerAssignment(Dealer dealer, string[] customerIDs)
	{
		yield return null;
		yield return null;
		yield return (object)new WaitForSeconds(0.1f);
		if ((Object)(object)dealer == (Object)null || customerIDs == null)
		{
			yield break;
		}
		try
		{
			_ = ((NPC)dealer).ID ?? ((Object)dealer).name ?? "<unknown>";
		}
		catch
		{
		}
		foreach (string customerID in customerIDs)
		{
			if (string.IsNullOrEmpty(customerID))
			{
				continue;
			}
			NPC npc = null;
			for (int retry = 0; retry < 5; retry++)
			{
				if (!((Object)(object)npc == (Object)null))
				{
					break;
				}
				try
				{
					npc = NPCManager.GetNPC(customerID);
				}
				catch (Exception ex)
				{
					Logger.Warning($"Exception finding customer NPC {customerID} (retry {retry}): {ex.Message}");
				}
				if ((Object)(object)npc == (Object)null && retry < 4)
				{
					yield return (object)new WaitForSeconds(0.1f);
				}
			}
			if ((Object)(object)npc == (Object)null)
			{
				Logger.Warning("Failed to find customer NPC with ID " + customerID + " after retries");
				continue;
			}
			Customer customer = null;
			try
			{
				customer = ((Component)npc).GetComponent<Customer>();
			}
			catch (Exception ex2)
			{
				Exception ex3 = ex2;
				Logger.Warning("Exception getting Customer component for " + customerID + ": " + ex3.Message);
			}
			if ((Object)(object)customer == (Object)null)
			{
				Logger.Warning("NPC " + npc.fullName + " (ID: " + customerID + ") is not a customer");
			}
			else
			{
				try
				{
					dealer.SendAddCustomer(customer.NPC.ID);
				}
				catch (Exception ex2)
				{
					Exception ex4 = ex2;
					Logger.Warning("Exception assigning customer " + customerID + " to dealer: " + ex4.Message);
				}
			}
		}
	}
}
