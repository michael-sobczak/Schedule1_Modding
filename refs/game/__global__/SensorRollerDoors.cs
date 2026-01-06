public class SensorRollerDoors : RollerDoor // TypeDefIndex: 1545
{
	// Fields
	[Header("References")]
	public VehicleDetector Detector; // 0x68
	public VehicleDetector ClipDetector; // 0x70
	[Header("Settings")]
	public bool DetectPlayerOccupiedVehiclesOnly; // 0x78

	// Methods

	// RVA: 0x6FCD20 Offset: 0x6FB720 VA: 0x1806FCD20 Slot: 5
	protected virtual void Update() { }

	// RVA: 0x6E79A0 Offset: 0x6E63A0 VA: 0x1806E79A0
	public void .ctor() { }
}
