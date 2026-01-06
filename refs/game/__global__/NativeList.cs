public struct NativeList.ParallelWriter<T> // TypeDefIndex: 15853
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	public UnsafeList<T>* ListData; // 0x0

	// Properties
	public void* Ptr { get; }

	// Methods

	[IsReadOnly]
	// RVA: -1 Offset: -1
	public void* get_Ptr() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF09B50 Offset: 0xF08550 VA: 0x180F09B50
	|-NativeList.ParallelWriter<byte>.get_Ptr
	|-NativeList.ParallelWriter<int>.get_Ptr
	|-NativeList.ParallelWriter<__Il2CppFullySharedGenericStructType>.get_Ptr
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(UnsafeList<T>* listData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	|-NativeList.ParallelWriter<byte>..ctor
	|-NativeList.ParallelWriter<int>..ctor
	|-NativeList.ParallelWriter<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void AddNoResize(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F1970 Offset: 0x10F0370 VA: 0x1810F1970
	|-NativeList.ParallelWriter<byte>.AddNoResize
	|
	|-RVA: 0x10F1900 Offset: 0x10F0300 VA: 0x1810F1900
	|-NativeList.ParallelWriter<int>.AddNoResize
	|
	|-RVA: 0x10F1A50 Offset: 0x10F0450 VA: 0x1810F1A50
	|-NativeList.ParallelWriter<__Il2CppFullySharedGenericStructType>.AddNoResize
	*/

	// RVA: -1 Offset: -1
	public void AddRangeNoResize(void* ptr, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F1B80 Offset: 0x10F0580 VA: 0x1810F1B80
	|-NativeList.ParallelWriter<byte>.AddRangeNoResize
	|
	|-RVA: 0x10F2270 Offset: 0x10F0C70 VA: 0x1810F2270
	|-NativeList.ParallelWriter<int>.AddRangeNoResize
	|
	|-RVA: 0x10F1E20 Offset: 0x10F0820 VA: 0x1810F1E20
	|-NativeList.ParallelWriter<__Il2CppFullySharedGenericStructType>.AddRangeNoResize
	*/

	// RVA: -1 Offset: -1
	public void AddRangeNoResize(UnsafeList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F1D70 Offset: 0x10F0770 VA: 0x1810F1D70
	|-NativeList.ParallelWriter<byte>.AddRangeNoResize
	|
	|-RVA: 0x10F1CB0 Offset: 0x10F06B0 VA: 0x1810F1CB0
	|-NativeList.ParallelWriter<int>.AddRangeNoResize
	|
	|-RVA: 0x10F2190 Offset: 0x10F0B90 VA: 0x1810F2190
	|-NativeList.ParallelWriter<__Il2CppFullySharedGenericStructType>.AddRangeNoResize
	*/

	// RVA: -1 Offset: -1
	public void AddRangeNoResize(NativeList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F2080 Offset: 0x10F0A80 VA: 0x1810F2080
	|-NativeList.ParallelWriter<byte>.AddRangeNoResize
	|
	|-RVA: 0x10F2030 Offset: 0x10F0A30 VA: 0x1810F2030
	|-NativeList.ParallelWriter<int>.AddRangeNoResize
	|
	|-RVA: 0x10F1F90 Offset: 0x10F0990 VA: 0x1810F1F90
	|-NativeList.ParallelWriter<__Il2CppFullySharedGenericStructType>.AddRangeNoResize
	*/
}
