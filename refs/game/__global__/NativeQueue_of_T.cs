public struct NativeQueue<T> : INativeDisposable, IDisposable // TypeDefIndex: 15881
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	private NativeQueueData* m_Buffer; // 0x0
	[NativeDisableUnsafePtrRestriction]
	private NativeQueueBlockPoolData* m_QueuePool; // 0x0
	private AllocatorManager.AllocatorHandle m_AllocatorLabel; // 0x0

	// Properties
	public int Count { get; }
	internal static int PersistentMemoryBlockCount { get; set; }
	internal static int MemoryBlockSize { get; }
	public bool IsCreated { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10909F0 Offset: 0x108F3F0 VA: 0x1810909F0
	|-NativeQueue<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1090330 Offset: 0x108ED30 VA: 0x181090330
	|-NativeQueue<__Il2CppFullySharedGenericStructType>.IsEmpty
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1090AB0 Offset: 0x108F4B0 VA: 0x181090AB0
	|-NativeQueue<__Il2CppFullySharedGenericStructType>.get_Count
	*/

	// RVA: -1 Offset: -1
	internal static int get_PersistentMemoryBlockCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1090B20 Offset: 0x108F520 VA: 0x181090B20
	|-NativeQueue<__Il2CppFullySharedGenericStructType>.get_PersistentMemoryBlockCount
	*/

	// RVA: -1 Offset: -1
	internal static void set_PersistentMemoryBlockCount(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1090B70 Offset: 0x108F570 VA: 0x181090B70
	|-NativeQueue<__Il2CppFullySharedGenericStructType>.set_PersistentMemoryBlockCount
	*/

	// RVA: -1 Offset: -1
	internal static int get_MemoryBlockSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1090B10 Offset: 0x108F510 VA: 0x181090B10
	|-NativeQueue<__Il2CppFullySharedGenericStructType>.get_MemoryBlockSize
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1090400 Offset: 0x108EE00 VA: 0x181090400
	|-NativeQueue<__Il2CppFullySharedGenericStructType>.Peek
	*/

	// RVA: -1 Offset: -1
	public void Enqueue(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10901B0 Offset: 0x108EBB0 VA: 0x1810901B0
	|-NativeQueue<__Il2CppFullySharedGenericStructType>.Enqueue
	*/

	// RVA: -1 Offset: -1
	public T Dequeue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108FFA0 Offset: 0x108E9A0 VA: 0x18108FFA0
	|-NativeQueue<__Il2CppFullySharedGenericStructType>.Dequeue
	*/

	// RVA: -1 Offset: -1
	public bool TryDequeue(out T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10907B0 Offset: 0x108F1B0 VA: 0x1810907B0
	|-NativeQueue<__Il2CppFullySharedGenericStructType>.TryDequeue
	*/

	// RVA: -1 Offset: -1
	public NativeArray<T> ToArray(AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1090590 Offset: 0x108EF90 VA: 0x181090590
	|-NativeQueue<__Il2CppFullySharedGenericStructType>.ToArray
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108FF00 Offset: 0x108E900 VA: 0x18108FF00
	|-NativeQueue<__Il2CppFullySharedGenericStructType>.Clear
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10676B0 Offset: 0x10660B0 VA: 0x1810676B0
	|-NativeQueue<__Il2CppFullySharedGenericStructType>.get_IsCreated
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1090180 Offset: 0x108EB80 VA: 0x181090180
	|-NativeQueue<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1 Slot: 4
	public JobHandle Dispose(JobHandle inputDeps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10900C0 Offset: 0x108EAC0 VA: 0x1810900C0
	|-NativeQueue<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1
	public NativeQueue.ParallelWriter<T> AsParallelWriter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108FEA0 Offset: 0x108E8A0 VA: 0x18108FEA0
	|-NativeQueue<__Il2CppFullySharedGenericStructType>.AsParallelWriter
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private void CheckRead() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-NativeQueue<__Il2CppFullySharedGenericStructType>.CheckRead
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private void CheckReadNotEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108FEC0 Offset: 0x108E8C0 VA: 0x18108FEC0
	|-NativeQueue<__Il2CppFullySharedGenericStructType>.CheckReadNotEmpty
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private void CheckWrite() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-NativeQueue<__Il2CppFullySharedGenericStructType>.CheckWrite
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private static void ThrowEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1090540 Offset: 0x108EF40 VA: 0x181090540
	|-NativeQueue<__Il2CppFullySharedGenericStructType>.ThrowEmpty
	*/
}
