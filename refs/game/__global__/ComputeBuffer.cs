public sealed class ComputeBuffer : IDisposable // TypeDefIndex: 11867
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public int count { get; }
	public int stride { get; }
	public string name { set; }

	// Methods

	// RVA: 0x2CBA710 Offset: 0x2CB9110 VA: 0x182CBA710 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2CBA5B0 Offset: 0x2CB8FB0 VA: 0x182CBA5B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2CBA650 Offset: 0x2CB9050 VA: 0x182CBA650
	private void Dispose(bool disposing) { }

	[FreeFunction("GraphicsBuffer_Bindings::InitComputeBuffer")]
	// RVA: 0x2CBA7D0 Offset: 0x2CB91D0 VA: 0x182CBA7D0
	private static IntPtr InitBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage) { }

	[FreeFunction("GraphicsBuffer_Bindings::DestroyComputeBuffer")]
	// RVA: 0x2CBA570 Offset: 0x2CB8F70 VA: 0x182CBA570
	private static void DestroyBuffer(ComputeBuffer buf) { }

	// RVA: 0x2CBAFC0 Offset: 0x2CB99C0 VA: 0x182CBAFC0
	public void .ctor(int count, int stride) { }

	// RVA: 0x2CBAD80 Offset: 0x2CB9780 VA: 0x182CBAD80
	public void .ctor(int count, int stride, ComputeBufferType type) { }

	// RVA: 0x2CBADB0 Offset: 0x2CB97B0 VA: 0x182CBADB0
	private void .ctor(int count, int stride, ComputeBufferType type, ComputeBufferMode usage, int stackDepth) { }

	// RVA: 0x2CBA5B0 Offset: 0x2CB8FB0 VA: 0x182CBA5B0
	public void Release() { }

	// RVA: 0x2CBAFF0 Offset: 0x2CB99F0 VA: 0x182CBAFF0
	public int get_count() { }

	// RVA: 0x2CBB030 Offset: 0x2CB9A30 VA: 0x182CBB030
	public int get_stride() { }

	// RVA: 0x2CBABB0 Offset: 0x2CB95B0 VA: 0x182CBABB0
	public void SetData(Array data) { }

	// RVA: -1 Offset: -1
	public void SetData<T>(NativeArray<T> data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE69370 Offset: 0xE67D70 VA: 0x180E69370
	|-ComputeBuffer.SetData<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0xE69430 Offset: 0xE67E30 VA: 0x180E69430
	|-ComputeBuffer.SetData<ShaderInput.LightData>
	*/

	// RVA: 0x2CBA910 Offset: 0x2CB9310 VA: 0x182CBA910
	public void SetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count) { }

	[FreeFunction(Name = "GraphicsBuffer_Bindings::InternalSetNativeData", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CBA8A0 Offset: 0x2CB92A0 VA: 0x182CBA8A0
	private void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	[FreeFunction(Name = "GraphicsBuffer_Bindings::InternalSetData", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CBA830 Offset: 0x2CB9230 VA: 0x182CBA830
	private void InternalSetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	// RVA: 0x2CBAD30 Offset: 0x2CB9730 VA: 0x182CBAD30
	public void set_name(string value) { }

	[FreeFunction(Name = "GraphicsBuffer_Bindings::SetName", HasExplicitThis = True)]
	// RVA: 0x2CBAD30 Offset: 0x2CB9730 VA: 0x182CBAD30
	private void SetName(string name) { }
}
