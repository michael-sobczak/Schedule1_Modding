public class NPCSignal_WaitForDelivery : NPCSignal // TypeDefIndex: 1889
{
	// Fields
	public const float DESTINATION_THRESHOLD = 1.5;
	private Contract contract; // 0x150
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCSignal_WaitForDeliveryAssembly-CSharp.dll_Excuted; // 0x158
	private bool NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCSignal_WaitForDeliveryAssembly-CSharp.dll_Excuted; // 0x159

	// Properties
	public string ActionName { get; }
	private DeliveryLocation Location { get; }

	// Methods

	// RVA: 0x78AE20 Offset: 0x789820 VA: 0x18078AE20
	public string get_ActionName() { }

	// RVA: 0x78BAB0 Offset: 0x78A4B0 VA: 0x18078BAB0
	private DeliveryLocation get_Location() { }

	// RVA: 0x71DC00 Offset: 0x71C600 VA: 0x18071DC00
	public void SetContract(Contract contract) { }

	// RVA: 0x78AC80 Offset: 0x789680 VA: 0x18078AC80 Slot: 20
	public override void Awake() { }

	// RVA: 0x78B740 Offset: 0x78A140 VA: 0x18078B740 Slot: 16
	protected override void OnValidate() { }

	// RVA: 0x78AE20 Offset: 0x789820 VA: 0x18078AE20 Slot: 36
	public override string GetName() { }

	// RVA: 0x78B880 Offset: 0x78A280 VA: 0x18078B880 Slot: 22
	public override void Started() { }

	// RVA: 0x78B1E0 Offset: 0x789BE0 VA: 0x18078B1E0 Slot: 23
	public override void LateStarted() { }

	// RVA: 0x78B060 Offset: 0x789A60 VA: 0x18078B060 Slot: 24
	public override void JumpTo() { }

	// RVA: 0x78AD90 Offset: 0x789790 VA: 0x18078AD90
	private void EnsureNPCHasEnoughCash() { }

	// RVA: 0x78B3E0 Offset: 0x789DE0 VA: 0x18078B3E0 Slot: 31
	public override void OnActiveTick() { }

	// RVA: 0x78AE50 Offset: 0x789850 VA: 0x18078AE50 Slot: 26
	public override void Interrupt() { }

	// RVA: 0x78B770 Offset: 0x78A170 VA: 0x18078B770 Slot: 27
	public override void Resume() { }

	// RVA: 0x78AD10 Offset: 0x789710 VA: 0x18078AD10 Slot: 25
	public override void End() { }

	// RVA: 0x78B7E0 Offset: 0x78A1E0 VA: 0x18078B7E0 Slot: 29
	public override void Skipped() { }

	// RVA: 0x78AEF0 Offset: 0x7898F0 VA: 0x18078AEF0
	private bool IsAtDestination() { }

	// RVA: 0x78B9A0 Offset: 0x78A3A0 VA: 0x18078B9A0 Slot: 39
	protected override void WalkCallback(NPCMovement.WalkResult result) { }

	// RVA: 0x77FB70 Offset: 0x77E570 VA: 0x18077FB70
	public void .ctor() { }

	// RVA: 0x78B3A0 Offset: 0x789DA0 VA: 0x18078B3A0 Slot: 41
	public override void NetworkInitialize___Early() { }

	// RVA: 0x78B360 Offset: 0x789D60 VA: 0x18078B360 Slot: 42
	public override void NetworkInitialize__Late() { }

	// RVA: 0x77E720 Offset: 0x77D120 VA: 0x18077E720 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x78AC20 Offset: 0x789620 VA: 0x18078AC20 Slot: 44
	protected override void Awake_UserLogic_ScheduleOne.NPCs.Schedules.NPCSignal_WaitForDelivery_Assembly-CSharp.dll() { }
}
