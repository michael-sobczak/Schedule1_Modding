public struct UnsafePtrList.ParallelWriter<T> // TypeDefIndex: 15973
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	public readonly T** Ptr; // 0x0
	[NativeDisableUnsafePtrRestriction]
	public UnsafeList<IntPtr>* ListData; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(T** ptr, UnsafeList<IntPtr>* listData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC41170 Offset: 0xC3FB70 VA: 0x180C41170
	|-UnsafePtrList.ParallelWriter<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void AddNoResize(T* value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F18A0 Offset: 0x10F02A0 VA: 0x1810F18A0
	|-UnsafePtrList.ParallelWriter<__Il2CppFullySharedGenericStructType>.AddNoResize
	*/

	// RVA: -1 Offset: -1
	public void AddRangeNoResize(T** ptr, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F1EC0 Offset: 0x10F08C0 VA: 0x1810F1EC0
	|-UnsafePtrList.ParallelWriter<__Il2CppFullySharedGenericStructType>.AddRangeNoResize
	*/

	// RVA: -1 Offset: -1
	public void AddRangeNoResize(UnsafePtrList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F20D0 Offset: 0x10F0AD0 VA: 0x1810F20D0
	|-UnsafePtrList.ParallelWriter<__Il2CppFullySharedGenericStructType>.AddRangeNoResize
	*/
}
