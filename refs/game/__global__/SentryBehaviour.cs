public class SentryBehaviour : Behaviour // TypeDefIndex: 1858
{
	// Fields
	public const float BODY_SEARCH_CHANCE = 0.75;
	public const int FLASHLIGHT_MIN_TIME = 1930;
	public int FLASHLIGHT_MAX_TIME; // 0x168
	public const string FLASHLIGHT_ASSET_PATH = "Tools/Flashlight/Flashlight_AvatarEquippable";
	public bool UseFlashlight; // 0x16C
	private bool flashlightEquipped; // 0x16D
	[CompilerGenerated]
	private SentryLocation <AssignedLocation>k__BackingField; // 0x170
	private PoliceOfficer officer; // 0x178
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.SentryBehaviourAssembly-CSharp.dll_Excuted; // 0x180
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.SentryBehaviourAssembly-CSharp.dll_Excuted; // 0x181

	// Properties
	public SentryLocation AssignedLocation { get; set; }
	private Transform standPoint { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x73B360 Offset: 0x739D60 VA: 0x18073B360
	public SentryLocation get_AssignedLocation() { }

	[CompilerGenerated]
	// RVA: 0x73B4B0 Offset: 0x739EB0 VA: 0x18073B4B0
	private void set_AssignedLocation(SentryLocation value) { }

	// RVA: 0x7712E0 Offset: 0x76FCE0 VA: 0x1807712E0
	private Transform get_standPoint() { }

	// RVA: 0x770AD0 Offset: 0x76F4D0 VA: 0x180770AD0 Slot: 19
	public override void Awake() { }

	// RVA: 0x73ED60 Offset: 0x73D760 VA: 0x18073ED60 Slot: 22
	public override void Activate() { }

	// RVA: 0x73F9D0 Offset: 0x73E3D0 VA: 0x18073F9D0 Slot: 25
	public override void Resume() { }

	// RVA: 0x770BE0 Offset: 0x76F5E0 VA: 0x180770BE0 Slot: 23
	public override void Deactivate() { }

	// RVA: 0x7710F0 Offset: 0x76FAF0 VA: 0x1807710F0 Slot: 24
	public override void Pause() { }

	// RVA: 0x73D060 Offset: 0x73BA60 VA: 0x18073D060 Slot: 21
	public override void Disable() { }

	// RVA: 0x770820 Offset: 0x76F220 VA: 0x180770820
	public void AssignLocation(SentryLocation loc) { }

	// RVA: 0x771220 Offset: 0x76FC20 VA: 0x180771220
	public void UnassignLocation() { }

	// RVA: 0x770C90 Offset: 0x76F690 VA: 0x180770C90 Slot: 28
	public override void OnActiveTick() { }

	// RVA: 0x771180 Offset: 0x76FB80 VA: 0x180771180
	private void SetFlashlightEquipped(bool equipped) { }

	// RVA: 0x762BE0 Offset: 0x7615E0 VA: 0x180762BE0
	public void .ctor() { }

	// RVA: 0x770C70 Offset: 0x76F670 VA: 0x180770C70 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x747D50 Offset: 0x746750 VA: 0x180747D50 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x7709E0 Offset: 0x76F3E0 VA: 0x1807709E0 Slot: 34
	protected override void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.SentryBehaviour_Assembly-CSharp.dll() { }
}
