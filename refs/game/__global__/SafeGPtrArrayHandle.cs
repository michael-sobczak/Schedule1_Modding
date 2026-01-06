internal struct SafeGPtrArrayHandle : IDisposable // TypeDefIndex: 3483
{
	// Fields
	private RuntimeGPtrArrayHandle handle; // 0x0

	// Properties
	internal int Length { get; }
	internal IntPtr Item { get; }

	// Methods

	// RVA: 0x1A8DC10 Offset: 0x1A8C610 VA: 0x181A8DC10
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x1A8DD30 Offset: 0x1A8C730 VA: 0x181A8DD30 Slot: 4
	public void Dispose() { }

	// RVA: 0x1A8DDF0 Offset: 0x1A8C7F0 VA: 0x181A8DDF0
	internal int get_Length() { }

	// RVA: 0x1A8DDE0 Offset: 0x1A8C7E0 VA: 0x181A8DDE0
	internal IntPtr get_Item(int i) { }
}
