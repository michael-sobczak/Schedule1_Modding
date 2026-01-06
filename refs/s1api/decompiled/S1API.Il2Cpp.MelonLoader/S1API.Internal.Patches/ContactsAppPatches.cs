using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using HarmonyLib;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.Relation;
using Il2CppScheduleOne.UI.Phone.ContactsApp;
using Il2CppScheduleOne.UI.Relations;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using MelonLoader;
using S1API.Entities;
using S1API.Internal.Utils;
using S1API.Logging;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace S1API.Internal.Patches;

[HarmonyPatch]
internal class ContactsAppPatches
{
	private static readonly Log Logger = new Log("ContactsAppPatches");

	private static bool _startCalled;

	private static bool? _hasCustomNpcTypesCache;

	private static bool HasCustomNpcTypes()
	{
		if (_hasCustomNpcTypesCache.HasValue)
		{
			return _hasCustomNpcTypesCache.Value;
		}
		try
		{
			Type typeFromHandle = typeof(NPC);
			Assembly baseAssembly = typeFromHandle.Assembly;
			List<Type> derivedClasses = ReflectionUtils.GetDerivedClasses<NPC>();
			bool flag = derivedClasses.Any((Type t) => t != null && t.Assembly != baseAssembly && !t.IsAbstract);
			_hasCustomNpcTypesCache = flag;
			return flag;
		}
		catch (Exception value)
		{
			Logger.Error($"Error in HasCustomNpcTypes: {value}");
			_hasCustomNpcTypesCache = false;
			return false;
		}
	}

