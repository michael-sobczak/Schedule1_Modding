public class NPCSignal : NPCAction // TypeDefIndex: 1882
{
	// Fields
	public int MaxDuration; // 0x148
	[CompilerGenerated]
	private bool <StartedThisCycle>k__BackingField; // 0x14C
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCSignalAssembly-CSharp.dll_Excuted; // 0x14D
	private bool NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCSignalAssembly-CSharp.dll_Excuted; // 0x14E

	// Properties
	public string ActionName { get; }
	public bool StartedThisCycle { get; set; }

	// Methods

	// RVA: 0x788710 Offset: 0x787110 VA: 0x180788710
	public string get_ActionName() { }

	[CompilerGenerated]
	// RVA: 0x512EE0 Offset: 0x5118E0 VA: 0x180512EE0
	public bool get_StartedThisCycle() { }

	[CompilerGenerated]
	// RVA: 0x78C520 Offset: 0x78AF20 VA: 0x18078C520
	protected void set_StartedThisCycle(bool value) { }

	// RVA: 0x788710 Offset: 0x787110 VA: 0x180788710 Slot: 36
	public override string GetName() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 30
	public override void ActiveUpdate() { }

	// RVA: 0x788740 Offset: 0x787140 VA: 0x180788740 Slot: 37
	public override string GetTimeDescription() { }

	// RVA: 0x781970 Offset: 0x780370 VA: 0x180781970 Slot: 38
	public override int GetEndTime() { }

	// RVA: 0x788900 Offset: 0x787300 VA: 0x180788900 Slot: 22
	public override void Started() { }

	// RVA: 0x788770 Offset: 0x787170 VA: 0x180788770 Slot: 23
	public override void LateStarted() { }

	// RVA: 0x7888C0 Offset: 0x7872C0 VA: 0x1807888C0 Slot: 35
	public override bool ShouldStart() { }

	// RVA: 0x788760 Offset: 0x787160 VA: 0x180788760 Slot: 26
	public override void Interrupt() { }

	// RVA: 0x788790 Offset: 0x787190 VA: 0x180788790 Slot: 34
	public override void MinPassed() { }

	// RVA: 0x77FB70 Offset: 0x77E570 VA: 0x18077FB70
	public void .ctor() { }

	// RVA: 0x788890 Offset: 0x787290 VA: 0x180788890 Slot: 41
	public override void NetworkInitialize___Early() { }

	// RVA: 0x788860 Offset: 0x787260 VA: 0x180788860 Slot: 42
	public override void NetworkInitialize__Late() { }

	// RVA: 0x77E720 Offset: 0x77D120 VA: 0x18077E720 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x77F5D0 Offset: 0x77DFD0 VA: 0x18077F5D0 Slot: 20
	public override void Awake() { }
}
