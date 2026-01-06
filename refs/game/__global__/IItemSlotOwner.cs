public interface IItemSlotOwner // TypeDefIndex: 3064
{
	// Properties
	public abstract List<ItemSlot> ItemSlots { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract List<ItemSlot> get_ItemSlots();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_ItemSlots(List<ItemSlot> value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SetItemSlotQuantity(int itemSlotIndex, int quantity);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter);

	// RVA: 0x995540 Offset: 0x993F40 VA: 0x180995540 Slot: 6
	public virtual void SendItemSlotDataToClient(NetworkConnection conn) { }

	// RVA: 0x995400 Offset: 0x993E00 VA: 0x180995400 Slot: 7
	public virtual int GetQuantitySum() { }

	// RVA: 0x995190 Offset: 0x993B90 VA: 0x180995190 Slot: 8
	public virtual int GetQuantityOfItem(string id) { }

	// RVA: 0x994FE0 Offset: 0x9939E0 VA: 0x180994FE0 Slot: 9
	public virtual int GetNonEmptySlotCount() { }

	// RVA: 0x994E70 Offset: 0x993870 VA: 0x180994E70 Slot: 10
	public virtual ItemSlot GetFirstSlotContaining(string id) { }

	[CompilerGenerated]
	// RVA: 0x995740 Offset: 0x994140 VA: 0x180995740
	private void <SendItemSlotDataToClient>g__Send|7_0(NetworkConnection conn) { }
}