	[HarmonyPrefix]
	[HarmonyPatch(typeof(ContactsApp), "Start")]
	private static bool ContactsApp_Start_Prefix(ContactsApp __instance)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		Scene activeScene = SceneManager.GetActiveScene();
		if (((Scene)(ref activeScene)).name == "Tutorial")
		{
			return true;
		}
		if (!HasCustomNpcTypes())
		{
			return true;
		}
		if (NPCPatches.CustomNpcsReady)
		{
			List<NPC> source = NPC.All.ToList();
			List<NPC> source2 = source.Where((NPC n) => n.IsCustomNPC).ToList();
			List<NPC> list = source2.Where((NPC n) => n.IsPhysical).ToList();
			if (list.Count == 0)
			{
				return true;
			}
		}
		if (!_startCalled)
		{
			_startCalled = true;
			MelonCoroutines.Start(WaitForNPCs(__instance));
			return false;
		}
		return true;
	}

	[HarmonyPrefix]
	[HarmonyPatch(typeof(ContactsApp), "Update")]
	private static bool ContactsApp_Update_Prefix(ContactsApp __instance)
	{
		return true;
	}

	private static IEnumerator WaitForNPCs(ContactsApp contactsApp)
	{
		while (!NPCPatches.CustomNpcsReady)
		{
			yield return null;
		}
		List<NPC> allNPCs = NPC.All.ToList();
		List<NPC> customNPCs = allNPCs.Where((NPC n) => n.IsCustomNPC && n.IsPhysical).ToList();
		MethodInfo startMethod = typeof(ContactsApp).GetMethod("Start", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
		if (startMethod == null)
		{
			Logger.Error("Couldn't find ContactsApp.Start method via reflection");
			yield break;
		}
		if (customNPCs.Count == 0)
		{
			try
			{
				startMethod.Invoke(contactsApp, null);
				yield break;
			}
			catch (Exception value)
			{
				Logger.Error($"Error invoking Start: {value}");
				yield break;
			}
		}
		yield return (object)new WaitUntil(Func<bool>.op_Implicit((Func<bool>)delegate
		{
			Il2CppArrayBase<NPC> allSceneNPCs = Object.FindObjectsOfType<NPC>(true);
			return customNPCs.All((NPC npc) => ((IEnumerable<NPC>)allSceneNPCs).Any((NPC sn) => sn.ID == npc.ID));
		}));
		yield return (object)new WaitUntil(Func<bool>.op_Implicit((Func<bool>)(() => customNPCs.All((NPC npc) => npc.RelationshipDataAppliedFromPrefab))));
		yield return (object)new WaitUntil(Func<bool>.op_Implicit((Func<bool>)(() => customNPCs.All((NPC npc) => (Object)(object)npc.S1NPC != (Object)null && npc.S1NPC.RelationData != null))));
		yield return null;
		yield return null;
		yield return (object)new WaitUntil(Func<bool>.op_Implicit((Func<bool>)(() => NPCAppearance.MugshotsProcessingComplete)));
		try
		{
			startMethod.Invoke(contactsApp, null);
		}
		catch (Exception value2)
		{
			Logger.Error($"Error invoking Start: {value2}");
		}
		AddRelationCircles(contactsApp);
	}

	private static void AddRelationCircles(ContactsApp contactsApp)
	{
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0734: Unknown result type (might be due to invalid IL or missing references)
		//IL_0739: Unknown result type (might be due to invalid IL or missing references)
		//IL_0744: Unknown result type (might be due to invalid IL or missing references)
		List<NPC> list = NPC.All.Where((NPC n) => n.IsCustomNPC && (NPC.IsCustomerType(n.GetType()) || NPC.IsDealerType(n.GetType()))).ToList();
		Dictionary<EMapRegion, RegionUI> dictionary = ((IEnumerable<RegionUI>)contactsApp.RegionUIs).ToDictionary((RegionUI r) => r.Region, (RegionUI r) => r);
		Dictionary<NPC, RelationCircle> dictionary2 = new Dictionary<NPC, RelationCircle>();
		HashSet<string> createdCircleIds = new HashSet<string>();
		foreach (NPC npc in list)
		{
			if ((Object)(object)npc.S1NPC == (Object)null || npc.S1NPC.RelationData == null)
			{
				Log logger = Logger;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 3);
				defaultInterpolatedStringHandler.AppendLiteral("Skipping NPC ");
				defaultInterpolatedStringHandler.AppendFormatted(npc.ID);
				defaultInterpolatedStringHandler.AppendLiteral(" - S1NPC=");
				defaultInterpolatedStringHandler.AppendFormatted((Object)(object)npc.S1NPC != (Object)null);
				defaultInterpolatedStringHandler.AppendLiteral(", RelationData=");
				NPC s1NPC = npc.S1NPC;
				defaultInterpolatedStringHandler.AppendFormatted(((s1NPC != null) ? s1NPC.RelationData : null) != null);
				logger.Warning(defaultInterpolatedStringHandler.ToStringAndClear());
				continue;
			}
			if (!dictionary.TryGetValue(npc.S1NPC.Region, out var value) || (Object)(object)((value != null) ? value.Container : null) == (Object)null)
			{
				Logger.Warning($"Skipping NPC {npc.ID} - region {npc.S1NPC.Region} not found in regionUIs");
				continue;
			}
			RelationCircle val = ((IEnumerable<RelationCircle>)((Component)value.Container).GetComponentsInChildren<RelationCircle>(true)).FirstOrDefault((Func<RelationCircle, bool>)((RelationCircle c) => c.AssignedNPC_ID == npc.S1NPC.ID));
			if ((Object)(object)val != (Object)null)
			{
				continue;
			}
			Il2CppArrayBase<RelationCircle> componentsInChildren = ((Component)value.Container).GetComponentsInChildren<RelationCircle>(true);
			RelationCircle val2 = ((IEnumerable<RelationCircle>)componentsInChildren).FirstOrDefault((Func<RelationCircle, bool>)((RelationCircle c) => !createdCircleIds.Contains(c.AssignedNPC_ID))) ?? ((Component)contactsApp.CirclesContainer).GetComponentInChildren<RelationCircle>(true);
			if ((Object)(object)val2 == (Object)null)
			{
				continue;
			}
			GameObject val3 = Object.Instantiate<GameObject>(((Component)val2).gameObject, (Transform)(object)value.Container);
			((Object)val3).name = npc.ID;
			RelationCircle component = val3.GetComponent<RelationCircle>();
			component.AssignedNPC_ID = npc.S1NPC.ID;
			component.AssignNPC(npc.S1NPC);
			createdCircleIds.Add(npc.S1NPC.ID);
			MethodInfo zoomMethod = typeof(ContactsApp).GetMethod("ZoomToRect", BindingFlags.Instance | BindingFlags.NonPublic);
			RelationCircle cachedCircle = component;
			NPC cachedNPC = npc.S1NPC;
			component.onClicked = Action.op_Implicit((Action)delegate
			{
				//IL_0082: Unknown result type (might be due to invalid IL or missing references)
				contactsApp.DetailPanel.Open(cachedNPC);
				if (zoomMethod != null)
				{
					zoomMethod.Invoke(contactsApp, new object[1] { cachedCircle.Rect });
				}
				((Transform)contactsApp.SelectionIndicator).position = ((Transform)cachedCircle.Rect).position;
			});
			EnableDealerIndicator(component, npc);
			dictionary2[npc] = component;
		}
		Dictionary<EMapRegion, List<RelationCircle>> dictionary3 = new Dictionary<EMapRegion, List<RelationCircle>>();
		foreach (RegionUI item in (Il2CppArrayBase<RegionUI>)(object)contactsApp.RegionUIs)
		{
			List<RelationCircle> value2 = (((Object)(object)item.Container == (Object)null) ? new List<RelationCircle>() : ((IEnumerable<RelationCircle>)((Component)item.Container).GetComponentsInChildren<RelationCircle>(true)).ToList());
			dictionary3[item.Region] = value2;
		}
		Dictionary<NPC, List<NPC>> graph = BuildGraph(list);
		HashSet<string> hashSet = new HashSet<string>();
		foreach (KeyValuePair<EMapRegion, List<RelationCircle>> item2 in dictionary3)
		{
			foreach (RelationCircle item3 in item2.Value)
			{
				if (!string.IsNullOrEmpty(item3.AssignedNPC_ID))
				{
					hashSet.Add(item3.AssignedNPC_ID);
				}
			}
		}
		List<NPC> source = ComputeInsertionOrder(list, graph, hashSet);
		foreach (IGrouping<EMapRegion, NPC> item4 in from n in source
			group n by n.S1NPC.Region)
		{
			if (!dictionary.TryGetValue(item4.Key, out var value3) || (Object)(object)((value3 != null) ? value3.Container : null) == (Object)null)
			{
				continue;
			}
			Il2CppArrayBase<RelationCircle> componentsInChildren2 = ((Component)value3.Container).GetComponentsInChildren<RelationCircle>(true);
			Dictionary<string, RelationCircle> circleById = ((IEnumerable<RelationCircle>)componentsInChildren2).Where((RelationCircle c) => !string.IsNullOrEmpty(c.AssignedNPC_ID)).ToDictionary((RelationCircle c) => c.AssignedNPC_ID, (RelationCircle c) => c);
			Dictionary<RelationCircle, RectTransform> dictionary4 = ((IEnumerable<RelationCircle>)componentsInChildren2).ToDictionary((RelationCircle c) => c, (RelationCircle c) => ((Component)c).GetComponent<RectTransform>());
			foreach (NPC npc2 in item4)
			{
				RelationCircle val4 = ((IEnumerable<RelationCircle>)componentsInChildren2).FirstOrDefault((Func<RelationCircle, bool>)((RelationCircle c) => c.AssignedNPC_ID == npc2.S1NPC.ID));
				if (!((Object)(object)val4 == (Object)null))
				{
					List<(Vector2, Vector2)> allEdges = GetAllEdges(Il2CppArrayBase<RelationCircle>.op_Implicit(componentsInChildren2), dictionary4);
					Vector2 anchoredPosition = ComputePlacement(val4, Il2CppArrayBase<RelationCircle>.op_Implicit(componentsInChildren2), circleById, dictionary4, allEdges);
					dictionary4[val4].anchoredPosition = anchoredPosition;
				}
			}
		}
		CreateConnectionLines(contactsApp, list, dictionary);
	}

	private static void CreateConnectionLines(ContactsApp contactsApp, List<NPC> customNPCs, Dictionary<EMapRegion, RegionUI> regionUIs)
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)contactsApp.ConnectionPrefab == (Object)null)
		{
			Logger.Warning("ConnectionPrefab is null, cannot create connection lines");
			return;
		}
		HashSet<string> hashSet = new HashSet<string>();
		foreach (NPC npc in customNPCs)
		{
			NPC s1NPC = npc.S1NPC;
			object obj;
			if (s1NPC == null)
			{
				obj = null;
			}
			else
			{
				NPCRelationData relationData = s1NPC.RelationData;
				obj = ((relationData != null) ? relationData.Connections : null);
			}
			if (obj == null || !regionUIs.TryGetValue(npc.S1NPC.Region, out RegionUI value) || (Object)(object)((value != null) ? value.Container : null) == (Object)null)
			{
				continue;
			}
			Il2CppArrayBase<RelationCircle> componentsInChildren = ((Component)value.Container).GetComponentsInChildren<RelationCircle>(true);
			RelationCircle val = ((IEnumerable<RelationCircle>)componentsInChildren).FirstOrDefault((Func<RelationCircle, bool>)((RelationCircle c) => c.AssignedNPC_ID == npc.S1NPC.ID));
			if ((Object)(object)val == (Object)null)
			{
				continue;
			}
			Il2CppArrayBase<NPC> items = npc.S1NPC.RelationData.Connections._items;
			foreach (NPC connectedNPC in items)
			{
				if ((Object)(object)connectedNPC == (Object)null || connectedNPC.Region != npc.S1NPC.Region)
				{
					continue;
				}
				string iD = npc.S1NPC.ID;
				string iD2 = connectedNPC.ID;
				string item = ((string.Compare(iD, iD2, StringComparison.Ordinal) < 0) ? (iD + "->" + iD2) : (iD2 + "->" + iD));
				if (hashSet.Contains(item))
				{
					continue;
				}
				RelationCircle val2 = ((IEnumerable<RelationCircle>)componentsInChildren).FirstOrDefault((Func<RelationCircle, bool>)((RelationCircle c) => c.AssignedNPC_ID == connectedNPC.ID));
				if ((Object)(object)val2 == (Object)null)
				{
					continue;
				}
				hashSet.Add(item);
				RectTransform val3 = value.ConnectionsContainer ?? contactsApp.ConnectionsContainer;
				if ((Object)(object)val3 == (Object)null)
				{
					continue;
				}
				GameObject val4 = Object.Instantiate<GameObject>(contactsApp.ConnectionPrefab, (Transform)(object)val3);
				RectTransform component = val4.GetComponent<RectTransform>();
				component.anchoredPosition = (val2.Rect.anchoredPosition + val.Rect.anchoredPosition) / 2f;
				Vector3 val5 = Vector2.op_Implicit(val2.Rect.anchoredPosition - val.Rect.anchoredPosition);
				float num = (0f - Mathf.Atan2(val5.x, val5.y)) * 57.29578f;
				((Transform)component).localRotation = Quaternion.Euler(0f, 0f, num);
				component.sizeDelta = new Vector2(component.sizeDelta.x, Vector3.Distance(Vector2.op_Implicit(val2.Rect.anchoredPosition), Vector2.op_Implicit(val.Rect.anchoredPosition)));
				((Object)val4).name = npc.S1NPC.ID + " -> " + connectedNPC.ID;
				Transform obj2 = ((Transform)component).Find("StartButton");
				Button val6 = ((obj2 != null) ? ((Component)obj2).GetComponent<Button>() : null);
				Transform obj3 = ((Transform)component).Find("EndButton");
				Button val7 = ((obj3 != null) ? ((Component)obj3).GetComponent<Button>() : null);
				MethodInfo zoomMethod = typeof(ContactsApp).GetMethod("ZoomToRect", BindingFlags.Instance | BindingFlags.NonPublic);
				if ((Object)(object)val6 != (Object)null && zoomMethod != null)
				{
					RectTransform cachedOtherRect = val2.Rect;
					((UnityEvent)val6.onClick).AddListener(UnityAction.op_Implicit((Action)delegate
					{
						zoomMethod.Invoke(contactsApp, new object[1] { cachedOtherRect });
					}));
				}
				if ((Object)(object)val7 != (Object)null && zoomMethod != null)
				{
					RectTransform cachedNpcRect = val.Rect;
					((UnityEvent)val7.onClick).AddListener(UnityAction.op_Implicit((Action)delegate
					{
						zoomMethod.Invoke(contactsApp, new object[1] { cachedNpcRect });
					}));
				}
			}
		}
	}

	private static Dictionary<NPC, List<NPC>> BuildGraph(List<NPC> customs)
	{
		Dictionary<string, NPC> dictionary = customs.ToDictionary((NPC n) => n.S1NPC.ID, (NPC n) => n);
		Dictionary<NPC, List<NPC>> dictionary2 = customs.ToDictionary((NPC n) => n, (NPC n) => new List<NPC>());
		foreach (NPC custom in customs)
		{
			NPCRelationData relationData = custom.S1NPC.RelationData;
			List<NPC> val = ((relationData != null) ? relationData.Connections : null);
			if (val == null)
			{
				continue;
			}
			Enumerator<NPC> enumerator2 = val.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				NPC current2 = enumerator2.Current;
				if (!((Object)(object)current2 == (Object)null) && current2.ID != null && dictionary.TryGetValue(current2.ID, out var value))
				{
					if (!dictionary2[custom].Contains(value))
					{
						dictionary2[custom].Add(value);
					}
					if (!dictionary2[value].Contains(custom))
					{
						dictionary2[value].Add(custom);
					}
				}
			}
		}
		return dictionary2;
	}

	private static List<NPC> ComputeInsertionOrder(List<NPC> customs, Dictionary<NPC, List<NPC>> graph, HashSet<string> nativeIds)
	{
		Dictionary<NPC, int> dist = new Dictionary<NPC, int>();
		Queue<NPC> queue = new Queue<NPC>();
		foreach (NPC custom in customs)
		{
			NPCRelationData relationData = custom.S1NPC.RelationData;
			List<NPC> val = ((relationData != null) ? relationData.Connections : null);
			if (val != null && ((IEnumerable<NPC>)val._items).Any((NPC c) => (Object)(object)c != (Object)null && nativeIds.Contains(c.ID)))
			{
				dist[custom] = 0;
				queue.Enqueue(custom);
			}
		}
		if (queue.Count == 0 && customs.Count > 0)
		{
			dist[customs[0]] = 0;
			queue.Enqueue(customs[0]);
		}
		while (queue.Count > 0)
		{
			NPC key = queue.Dequeue();
			int num = dist[key];
			foreach (NPC item in graph[key])
			{
				if (!dist.ContainsKey(item))
				{
					dist[item] = num + 1;
					queue.Enqueue(item);
				}
			}
		}
		return (from n in customs
			orderby dist.ContainsKey(n) ? dist[n] : int.MaxValue, graph[n].Count descending
			select n).ToList();
	}

	private static Vector2 ComputePlacement(RelationCircle circle, RelationCircle[] regionCircles, Dictionary<string, RelationCircle> circleById, Dictionary<RelationCircle, RectTransform> rectTransforms, List<(Vector2, Vector2)> existingEdges)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> connectionPositions = GetConnectionPositions(circle, circleById, rectTransforms);
		List<Vector2> list = regionCircles.Select((RelationCircle c) => rectTransforms[c].anchoredPosition).ToList();
		if (list.Count == 0)
		{
			return Vector2.zero;
		}
		float num = EstimateGridSpacing(list);
		Vector2 val = Mean(list);
		var (val2, val3) = EstimateLocalBasis(list, val);
		if (connectionPositions.Count > 0)
		{
			Vector2 val4 = Mean(connectionPositions);
			List<Vector2> list2 = new List<Vector2>();
			Vector2[] obj = new Vector2[16]
			{
				val2,
				-val2,
				val3,
				-val3,
				val2 + val3,
				val2 - val3,
				-val2 + val3,
				-val2 - val3,
				default(Vector2),
				default(Vector2),
				default(Vector2),
				default(Vector2),
				default(Vector2),
				default(Vector2),
				default(Vector2),
				default(Vector2)
			};
			Vector2 val5 = val2 + val3 * 2f;
			obj[8] = ((Vector2)(ref val5)).normalized;
			val5 = val2 * 2f + val3;
			obj[9] = ((Vector2)(ref val5)).normalized;
			val5 = -val2 + val3 * 2f;
			obj[10] = ((Vector2)(ref val5)).normalized;
			val5 = -val2 * 2f + val3;
			obj[11] = ((Vector2)(ref val5)).normalized;
			val5 = val2 - val3 * 2f;
			obj[12] = ((Vector2)(ref val5)).normalized;
			val5 = val2 * 2f - val3;
			obj[13] = ((Vector2)(ref val5)).normalized;
			val5 = -val2 - val3 * 2f;
			obj[14] = ((Vector2)(ref val5)).normalized;
			val5 = -val2 * 2f - val3;
			obj[15] = ((Vector2)(ref val5)).normalized;
			Vector2[] array = (Vector2[])(object)obj;
			float minDist = num * 0.7f;
			for (float num2 = num * 0.8f; num2 <= num * 3.5f; num2 += num * 0.2f)
			{
				Vector2[] array2 = array;
				foreach (Vector2 val6 in array2)
				{
					Vector2 pos = val4 + val6 * num2;
					pos = SnapToLattice(pos, val4, num, val2, val3);
					Vector2 val7 = pos + Random.insideUnitCircle * 5f;
					if (IsPositionFree(val7, list, minDist))
					{
						list2.Add(val7);
					}
				}
			}
			if (list2.Count > 0)
			{
				return PickBestPosition(list2, connectionPositions, list, existingEdges, num);
			}
			return val4 + new Vector2(0f, (0f - num) * 1.5f);
		}
		float num4 = list.Max((Vector2 p) => p.y);
		float x = val.x;
		float minDist2 = num * 0.8f;
		Vector2 val8 = default(Vector2);
		for (int num5 = 0; num5 < 20; num5++)
		{
			float num6 = num4 + num * 2f + (float)(num5 / 3) * num * 1.2f;
			float num7 = (float)(num5 % 3 - 1) * num * 0.8f;
			((Vector2)(ref val8))._002Ector(x + num7, num6);
			val8 = SnapToLattice(val8, new Vector2(x, num6), num, val2, val3);
			if (IsPositionFree(val8, list, minDist2))
			{
				return val8;
			}
		}
		return new Vector2(x, num4 + num * 2f);
	}

	private static List<Vector2> GetConnectionPositions(RelationCircle circle, Dictionary<string, RelationCircle> circleById, Dictionary<RelationCircle, RectTransform> rectTransforms)
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		NPC assignedNPC = circle.AssignedNPC;
		object obj;
		if (assignedNPC == null)
		{
			obj = null;
		}
		else
		{
			NPCRelationData relationData = assignedNPC.RelationData;
			obj = ((relationData != null) ? relationData.Connections : null);
		}
		List<NPC> val = (List<NPC>)obj;
		if (val == null || val.Count == 0)
		{
			return list;
		}
		Enumerator<NPC> enumerator = val.GetEnumerator();
		while (enumerator.MoveNext())
		{
			NPC current = enumerator.Current;
			if (!((Object)(object)current == (Object)null) && !string.IsNullOrEmpty(current.ID) && circleById.TryGetValue(current.ID, out RelationCircle value))
			{
				list.Add(rectTransforms[value].anchoredPosition);
			}
		}
		return list;
	}

	private static bool IsPositionFree(Vector2 pos, List<Vector2> existing, float minDist)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		foreach (Vector2 item in existing)
		{
			if (Vector2.Distance(item, pos) < minDist)
			{
				return false;
			}
		}
		return true;
	}

	private static Vector2 Mean(IEnumerable<Vector2> pts)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> source = pts.ToList();
		return new Vector2(source.Average((Vector2 p) => p.x), source.Average((Vector2 p) => p.y));
	}

	private static float EstimateGridSpacing(List<Vector2> pts)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (pts.Count < 2)
		{
			return 200f;
		}
		List<float> list = new List<float>();
		int i;
		for (i = 0; i < pts.Count; i++)
		{
			Vector2 p = pts[i];
			IEnumerable<Vector2> source = (from q in pts.Where((Vector2 q, int idx) => idx != i)
				orderby Vector2.Distance(p, q)
				select q).Take(3);
			list.AddRange(source.Select((Vector2 q) => Vector2.Distance(p, q)));
		}
		list.Sort();
		float num = ((list.Count > 0) ? list[list.Count / 2] : 200f);
		return Mathf.Clamp(num, 150f, 250f);
	}

	private static (Vector2, Vector2) EstimateLocalBasis(List<Vector2> pts, Vector2 center)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		float num = 0f;
		float num2 = 0f;
		float num3 = 0f;
		foreach (Vector2 pt in pts)
		{
			Vector2 val = pt - center;
			num += val.x * val.x;
			num2 += val.y * val.y;
			num3 += val.x * val.y;
		}
		float num4 = 0.5f * Mathf.Atan2(2f * num3, num - num2);
		Vector2 val2 = default(Vector2);
		((Vector2)(ref val2))._002Ector(Mathf.Cos(num4), Mathf.Sin(num4));
		Vector2 item = default(Vector2);
		((Vector2)(ref item))._002Ector(0f - val2.y, val2.x);
		return (val2, item);
	}

	private static Vector2 SnapToLattice(Vector2 pos, Vector2 origin, float grid, Vector2 right, Vector2 up)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		Vector2 normalized = ((Vector2)(ref right)).normalized;
		Vector2 normalized2 = ((Vector2)(ref up)).normalized;
		Vector2 val = pos - origin;
		float num = Vector2.Dot(val, normalized);
		float num2 = Vector2.Dot(val, normalized2);
		num = Mathf.Round(num / grid) * grid;
		num2 = Mathf.Round(num2 / grid) * grid;
		return origin + num * normalized + num2 * normalized2;
	}

	private static List<(Vector2 from, Vector2 to)> GetAllEdges(RelationCircle[] regionCircles, Dictionary<RelationCircle, RectTransform> rectTransforms)
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		List<(Vector2, Vector2)> list = new List<(Vector2, Vector2)>();
		Dictionary<string, RelationCircle> dictionary = regionCircles.Where((RelationCircle c) => !string.IsNullOrEmpty(c.AssignedNPC_ID)).ToDictionary((RelationCircle c) => c.AssignedNPC_ID, (RelationCircle c) => c);
		foreach (RelationCircle val in regionCircles)
		{
			NPC assignedNPC = val.AssignedNPC;
			object obj;
			if (assignedNPC == null)
			{
				obj = null;
			}
			else
			{
				NPCRelationData relationData = assignedNPC.RelationData;
				obj = ((relationData != null) ? relationData.Connections : null);
			}
			if (obj == null)
			{
				continue;
			}
			Vector2 anchoredPosition = rectTransforms[val].anchoredPosition;
			Enumerator<NPC> enumerator = val.AssignedNPC.RelationData.Connections.GetEnumerator();
			while (enumerator.MoveNext())
			{
				NPC current = enumerator.Current;
				if (!((Object)(object)current == (Object)null) && !string.IsNullOrEmpty(current.ID) && dictionary.TryGetValue(current.ID, out var value))
				{
					Vector2 anchoredPosition2 = rectTransforms[value].anchoredPosition;
					list.Add((anchoredPosition, anchoredPosition2));
				}
			}
		}
		return list;
	}

	private static bool LineSegmentsIntersect(Vector2 a1, Vector2 a2, Vector2 b1, Vector2 b2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		float num = (a2.x - a1.x) * (b2.y - b1.y) - (a2.y - a1.y) * (b2.x - b1.x);
		if (Mathf.Abs(num) < 0.001f)
		{
			return false;
		}
		float num2 = ((b1.x - a1.x) * (b2.y - b1.y) - (b1.y - a1.y) * (b2.x - b1.x)) / num;
		float num3 = ((b1.x - a1.x) * (a2.y - a1.y) - (b1.y - a1.y) * (a2.x - a1.x)) / num;
		return num2 >= 0f && num2 <= 1f && num3 >= 0f && num3 <= 1f;
	}

	private static int CountCrossings(Vector2 newPos, List<Vector2> anchors, List<(Vector2, Vector2)> existingEdges)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		foreach (Vector2 anchor in anchors)
		{
			foreach (var (val, val2) in existingEdges)
			{
				if (!(Vector2.Distance(val, newPos) < 1f) && !(Vector2.Distance(val2, newPos) < 1f) && !(Vector2.Distance(val, anchor) < 1f) && !(Vector2.Distance(val2, anchor) < 1f) && LineSegmentsIntersect(newPos, anchor, val, val2))
				{
					num++;
				}
			}
		}
		return num;
	}

	private static float CalculateCrowdingPenalty(Vector2 pos, List<Vector2> allPositions, float spacing)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		float num = 0f;
		float num2 = spacing * 1.25f;
		foreach (Vector2 allPosition in allPositions)
		{
			float num3 = Vector2.Distance(pos, allPosition);
			if (num3 < num2 && num3 > 0.01f)
			{
				num += Mathf.Pow((num2 - num3) / num2, 2f) * 100f;
			}
		}
		return num;
	}

	private static Vector2 PickBestPosition(List<Vector2> candidates, List<Vector2> anchors, List<Vector2> allPositions, List<(Vector2, Vector2)> existingEdges, float spacing)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		float num = float.MaxValue;
		Vector2 result = candidates[0];
		foreach (Vector2 candidate in candidates)
		{
			int num2 = CountCrossings(candidate, anchors, existingEdges);
			float num3 = anchors.Average((Vector2 a) => Vector2.Distance(candidate, a));
			float num4 = CalculateCrowdingPenalty(candidate, allPositions, spacing);
			float num5 = CalculateCircleIntersectionPenalty(candidate, anchors, allPositions, spacing);
			float num6 = (float)num2 * 50000f + num5 * 4.8f + num3 * 0.35f + num4 * 0.65f;
			if (num6 < num)
			{
				num = num6;
				result = candidate;
			}
		}
		return result;
	}

	private static float CalculateCircleIntersectionPenalty(Vector2 newPos, List<Vector2> anchors, List<Vector2> allPositions, float spacing)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		float num = 0f;
		float num2 = spacing * 0.25f;
		float num3 = num2 * 1.3f;
		foreach (Vector2 anchor in anchors)
		{
			foreach (Vector2 allPosition in allPositions)
			{
				if (!(Vector2.Distance(allPosition, newPos) < 0.8f) && !(Vector2.Distance(allPosition, anchor) < 0.8f))
				{
					float num4 = DistanceFromPointToLineSegment(allPosition, newPos, anchor);
					if (num4 < num3)
					{
						float num5 = (num3 - num4) / num3;
						num += Mathf.Pow(num5, 2f) * 500f;
					}
				}
			}
		}
		return num;
	}

	private static float DistanceFromPointToLineSegment(Vector2 point, Vector2 lineStart, Vector2 lineEnd)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = lineEnd - lineStart;
		float magnitude = ((Vector2)(ref val)).magnitude;
		if (magnitude < 0.001f)
		{
			return Vector2.Distance(point, lineStart);
		}
		Vector2 val2 = val / magnitude;
		Vector2 val3 = point - lineStart;
		float num = Vector2.Dot(val3, val2);
		num = Mathf.Clamp(num, 0f, magnitude);
		Vector2 val4 = lineStart + val2 * num;
		return Vector2.Distance(point, val4);
	}

	private static void EnableDealerIndicator(RelationCircle circle, NPC npc)
	{
		if (!((Object)(object)circle == (Object)null) && npc != null)
		{
			Transform transform = ((Component)circle).transform;
			Transform val = ((transform != null) ? transform.Find("DealerIndicator") : null);
			if (!((Object)(object)val == (Object)null))
			{
				bool active = NPC.IsDealerType(npc.GetType());
				((Component)val).gameObject.SetActive(active);
			}
		}
	}

	[HarmonyPatch(typeof(ContactsDetailPanel), "Open")]
	[HarmonyPostfix]
	private static void ContactsDetailPanel_Open_Postfix(ContactsDetailPanel __instance)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		if ((Object)(object)__instance == (Object)null || (Object)(object)((Component)__instance).transform == (Object)null || (Object)(object)__instance.TypeLabel.font == (Object)null)
		{
			return;
		}
		Transform obj = ((Component)__instance).transform.Find("Connections");
		GameObject val = ((obj != null) ? ((Component)obj).gameObject : null);
		if ((Object)(object)val == (Object)null)
		{
			val = new GameObject("Connections");
			val.transform.SetParent(((Component)__instance).transform, false);
			Text val2 = val.AddComponent<Text>();
			val2.font = __instance.TypeLabel.font;
		}
		Text component = val.GetComponent<Text>();
		if ((Object)(object)component == (Object)null)
		{
			Debug.LogWarning(Object.op_Implicit("Connections Text Component not found!"));
			return;
		}
		NPC selectedNPC = __instance.SelectedNPC;
		object obj2;
		if (selectedNPC == null)
		{
			obj2 = null;
		}
		else
		{
			NPCRelationData relationData = selectedNPC.RelationData;
			obj2 = ((relationData != null) ? relationData.Connections : null);
		}
		List<NPC> val3 = (List<NPC>)obj2;
		if (val3 == null || val3.Count == 0)
		{
			component.text = "Connections: None";
			return;
		}
		string text = string.Join(", ", ((IEnumerable<NPC>)val3._items).Where((NPC c) => (Object)(object)c != (Object)null).Select(delegate(NPC c)
		{
			if (c.RelationData == null)
			{
				return "???";
			}
			return (!NPC.IsCustomerType(((object)c).GetType())) ? (c.RelationData.Unlocked ? c.fullName : "???") : (c.RelationData.IsKnown() ? c.fullName : "???");
		}));
		component.text = "Connections: " + text;
	}
}
