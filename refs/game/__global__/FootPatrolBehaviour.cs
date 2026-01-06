public class FootPatrolBehaviour : Behaviour // TypeDefIndex: 1838
{
	// Fields
	public const float MOVE_SPEED = 0.08;
	public const int FLASHLIGHT_MIN_TIME = 1930;
	public int FLASHLIGHT_MAX_TIME; // 0x168
	public const string FLASHLIGHT_ASSET_PATH = "Tools/Flashlight/Flashlight_AvatarEquippable";
	public bool UseFlashlight; // 0x16C
	private bool flashlightEquipped; // 0x16D
	[CompilerGenerated]
	private PatrolGroup <Group>k__BackingField; // 0x170
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.FootPatrolBehaviourAssembly-CSharp.dll_Excuted; // 0x178
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.FootPatrolBehaviourAssembly-CSharp.dll_Excuted; // 0x179

	// Properties
	public PatrolGroup Group { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x73B360 Offset: 0x739D60 VA: 0x18073B360
	public PatrolGroup get_Group() { }

	[CompilerGenerated]
	// RVA: 0x73B4B0 Offset: 0x739EB0 VA: 0x18073B4B0
	protected void set_Group(PatrolGroup value) { }

	// RVA: 0x7615B0 Offset: 0x75FFB0 VA: 0x1807615B0 Slot: 22
	public override void Activate() { }

	// RVA: 0x7628C0 Offset: 0x7612C0 VA: 0x1807628C0 Slot: 25
	public override void Resume() { }

	// RVA: 0x762750 Offset: 0x761150 VA: 0x180762750 Slot: 24
	public override void Pause() { }

	// RVA: 0x761750 Offset: 0x760150 VA: 0x180761750 Slot: 23
	public override void Deactivate() { }

	// RVA: 0x761E10 Offset: 0x760810 VA: 0x180761E10 Slot: 28
	public override void OnActiveTick() { }

	// RVA: 0x762A60 Offset: 0x761460 VA: 0x180762A60
	private void SetFlashlightEquipped(bool equipped) { }

	// RVA: 0x762B00 Offset: 0x761500 VA: 0x180762B00
	public void SetGroup(PatrolGroup group) { }

	// RVA: 0x761A80 Offset: 0x760480 VA: 0x180761A80
	public bool IsReadyToAdvance() { }

	// RVA: 0x761900 Offset: 0x760300 VA: 0x180761900
	private bool IsAtDestination() { }

	// RVA: 0x762BE0 Offset: 0x7615E0 VA: 0x180762BE0
	public void .ctor() { }

	// RVA: 0x761DF0 Offset: 0x7607F0 VA: 0x180761DF0 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x761DD0 Offset: 0x7607D0 VA: 0x180761DD0 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x7305E0 Offset: 0x72EFE0 VA: 0x1807305E0 Slot: 19
	public override void Awake() { }
}
