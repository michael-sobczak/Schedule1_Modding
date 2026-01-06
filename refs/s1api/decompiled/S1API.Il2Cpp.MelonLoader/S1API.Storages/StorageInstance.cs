using System;
using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Storage;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using S1API.Internal.Abstraction;
using S1API.Items;

namespace S1API.Storages;

public class StorageInstance
{
	internal readonly StorageEntity S1Storage;

	public string Name => S1Storage.StorageEntityName;

	public string Subtitle => S1Storage.StorageEntitySubtitle;

	public int SlotCount => S1Storage.SlotCount;

	public int ItemCount => S1Storage.ItemCount;

	public StorageAccessSettings AccessSettings
	{
		get
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected I4, but got Unknown
			return (StorageAccessSettings)S1Storage.AccessSettings;
		}
		set
		{
			S1Storage.AccessSettings = (EAccessSettings)value;
		}
	}

	public bool IsOpened => S1Storage.IsOpened;

	public ItemSlotInstance[] Slots => ((IEnumerable<ItemSlot>)S1Storage.ItemSlots.ToArray()).Select((ItemSlot itemSlot) => new ItemSlotInstance(itemSlot)).ToArray();

	public event Action OnOpened
	{
		add
		{
			EventHelper.AddListener(value, (Action<Action>)delegate(Action h)
			{
				StorageEntity s1Storage = S1Storage;
				s1Storage.onOpened += Action.op_Implicit(h);
			});
		}
		remove
		{
			EventHelper.RemoveListener(value, (Action<Action>)delegate(Action h)
			{
				StorageEntity s1Storage = S1Storage;
				s1Storage.onOpened -= Action.op_Implicit(h);
			});
		}
	}

	public event Action OnClosed
	{
		add
		{
			EventHelper.AddListener(value, (Action<Action>)delegate(Action h)
			{
				StorageEntity s1Storage = S1Storage;
				s1Storage.onClosed += Action.op_Implicit(h);
			});
		}
		remove
		{
			EventHelper.RemoveListener(value, (Action<Action>)delegate(Action h)
			{
				StorageEntity s1Storage = S1Storage;
				s1Storage.onClosed -= Action.op_Implicit(h);
			});
		}
	}

	public event Action OnContentsChanged
	{
		add
		{
			EventHelper.AddListener(value, (Action<Action>)delegate(Action h)
			{
				StorageEntity s1Storage = S1Storage;
				s1Storage.onContentsChanged += Action.op_Implicit(h);
			});
		}
		remove
		{
			EventHelper.RemoveListener(value, (Action<Action>)delegate(Action h)
			{
				StorageEntity s1Storage = S1Storage;
				s1Storage.onContentsChanged -= Action.op_Implicit(h);
			});
		}
	}

	internal StorageInstance(StorageEntity storage)
	{
		S1Storage = storage;
	}

	public ItemInstance[] GetItems()
	{
		List<ItemInstance> allItems = S1Storage.GetAllItems();
		if (allItems == null || allItems.Count == 0)
		{
			return Array.Empty<ItemInstance>();
		}
		ItemInstance[] array = new ItemInstance[allItems.Count];
		for (int i = 0; i < allItems.Count; i++)
		{
			array[i] = new ItemInstance(allItems[i]);
		}
		return array;
	}

	public Dictionary<ItemInstance, int> GetContentsDictionary()
	{
		Dictionary<StorableItemInstance, int> contentsDictionary = S1Storage.GetContentsDictionary();
		Dictionary<ItemInstance, int> dictionary = new Dictionary<ItemInstance, int>();
		Enumerator<StorableItemInstance, int> enumerator = contentsDictionary.GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<StorableItemInstance, int> current = enumerator.Current;
			if (current.Key != null)
			{
				dictionary[new ItemInstance((ItemInstance)(object)current.Key)] = current.Value;
			}
		}
		return dictionary;
	}

	public bool CanItemFit(ItemInstance itemInstance, int quantity = 1)
	{
		return S1Storage.CanItemFit(itemInstance.S1ItemInstance, quantity);
	}

	public void AddItem(ItemInstance itemInstance)
	{
		S1Storage.InsertItem(itemInstance.S1ItemInstance, true);
	}

	public int RemoveItem(ItemInstance itemInstance)
	{
		if (itemInstance == null)
		{
			return 0;
		}
		int num = 0;
		List<ItemSlot> itemSlots = S1Storage.ItemSlots;
		for (int i = 0; i < itemSlots.Count; i++)
		{
			ItemSlot val = itemSlots[i];
			if (val.ItemInstance != null && val.ItemInstance == itemInstance.S1ItemInstance)
			{
				int quantity = val.Quantity;
				val.ClearStoredInstance(false);
				num += quantity;
				break;
			}
		}
		return num;
	}

	public int TryRemoveQuantity(string itemDefinitionId, int quantity)
	{
		if (string.IsNullOrEmpty(itemDefinitionId) || quantity <= 0)
		{
			return 0;
		}
		int num = quantity;
		List<ItemSlot> itemSlots = S1Storage.ItemSlots;
		for (int i = 0; i < itemSlots.Count; i++)
		{
			if (num <= 0)
			{
				break;
			}
			ItemSlot val = itemSlots[i];
			if (val.ItemInstance != null && val.ItemInstance.ID == itemDefinitionId)
			{
				int quantity2 = val.Quantity;
				int num2 = Math.Min(num, quantity2);
				num -= num2;
				if (num2 >= quantity2)
				{
					val.ClearStoredInstance(false);
				}
				else
				{
					val.ChangeQuantity(-num2, false);
				}
			}
		}
		return quantity - num;
	}

	public int RemoveAllOfDefinition(string itemDefinitionId)
	{
		if (string.IsNullOrEmpty(itemDefinitionId))
		{
			return 0;
		}
		int num = 0;
		List<ItemSlot> itemSlots = S1Storage.ItemSlots;
		for (int i = 0; i < itemSlots.Count; i++)
		{
			ItemSlot val = itemSlots[i];
			if (val.ItemInstance != null && val.ItemInstance.ID == itemDefinitionId)
			{
				num += val.Quantity;
				val.ClearStoredInstance(false);
			}
		}
		return num;
	}
}
