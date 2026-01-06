using System;
using Il2CppFishNet;
using Il2CppFishNet.Managing;
using Il2CppScheduleOne.NPCs.Schedules;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using S1API.Internal.Utils;
using S1API.Map;
using S1API.Vehicles;
using UnityEngine;

namespace S1API.Entities.Schedule;

public sealed class DriveToCarParkSpec : IScheduleActionSpec
{
	public int StartTime { get; set; }

	public string ParkingLotGUID { get; set; }

	public string VehicleGUID { get; set; }

	public bool? OverrideParkingType { get; set; }

	public int? ParkingType { get; set; }

	public ParkingAlignment? Alignment { get; set; }

	public string Name { get; set; }

	public ParkingLotWrapper ParkingLot { get; set; }

	public LandVehicle Vehicle { get; set; }

	public string ParkingLotName { get; set; }

	public string VehicleName { get; set; }

	public string VehicleCode { get; set; }

	public Vector3 VehicleSpawnPosition { get; set; }

	public Quaternion? VehicleSpawnRotation { get; set; }

	void IScheduleActionSpec.ApplyTo(NPCSchedule schedule)
	{
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		NPCSignal_DriveToCarPark val = schedule.AddActionInternal<NPCSignal_DriveToCarPark>(StartTime, string.IsNullOrEmpty(Name) ? "DriveToCarPark" : Name);
		if ((Object)(object)val == (Object)null)
		{
			return;
		}
		try
		{
			object obj = null;
			if (ParkingLot != null)
			{
				obj = ParkingLot.ResolveGameLot();
			}
			else if (!string.IsNullOrEmpty(ParkingLotName))
			{
				obj = ParkingLotRegistry.GetByName(ParkingLotName)?.ResolveGameLot();
			}
			else if (!string.IsNullOrEmpty(ParkingLotGUID))
			{
				obj = ParkingLotRegistry.GetByGUID(ParkingLotGUID)?.ResolveGameLot();
			}
			if (obj != null)
			{
				ReflectionUtils.TrySetFieldOrProperty(val, "ParkingLot", obj);
			}
			object obj2 = null;
			if (Vehicle != null && (Object)(object)Vehicle.S1LandVehicle != (Object)null)
			{
				obj2 = Vehicle.S1LandVehicle;
			}
			else if (!string.IsNullOrEmpty(VehicleName))
			{
				obj2 = VehicleRegistry.GetByName(VehicleName)?.S1LandVehicle;
			}
			else if (!string.IsNullOrEmpty(VehicleGUID))
			{
				obj2 = VehicleRegistry.GetByGUID(VehicleGUID)?.S1LandVehicle;
			}
			else if (!string.IsNullOrEmpty(VehicleCode))
			{
				LandVehicle landVehicle = VehicleRegistry.CreateVehicle(VehicleCode);
				obj2 = landVehicle?.S1LandVehicle;
				if (obj2 != null)
				{
					LandVehicle landVehicle2 = landVehicle;
					if (landVehicle2 != null && (Object)(object)landVehicle2.S1LandVehicle != (Object)null)
					{
						try
						{
							NetworkManager networkManager = InstanceFinder.NetworkManager;
							if ((Object)(object)networkManager != (Object)null && networkManager.IsServer)
							{
								Quaternion rotation = (Quaternion)(((_003F?)VehicleSpawnRotation) ?? Quaternion.identity);
								landVehicle2.Spawn(VehicleSpawnPosition, rotation);
							}
						}
						catch (Exception ex)
						{
							Debug.LogWarning(Object.op_Implicit("[S1API] Failed to spawn created vehicle: " + ex.Message));
						}
					}
				}
			}
			if (obj2 != null)
			{
				ReflectionUtils.TrySetFieldOrProperty(val, "Vehicle", obj2);
			}
			if (OverrideParkingType.HasValue)
			{
				ReflectionUtils.TrySetFieldOrProperty(val, "OverrideParkingType", OverrideParkingType.Value);
			}
			if (Alignment.HasValue)
			{
				EParkingAlignment val2 = (EParkingAlignment)Alignment.Value;
				ReflectionUtils.TrySetFieldOrProperty(val, "ParkingType", val2);
			}
			else if (ParkingType.HasValue)
			{
				EParkingAlignment val3 = (EParkingAlignment)ParkingType.Value;
				ReflectionUtils.TrySetFieldOrProperty(val, "ParkingType", val3);
			}
		}
		catch
		{
		}
	}
}
