public struct ComputeBufferHandle // TypeDefIndex: 13528
{
	// Fields
	private static ComputeBufferHandle s_NullHandle; // 0x0
	internal ResourceHandle handle; // 0x0

	// Properties
	public static ComputeBufferHandle nullHandle { get; }

	// Methods

	// RVA: 0x29C71C0 Offset: 0x29C5BC0 VA: 0x1829C71C0
	public static ComputeBufferHandle get_nullHandle() { }

	// RVA: 0x29C7180 Offset: 0x29C5B80 VA: 0x1829C7180
	internal void .ctor(int handle, bool shared = False) { }

	// RVA: 0x29C7210 Offset: 0x29C5C10 VA: 0x1829C7210
	public static ComputeBuffer op_Implicit(ComputeBufferHandle buffer) { }

	// RVA: 0x29C7130 Offset: 0x29C5B30 VA: 0x1829C7130
	public bool IsValid() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private static void .cctor() { }
}
