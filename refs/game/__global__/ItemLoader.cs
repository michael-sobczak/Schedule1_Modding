public class ItemLoader // TypeDefIndex: 1131
{
	// Properties
	public virtual string ItemType { get; }

	// Methods

	// RVA: 0x5DC020 Offset: 0x5DAA20 VA: 0x1805DC020 Slot: 4
	public virtual string get_ItemType() { }

	// RVA: 0x5DBF20 Offset: 0x5DA920 VA: 0x1805DBF20
	public void .ctor() { }

	// RVA: 0x5DBD60 Offset: 0x5DA760 VA: 0x1805DBD60 Slot: 5
	public virtual ItemInstance LoadItem(string itemString) { }

	// RVA: -1 Offset: -1
	protected T LoadData<T>(string itemString) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE4380 Offset: 0xEE2D80 VA: 0x180EE4380
	|-ItemLoader.LoadData<object>
	*/
}
