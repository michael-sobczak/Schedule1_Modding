public struct NativeKeyValueArrays<TKey, TValue> : INativeDisposable, IDisposable // TypeDefIndex: 15858
{
	// Fields
	public NativeArray<TKey> Keys; // 0x0
	public NativeArray<TValue> Values; // 0x0

	// Properties
	public int Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x489DD0 Offset: 0x4887D0 VA: 0x180489DD0
	|-NativeKeyValueArrays<int, int>.get_Length
	|
	|-RVA: 0x10872F0 Offset: 0x1085CF0 VA: 0x1810872F0
	|-NativeKeyValueArrays<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_Length
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int length, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1087220 Offset: 0x1085C20 VA: 0x181087220
	|-NativeKeyValueArrays<int, int>..ctor
	|
	|-RVA: 0x1087110 Offset: 0x1085B10 VA: 0x181087110
	|-NativeKeyValueArrays<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1086ED0 Offset: 0x10858D0 VA: 0x181086ED0
	|-NativeKeyValueArrays<int, int>.Dispose
	|
	|-RVA: 0x1086E10 Offset: 0x1085810 VA: 0x181086E10
	|-NativeKeyValueArrays<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Dispose
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1 Slot: 4
	public JobHandle Dispose(JobHandle inputDeps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1087050 Offset: 0x1085A50 VA: 0x181087050
	|-NativeKeyValueArrays<int, int>.Dispose
	|
	|-RVA: 0x1086F40 Offset: 0x1085940 VA: 0x181086F40
	|-NativeKeyValueArrays<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Dispose
	*/
}
