public class PlayerInventory : PlayerSingleton<PlayerInventory> // TypeDefIndex: 1347
{
	// Fields
	public const float LABEL_DISPLAY_TIME = 2;
	public const float LABEL_FADE_TIME = 0.5;
	public const float DISCARD_TIME = 1.5;
	public const int INVENTORY_SLOT_COUNT = 8;
	[Header("Startup Items (Editor only)")]
	[SerializeField]
	private bool giveStartupItems; // 0x20
	[SerializeField]
	private List<PlayerInventory.ItemAmount> startupItems; // 0x28
	[Header("References")]
	public Transform equipContainer; // 0x30
	public List<HotbarSlot> hotbarSlots; // 0x38
	[CompilerGenerated]
	private CashSlot <cashSlot>k__BackingField; // 0x40
	[CompilerGenerated]
	private CashInstance <cashInstance>k__BackingField; // 0x48
	private ClipboardSlot clipboardSlot; // 0x50
	private List<ItemSlotUI> slotUIs; // 0x58
	private ItemSlot discardSlot; // 0x60
	[Header("Item Variables")]
	public List<PlayerInventory.ItemVariable> ItemVariables; // 0x68
	private int _equippedSlotIndex; // 0x70
	[CompilerGenerated]
	private bool <HotbarEnabled>k__BackingField; // 0x74
	[CompilerGenerated]
	private bool <EquippingEnabled>k__BackingField; // 0x75
	[CompilerGenerated]
	private Equippable <equippable>k__BackingField; // 0x78
	public Action<bool> onInventoryStateChanged; // 0x80
	public Action<int> onEquippedSlotChanged; // 0x88
	private int PriorEquippedSlotIndex; // 0x90
	private int PreviousEquippedSlotIndex; // 0x94
	public UnityEvent onPreItemEquipped; // 0x98
	public UnityEvent onItemEquipped; // 0xA0
	private bool ManagementSlotEnabled; // 0xA8
	public float currentEquipTime; // 0xAC
	protected float currentDiscardTime; // 0xB0

	// Properties
	public int TOTAL_SLOT_COUNT { get; }
	public CashSlot cashSlot { get; set; }
	public CashInstance cashInstance { get; set; }
	public int EquippedSlotIndex { get; set; }
	public bool HotbarEnabled { get; set; }
	public bool EquippingEnabled { get; set; }
	public Equippable equippable { get; set; }
	public HotbarSlot equippedSlot { get; }
	public ItemInstance EquippedItem { get; }
	public bool isAnythingEquipped { get; }

	// Methods

