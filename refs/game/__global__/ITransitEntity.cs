public interface ITransitEntity // TypeDefIndex: 1227
{
	// Properties
	public abstract string Name { get; }
	public abstract List<ItemSlot> InputSlots { get; set; }
	public abstract List<ItemSlot> OutputSlots { get; set; }
	public abstract Transform LinkOrigin { get; }
	public abstract Transform[] AccessPoints { get; }
	public abstract bool Selectable { get; }
	public abstract bool IsAcceptingItems { get; }
	public abstract bool IsDestroyed { get; }
	public abstract Guid GUID { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract List<ItemSlot> get_InputSlots();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_InputSlots(List<ItemSlot> value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract List<ItemSlot> get_OutputSlots();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void set_OutputSlots(List<ItemSlot> value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Transform get_LinkOrigin();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Transform[] get_AccessPoints();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_Selectable();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_IsAcceptingItems();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_IsDestroyed();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Guid get_GUID();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void ShowOutline(Color color);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void HideOutline();

	// RVA: 0x610710 Offset: 0x60F110 VA: 0x180610710 Slot: 13
	public virtual void InsertItemIntoInput(ItemInstance item, NPC inserter) { }

	// RVA: 0x610A80 Offset: 0x60F480 VA: 0x180610A80 Slot: 14
	public virtual void InsertItemIntoOutput(ItemInstance item, NPC inserter) { }

	// RVA: 0x60FED0 Offset: 0x60E8D0 VA: 0x18060FED0 Slot: 15
	public virtual int GetInputCapacityForItem(ItemInstance item, NPC asker, bool checkPlayerFilters = True) { }

	// RVA: 0x610270 Offset: 0x60EC70 VA: 0x180610270 Slot: 16
	public virtual int GetOutputCapacityForItem(ItemInstance item, NPC asker) { }

	// RVA: 0x610610 Offset: 0x60F010 VA: 0x180610610 Slot: 17
	public virtual ItemSlot GetOutputItemContainer(ItemInstance item) { }

	// RVA: 0x6110C0 Offset: 0x60FAC0 VA: 0x1806110C0 Slot: 18
	public virtual List<ItemSlot> ReserveInputSlotsForItem(ItemInstance item, NetworkObject locker) { }

	// RVA: 0x610E30 Offset: 0x60F830 VA: 0x180610E30 Slot: 19
	public virtual void RemoveSlotLocks(NetworkObject locker) { }

	// RVA: 0x60F940 Offset: 0x60E340 VA: 0x18060F940 Slot: 20
	public virtual ItemSlot GetFirstSlotContainingItem(string id, ITransitEntity.ESlotType searchType) { }

	// RVA: 0x60FC00 Offset: 0x60E600 VA: 0x18060FC00 Slot: 21
	public virtual ItemSlot GetFirstSlotContainingTemplateItem(ItemInstance templateItem, ITransitEntity.ESlotType searchType) { }
}
