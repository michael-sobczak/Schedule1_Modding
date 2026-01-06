public class VehiclePatrolInstance // TypeDefIndex: 1310
{
	// Fields
	public VehiclePatrolRoute Route; // 0x10
	public int StartTime; // 0x18
	[Range(1, 10)]
	public int IntensityRequirement; // 0x1C
	public bool OnlyIfCurfewEnabled; // 0x20
	private PoliceOfficer activeOfficer; // 0x28
	private int latestStartTime; // 0x30
	private bool startedThisCycle; // 0x34

	// Properties
	private PoliceStation nearestStation { get; }

	// Methods

	// RVA: 0x65BA60 Offset: 0x65A460 VA: 0x18065BA60
	private PoliceStation get_nearestStation() { }

	// RVA: 0x65B620 Offset: 0x65A020 VA: 0x18065B620
	public void Evaluate() { }

	// RVA: 0x65B580 Offset: 0x659F80 VA: 0x18065B580
	private void CheckEnd() { }

	// RVA: 0x65B920 Offset: 0x65A320 VA: 0x18065B920
	public void StartPatrol() { }

	// RVA: 0x65BA40 Offset: 0x65A440 VA: 0x18065BA40
	public void .ctor() { }
}
