using System;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Storage;
using Il2CppSystem.Collections.Generic;
using S1API.Items;
using S1API.Logging;
using UnityEngine;

namespace S1API.Storage;

public sealed class StorageEntity
{
	private static readonly Log Logger = new Log("StorageEntity");

	internal readonly StorageEntity S1StorageEntity;

	internal readonly PlaceableStorageEntity S1PlaceableStorageEntity;

	public string Name
	{
		get
		{
			return S1StorageEntity.StorageEntityName;
		}
		set
		{
			S1StorageEntity.StorageEntityName = value;
		}
	}

	public int SlotCount
	{
		get
		{
			return S1StorageEntity.SlotCount;
		}
		set
		{
			if (value < 0)
			{
				Logger.Warning("Cannot set SlotCount to negative value");
				return;
			}
			if (value > MaxSlots)
			{
				Logger.Warning($"Cannot set SlotCount to {value}, maximum is {MaxSlots}");
				return;
			}
			int count = S1StorageEntity.ItemSlots.Count;
			if (value > count)
			{
				AddSlots(value - count);
			}
			else if (value < count)
			{
				RemoveSlots(count - value);
			}
		}
	}

	public int MaxSlots { get; set; } = 20;

	public int DisplayRowCount
	{
		get
		{
			return S1StorageEntity.DisplayRowCount;
		}
		set
		{
			S1StorageEntity.DisplayRowCount = value;
		}
	}

	public bool SlotsAreFilterable => S1StorageEntity.SlotsAreFilterable;

	public ItemInstance ItemInstance
	{
		get
		{
			PlaceableStorageEntity s1PlaceableStorageEntity = S1PlaceableStorageEntity;
			if (((s1PlaceableStorageEntity != null) ? ((BuildableItem)s1PlaceableStorageEntity).ItemInstance : null) == null)
			{
				return null;
			}
			return new ItemInstance(((BuildableItem)S1PlaceableStorageEntity).ItemInstance);
		}
	}

	public string ItemId
	{
		get
		{
			PlaceableStorageEntity s1PlaceableStorageEntity = S1PlaceableStorageEntity;
			object result;
			if (s1PlaceableStorageEntity == null)
			{
				result = null;
			}
			else
			{
				ItemInstance itemInstance = ((BuildableItem)s1PlaceableStorageEntity).ItemInstance;
				if (itemInstance == null)
				{
					result = null;
				}
				else
				{
					ItemDefinition definition = itemInstance.Definition;
					result = ((definition != null) ? definition.ID : null);
				}
			}
			return (string)result;
		}
	}

	public bool IsPlaceable => (Object)(object)S1PlaceableStorageEntity != (Object)null;

	public string CustomName
	{
		get
		{
			PlaceableStorageEntity s1PlaceableStorageEntity = S1PlaceableStorageEntity;
			object result;
			if (s1PlaceableStorageEntity == null)
			{
				result = null;
			}
			else
			{
				EntityConfiguration configuration = s1PlaceableStorageEntity.Configuration;
				if (configuration == null)
				{
					result = null;
				}
				else
				{
					StringField name = configuration.Name;
					result = ((name != null) ? name.Value : null);
				}
			}
			return (string)result;
		}
		set
		{
			PlaceableStorageEntity s1PlaceableStorageEntity = S1PlaceableStorageEntity;
			object obj;
			if (s1PlaceableStorageEntity == null)
			{
				obj = null;
			}
			else
			{
				EntityConfiguration configuration = s1PlaceableStorageEntity.Configuration;
				obj = ((configuration != null) ? configuration.Name : null);
			}
			if (obj != null && !string.IsNullOrEmpty(value))
			{
				S1PlaceableStorageEntity.Configuration.Name.SetValue(value, true);
			}
		}
	}

	public bool HasCustomName => !string.IsNullOrEmpty(CustomName);

	internal StorageEntity(StorageEntity storageEntity, PlaceableStorageEntity placeableStorage = null)
	{
		S1StorageEntity = storageEntity ?? throw new ArgumentNullException("storageEntity");
		S1PlaceableStorageEntity = placeableStorage;
	}

