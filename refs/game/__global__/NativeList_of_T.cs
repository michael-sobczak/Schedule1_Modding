public struct NativeList<T> : INativeDisposable, IDisposable, INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 15854
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	internal UnsafeList<T>* m_ListData; // 0x0
	internal AllocatorManager.AllocatorHandle m_DeprecatedAllocator; // 0x0

	// Properties
	public T Item { get; set; }
	public int Length { get; set; }
	public int Capacity { get; set; }
	public bool IsEmpty { get; }
	public bool IsCreated { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108AB40 Offset: 0x1089540 VA: 0x18108AB40
	|-NativeList<byte>..ctor
	|
	|-RVA: 0x108ACE0 Offset: 0x10896E0 VA: 0x18108ACE0
	|-NativeList<int>..ctor
	|
	|-RVA: 0x108AD60 Offset: 0x1089760 VA: 0x18108AD60
	|-NativeList<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int initialCapacity, AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108AC50 Offset: 0x1089650 VA: 0x18108AC50
	|-NativeList<byte>..ctor
	|
	|-RVA: 0x108ABC0 Offset: 0x10895C0 VA: 0x18108ABC0
	|-NativeList<int>..ctor
	|
	|-RVA: 0x1085E20 Offset: 0x1084820 VA: 0x181085E20
	|-NativeList<__Il2CppFullySharedGenericStructType>..ctor
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(AllocatorManager.AllocatorHandle) })]
	// RVA: -1 Offset: -1
	internal void Initialize<U>(int initialCapacity, ref U allocator, int disposeSentinelStackDepth) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC92E0 Offset: 0xDC7CE0 VA: 0x180DC92E0
	|-NativeList<byte>.Initialize<AllocatorManager.AllocatorHandle>
	|
	|-RVA: 0xDC9450 Offset: 0xDC7E50 VA: 0x180DC9450
	|-NativeList<int>.Initialize<AllocatorManager.AllocatorHandle>
	|
	|-RVA: 0xDC95C0 Offset: 0xDC7FC0 VA: 0x180DC95C0
	|-NativeList<__Il2CppFullySharedGenericStructType>.Initialize<__Il2CppFullySharedGenericStructType>
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(AllocatorManager.AllocatorHandle) })]
	// RVA: -1 Offset: -1
	internal static NativeList<T> New<U>(int initialCapacity, ref U allocator, int disposeSentinelStackDepth) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC96C0 Offset: 0xDC80C0 VA: 0x180DC96C0
	|-NativeList<__Il2CppFullySharedGenericStructType>.New<__Il2CppFullySharedGenericStructType>
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(AllocatorManager.AllocatorHandle) })]
	// RVA: -1 Offset: -1
	internal static NativeList<T> New<U>(int initialCapacity, ref U allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC9740 Offset: 0xDC8140 VA: 0x180DC9740
	|-NativeList<__Il2CppFullySharedGenericStructType>.New<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	private void .ctor(int initialCapacity, AllocatorManager.AllocatorHandle allocator, int disposeSentinelStackDepth) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108ADF0 Offset: 0x10897F0 VA: 0x18108ADF0
	|-NativeList<byte>..ctor
	|
	|-RVA: 0x108AE60 Offset: 0x1089860 VA: 0x18108AE60
	|-NativeList<int>..ctor
	|
	|-RVA: 0x108AAA0 Offset: 0x10894A0 VA: 0x18108AAA0
	|-NativeList<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108B260 Offset: 0x1089C60 VA: 0x18108B260
	|-NativeList<byte>.get_Item
	|
	|-RVA: 0x108B210 Offset: 0x1089C10 VA: 0x18108B210
	|-NativeList<int>.get_Item
	|
	|-RVA: 0x108B100 Offset: 0x1089B00 VA: 0x18108B100
	|-NativeList<__Il2CppFullySharedGenericStructType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108B680 Offset: 0x108A080 VA: 0x18108B680
	|-NativeList<byte>.set_Item
	|
	|-RVA: 0x108B6E0 Offset: 0x108A0E0 VA: 0x18108B6E0
	|-NativeList<int>.set_Item
	|
	|-RVA: 0x108B580 Offset: 0x1089F80 VA: 0x18108B580
	|-NativeList<__Il2CppFullySharedGenericStructType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public ref T ElementAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10891C0 Offset: 0x1087BC0 VA: 0x1810891C0
	|-NativeList<byte>.ElementAt
	|
	|-RVA: 0x1089170 Offset: 0x1087B70 VA: 0x181089170
	|-NativeList<int>.ElementAt
	|
	|-RVA: 0x1089210 Offset: 0x1087C10 VA: 0x181089210
	|-NativeList<__Il2CppFullySharedGenericStructType>.ElementAt
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108B2B0 Offset: 0x1089CB0 VA: 0x18108B2B0
	|-NativeList<byte>.get_Length
	|-NativeList<int>.get_Length
	|
	|-RVA: 0x108B2F0 Offset: 0x1089CF0 VA: 0x18108B2F0
	|-NativeList<__Il2CppFullySharedGenericStructType>.get_Length
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public void set_Length(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108B740 Offset: 0x108A140 VA: 0x18108B740
	|-NativeList<byte>.set_Length
	|
	|-RVA: 0x108B820 Offset: 0x108A220 VA: 0x18108B820
	|-NativeList<int>.set_Length
	|
	|-RVA: 0x108B790 Offset: 0x108A190 VA: 0x18108B790
	|-NativeList<__Il2CppFullySharedGenericStructType>.set_Length
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108AED0 Offset: 0x10898D0 VA: 0x18108AED0
	|-NativeList<byte>.get_Capacity
	|-NativeList<int>.get_Capacity
	|
	|-RVA: 0x108AF10 Offset: 0x1089910 VA: 0x18108AF10
	|-NativeList<__Il2CppFullySharedGenericStructType>.get_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108B530 Offset: 0x1089F30 VA: 0x18108B530
	|-NativeList<byte>.set_Capacity
	|
	|-RVA: 0x108B4E0 Offset: 0x1089EE0 VA: 0x18108B4E0
	|-NativeList<int>.set_Capacity
	|
	|-RVA: 0x108B460 Offset: 0x1089E60 VA: 0x18108B460
	|-NativeList<__Il2CppFullySharedGenericStructType>.set_Capacity
	*/

	// RVA: -1 Offset: -1
	public UnsafeList<T>* GetUnsafeList() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	|-NativeList<byte>.GetUnsafeList
	|-NativeList<int>.GetUnsafeList
	|-NativeList<__Il2CppFullySharedGenericStructType>.GetUnsafeList
	*/

	// RVA: -1 Offset: -1
	public void AddNoResize(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1087410 Offset: 0x1085E10 VA: 0x181087410
	|-NativeList<byte>.AddNoResize
	|
	|-RVA: 0x10873C0 Offset: 0x1085DC0 VA: 0x1810873C0
	|-NativeList<int>.AddNoResize
	|
	|-RVA: 0x1087460 Offset: 0x1085E60 VA: 0x181087460
	|-NativeList<__Il2CppFullySharedGenericStructType>.AddNoResize
	*/

	// RVA: -1 Offset: -1
	public void AddRangeNoResize(void* ptr, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1087660 Offset: 0x1086060 VA: 0x181087660
	|-NativeList<byte>.AddRangeNoResize
	|
	|-RVA: 0x1087760 Offset: 0x1086160 VA: 0x181087760
	|-NativeList<int>.AddRangeNoResize
	|
	|-RVA: 0x1087550 Offset: 0x1085F50 VA: 0x181087550
	|-NativeList<__Il2CppFullySharedGenericStructType>.AddRangeNoResize
	*/

	// RVA: -1 Offset: -1
	public void AddRangeNoResize(NativeList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10875F0 Offset: 0x1085FF0 VA: 0x1810875F0
	|-NativeList<byte>.AddRangeNoResize
	|
	|-RVA: 0x10877C0 Offset: 0x10861C0 VA: 0x1810877C0
	|-NativeList<int>.AddRangeNoResize
	|
	|-RVA: 0x10876C0 Offset: 0x10860C0 VA: 0x1810876C0
	|-NativeList<__Il2CppFullySharedGenericStructType>.AddRangeNoResize
	*/

	// RVA: -1 Offset: -1
	public void Add(in T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1087CD0 Offset: 0x10866D0 VA: 0x181087CD0
	|-NativeList<byte>.Add
	|
	|-RVA: 0x1087DB0 Offset: 0x10867B0 VA: 0x181087DB0
	|-NativeList<int>.Add
	|
	|-RVA: 0x1087D20 Offset: 0x1086720 VA: 0x181087D20
	|-NativeList<__Il2CppFullySharedGenericStructType>.Add
	*/

	// RVA: -1 Offset: -1
	public void AddRange(NativeArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1087980 Offset: 0x1086380 VA: 0x181087980
	|-NativeList<byte>.AddRange
	|
	|-RVA: 0x1087830 Offset: 0x1086230 VA: 0x181087830
	|-NativeList<int>.AddRange
	|
	|-RVA: 0x1087B10 Offset: 0x1086510 VA: 0x181087B10
	|-NativeList<__Il2CppFullySharedGenericStructType>.AddRange
	*/

	// RVA: -1 Offset: -1
	public void AddRange(void* ptr, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1087910 Offset: 0x1086310 VA: 0x181087910
	|-NativeList<byte>.AddRange
	|
	|-RVA: 0x1087C60 Offset: 0x1086660 VA: 0x181087C60
	|-NativeList<int>.AddRange
	|
	|-RVA: 0x1087A60 Offset: 0x1086460 VA: 0x181087A60
	|-NativeList<__Il2CppFullySharedGenericStructType>.AddRange
	*/

	// RVA: -1 Offset: -1
	public void InsertRangeWithBeginEnd(int begin, int end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1089660 Offset: 0x1088060 VA: 0x181089660
	|-NativeList<byte>.InsertRangeWithBeginEnd
	|
	|-RVA: 0x1089530 Offset: 0x1087F30 VA: 0x181089530
	|-NativeList<int>.InsertRangeWithBeginEnd
	|
	|-RVA: 0x10895B0 Offset: 0x1087FB0 VA: 0x1810895B0
	|-NativeList<__Il2CppFullySharedGenericStructType>.InsertRangeWithBeginEnd
	*/

	// RVA: -1 Offset: -1
	public void RemoveAtSwapBack(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1089770 Offset: 0x1088170 VA: 0x181089770
	|-NativeList<byte>.RemoveAtSwapBack
	|
	|-RVA: 0x10897D0 Offset: 0x10881D0 VA: 0x1810897D0
	|-NativeList<int>.RemoveAtSwapBack
	|
	|-RVA: 0x10896E0 Offset: 0x10880E0 VA: 0x1810896E0
	|-NativeList<__Il2CppFullySharedGenericStructType>.RemoveAtSwapBack
	*/

	// RVA: -1 Offset: -1
	public void RemoveRangeSwapBack(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1089B30 Offset: 0x1088530 VA: 0x181089B30
	|-NativeList<byte>.RemoveRangeSwapBack
	|
	|-RVA: 0x1089BB0 Offset: 0x10885B0 VA: 0x181089BB0
	|-NativeList<int>.RemoveRangeSwapBack
	|
	|-RVA: 0x1089C30 Offset: 0x1088630 VA: 0x181089C30
	|-NativeList<__Il2CppFullySharedGenericStructType>.RemoveRangeSwapBack
	*/

	[Obsolete("RemoveRangeSwapBackWithBeginEnd(begin, end) is deprecated, use RemoveRangeSwapBack(index, count) instead. (RemovedAfter 2021-06-02)", False)]
	// RVA: -1 Offset: -1
	public void RemoveRangeSwapBackWithBeginEnd(int begin, int end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1089980 Offset: 0x1088380 VA: 0x181089980
	|-NativeList<byte>.RemoveRangeSwapBackWithBeginEnd
	|
	|-RVA: 0x1089AB0 Offset: 0x10884B0 VA: 0x181089AB0
	|-NativeList<int>.RemoveRangeSwapBackWithBeginEnd
	|
	|-RVA: 0x1089A00 Offset: 0x1088400 VA: 0x181089A00
	|-NativeList<__Il2CppFullySharedGenericStructType>.RemoveRangeSwapBackWithBeginEnd
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1089890 Offset: 0x1088290 VA: 0x181089890
	|-NativeList<byte>.RemoveAt
	|
	|-RVA: 0x1089830 Offset: 0x1088230 VA: 0x181089830
	|-NativeList<int>.RemoveAt
	|
	|-RVA: 0x10898F0 Offset: 0x10882F0 VA: 0x1810898F0
	|-NativeList<__Il2CppFullySharedGenericStructType>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public void RemoveRange(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1089E40 Offset: 0x1088840 VA: 0x181089E40
	|-NativeList<byte>.RemoveRange
	|
	|-RVA: 0x1089EA0 Offset: 0x10888A0 VA: 0x181089EA0
	|-NativeList<int>.RemoveRange
	|
	|-RVA: 0x1089F00 Offset: 0x1088900 VA: 0x181089F00
	|-NativeList<__Il2CppFullySharedGenericStructType>.RemoveRange
	*/

	[Obsolete("RemoveRangeWithBeginEnd(begin, end) is deprecated, use RemoveRange(index, count) instead. (RemovedAfter 2021-06-02)", False)]
	// RVA: -1 Offset: -1
	public void RemoveRangeWithBeginEnd(int begin, int end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1089D80 Offset: 0x1088780 VA: 0x181089D80
	|-NativeList<byte>.RemoveRangeWithBeginEnd
	|
	|-RVA: 0x1089DE0 Offset: 0x10887E0 VA: 0x181089DE0
	|-NativeList<int>.RemoveRangeWithBeginEnd
	|
	|-RVA: 0x1089CE0 Offset: 0x10886E0 VA: 0x181089CE0
	|-NativeList<__Il2CppFullySharedGenericStructType>.RemoveRangeWithBeginEnd
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108B060 Offset: 0x1089A60 VA: 0x18108B060
	|-NativeList<byte>.get_IsEmpty
	|-NativeList<int>.get_IsEmpty
	|
	|-RVA: 0x108AF80 Offset: 0x1089980 VA: 0x18108AF80
	|-NativeList<__Il2CppFullySharedGenericStructType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10676B0 Offset: 0x10660B0 VA: 0x1810676B0
	|-NativeList<byte>.get_IsCreated
	|-NativeList<int>.get_IsCreated
	|-NativeList<__Il2CppFullySharedGenericStructType>.get_IsCreated
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1089120 Offset: 0x1087B20 VA: 0x181089120
	|-NativeList<byte>.Dispose
	|
	|-RVA: 0x10890D0 Offset: 0x1087AD0 VA: 0x1810890D0
	|-NativeList<int>.Dispose
	|
	|-RVA: 0x1088FC0 Offset: 0x10879C0 VA: 0x181088FC0
	|-NativeList<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(AllocatorManager.AllocatorHandle) })]
	// RVA: -1 Offset: -1
	internal void Dispose<U>(ref U allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC9280 Offset: 0xDC7C80 VA: 0x180DC9280
	|-NativeList<__Il2CppFullySharedGenericStructType>.Dispose<__Il2CppFullySharedGenericStructType>
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1 Slot: 4
	public JobHandle Dispose(JobHandle inputDeps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1088F40 Offset: 0x1087940 VA: 0x181088F40
	|-NativeList<byte>.Dispose
	|
	|-RVA: 0x1088EC0 Offset: 0x10878C0 VA: 0x181088EC0
	|-NativeList<int>.Dispose
	|
	|-RVA: 0x1089050 Offset: 0x1087A50 VA: 0x181089050
	|-NativeList<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10887F0 Offset: 0x10871F0 VA: 0x1810887F0
	|-NativeList<byte>.Clear
	|-NativeList<int>.Clear
	|
	|-RVA: 0x1088830 Offset: 0x1087230 VA: 0x181088830
	|-NativeList<__Il2CppFullySharedGenericStructType>.Clear
	*/

	// RVA: -1 Offset: -1
	public static NativeArray<T> op_Implicit(NativeList<T> nativeList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108B370 Offset: 0x1089D70 VA: 0x18108B370
	|-NativeList<byte>.op_Implicit
	|-NativeList<int>.op_Implicit
	|
	|-RVA: 0x108B3D0 Offset: 0x1089DD0 VA: 0x18108B3D0
	|-NativeList<__Il2CppFullySharedGenericStructType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public NativeArray<T> AsArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1087F10 Offset: 0x1086910 VA: 0x181087F10
	|-NativeList<byte>.AsArray
	|-NativeList<int>.AsArray
	|
	|-RVA: 0x1087E00 Offset: 0x1086800 VA: 0x181087E00
	|-NativeList<__Il2CppFullySharedGenericStructType>.AsArray
	*/

	// RVA: -1 Offset: -1
	public NativeArray<T> AsDeferredJobArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1088070 Offset: 0x1086A70 VA: 0x181088070
	|-NativeList<byte>.AsDeferredJobArray
	|-NativeList<int>.AsDeferredJobArray
	|
	|-RVA: 0x1087FD0 Offset: 0x10869D0 VA: 0x181087FD0
	|-NativeList<__Il2CppFullySharedGenericStructType>.AsDeferredJobArray
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108A900 Offset: 0x1089300 VA: 0x18108A900
	|-NativeList<byte>.ToArray
	|
	|-RVA: 0x108A950 Offset: 0x1089350 VA: 0x18108A950
	|-NativeList<int>.ToArray
	|
	|-RVA: 0x108A880 Offset: 0x1089280 VA: 0x18108A880
	|-NativeList<__Il2CppFullySharedGenericStructType>.ToArray
	*/

	// RVA: -1 Offset: -1
	public NativeArray<T> ToArray(AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108A6F0 Offset: 0x10890F0 VA: 0x18108A6F0
	|-NativeList<byte>.ToArray
	|
	|-RVA: 0x108A560 Offset: 0x1088F60 VA: 0x18108A560
	|-NativeList<int>.ToArray
	|
	|-RVA: 0x108A390 Offset: 0x1088D90 VA: 0x18108A390
	|-NativeList<__Il2CppFullySharedGenericStructType>.ToArray
	*/

	// RVA: -1 Offset: -1
	public NativeArray.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1089480 Offset: 0x1087E80 VA: 0x181089480
	|-NativeList<byte>.GetEnumerator
	|
	|-RVA: 0x1089290 Offset: 0x1087C90 VA: 0x181089290
	|-NativeList<int>.GetEnumerator
	|
	|-RVA: 0x1089340 Offset: 0x1087D40 VA: 0x181089340
	|-NativeList<__Il2CppFullySharedGenericStructType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-NativeList<byte>.System.Collections.IEnumerable.GetEnumerator
	|-NativeList<int>.System.Collections.IEnumerable.GetEnumerator
	|-NativeList<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-NativeList<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeList<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeList<__Il2CppFullySharedGenericStructType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[NotBurstCompatible]
	[Obsolete("Please use `CopyFromNBC` from `Unity.Collections.NotBurstCompatible` namespace instead. (RemovedAfter 2021-06-22)", False)]
	// RVA: -1 Offset: -1
	public void CopyFrom(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1088C00 Offset: 0x1087600 VA: 0x181088C00
	|-NativeList<byte>.CopyFrom
	|
	|-RVA: 0x1088C60 Offset: 0x1087660 VA: 0x181088C60
	|-NativeList<int>.CopyFrom
	|
	|-RVA: 0x10888B0 Offset: 0x10872B0 VA: 0x1810888B0
	|-NativeList<__Il2CppFullySharedGenericStructType>.CopyFrom
	*/

	// RVA: -1 Offset: -1
	public void CopyFrom(NativeArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1088940 Offset: 0x1087340 VA: 0x181088940
	|-NativeList<byte>.CopyFrom
	|
	|-RVA: 0x1088AA0 Offset: 0x10874A0 VA: 0x181088AA0
	|-NativeList<int>.CopyFrom
	|
	|-RVA: 0x1088CC0 Offset: 0x10876C0 VA: 0x181088CC0
	|-NativeList<__Il2CppFullySharedGenericStructType>.CopyFrom
	*/

	// RVA: -1 Offset: -1
	public void Resize(int length, NativeArrayOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108A110 Offset: 0x1088B10 VA: 0x18108A110
	|-NativeList<byte>.Resize
	|
	|-RVA: 0x108A170 Offset: 0x1088B70 VA: 0x18108A170
	|-NativeList<int>.Resize
	|
	|-RVA: 0x108A1D0 Offset: 0x1088BD0 VA: 0x18108A1D0
	|-NativeList<__Il2CppFullySharedGenericStructType>.Resize
	*/

	// RVA: -1 Offset: -1
	public void ResizeUninitialized(int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108A010 Offset: 0x1088A10 VA: 0x18108A010
	|-NativeList<byte>.ResizeUninitialized
	|
	|-RVA: 0x1089FA0 Offset: 0x10889A0 VA: 0x181089FA0
	|-NativeList<int>.ResizeUninitialized
	|
	|-RVA: 0x108A080 Offset: 0x1088A80 VA: 0x18108A080
	|-NativeList<__Il2CppFullySharedGenericStructType>.ResizeUninitialized
	*/

	// RVA: -1 Offset: -1
	public void SetCapacity(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108A2B0 Offset: 0x1088CB0 VA: 0x18108A2B0
	|-NativeList<byte>.SetCapacity
	|
	|-RVA: 0x108A260 Offset: 0x1088C60 VA: 0x18108A260
	|-NativeList<int>.SetCapacity
	|
	|-RVA: 0x108A300 Offset: 0x1088D00 VA: 0x18108A300
	|-NativeList<__Il2CppFullySharedGenericStructType>.SetCapacity
	*/

	// RVA: -1 Offset: -1
	public void TrimExcess() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108A9A0 Offset: 0x10893A0 VA: 0x18108A9A0
	|-NativeList<byte>.TrimExcess
	|
	|-RVA: 0x108A9E0 Offset: 0x10893E0 VA: 0x18108A9E0
	|-NativeList<int>.TrimExcess
	|
	|-RVA: 0x108AA20 Offset: 0x1089420 VA: 0x18108AA20
	|-NativeList<__Il2CppFullySharedGenericStructType>.TrimExcess
	*/

	// RVA: -1 Offset: -1
	public NativeArray.ReadOnly<T> AsParallelReader() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10880E0 Offset: 0x1086AE0 VA: 0x1810880E0
	|-NativeList<byte>.AsParallelReader
	|-NativeList<int>.AsParallelReader
	|
	|-RVA: 0x1088190 Offset: 0x1086B90 VA: 0x181088190
	|-NativeList<__Il2CppFullySharedGenericStructType>.AsParallelReader
	*/

	// RVA: -1 Offset: -1
	public NativeList.ParallelWriter<T> AsParallelWriter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1088270 Offset: 0x1086C70 VA: 0x181088270
	|-NativeList<byte>.AsParallelWriter
	|-NativeList<int>.AsParallelWriter
	|-NativeList<__Il2CppFullySharedGenericStructType>.AsParallelWriter
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private static void CheckInitialCapacity(int initialCapacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1088610 Offset: 0x1087010 VA: 0x181088610
	|-NativeList<byte>.CheckInitialCapacity
	|-NativeList<int>.CheckInitialCapacity
	|-NativeList<__Il2CppFullySharedGenericStructType>.CheckInitialCapacity
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private static void CheckTotalSize(int initialCapacity, long totalSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1088740 Offset: 0x1087140 VA: 0x181088740
	|-NativeList<byte>.CheckTotalSize
	|-NativeList<int>.CheckTotalSize
	|-NativeList<__Il2CppFullySharedGenericStructType>.CheckTotalSize
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private static void CheckSufficientCapacity(int capacity, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1088680 Offset: 0x1087080 VA: 0x181088680
	|-NativeList<byte>.CheckSufficientCapacity
	|-NativeList<int>.CheckSufficientCapacity
	|-NativeList<__Il2CppFullySharedGenericStructType>.CheckSufficientCapacity
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private static void CheckIndexInRange(int value, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10884E0 Offset: 0x1086EE0 VA: 0x1810884E0
	|-NativeList<byte>.CheckIndexInRange
	|-NativeList<int>.CheckIndexInRange
	|-NativeList<__Il2CppFullySharedGenericStructType>.CheckIndexInRange
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private static void CheckArgPositive(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10882A0 Offset: 0x1086CA0 VA: 0x1810882A0
	|-NativeList<byte>.CheckArgPositive
	|-NativeList<int>.CheckArgPositive
	|-NativeList<__Il2CppFullySharedGenericStructType>.CheckArgPositive
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private void CheckHandleMatches(AllocatorManager.AllocatorHandle handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1088340 Offset: 0x1086D40 VA: 0x181088340
	|-NativeList<byte>.CheckHandleMatches
	|-NativeList<int>.CheckHandleMatches
	|-NativeList<__Il2CppFullySharedGenericStructType>.CheckHandleMatches
	*/
}
