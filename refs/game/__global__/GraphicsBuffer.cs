public sealed class GraphicsBuffer : IDisposable // TypeDefIndex: 11672
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public string name { set; }

	// Methods

	// RVA: 0x2C8BC40 Offset: 0x2C8A640 VA: 0x182C8BC40 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2C8BA30 Offset: 0x2C8A430 VA: 0x182C8BA30 Slot: 4
	public void Dispose() { }

	// RVA: 0x2C8BAD0 Offset: 0x2C8A4D0 VA: 0x182C8BAD0
	private void Dispose(bool disposing) { }

	// RVA: 0x2C8C180 Offset: 0x2C8AB80 VA: 0x182C8C180
	private static bool RequiresCompute(GraphicsBuffer.Target target) { }

	// RVA: 0x2C8C170 Offset: 0x2C8AB70 VA: 0x182C8C170
	private static bool IsVertexIndexOrCopyOnly(GraphicsBuffer.Target target) { }

	[FreeFunction("GraphicsBuffer_Bindings::InitBuffer")]
	// RVA: 0x2C8BCA0 Offset: 0x2C8A6A0 VA: 0x182C8BCA0
	private static IntPtr InitBuffer(GraphicsBuffer.Target target, GraphicsBuffer.UsageFlags usageFlags, int count, int stride) { }

	[FreeFunction("GraphicsBuffer_Bindings::DestroyBuffer")]
	// RVA: 0x2C8B9F0 Offset: 0x2C8A3F0 VA: 0x182C8B9F0
	private static void DestroyBuffer(GraphicsBuffer buf) { }

	// RVA: 0x2C8C1E0 Offset: 0x2C8ABE0 VA: 0x182C8C1E0
	public void .ctor(GraphicsBuffer.Target target, int count, int stride) { }

	// RVA: 0x2C8BD00 Offset: 0x2C8A700 VA: 0x182C8BD00
	private void InternalInitialization(GraphicsBuffer.Target target, GraphicsBuffer.UsageFlags usageFlags, int count, int stride) { }

	// RVA: 0x2C8BA30 Offset: 0x2C8A430 VA: 0x182C8BA30
	public void Release() { }

	// RVA: -1 Offset: -1
	public void SetData<T>(NativeArray<T> data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEBDBA0 Offset: 0xEBC5A0 VA: 0x180EBDBA0
	|-GraphicsBuffer.SetData<int>
	|
	|-RVA: 0xEBD920 Offset: 0xEBC320 VA: 0x180EBD920
	|-GraphicsBuffer.SetData<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0xEBDE50 Offset: 0xEBC850 VA: 0x180EBDE50
	|-GraphicsBuffer.SetData<float4>
	|
	|-RVA: 0xEBDC30 Offset: 0xEBC630 VA: 0x180EBDC30
	|-GraphicsBuffer.SetData<ShaderInput.LightData>
	*/

	// RVA: -1 Offset: -1
	public void SetData<T>(NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEBDCC0 Offset: 0xEBC6C0 VA: 0x180EBDCC0
	|-GraphicsBuffer.SetData<uint>
	|
	|-RVA: 0xEBD9E0 Offset: 0xEBC3E0 VA: 0x180EBD9E0
	|-GraphicsBuffer.SetData<__Il2CppFullySharedGenericStructType>
	*/

	[FreeFunction(Name = "GraphicsBuffer_Bindings::InternalSetNativeData", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2C8C100 Offset: 0x2C8AB00 VA: 0x182C8C100
	private void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) { }

	// RVA: 0x2C8C190 Offset: 0x2C8AB90 VA: 0x182C8C190
	public void set_name(string value) { }

	[FreeFunction(Name = "GraphicsBuffer_Bindings::SetName", HasExplicitThis = True)]
	// RVA: 0x2C8C190 Offset: 0x2C8AB90 VA: 0x182C8C190
	private void SetName(string name) { }
}
