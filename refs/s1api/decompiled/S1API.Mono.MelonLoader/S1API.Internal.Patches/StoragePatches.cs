using System;
using System.Collections.Generic;
using HarmonyLib;
using S1API.Logging;
using S1API.Storage;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.Storage;
using ScheduleOne.UI;
using UnityEngine;

namespace S1API.Internal.Patches;

[HarmonyPatch]
internal static class StoragePatches
{
	[Serializable]
	private class StorageSlotMeta : SaveData
	{
		public int SlotCount;

		public int DisplayRowCount;

		public string ItemId;
	}

	private static readonly Log Logger = new Log("StoragePatches");

	private static readonly HashSet<int> _processedStorages = new HashSet<int>();

	private const string ExtraSlotMetaKey = "S1API_Storage_SlotMeta";

	private static StorageSlotMeta ParseStorageSlotMeta(string json)
	{
		if (string.IsNullOrEmpty(json))
		{
			return null;
		}
		try
		{
			StorageSlotMeta storageSlotMeta = new StorageSlotMeta();
			int num = json.IndexOf("\"SlotCount\":");
			if (num >= 0)
			{
				int num2 = num + 12;
				int num3 = json.IndexOfAny(new char[2] { ',', '}' }, num2);
				if (num3 > num2 && int.TryParse(json.Substring(num2, num3 - num2), out var result))
				{
					storageSlotMeta.SlotCount = result;
				}
			}
			int num4 = json.IndexOf("\"DisplayRowCount\":");
			if (num4 >= 0)
			{
				int num5 = num4 + 18;
				int num6 = json.IndexOfAny(new char[2] { ',', '}' }, num5);
				if (num6 > num5 && int.TryParse(json.Substring(num5, num6 - num5), out var result2))
				{
					storageSlotMeta.DisplayRowCount = result2;
				}
			}
			int num7 = json.IndexOf("\"ItemId\":\"");
			if (num7 >= 0)
			{
				int num8 = num7 + 10;
				int num9 = json.IndexOf("\"", num8);
				if (num9 > num8)
				{
					storageSlotMeta.ItemId = json.Substring(num8, num9 - num8);
				}
			}
			return storageSlotMeta;
		}
		catch
		{
			return null;
		}
	}

	[HarmonyPatch(typeof(PlaceableStorageEntity), "Start")]
	[HarmonyPostfix]
	private static void PlaceableStorageEntity_Start_Postfix(PlaceableStorageEntity __instance)
	{
		object obj;
		if (__instance == null)
		{
			obj = null;
		}
		else
		{
			ItemInstance itemInstance = ((BuildableItem)__instance).ItemInstance;
			obj = ((itemInstance != null) ? itemInstance.Definition : null);
		}
		if ((Object)obj == (Object)null || (Object)(object)__instance.StorageEntity == (Object)null)
		{
			return;
		}
		int instanceID = ((Object)__instance).GetInstanceID();
		if (_processedStorages.Contains(instanceID))
		{
			return;
		}
		_processedStorages.Add(instanceID);
		try
		{
			StorageEntity storage = new StorageEntity(__instance.StorageEntity, __instance);
			StorageEventArgs args = new StorageEventArgs(storage);
			StorageEvents.RaiseStorageCreated(args);
		}
		catch (Exception ex)
		{
			Logger.Error("Error in PlaceableStorageEntity_Start_Postfix: " + ex.Message);
		}
	}

	[HarmonyPatch(typeof(PlaceableStorageEntity), "InitializeGridItem")]
	[HarmonyPostfix]
	private static void PlaceableStorageEntity_InitializeGridItem_Postfix(PlaceableStorageEntity __instance)
	{
		object obj;
		if (__instance == null)
		{
			obj = null;
		}
		else
		{
			ItemInstance itemInstance = ((BuildableItem)__instance).ItemInstance;
			obj = ((itemInstance != null) ? itemInstance.Definition : null);
		}
		if ((Object)obj == (Object)null || (Object)(object)__instance.StorageEntity == (Object)null)
		{
			return;
		}
		int instanceID = ((Object)__instance).GetInstanceID();
		if (_processedStorages.Contains(instanceID))
		{
			return;
		}
		_processedStorages.Add(instanceID);
		try
		{
			StorageEntity storage = new StorageEntity(__instance.StorageEntity, __instance);
			StorageEventArgs args = new StorageEventArgs(storage);
			StorageEvents.RaiseStorageCreated(args);
		}
		catch (Exception ex)
		{
			Logger.Error("Error in PlaceableStorageEntity_InitializeGridItem_Postfix: " + ex.Message);
		}
	}

	[HarmonyPatch(typeof(ItemSet), "LoadTo", new Type[] { typeof(List<ItemSlot>) })]
	[HarmonyPrefix]
	private static void ItemSet_LoadTo_Prefix(ItemSet __instance, List<ItemSlot> slots)
	{
		if (__instance.Items == null || slots == null || __instance.Items.Length <= slots.Count || slots.Count == 0)
		{
			return;
		}
		try
		{
			IItemSlotOwner slotOwner = slots[0].SlotOwner;
			if (slotOwner == null)
			{
				return;
			}
			StorageEntity val = null;
			val = (StorageEntity)(object)((slotOwner is StorageEntity) ? slotOwner : null);
			if ((Object)(object)val == (Object)null)
			{
				return;
			}
			PlaceableStorageEntity componentInParent = ((Component)val).GetComponentInParent<PlaceableStorageEntity>();
			StorageEntity storage = new StorageEntity(val, componentInParent);
			StorageLoadingEventArgs args = new StorageLoadingEventArgs(storage, __instance.Items.Length);
			StorageEvents.RaiseStorageLoading(args);
			int count = val.ItemSlots.Count;
			if (slots.Count < count)
			{
				for (int i = slots.Count; i < count; i++)
				{
					slots.Add(val.ItemSlots[i]);
				}
			}
		}
		catch (Exception ex)
		{
			Logger.Error("Error in ItemSet_LoadTo_Prefix: " + ex.Message);
		}
	}

