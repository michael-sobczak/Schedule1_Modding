public class ItemSlot // TypeDefIndex: 3078
{
	// Fields
	[CompilerGenerated]
	private ItemInstance <ItemInstance>k__BackingField; // 0x10
	[CompilerGenerated]
	private IItemSlotOwner <SlotOwner>k__BackingField; // 0x18
	public Action onItemDataChanged; // 0x20
	public Action onItemInstanceChanged; // 0x28
	[CompilerGenerated]
	private ItemSlotLock <ActiveLock>k__BackingField; // 0x30
	public Action onLocked; // 0x38
	public Action onUnlocked; // 0x40
	[CompilerGenerated]
	private bool <IsRemovalLocked>k__BackingField; // 0x48
	[CompilerGenerated]
	private bool <IsAddLocked>k__BackingField; // 0x49
	[CompilerGenerated]
	private List<ItemFilter> <HardFilters>k__BackingField; // 0x50
	[CompilerGenerated]
	private bool <CanPlayerSetFilter>k__BackingField; // 0x58
	[CompilerGenerated]
	private SlotFilter <PlayerFilter>k__BackingField; // 0x60
	public Action onFilterChange; // 0x68
	[CompilerGenerated]
	private ItemSlotSiblingSet <SiblingSet>k__BackingField; // 0x70

	// Properties
	public ItemInstance ItemInstance { get; set; }
	public IItemSlotOwner SlotOwner { get; set; }
	private int SlotIndex { get; }
	public int Quantity { get; }
	public bool IsAtCapacity { get; }
	public bool IsLocked { get; }
	public ItemSlotLock ActiveLock { get; set; }
	public bool IsRemovalLocked { get; set; }
	public bool IsAddLocked { get; set; }
	protected List<ItemFilter> HardFilters { get; set; }
	public bool CanPlayerSetFilter { get; set; }
	public SlotFilter PlayerFilter { get; set; }
	public ItemSlotSiblingSet SiblingSet { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public ItemInstance get_ItemInstance() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	protected void set_ItemInstance(ItemInstance value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public IItemSlotOwner get_SlotOwner() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	protected void set_SlotOwner(IItemSlotOwner value) { }

	// RVA: 0x99F570 Offset: 0x99DF70 VA: 0x18099F570
	private int get_SlotIndex() { }

	// RVA: 0x99F550 Offset: 0x99DF50 VA: 0x18099F550
	public int get_Quantity() { }

	// RVA: 0x99F4F0 Offset: 0x99DEF0 VA: 0x18099F4F0
	public bool get_IsAtCapacity() { }

	// RVA: 0x99F540 Offset: 0x99DF40 VA: 0x18099F540
	public bool get_IsLocked() { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public ItemSlotLock get_ActiveLock() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	protected void set_ActiveLock(ItemSlotLock value) { }

	[CompilerGenerated]
	// RVA: 0x4D60D0 Offset: 0x4D4AD0 VA: 0x1804D60D0
	public bool get_IsRemovalLocked() { }

	[CompilerGenerated]
	// RVA: 0x4D6480 Offset: 0x4D4E80 VA: 0x1804D6480
	protected void set_IsRemovalLocked(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4D6190 Offset: 0x4D4B90 VA: 0x1804D6190
	public bool get_IsAddLocked() { }

	[CompilerGenerated]
	// RVA: 0x4D6510 Offset: 0x4D4F10 VA: 0x1804D6510
	protected void set_IsAddLocked(bool value) { }

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	protected List<ItemFilter> get_HardFilters() { }

	[CompilerGenerated]
	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	protected void set_HardFilters(List<ItemFilter> value) { }

	[CompilerGenerated]
	// RVA: 0x4D61A0 Offset: 0x4D4BA0 VA: 0x1804D61A0
	public bool get_CanPlayerSetFilter() { }

	[CompilerGenerated]
	// RVA: 0x4D6520 Offset: 0x4D4F20 VA: 0x1804D6520
	public void set_CanPlayerSetFilter(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public SlotFilter get_PlayerFilter() { }

	[CompilerGenerated]
	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	public void set_PlayerFilter(SlotFilter value) { }

	[CompilerGenerated]
	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public ItemSlotSiblingSet get_SiblingSet() { }

	[CompilerGenerated]
	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	public void set_SiblingSet(ItemSlotSiblingSet value) { }

	// RVA: 0x99EBD0 Offset: 0x99D5D0 VA: 0x18099EBD0
	public void SetSlotOwner(IItemSlotOwner owner) { }

	// RVA: 0x99EB40 Offset: 0x99D540 VA: 0x18099EB40
	public void SetSiblingSet(ItemSlotSiblingSet set) { }

	// RVA: 0x99F3E0 Offset: 0x99DDE0 VA: 0x18099F3E0
	public void .ctor() { }

	// RVA: 0x99F2C0 Offset: 0x99DCC0 VA: 0x18099F2C0
	public void .ctor(bool canPlayerSetFilter = False) { }

	// RVA: 0x99E600 Offset: 0x99D000 VA: 0x18099E600
	public void ReplicateStoredInstance() { }

	// RVA: 0x99ECC0 Offset: 0x99D6C0 VA: 0x18099ECC0 Slot: 4
	public virtual void SetStoredItem(ItemInstance instance, bool _internal = False) { }

	// RVA: 0x99E450 Offset: 0x99CE50 VA: 0x18099E450 Slot: 5
	public virtual void InsertItem(ItemInstance item) { }

	// RVA: 0x99D770 Offset: 0x99C170 VA: 0x18099D770 Slot: 6
	public virtual void AddItem(ItemInstance item, bool _internal = False) { }

	// RVA: 0x99DD40 Offset: 0x99C740 VA: 0x18099DD40 Slot: 7
	public virtual void ClearStoredInstance(bool _internal = False) { }

	// RVA: 0x99E860 Offset: 0x99D260 VA: 0x18099E860
	public void SetQuantity(int amount, bool _internal = False) { }

	// RVA: 0x99DA30 Offset: 0x99C430 VA: 0x18099DA30
	public void ChangeQuantity(int change, bool _internal = False) { }

	// RVA: 0x99E470 Offset: 0x99CE70 VA: 0x18099E470 Slot: 8
	protected virtual void ItemDataChanged() { }

	// RVA: 0x971D10 Offset: 0x970710 VA: 0x180971D10 Slot: 9
	protected virtual void ClearItemInstanceRequested() { }

	// RVA: 0x99D670 Offset: 0x99C070 VA: 0x18099D670
	public void AddFilter(ItemFilter filter) { }

	// RVA: 0x99D870 Offset: 0x99C270 VA: 0x18099D870
	public void ApplyLock(NetworkObject lockOwner, string lockReason, bool _internal = False) { }

	// RVA: 0x99E4C0 Offset: 0x99CEC0 VA: 0x18099E4C0
	public void RemoveLock(bool _internal = False) { }

	// RVA: 0x4D6480 Offset: 0x4D4E80 VA: 0x1804D6480
	public void SetIsRemovalLocked(bool locked) { }

	// RVA: 0x4D6510 Offset: 0x4D4F10 VA: 0x1804D6510
	public void SetIsAddLocked(bool locked) { }

	// RVA: 0x99E030 Offset: 0x99CA30 VA: 0x18099E030 Slot: 10
	public virtual bool DoesItemMatchHardFilters(ItemInstance item) { }

	// RVA: 0x99E210 Offset: 0x99CC10 VA: 0x18099E210 Slot: 11
	public virtual bool DoesItemMatchPlayerFilters(ItemInstance item) { }

	// RVA: 0x99E6D0 Offset: 0x99D0D0 VA: 0x18099E6D0
	public void SetFilterable(bool filterable) { }

	// RVA: 0x99E740 Offset: 0x99D140 VA: 0x18099E740
	public void SetPlayerFilter(SlotFilter filter, bool _internal = False) { }

	// RVA: 0x99E360 Offset: 0x99CD60 VA: 0x18099E360 Slot: 12
	public virtual int GetCapacityForItem(ItemInstance item, bool checkPlayerFilters = False) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 13
	public virtual bool CanSlotAcceptCash() { }

	// RVA: 0x99F020 Offset: 0x99DA20 VA: 0x18099F020
	public static bool TryInsertItemIntoSet(List<ItemSlot> ItemSlots, ItemInstance item) { }
}
