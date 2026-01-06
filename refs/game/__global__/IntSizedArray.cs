internal sealed class IntSizedArray : ICloneable // TypeDefIndex: 4508
{
	// Fields
	internal int[] objects; // 0x10
	internal int[] negObjects; // 0x18

	// Properties
	internal int Item { get; set; }

	// Methods

	// RVA: 0x1B62DC0 Offset: 0x1B617C0 VA: 0x181B62DC0
	public void .ctor() { }

	// RVA: 0x1B62CA0 Offset: 0x1B616A0 VA: 0x181B62CA0
	private void .ctor(IntSizedArray sizedArray) { }

	// RVA: 0x1B62980 Offset: 0x1B61380 VA: 0x181B62980 Slot: 4
	public object Clone() { }

	// RVA: 0x1B62E40 Offset: 0x1B61840 VA: 0x181B62E40
	internal int get_Item(int index) { }

	// RVA: 0x1B62EB0 Offset: 0x1B618B0 VA: 0x181B62EB0
	internal void set_Item(int index, int value) { }

	// RVA: 0x1B62AD0 Offset: 0x1B614D0 VA: 0x181B62AD0
	internal void IncreaseCapacity(int index) { }
}
