internal sealed class SizedArray : ICloneable // TypeDefIndex: 4507
{
	// Fields
	internal object[] objects; // 0x10
	internal object[] negObjects; // 0x18

	// Properties
	internal object Item { get; set; }

	// Methods

	// RVA: 0x1B758D0 Offset: 0x1B742D0 VA: 0x181B758D0
	internal void .ctor() { }

	// RVA: 0x1B75950 Offset: 0x1B74350 VA: 0x181B75950
	internal void .ctor(int length) { }

	// RVA: 0x1B759D0 Offset: 0x1B743D0 VA: 0x181B759D0
	private void .ctor(SizedArray sizedArray) { }

	// RVA: 0x1B75600 Offset: 0x1B74000 VA: 0x181B75600 Slot: 4
	public object Clone() { }

	// RVA: 0x1B75AB0 Offset: 0x1B744B0 VA: 0x181B75AB0
	internal object get_Item(int index) { }

	// RVA: 0x1B75B20 Offset: 0x1B74520 VA: 0x181B75B20
	internal void set_Item(int index, object value) { }

	// RVA: 0x1B75700 Offset: 0x1B74100 VA: 0x181B75700
	internal void IncreaseCapacity(int index) { }
}
