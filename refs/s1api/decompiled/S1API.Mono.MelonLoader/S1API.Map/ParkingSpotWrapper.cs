using S1API.Vehicles;
using ScheduleOne.Map;
using UnityEngine;

namespace S1API.Map;

public sealed class ParkingSpotWrapper
{
	internal readonly ParkingSpot _spot;

	public bool IsFree => (Object)(object)_spot != (Object)null && (Object)(object)_spot.OccupantVehicle == (Object)null;

	public ParkingAlignment Alignment => (ParkingAlignment)_spot.Alignment;

	public Transform AlignmentPoint => _spot.AlignmentPoint;

	internal LandVehicle? _OccupantVehicle => new LandVehicle(_spot.OccupantVehicle);

	public LandVehicle? OccupantVehicle => _OccupantVehicle;

	internal ParkingSpotWrapper(ParkingSpot spot)
	{
		_spot = spot;
	}

	public void SetOccupant(LandVehicle vehicle)
	{
		_spot.SetOccupant(vehicle.S1LandVehicle);
	}
}
