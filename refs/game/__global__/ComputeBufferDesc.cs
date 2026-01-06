public struct ComputeBufferDesc // TypeDefIndex: 13529
{
	// Fields
	public int count; // 0x0
	public int stride; // 0x4
	public ComputeBufferType type; // 0x8
	public string name; // 0x10

	// Methods

	// RVA: 0x29C7110 Offset: 0x29C5B10 VA: 0x1829C7110
	public void .ctor(int count, int stride) { }

	// RVA: 0x29C70F0 Offset: 0x29C5AF0 VA: 0x1829C70F0
	public void .ctor(int count, int stride, ComputeBufferType type) { }

	// RVA: 0x29C70C0 Offset: 0x29C5AC0 VA: 0x1829C70C0 Slot: 2
	public override int GetHashCode() { }
}
