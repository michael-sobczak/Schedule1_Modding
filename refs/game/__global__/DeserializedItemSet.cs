public class DeserializedItemSet // TypeDefIndex: 986
{
	// Fields
	public ItemInstance[] Items; // 0x10
	public SlotFilter[] SlotFilters; // 0x18

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x5D8B60 Offset: 0x5D7560 VA: 0x1805D8B60
	public ItemInstance GetItemAt(int index) { }

	// RVA: 0x5D8BA0 Offset: 0x5D75A0 VA: 0x1805D8BA0
	public SlotFilter GetSlotFilterAt(int index) { }

	// RVA: 0x5D8BE0 Offset: 0x5D75E0 VA: 0x1805D8BE0
	public void LoadTo(List<ItemSlot> slots) { }
}
