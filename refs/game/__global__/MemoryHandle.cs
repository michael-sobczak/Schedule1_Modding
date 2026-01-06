public struct MemoryHandle : IDisposable // TypeDefIndex: 5028
{
	// Fields
	private void* _pointer; // 0x0
	private GCHandle _handle; // 0x8
	private IPinnable _pinnable; // 0x10

	// Properties
	[CLSCompliant(False)]
	public void* Pointer { get; }

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x1C0F780 Offset: 0x1C0E180 VA: 0x181C0F780
	public void .ctor(void* pointer, GCHandle handle, IPinnable pinnable) { }

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public void* get_Pointer() { }

	// RVA: 0x1C0F700 Offset: 0x1C0E100 VA: 0x181C0F700 Slot: 4
	public void Dispose() { }
}
