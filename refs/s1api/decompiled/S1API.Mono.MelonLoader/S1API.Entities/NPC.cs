using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using FishNet;
using FishNet.Managing;
using FishNet.Managing.Object;
using FishNet.Object;
using HarmonyLib;
using MelonLoader;
using S1API.Entities.Behaviour;
using S1API.Entities.Customer;
using S1API.Entities.Dealer;
using S1API.Entities.Interfaces;
using S1API.Entities.Relation;
using S1API.Entities.Schedule;
using S1API.Internal;
using S1API.Internal.Abstraction;
using S1API.Internal.Entities;
using S1API.Internal.Patches;
using S1API.Internal.Utils;
using S1API.Logging;
using S1API.Map;
using S1API.Messaging;
using S1API.Vehicles;
using ScheduleOne;
using ScheduleOne.AvatarFramework;
using ScheduleOne.Combat;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Map;
using ScheduleOne.Messaging;
using ScheduleOne.Money;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.Actions;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.NPCs.Relation;
using ScheduleOne.NPCs.Responses;
using ScheduleOne.NPCs.Schedules;
using ScheduleOne.Noise;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI;
using ScheduleOne.UI.Phone.ContactsApp;
using ScheduleOne.UI.WorldspacePopup;
using ScheduleOne.Vehicles;
using ScheduleOne.Vision;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace S1API.Entities;

public abstract class NPC : Saveable, IEntity, IHealth
{
	private static readonly Log Logger = new Log("NPC");

	private static readonly Dictionary<Type, GameObject> TypeToPrefab = new Dictionary<Type, GameObject>();

	private static readonly object TemplateLoadLock = new object();

	private static readonly Dictionary<Type, List<IScheduleActionSpec>> TypeToSchedulePlan = new Dictionary<Type, List<IScheduleActionSpec>>();

	private static readonly Dictionary<Type, Action<CustomerDataBuilder>> TypeToCustomerDefaults = new Dictionary<Type, Action<CustomerDataBuilder>>();

	internal static readonly Dictionary<Type, Action<NPCRelationshipDataBuilder>> TypeToRelationshipDefaults = new Dictionary<Type, Action<NPCRelationshipDataBuilder>>();

	private static readonly Dictionary<Type, Action<RandomInventoryItemsBuilder>> TypeToRandomInventoryDefaults = new Dictionary<Type, Action<RandomInventoryItemsBuilder>>();

	private static readonly Dictionary<Type, Action<DealerDataBuilder>> TypeToDealerDefaults = new Dictionary<Type, Action<DealerDataBuilder>>();

	private static readonly Dictionary<Type, (Vector3 position, Quaternion rotation)> TypeToSpawnPosition = new Dictionary<Type, (Vector3, Quaternion)>();

	private static readonly HashSet<Type> CustomerTypes = new HashSet<Type>();

	private static readonly HashSet<Type> DealerTypes = new HashSet<Type>();

	private static volatile bool _prefabsConfiguredForLocalProcess;

	private Avatar? _runtimeAvatar;

	protected readonly List<Response> Responses = new List<Response>();

	public static readonly List<NPC> All = new List<NPC>();

	internal readonly NPC S1NPC;

	internal readonly bool IsCustomNPC;

	private static readonly float DefaultPanicDuration = 20f;

	private static readonly bool DefaultRequiresRegionUnlocked = true;

	private readonly FieldInfo _panicField = AccessTools.Field(typeof(NPC), "PANIC_DURATION");

	private readonly FieldInfo _requiresRegionUnlockedField = AccessTools.Field(typeof(NPC), "RequiresRegionUnlocked");

	private readonly MethodInfo _unsettleMethod = AccessTools.Method(typeof(NPC), "SetUnsettled", (Type[])null, (Type[])null);

	private readonly MethodInfo _removePanicMethod = AccessTools.Method(typeof(NPC), "RemovePanicked", (Type[])null, (Type[])null);

	private NPCDialogue _dialogue;

	private NPCSchedule _schedule;

	private NPCInventory _inventory;

	private NPCCustomer _customer;

	private NPCDealer _dealer;

	private NPCRelationship _relationship;

	private bool _wasLoadedFromSave;

	private EUnlockType? _loadedUnlockType;

	private bool _relationshipDataAppliedFromPrefab;

	internal static bool PrefabsConfiguredForLocalProcess => _prefabsConfiguredForLocalProcess;

	public GameObject gameObject { get; }

