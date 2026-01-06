public class ClothingInstance : StorableItemInstance // TypeDefIndex: 2000
{
	// Fields
	public EClothingColor Color; // 0x38

	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x7CFB40 Offset: 0x7CE540 VA: 0x1807CFB40 Slot: 4
	public override string get_Name() { }

	// RVA: 0x7CFB30 Offset: 0x7CE530 VA: 0x1807CFB30
	public void .ctor() { }

	// RVA: 0x7CFB00 Offset: 0x7CE500 VA: 0x1807CFB00
	public void .ctor(ItemDefinition definition, int quantity, EClothingColor color) { }

	// RVA: 0x7CF9F0 Offset: 0x7CE3F0 VA: 0x1807CF9F0 Slot: 12
	public override ItemInstance GetCopy(int overrideQuantity = -1) { }

	// RVA: 0x7CFA80 Offset: 0x7CE480 VA: 0x1807CFA80 Slot: 14
	public override ItemData GetItemData() { }
}
