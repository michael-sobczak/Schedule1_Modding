public class StorableItemInstance : ItemInstance // TypeDefIndex: 2392
{
	// Properties
	[CodegenExclude]
	public virtual StoredItem StoredItem { get; }

	// Methods

	// RVA: 0x87FF20 Offset: 0x87E920 VA: 0x18087FF20 Slot: 16
	public virtual StoredItem get_StoredItem() { }

	// RVA: 0x87FF10 Offset: 0x87E910 VA: 0x18087FF10
	public void .ctor() { }

	// RVA: 0x87FE00 Offset: 0x87E800 VA: 0x18087FE00
	public void .ctor(ItemDefinition definition, int quantity) { }

	// RVA: 0x87FB80 Offset: 0x87E580 VA: 0x18087FB80 Slot: 12
	public override ItemInstance GetCopy(int overrideQuantity = -1) { }

	// RVA: 0x87FCD0 Offset: 0x87E6D0 VA: 0x18087FCD0 Slot: 15
	public override float GetMonetaryValue() { }
}
