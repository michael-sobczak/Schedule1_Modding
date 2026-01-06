public class Marco : NPC // TypeDefIndex: 1736
{
	// Fields
	public Transform VehicleRecoveryPoint; // 0x2F0
	public VehicleDetector VehicleDetector; // 0x2F8
	public DialogueContainer RecoveryConversation; // 0x300
	public DialogueContainer GreetingDialogue; // 0x308
	public string GreetedVariable; // 0x310
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.MarcoAssembly-CSharp.dll_Excuted; // 0x318
	private bool NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.MarcoAssembly-CSharp.dll_Excuted; // 0x319

	// Methods

	// RVA: 0x7406D0 Offset: 0x73F0D0 VA: 0x1807406D0 Slot: 65
	public override void Awake() { }

	// RVA: 0x741000 Offset: 0x73FA00 VA: 0x180741000 Slot: 71
	protected override void Start() { }

	// RVA: 0x740F60 Offset: 0x73F960 VA: 0x180740F60
	private bool ShouldShowRecoverVehicle(bool enabled) { }

	// RVA: 0x740A60 Offset: 0x73F460 VA: 0x180740A60
	private bool RecoverVehicleValid(out string reason) { }

	// RVA: 0x740CB0 Offset: 0x73F6B0 VA: 0x180740CB0
	private bool RepaintVehicleValid(out string reason) { }

	// RVA: 0x740BE0 Offset: 0x73F5E0 VA: 0x180740BE0
	private void RecoverVehicle() { }

	// RVA: 0x740800 Offset: 0x73F200 VA: 0x180740800
	private void Loaded() { }

	// RVA: 0x740720 Offset: 0x73F120 VA: 0x180740720
	private void EnableGreeting() { }

	// RVA: 0x740DD0 Offset: 0x73F7D0 VA: 0x180740DD0
	private void SetGreeted() { }

	// RVA: 0x741280 Offset: 0x73FC80 VA: 0x180741280
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x741190 Offset: 0x73FB90 VA: 0x180741190
	private void <Awake>b__5_0() { }

	[CompilerGenerated]
	// RVA: 0x741220 Offset: 0x73FC20 VA: 0x180741220
	private void <Start>b__6_0() { }

	// RVA: 0x740A40 Offset: 0x73F440 VA: 0x180740A40 Slot: 102
	public override void NetworkInitialize___Early() { }

	// RVA: 0x740A20 Offset: 0x73F420 VA: 0x180740A20 Slot: 103
	public override void NetworkInitialize__Late() { }

	// RVA: 0x677A30 Offset: 0x676430 VA: 0x180677A30 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x740310 Offset: 0x73ED10 VA: 0x180740310 Slot: 111
	protected override void Awake_UserLogic_ScheduleOne.NPCs.CharacterClasses.Marco_Assembly-CSharp.dll() { }
}
