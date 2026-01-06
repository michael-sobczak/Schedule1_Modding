public struct UnsafeList<T> : INativeDisposable, IDisposable, INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 15969
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	public T* Ptr; // 0x0
	public int m_length; // 0x0
	public int m_capacity; // 0x0
	public AllocatorManager.AllocatorHandle Allocator; // 0x0
	[Obsolete("Use Length property (UnityUpgradable) -> Length", True)]
	public int length; // 0x0
	[Obsolete("Use Capacity property (UnityUpgradable) -> Capacity", True)]
	public int capacity; // 0x0

	// Properties
	public int Length { get; set; }
	public int Capacity { get; set; }
	public T Item { get; set; }
	public bool IsEmpty { get; }
	public bool IsCreated { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 12
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D98B0 Offset: 0x12D82B0 VA: 0x1812D98B0
	|-UnsafeList<byte>.get_Length
	|-UnsafeList<int>.get_Length
	|-UnsafeList<IntPtr>.get_Length
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.get_Length
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public void set_Length(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D9960 Offset: 0x12D8360 VA: 0x1812D9960
	|-UnsafeList<byte>.set_Length
	|
	|-RVA: 0x12DDC70 Offset: 0x12DC670 VA: 0x1812DDC70
	|-UnsafeList<int>.set_Length
	|
	|-RVA: 0x12DDBE0 Offset: 0x12DC5E0 VA: 0x1812DDBE0
	|-UnsafeList<IntPtr>.set_Length
	|
	|-RVA: 0x12DDD00 Offset: 0x12DC700 VA: 0x1812DDD00
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.set_Length
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D9830 Offset: 0x12D8230 VA: 0x1812D9830
	|-UnsafeList<byte>.get_Capacity
	|-UnsafeList<int>.get_Capacity
	|-UnsafeList<IntPtr>.get_Capacity
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.get_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D98C0 Offset: 0x12D82C0 VA: 0x1812D98C0
	|-UnsafeList<byte>.set_Capacity
	|
	|-RVA: 0x12DDA00 Offset: 0x12DC400 VA: 0x1812DDA00
	|-UnsafeList<int>.set_Capacity
	|
	|-RVA: 0x12DD990 Offset: 0x12DC390 VA: 0x1812DD990
	|-UnsafeList<IntPtr>.set_Capacity
	|
	|-RVA: 0x12DD910 Offset: 0x12DC310 VA: 0x1812DD910
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.set_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D9880 Offset: 0x12D8280 VA: 0x1812D9880
	|-UnsafeList<byte>.get_Item
	|
	|-RVA: 0x12DD8F0 Offset: 0x12DC2F0 VA: 0x1812DD8F0
	|-UnsafeList<int>.get_Item
	|
	|-RVA: 0x12DD800 Offset: 0x12DC200 VA: 0x1812DD800
	|-UnsafeList<IntPtr>.get_Item
	|
	|-RVA: 0x12DD830 Offset: 0x12DC230 VA: 0x1812DD830
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D9930 Offset: 0x12D8330 VA: 0x1812D9930
	|-UnsafeList<byte>.set_Item
	|
	|-RVA: 0x12DDBB0 Offset: 0x12DC5B0 VA: 0x1812DDBB0
	|-UnsafeList<int>.set_Item
	|
	|-RVA: 0x12DDA70 Offset: 0x12DC470 VA: 0x1812DDA70
	|-UnsafeList<IntPtr>.set_Item
	|
	|-RVA: 0x12DDAA0 Offset: 0x12DC4A0 VA: 0x1812DDAA0
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public ref T ElementAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D9130 Offset: 0x12D7B30 VA: 0x1812D9130
	|-UnsafeList<byte>.ElementAt
	|
	|-RVA: 0x12DBDF0 Offset: 0x12DA7F0 VA: 0x1812DBDF0
	|-UnsafeList<int>.ElementAt
	|
	|-RVA: 0x12DBE20 Offset: 0x12DA820 VA: 0x1812DBE20
	|-UnsafeList<IntPtr>.ElementAt
	|
	|-RVA: 0x12DBE50 Offset: 0x12DA850 VA: 0x1812DBE50
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.ElementAt
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T* ptr, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D96C0 Offset: 0x12D80C0 VA: 0x1812D96C0
	|-UnsafeList<byte>..ctor
	|
	|-RVA: 0x12DD350 Offset: 0x12DBD50 VA: 0x1812DD350
	|-UnsafeList<int>..ctor
	|
	|-RVA: 0x12DD3E0 Offset: 0x12DBDE0 VA: 0x1812DD3E0
	|-UnsafeList<IntPtr>..ctor
	|
	|-RVA: 0x12DD2C0 Offset: 0x12DBCC0 VA: 0x1812DD2C0
	|-UnsafeList<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int initialCapacity, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D9750 Offset: 0x12D8150 VA: 0x1812D9750
	|-UnsafeList<byte>..ctor
	|
	|-RVA: 0x12DD690 Offset: 0x12DC090 VA: 0x1812DD690
	|-UnsafeList<int>..ctor
	|
	|-RVA: 0x12DD5B0 Offset: 0x12DBFB0 VA: 0x1812DD5B0
	|-UnsafeList<IntPtr>..ctor
	|
	|-RVA: 0x12DD470 Offset: 0x12DBE70 VA: 0x1812DD470
	|-UnsafeList<__Il2CppFullySharedGenericStructType>..ctor
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(AllocatorManager.AllocatorHandle) })]
	// RVA: -1 Offset: -1
	internal void Initialize<U>(int initialCapacity, ref U allocator, NativeArrayOptions options = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCDF40 Offset: 0xDCC940 VA: 0x180DCDF40
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.Initialize<__Il2CppFullySharedGenericStructType>
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(AllocatorManager.AllocatorHandle) })]
	// RVA: -1 Offset: -1
	internal static UnsafeList<T> New<U>(int initialCapacity, ref U allocator, NativeArrayOptions options = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCE000 Offset: 0xDCCA00 VA: 0x180DCE000
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.New<__Il2CppFullySharedGenericStructType>
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(AllocatorManager.AllocatorHandle) })]
	// RVA: -1 Offset: -1
	internal static UnsafeList<T>* Create<U>(int initialCapacity, ref U allocator, NativeArrayOptions options = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCD870 Offset: 0xDCC270 VA: 0x180DCD870
	|-UnsafeList<byte>.Create<AllocatorManager.AllocatorHandle>
	|
	|-RVA: 0xDCD9F0 Offset: 0xDCC3F0 VA: 0x180DCD9F0
	|-UnsafeList<int>.Create<AllocatorManager.AllocatorHandle>
	|
	|-RVA: 0xDCDB70 Offset: 0xDCC570 VA: 0x180DCDB70
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.Create<__Il2CppFullySharedGenericStructType>
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(AllocatorManager.AllocatorHandle) })]
	// RVA: -1 Offset: -1
	internal static void Destroy<U>(UnsafeList<T>* listData, ref U allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCDDB0 Offset: 0xDCC7B0 VA: 0x180DCDDB0
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.Destroy<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static UnsafeList<T>* Create(int initialCapacity, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D8DB0 Offset: 0x12D77B0 VA: 0x1812D8DB0
	|-UnsafeList<byte>.Create
	|
	|-RVA: 0x12DB3F0 Offset: 0x12D9DF0 VA: 0x1812DB3F0
	|-UnsafeList<int>.Create
	|
	|-RVA: 0x12DB4F0 Offset: 0x12D9EF0 VA: 0x1812DB4F0
	|-UnsafeList<IntPtr>.Create
	|
	|-RVA: 0x12DB2D0 Offset: 0x12D9CD0 VA: 0x1812DB2D0
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.Create
	*/

	// RVA: -1 Offset: -1
	public static void Destroy(UnsafeList<T>* listData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D8EB0 Offset: 0x12D78B0 VA: 0x1812D8EB0
	|-UnsafeList<byte>.Destroy
	|
	|-RVA: 0x12DB7C0 Offset: 0x12DA1C0 VA: 0x1812DB7C0
	|-UnsafeList<int>.Destroy
	|
	|-RVA: 0x12DB700 Offset: 0x12DA100 VA: 0x1812DB700
	|-UnsafeList<IntPtr>.Destroy
	|
	|-RVA: 0x12DB5F0 Offset: 0x12D9FF0 VA: 0x1812DB5F0
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.Destroy
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D9840 Offset: 0x12D8240 VA: 0x1812D9840
	|-UnsafeList<byte>.get_IsEmpty
	|-UnsafeList<int>.get_IsEmpty
	|-UnsafeList<IntPtr>.get_IsEmpty
	|
	|-RVA: 0x12DD770 Offset: 0x12DC170 VA: 0x1812DD770
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10676B0 Offset: 0x10660B0 VA: 0x1810676B0
	|-UnsafeList<byte>.get_IsCreated
	|-UnsafeList<int>.get_IsCreated
	|-UnsafeList<IntPtr>.get_IsCreated
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.get_IsCreated
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(AllocatorManager.AllocatorHandle) })]
	// RVA: -1 Offset: -1
	internal void Dispose<U>(ref U allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCDEA0 Offset: 0xDCC8A0 VA: 0x180DCDEA0
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.Dispose<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D9070 Offset: 0x12D7A70 VA: 0x1812D9070
	|-UnsafeList<byte>.Dispose
	|
	|-RVA: 0x12DB980 Offset: 0x12DA380 VA: 0x1812DB980
	|-UnsafeList<int>.Dispose
	|
	|-RVA: 0x12DBC30 Offset: 0x12DA630 VA: 0x1812DBC30
	|-UnsafeList<IntPtr>.Dispose
	|
	|-RVA: 0x12DBA40 Offset: 0x12DA440 VA: 0x1812DBA40
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1 Slot: 4
	public JobHandle Dispose(JobHandle inputDeps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D8F70 Offset: 0x12D7970 VA: 0x1812D8F70
	|-UnsafeList<byte>.Dispose
	|
	|-RVA: 0x12DBB30 Offset: 0x12DA530 VA: 0x1812DBB30
	|-UnsafeList<int>.Dispose
	|
	|-RVA: 0x12DB880 Offset: 0x12DA280 VA: 0x1812DB880
	|-UnsafeList<IntPtr>.Dispose
	|
	|-RVA: 0x12DBCF0 Offset: 0x12DA6F0 VA: 0x1812DBCF0
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D8CE0 Offset: 0x12D76E0 VA: 0x1812D8CE0
	|-UnsafeList<byte>.Clear
	|-UnsafeList<int>.Clear
	|-UnsafeList<IntPtr>.Clear
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Resize(int length, NativeArrayOptions options = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D94F0 Offset: 0x12D7EF0 VA: 0x1812D94F0
	|-UnsafeList<byte>.Resize
	|
	|-RVA: 0x12DCEA0 Offset: 0x12DB8A0 VA: 0x1812DCEA0
	|-UnsafeList<int>.Resize
	|
	|-RVA: 0x12DCDC0 Offset: 0x12DB7C0 VA: 0x1812DCDC0
	|-UnsafeList<IntPtr>.Resize
	|
	|-RVA: 0x12DCC80 Offset: 0x12DB680 VA: 0x1812DCC80
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.Resize
	*/

	// RVA: -1 Offset: -1
	private void Realloc<U>(ref U allocator, int newCapacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCE210 Offset: 0xDCCC10 VA: 0x180DCE210
	|-UnsafeList<byte>.Realloc<AllocatorManager.AllocatorHandle>
	|
	|-RVA: 0xDCE390 Offset: 0xDCCD90 VA: 0x180DCE390
	|-UnsafeList<int>.Realloc<AllocatorManager.AllocatorHandle>
	|
	|-RVA: 0xDCE080 Offset: 0xDCCA80 VA: 0x180DCE080
	|-UnsafeList<IntPtr>.Realloc<AllocatorManager.AllocatorHandle>
	|
	|-RVA: 0xDCE520 Offset: 0xDCCF20 VA: 0x180DCE520
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.Realloc<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	private void Realloc(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D9280 Offset: 0x12D7C80 VA: 0x1812D9280
	|-UnsafeList<byte>.Realloc
	|
	|-RVA: 0x12DC370 Offset: 0x12DAD70 VA: 0x1812DC370
	|-UnsafeList<int>.Realloc
	|
	|-RVA: 0x12DC320 Offset: 0x12DAD20 VA: 0x1812DC320
	|-UnsafeList<IntPtr>.Realloc
	|
	|-RVA: 0x12DC290 Offset: 0x12DAC90 VA: 0x1812DC290
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.Realloc
	*/

	// RVA: -1 Offset: -1
	private void SetCapacity<U>(ref U allocator, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCE800 Offset: 0xDCD200 VA: 0x180DCE800
	|-UnsafeList<byte>.SetCapacity<AllocatorManager.AllocatorHandle>
	|
	|-RVA: 0xDCE8C0 Offset: 0xDCD2C0 VA: 0x180DCE8C0
	|-UnsafeList<int>.SetCapacity<AllocatorManager.AllocatorHandle>
	|
	|-RVA: 0xDCE740 Offset: 0xDCD140 VA: 0x180DCE740
	|-UnsafeList<IntPtr>.SetCapacity<AllocatorManager.AllocatorHandle>
	|
	|-RVA: 0xDCE980 Offset: 0xDCD380 VA: 0x180DCE980
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.SetCapacity<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void SetCapacity(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D95D0 Offset: 0x12D7FD0 VA: 0x1812D95D0
	|-UnsafeList<byte>.SetCapacity
	|
	|-RVA: 0x12DD060 Offset: 0x12DBA60 VA: 0x1812DD060
	|-UnsafeList<int>.SetCapacity
	|
	|-RVA: 0x12DD010 Offset: 0x12DBA10 VA: 0x1812DD010
	|-UnsafeList<IntPtr>.SetCapacity
	|
	|-RVA: 0x12DCF80 Offset: 0x12DB980 VA: 0x1812DCF80
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.SetCapacity
	*/

	// RVA: -1 Offset: -1
	public void TrimExcess() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D9620 Offset: 0x12D8020 VA: 0x1812D9620
	|-UnsafeList<byte>.TrimExcess
	|
	|-RVA: 0x12DD0B0 Offset: 0x12DBAB0 VA: 0x1812DD0B0
	|-UnsafeList<int>.TrimExcess
	|
	|-RVA: 0x12DD150 Offset: 0x12DBB50 VA: 0x1812DD150
	|-UnsafeList<IntPtr>.TrimExcess
	|
	|-RVA: 0x12DD1F0 Offset: 0x12DBBF0 VA: 0x1812DD1F0
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.TrimExcess
	*/

	// RVA: -1 Offset: -1
	public void AddNoResize(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D82A0 Offset: 0x12D6CA0 VA: 0x1812D82A0
	|-UnsafeList<byte>.AddNoResize
	|
	|-RVA: 0x12D9B10 Offset: 0x12D8510 VA: 0x1812D9B10
	|-UnsafeList<int>.AddNoResize
	|
	|-RVA: 0x12D9B60 Offset: 0x12D8560 VA: 0x1812D9B60
	|-UnsafeList<IntPtr>.AddNoResize
	|
	|-RVA: 0x12D9BB0 Offset: 0x12D85B0 VA: 0x1812D9BB0
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.AddNoResize
	*/

	// RVA: -1 Offset: -1
	public void AddRangeNoResize(void* ptr, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D82F0 Offset: 0x12D6CF0 VA: 0x1812D82F0
	|-UnsafeList<byte>.AddRangeNoResize
	|
	|-RVA: 0x12D9E30 Offset: 0x12D8830 VA: 0x1812D9E30
	|-UnsafeList<int>.AddRangeNoResize
	|
	|-RVA: 0x12D9F20 Offset: 0x12D8920 VA: 0x1812D9F20
	|-UnsafeList<IntPtr>.AddRangeNoResize
	|
	|-RVA: 0x12D9D40 Offset: 0x12D8740 VA: 0x1812D9D40
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.AddRangeNoResize
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public void AddRangeNoResize(UnsafeList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D8320 Offset: 0x12D6D20 VA: 0x1812D8320
	|-UnsafeList<byte>.AddRangeNoResize
	|
	|-RVA: 0x12D9CC0 Offset: 0x12D86C0 VA: 0x1812D9CC0
	|-UnsafeList<int>.AddRangeNoResize
	|
	|-RVA: 0x12D9DB0 Offset: 0x12D87B0 VA: 0x1812D9DB0
	|-UnsafeList<IntPtr>.AddRangeNoResize
	|
	|-RVA: 0x12D9E70 Offset: 0x12D8870 VA: 0x1812D9E70
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.AddRangeNoResize
	*/

	// RVA: -1 Offset: -1
	public void Add(in T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D84F0 Offset: 0x12D6EF0 VA: 0x1812D84F0
	|-UnsafeList<byte>.Add
	|
	|-RVA: 0x12DA610 Offset: 0x12D9010 VA: 0x1812DA610
	|-UnsafeList<int>.Add
	|
	|-RVA: 0x12DA6D0 Offset: 0x12D90D0 VA: 0x1812DA6D0
	|-UnsafeList<IntPtr>.Add
	|
	|-RVA: 0x12DA450 Offset: 0x12D8E50 VA: 0x1812DA450
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.Add
	*/

	// RVA: -1 Offset: -1
	public void AddRange(void* ptr, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D8420 Offset: 0x12D6E20 VA: 0x1812D8420
	|-UnsafeList<byte>.AddRange
	|
	|-RVA: 0x12DA220 Offset: 0x12D8C20 VA: 0x1812DA220
	|-UnsafeList<int>.AddRange
	|
	|-RVA: 0x12DA2F0 Offset: 0x12D8CF0 VA: 0x1812DA2F0
	|-UnsafeList<IntPtr>.AddRange
	|
	|-RVA: 0x12DA0E0 Offset: 0x12D8AE0 VA: 0x1812DA0E0
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.AddRange
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public void AddRange(UnsafeList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D8390 Offset: 0x12D6D90 VA: 0x1812D8390
	|-UnsafeList<byte>.AddRange
	|
	|-RVA: 0x12D9F60 Offset: 0x12D8960 VA: 0x1812D9F60
	|-UnsafeList<int>.AddRange
	|
	|-RVA: 0x12DA3C0 Offset: 0x12D8DC0 VA: 0x1812DA3C0
	|-UnsafeList<IntPtr>.AddRange
	|
	|-RVA: 0x12D9FF0 Offset: 0x12D89F0 VA: 0x1812D9FF0
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.AddRange
	*/

	// RVA: -1 Offset: -1
	public void InsertRangeWithBeginEnd(int begin, int end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D91B0 Offset: 0x12D7BB0 VA: 0x1812D91B0
	|-UnsafeList<byte>.InsertRangeWithBeginEnd
	|
	|-RVA: 0x12DC040 Offset: 0x12DAA40 VA: 0x1812DC040
	|-UnsafeList<int>.InsertRangeWithBeginEnd
	|
	|-RVA: 0x12DBF50 Offset: 0x12DA950 VA: 0x1812DBF50
	|-UnsafeList<IntPtr>.InsertRangeWithBeginEnd
	|
	|-RVA: 0x12DC130 Offset: 0x12DAB30 VA: 0x1812DC130
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.InsertRangeWithBeginEnd
	*/

	// RVA: -1 Offset: -1
	public void RemoveAtSwapBack(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D92D0 Offset: 0x12D7CD0 VA: 0x1812D92D0
	|-UnsafeList<byte>.RemoveAtSwapBack
	|
	|-RVA: 0x12DC3C0 Offset: 0x12DADC0 VA: 0x1812DC3C0
	|-UnsafeList<int>.RemoveAtSwapBack
	|
	|-RVA: 0x12DC430 Offset: 0x12DAE30 VA: 0x1812DC430
	|-UnsafeList<IntPtr>.RemoveAtSwapBack
	|
	|-RVA: 0x12DC4A0 Offset: 0x12DAEA0 VA: 0x1812DC4A0
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.RemoveAtSwapBack
	*/

	// RVA: -1 Offset: -1
	public void RemoveRangeSwapBack(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D93F0 Offset: 0x12D7DF0 VA: 0x1812D93F0
	|-UnsafeList<byte>.RemoveRangeSwapBack
	|
	|-RVA: 0x12DC920 Offset: 0x12DB320 VA: 0x1812DC920
	|-UnsafeList<int>.RemoveRangeSwapBack
	|
	|-RVA: 0x12DC8B0 Offset: 0x12DB2B0 VA: 0x1812DC8B0
	|-UnsafeList<IntPtr>.RemoveRangeSwapBack
	|
	|-RVA: 0x12DC820 Offset: 0x12DB220 VA: 0x1812DC820
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.RemoveRangeSwapBack
	*/

	[Obsolete("RemoveRangeSwapBackWithBeginEnd(begin, end) is deprecated, use RemoveRangeSwapBack(index, count) instead. (RemovedAfter 2021-06-02)", False)]
	// RVA: -1 Offset: -1
	public void RemoveRangeSwapBackWithBeginEnd(int begin, int end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D9390 Offset: 0x12D7D90 VA: 0x1812D9390
	|-UnsafeList<byte>.RemoveRangeSwapBackWithBeginEnd
	|
	|-RVA: 0x12DC7B0 Offset: 0x12DB1B0 VA: 0x1812DC7B0
	|-UnsafeList<int>.RemoveRangeSwapBackWithBeginEnd
	|
	|-RVA: 0x12DC740 Offset: 0x12DB140 VA: 0x1812DC740
	|-UnsafeList<IntPtr>.RemoveRangeSwapBackWithBeginEnd
	|
	|-RVA: 0x12DC6A0 Offset: 0x12DB0A0 VA: 0x1812DC6A0
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.RemoveRangeSwapBackWithBeginEnd
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D9330 Offset: 0x12D7D30 VA: 0x1812D9330
	|-UnsafeList<byte>.RemoveAt
	|
	|-RVA: 0x12DC630 Offset: 0x12DB030 VA: 0x1812DC630
	|-UnsafeList<int>.RemoveAt
	|
	|-RVA: 0x12DC5C0 Offset: 0x12DAFC0 VA: 0x1812DC5C0
	|-UnsafeList<IntPtr>.RemoveAt
	|
	|-RVA: 0x12DC530 Offset: 0x12DAF30 VA: 0x1812DC530
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public void RemoveRange(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D94A0 Offset: 0x12D7EA0 VA: 0x1812D94A0
	|-UnsafeList<byte>.RemoveRange
	|
	|-RVA: 0x12DCC10 Offset: 0x12DB610 VA: 0x1812DCC10
	|-UnsafeList<int>.RemoveRange
	|
	|-RVA: 0x12DCB10 Offset: 0x12DB510 VA: 0x1812DCB10
	|-UnsafeList<IntPtr>.RemoveRange
	|
	|-RVA: 0x12DCB80 Offset: 0x12DB580 VA: 0x1812DCB80
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.RemoveRange
	*/

	[Obsolete("RemoveRangeWithBeginEnd(begin, end) is deprecated, use RemoveRange(index, count) instead. (RemovedAfter 2021-06-02)", False)]
	// RVA: -1 Offset: -1
	public void RemoveRangeWithBeginEnd(int begin, int end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D9450 Offset: 0x12D7E50 VA: 0x1812D9450
	|-UnsafeList<byte>.RemoveRangeWithBeginEnd
	|
	|-RVA: 0x12DCAA0 Offset: 0x12DB4A0 VA: 0x1812DCAA0
	|-UnsafeList<int>.RemoveRangeWithBeginEnd
	|
	|-RVA: 0x12DCA30 Offset: 0x12DB430 VA: 0x1812DCA30
	|-UnsafeList<IntPtr>.RemoveRangeWithBeginEnd
	|
	|-RVA: 0x12DC990 Offset: 0x12DB390 VA: 0x1812DC990
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.RemoveRangeWithBeginEnd
	*/

	// RVA: -1 Offset: -1
	public UnsafeList.ParallelReader<T> AsParallelReader() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D85B0 Offset: 0x12D6FB0 VA: 0x1812D85B0
	|-UnsafeList<byte>.AsParallelReader
	|-UnsafeList<int>.AsParallelReader
	|-UnsafeList<IntPtr>.AsParallelReader
	|
	|-RVA: 0x12DA790 Offset: 0x12D9190 VA: 0x1812DA790
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.AsParallelReader
	*/

	// RVA: -1 Offset: -1
	public UnsafeList.ParallelWriter<T> AsParallelWriter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D8640 Offset: 0x12D7040 VA: 0x1812D8640
	|-UnsafeList<byte>.AsParallelWriter
	|-UnsafeList<int>.AsParallelWriter
	|-UnsafeList<IntPtr>.AsParallelWriter
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.AsParallelWriter
	*/

	// RVA: -1 Offset: -1
	public void CopyFrom(UnsafeList<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D8CF0 Offset: 0x12D76F0 VA: 0x1812D8CF0
	|-UnsafeList<byte>.CopyFrom
	|
	|-RVA: 0x12DB130 Offset: 0x12D9B30 VA: 0x1812DB130
	|-UnsafeList<int>.CopyFrom
	|
	|-RVA: 0x12DB200 Offset: 0x12D9C00 VA: 0x1812DB200
	|-UnsafeList<IntPtr>.CopyFrom
	|
	|-RVA: 0x12DAFA0 Offset: 0x12D99A0 VA: 0x1812DAFA0
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.CopyFrom
	*/

	// RVA: -1 Offset: -1
	public UnsafeList.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D9150 Offset: 0x12D7B50 VA: 0x1812D9150
	|-UnsafeList<byte>.GetEnumerator
	|-UnsafeList<int>.GetEnumerator
	|-UnsafeList<IntPtr>.GetEnumerator
	|
	|-RVA: 0x12DBEB0 Offset: 0x12DA8B0 VA: 0x1812DBEB0
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-UnsafeList<byte>.System.Collections.IEnumerable.GetEnumerator
	|-UnsafeList<int>.System.Collections.IEnumerable.GetEnumerator
	|-UnsafeList<IntPtr>.System.Collections.IEnumerable.GetEnumerator
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-UnsafeList<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-UnsafeList<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-UnsafeList<IntPtr>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	internal static void CheckNull(void* listData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D8C80 Offset: 0x12D7680 VA: 0x1812D8C80
	|-UnsafeList<byte>.CheckNull
	|-UnsafeList<int>.CheckNull
	|-UnsafeList<IntPtr>.CheckNull
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.CheckNull
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private void CheckIndexCount(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D88D0 Offset: 0x12D72D0 VA: 0x1812D88D0
	|-UnsafeList<byte>.CheckIndexCount
	|-UnsafeList<int>.CheckIndexCount
	|-UnsafeList<IntPtr>.CheckIndexCount
	|
	|-RVA: 0x12DAB30 Offset: 0x12D9530 VA: 0x1812DAB30
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.CheckIndexCount
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private void CheckBeginEnd(int begin, int end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D8670 Offset: 0x12D7070 VA: 0x1812D8670
	|-UnsafeList<byte>.CheckBeginEnd
	|-UnsafeList<int>.CheckBeginEnd
	|-UnsafeList<IntPtr>.CheckBeginEnd
	|
	|-RVA: 0x12DA860 Offset: 0x12D9260 VA: 0x1812DA860
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.CheckBeginEnd
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private void CheckNoResizeHasEnoughCapacity(int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-UnsafeList<byte>.CheckNoResizeHasEnoughCapacity
	|-UnsafeList<int>.CheckNoResizeHasEnoughCapacity
	|-UnsafeList<IntPtr>.CheckNoResizeHasEnoughCapacity
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.CheckNoResizeHasEnoughCapacity
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private void CheckNoResizeHasEnoughCapacity(int length, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D8B20 Offset: 0x12D7520 VA: 0x1812D8B20
	|-UnsafeList<byte>.CheckNoResizeHasEnoughCapacity
	|-UnsafeList<int>.CheckNoResizeHasEnoughCapacity
	|-UnsafeList<IntPtr>.CheckNoResizeHasEnoughCapacity
	|
	|-RVA: 0x12DADE0 Offset: 0x12D97E0 VA: 0x1812DADE0
	|-UnsafeList<__Il2CppFullySharedGenericStructType>.CheckNoResizeHasEnoughCapacity
	*/
}
