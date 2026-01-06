internal struct ResourceLocator // TypeDefIndex: 4667
{
	// Fields
	internal object _value; // 0x0
	internal int _dataPos; // 0x8

	// Properties
	internal int DataPosition { get; }
	internal object Value { get; set; }

	// Methods

	// RVA: 0xB2C8C0 Offset: 0xB2B2C0 VA: 0x180B2C8C0
	internal void .ctor(int dataPos, object value) { }

	// RVA: 0x489DD0 Offset: 0x4887D0 VA: 0x180489DD0
	internal int get_DataPosition() { }

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	internal object get_Value() { }

	// RVA: 0x48A530 Offset: 0x488F30 VA: 0x18048A530
	internal void set_Value(object value) { }

	// RVA: 0x1B6B150 Offset: 0x1B69B50 VA: 0x181B6B150
	internal static bool CanCache(ResourceTypeCode value) { }
}