	public Vector3 Position
	{
		get
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			return gameObject.transform.position;
		}
		set
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			S1NPC.Movement.Warp(value);
		}
	}

	public Transform Transform => gameObject.transform;

	public static bool CustomNpcsReady
	{
		get
		{
			return NPCPatches.CustomNpcsReady;
		}
		internal set
		{
			NPCPatches.CustomNpcsReady = value;
		}
	}

	public string FirstName
	{
		get
		{
			return S1NPC.FirstName;
		}
		set
		{
			S1NPC.FirstName = value;
		}
	}

	public string LastName
	{
		get
		{
			return S1NPC.LastName;
		}
		set
		{
			S1NPC.LastName = value;
		}
	}

	public string FullName => S1NPC.fullName;

	public string ID
	{
		get
		{
			return S1NPC.ID;
		}
		protected set
		{
			S1NPC.ID = value;
		}
	}

	public static string? NPCId => null;

	public Sprite Icon
	{
		get
		{
			return S1NPC.MugshotSprite;
		}
		set
		{
			S1NPC.MugshotSprite = value;
		}
	}

	public bool IsConscious => S1NPC.IsConscious;

	public bool IsInBuilding => S1NPC.isInBuilding;

	public bool IsInVehicle => S1NPC.IsInVehicle;

	public bool IsPanicking => S1NPC.IsPanicked;

	public bool IsUnsettled => S1NPC.isUnsettled;

	public bool IsVisible => S1NPC.isVisible;

	public virtual bool IsPhysical => false;

	public virtual bool IsDealer => false;

	public float Aggressiveness
	{
		get
		{
			return S1NPC.Aggression;
		}
		set
		{
			S1NPC.Aggression = value;
		}
	}

	public Region Region
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Expected I4, but got Unknown
			return (Region)S1NPC.Region;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				S1NPC.Region = (EMapRegion)value;
			}
			catch
			{
			}
		}
	}

	public float PanicDuration
	{
		get
		{
			return (_panicField != null) ? ((float)_panicField.GetValue(S1NPC)) : DefaultPanicDuration;
		}
		set
		{
			_panicField?.SetValue(S1NPC, value);
		}
	}

	public float Scale
	{
		get
		{
			return S1NPC.Scale;
		}
		set
		{
			S1NPC.SetScale(value);
		}
	}

	public bool IsKnockedOut => S1NPC.Health.IsKnockedOut;

	public bool RequiresRegionUnlocked
	{
		get
		{
			return _requiresRegionUnlockedField != null && (bool)_requiresRegionUnlockedField.GetValue(S1NPC);
		}
		set
		{
			_requiresRegionUnlockedField?.SetValue(S1NPC, value);
		}
	}

	public LandVehicle? CurrentVehicle => ((Object)(object)S1NPC.CurrentVehicle != (Object)null) ? new LandVehicle(S1NPC.CurrentVehicle) : null;

	public float CurrentHealth => S1NPC.Health.Health;

	public float MaxHealth
	{
		get
		{
			return S1NPC.Health.MaxHealth;
		}
		set
		{
			S1NPC.Health.MaxHealth = value;
		}
	}

	public bool IsDead => S1NPC.Health.IsDead;

	public bool IsInvincible
	{
		get
		{
			return S1NPC.Health.Invincible;
		}
		set
		{
			S1NPC.Health.Invincible = value;
		}
	}

	public NPCAppearance Appearance { get; private set; }

	public NPCMovement Movement => new NPCMovement(this);

	public CombatBehaviour CombatBehaviour => new CombatBehaviour(this);

	public NPCDialogue Dialogue => _dialogue ?? (_dialogue = new NPCDialogue(this));

	public NPCSchedule Schedule => _schedule ?? (_schedule = new NPCSchedule(this));

	public NPCInventory Inventory => _inventory ?? (_inventory = new NPCInventory(this));

	public NPCCustomer Customer => _customer ?? (_customer = new NPCCustomer(this));

	public NPCDealer Dealer => _dealer ?? (_dealer = new NPCDealer(this));

	public NPCRelationship Relationship => _relationship ?? (_relationship = new NPCRelationship(this));

	public bool ConversationCanBeHidden
	{
		get
		{
			return S1NPC.ConversationCanBeHidden;
		}
		set
		{
			S1NPC.ConversationCanBeHidden = value;
		}
	}

	internal bool RelationshipDataAppliedFromPrefab => _relationshipDataAppliedFromPrefab;

	public event Action OnDeath
	{
		add
		{
			EventHelper.AddListener(value, S1NPC.Health.onDie);
		}
		remove
		{
			EventHelper.RemoveListener(value, S1NPC.Health.onDie);
		}
	}

	public event Action OnInventoryChanged
	{
		add
		{
			EventHelper.AddListener(value, S1NPC.Inventory.onContentsChanged);
		}
		remove
		{
			EventHelper.RemoveListener(value, S1NPC.Inventory.onContentsChanged);
		}
	}

	private static GameObject InstantiateTemplateInstance(Type npcType, NPC owner)
	{
		GameObject orCreatePerNpcPrefab = GetOrCreatePerNpcPrefab(npcType, owner);
		NetworkObject val = orCreatePerNpcPrefab.GetComponent<NetworkObject>() ?? orCreatePerNpcPrefab.AddComponent<NetworkObject>();
		NetworkObject val2 = null;
		try
		{
			NetworkManager networkManager = InstanceFinder.NetworkManager;
			if ((Object)(object)networkManager != (Object)null)
			{
				PrefabObjects spawnablePrefabs = networkManager.SpawnablePrefabs;
				if ((Object)(object)spawnablePrefabs != (Object)null)
				{
					int objectCount = spawnablePrefabs.GetObjectCount();
					for (int i = 0; i < objectCount; i++)
					{
						NetworkObject val3 = spawnablePrefabs.GetObject(true, i);
						if ((Object)(object)val3 != (Object)null && (Object)(object)((Component)val3).gameObject != (Object)null && ((Object)((Component)val3).gameObject).name == ((Object)orCreatePerNpcPrefab).name)
						{
							val2 = val3;
							break;
						}
					}
				}
			}
		}
		catch
		{
		}
		GameObject val4 = ((val2 != null) ? ((Component)val2).gameObject : null) ?? orCreatePerNpcPrefab;
		GameObject val5 = Object.Instantiate<GameObject>(val4);
		try
		{
			NetworkManager networkManager2 = InstanceFinder.NetworkManager;
			bool flag = (Object)(object)networkManager2 != (Object)null && networkManager2.IsServer;
			NetworkObject component = val5.GetComponent<NetworkObject>();
			if (flag)
			{
				if ((Object)(object)component == (Object)null)
				{
					component = val5.AddComponent<NetworkObject>();
				}
			}
			else if ((Object)(object)component != (Object)null)
			{
				Object.Destroy((Object)(object)component);
			}
		}
		catch
		{
		}
		if (NetworkSingleton<NPCManager>.InstanceExists && (Object)(object)NetworkSingleton<NPCManager>.Instance.NPCContainer != (Object)null)
		{
			Transform nPCContainer = NetworkSingleton<NPCManager>.Instance.NPCContainer;
			if ((Object)(object)nPCContainer != (Object)null && (Object)(object)((Component)nPCContainer).gameObject != (Object)null && ((Component)nPCContainer).gameObject.activeInHierarchy)
			{
				val5.transform.SetParent(nPCContainer, false);
			}
		}
		((Object)val5).name = ((Object)orCreatePerNpcPrefab).name;
		return val5;
	}

	private static GameObject GetOrCreatePerNpcPrefab(Type npcType, NPC owner)
	{
		if (npcType == null)
		{
			throw new Exception("NPC type is null for prefab resolution.");
		}
		if (TypeToPrefab.TryGetValue(npcType, out GameObject value) && (Object)(object)value != (Object)null)
		{
			MarkPrefabsConfigured();
			return value;
		}
		lock (TemplateLoadLock)
		{
			if (TypeToPrefab.TryGetValue(npcType, out value) && (Object)(object)value != (Object)null)
			{
				MarkPrefabsConfigured();
				return value;
			}
			NetworkManager networkManager = InstanceFinder.NetworkManager;
			if ((Object)(object)networkManager == (Object)null)
			{
				throw new Exception("NetworkManager not found when resolving NPC prefab.");
			}
			PrefabObjects spawnablePrefabs = networkManager.SpawnablePrefabs;
			if ((Object)(object)spawnablePrefabs == (Object)null)
			{
				throw new Exception("SpawnablePrefabs not available on NetworkManager.");
			}
			NetworkObject val = null;
			int objectCount = spawnablePrefabs.GetObjectCount();
			bool flag = false;
			try
			{
				NPC nPC = (NPC)FormatterServices.GetUninitializedObject(npcType);
				flag = nPC.IsDealer;
			}
			catch
			{
				flag = IsDealerType(npcType);
			}
			if (flag)
			{
				for (int i = 0; i < objectCount; i++)
				{
					NetworkObject val2 = spawnablePrefabs.GetObject(true, i);
					if ((Object)(object)val2 != (Object)null && (Object)(object)((Component)val2).gameObject != (Object)null && ((Object)((Component)val2).gameObject).name == "Dealer")
					{
						val = val2;
						break;
					}
				}
				if ((Object)(object)val == (Object)null)
				{
					for (int j = 0; j < objectCount; j++)
					{
						NetworkObject val3 = spawnablePrefabs.GetObject(true, j);
						if ((Object)(object)val3 != (Object)null && (Object)(object)((Component)val3).gameObject != (Object)null && (Object)(object)((Component)val3).gameObject.GetComponent<Dealer>() != (Object)null)
						{
							val = val3;
							break;
						}
					}
				}
			}
			if ((Object)(object)val == (Object)null)
			{
				for (int k = 0; k < objectCount; k++)
				{
					NetworkObject val4 = spawnablePrefabs.GetObject(true, k);
					if ((Object)(object)val4 != (Object)null && (Object)(object)((Component)val4).gameObject != (Object)null && ((Object)((Component)val4).gameObject).name == "CivilianNPC")
					{
						val = val4;
						break;
					}
				}
			}
			if ((Object)(object)val == (Object)null)
			{
				for (int l = 0; l < objectCount; l++)
				{
					NetworkObject val5 = spawnablePrefabs.GetObject(true, l);
					if ((Object)(object)val5 != (Object)null && (Object)(object)((Component)val5).gameObject != (Object)null && (Object)(object)((Component)val5).gameObject.GetComponent<NPC>() != (Object)null)
					{
						val = val5;
						break;
					}
				}
			}
			if ((Object)(object)val == (Object)null)
			{
				string text = (flag ? "Dealer" : "CivilianNPC");
				string text2 = (flag ? "Dealer" : "NPC");
				throw new Exception("Failed to locate a suitable NPC spawnable prefab (" + text + " or any with " + text2 + " component).");
			}
			NetworkObject val6 = Object.Instantiate<NetworkObject>(val);
			string prefabNameForType = GetPrefabNameForType(npcType);
			((Object)((Component)val6).gameObject).name = prefabNameForType;
			try
			{
				if ((Object)(object)val6 != (Object)null && (Object)(object)((Component)val6).gameObject != (Object)null)
				{
					((Component)val6).gameObject.SetActive(false);
					Dealer component = ((Component)val6).gameObject.GetComponent<Dealer>();
					NPC val7 = (NPC)(((Object)(object)component != (Object)null) ? ((object)component) : ((object)((Component)val6).gameObject.GetComponent<NPC>()));
					if ((Object)(object)val7 != (Object)null)
					{
						List<NPC> nPCRegistry = NPCManager.NPCRegistry;
						if (nPCRegistry != null && nPCRegistry.Count > 0)
						{
							for (int num = nPCRegistry.Count - 1; num >= 0; num--)
							{
								if ((Object)(object)nPCRegistry[num] == (Object)(object)val7)
								{
									nPCRegistry.RemoveAt(num);
									break;
								}
							}
						}
					}
				}
			}
			catch
			{
			}
			NPCPrefabBuilder builder = new NPCPrefabBuilder(((Component)val6).gameObject, npcType);
			if (owner != null)
			{
				owner.ConfigurePrefab(builder);
			}
			else
			{
				InvokeConfigurePrefabWithoutInstance(npcType, builder);
			}
			try
			{
				EnsureScheduleActionsOnPrefab(((Component)val6).gameObject);
			}
			catch
			{
			}
			if (owner == null)
			{
				try
				{
					if (IsCustomerType(npcType))
					{
						Customer val8 = ((Component)val6).gameObject.GetComponent<Customer>();
						if ((Object)(object)val8 == (Object)null)
						{
							val8 = ((Component)val6).gameObject.AddComponent<Customer>();
						}
						Action<CustomerDataBuilder> customerDefaultsForType = GetCustomerDefaultsForType(npcType);
						if (customerDefaultsForType != null && (Object)(object)val8 != (Object)null)
						{
							CustomerData data = BuildCustomerDefaultsForType(npcType);
							TrySetCustomerDataOnComponent(val8, data);
						}
					}
					if (IsDealerType(npcType))
					{
						Dealer component2 = ((Component)val6).gameObject.GetComponent<Dealer>();
						if ((Object)(object)component2 != (Object)null)
						{
							DealerDataBuilder.DealerConfigData dealerConfigData = BuildDealerDefaultsForType(npcType);
							if (dealerConfigData != null)
							{
								TryApplyDealerDefaults(component2, dealerConfigData);
							}
						}
						else
						{
							Logger.Warning("[S1API] NPC " + npcType.Name + " requested dealer functionality but prefab does not have Dealer component. EnsureDealer() was called before prefab creation.");
						}
					}
				}
				catch
				{
				}
			}
			try
			{
				if ((Object)(object)spawnablePrefabs != (Object)null)
				{
					bool flag2 = false;
					int objectCount2 = spawnablePrefabs.GetObjectCount();
					for (int m = 0; m < objectCount2; m++)
					{
						NetworkObject val9 = spawnablePrefabs.GetObject(true, m);
						if ((Object)(object)val9 != (Object)null && (Object)(object)((Component)val9).gameObject != (Object)null && ((Object)((Component)val9).gameObject).name == prefabNameForType)
						{
							flag2 = true;
							break;
						}
					}
					if (!flag2)
					{
						spawnablePrefabs.AddObject(val6, false);
					}
				}
			}
			catch (Exception ex)
			{
				Logger.Warning("[S1API] Failed to register " + prefabNameForType + " in SpawnablePrefabs: " + ex.Message);
			}
			NPCPrefabContainer.OrganizePrefab(((Component)val6).gameObject, npcType.Name);
			TypeToPrefab[npcType] = ((Component)val6).gameObject;
			MarkPrefabsConfigured();
			return ((Component)val6).gameObject;
		}
	}

	private static void InvokeConfigurePrefabWithoutInstance(Type npcType, NPCPrefabBuilder builder)
	{
		if (npcType == null || builder == null)
		{
			return;
		}
		MethodInfo method = npcType.GetMethod("ConfigurePrefab", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		if (method == null || method.DeclaringType == typeof(NPC))
		{
			return;
		}
		NPC nPC = null;
		try
		{
			nPC = (NPC)FormatterServices.GetUninitializedObject(npcType);
			method.Invoke(nPC, new object[1] { builder });
		}
		finally
		{
			nPC = null;
		}
	}

	private static string GetPrefabNameForType(Type npcType)
	{
		string text = ((npcType != null) ? npcType.Name : "UnknownNPC");
		return "S1API_" + text;
	}

	internal static NPC? CreateWrapperForNetworkSpawnedNPC(NPC baseNpc)
	{
		if ((Object)(object)baseNpc == (Object)null)
		{
			return null;
		}
		try
		{
			NPCPrefabIdentity component = ((Component)baseNpc).GetComponent<NPCPrefabIdentity>();
			string text = ((Object)((Component)baseNpc).gameObject).name;
			if (text.EndsWith("(Clone)"))
			{
				text = text.Substring(0, text.Length - 7);
			}
			if (!text.StartsWith("S1API_", StringComparison.Ordinal) && (Object)(object)component == (Object)null)
			{
				return null;
			}
			string text2 = (text.StartsWith("S1API_", StringComparison.Ordinal) ? text.Substring(6) : null);
			if (string.IsNullOrEmpty(text2))
			{
				return null;
			}
			Type type = null;
			Type typeFromHandle = typeof(NPC);
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			for (int i = 0; i < assemblies.Length && type == null; i++)
			{
				Assembly assembly = assemblies[i];
				if (assembly == typeFromHandle.Assembly)
				{
					continue;
				}
				Type[] types;
				try
				{
					types = assembly.GetTypes();
				}
				catch
				{
					continue;
				}
				foreach (Type type2 in types)
				{
					if (!(type2 == null) && !type2.IsAbstract && typeFromHandle.IsAssignableFrom(type2) && type2.Name == text2)
					{
						type = type2;
						break;
					}
				}
			}
			if (type == null)
			{
				return null;
			}
			for (int k = 0; k < All.Count; k++)
			{
				NPC nPC = All[k];
				if (nPC != null && (Object)(object)nPC.S1NPC == (Object)(object)baseNpc)
				{
					return nPC;
				}
			}
			NPC nPC2 = (NPC)FormatterServices.GetUninitializedObject(type);
			bool flag = ReflectionUtils.TrySetFieldOrProperty(nPC2, "S1NPC", baseNpc);
			bool flag2 = ReflectionUtils.TrySetFieldOrProperty(nPC2, "IsCustomNPC", true);
			bool flag3 = false;
			FieldInfo[] allFields = ReflectionUtils.GetAllFields(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			foreach (FieldInfo fieldInfo in allFields)
			{
				if ((fieldInfo.Name == "<gameObject>k__BackingField" || fieldInfo.Name == "gameObject") && fieldInfo.FieldType == typeof(GameObject))
				{
					try
					{
						fieldInfo.SetValue(nPC2, ((Component)baseNpc).gameObject);
						flag3 = true;
					}
					catch (Exception ex)
					{
						Logger.Warning("CreateWrapperForNetworkSpawnedNPC: Exception setting gameObject backing field '" + fieldInfo.Name + "': " + ex.Message);
						continue;
					}
					break;
				}
			}
			if (!flag3)
			{
				flag3 = ReflectionUtils.TrySetFieldOrProperty(nPC2, "gameObject", ((Component)baseNpc).gameObject);
			}
			if (!flag)
			{
				Logger.Warning("CreateWrapperForNetworkSpawnedNPC: Could not set S1NPC field/property for '" + baseNpc.ID + "'.");
				return null;
			}
			if (!flag3)
			{
				Logger.Warning("CreateWrapperForNetworkSpawnedNPC: Could not set gameObject field/property for '" + baseNpc.ID + "'. Tried backing field and property setter.");
				return null;
			}
			if ((Object)(object)nPC2.S1NPC != (Object)(object)baseNpc)
			{
				Logger.Warning("CreateWrapperForNetworkSpawnedNPC: S1NPC field not set correctly for '" + baseNpc.ID + "'.");
				return null;
			}
			if ((Object)(object)nPC2.gameObject != (Object)(object)((Component)baseNpc).gameObject)
			{
				Logger.Warning("CreateWrapperForNetworkSpawnedNPC: gameObject field not set correctly for '" + baseNpc.ID + "'.");
				return null;
			}
			InitializeWrapperStateFromNetworkSpawn(nPC2, baseNpc);
			All.Add(nPC2);
			return nPC2;
		}
		catch (Exception ex2)
		{
			Logger.Warning("CreateWrapperForNetworkSpawnedNPC: Exception creating wrapper for '" + (baseNpc?.ID ?? "<null>") + "': " + ex2.Message);
			Logger.Warning("Stack trace: " + ex2.StackTrace);
			return null;
		}
	}

	private static void InitializeWrapperStateFromNetworkSpawn(NPC wrapper, NPC baseNpc)
	{
		if (wrapper == null || (Object)(object)baseNpc == (Object)null)
		{
			return;
		}
		try
		{
			object obj = baseNpc.Avatar;
			if (obj == null)
			{
				GameObject obj2 = ((Component)baseNpc).gameObject;
				obj = ((obj2 != null) ? obj2.GetComponentInChildren<Avatar>(true) : null);
			}
			wrapper.Appearance = new NPCAppearance(wrapper, wrapper._runtimeAvatar = (Avatar?)obj);
			wrapper.RestoreRuntimeAvatarAppearance();
			wrapper.RefreshMessagingIcons();
			try
			{
				List<NPC> nPCRegistry = NPCManager.NPCRegistry;
				if (nPCRegistry != null && !nPCRegistry.Contains(baseNpc))
				{
					nPCRegistry.Add(baseNpc);
				}
			}
			catch
			{
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("InitializeWrapperStateFromNetworkSpawn: Failed for '" + (baseNpc?.ID ?? "<null>") + "': " + ex.Message);
		}
	}

	public void RefreshMessagingIcons()
	{
		try
		{
			Sprite icon = Icon;
			if (!((Object)(object)icon == (Object)null))
			{
				NPC s1NPC = S1NPC;
				MSGConversation val = ((s1NPC != null) ? s1NPC.MSGConversation : null);
				if (val != null)
				{
					RectTransform rect = val.entry ?? ResolveConversationRect(val, "entry");
					RectTransform rect2 = ResolveConversationRect(val, "container");
					TryApplyIconToRect(rect, icon);
					TryApplyIconToRect(rect2, icon);
				}
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("RefreshMessagingIcons failed for '" + (S1NPC?.ID ?? "<null>") + "': " + ex.Message);
		}
	}

	private void TryApplyIconToRect(RectTransform rect, Sprite sprite)
	{
		if (!((Object)(object)rect == (Object)null) && !((Object)(object)sprite == (Object)null))
		{
			ApplyIconToPath(rect, null, sprite);
			ApplyIconToPath(rect, "Icon", sprite);
			ApplyIconToPath(rect, "IconMask/Icon", sprite);
		}
	}

	private static void ApplyIconToPath(RectTransform root, string childPath, Sprite sprite)
	{
		if ((Object)(object)root == (Object)null || (Object)(object)sprite == (Object)null)
		{
			return;
		}
		Transform val = (Transform)(string.IsNullOrEmpty(childPath) ? ((object)root) : ((object)((Transform)root).Find(childPath)));
		if (!((Object)(object)val == (Object)null))
		{
			Image component = ((Component)val).GetComponent<Image>();
			if (!((Object)(object)component == (Object)null))
			{
				component.sprite = sprite;
				((Behaviour)component).enabled = true;
			}
		}
	}

	private static RectTransform ResolveConversationRect(MSGConversation convo, string memberName)
	{
		if (convo == null || string.IsNullOrEmpty(memberName))
		{
			return null;
		}
		object obj = ReflectionUtils.TryGetFieldOrProperty(convo, memberName);
		return (RectTransform)((obj is RectTransform) ? obj : null);
	}

	internal static void RegisterSchedulePlanForType(Type npcType, List<IScheduleActionSpec> specs)
	{
		if (!(npcType == null) && specs != null)
		{
			TypeToSchedulePlan[npcType] = specs;
		}
	}

	public static void PreRegisterPrefabForType(Type npcType)
	{
		try
		{
			GetOrCreatePerNpcPrefab(npcType, null);
		}
		catch (Exception ex)
		{
			Logger.Warning("[S1API] Failed to pre-register NPC prefab for " + npcType?.Name + ": " + ex.Message);
		}
	}

	public static void PreRegisterAllNpcPrefabs()
	{
		try
		{
			NetworkManager networkManager = InstanceFinder.NetworkManager;
			PrefabObjects val = ((networkManager != null) ? networkManager.SpawnablePrefabs : null);
			if ((Object)(object)val == (Object)null)
			{
				return;
			}
			Type typeFromHandle = typeof(NPC);
			Assembly assembly = typeFromHandle.Assembly;
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			foreach (Assembly assembly2 in assemblies)
			{
				Type[] types;
				try
				{
					types = assembly2.GetTypes();
				}
				catch
				{
					continue;
				}
				foreach (Type type in types)
				{
					if (!(type == null) && !type.IsAbstract && typeFromHandle.IsAssignableFrom(type) && !(type.Assembly == assembly))
					{
						PreRegisterPrefabForType(type);
					}
				}
			}
			MarkPrefabsConfigured();
		}
		catch (Exception ex)
		{
			Logger.Error("[S1API] PreRegisterAllNpcPrefabs failed: " + ex.Message);
			Logger.Error("[S1API] Stack Trace: " + ex.StackTrace);
		}
	}

	internal static void RegisterCustomerDefaultsForType(Type npcType, Action<CustomerDataBuilder> configure)
	{
		if (!(npcType == null) && configure != null)
		{
			TypeToCustomerDefaults[npcType] = configure;
		}
	}

	internal static void RegisterCustomerType(Type npcType)
	{
		if (!(npcType == null))
		{
			CustomerTypes.Add(npcType);
		}
	}

	internal static bool IsCustomerType(Type npcType)
	{
		if (npcType == null)
		{
			return false;
		}
		return CustomerTypes.Contains(npcType);
	}

	internal static bool HasCustomerDefaultsForType(Type npcType)
	{
		if (npcType == null)
		{
			return false;
		}
		Action<CustomerDataBuilder> value;
		return TypeToCustomerDefaults.TryGetValue(npcType, out value) && value != null;
	}

	internal static Action<CustomerDataBuilder> GetCustomerDefaultsForType(Type npcType)
	{
		if (npcType == null)
		{
			return null;
		}
		TypeToCustomerDefaults.TryGetValue(npcType, out Action<CustomerDataBuilder> value);
		return value;
	}

	internal static CustomerData BuildCustomerDefaultsForType(Type npcType)
	{
		Action<CustomerDataBuilder> customerDefaultsForType = GetCustomerDefaultsForType(npcType);
		if (customerDefaultsForType == null)
		{
			return null;
		}
		CustomerDataBuilder customerDataBuilder = new CustomerDataBuilder();
		customerDefaultsForType(customerDataBuilder);
		return customerDataBuilder.BuildInternal();
	}

	internal static bool TrySetCustomerDataOnComponent(Customer customerComponent, CustomerData data)
	{
		if ((Object)(object)customerComponent == (Object)null || (Object)(object)data == (Object)null)
		{
			return false;
		}
		try
		{
			typeof(Customer).GetField("customerData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)?.SetValue(customerComponent, data);
			typeof(Customer).GetField("currentAffinityData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)?.SetValue(customerComponent, data.DefaultAffinityData);
			return true;
		}
		catch
		{
			return false;
		}
	}

	internal static bool TryApplyDealerDefaults(Dealer dealerComponent, DealerDataBuilder.DealerConfigData data)
	{
		if ((Object)(object)dealerComponent == (Object)null || data == null)
		{
			return false;
		}
		try
		{
			string empty = string.Empty;
			try
			{
				empty = ((NPC)dealerComponent).ID ?? ((dealerComponent != null) ? ((Object)dealerComponent).name : null) ?? "<unknown-dealer>";
			}
			catch
			{
				empty = "<unknown-dealer>";
			}
			dealerComponent.SigningFee = data.SigningFee;
			dealerComponent.Cut = data.Cut;
			FieldInfo field = typeof(Dealer).GetField("DealerType", BindingFlags.Instance | BindingFlags.Public);
			if (field != null)
			{
				object value = Enum.Parse(typeof(EDealerType), data.DealerType.ToString());
				field.SetValue(dealerComponent, value);
			}
			dealerComponent.SellInsufficientQualityItems = data.SellInsufficientQualityItems;
			dealerComponent.SellExcessQualityItems = data.SellExcessQualityItems;
			string text = null;
			if (data.Home != null)
			{
				text = data.Home.Name;
			}
			else if (!string.IsNullOrEmpty(data.HomeName))
			{
				text = data.HomeName;
			}
			if (!string.IsNullOrEmpty(text))
			{
				NPCPrefabIdentity component = ((Component)dealerComponent).gameObject.GetComponent<NPCPrefabIdentity>();
				if ((Object)(object)component != (Object)null)
				{
					component.DealerHomeBuildingName = text;
					string text2 = ((Object)((Component)dealerComponent).gameObject).name;
					if (text2.EndsWith("(Clone)"))
					{
						text2 = text2.Substring(0, text2.Length - 7);
					}
					component.RegisterToStaticCache(text2);
				}
				else
				{
					Logger.Warning("[NPC] TryApplyDealerDefaults: NPCPrefabIdentity component not found on " + ((Object)((Component)dealerComponent).gameObject).name + " for dealer " + empty + ". Building name '" + text + "' will not be stored.");
				}
			}
			else
			{
				Logger.Warning(string.Format("[NPC] TryApplyDealerDefaults: No building name to store for dealer {0}. Home={1}, HomeName={2}", empty, data.Home != null, data.HomeName ?? "null"));
			}
			return true;
		}
		catch (Exception ex)
		{
			Logger.Error("[NPC] TryApplyDealerDefaults: Exception applying dealer defaults: " + ex.Message);
			Logger.Error("[NPC] Stack trace: " + ex.StackTrace);
			return false;
		}
	}

	internal static void RegisterRelationshipDefaultsForType(Type npcType, Action<NPCRelationshipDataBuilder> configure)
	{
		if (!(npcType == null) && configure != null)
		{
			TypeToRelationshipDefaults[npcType] = configure;
		}
	}

	internal static void RegisterDealerDefaultsForType(Type npcType, Action<DealerDataBuilder> configure)
	{
		if (!(npcType == null) && configure != null)
		{
			TypeToDealerDefaults[npcType] = configure;
		}
	}

	internal static void RegisterDealerType(Type npcType)
	{
		if (!(npcType == null))
		{
			DealerTypes.Add(npcType);
		}
	}

	internal static bool IsDealerType(Type npcType)
	{
		if (npcType == null)
		{
			return false;
		}
		return DealerTypes.Contains(npcType);
	}

	internal static bool HasDealerDefaultsForType(Type npcType)
	{
		if (npcType == null)
		{
			return false;
		}
		Action<DealerDataBuilder> value;
		return TypeToDealerDefaults.TryGetValue(npcType, out value) && value != null;
	}

	internal static Action<DealerDataBuilder> GetDealerDefaultsForType(Type npcType)
	{
		if (npcType == null)
		{
			return null;
		}
		TypeToDealerDefaults.TryGetValue(npcType, out Action<DealerDataBuilder> value);
		return value;
	}

	internal static DealerDataBuilder.DealerConfigData BuildDealerDefaultsForType(Type npcType)
	{
		Action<DealerDataBuilder> dealerDefaultsForType = GetDealerDefaultsForType(npcType);
		if (dealerDefaultsForType == null)
		{
			return null;
		}
		DealerDataBuilder dealerDataBuilder = new DealerDataBuilder();
		dealerDefaultsForType(dealerDataBuilder);
		return dealerDataBuilder.BuildInternal();
	}

	internal static void RegisterRandomInventoryDefaultsForType(Type npcType, Action<RandomInventoryItemsBuilder> configure)
	{
		if (!(npcType == null) && configure != null)
		{
			TypeToRandomInventoryDefaults[npcType] = configure;
		}
	}

	internal static bool HasRandomInventoryDefaultsForType(Type npcType)
	{
		if (npcType == null)
		{
			return false;
		}
		Action<RandomInventoryItemsBuilder> value;
		return TypeToRandomInventoryDefaults.TryGetValue(npcType, out value) && value != null;
	}

	internal static Action<RandomInventoryItemsBuilder> GetRandomInventoryDefaultsForType(Type npcType)
	{
		if (npcType == null)
		{
			return null;
		}
		TypeToRandomInventoryDefaults.TryGetValue(npcType, out Action<RandomInventoryItemsBuilder> value);
		return value;
	}

	internal static RandomInventoryItemsBuilder.InventoryDefaultsData BuildRandomInventoryDefaultsForType(Type npcType)
	{
		Action<RandomInventoryItemsBuilder> randomInventoryDefaultsForType = GetRandomInventoryDefaultsForType(npcType);
		if (randomInventoryDefaultsForType == null)
		{
			return null;
		}
		RandomInventoryItemsBuilder randomInventoryItemsBuilder = new RandomInventoryItemsBuilder();
		randomInventoryDefaultsForType(randomInventoryItemsBuilder);
		return randomInventoryItemsBuilder.BuildInternal();
	}

	internal static void RegisterSpawnPositionForType(Type npcType, Vector3 position, Quaternion rotation)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		if (!(npcType == null))
		{
			TypeToSpawnPosition[npcType] = (position, rotation);
		}
	}

	private static void MarkPrefabsConfigured()
	{
		_prefabsConfiguredForLocalProcess = true;
	}

	protected NPC()
	{
		IsCustomNPC = true;
		gameObject = InstantiateTemplateInstance(GetType(), this);
		gameObject.SetActive(false);
		NPC component = gameObject.GetComponent<NPC>();
		if ((Object)(object)component == (Object)null)
		{
			throw new Exception("NPC template is missing the core ScheduleOne.NPCs.NPC component.");
		}
		S1NPC = component;
		Avatar runtimeAvatar = S1NPC.Avatar ?? gameObject.GetComponentInChildren<Avatar>(true);
		_runtimeAvatar = runtimeAvatar;
		NPCPrefabIdentity component2 = gameObject.GetComponent<NPCPrefabIdentity>();
		string text = null;
		string text2 = null;
		string text3 = null;
		Sprite val = null;
		if ((Object)(object)component2 != (Object)null)
		{
			text = component2.Id;
			text2 = component2.FirstName;
			text3 = component2.LastName;
			val = component2.Icon;
		}
		if (!string.IsNullOrEmpty(text))
		{
			S1NPC.ID = text;
		}
		if (!string.IsNullOrEmpty(text2))
		{
			S1NPC.FirstName = text2;
		}
		if (!string.IsNullOrEmpty(text3))
		{
			S1NPC.LastName = text3;
		}
		else
		{
			S1NPC.hasLastName = false;
		}
		if ((Object)(object)val != (Object)null)
		{
			S1NPC.MugshotSprite = val;
		}
		if ((Object)(object)S1NPC.MugshotSprite == (Object)null)
		{
			S1NPC.MugshotSprite = ((App<ContactsApp>)(object)PlayerSingleton<ContactsApp>.Instance).AppIcon;
		}
		S1NPC.BakedGUID = Guid.NewGuid().ToString();
		EnsureMessageConversationReady(resetDefaults: true);
		InitializeHealthComponent();
		InitializeAwarenessComponent();
		InitializeBehaviourComponents();
		InitializeVisionComponents();
		InitializeInteractables();
		InitializeInventoryComponent();
		InitializeRelationshipData();
		InitializeNetworkBehaviours();
		Appearance = new NPCAppearance(this, _runtimeAvatar);
		RestoreRuntimeAvatarAppearance();
		((Object)gameObject).name = S1NPC.FirstName ?? "UnknownNPC";
		if (!NPCManager.NPCRegistry.Contains(S1NPC))
		{
			NPCManager.NPCRegistry.Add(S1NPC);
		}
		All.Add(this);
	}

	[Obsolete("Use the parameterless constructor and configure identity via ConfigurePrefab with NPCPrefabBuilder.WithIdentity. This constructor is provided for backwards compatibility with non-physical NPCs.")]
	protected NPC(string id, string? firstName, string? lastName, Sprite? icon = null)
		: this()
	{
		bool flag = !string.IsNullOrEmpty(id);
		bool flag2 = !string.IsNullOrEmpty(firstName);
		bool flag3 = !string.IsNullOrEmpty(lastName);
		if (flag)
		{
			S1NPC.ID = id;
		}
		if (flag2)
		{
			S1NPC.FirstName = firstName;
		}
		if (flag3)
		{
			S1NPC.LastName = lastName;
		}
		else
		{
			S1NPC.hasLastName = false;
		}
		if ((Object)(object)icon != (Object)null)
		{
			S1NPC.MugshotSprite = icon;
		}
		NPCPrefabIdentity component = gameObject.GetComponent<NPCPrefabIdentity>();
		if ((Object)(object)component != (Object)null)
		{
			if (flag)
			{
				component.Id = id;
			}
			if (flag2)
			{
				component.FirstName = firstName;
			}
			if (flag3)
			{
				component.LastName = lastName;
			}
			if ((Object)(object)icon != (Object)null)
			{
				component.Icon = icon;
			}
			component.RegisterToStaticCache(((Object)gameObject).name);
		}
		if ((Object)(object)S1NPC.MugshotSprite == (Object)null)
		{
			S1NPC.MugshotSprite = ((App<ContactsApp>)(object)PlayerSingleton<ContactsApp>.Instance).AppIcon;
		}
		string text = S1NPC.FirstName;
		if (string.IsNullOrEmpty(text))
		{
			text = (flag ? id : "UnknownNPC");
		}
		((Object)gameObject).name = text;
		if (S1NPC.MSGConversation == null)
		{
			return;
		}
		try
		{
			string value = S1NPC.fullName;
			if (string.IsNullOrEmpty(value))
			{
				value = (flag2 ? firstName : (flag ? id : "Unknown"));
			}
			ReflectionUtils.TrySetFieldOrProperty(S1NPC.MSGConversation, "contactName", value);
			RefreshMessagingIcons();
			MethodInfo method = typeof(MSGConversation).GetMethod("SetIsKnown", BindingFlags.Instance | BindingFlags.Public);
			if (method != null)
			{
				bool flag4 = !(ReflectionUtils.TryGetFieldOrProperty(S1NPC.MSGConversation, "IsSenderKnown") is bool flag5) || flag5;
				method.Invoke(S1NPC.MSGConversation, new object[1] { flag4 });
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("Failed to update MSGConversation contactName for '" + (S1NPC?.ID ?? "<null>") + "': " + ex.Message);
		}
	}

	protected virtual void ConfigurePrefab(NPCPrefabBuilder builder)
	{
	}

	protected virtual void OnResponseLoaded(Response response)
	{
	}

	protected override void OnCreated()
	{
		Appearance.GenerateMugshot();
		RestoreRuntimeAvatarAppearance();
		if ((Object)(object)S1NPC.Movement == (Object)null)
		{
			S1NPC.Movement = gameObject.GetComponent<NPCMovement>();
		}
		((Behaviour)S1NPC.Movement).enabled = true;
	}

	internal void EnsureMessageConversationReady(bool resetDefaults)
	{
		try
		{
			List<EConversationCategory> categories = (resetDefaults ? ResetConversationCategoriesToDefaults() : EnsureConversationCategoriesInitialized());
			EnsureMessageConversationInstance(categories);
		}
		catch (Exception ex)
		{
			Logger.Warning("EnsureMessageConversationReady exception for '" + (S1NPC?.ID ?? "<null>") + "': " + ex.Message);
		}
	}

	private List<EConversationCategory> EnsureConversationCategoriesInitialized()
	{
		List<EConversationCategory> list = S1NPC.ConversationCategories;
		if (list == null)
		{
			list = new List<EConversationCategory>();
			S1NPC.ConversationCategories = list;
		}
		if (list.Count == 0)
		{
			ResetConversationCategoriesToDefaults(list);
		}
		return list;
	}

	private List<EConversationCategory> ResetConversationCategoriesToDefaults()
	{
		List<EConversationCategory> list = S1NPC.ConversationCategories;
		if (list == null)
		{
			list = new List<EConversationCategory>();
			S1NPC.ConversationCategories = list;
		}
		else
		{
			list.Clear();
		}
		ResetConversationCategoriesToDefaults(list);
		return list;
	}

	private void ResetConversationCategoriesToDefaults(List<EConversationCategory> categories)
	{
		if (categories != null)
		{
			if (ShouldUseDealerCategory())
			{
				categories.Add((EConversationCategory)2);
			}
			else
			{
				categories.Add((EConversationCategory)0);
			}
		}
	}

	private bool ShouldUseDealerCategory()
	{
		bool flag = false;
		try
		{
			flag = IsDealer;
		}
		catch
		{
		}
		if (!flag)
		{
			try
			{
				flag = IsDealerType(GetType());
			}
			catch
			{
			}
		}
		return flag;
	}

	private void EnsureMessageConversationInstance(List<EConversationCategory> categories)
	{
		if ((Object)(object)S1NPC == (Object)null)
		{
			return;
		}
		if (S1NPC.MSGConversation == null)
		{
			AccessTools.Method(typeof(NPC), "CreateMessageConversation", (Type[])null, (Type[])null)?.Invoke(S1NPC, null);
			if (S1NPC.MSGConversation == null)
			{
				Logger.Warning("EnsureMessageConversationInstance: creation failed for '" + (S1NPC?.ID ?? "<null>") + "'.");
			}
		}
		MSGConversation mSGConversation = S1NPC.MSGConversation;
		if (mSGConversation == null)
		{
			Logger.Warning("EnsureMessageConversationInstance: conversation still null for '" + (S1NPC?.ID ?? "<null>") + "'.");
			return;
		}
		if (categories == null)
		{
			Logger.Warning("EnsureMessageConversationInstance: categories null for '" + (S1NPC?.ID ?? "<null>") + "'.");
			return;
		}
		try
		{
			mSGConversation.SetCategories(categories);
		}
		catch (Exception ex)
		{
			Logger.Warning("EnsureMessageConversationInstance: failed to apply categories for '" + (S1NPC?.ID ?? "<null>") + "': " + ex.Message);
		}
	}

	private static bool SafeIsServer()
	{
		try
		{
			NetworkManager networkManager = InstanceFinder.NetworkManager;
			return (Object)(object)networkManager != (Object)null && networkManager.IsServer;
		}
		catch
		{
			return false;
		}
	}

	public void Revive()
	{
		S1NPC.Health.Revive();
	}

	public void Damage(int amount)
	{
		if (amount > 0)
		{
			S1NPC.Health.TakeDamage((float)amount, true);
		}
	}

	public void Heal(int amount)
	{
		if (amount > 0)
		{
			float num = Mathf.Min((float)amount, S1NPC.Health.MaxHealth - S1NPC.Health.Health);
			S1NPC.Health.TakeDamage(0f - num, false);
		}
	}

	public void Kill()
	{
		S1NPC.Health.TakeDamage(S1NPC.Health.MaxHealth, true);
	}

	public void Unsettle(float duration)
	{
		_unsettleMethod.Invoke(S1NPC, new object[1] { duration });
	}

	public void LerpScale(float scale, float lerpTime)
	{
		S1NPC.SetScale(scale, lerpTime);
	}

	public void Panic()
	{
		S1NPC.SetPanicked();
	}

	public void StopPanicking()
	{
		_removePanicMethod.Invoke(S1NPC, new object[0]);
	}

	public void KnockOut()
	{
		S1NPC.Health.KnockOut();
	}

	public void Goto(Vector3 position)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		S1NPC.Movement.SetDestination(position);
	}

	public void SendTextMessage(string message, Response[]? responses = null, float responseDelay = 1f, bool network = true)
	{
		if (S1NPC.MSGConversation == null)
		{
			Logger.Warning("SendTextMessage: MSGConversation null before send for '" + S1NPC.ID + "'. Trying to ensure.");
			EnsureMessageConversationReady(resetDefaults: false);
		}
		S1NPC.SendTextMessage(message);
		if (responses == null || responses.Length == 0)
		{
			if (S1NPC.MSGConversation == null)
			{
				Logger.Warning("SendTextMessage: Conversation still null after send for '" + S1NPC.ID + "'.");
			}
			return;
		}
		if (S1NPC.MSGConversation == null)
		{
			Logger.Warning("SendTextMessage: Unable to show responses because MSGConversation is null for '" + S1NPC.ID + "'.");
			return;
		}
		S1NPC.MSGConversation.ClearResponses(false);
		Responses.Clear();
		List<Response> list = new List<Response>();
		foreach (Response response in responses)
		{
			Responses.Add(response);
			list.Add(response.S1Response);
		}
		S1NPC.MSGConversation.ShowResponses(list, responseDelay, network);
	}

	public void SetEquippable(string assetPath)
	{
		S1NPC.SetEquippable_Return(assetPath);
	}

	public static NPC? Get<T>() where T : NPC
	{
		return All.FirstOrDefault((NPC npc) => npc.GetType() == typeof(T)) ?? TryCreateBuiltInWrapper(typeof(T));
	}

	private static NPC? TryCreateBuiltInWrapper(Type npcType)
	{
		if (npcType == null || npcType.Assembly != typeof(NPC).Assembly || npcType.IsAbstract)
		{
			return null;
		}
		try
		{
			ConstructorInfo constructor = npcType.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, null);
			if (constructor != null)
			{
				return (NPC)constructor.Invoke(null);
			}
		}
		catch
		{
		}
		return null;
	}

	internal NPC(NPC npc)
	{
		S1NPC = npc;
		gameObject = ((Component)npc).gameObject;
		IsCustomNPC = false;
		All.Add(this);
	}

	internal override void CreateInternal()
	{
		NPC s1NPC = S1NPC;
		if (((s1NPC != null) ? s1NPC.MSGConversation : null) != null && S1NPC.MSGConversation.currentResponses != null)
		{
			foreach (Response currentResponse in S1NPC.MSGConversation.currentResponses)
			{
				Response response = new Response(currentResponse)
				{
					Label = currentResponse.label,
					Text = currentResponse.text
				};
				Responses.Add(response);
				OnResponseLoaded(response);
			}
		}
		try
		{
			Inventory.EnsureInitialized();
		}
		catch (Exception ex)
		{
			Logger.Warning("[NPC] CreateInternal: Failed to ensure inventory initialized for '" + (S1NPC?.ID ?? "null") + "': " + ex.Message);
		}
		try
		{
			ApplyRandomInventoryDefaults();
		}
		catch (Exception ex2)
		{
			Logger.Warning("[NPC] CreateInternal: Failed to apply inventory defaults for '" + (S1NPC?.ID ?? "null") + "': " + ex2.Message);
		}
		base.CreateInternal();
	}

	internal override void SaveInternal(string folderPath, ref List<string> extraSaveables)
	{
		string path = S1NPC.SaveFolderName?.Trim() ?? "UnknownNPC";
		string folderPath2 = Path.Combine(folderPath, path);
		base.SaveInternal(folderPath2, ref extraSaveables);
	}

	private void InitializeHealthComponent()
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		S1NPC.Health = S1NPC.Health ?? gameObject.GetComponent<NPCHealth>();
		if ((Object)(object)S1NPC.Health == (Object)null)
		{
			S1NPC.Health = gameObject.AddComponent<NPCHealth>();
		}
		if (S1NPC.Health.onDie == null)
		{
			S1NPC.Health.onDie = new UnityEvent();
		}
		if (S1NPC.Health.onKnockedOut == null)
		{
			S1NPC.Health.onKnockedOut = new UnityEvent();
		}
		S1NPC.Health.MaxHealth = 100f;
	}

	private void InitializeAwarenessComponent()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		if ((Object)(object)S1NPC.Awareness == (Object)null)
		{
			S1NPC.Awareness = gameObject.GetComponentInChildren<NPCAwareness>(true);
			if ((Object)(object)S1NPC.Awareness == (Object)null)
			{
				GameObject val = new GameObject("NPCAwareness");
				val.transform.SetParent(gameObject.transform, false);
				S1NPC.Awareness = val.AddComponent<NPCAwareness>();
			}
		}
		if (S1NPC.Awareness.onExplosionHeard == null)
		{
			S1NPC.Awareness.onExplosionHeard = new UnityEvent<NoiseEvent>();
		}
		if (S1NPC.Awareness.onGunshotHeard == null)
		{
			S1NPC.Awareness.onGunshotHeard = new UnityEvent<NoiseEvent>();
		}
		if (S1NPC.Awareness.onHitByCar == null)
		{
			S1NPC.Awareness.onHitByCar = new UnityEvent<LandVehicle>();
		}
		if (S1NPC.Awareness.onNoticedDrugDealing == null)
		{
			S1NPC.Awareness.onNoticedDrugDealing = new UnityEvent<Player>();
		}
		if (S1NPC.Awareness.onNoticedGeneralCrime == null)
		{
			S1NPC.Awareness.onNoticedGeneralCrime = new UnityEvent<Player>();
		}
		if (S1NPC.Awareness.onNoticedPettyCrime == null)
		{
			S1NPC.Awareness.onNoticedPettyCrime = new UnityEvent<Player>();
		}
		if (S1NPC.Awareness.onNoticedPlayerViolatingCurfew == null)
		{
			S1NPC.Awareness.onNoticedPlayerViolatingCurfew = new UnityEvent<Player>();
		}
		if (S1NPC.Awareness.onNoticedSuspiciousPlayer == null)
		{
			S1NPC.Awareness.onNoticedSuspiciousPlayer = new UnityEvent<Player>();
		}
		if ((Object)(object)S1NPC.Awareness.Listener == (Object)null)
		{
			S1NPC.Awareness.Listener = gameObject.GetComponent<Listener>() ?? gameObject.AddComponent<Listener>();
		}
		if ((Object)(object)S1NPC.Responses == (Object)null)
		{
			S1NPC.Responses = gameObject.GetComponentInChildren<NPCResponses>(true);
			if ((Object)(object)S1NPC.Responses == (Object)null)
			{
				GameObject val2 = new GameObject("NPCResponses");
				val2.transform.SetParent(gameObject.transform, false);
				S1NPC.Responses = (NPCResponses)(object)val2.AddComponent<NPCResponses_Civilian>();
			}
		}
		if (!(S1NPC.Responses is NPCResponses_Civilian))
		{
			try
			{
				GameObject val3 = (GameObject)(((Object)(object)S1NPC.Responses != (Object)null) ? ((object)((Component)S1NPC.Responses).gameObject) : ((object)gameObject));
				if ((Object)(object)S1NPC.Responses != (Object)null)
				{
					Object.Destroy((Object)(object)S1NPC.Responses);
				}
				NPCResponses_Civilian responses = val3.AddComponent<NPCResponses_Civilian>();
				S1NPC.Responses = (NPCResponses)(object)responses;
			}
			catch
			{
			}
		}
		NPCResponses responses2 = S1NPC.Responses;
		NPCResponses_Civilian val4 = (NPCResponses_Civilian)(object)((responses2 is NPCResponses_Civilian) ? responses2 : null);
		if (val4 != null)
		{
			S1NPC.Awareness.Responses = (NPCResponses)(object)val4;
		}
	}

	private void InitializeBehaviourComponents()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected O, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected O, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected O, but got Unknown
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected O, but got Unknown
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Expected O, but got Unknown
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected O, but got Unknown
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Expected O, but got Unknown
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Expected O, but got Unknown
		if ((Object)(object)S1NPC.Behaviour == (Object)null)
		{
			GameObject val = new GameObject("NPCBehaviour");
			val.transform.SetParent(gameObject.transform, false);
			S1NPC.Behaviour = val.AddComponent<NPCBehaviour>();
		}
		if ((Object)(object)S1NPC.Actions == (Object)null)
		{
			NPCActions val2 = ((Component)S1NPC).GetComponentInChildren<NPCActions>(true);
			if ((Object)(object)val2 == (Object)null)
			{
				GameObject val3 = new GameObject("NPCActions");
				val3.transform.SetParent(gameObject.transform, false);
				val2 = val3.AddComponent<NPCActions>();
			}
			S1NPC.Actions = val2;
		}
		if ((Object)(object)S1NPC.Behaviour.CoweringBehaviour == (Object)null)
		{
			CoweringBehaviour val4 = ((Component)S1NPC.Behaviour).GetComponentInChildren<CoweringBehaviour>(true);
			if ((Object)(object)val4 == (Object)null)
			{
				GameObject val5 = new GameObject("CowingBehaviour");
				val5.transform.SetParent(((Component)S1NPC.Behaviour).transform, false);
				val4 = val5.AddComponent<CoweringBehaviour>();
			}
			S1NPC.Behaviour.CoweringBehaviour = val4;
		}
		if ((Object)(object)S1NPC.Behaviour.FleeBehaviour == (Object)null)
		{
			FleeBehaviour val6 = ((Component)S1NPC.Behaviour).GetComponentInChildren<FleeBehaviour>(true);
			if ((Object)(object)val6 == (Object)null)
			{
				GameObject val7 = new GameObject("FleeBehaviour");
				val7.transform.SetParent(((Component)S1NPC.Behaviour).transform, false);
				val6 = val7.AddComponent<FleeBehaviour>();
			}
			S1NPC.Behaviour.FleeBehaviour = val6;
		}
		if ((Object)(object)S1NPC.Behaviour.GenericDialogueBehaviour == (Object)null)
		{
			GenericDialogueBehaviour val8 = ((Component)S1NPC.Behaviour).GetComponentInChildren<GenericDialogueBehaviour>(true);
			if ((Object)(object)val8 == (Object)null)
			{
				GameObject val9 = new GameObject("GenericDialogueBehaviour");
				val9.transform.SetParent(((Component)S1NPC.Behaviour).transform, false);
				val8 = val9.AddComponent<GenericDialogueBehaviour>();
			}
			S1NPC.Behaviour.GenericDialogueBehaviour = val8;
		}
		if ((Object)(object)S1NPC.Behaviour.RequestProductBehaviour == (Object)null)
		{
			RequestProductBehaviour val10 = ((Component)S1NPC.Behaviour).GetComponentInChildren<RequestProductBehaviour>(true);
			if ((Object)(object)val10 == (Object)null)
			{
				GameObject val11 = new GameObject("RequestProductBehaviour");
				val11.transform.SetParent(((Component)S1NPC.Behaviour).transform, false);
				val10 = val11.AddComponent<RequestProductBehaviour>();
			}
			S1NPC.Behaviour.RequestProductBehaviour = val10;
		}
		if ((Object)(object)S1NPC.Behaviour.CallPoliceBehaviour == (Object)null)
		{
			CallPoliceBehaviour val12 = ((Component)S1NPC.Behaviour).GetComponentInChildren<CallPoliceBehaviour>(true);
			if ((Object)(object)val12 == (Object)null)
			{
				GameObject val13 = new GameObject("CallPoliceBehaviour");
				val13.transform.SetParent(((Component)S1NPC.Behaviour).transform, false);
				val12 = val13.AddComponent<CallPoliceBehaviour>();
			}
			S1NPC.Behaviour.CallPoliceBehaviour = val12;
		}
		if ((Object)(object)S1NPC.Behaviour.CombatBehaviour == (Object)null)
		{
			CombatBehaviour val14 = ((Component)S1NPC.Behaviour).GetComponentInChildren<CombatBehaviour>(true);
			if ((Object)(object)val14 == (Object)null)
			{
				GameObject val15 = new GameObject("CombatBehaviour");
				val15.transform.SetParent(((Component)S1NPC.Behaviour).transform, false);
				val14 = val15.AddComponent<CombatBehaviour>();
			}
			S1NPC.Behaviour.CombatBehaviour = val14;
		}
		if ((Object)(object)S1NPC.Behaviour.StationaryBehaviour == (Object)null)
		{
			StationaryBehaviour val16 = ((Component)S1NPC.Behaviour).GetComponentInChildren<StationaryBehaviour>(true);
			if ((Object)(object)val16 == (Object)null)
			{
				GameObject val17 = new GameObject("StationaryBehaviour");
				val17.transform.SetParent(((Component)S1NPC.Behaviour).transform, false);
				val16 = val17.AddComponent<StationaryBehaviour>();
			}
			S1NPC.Behaviour.StationaryBehaviour = val16;
		}
		if ((Object)(object)S1NPC.Behaviour.FaceTargetBehaviour == (Object)null)
		{
			FaceTargetBehaviour val18 = ((Component)S1NPC.Behaviour).GetComponentInChildren<FaceTargetBehaviour>(true);
			if ((Object)(object)val18 == (Object)null)
			{
				GameObject val19 = new GameObject("FaceTargetBehaviour");
				val19.transform.SetParent(((Component)S1NPC.Behaviour).transform, false);
				val18 = val19.AddComponent<FaceTargetBehaviour>();
			}
			S1NPC.Behaviour.FaceTargetBehaviour = val18;
		}
		if ((Object)(object)S1NPC.Behaviour.ConsumeProductBehaviour == (Object)null)
		{
			ConsumeProductBehaviour val20 = ((Component)S1NPC.Behaviour).GetComponentInChildren<ConsumeProductBehaviour>(true);
			if ((Object)(object)val20 == (Object)null)
			{
				GameObject val21 = new GameObject("ConsumeProductBehaviour");
				val21.transform.SetParent(((Component)S1NPC.Behaviour).transform, false);
				val20 = val21.AddComponent<ConsumeProductBehaviour>();
			}
			S1NPC.Behaviour.ConsumeProductBehaviour = val20;
		}
		if ((Object)(object)S1NPC.Behaviour.UnconsciousBehaviour == (Object)null)
		{
			UnconsciousBehaviour val22 = ((Component)S1NPC.Behaviour).GetComponentInChildren<UnconsciousBehaviour>(true);
			if ((Object)(object)val22 == (Object)null)
			{
				GameObject val23 = new GameObject("UnconsciousBehaviour");
				val23.transform.SetParent(((Component)S1NPC.Behaviour).transform, false);
				val22 = val23.AddComponent<UnconsciousBehaviour>();
			}
			S1NPC.Behaviour.UnconsciousBehaviour = val22;
		}
		if ((Object)(object)S1NPC.Behaviour.DeadBehaviour == (Object)null)
		{
			DeadBehaviour val24 = ((Component)S1NPC.Behaviour).GetComponentInChildren<DeadBehaviour>(true);
			if ((Object)(object)val24 == (Object)null)
			{
				GameObject val25 = new GameObject("DeadBehaviour");
				val25.transform.SetParent(((Component)S1NPC.Behaviour).transform, false);
				val24 = val25.AddComponent<DeadBehaviour>();
			}
			S1NPC.Behaviour.DeadBehaviour = val24;
		}
		TryRegisterBehaviourEventLinks();
	}

	private void TryRegisterBehaviourEventLinks()
	{
		try
		{
			NPCBehaviour beh = S1NPC.Behaviour;
			if ((Object)(object)beh == (Object)null)
			{
				return;
			}
			Behaviour[] componentsInChildren = ((Component)beh).GetComponentsInChildren<Behaviour>(true);
			MethodInfo addMethod = AccessTools.Method(typeof(NPCBehaviour), "AddEnabledBehaviour", (Type[])null, (Type[])null);
			MethodInfo removeMethod = AccessTools.Method(typeof(NPCBehaviour), "RemoveEnabledBehaviour", (Type[])null, (Type[])null);
			foreach (Behaviour b in componentsInChildren)
			{
				if ((Object)(object)b == (Object)null)
				{
					continue;
				}
				try
				{
					Action listener = delegate
					{
						try
						{
							addMethod?.Invoke(beh, new object[1] { b });
						}
						catch
						{
						}
					};
					EventHelper.AddListener(listener, b.onEnable);
				}
				catch
				{
				}
				try
				{
					Action listener2 = delegate
					{
						try
						{
							removeMethod?.Invoke(beh, new object[1] { b });
						}
						catch
						{
						}
					};
					EventHelper.AddListener(listener2, b.onDisable);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
	}

	private void InitializeVisionComponents()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		if ((Object)(object)S1NPC.Awareness == (Object)null)
		{
			return;
		}
		if ((Object)(object)S1NPC.Awareness.VisionCone == (Object)null)
		{
			VisionCone val = gameObject.GetComponentInChildren<VisionCone>(true);
			if ((Object)(object)val == (Object)null)
			{
				GameObject val2 = new GameObject("VisionCone");
				val2.transform.SetParent(gameObject.transform, false);
				val = val2.AddComponent<VisionCone>();
			}
			S1NPC.Awareness.VisionCone = val;
		}
		List<StateContainer> list = S1NPC.Awareness.VisionCone.DefaultStatesOfInterest;
		if (list == null)
		{
			list = new List<StateContainer>();
			S1NPC.Awareness.VisionCone.DefaultStatesOfInterest = list;
		}
		if (list.Count == 0)
		{
			EVisualState[] array = new EVisualState[9];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			EVisualState[] array2 = (EVisualState[])(object)array;
			for (int i = 0; i < array2.Length; i++)
			{
				list.Add(new StateContainer
				{
					state = array2[i]
				});
			}
		}
		if ((Object)(object)S1NPC.Awareness.VisionCone.QuestionMarkPopup == (Object)null)
		{
			WorldspacePopup questionMarkPopup = gameObject.GetComponent<WorldspacePopup>() ?? gameObject.AddComponent<WorldspacePopup>();
			S1NPC.Awareness.VisionCone.QuestionMarkPopup = questionMarkPopup;
		}
	}

	private void InitializeInteractables()
	{
		FieldInfo fieldInfo = AccessTools.Field(typeof(NPC), "intObj");
		if (fieldInfo.GetValue(S1NPC) == null)
		{
			InteractableObject value = gameObject.GetComponentInChildren<InteractableObject>(true) ?? gameObject.AddComponent<InteractableObject>();
			fieldInfo.SetValue(S1NPC, value);
		}
	}

	private void InitializeInventoryComponent()
	{
		if ((Object)(object)S1NPC.Inventory == (Object)null)
		{
			S1NPC.Inventory = gameObject.GetComponentInChildren<NPCInventory>(true) ?? gameObject.AddComponent<NPCInventory>();
		}
		if ((Object)(object)S1NPC.Inventory.PickpocketIntObj == (Object)null)
		{
			InteractableObject talkInteractable = GetPrimaryInteractable();
			InteractableObject[] componentsInChildren = gameObject.GetComponentsInChildren<InteractableObject>(true);
			InteractableObject val = ((IEnumerable<InteractableObject>)componentsInChildren).FirstOrDefault((Func<InteractableObject, bool>)((InteractableObject io) => (Object)(object)io != (Object)null && (Object)(object)io != (Object)(object)talkInteractable));
			if ((Object)(object)val == (Object)null)
			{
				val = gameObject.AddComponent<InteractableObject>();
			}
			S1NPC.Inventory.PickpocketIntObj = val;
		}
	}

	private void InitializeRelationshipData()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		string text = S1NPC?.ID ?? "<null>";
		bool flag = S1NPC.RelationData != null;
		if (S1NPC.RelationData == null)
		{
			S1NPC.RelationData = new NPCRelationData();
		}
		try
		{
			if (S1NPC.RelationData != null)
			{
				S1NPC.RelationData.Init(S1NPC);
			}
			else
			{
				Logger.Warning("[NPC] InitializeRelationshipData: RelationData is still null after creation attempt for NPC '" + text + "'");
			}
		}
		catch (Exception ex)
		{
			Logger.Error("[NPC] InitializeRelationshipData: Exception during Init() for NPC '" + text + "': " + ex.Message);
			Logger.Error("[NPC] InitializeRelationshipData: Stack trace: " + ex.StackTrace);
		}
	}

	private void ApplyRandomInventoryDefaults()
	{
		if (!HasRandomInventoryDefaultsForType(GetType()))
		{
			return;
		}
		try
		{
			string text = S1NPC?.ID ?? "<null>";
			RandomInventoryItemsBuilder.InventoryDefaultsData inventoryDefaultsData = BuildRandomInventoryDefaultsForType(GetType());
			if (inventoryDefaultsData == null)
			{
				return;
			}
			NPCInventory inventory = S1NPC.Inventory;
			if ((Object)(object)inventory == (Object)null)
			{
				return;
			}
			if (inventoryDefaultsData.RandomCashMin.HasValue || inventoryDefaultsData.RandomCashMax.HasValue)
			{
				inventory.RandomCash = true;
				if (inventoryDefaultsData.RandomCashMin.HasValue)
				{
					inventory.RandomCashMin = inventoryDefaultsData.RandomCashMin.Value;
				}
				if (inventoryDefaultsData.RandomCashMax.HasValue)
				{
					inventory.RandomCashMax = inventoryDefaultsData.RandomCashMax.Value;
				}
				if (inventory.ItemSlots != null && inventory.ItemSlots.Count > 0)
				{
					int num = 0;
					try
					{
						if (inventory.ItemSlots != null)
						{
							for (int i = 0; i < inventory.ItemSlots.Count; i++)
							{
								ItemSlot val = inventory.ItemSlots[i];
								if (((val != null) ? val.ItemInstance : null) == null)
								{
									continue;
								}
								ItemDefinition definition = val.ItemInstance.Definition;
								if (!((Object)(object)definition != (Object)null) || !(definition.ID == "cash"))
								{
									continue;
								}
								PropertyInfo property = ((object)val.ItemInstance).GetType().GetProperty("Value");
								if (property != null)
								{
									object value = property.GetValue(val.ItemInstance);
									if (value is int num2)
									{
										num += num2;
									}
									else if (value is float num3)
									{
										num += (int)num3;
									}
								}
							}
						}
					}
					catch (Exception ex)
					{
						Logger.Warning("[NPC] ApplyRandomInventoryDefaults: '" + text + "' failed to check existing cash: " + ex.Message);
					}
					if (num == 0)
					{
						int valueOrDefault = inventoryDefaultsData.RandomCashMin.GetValueOrDefault();
						int num4 = inventoryDefaultsData.RandomCashMax ?? 100;
						if (num4 > 0)
						{
							int num5 = Random.Range(valueOrDefault, num4 + 1);
							if (num5 > 0)
							{
								try
								{
									MethodInfo method = ((object)inventory).GetType().GetMethod("AddCash", BindingFlags.Instance | BindingFlags.Public);
									if (method != null)
									{
										method.Invoke(inventory, new object[1] { (float)num5 });
									}
									else
									{
										MoneyManager instance = NetworkSingleton<MoneyManager>.Instance;
										if ((Object)(object)instance != (Object)null)
										{
											CashInstance cashInstance = instance.GetCashInstance((float)num5);
											if (cashInstance != null)
											{
												inventory.InsertItem((ItemInstance)(object)cashInstance, true);
											}
											else
											{
												Logger.Warning($"[NPC] ApplyRandomInventoryDefaults: '{text}' MoneyManager.GetCashInstance returned null for amount {num5}");
											}
										}
										else
										{
											Logger.Warning("[NPC] ApplyRandomInventoryDefaults: '" + text + "' MoneyManager not available to create cash");
										}
									}
								}
								catch (Exception ex2)
								{
									Logger.Warning("[NPC] ApplyRandomInventoryDefaults: '" + text + "' failed to add cash: " + ex2.Message);
								}
							}
						}
					}
				}
			}
			if (inventoryDefaultsData.ClearInventoryEachNight.HasValue)
			{
				inventory.ClearInventoryEachNight = inventoryDefaultsData.ClearInventoryEachNight.Value;
			}
			if (inventoryDefaultsData.StartupItems == null || inventoryDefaultsData.StartupItems.Count <= 0)
			{
				return;
			}
			List<ItemDefinition> list = new List<ItemDefinition>();
			foreach (string startupItem in inventoryDefaultsData.StartupItems)
			{
				ItemDefinition item = Registry.GetItem(startupItem);
				if ((Object)(object)item != (Object)null)
				{
					list.Add(item);
				}
			}
			if (list.Count > 0)
			{
				if (inventory.ItemSlots != null && inventory.ItemSlots.Count > 0)
				{
					int num6 = 0;
					foreach (ItemDefinition item2 in list)
					{
						try
						{
							ItemInstance defaultInstance = item2.GetDefaultInstance(1);
							if (defaultInstance != null)
							{
								inventory.InsertItem(defaultInstance, false);
								num6++;
							}
						}
						catch (Exception ex3)
						{
							Logger.Warning("[NPC] ApplyRandomInventoryDefaults: '" + text + "' failed to insert startup item " + item2.ID + ": " + ex3.Message);
						}
					}
					inventory.StartupItems = Array.Empty<ItemDefinition>();
					return;
				}
				bool flag = false;
				try
				{
					if (inventory.StartupItems != null)
					{
						ItemDefinition[] startupItems = inventory.StartupItems;
						flag = startupItems != null && startupItems.Length != 0;
					}
				}
				catch
				{
					flag = false;
				}
				if (!flag)
				{
					inventory.StartupItems = list.ToArray();
				}
			}
			else
			{
				Logger.Warning("[NPC] ApplyRandomInventoryDefaults: '" + text + "' had StartupItems definitions but none resolved from registry.");
			}
		}
		catch (Exception ex4)
		{
			Logger.Warning("[NPC] ApplyRandomInventoryDefaults: '" + (S1NPC?.ID ?? GetType().Name) + "' failed with exception: " + ex4.Message);
			Logger.Warning("[NPC] ApplyRandomInventoryDefaults: Stack trace: " + ex4.StackTrace);
		}
	}

	private InteractableObject? GetPrimaryInteractable()
	{
		FieldInfo fieldInfo = AccessTools.Field(typeof(NPC), "intObj");
		object? value = fieldInfo.GetValue(S1NPC);
		return (InteractableObject?)((value is InteractableObject) ? value : null);
	}

	private void InitializeNetworkBehaviours()
	{
		NetworkBehaviour[] componentsInChildren = gameObject.GetComponentsInChildren<NetworkBehaviour>(true);
		NetworkBehaviour[] array = componentsInChildren;
		foreach (NetworkBehaviour val in array)
		{
			if (!((Object)(object)val == (Object)null))
			{
				try
				{
				}
				catch (Exception ex)
				{
					Logger.Warning("[S1API] Failed to initialize network behaviour " + ((object)val).GetType().Name + ": " + ex.Message);
				}
			}
		}
	}

	private void RestoreRuntimeAvatarAppearance()
	{
		if (!((Object)(object)_runtimeAvatar == (Object)null))
		{
			S1NPC.Avatar = _runtimeAvatar;
			Appearance.ApplyToAvatar(_runtimeAvatar);
		}
	}

	private void MarkLoadedFromSave()
	{
		_wasLoadedFromSave = true;
	}

	private void TrySpawnNetworkInstance()
	{
		try
		{
			NetworkManager networkManager = InstanceFinder.NetworkManager;
			if (!((Object)(object)networkManager != (Object)null) || networkManager.IsServer)
			{
				NetworkObject netObject = gameObject.GetComponent<NetworkObject>() ?? gameObject.AddComponent<NetworkObject>();
				NPCNetworkBootstrap.RegisterPendingNetworkSpawn(this, netObject, 0.3f, 0.6f);
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("[S1API] Failed to queue NPC network spawn: " + ex.Message);
		}
	}

	internal void PrepareForNetworkSpawn()
	{
		try
		{
			Customer component = gameObject.GetComponent<Customer>();
			if ((Object)(object)component != (Object)null)
			{
				Customer.EnsureCustomer();
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("[S1API] Failed to prepare customer data before spawn: " + ex.Message);
		}
	}

	internal void FinalizeNetworkSpawn()
	{
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if ((Object)(object)S1NPC.Awareness != (Object)null)
			{
				NPCResponses responses = S1NPC.Responses;
				NPCResponses_Civilian val = (NPCResponses_Civilian)(object)((responses is NPCResponses_Civilian) ? responses : null);
				if (val != null)
				{
					S1NPC.Awareness.Responses = (NPCResponses)(object)val;
				}
			}
			S1NPC.SetVisible(IsPhysical, false);
			if (InstanceFinder.IsServer)
			{
				MelonCoroutines.Start(DelayedVisibilityRPC(IsPhysical));
			}
			try
			{
				if (IsCustomNPC && !((Object)(object)gameObject.GetComponent<Customer>() != (Object)null))
				{
				}
			}
			catch (Exception ex)
			{
				Logger.Warning("[S1API] Failed to ensure Customer on NPC: " + ex.Message);
			}
			try
			{
				if (IsCustomNPC && IsDealerType(GetType()))
				{
					Dealer.EnsureDealer();
				}
			}
			catch (Exception ex2)
			{
				Logger.Warning("[S1API] Failed to ensure Dealer on NPC: " + ex2.Message);
			}
			try
			{
				Type type = GetType();
				if (TypeToSchedulePlan.TryGetValue(type, out List<IScheduleActionSpec> value) && value != null && value.Count > 0)
				{
					for (int i = 0; i < value.Count; i++)
					{
						IScheduleActionSpec scheduleActionSpec = value[i];
						if (scheduleActionSpec != null)
						{
							try
							{
								scheduleActionSpec.ApplyTo(Schedule);
							}
							catch (Exception ex3)
							{
								Logger.Error($"Failed to apply schedule spec {i} ({scheduleActionSpec.GetType().Name}) for NPC type {type.Name}: {ex3.Message}");
								Logger.Error("Stack trace: " + ex3.StackTrace);
							}
						}
					}
					Schedule.InitializeActions();
					Schedule.EnforceState();
				}
			}
			catch (Exception ex4)
			{
				Logger.Error("Failed to apply planned schedule for NPC type " + GetType().Name + ": " + ex4.Message);
				Logger.Error("Stack trace: " + ex4.StackTrace);
			}
			bool flag = S1NPC.RelationData != null;
			bool flag2 = false;
			if (flag)
			{
				bool unlocked = S1NPC.RelationData.Unlocked;
				float relationDelta = S1NPC.RelationData.RelationDelta;
				flag2 = unlocked || Math.Abs(relationDelta - 2f) > 0.01f;
			}
			if (!_wasLoadedFromSave && !flag2)
			{
				try
				{
					NPCPrefabIdentity component = gameObject.GetComponent<NPCPrefabIdentity>();
					bool flag3 = false;
					if ((Object)(object)component != (Object)null)
					{
						NPCRelationData relationData = S1NPC.RelationData;
						if (relationData != null)
						{
							bool unlocked2 = relationData.Unlocked;
							component.ApplyRelationshipDataTo(S1NPC, unlocked2);
							flag3 = true;
							_relationshipDataAppliedFromPrefab = true;
							if (unlocked2 && !relationData.Unlocked)
							{
								Logger.Warning("[NPC] FinalizeNetworkSpawn: WARNING - Unlock state was lost for NPC '" + S1NPC.ID + "' after applying prefab defaults. Restoring...");
								EUnlockType val2 = (EUnlockType)(((_003F?)_loadedUnlockType) ?? 1);
								relationData.Unlock(val2, false);
							}
						}
						else
						{
							Logger.Warning("[Relationship Data] FinalizeNetworkSpawn: RelationData is null for NPC '" + S1NPC.ID + "'");
						}
					}
					if (!flag3)
					{
						Type type2 = GetType();
						if (TypeToRelationshipDefaults.TryGetValue(type2, out Action<NPCRelationshipDataBuilder> value2) && value2 != null)
						{
							NPCRelationshipDataBuilder nPCRelationshipDataBuilder = new NPCRelationshipDataBuilder();
							value2(nPCRelationshipDataBuilder);
							NPCRelationData relationData2 = S1NPC.RelationData;
							if (relationData2 != null)
							{
								bool unlocked3 = relationData2.Unlocked;
								nPCRelationshipDataBuilder.ApplyTo(relationData2, S1NPC, unlocked3);
								_relationshipDataAppliedFromPrefab = true;
								if (unlocked3 && !relationData2.Unlocked)
								{
									Logger.Warning("[NPC] FinalizeNetworkSpawn: WARNING - Unlock state was lost for NPC '" + S1NPC.ID + "' after applying defaults. Restoring...");
									EUnlockType val3 = (EUnlockType)(((_003F?)_loadedUnlockType) ?? 1);
									relationData2.Unlock(val3, false);
								}
							}
							else
							{
								Logger.Warning("[NPC] FinalizeNetworkSpawn: RelationData is null for NPC '" + S1NPC.ID + "' - cannot apply defaults!");
							}
						}
						else
						{
							_relationshipDataAppliedFromPrefab = true;
						}
					}
				}
				catch (Exception ex5)
				{
					Logger.Error("[NPC] FinalizeNetworkSpawn: Failed to apply relationship defaults for NPC '" + S1NPC.ID + "': " + ex5.Message);
					Logger.Error("[NPC] FinalizeNetworkSpawn: Stack trace: " + ex5.StackTrace);
				}
			}
			else
			{
				_relationshipDataAppliedFromPrefab = true;
			}
			try
			{
				Type type3 = GetType();
				if (TypeToSpawnPosition.TryGetValue(type3, out (Vector3, Quaternion) value3))
				{
					(Position, _) = value3;
					Transform.rotation = value3.Item2;
				}
			}
			catch (Exception ex6)
			{
				Logger.Warning("[S1API] Failed to apply spawn position: " + ex6.Message);
			}
			CheckAndSetCustomNpcsReady();
		}
		catch (Exception ex7)
		{
			Logger.Warning("[S1API] Failed to finalize NPC after spawn: " + ex7.Message);
		}
	}

	private static void CheckAndSetCustomNpcsReady()
	{
		if (CustomNpcsReady)
		{
			return;
		}
		try
		{
			List<NPC> allCustomNpcs = All.Where((NPC n) => n.IsCustomNPC).ToList();
			if (allCustomNpcs.Count != 0)
			{
				List<Type> source = (from t in ReflectionUtils.GetDerivedClasses<NPC>()
					where t != null && !t.IsAbstract && t.Assembly != typeof(NPC).Assembly
					select t).ToList();
				if (source.All((Type type) => allCustomNpcs.Any((NPC npc) => npc.GetType() == type)))
				{
					CustomNpcsReady = true;
				}
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("[NPC] Failed to check CustomNpcsReady status: " + ex.Message);
		}
	}

	private IEnumerator DelayedVisibilityRPC(bool isPhysical)
	{
		yield return null;
		yield return (object)new WaitForSeconds(0.1f);
		try
		{
			if ((Object)(object)S1NPC != (Object)null && (Object)(object)((Component)S1NPC).gameObject != (Object)null)
			{
				S1NPC.SetVisible(isPhysical, true);
			}
		}
		catch (Exception ex)
		{
			Exception ex2 = ex;
			Logger.Warning("[S1API] Failed to send visibility RPC for NPC '" + S1NPC?.ID + "': " + ex2.Message);
		}
	}

	private static void EnsureScheduleActionsOnPrefab(GameObject prefabRoot)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		if ((Object)(object)prefabRoot == (Object)null)
		{
			return;
		}
		NPCScheduleManager val = prefabRoot.GetComponentInChildren<NPCScheduleManager>(true);
		if ((Object)(object)val == (Object)null)
		{
			GameObject val2 = new GameObject("NPCSchedule");
			val2.transform.SetParent(prefabRoot.transform, false);
			val = val2.AddComponent<NPCScheduleManager>();
		}
		List<Type> list = new List<Type>();
		Type typeFromHandle = typeof(NPCAction);
		try
		{
			Assembly assembly = typeFromHandle.Assembly;
			if (assembly != null)
			{
				Type[] types = assembly.GetTypes();
				foreach (Type type in types)
				{
					if (!(type == null) && !type.IsAbstract && typeFromHandle.IsAssignableFrom(type))
					{
						list.Add(type);
					}
				}
			}
		}
		catch
		{
			string text = typeFromHandle.Namespace;
			string[] array = new string[10] { "NPCSignal_WalkToLocation", "NPCSignal_WaitForDelivery", "NPCSignal_UseVendingMachine", "NPCSignal_UseATM", "NPCSignal_DriveToCarPark", "NPCEvent_StayInBuilding", "NPCEvent_Sit", "NPCEvent_LocationDialogue", "NPCEvent_LocationBasedAction", "NPCEvent_Conversate" };
			for (int j = 0; j < array.Length; j++)
			{
				string typeName = (string.IsNullOrEmpty(text) ? array[j] : (text + "." + array[j]));
				Type type2 = Type.GetType(typeName);
				if (type2 != null && !type2.IsAbstract && typeFromHandle.IsAssignableFrom(type2))
				{
					list.Add(type2);
				}
			}
		}
		for (int k = 0; k < list.Count; k++)
		{
			Type type3 = list[k];
			if (type3 == null)
			{
				continue;
			}
			Component componentInChildren = ((Component)val).GetComponentInChildren(type3, true);
			if (!((Object)(object)componentInChildren != (Object)null))
			{
				GameObject val3 = new GameObject(type3.Name);
				val3.transform.SetParent(((Component)val).transform, false);
				Component obj2 = val3.AddComponent(type3);
				try
				{
					FieldInfo field = type3.GetField("npc", BindingFlags.Instance | BindingFlags.NonPublic);
					FieldInfo field2 = type3.GetField("schedule", BindingFlags.Instance | BindingFlags.NonPublic);
					NPC component = prefabRoot.GetComponent<NPC>();
					field?.SetValue(obj2, component);
					field2?.SetValue(obj2, val);
				}
				catch
				{
				}
				val3.SetActive(false);
			}
		}
	}
}
