using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using S1API.Internal.Map;
using S1API.Internal.Utils;
using S1API.Logging;
using S1API.Map;
using ScheduleOne.GameTime;
using ScheduleOne.Map;
using ScheduleOne.NPCs.Schedules;
using UnityEngine;

namespace S1API.Entities.Schedule;

public sealed class StayInBuildingSpec : IScheduleActionSpec
{
	private sealed class PendingAction
	{
		public NPCEvent_StayInBuilding Action;

		public NPCSchedule Schedule;

		public string BuildingName;

		public int StartTime;

		public int? DoorIndex;
	}

	private static readonly Log Logger = new Log("StayInBuildingSpec");

	private static readonly List<PendingAction> PendingActions = new List<PendingAction>();

	public string BuildingGUID { get; set; }

	public string BuildingName { get; set; }

	internal Type BuildingIdentifierType { get; set; }

	public int StartTime { get; set; }

	public int DurationMinutes { get; set; } = 60;

	public int? DoorIndex { get; set; }

	public string Name { get; set; }

	public void ApplyTo(NPCSchedule schedule)
	{
		NPCEvent_StayInBuilding val = schedule.AddActionInternal<NPCEvent_StayInBuilding>(StartTime, string.IsNullOrEmpty(Name) ? "StayInBuilding" : Name);
		if ((Object)(object)val == (Object)null)
		{
			Logger.Warning($"Failed to create StayInBuilding action at time {StartTime} - AddActionInternal returned null");
			return;
		}
		((NPCEvent)val).Duration = Mathf.Max(1, DurationMinutes);
		int num = TimeManager.AddMinutesTo24HourTime(StartTime, ((NPCEvent)val).Duration);
		ReflectionUtils.TrySetFieldOrProperty(val, "EndTime", num);
		object obj = null;
		global::S1API.Map.Building building = null;
		if (!string.IsNullOrEmpty(BuildingName))
		{
			building = global::S1API.Map.Building.GetByName(BuildingName);
			if (building == null)
			{
				Logger.Warning($"Building '{BuildingName}' not found in registry for StayInBuilding action at time {StartTime}. Will register deferred lookup.");
				if (!DeferredMapResolver.IsMenuScene())
				{
					obj = TryFindBuildingInScene(BuildingName);
					if (obj != null)
					{
						ApplyBuildingToAction(val, obj);
						return;
					}
				}
				RegisterDeferredBuildingResolution(val, schedule);
				return;
			}
			obj = building.ResolveGameBuilding();
			if (obj == null)
			{
				if (building.IsDeferred)
				{
					RegisterDeferredBuildingResolution(val, schedule, building);
					return;
				}
				Logger.Warning("Building wrapper for '" + BuildingName + "' exists but ResolveGameBuilding returned null. Trying direct scene lookup.");
				obj = TryFindBuildingInScene(BuildingName);
				if (obj == null)
				{
					Logger.Error($"Failed to resolve game building for '{BuildingName}' (wrapper exists but ResolveGameBuilding returned null) at time {StartTime}");
				}
			}
		}
		else if (!string.IsNullOrEmpty(BuildingGUID))
		{
			Logger.Warning($"StayInBuildingSpec at time {StartTime} has BuildingGUID set but BuildingName is empty. GUID-based lookup is not yet implemented.");
		}
		else
		{
			Logger.Error($"StayInBuildingSpec at time {StartTime} has neither BuildingName nor BuildingGUID set. Action will be created without a building reference.");
		}
		if (obj != null)
		{
			ApplyBuildingToAction(val, obj);
			return;
		}
		Logger.Warning($"StayInBuilding action at time {StartTime} was created but Building field is null. Will retry when building is registered.");
		lock (PendingActions)
		{
			PendingActions.Add(new PendingAction
			{
				Action = val,
				Schedule = schedule,
				BuildingName = BuildingName,
				StartTime = StartTime,
				DoorIndex = DoorIndex
			});
		}
		TryResolvePendingActions();
	}

	internal static void TryResolvePendingActions()
	{
		lock (PendingActions)
		{
			if (PendingActions.Count == 0)
			{
				return;
			}
			List<PendingAction> list = new List<PendingAction>();
			for (int num = PendingActions.Count - 1; num >= 0; num--)
			{
				PendingAction pendingAction = PendingActions[num];
				if ((Object)(object)pendingAction.Action == (Object)null || pendingAction.Schedule == null)
				{
					list.Add(pendingAction);
				}
				else
				{
					global::S1API.Map.Building byName = global::S1API.Map.Building.GetByName(pendingAction.BuildingName);
					if (byName != null)
					{
						object obj = byName.ResolveGameBuilding();
						if (obj != null)
						{
							StayInBuildingSpec stayInBuildingSpec = new StayInBuildingSpec
							{
								BuildingName = pendingAction.BuildingName,
								StartTime = pendingAction.StartTime,
								DoorIndex = pendingAction.DoorIndex
							};
							stayInBuildingSpec.ApplyBuildingToAction(pendingAction.Action, obj);
							try
							{
								pendingAction.Schedule.InitializeActions();
							}
							catch (Exception ex)
							{
								Logger.Warning("Failed to re-initialize schedule after resolving pending building '" + pendingAction.BuildingName + "': " + ex.Message);
							}
							list.Add(pendingAction);
						}
					}
				}
			}
			foreach (PendingAction item in list)
			{
				PendingActions.Remove(item);
			}
		}
	}

