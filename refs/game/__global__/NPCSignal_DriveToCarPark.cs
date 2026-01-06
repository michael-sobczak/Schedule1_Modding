public class NPCSignal_DriveToCarPark : NPCSignal // TypeDefIndex: 1884
{
	// Fields
	public ParkingLot ParkingLot; // 0x150
	public LandVehicle Vehicle; // 0x158
	[Header("Parking Settings")]
	public bool OverrideParkingType; // 0x160
	public EParkingAlignment ParkingType; // 0x164
	private bool isAtDestination; // 0x168
	private float timeInVehicle; // 0x16C
	private float timeAtDestination; // 0x170
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCSignal_DriveToCarParkAssembly-CSharp.dll_Excuted; // 0x174
	private bool NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCSignal_DriveToCarParkAssembly-CSharp.dll_Excuted; // 0x175

	// Properties
	public string ActionName { get; }

	// Methods

	// RVA: 0x7886E0 Offset: 0x7870E0 VA: 0x1807886E0
	public string get_ActionName() { }

	// RVA: 0x787840 Offset: 0x786240 VA: 0x180787840 Slot: 36
	public override string GetName() { }

	// RVA: 0x7882E0 Offset: 0x786CE0 VA: 0x1807882E0 Slot: 16
	protected override void OnValidate() { }

	// RVA: 0x7885D0 Offset: 0x786FD0 VA: 0x1807885D0 Slot: 22
	public override void Started() { }

	// RVA: 0x787790 Offset: 0x786190 VA: 0x180787790 Slot: 25
	public override void End() { }

	// RVA: 0x787BD0 Offset: 0x7865D0 VA: 0x180787BD0 Slot: 23
	public override void LateStarted() { }

	// RVA: 0x787640 Offset: 0x786040 VA: 0x180787640
	private void CheckValidForStart() { }

	// RVA: 0x787AF0 Offset: 0x7864F0 VA: 0x180787AF0 Slot: 26
	public override void Interrupt() { }

	// RVA: 0x788580 Offset: 0x786F80 VA: 0x180788580 Slot: 27
	public override void Resume() { }

	// RVA: 0x7885B0 Offset: 0x786FB0 VA: 0x1807885B0 Slot: 29
	public override void Skipped() { }

	// RVA: 0x788450 Offset: 0x786E50 VA: 0x180788450 Slot: 28
	public override void ResumeFailed() { }

	// RVA: 0x787BB0 Offset: 0x7865B0 VA: 0x180787BB0 Slot: 24
	public override void JumpTo() { }

	// RVA: 0x787C80 Offset: 0x786680 VA: 0x180787C80 Slot: 31
	public override void OnActiveTick() { }

	// RVA: 0x788670 Offset: 0x787070 VA: 0x180788670 Slot: 39
	protected override void WalkCallback(NPCMovement.WalkResult result) { }

	// RVA: 0x7879B0 Offset: 0x7863B0 VA: 0x1807879B0
	private Vector3 GetWalkDestination() { }

	// RVA: 0x7876F0 Offset: 0x7860F0 VA: 0x1807876F0
	private void DriveCallback(VehicleAgent.ENavigationResult result) { }

	// RVA: 0x788310 Offset: 0x786D10 VA: 0x180788310
	private void Park() { }

	// RVA: 0x787970 Offset: 0x786370 VA: 0x180787970
	private EParkingAlignment GetParkingType() { }

	// RVA: 0x77FB70 Offset: 0x77E570 VA: 0x18077FB70
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(NPCSignal_DriveToCarPark.<<DriveCallback>g__Wait|23_0>d))]
	// RVA: 0x788600 Offset: 0x787000 VA: 0x180788600
	private IEnumerator <DriveCallback>g__Wait|23_0() { }

	// RVA: 0x787C40 Offset: 0x786640 VA: 0x180787C40 Slot: 41
	public override void NetworkInitialize___Early() { }

	// RVA: 0x787C00 Offset: 0x786600 VA: 0x180787C00 Slot: 42
	public override void NetworkInitialize__Late() { }

	// RVA: 0x77E720 Offset: 0x77D120 VA: 0x18077E720 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x77FCC0 Offset: 0x77E6C0 VA: 0x18077FCC0 Slot: 20
	public override void Awake() { }
}