	// RVA: 0x658710 Offset: 0x657110 VA: 0x180658710
	public int get_TOTAL_SLOT_COUNT() { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public CashSlot get_cashSlot() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	private void set_cashSlot(CashSlot value) { }

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public CashInstance get_cashInstance() { }

	[CompilerGenerated]
	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	protected void set_cashInstance(CashInstance value) { }

	// RVA: 0x501290 Offset: 0x4FFC90 VA: 0x180501290
	public int get_EquippedSlotIndex() { }

	// RVA: 0x6587B0 Offset: 0x6571B0 VA: 0x1806587B0
	public void set_EquippedSlotIndex(int value) { }

	[CompilerGenerated]
	// RVA: 0x658700 Offset: 0x657100 VA: 0x180658700
	public bool get_HotbarEnabled() { }

	[CompilerGenerated]
	// RVA: 0x658840 Offset: 0x657240 VA: 0x180658840
	protected void set_HotbarEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6586F0 Offset: 0x6570F0 VA: 0x1806586F0
	public bool get_EquippingEnabled() { }

	[CompilerGenerated]
	// RVA: 0x658830 Offset: 0x657230 VA: 0x180658830
	protected void set_EquippingEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public Equippable get_equippable() { }

	[CompilerGenerated]
	// RVA: 0x5F4EC0 Offset: 0x5F38C0 VA: 0x1805F4EC0
	protected void set_equippable(Equippable value) { }

	// RVA: 0x658730 Offset: 0x657130 VA: 0x180658730
	public HotbarSlot get_equippedSlot() { }

	// RVA: 0x6586A0 Offset: 0x6570A0 VA: 0x1806586A0
	public ItemInstance get_EquippedItem() { }

	// RVA: 0x658750 Offset: 0x657150 VA: 0x180658750
	public bool get_isAnythingEquipped() { }

	// RVA: 0x654CA0 Offset: 0x6536A0 VA: 0x180654CA0
	public HotbarSlot IndexAllSlots(int index) { }

	// RVA: 0x654440 Offset: 0x652E40 VA: 0x180654440 Slot: 4
	protected override void Awake() { }

	// RVA: 0x6561B0 Offset: 0x654BB0 VA: 0x1806561B0
	private void SetupInventoryUI() { }

	// RVA: 0x6553C0 Offset: 0x653DC0 VA: 0x1806553C0
	private void RepositionUI() { }

	// RVA: 0x656BE0 Offset: 0x6555E0 VA: 0x180656BE0 Slot: 5
	protected override void Start() { }

	// RVA: 0x654B10 Offset: 0x653510 VA: 0x180654B10
	private void GiveStartupItems() { }

	// RVA: 0x657DC0 Offset: 0x6567C0 VA: 0x180657DC0 Slot: 8
	protected virtual void Update() { }

	// RVA: 0x657120 Offset: 0x655B20 VA: 0x180657120
	private void UpdateHotbarSelection() { }

	// RVA: 0x654780 Offset: 0x653180 VA: 0x180654780
	public void Equip(HotbarSlot slot) { }

	// RVA: 0x655F40 Offset: 0x654940 VA: 0x180655F40
	public void SetInventoryEnabled(bool enabled) { }

	// RVA: 0x655D00 Offset: 0x654700 VA: 0x180655D00
	public void SetEquippingEnabled(bool enabled) { }

	// RVA: 0x654740 Offset: 0x653140 VA: 0x180654740
	private void ClipboardAcquiredVarChange(bool newVal) { }

	// RVA: 0x654740 Offset: 0x653140 VA: 0x180654740
	public void SetManagementClipboardEnabled(bool enabled) { }

	// RVA: 0x656020 Offset: 0x654A20 VA: 0x180656020
	public void SetViewmodelVisible(bool visible) { }

	// RVA: 0x654490 Offset: 0x652E90 VA: 0x180654490
	public bool CanItemFitInInventory(ItemInstance item, int quantity = 1) { }

	// RVA: 0x654020 Offset: 0x652A20 VA: 0x180654020
	public void AddItemToInventory(ItemInstance item) { }

	// RVA: 0x6549B0 Offset: 0x6533B0 VA: 0x1806549B0
	public uint GetAmountOfItem(string ID) { }

	// RVA: 0x654E00 Offset: 0x653800 VA: 0x180654E00
	public void RemoveAmountOfItem(string ID, uint amount = 1) { }

	// RVA: 0x654680 Offset: 0x653080 VA: 0x180654680
	public void ClearInventory() { }

	// RVA: 0x655060 Offset: 0x653A60 VA: 0x180655060
	public void RemoveProductFromInventory(EStealthLevel maxStealth) { }

	// RVA: 0x655290 Offset: 0x653C90 VA: 0x180655290
	public void RemoveRandomItemsFromInventory() { }

	// RVA: 0x655C70 Offset: 0x654670 VA: 0x180655C70
	public void SetEquippable(Equippable eq) { }

	// RVA: 0x6547B0 Offset: 0x6531B0 VA: 0x1806547B0
	public void EquippedSlotChanged() { }

	// RVA: 0x654D90 Offset: 0x653790 VA: 0x180654D90
	public void Reequip() { }

	// RVA: 0x6547E0 Offset: 0x6531E0 VA: 0x1806547E0
	public List<ItemSlot> GetAllInventorySlots() { }

	// RVA: 0x657610 Offset: 0x656010 VA: 0x180657610
	private void UpdateInventoryVariables() { }

	// RVA: 0x658520 Offset: 0x656F20 VA: 0x180658520
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x657090 Offset: 0x655A90 VA: 0x180657090
	private void <Start>b__59_1() { }
}
