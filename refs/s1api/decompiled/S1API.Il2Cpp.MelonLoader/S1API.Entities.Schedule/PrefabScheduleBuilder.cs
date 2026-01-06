using System;
using System.Collections.Generic;
using S1API.Casino;
using S1API.Logging;
using S1API.Map;
using S1API.Vehicles;
using UnityEngine;

namespace S1API.Entities.Schedule;

public sealed class PrefabScheduleBuilder
{
	private static readonly Log Logger = new Log("PrefabScheduleBuilder");

	private readonly List<IScheduleActionSpec> _specs = new List<IScheduleActionSpec>();

	internal List<IScheduleActionSpec> Build()
	{
		return _specs;
	}

	public PrefabScheduleBuilder WalkTo(Vector3 destination, int startTime, bool faceDestinationDir = true, float within = 1f, bool warpIfSkipped = false, Vector3? forward = null, string name = null)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		_specs.Add(new WalkToSpec
		{
			Destination = destination,
			StartTime = startTime,
			FaceDestinationDirection = faceDestinationDir,
			Within = within,
			WarpIfSkipped = warpIfSkipped,
			Forward = forward,
			Name = name
		});
		return this;
	}

	public PrefabScheduleBuilder SitAtSeatSet(string seatSetName, int startTime, bool warpIfSkipped = false, string name = null)
	{
		if (!string.IsNullOrEmpty(seatSetName))
		{
			_specs.Add(new SitSpec
			{
				SeatSetName = seatSetName,
				StartTime = startTime,
				WarpIfSkipped = warpIfSkipped,
				Name = name
			});
		}
		return this;
	}

	public PrefabScheduleBuilder EnsureDealSignal()
	{
		_specs.Add(new EnsureDealSignalSpec());
		return this;
	}

	public PrefabScheduleBuilder Add(IScheduleActionSpec spec)
	{
		if (spec != null)
		{
			_specs.Add(spec);
		}
		return this;
	}

	public PrefabScheduleBuilder UseVendingMachine(int startTime, string machineGUID = null, string name = null)
	{
		_specs.Add(new UseVendingMachineSpec
		{
			StartTime = startTime,
			MachineGUID = machineGUID,
			Name = name
		});
		return this;
	}

	public PrefabScheduleBuilder UseSlotMachine(int startTime, Vector3 machinePosition, int betAmount = 10, GamblingSessionMode sessionMode = GamblingSessionMode.SingleSpin, float maxSearchDistance = 5f, string name = null)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		_specs.Add(new UseSlotMachineSpec
		{
			StartTime = startTime,
			MachinePosition = machinePosition,
			BetAmount = betAmount,
			SessionMode = sessionMode,
			MaxSearchDistance = maxSearchDistance,
			Name = name
		});
		return this;
	}

	public PrefabScheduleBuilder UseSlotMachineMultipleTimes(int startTime, Vector3 machinePosition, int spinCount, int betAmount = 10, float timeBetweenSpins = 10f, float maxSearchDistance = 5f, string name = null)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		_specs.Add(new UseSlotMachineSpec
		{
			StartTime = startTime,
			MachinePosition = machinePosition,
			BetAmount = betAmount,
			SessionMode = GamblingSessionMode.SpinCount,
			SpinCount = spinCount,
			TimeBetweenSpins = timeBetweenSpins,
			MaxSearchDistance = maxSearchDistance,
			Name = name
		});
		return this;
	}

	public PrefabScheduleBuilder UseSlotMachineUntilTime(int startTime, int endTime, Vector3 machinePosition, int betAmount = 10, float timeBetweenSpins = 10f, bool stopIfBroke = true, float maxSearchDistance = 5f, global::S1API.Map.Building building = null, string name = null)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		_specs.Add(new UseSlotMachineSpec
		{
			StartTime = startTime,
			MachinePosition = machinePosition,
			BetAmount = betAmount,
			SessionMode = (stopIfBroke ? GamblingSessionMode.UntilTimeOrBroke : GamblingSessionMode.UntilTime),
			EndTime = endTime,
			TimeBetweenSpins = timeBetweenSpins,
			MaxSearchDistance = maxSearchDistance,
			Building = building,
			Name = name
		});
		return this;
	}

	public PrefabScheduleBuilder UseSlotMachineUntilBroke(int startTime, Vector3 machinePosition, int betAmount = 10, float timeBetweenSpins = 10f, float maxSearchDistance = 5f, string name = null)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		_specs.Add(new UseSlotMachineSpec
		{
			StartTime = startTime,
			MachinePosition = machinePosition,
			BetAmount = betAmount,
			SessionMode = GamblingSessionMode.UntilBroke,
			TimeBetweenSpins = timeBetweenSpins,
			MaxSearchDistance = maxSearchDistance,
			Name = name
		});
		return this;
	}

	public PrefabScheduleBuilder UseATM(int startTime, string atmGUID = null, string name = null)
	{
		_specs.Add(new UseATMSpec
		{
			StartTime = startTime,
			ATMGUID = atmGUID,
			Name = name
		});
		return this;
	}

	public PrefabScheduleBuilder LocationDialogue(Vector3 destination, int startTime, bool faceDestinationDir = true, float within = 1f, bool warpIfSkipped = false, int greetingOverrideToEnable = -1, int choiceToEnable = -1, string name = null)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		_specs.Add(new LocationDialogueSpec
		{
			Destination = destination,
			Forward = null,
			StartTime = startTime,
			FaceDestinationDirection = faceDestinationDir,
			Within = within,
			WarpIfSkipped = warpIfSkipped,
			GreetingOverrideToEnable = greetingOverrideToEnable,
			ChoiceToEnable = choiceToEnable,
			Name = name
		});
		return this;
	}

	[Obsolete("HandleDeal is no longer needed as of game version 0.4.2f4. Deal handling is now automatic through DealerAttendDealBehaviour.")]
	public PrefabScheduleBuilder HandleDeal(int startTime, string name = null)
	{
		_specs.Add(new HandleDealSpec
		{
			StartTime = startTime,
			Name = name
		});
		return this;
	}

	public PrefabScheduleBuilder StayInBuilding(global::S1API.Map.Building building, int startTime, int durationMinutes = 60, int? doorIndex = null, string name = null)
	{
		if (building == null)
		{
			Logger.Error($"StayInBuilding called with null building at time {startTime}. Action will not be added to schedule.");
			return this;
		}
		string name2 = building.Name;
		if (string.IsNullOrEmpty(name2))
		{
			Logger.Error($"StayInBuilding called with building that has null/empty Name at time {startTime}. Building wrapper exists but Name property is invalid.");
			return this;
		}
		_specs.Add(new StayInBuildingSpec
		{
			BuildingName = name2,
			BuildingIdentifierType = building.DeferredIdentifierType,
			StartTime = startTime,
			DurationMinutes = durationMinutes,
			DoorIndex = doorIndex,
			Name = name
		});
		return this;
	}

	public PrefabScheduleBuilder DriveToCarPark(ParkingLotWrapper lot, LandVehicle vehicle, int startTime, ParkingAlignment? alignment = null, bool? overrideParkingType = null, string name = null)
	{
		_specs.Add(new DriveToCarParkSpec
		{
			StartTime = startTime,
			ParkingLot = lot,
			Vehicle = vehicle,
			Alignment = alignment,
			OverrideParkingType = overrideParkingType,
			Name = name
		});
		return this;
	}

	public PrefabScheduleBuilder DriveToCarPark(string parkingLotGUID, string vehicleGUID, int startTime, ParkingAlignment? alignment = null, bool? overrideParkingType = null, string name = null)
	{
		_specs.Add(new DriveToCarParkSpec
		{
			StartTime = startTime,
			ParkingLotGUID = parkingLotGUID,
			VehicleGUID = vehicleGUID,
			Alignment = alignment,
			OverrideParkingType = overrideParkingType,
			Name = name
		});
		return this;
	}

	public PrefabScheduleBuilder DriveToCarParkByName(string parkingLotName, string vehicleName, int startTime, ParkingAlignment? alignment = null, bool? overrideParkingType = null, string name = null)
	{
		_specs.Add(new DriveToCarParkSpec
		{
			StartTime = startTime,
			ParkingLotName = parkingLotName,
			VehicleName = vehicleName,
			Alignment = alignment,
			OverrideParkingType = overrideParkingType,
			Name = name
		});
		return this;
	}

	public PrefabScheduleBuilder DriveToCarParkWithCreateVehicle(string parkingLotName, string vehicleCode, int startTime, Vector3 vehicleSpawnPosition, Quaternion? vehicleSpawnRotation = null, ParkingAlignment? alignment = null, bool? overrideParkingType = null, string name = null)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		_specs.Add(new DriveToCarParkSpec
		{
			StartTime = startTime,
			ParkingLotName = parkingLotName,
			VehicleCode = vehicleCode,
			VehicleSpawnPosition = vehicleSpawnPosition,
			VehicleSpawnRotation = vehicleSpawnRotation,
			Alignment = alignment,
			OverrideParkingType = overrideParkingType,
			Name = name
		});
		return this;
	}
}
