public class QualityItemInstance : StorableItemInstance // TypeDefIndex: 3085
{
	// Fields
	public EQuality Quality; // 0x38

	// Methods

	// RVA: 0x9A5630 Offset: 0x9A4030 VA: 0x1809A5630
	public void .ctor() { }

	// RVA: 0x9A5640 Offset: 0x9A4040 VA: 0x1809A5640
	public void .ctor(ItemDefinition definition, int quantity, EQuality quality) { }

	// RVA: 0x9A53D0 Offset: 0x9A3DD0 VA: 0x1809A53D0 Slot: 11
	public override bool CanStackWith(ItemInstance other, bool checkQuantities = True) { }

	// RVA: 0x9A54B0 Offset: 0x9A3EB0 VA: 0x1809A54B0 Slot: 12
	public override ItemInstance GetCopy(int overrideQuantity = -1) { }

	// RVA: 0x9A5570 Offset: 0x9A3F70 VA: 0x1809A5570 Slot: 14
	public override ItemData GetItemData() { }

	// RVA: 0x995DE0 Offset: 0x9947E0 VA: 0x180995DE0
	public void SetQuality(EQuality quality) { }
}