	private void ApplyBuildingToAction(NPCEvent_StayInBuilding action, object gameBuilding)
	{
		if ((Object)(object)action == (Object)null)
		{
			Logger.Error($"Cannot apply building to null action for '{BuildingName}' at time {StartTime}");
			return;
		}
		if (gameBuilding == null)
		{
			Logger.Error($"Cannot apply null gameBuilding to action for '{BuildingName}' at time {StartTime}");
			return;
		}
		if (!ReflectionUtils.TrySetFieldOrProperty(action, "Building", gameBuilding))
		{
			Logger.Error($"Failed to set Building field on StayInBuilding action for '{BuildingName}' at time {StartTime}. Field may not exist or be inaccessible.");
		}
		else
		{
			object obj = ReflectionUtils.TryGetFieldOrProperty(action, "Building");
			if (obj == null)
			{
				Logger.Warning($"Building field appears to be null after setting for '{BuildingName}' at time {StartTime}");
			}
		}
		if (!DoorIndex.HasValue)
		{
			return;
		}
		Type type = gameBuilding.GetType();
		IList list = null;
		FieldInfo field = type.GetField("Doors", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		if (field != null)
		{
			list = field.GetValue(gameBuilding) as IList;
		}
		if (list == null)
		{
			PropertyInfo property = type.GetProperty("Doors", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			if (property != null)
			{
				list = property.GetValue(gameBuilding) as IList;
			}
		}
		if (list != null && DoorIndex.Value >= 0 && DoorIndex.Value < list.Count)
		{
			ReflectionUtils.TrySetFieldOrProperty(action, "Door", list[DoorIndex.Value]);
		}
		else if (DoorIndex.HasValue)
		{
			Logger.Warning($"DoorIndex {DoorIndex.Value} is out of range for building '{BuildingName}' (has {list?.Count ?? 0} doors)");
		}
	}

	private void RegisterDeferredBuildingResolution(NPCEvent_StayInBuilding action, NPCSchedule schedule, global::S1API.Map.Building existingWrapper = null)
	{
		if (BuildingIdentifierType != null)
		{
			DeferredMapResolver.RegisterDeferredLookup(new DeferredLookup(BuildingIdentifierType, delegate(object resolved)
			{
				if (resolved is global::S1API.Map.Building building && building != null)
				{
					object obj = building.ResolveGameBuilding();
					if (obj != null && (Object)(object)action != (Object)null)
					{
						ApplyBuildingToAction(action, obj);
						try
						{
							schedule.InitializeActions();
						}
						catch (Exception ex)
						{
							Logger.Warning("Failed to re-initialize schedule after building resolution: " + ex.Message);
						}
					}
				}
			}));
		}
		else if (existingWrapper != null && existingWrapper.DeferredIdentifierType != null)
		{
			DeferredMapResolver.RegisterDeferredLookup(new DeferredLookup(existingWrapper.DeferredIdentifierType, delegate(object resolved)
			{
				if (resolved is global::S1API.Map.Building building && building != null)
				{
					object obj = building.ResolveGameBuilding();
					if (obj != null && (Object)(object)action != (Object)null)
					{
						ApplyBuildingToAction(action, obj);
						try
						{
							schedule.InitializeActions();
						}
						catch (Exception ex)
						{
							Logger.Warning("Failed to re-initialize schedule after building resolution: " + ex.Message);
						}
					}
				}
			}));
		}
		else if (string.IsNullOrEmpty(BuildingName))
		{
		}
	}

	private object TryFindBuildingInScene(string buildingName)
	{
		try
		{
			NPCEnterableBuilding[] array = Object.FindObjectsOfType<NPCEnterableBuilding>(true);
			foreach (NPCEnterableBuilding val in array)
			{
				if (!((Object)(object)val == (Object)null))
				{
					Type type = ((object)val).GetType();
					string text = type.GetField("BuildingName", BindingFlags.Instance | BindingFlags.Public)?.GetValue(val) as string;
					if (string.IsNullOrEmpty(text))
					{
						text = type.GetProperty("BuildingName", BindingFlags.Instance | BindingFlags.Public)?.GetValue(val) as string;
					}
					if (!string.IsNullOrEmpty(text) && string.Equals(text, buildingName, StringComparison.OrdinalIgnoreCase))
					{
						return val;
					}
				}
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("Exception during direct building lookup for '" + buildingName + "': " + ex.Message);
		}
		return null;
	}
}
