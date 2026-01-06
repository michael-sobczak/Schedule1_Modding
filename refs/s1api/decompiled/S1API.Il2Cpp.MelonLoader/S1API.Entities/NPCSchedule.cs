using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppFishNet;
using Il2CppFishNet.Managing.Transporting;
using Il2CppFishNet.Object;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.Schedules;
using Il2CppSystem;
using S1API.Entities.Schedule;
using UnityEngine;

namespace S1API.Entities;

public sealed class NPCSchedule
{
	internal readonly NPC NPC;

	public bool IsEnabled => (Object)(object)Manager != (Object)null && Manager.ScheduleEnabled;

	public bool CurfewModeEnabled => (Object)(object)Manager != (Object)null && Manager.CurfewModeEnabled;

	internal NPCScheduleManager Manager => NPC.gameObject.GetComponentInChildren<NPCScheduleManager>(true);

	internal NPC Owner => NPC;

	internal NPCSchedule(NPC npc)
	{
		NPC = npc;
	}

	public void Enable()
	{
		EnsureManager();
		NPCScheduleManager manager = Manager;
		if (manager != null)
		{
			manager.EnableSchedule();
		}
	}

	public void Disable()
	{
		NPCScheduleManager manager = Manager;
		if (manager != null)
		{
			manager.DisableSchedule();
		}
	}

	internal void InitializeActions()
	{
		EnsureManager();
		NPCScheduleManager manager = Manager;
		if (manager != null)
		{
			manager.InitializeActions();
		}
	}

	public void EnforceState()
	{
		NPCScheduleManager manager = Manager;
		if (manager != null)
		{
			manager.EnforceState();
		}
	}

	public void SetCurfewMode(bool enabled)
	{
		if (!((Object)(object)Manager == (Object)null))
		{
			Manager.SetCurfewModeEnabled(enabled);
		}
	}

	public string GetActiveActionName()
	{
		return ((Object)(object)Manager != (Object)null && (Object)(object)Manager.ActiveAction != (Object)null) ? ((Object)Manager.ActiveAction).name : string.Empty;
	}

