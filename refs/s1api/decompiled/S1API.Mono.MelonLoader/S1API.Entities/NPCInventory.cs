using System;
using System.Collections.Generic;
using System.Reflection;
using FishNet.Object;
using S1API.Logging;
using S1API.Utils;
using ScheduleOne;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.NPCs;
using UnityEngine;
using UnityEngine.Events;

namespace S1API.Entities;

public sealed class NPCInventory
{
	private static readonly Log Logger = new Log("NPCInventory");

	internal readonly NPC NPC;

	internal NPCInventory Component => NPC.gameObject.GetComponent<NPCInventory>();

	internal NPCInventory(NPC npc)
	{
		NPC = npc;
	}

	public bool CanItemFit(string itemId, int quantity = 1)
	{
		if (string.IsNullOrEmpty(itemId) || quantity <= 0)
		{
			return false;
		}
		ItemInstance val = BuildTempItem(itemId, quantity);
		if (val == null)
		{
			return false;
		}
		return CanItemFitInternal(val);
	}

	public int GetCapacityForItem(string itemId, int quantity = 1)
	{
		if (string.IsNullOrEmpty(itemId) || quantity <= 0)
		{
			return 0;
		}
		ItemInstance val = BuildTempItem(itemId, quantity);
		if (val == null)
		{
			return 0;
		}
		return GetCapacityForItemInternal(val);
	}

	public bool TryInsert(string itemId, int quantity = 1, bool network = true)
	{
		if (string.IsNullOrEmpty(itemId) || quantity <= 0)
		{
			return false;
		}
		ItemInstance val = BuildTempItem(itemId, quantity);
		if (val == null)
		{
			return false;
		}
		if (!CanItemFitInternal(val))
		{
			return false;
		}
		InsertItemInternal(val, network);
		return true;
	}

	public void EnsureInitialized()
	{
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected O, but got Unknown
		string text = NPC?.S1NPC?.ID ?? "<null>";
		NPCInventory inv = Component;
		if ((Object)(object)inv == (Object)null)
		{
			NPCInventory val = NPC.gameObject.GetComponent<NPCInventory>() ?? NPC.gameObject.AddComponent<NPCInventory>();
			inv = val;
		}
		if (inv.ItemSlots == null)
		{
			inv.ItemSlots = new List<ItemSlot>();
		}
		int num = DeduplicateSlots(inv);
		int count = inv.ItemSlots.Count;
		int slotCount = inv.SlotCount;
		if (count > slotCount)
		{
			int num2 = count - slotCount;
			for (int num3 = count - 1; num3 >= slotCount; num3--)
			{
				ItemSlot val2 = inv.ItemSlots[num3];
				if (val2 != null)
				{
					try
					{
						val2.ClearStoredInstance(true);
					}
					catch
					{
					}
				}
				inv.ItemSlots.RemoveAt(num3);
			}
			count = inv.ItemSlots.Count;
		}
		for (int i = 0; i < inv.ItemSlots.Count; i++)
		{
			ItemSlot val3 = inv.ItemSlots[i];
			if (val3 != null)
			{
				try
				{
					ReflectionUtils.TrySetFieldOrProperty(val3, "ActiveLock", null);
				}
				catch
				{
				}
				try
				{
					ReflectionUtils.TrySetFieldOrProperty(val3, "IsAddLocked", false);
				}
				catch
				{
				}
			}
		}
		if (count < slotCount)
		{
			int num4 = slotCount - count;
			for (int j = 0; j < num4; j++)
			{
				ItemSlot val4 = new ItemSlot();
				val4.onItemDataChanged = (Action)Delegate.Combine(val4.onItemDataChanged, (Action)delegate
				{
					try
					{
						UnityEvent onContentsChanged = inv.onContentsChanged;
						if (onContentsChanged != null)
						{
							onContentsChanged.Invoke();
						}
					}
					catch
					{
						try
						{
							object? obj11 = typeof(NPCInventory).GetField("onContentsChanged", BindingFlags.Instance | BindingFlags.Public)?.GetValue(inv);
							UnityEvent val8 = (UnityEvent)((obj11 is UnityEvent) ? obj11 : null);
							if (val8 != null)
							{
								val8.Invoke();
							}
						}
						catch
						{
						}
					}
				});
				val4.SetSlotOwner((IItemSlotOwner)(object)inv);
				try
				{
					ReflectionUtils.TrySetFieldOrProperty(val4, "ActiveLock", null);
				}
				catch
				{
				}
				try
				{
					ReflectionUtils.TrySetFieldOrProperty(val4, "IsAddLocked", false);
				}
				catch
				{
				}
			}
		}
		if ((Object)(object)inv.PickpocketIntObj == (Object)null)
		{
			object? obj6 = NPC.GetType().GetMethod("GetPrimaryInteractable", BindingFlags.Instance | BindingFlags.NonPublic)?.Invoke(NPC, null);
			InteractableObject val5 = (InteractableObject)((obj6 is InteractableObject) ? obj6 : null);
			InteractableObject[] componentsInChildren = NPC.gameObject.GetComponentsInChildren<InteractableObject>(true);
			InteractableObject val6 = null;
			for (int num5 = 0; num5 < componentsInChildren.Length; num5++)
			{
				if ((Object)(object)componentsInChildren[num5] != (Object)null && (Object)(object)componentsInChildren[num5] != (Object)(object)val5)
				{
					val6 = componentsInChildren[num5];
					break;
				}
			}
			if ((Object)(object)val6 == (Object)null)
			{
				val6 = NPC.gameObject.AddComponent<InteractableObject>();
			}
			inv.PickpocketIntObj = val6;
		}
		try
		{
			ReflectionUtils.TrySetFieldOrProperty(inv, "npc", NPC.S1NPC);
		}
		catch
		{
		}
		try
		{
			object? obj8 = ReflectionUtils.TryGetFieldOrProperty(inv, "onContentsChanged");
			UnityEvent val7 = (UnityEvent)((obj8 is UnityEvent) ? obj8 : null);
			if (val7 == null)
			{
				ReflectionUtils.TrySetFieldOrProperty(inv, "onContentsChanged", (object)new UnityEvent());
			}
		}
		catch
		{
		}
		try
		{
			((NetworkBehaviour)inv).NetworkInitializeIfDisabled();
		}
		catch (Exception ex)
		{
			Logger.Warning("[NPCInventory] EnsureInitialized: NetworkInitializeIfDisabled threw for '" + text + "': " + ex.Message);
		}
	}

