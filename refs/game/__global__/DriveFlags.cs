public class DriveFlags // TypeDefIndex: 2205
{
	// Fields
	public bool OverrideSpeed; // 0x10
	public float OverriddenSpeed; // 0x14
	public float OverriddenReverseSpeed; // 0x18
	public float SpeedLimitMultiplier; // 0x1C
	public bool IgnoreTrafficLights; // 0x20
	public bool UseRoads; // 0x21
	public bool StuckDetection; // 0x22
	public DriveFlags.EObstacleMode ObstacleMode; // 0x24
	public bool AutoBrakeAtDestination; // 0x28
	public bool TurnBasedSpeedReduction; // 0x29

	// Methods

	// RVA: 0x825420 Offset: 0x823E20 VA: 0x180825420
	public void ResetFlags() { }

	// RVA: 0x825460 Offset: 0x823E60 VA: 0x180825460
	public void .ctor() { }
}
