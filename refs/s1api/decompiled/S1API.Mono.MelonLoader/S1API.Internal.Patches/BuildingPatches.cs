using System;
using HarmonyLib;
using S1API.Building;
using S1API.Items;
using S1API.Logging;
using S1API.Storage;
using ScheduleOne.Building;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using UnityEngine;

namespace S1API.Internal.Patches;

[HarmonyPatch]
internal static class BuildingPatches
{
	private static readonly Log Logger = new Log("BuildingPatches");

	[HarmonyPatch(typeof(BuildManager), "CreateGridItem")]
	[HarmonyPostfix]
	private static void CreateGridItem_Postfix(GridItem __result, ItemInstance item)
	{
		if ((Object)(object)__result == (Object)null || (Object)(object)((item != null) ? item.Definition : null) == (Object)null)
		{
			return;
		}
		try
		{
			ItemInstance itemInstance = new ItemInstance(item);
			PlaceableStorageEntity component = ((Component)__result).GetComponent<PlaceableStorageEntity>();
			StorageEntity storage = null;
			if ((Object)(object)component?.StorageEntity != (Object)null)
			{
				storage = new StorageEntity(component.StorageEntity, component);
			}
			BuildEventArgs args = new BuildEventArgs(itemInstance, ((Component)__result).gameObject, storage);
			BuildEvents.RaiseGridItemCreated(args);
		}
		catch (Exception ex)
		{
			Logger.Error("Error in CreateGridItem_Postfix: " + ex.Message);
		}
	}

	[HarmonyPatch(typeof(BuildManager), "CreateSurfaceItem")]
	[HarmonyPostfix]
	private static void CreateSurfaceItem_Postfix(SurfaceItem __result, ItemInstance item)
	{
		if ((Object)(object)__result == (Object)null || (Object)(object)((item != null) ? item.Definition : null) == (Object)null)
		{
			return;
		}
		try
		{
			ItemInstance itemInstance = new ItemInstance(item);
			PlaceableStorageEntity component = ((Component)__result).GetComponent<PlaceableStorageEntity>();
			StorageEntity storage = null;
			if ((Object)(object)component?.StorageEntity != (Object)null)
			{
				storage = new StorageEntity(component.StorageEntity, component);
			}
			BuildEventArgs args = new BuildEventArgs(itemInstance, ((Component)__result).gameObject, storage);
			BuildEvents.RaiseSurfaceItemCreated(args);
		}
		catch (Exception ex)
		{
			Logger.Error("Error in CreateSurfaceItem_Postfix: " + ex.Message);
		}
	}

	[HarmonyPatch(typeof(BuildableItem), "InitializeBuildableItem")]
	[HarmonyPostfix]
	private static void InitializeBuildableItem_Postfix(BuildableItem __instance, ItemInstance instance)
	{
		if ((Object)(object)__instance == (Object)null || (Object)(object)((instance != null) ? instance.Definition : null) == (Object)null)
		{
			return;
		}
		try
		{
			ItemInstance itemInstance = new ItemInstance(instance);
			PlaceableStorageEntity component = ((Component)__instance).GetComponent<PlaceableStorageEntity>();
			StorageEntity storage = null;
			if ((Object)(object)component?.StorageEntity != (Object)null)
			{
				storage = new StorageEntity(component.StorageEntity, component);
			}
			BuildEventArgs args = new BuildEventArgs(itemInstance, ((Component)__instance).gameObject, storage);
			BuildEvents.RaiseBuildableItemInitialized(args);
		}
		catch (Exception ex)
		{
			Logger.Error("Error in InitializeBuildableItem_Postfix: " + ex.Message);
		}
	}
}
