public class ItemSet // TypeDefIndex: 987
{
	// Fields
	public string[] Items; // 0x10
	public SlotFilter[] SlotFilters; // 0x18

	// Methods

	// RVA: 0x5DCA60 Offset: 0x5DB460 VA: 0x1805DCA60
	public void .ctor(List<ItemData> items) { }

	// RVA: 0x5DC0A0 Offset: 0x5DAAA0 VA: 0x1805DC0A0
	public string GetJSON() { }

	// RVA: 0x5DC730 Offset: 0x5DB130 VA: 0x1805DC730
	public void .ctor(List<ItemSlot> itemSlots) { }

	// RVA: 0x5DCB80 Offset: 0x5DB580 VA: 0x1805DCB80
	public void .ctor(ItemSlot[] itemSlots) { }

	// RVA: 0x5DC150 Offset: 0x5DAB50 VA: 0x1805DC150
	public void LoadTo(List<ItemSlot> slots) { }

	// RVA: 0x5DC2A0 Offset: 0x5DACA0 VA: 0x1805DC2A0
	public void LoadTo(ItemSlot[] slots) { }

	// RVA: 0x5DC0B0 Offset: 0x5DAAB0 VA: 0x1805DC0B0
	public void LoadTo(ItemSlot slot, int index = 0) { }

	// RVA: 0x5DC300 Offset: 0x5DAD00 VA: 0x1805DC300
	public static bool TryDeserialize(string json, out DeserializedItemSet itemSet) { }

	// RVA: 0x5DC450 Offset: 0x5DAE50 VA: 0x1805DC450
	public static bool TryDeserialize(ItemSet set, out DeserializedItemSet itemSet) { }
}
