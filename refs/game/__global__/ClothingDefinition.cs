public class ClothingDefinition : StorableItemDefinition // TypeDefIndex: 1999
{
	// Fields
	public EClothingSlot Slot; // 0xC0
	public EClothingApplicationType ApplicationType; // 0xC4
	public string ClothingAssetPath; // 0xC8
	public bool Colorable; // 0xD0
	public EClothingColor DefaultColor; // 0xD4
	public List<EClothingSlot> SlotsToBlock; // 0xD8

	// Methods

	// RVA: 0x7CF8B0 Offset: 0x7CE2B0 VA: 0x1807CF8B0 Slot: 4
	public override ItemInstance GetDefaultInstance(int quantity = 1) { }

	// RVA: 0x7CF930 Offset: 0x7CE330 VA: 0x1807CF930
	public void .ctor() { }
}
