internal class ShaderData : IDisposable // TypeDefIndex: 9011
{
	// Fields
	private static ShaderData m_Instance; // 0x0
	private ComputeBuffer m_LightDataBuffer; // 0x10
	private ComputeBuffer m_LightIndicesBuffer; // 0x18
	private ComputeBuffer m_AdditionalLightShadowParamsStructuredBuffer; // 0x20
	private ComputeBuffer m_AdditionalLightShadowSliceMatricesStructuredBuffer; // 0x28

	// Properties
	internal static ShaderData instance { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	private void .ctor() { }

	// RVA: 0x2B279B0 Offset: 0x2B263B0 VA: 0x182B279B0
	internal static ShaderData get_instance() { }

	// RVA: 0x2B277C0 Offset: 0x2B261C0 VA: 0x182B277C0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2B27910 Offset: 0x2B26310 VA: 0x182B27910
	internal ComputeBuffer GetLightDataBuffer(int size) { }

	// RVA: 0x2B27960 Offset: 0x2B26360 VA: 0x182B27960
	internal ComputeBuffer GetLightIndicesBuffer(int size) { }

	// RVA: 0x2B27870 Offset: 0x2B26270 VA: 0x182B27870
	internal ComputeBuffer GetAdditionalLightShadowParamsStructuredBuffer(int size) { }

	// RVA: 0x2B278C0 Offset: 0x2B262C0 VA: 0x182B278C0
	internal ComputeBuffer GetAdditionalLightShadowSliceMatricesStructuredBuffer(int size) { }

	// RVA: -1 Offset: -1
	private ComputeBuffer GetOrUpdateBuffer<T>(ref ComputeBuffer buffer, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF4EA30 Offset: 0xF4D430 VA: 0x180F4EA30
	|-ShaderData.GetOrUpdateBuffer<int>
	|-ShaderData.GetOrUpdateBuffer<Matrix4x4>
	|-ShaderData.GetOrUpdateBuffer<Vector4>
	|-ShaderData.GetOrUpdateBuffer<ShaderInput.LightData>
	|
	|-RVA: 0xF4E950 Offset: 0xF4D350 VA: 0x180F4E950
	|-ShaderData.GetOrUpdateBuffer<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2B27780 Offset: 0x2B26180 VA: 0x182B27780
	private void DisposeBuffer(ref ComputeBuffer buffer) { }
}
