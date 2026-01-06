public class NPCSignal_WalkToLocation : NPCSignal // TypeDefIndex: 1890
{
	// Fields
	public Transform Destination; // 0x150
	public bool FaceDestinationDir; // 0x158
	public float DestinationThreshold; // 0x15C
	public bool WarpIfSkipped; // 0x160
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCSignal_WalkToLocationAssembly-CSharp.dll_Excuted; // 0x161
	private bool NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCSignal_WalkToLocationAssembly-CSharp.dll_Excuted; // 0x162

	// Properties
	public string ActionName { get; }

	// Methods

	// RVA: 0x78C4F0 Offset: 0x78AEF0 VA: 0x18078C4F0
	public string get_ActionName() { }

	// RVA: 0x78BCB0 Offset: 0x78A6B0 VA: 0x18078BCB0 Slot: 36
	public override string GetName() { }

	// RVA: 0x78C2C0 Offset: 0x78ACC0 VA: 0x18078C2C0 Slot: 22
	public override void Started() { }

	// RVA: 0x78BAE0 Offset: 0x78A4E0 VA: 0x18078BAE0 Slot: 30
	public override void ActiveUpdate() { }

	// RVA: 0x788770 Offset: 0x787170 VA: 0x180788770 Slot: 23
	public override void LateStarted() { }

	// RVA: 0x78BD50 Offset: 0x78A750 VA: 0x18078BD50 Slot: 26
	public override void Interrupt() { }

	// RVA: 0x7891F0 Offset: 0x787BF0 VA: 0x1807891F0 Slot: 27
	public override void Resume() { }

	// RVA: 0x78C230 Offset: 0x78AC30 VA: 0x18078C230 Slot: 29
	public override void Skipped() { }

	// RVA: 0x78BDC0 Offset: 0x78A7C0 VA: 0x18078BDC0
	private bool IsAtDestination() { }

	// RVA: 0x78C320 Offset: 0x78AD20 VA: 0x18078C320 Slot: 39
	protected override void WalkCallback(NPCMovement.WalkResult result) { }

	[ObserversRpc]
	// RVA: 0x78C010 Offset: 0x78AA10 VA: 0x18078C010
	private void ReachedDestination() { }

	// RVA: 0x78C4C0 Offset: 0x78AEC0 VA: 0x18078C4C0
	public void .ctor() { }

	// RVA: 0x78BF60 Offset: 0x78A960 VA: 0x18078BF60 Slot: 41
	public override void NetworkInitialize___Early() { }

	// RVA: 0x78BF20 Offset: 0x78A920 VA: 0x18078BF20 Slot: 42
	public override void NetworkInitialize__Late() { }

	// RVA: 0x77E720 Offset: 0x77D120 VA: 0x18077E720 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x78C010 Offset: 0x78AA10 VA: 0x18078C010
	private void RpcWriter___Observers_ReachedDestination_2166136261() { }

	// RVA: 0x78C120 Offset: 0x78AB20 VA: 0x18078C120
	private void RpcLogic___ReachedDestination_2166136261() { }

	// RVA: 0x78C1A0 Offset: 0x78ABA0 VA: 0x18078C1A0
	private void RpcReader___Observers_ReachedDestination_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x77FCC0 Offset: 0x77E6C0 VA: 0x18077FCC0 Slot: 20
	public override void Awake() { }
}
