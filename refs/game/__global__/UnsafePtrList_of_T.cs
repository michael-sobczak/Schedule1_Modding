public struct UnsafePtrList<T> : INativeDisposable, IDisposable, IEnumerable<IntPtr>, IEnumerable // TypeDefIndex: 15974
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	public readonly T** Ptr; // 0x0
	public readonly int m_length; // 0x0
	public readonly int m_capacity; // 0x0
	public readonly AllocatorManager.AllocatorHandle Allocator; // 0x0
	[Obsolete("Use Length property (UnityUpgradable) -> Length", True)]
	public int length; // 0x0
	[Obsolete("Use Capacity property (UnityUpgradable) -> Capacity", True)]
	public int capacity; // 0x0

	// Properties
	public int Length { get; set; }
	public int Capacity { get; set; }
	public T* Item { get; set; }
	public bool IsEmpty { get; }
	public bool IsCreated { get; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E52E0 Offset: 0x12E3CE0 VA: 0x1812E52E0
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.get_Length
	*/

	// RVA: -1 Offset: -1
	public void set_Length(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E5420 Offset: 0x12E3E20 VA: 0x1812E5420
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.set_Length
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E5180 Offset: 0x12E3B80 VA: 0x1812E5180
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E5370 Offset: 0x12E3D70 VA: 0x1812E5370
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.set_Capacity
	*/

	// RVA: -1 Offset: -1
	public T* get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DD800 Offset: 0x12DC200 VA: 0x1812DD800
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, T* value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DDA70 Offset: 0x12DC470 VA: 0x1812DDA70
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public ref T* ElementAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DBE20 Offset: 0x12DA820 VA: 0x1812DBE20
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.ElementAt
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T** ptr, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E50F0 Offset: 0x12E3AF0 VA: 0x1812E50F0
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int initialCapacity, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E4FB0 Offset: 0x12E39B0 VA: 0x1812E4FB0
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public static UnsafePtrList<T>* Create(T** ptr, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E4120 Offset: 0x12E2B20 VA: 0x1812E4120
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.Create
	*/

	// RVA: -1 Offset: -1
	public static UnsafePtrList<T>* Create(int initialCapacity, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E4280 Offset: 0x12E2C80 VA: 0x1812E4280
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.Create
	*/

	// RVA: -1 Offset: -1
	public static void Destroy(UnsafePtrList<T>* listData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E43A0 Offset: 0x12E2DA0 VA: 0x1812E43A0
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.Destroy
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E5210 Offset: 0x12E3C10 VA: 0x1812E5210
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10676B0 Offset: 0x10660B0 VA: 0x1810676B0
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.get_IsCreated
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E4650 Offset: 0x12E3050 VA: 0x1812E4650
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1 Slot: 4
	public JobHandle Dispose(JobHandle inputDeps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E4580 Offset: 0x12E2F80 VA: 0x1812E4580
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E4000 Offset: 0x12E2A00 VA: 0x1812E4000
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Resize(int length, NativeArrayOptions options = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E4D80 Offset: 0x12E3780 VA: 0x1812E4D80
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.Resize
	*/

	// RVA: -1 Offset: -1
	public void SetCapacity(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E4E40 Offset: 0x12E3840 VA: 0x1812E4E40
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.SetCapacity
	*/

	// RVA: -1 Offset: -1
	public void TrimExcess() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E4F10 Offset: 0x12E3910 VA: 0x1812E4F10
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.TrimExcess
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(void* ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E46F0 Offset: 0x12E30F0 VA: 0x1812E46F0
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public bool Contains(void* ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E4090 Offset: 0x12E2A90 VA: 0x1812E4090
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.Contains
	*/

	// RVA: -1 Offset: -1
	public void AddNoResize(void* value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E3890 Offset: 0x12E2290 VA: 0x1812E3890
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.AddNoResize
	*/

	// RVA: -1 Offset: -1
	public void AddRangeNoResize(void** ptr, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E3960 Offset: 0x12E2360 VA: 0x1812E3960
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.AddRangeNoResize
	*/

	// RVA: -1 Offset: -1
	public void AddRangeNoResize(UnsafePtrList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E3A30 Offset: 0x12E2430 VA: 0x1812E3A30
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.AddRangeNoResize
	*/

	// RVA: -1 Offset: -1
	public void Add(in IntPtr value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E3D50 Offset: 0x12E2750 VA: 0x1812E3D50
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Add(void* value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E3E00 Offset: 0x12E2800 VA: 0x1812E3E00
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.Add
	*/

	// RVA: -1 Offset: -1
	public void AddRange(void* ptr, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E3C90 Offset: 0x12E2690 VA: 0x1812E3C90
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.AddRange
	*/

	// RVA: -1 Offset: -1
	public void AddRange(UnsafePtrList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E3B40 Offset: 0x12E2540 VA: 0x1812E3B40
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.AddRange
	*/

	// RVA: -1 Offset: -1
	public void InsertRangeWithBeginEnd(int begin, int end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E47A0 Offset: 0x12E31A0 VA: 0x1812E47A0
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.InsertRangeWithBeginEnd
	*/

	// RVA: -1 Offset: -1
	public void RemoveAtSwapBack(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E4860 Offset: 0x12E3260 VA: 0x1812E4860
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.RemoveAtSwapBack
	*/

	// RVA: -1 Offset: -1
	public void RemoveRangeSwapBack(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E4AB0 Offset: 0x12E34B0 VA: 0x1812E4AB0
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.RemoveRangeSwapBack
	*/

	[Obsolete("RemoveRangeSwapBackWithBeginEnd(begin, end) is deprecated, use RemoveRangeSwapBack(index, count) instead. (RemovedAfter 2021-06-02)", False)]
	// RVA: -1 Offset: -1
	public void RemoveRangeSwapBackWithBeginEnd(int begin, int end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E49C0 Offset: 0x12E33C0 VA: 0x1812E49C0
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.RemoveRangeSwapBackWithBeginEnd
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E4910 Offset: 0x12E3310 VA: 0x1812E4910
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public void RemoveRange(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E4C90 Offset: 0x12E3690 VA: 0x1812E4C90
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.RemoveRange
	*/

	[Obsolete("RemoveRangeWithBeginEnd(begin, end) is deprecated, use RemoveRange(index, count) instead. (RemovedAfter 2021-06-02)", False)]
	// RVA: -1 Offset: -1
	public void RemoveRangeWithBeginEnd(int begin, int end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E4BA0 Offset: 0x12E35A0 VA: 0x1812E4BA0
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.RemoveRangeWithBeginEnd
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator<IntPtr> System.Collections.Generic.IEnumerable<System.IntPtr>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.System.Collections.Generic.IEnumerable<System.IntPtr>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public UnsafePtrList.ParallelReader<T> AsParallelReader() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E3EC0 Offset: 0x12E28C0 VA: 0x1812E3EC0
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.AsParallelReader
	*/

	// RVA: -1 Offset: -1
	public UnsafePtrList.ParallelWriter<T> AsParallelWriter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E3F90 Offset: 0x12E2990 VA: 0x1812E3F90
	|-UnsafePtrList<__Il2CppFullySharedGenericStructType>.AsParallelWriter
	*/
}
