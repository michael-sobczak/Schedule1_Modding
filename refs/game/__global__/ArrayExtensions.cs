public static class ArrayExtensions // TypeDefIndex: 13834
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static void ResizeArray<T>(ref NativeArray<T> array, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE21EA0 Offset: 0xE208A0 VA: 0x180E21EA0
	|-ArrayExtensions.ResizeArray<bool>
	|
	|-RVA: 0xE21F50 Offset: 0xE20950 VA: 0x180E21F50
	|-ArrayExtensions.ResizeArray<BoundingSphere>
	|-ArrayExtensions.ResizeArray<float4>
	|-ArrayExtensions.ResizeArray<quaternion>
	|
	|-RVA: 0xE22090 Offset: 0xE20A90 VA: 0x180E22090
	|-ArrayExtensions.ResizeArray<DecalEntity>
	|-ArrayExtensions.ResizeArray<DecalSubDrawCall>
	|-ArrayExtensions.ResizeArray<float2>
	|
	|-RVA: 0xE222D0 Offset: 0xE20CD0 VA: 0x180E222D0
	|-ArrayExtensions.ResizeArray<int>
	|-ArrayExtensions.ResizeArray<Int32Enum>
	|-ArrayExtensions.ResizeArray<float>
	|-ArrayExtensions.ResizeArray<uint>
	|
	|-RVA: 0xE22380 Offset: 0xE20D80 VA: 0x180E22380
	|-ArrayExtensions.ResizeArray<ulong>
	|
	|-RVA: 0xE221D0 Offset: 0xE20BD0 VA: 0x180E221D0
	|-ArrayExtensions.ResizeArray<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0xE22430 Offset: 0xE20E30 VA: 0x180E22430
	|-ArrayExtensions.ResizeArray<float3>
	|
	|-RVA: 0xE224E0 Offset: 0xE20EE0 VA: 0x180E224E0
	|-ArrayExtensions.ResizeArray<float4x4>
	*/

	[Extension]
	// RVA: 0x2A2E9C0 Offset: 0x2A2D3C0 VA: 0x182A2E9C0
	public static void ResizeArray(ref TransformAccessArray array, int capacity) { }

	// RVA: -1 Offset: -1
	public static void ResizeArray<T>(ref T[] array, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE22000 Offset: 0xE20A00 VA: 0x180E22000
	|-ArrayExtensions.ResizeArray<BoundingSphere>
	|-ArrayExtensions.ResizeArray<int>
	|-ArrayExtensions.ResizeArray<object>
	|
	|-RVA: 0xE22140 Offset: 0xE20B40 VA: 0x180E22140
	|-ArrayExtensions.ResizeArray<__Il2CppFullySharedGenericType>
	*/
}