	private ItemInstance BuildTempItem(string itemId, int quantity)
	{
		try
		{
			ItemDefinition item = Registry.GetItem(itemId);
			if ((Object)(object)item == (Object)null)
			{
				return null;
			}
			ItemInstance defaultInstance = item.GetDefaultInstance(1);
			ItemInstance copy = defaultInstance.GetCopy(quantity);
			return copy ?? defaultInstance;
		}
		catch
		{
			return null;
		}
	}

	internal bool CanItemFitInternal(ItemInstance item)
	{
		if (item == null)
		{
			return false;
		}
		EnsureInitialized();
		NPCInventory component = Component;
		return (Object)(object)component != (Object)null && component.CanItemFit(item);
	}

	internal int GetCapacityForItemInternal(ItemInstance item)
	{
		if (item == null)
		{
			return 0;
		}
		EnsureInitialized();
		NPCInventory component = Component;
		return ((Object)(object)component != (Object)null) ? component.GetCapacityForItem(item) : 0;
	}

	internal void InsertItemInternal(ItemInstance item, bool network = true)
	{
		if (item != null)
		{
			EnsureInitialized();
			NPCInventory component = Component;
			if (component != null)
			{
				component.InsertItem(item, network);
			}
		}
	}

	private int DeduplicateSlots(NPCInventory inv)
	{
		if (((inv != null) ? inv.ItemSlots : null) == null)
		{
			return 0;
		}
		try
		{
			HashSet<object> hashSet = new HashSet<object>();
			List<int> list = new List<int>();
			for (int i = 0; i < inv.ItemSlots.Count; i++)
			{
				ItemSlot val = inv.ItemSlots[i];
				if (val == null)
				{
					list.Add(i);
				}
				else if (hashSet.Contains(val))
				{
					try
					{
						val.ClearStoredInstance(true);
					}
					catch
					{
					}
					list.Add(i);
				}
				else
				{
					hashSet.Add(val);
				}
			}
			for (int num = list.Count - 1; num >= 0; num--)
			{
				inv.ItemSlots.RemoveAt(list[num]);
			}
			return list.Count;
		}
		catch (Exception ex)
		{
			Logger.Warning("[NPCInventory] DeduplicateSlots: Failed with exception: " + ex.Message);
			Logger.Warning("[NPCInventory] DeduplicateSlots: Stack trace: " + ex.StackTrace);
			return 0;
		}
	}
}
