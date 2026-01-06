public class TrashContainerItem : GridItem, ITransitEntity // TypeDefIndex: 3217
{
	// Fields
	public const float MAX_VERTICAL_OFFSET = 2;
	public TrashContainer Container; // 0x210
	public ParticleSystem Flies; // 0x218
	public AudioSourceController TrashAddedSound; // 0x220
	public DecalProjector PickupAreaProjector; // 0x228
	public Transform[] accessPoints; // 0x230
	[Header("Pickup settings")]
	public bool UsableByCleaners; // 0x238
	public float PickupSquareWidth; // 0x23C
	[CompilerGenerated]
	private List<ItemSlot> <InputSlots>k__BackingField; // 0x240
	[CompilerGenerated]
	private List<ItemSlot> <OutputSlots>k__BackingField; // 0x248
	[CompilerGenerated]
	private readonly bool <Selectable>k__BackingField; // 0x250
	[CompilerGenerated]
	private bool <IsAcceptingItems>k__BackingField; // 0x251
	public List<TrashItem> TrashItemsInRadius; // 0x258
	public List<TrashBag> TrashBagsInRadius; // 0x260
	private float calculatedPickupRadius; // 0x268
	private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.TrashContainerItemAssembly-CSharp.dll_Excuted; // 0x26C
	private bool NetworkInitialize__LateScheduleOne.ObjectScripts.TrashContainerItemAssembly-CSharp.dll_Excuted; // 0x26D

	// Properties
	public string Name { get; }
	public List<ItemSlot> InputSlots { get; set; }
	public List<ItemSlot> OutputSlots { get; set; }
	public Transform LinkOrigin { get; }
	public Transform[] AccessPoints { get; }
	public bool Selectable { get; }
	public bool IsAcceptingItems { get; set; }

	// Methods

	// RVA: 0x8793E0 Offset: 0x877DE0 VA: 0x1808793E0 Slot: 71
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x640C70 Offset: 0x63F670 VA: 0x180640C70 Slot: 72
	public List<ItemSlot> get_InputSlots() { }

	[CompilerGenerated]
	// RVA: 0x860C80 Offset: 0x85F680 VA: 0x180860C80 Slot: 73
	public void set_InputSlots(List<ItemSlot> value) { }

	[CompilerGenerated]
	// RVA: 0x8793A0 Offset: 0x877DA0 VA: 0x1808793A0 Slot: 74
	public List<ItemSlot> get_OutputSlots() { }

	[CompilerGenerated]
	// RVA: 0x9D8790 Offset: 0x9D7190 VA: 0x1809D8790 Slot: 75
	public void set_OutputSlots(List<ItemSlot> value) { }

	// RVA: 0x4E26A0 Offset: 0x4E10A0 VA: 0x1804E26A0 Slot: 76
	public Transform get_LinkOrigin() { }

	// RVA: 0x640F00 Offset: 0x63F900 VA: 0x180640F00 Slot: 77
	public Transform[] get_AccessPoints() { }

	[CompilerGenerated]
	// RVA: 0x9D8770 Offset: 0x9D7170 VA: 0x1809D8770 Slot: 78
	public bool get_Selectable() { }

	[CompilerGenerated]
	// RVA: 0x9D8760 Offset: 0x9D7160 VA: 0x1809D8760 Slot: 79
	public bool get_IsAcceptingItems() { }

	[CompilerGenerated]
	// RVA: 0x9D8780 Offset: 0x9D7180 VA: 0x1809D8780
	public void set_IsAcceptingItems(bool value) { }

	// RVA: 0x9D7550 Offset: 0x9D5F50 VA: 0x1809D7550 Slot: 47
	public override void Awake() { }

	// RVA: 0x9D8310 Offset: 0x9D6D10 VA: 0x1809D8310 Slot: 48
	protected override void Start() { }

	// RVA: 0x9D7B30 Offset: 0x9D6530 VA: 0x1809D7B30 Slot: 66
	public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID) { }

	// RVA: 0x9D8570 Offset: 0x9D6F70 VA: 0x1809D8570
	private void TrashLevelChanged() { }

	// RVA: 0x9D7630 Offset: 0x9D6030 VA: 0x1809D7630 Slot: 55
	public override bool CanBeDestroyed(out string reason) { }

	// RVA: 0x9D79C0 Offset: 0x9D63C0 VA: 0x1809D79C0 Slot: 61
	public override BuildableItemData GetBaseData() { }

	// RVA: 0x9D8430 Offset: 0x9D6E30 VA: 0x1809D8430
	private void TrashAdded(string trashID) { }

	// RVA: 0x9D82D0 Offset: 0x9D6CD0 VA: 0x1809D82D0 Slot: 57
	public override void ShowOutline(Color color) { }

	// RVA: 0x9D7AF0 Offset: 0x9D64F0 VA: 0x1809D7AF0 Slot: 58
	public override void HideOutline() { }

	// RVA: 0x9D76C0 Offset: 0x9D60C0 VA: 0x1809D76C0
	private void CheckTrashItems() { }

	// RVA: 0x9D72B0 Offset: 0x9D5CB0 VA: 0x1809D72B0
	private void AddTrashToRadius(TrashItem trashItem) { }

	// RVA: 0x9D70F0 Offset: 0x9D5AF0 VA: 0x1809D70F0
	private void AddTrashBagToRadius(TrashBag trashBag) { }

	// RVA: 0x9D7FB0 Offset: 0x9D69B0 VA: 0x1809D7FB0
	private void RemoveTrashItemFromRadius(TrashItem trashItem) { }

	// RVA: 0x9D7E50 Offset: 0x9D6850 VA: 0x1809D7E50
	private void RemoveTrashBagFromRadius(TrashBag trashBag) { }

	// RVA: 0x9D7CE0 Offset: 0x9D66E0 VA: 0x1809D7CE0
	private bool IsTrashValid(TrashItem trashItem) { }

	// RVA: 0x9D7BF0 Offset: 0x9D65F0 VA: 0x1809D7BF0
	public bool IsPointInPickupZone(Vector3 point) { }

	// RVA: 0x9D8600 Offset: 0x9D7000 VA: 0x1809D8600
	public void .ctor() { }

	// RVA: 0x9D7E30 Offset: 0x9D6830 VA: 0x1809D7E30 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0x9D7E10 Offset: 0x9D6810 VA: 0x1809D7E10 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x9D74A0 Offset: 0x9D5EA0 VA: 0x1809D74A0 Slot: 93
	protected override void Awake_UserLogic_ScheduleOne.ObjectScripts.TrashContainerItem_Assembly-CSharp.dll() { }
}
