public class Equippable_TrashGrabber : Equippable_Viewmodel // TypeDefIndex: 2528
{
	// Fields
	[CompilerGenerated]
	private static Equippable_TrashGrabber <Instance>k__BackingField; // 0x0
	public const float TrashDropSpacing = 0.15;
	[Header("References")]
	public Transform TrashContent; // 0x60
	public Transform TrashContent_Min; // 0x68
	public Transform TrashContent_Max; // 0x70
	public Animation GrabAnim; // 0x78
	public Transform Bin; // 0x80
	public Transform BinRaisedPosition; // 0x88
	public AudioSourceController TrashDropSound; // 0x90
	[Header("Settings")]
	public float DropTime; // 0x98
	public float DropForce; // 0x9C
	public Vector3 TrashDropOffset; // 0xA0
	public UnityEvent onPickup; // 0xB0
	[CompilerGenerated]
	private float <currentDropTime>k__BackingField; // 0xB8
	[CompilerGenerated]
	private float <timeSinceLastDrop>k__BackingField; // 0xBC
	private TrashGrabberInstance trashGrabberInstance; // 0xC0
	private Pose defaultBinPosition; // 0xC8
	private Vector3 defaultBinScale; // 0xE4

	// Properties
	public static Equippable_TrashGrabber Instance { get; set; }
	public static bool IsEquipped { get; }
	private float currentDropTime { get; set; }
	private float timeSinceLastDrop { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8B55F0 Offset: 0x8B3FF0 VA: 0x1808B55F0
	public static Equippable_TrashGrabber get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x8B56B0 Offset: 0x8B40B0 VA: 0x1808B56B0
	private static void set_Instance(Equippable_TrashGrabber value) { }

	// RVA: 0x8B5630 Offset: 0x8B4030 VA: 0x1808B5630
	public static bool get_IsEquipped() { }

	[CompilerGenerated]
	// RVA: 0x4F2360 Offset: 0x4F0D60 VA: 0x1804F2360
	private float get_currentDropTime() { }

	[CompilerGenerated]
	// RVA: 0x8B5710 Offset: 0x8B4110 VA: 0x1808B5710
	private void set_currentDropTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x4F2430 Offset: 0x4F0E30 VA: 0x1804F2430
	private float get_timeSinceLastDrop() { }

	[CompilerGenerated]
	// RVA: 0x8B5720 Offset: 0x8B4120 VA: 0x1808B5720
	private void set_timeSinceLastDrop(float value) { }

	// RVA: 0x8B4760 Offset: 0x8B3160 VA: 0x1808B4760 Slot: 4
	public override void Equip(ItemInstance item) { }

	// RVA: 0x8B4EC0 Offset: 0x8B38C0 VA: 0x1808B4EC0 Slot: 5
	public override void Unequip() { }

	// RVA: 0x8B5090 Offset: 0x8B3A90 VA: 0x1808B5090 Slot: 6
	protected override void Update() { }

	// RVA: 0x8B43B0 Offset: 0x8B2DB0 VA: 0x1808B43B0
	private void EjectTrash() { }

	// RVA: 0x8B4B00 Offset: 0x8B3500 VA: 0x1808B4B00
	private void OnDestroy() { }

	// RVA: 0x8B4BD0 Offset: 0x8B35D0 VA: 0x1808B4BD0
	public void PickupTrash(TrashItem item) { }

	// RVA: 0x8B4AD0 Offset: 0x8B34D0 VA: 0x1808B4AD0
	public int GetCapacity() { }

	// RVA: 0x8B4C60 Offset: 0x8B3660 VA: 0x1808B4C60
	private void RefreshVisuals() { }

	// RVA: 0x8B5570 Offset: 0x8B3F70 VA: 0x1808B5570
	public void .ctor() { }
}