	public void SyncCustomNameToDisplayName()
	{
		if (HasCustomName)
		{
			Name = CustomName;
		}
	}

	public bool AddSlots(int count)
	{
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		if (count <= 0)
		{
			Logger.Warning("AddSlots called with non-positive count");
			return false;
		}
		int count2 = S1StorageEntity.ItemSlots.Count;
		int num = count2 + count;
		if (num > MaxSlots)
		{
			Logger.Warning($"Cannot add {count} slots, would exceed MaxSlots ({MaxSlots})");
			return false;
		}
		try
		{
			for (int i = 0; i < count; i++)
			{
				ItemSlot val = new ItemSlot(S1StorageEntity.SlotsAreFilterable);
				val.SetSlotOwner(((Il2CppObjectBase)S1StorageEntity).Cast<IItemSlotOwner>());
			}
			S1StorageEntity.SlotCount = num;
			if ((Object)(object)S1PlaceableStorageEntity != (Object)null)
			{
				int count3 = S1StorageEntity.ItemSlots.Count;
				for (int j = count2; j < count3; j++)
				{
					ItemSlot val2 = S1StorageEntity.ItemSlots[j];
					S1PlaceableStorageEntity.InputSlots.Add(val2);
					S1PlaceableStorageEntity.OutputSlots.Add(val2);
				}
			}
			if (num > 6 && DisplayRowCount < 2)
			{
				DisplayRowCount = 2;
			}
			return true;
		}
		catch (Exception ex)
		{
			Logger.Error("Failed to add slots: " + ex.Message);
			return false;
		}
	}

	public bool RemoveSlots(int count)
	{
		if (count <= 0)
		{
			Logger.Warning("RemoveSlots called with non-positive count");
			return false;
		}
		int count2 = S1StorageEntity.ItemSlots.Count;
		if (count > count2)
		{
			Logger.Warning($"Cannot remove {count} slots, only {count2} exist");
			return false;
		}
		try
		{
			for (int i = count2 - count; i < count2; i++)
			{
				if (S1StorageEntity.ItemSlots[i].ItemInstance != null)
				{
					Logger.Warning($"Cannot remove slot {i}, it contains an item");
					return false;
				}
			}
			for (int j = 0; j < count; j++)
			{
				int num = S1StorageEntity.ItemSlots.Count - 1;
				ItemSlot val = S1StorageEntity.ItemSlots[num];
				if ((Object)(object)S1PlaceableStorageEntity != (Object)null)
				{
					S1PlaceableStorageEntity.InputSlots.Remove(val);
					S1PlaceableStorageEntity.OutputSlots.Remove(val);
				}
				S1StorageEntity.ItemSlots.RemoveAt(num);
			}
			S1StorageEntity.SlotCount = count2 - count;
			return true;
		}
		catch (Exception ex)
		{
			Logger.Error("Failed to remove slots: " + ex.Message);
			return false;
		}
	}

	public bool SetSlotCount(int targetSlotCount)
	{
		if (targetSlotCount < 0)
		{
			Logger.Warning("Cannot set negative slot count");
			return false;
		}
		int count = S1StorageEntity.ItemSlots.Count;
		int num = targetSlotCount - count;
		if (num > 0)
		{
			return AddSlots(num);
		}
		if (num < 0)
		{
			return RemoveSlots(-num);
		}
		return true;
	}

	public int GetEmptySlotCount()
	{
		int num = 0;
		Enumerator<ItemSlot> enumerator = S1StorageEntity.ItemSlots.GetEnumerator();
		while (enumerator.MoveNext())
		{
			ItemSlot current = enumerator.Current;
			if (current.ItemInstance == null)
			{
				num++;
			}
		}
		return num;
	}

	public int GetOccupiedSlotCount()
	{
		return S1StorageEntity.ItemSlots.Count - GetEmptySlotCount();
	}

	public bool HasItems()
	{
		Enumerator<ItemSlot> enumerator = S1StorageEntity.ItemSlots.GetEnumerator();
		while (enumerator.MoveNext())
		{
			ItemSlot current = enumerator.Current;
			if (current.ItemInstance != null)
			{
				return true;
			}
		}
		return false;
	}

	public bool IsEmpty()
	{
		return !HasItems();
	}
}
