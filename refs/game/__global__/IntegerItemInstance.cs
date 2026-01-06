public class IntegerItemInstance : StorableItemInstance // TypeDefIndex: 3066
{
	// Fields
	public int Value; // 0x38

	// Methods

	// RVA: 0x7CFB30 Offset: 0x7CE530 VA: 0x1807CFB30
	public void .ctor() { }

	// RVA: 0x7CFB00 Offset: 0x7CE500 VA: 0x1807CFB00
	public void .ctor(ItemDefinition definition, int quantity, int value) { }

	// RVA: 0x995CD0 Offset: 0x9946D0 VA: 0x180995CD0 Slot: 12
	public override ItemInstance GetCopy(int overrideQuantity = -1) { }

	// RVA: 0x995CB0 Offset: 0x9946B0 VA: 0x180995CB0
	public void ChangeValue(int change) { }

	// RVA: 0x995DE0 Offset: 0x9947E0 VA: 0x180995DE0
	public void SetValue(int value) { }

	// RVA: 0x995D60 Offset: 0x994760 VA: 0x180995D60 Slot: 14
	public override ItemData GetItemData() { }
}
