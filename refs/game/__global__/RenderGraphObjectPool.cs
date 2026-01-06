public sealed class RenderGraphObjectPool // TypeDefIndex: 13524
{
	// Fields
	private Dictionary<ValueTuple<Type, int>, Stack<object>> m_ArrayPool; // 0x10
	private List<ValueTuple<object, ValueTuple<Type, int>>> m_AllocatedArrays; // 0x18
	private List<MaterialPropertyBlock> m_AllocatedMaterialPropertyBlocks; // 0x20

	// Methods

	// RVA: 0x29CBFE0 Offset: 0x29CA9E0 VA: 0x1829CBFE0
	internal void .ctor() { }

	// RVA: -1 Offset: -1
	public T[] GetTempArray<T>(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF31950 Offset: 0xF30350 VA: 0x180F31950
	|-RenderGraphObjectPool.GetTempArray<RenderTargetIdentifier>
	|-RenderGraphObjectPool.GetTempArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x29CBB20 Offset: 0x29CA520 VA: 0x1829CBB20
	public MaterialPropertyBlock GetTempMaterialPropertyBlock() { }

	// RVA: 0x29CBC50 Offset: 0x29CA650 VA: 0x1829CBC50
	internal void ReleaseAllTempAlloc() { }

	// RVA: -1 Offset: -1
	internal T Get<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF31DD0 Offset: 0xF307D0 VA: 0x180F31DD0
	|-RenderGraphObjectPool.Get<object>
	|
	|-RVA: 0xF31CE0 Offset: 0xF306E0 VA: 0x180F31CE0
	|-RenderGraphObjectPool.Get<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void Release<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF31F60 Offset: 0xF30960 VA: 0x180F31F60
	|-RenderGraphObjectPool.Release<object>
	|
	|-RVA: 0xF31E40 Offset: 0xF30840 VA: 0x180F31E40
	|-RenderGraphObjectPool.Release<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x29CBA40 Offset: 0x29CA440 VA: 0x1829CBA40
	internal void Cleanup() { }
}