	internal T AddActionInternal<T>(int startTime, string name = null) where T : NPCAction
	{
		EnsureManager();
		if ((Object)(object)Manager == (Object)null)
		{
			return default(T);
		}
		Il2CppArrayBase<T> componentsInChildren = ((Component)Manager).GetComponentsInChildren<T>(true);
		T val = default(T);
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			T val2 = componentsInChildren[i];
			if (!((Object)(object)val2 == (Object)null) && !((Component)(object)val2).gameObject.activeSelf)
			{
				val = val2;
				break;
			}
		}
		if ((Object)(object)val == (Object)null)
		{
			if (componentsInChildren.Length <= 0)
			{
				Debug.LogWarning(Object.op_Implicit("[S1API] No available pre-created actions of type " + typeof(T).Name + ". Add more via NPC.ConfigurePrefab."));
				return default(T);
			}
			val = componentsInChildren[0];
		}
		if ((Object)(object)val == (Object)null)
		{
			return default(T);
		}
		if (!string.IsNullOrEmpty(name))
		{
			((Object)((Component)(object)val).gameObject).name = name;
		}
		((NPCAction)val).SetStartTime(startTime);
		if (!((Component)(object)val).gameObject.activeSelf)
		{
			((Component)(object)val).gameObject.SetActive(true);
		}
		((Behaviour)(object)val).enabled = true;
		return val;
	}

	internal void AddActionFromSpec(IScheduleActionSpec spec)
	{
		spec?.ApplyTo(this);
	}

	public void EnsureDealSignal()
	{
		NPCScheduleManager manager = Manager;
		if ((Object)(object)manager == (Object)null)
		{
			EnsureManager();
			manager = Manager;
			if ((Object)(object)manager == (Object)null)
			{
				return;
			}
		}
		NPCSignal_WaitForDelivery componentInChildren = ((Component)manager).GetComponentInChildren<NPCSignal_WaitForDelivery>(true);
		if ((Object)(object)componentInChildren != (Object)null)
		{
			TryNetworkInitialize(componentInChildren);
			TryWireCustomerDealSignal(componentInChildren);
			TryAssignDealSignalField(componentInChildren);
		}
		else
		{
			Debug.LogWarning(Object.op_Implicit("[S1API] DealSignal missing on prefab. Please add via NPC.ConfigurePrefab(builder.EnsureDealSignal())."));
		}
	}

	private void TryWireCustomerDealSignal(NPCSignal_WaitForDelivery signal)
	{
		try
		{
			Customer component = NPC.gameObject.GetComponent<Customer>();
			if (!((Object)(object)component == (Object)null))
			{
				typeof(Customer).GetField("DealSignal", BindingFlags.Instance | BindingFlags.Public)?.SetValue(component, signal);
			}
		}
		catch
		{
		}
	}

	private void TryAssignDealSignalField(NPCSignal_WaitForDelivery signal)
	{
		try
		{
			Customer component = NPC.gameObject.GetComponent<Customer>();
			if (!((Object)(object)component == (Object)null) && !((Object)(object)signal == (Object)null))
			{
				component.DealSignal = signal;
			}
		}
		catch
		{
		}
	}

	public void ClearActions(bool includeSignals = true, bool includeEvents = true)
	{
		if ((Object)(object)Manager == (Object)null)
		{
			return;
		}
		Il2CppArrayBase<NPCAction> componentsInChildren = ((Component)Manager).GetComponentsInChildren<NPCAction>(true);
		foreach (NPCAction item in componentsInChildren)
		{
			bool flag = item is NPCSignal;
			bool flag2 = item is NPCEvent;
			if (((flag && includeSignals) || (flag2 && includeEvents)) && (Object)(object)item != (Object)null && (Object)(object)((Component)item).gameObject != (Object)null)
			{
				((Component)item).gameObject.SetActive(false);
				((Behaviour)item).enabled = false;
				try
				{
					item.SetStartTime(0);
				}
				catch
				{
				}
			}
		}
		Manager.InitializeActions();
	}

	public IReadOnlyList<string> GetActionNames()
	{
		if ((Object)(object)Manager == (Object)null)
		{
			return Array.Empty<string>();
		}
		Il2CppArrayBase<NPCAction> componentsInChildren = ((Component)Manager).GetComponentsInChildren<NPCAction>(true);
		List<string> list = new List<string>(componentsInChildren.Length);
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			list.Add(((Object)(object)componentsInChildren[i] != (Object)null) ? ((Object)componentsInChildren[i]).name : string.Empty);
		}
		return list;
	}

	internal void EnsureManager()
	{
		NPCScheduleManager componentInChildren = NPC.gameObject.GetComponentInChildren<NPCScheduleManager>(true);
		if ((Object)(object)componentInChildren == (Object)null)
		{
			Debug.LogWarning(Object.op_Implicit("[S1API] NPCScheduleManager is missing. Ensure it is added in NPC.ConfigurePrefab."));
		}
	}

	private void TryNetworkInitialize(object behaviour)
	{
		if (behaviour == null)
		{
			return;
		}
		try
		{
			NetworkObject component = NPC.gameObject.GetComponent<NetworkObject>();
			TransportManager transportManager = InstanceFinder.TransportManager;
			if (!((Object)(object)component == (Object)null) && !((Object)(object)transportManager == (Object)null))
			{
				SetNonPublicInstanceField(behaviour, "_networkObjectCache", component);
				SetNonPublicInstanceField(behaviour, "_transportManagerCache", transportManager);
			}
		}
		catch
		{
		}
	}

	private static void SetNonPublicInstanceField(object target, string fieldName, object value)
	{
		try
		{
			if (target != null && !string.IsNullOrEmpty(fieldName))
			{
				Type type = target.GetType();
				FieldInfo fieldInfo = null;
				while (type != null && fieldInfo == null)
				{
					fieldInfo = type.GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic);
					type = type.BaseType;
				}
				fieldInfo?.SetValue(target, value);
			}
		}
		catch
		{
		}
	}
}
