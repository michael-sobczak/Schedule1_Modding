public class TrashBag_Equippable : Equippable_Viewmodel // TypeDefIndex: 2236
{
	// Fields
	public const float TRASH_CONTAINER_INTERACT_DISTANCE = 2.75;
	public const float BAG_TRASH_TIME = 1;
	public const float PICKUP_RANGE = 3;
	public const float PICKUP_AREA_RADIUS = 0.5;
	[CompilerGenerated]
	private bool <IsBaggingTrash>k__BackingField; // 0x60
	[CompilerGenerated]
	private bool <IsPickingUpTrash>k__BackingField; // 0x61
	public LayerMask PickupLookMask; // 0x64
	[Header("References")]
	public DecalProjector PickupAreaProjector; // 0x68
	public AudioSourceController RustleSound; // 0x70
	public AudioSourceController BagSound; // 0x78
	private float _bagTrashTime; // 0x80
	private TrashContainer _baggedContainer; // 0x88
	private float _pickupTrashTime; // 0x90

	// Properties
	public static bool IsHoveringTrash { get; }
	public bool IsBaggingTrash { get; set; }
	public bool IsPickingUpTrash { get; set; }

	// Methods

	// RVA: 0x8482B0 Offset: 0x846CB0 VA: 0x1808482B0
	public static bool get_IsHoveringTrash() { }

	[CompilerGenerated]
	// RVA: 0x4C1D90 Offset: 0x4C0790 VA: 0x1804C1D90
	public bool get_IsBaggingTrash() { }

	[CompilerGenerated]
	// RVA: 0x68C180 Offset: 0x68AB80 VA: 0x18068C180
	private void set_IsBaggingTrash(bool value) { }

	[CompilerGenerated]
	// RVA: 0x848340 Offset: 0x846D40 VA: 0x180848340
	public bool get_IsPickingUpTrash() { }

	[CompilerGenerated]
	// RVA: 0x848350 Offset: 0x846D50 VA: 0x180848350
	private void set_IsPickingUpTrash(bool value) { }

	// RVA: 0x846AC0 Offset: 0x8454C0 VA: 0x180846AC0 Slot: 4
	public override void Equip(ItemInstance item) { }

	// RVA: 0x847820 Offset: 0x846220 VA: 0x180847820 Slot: 5
	public override void Unequip() { }

	// RVA: 0x8478F0 Offset: 0x8462F0 VA: 0x1808478F0 Slot: 6
	protected override void Update() { }

	// RVA: 0x846D80 Offset: 0x845780 VA: 0x180846D80
	private TrashContainer GetHoveredTrashContainer() { }

	// RVA: 0x8471A0 Offset: 0x845BA0 VA: 0x1808471A0
	private bool RaycastLook(out RaycastHit hit) { }

	// RVA: 0x847110 Offset: 0x845B10 VA: 0x180847110
	private bool IsPickupLocationValid(RaycastHit hit) { }

	// RVA: 0x846F20 Offset: 0x845920 VA: 0x180846F20
	private List<TrashItem> GetTrashItemsAtPoint(Vector3 pos) { }

	// RVA: 0x847250 Offset: 0x845C50 VA: 0x180847250
	private void StartBagTrash(TrashContainer container) { }

	// RVA: 0x8472F0 Offset: 0x845CF0 VA: 0x1808472F0
	private void StopBagTrash(bool complete) { }

	// RVA: 0x8472B0 Offset: 0x845CB0 VA: 0x1808472B0
	private void StartPickup() { }

	// RVA: 0x847390 Offset: 0x845D90 VA: 0x180847390
	private void StopPickup(bool complete) { }

	// RVA: 0x840740 Offset: 0x83F140 VA: 0x180840740
	public void .ctor() { }
}