	[HarmonyPatch(typeof(BuildableItem), "GetSaveData")]
	[HarmonyPostfix]
	private static void BuildableItem_GetSaveData_Postfix(BuildableItem __instance, ref DynamicSaveData __result)
	{
		PlaceableStorageEntity val = (PlaceableStorageEntity)(object)((__instance is PlaceableStorageEntity) ? __instance : null);
		if (__result == null || (Object)(object)val?.StorageEntity == (Object)null)
		{
			return;
		}
		try
		{
			StorageSlotMeta obj = new StorageSlotMeta
			{
				SlotCount = ((val.StorageEntity.ItemSlots != null) ? val.StorageEntity.ItemSlots.Count : val.StorageEntity.SlotCount),
				DisplayRowCount = val.StorageEntity.DisplayRowCount
			};
			ItemInstance itemInstance = ((BuildableItem)val).ItemInstance;
			obj.ItemId = ((itemInstance == null) ? null : itemInstance.Definition?.ID);
			StorageSlotMeta storageSlotMeta = obj;
			__result.AddData("S1API_Storage_SlotMeta", (SaveData)(object)storageSlotMeta);
		}
		catch (Exception ex)
		{
			Logger.Error("Error adding storage slot metadata: " + ex.Message);
		}
	}

	[HarmonyPatch(typeof(PlaceableStorageEntityLoader), "Load", new Type[] { typeof(DynamicSaveData) })]
	[HarmonyPrefix]
	private static bool PlaceableStorageEntityLoader_Load_Prefix(PlaceableStorageEntityLoader __instance, DynamicSaveData data)
	{
		try
		{
			if (data == null)
			{
				return false;
			}
			GridItemData val = default(GridItemData);
			if (!data.TryExtractBaseData<GridItemData>(ref val) || val == null)
			{
				return false;
			}
			object? obj = AccessTools.Method(((object)__instance).GetType(), "LoadAndCreate", new Type[1] { typeof(GridItemData) }, (Type[])null)?.Invoke(__instance, new object[1] { val });
			GridItem val2 = (GridItem)((obj is GridItem) ? obj : null);
			if ((Object)(object)val2 == (Object)null)
			{
				return false;
			}
			PlaceableStorageEntity val3 = (PlaceableStorageEntity)(object)((val2 is PlaceableStorageEntity) ? val2 : null);
			if ((Object)(object)val3 == (Object)null)
			{
				return false;
			}
			PlaceableStorageData val4 = default(PlaceableStorageData);
			if (!data.TryExtractBaseData<PlaceableStorageData>(ref val4) || val4 == null)
			{
				return false;
			}
			int num = val4.Contents?.Items?.Length ?? val3.StorageEntity.ItemSlots.Count;
			string text = default(string);
			if (data.TryGetData("S1API_Storage_SlotMeta", ref text) && !string.IsNullOrEmpty(text))
			{
				try
				{
					StorageSlotMeta storageSlotMeta = ParseStorageSlotMeta(text);
					if (storageSlotMeta != null)
					{
						num = Math.Max(num, storageSlotMeta.SlotCount);
						if (storageSlotMeta.DisplayRowCount > val3.StorageEntity.DisplayRowCount)
						{
							val3.StorageEntity.DisplayRowCount = storageSlotMeta.DisplayRowCount;
						}
					}
				}
				catch (Exception ex)
				{
					object obj2;
					if (val3 == null)
					{
						obj2 = null;
					}
					else
					{
						ItemInstance itemInstance = ((BuildableItem)val3).ItemInstance;
						obj2 = ((itemInstance == null) ? null : itemInstance.Definition?.ID);
					}
					if (obj2 == null)
					{
						obj2 = "unknown";
					}
					string text2 = (string)obj2;
					Logger.Warning("Failed to deserialize storage slot metadata for item '" + text2 + "'. This usually happens when a mod that added extra storage rows is no longer loaded. The save file contains expanded storage data, but the mod that created it is missing. Exception: " + ex.GetType().Name + ": " + ex.Message + ". ");
				}
			}
			StorageEntity storageEntity = new StorageEntity(val3.StorageEntity, val3);
			storageEntity.SetSlotCount(num);
			val4.Contents.LoadTo(val3.StorageEntity.ItemSlots);
		}
		catch (Exception ex2)
		{
			Logger.Error("Error in PlaceableStorageEntityLoader_Load_Prefix: " + ex2.Message);
		}
		return false;
	}

	[HarmonyPatch(typeof(StorageMenu), "Open", new Type[] { typeof(StorageEntity) })]
	[HarmonyPrefix]
	private static void StorageMenu_Open_Prefix(StorageEntity entity)
	{
		if ((Object)(object)entity == (Object)null)
		{
			return;
		}
		try
		{
			PlaceableStorageEntity componentInParent = ((Component)entity).GetComponentInParent<PlaceableStorageEntity>();
			StorageEntity storage = new StorageEntity(entity, componentInParent);
			StorageEventArgs args = new StorageEventArgs(storage);
			StorageEvents.RaiseStorageOpening(args);
		}
		catch (Exception ex)
		{
			Logger.Error("Error in StorageMenu_Open_Prefix: " + ex.Message);
		}
	}
}
