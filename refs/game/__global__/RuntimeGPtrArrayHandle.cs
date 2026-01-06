internal struct RuntimeGPtrArrayHandle // TypeDefIndex: 3468
{
	// Fields
	private RuntimeStructs.GPtrArray* value; // 0x0

	// Properties
	internal int Length { get; }
	internal IntPtr Item { get; }

	// Methods

	// RVA: 0x1A8DC10 Offset: 0x1A8C610 VA: 0x181A8DC10
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x1A8DDF0 Offset: 0x1A8C7F0 VA: 0x181A8DDF0
	internal int get_Length() { }

	// RVA: 0x1A8DDE0 Offset: 0x1A8C7E0 VA: 0x181A8DDE0
	internal IntPtr get_Item(int i) { }

	// RVA: 0x1A8DD60 Offset: 0x1A8C760 VA: 0x181A8DD60
	internal IntPtr Lookup(int i) { }

	// RVA: 0x1A8DD50 Offset: 0x1A8C750 VA: 0x181A8DD50
	private static void GPtrArrayFree(RuntimeStructs.GPtrArray* value) { }

	// RVA: 0x1A8DD30 Offset: 0x1A8C730 VA: 0x181A8DD30
	internal static void DestroyAndFree(ref RuntimeGPtrArrayHandle h) { }
}
