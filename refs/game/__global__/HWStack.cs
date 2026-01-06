internal class HWStack : ICloneable // TypeDefIndex: 8073
{
	// Fields
	private object[] stack; // 0x10
	private int growthRate; // 0x18
	private int used; // 0x1C
	private int size; // 0x20
	private int limit; // 0x24

	// Properties
	internal object Item { get; set; }
	internal int Length { get; }

	// Methods

	// RVA: 0x250B820 Offset: 0x250A220 VA: 0x18250B820
	internal void .ctor(int GrowthRate) { }

	// RVA: 0x250B7A0 Offset: 0x250A1A0 VA: 0x18250B7A0
	internal void .ctor(int GrowthRate, int limit) { }

	// RVA: 0x250B670 Offset: 0x250A070 VA: 0x18250B670
	internal object Push() { }

	// RVA: 0x250B630 Offset: 0x250A030 VA: 0x18250B630
	internal object Pop() { }

	// RVA: 0x250B5F0 Offset: 0x2509FF0 VA: 0x18250B5F0
	internal object Peek() { }

	// RVA: 0x250B450 Offset: 0x2509E50 VA: 0x18250B450
	internal void AddToTop(object o) { }

	// RVA: 0x250B8A0 Offset: 0x250A2A0 VA: 0x18250B8A0
	internal object get_Item(int index) { }

	// RVA: 0x250B920 Offset: 0x250A320 VA: 0x18250B920
	internal void set_Item(int index, object value) { }

	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	internal int get_Length() { }

	// RVA: 0xA0B1D0 Offset: 0xA09BD0 VA: 0x180A0B1D0
	private void .ctor(object[] stack, int growthRate, int used, int size) { }

	// RVA: 0x250B4E0 Offset: 0x2509EE0 VA: 0x18250B4E0 Slot: 4
	public object Clone() { }
}
