public struct UnsafeRingQueue<T> : INativeDisposable, IDisposable // TypeDefIndex: 16002
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	public T* Ptr; // 0x0
	public AllocatorManager.AllocatorHandle Allocator; // 0x0
	internal RingControl Control; // 0x0

	// Properties
	public bool IsEmpty { get; }
	public int Length { get; }
	public int Capacity { get; }
	public bool IsCreated { get; }

	// Methods

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E5EE0 Offset: 0x12E48E0 VA: 0x1812E5EE0
	|-UnsafeRingQueue<__Il2CppFullySharedGenericStructType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E5FB0 Offset: 0x12E49B0 VA: 0x1812E5FB0
	|-UnsafeRingQueue<__Il2CppFullySharedGenericStructType>.get_Length
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4975D0 Offset: 0x495FD0 VA: 0x1804975D0
	|-UnsafeRingQueue<__Il2CppFullySharedGenericStructType>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T* ptr, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E5D60 Offset: 0x12E4760 VA: 0x1812E5D60
	|-UnsafeRingQueue<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E5E00 Offset: 0x12E4800 VA: 0x1812E5E00
	|-UnsafeRingQueue<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10676B0 Offset: 0x10660B0 VA: 0x1810676B0
	|-UnsafeRingQueue<__Il2CppFullySharedGenericStructType>.get_IsCreated
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E58A0 Offset: 0x12E42A0 VA: 0x1812E58A0
	|-UnsafeRingQueue<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1 Slot: 4
	public JobHandle Dispose(JobHandle inputDeps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E57A0 Offset: 0x12E41A0 VA: 0x1812E57A0
	|-UnsafeRingQueue<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1
	public bool TryEnqueue(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E5C20 Offset: 0x12E4620 VA: 0x1812E5C20
	|-UnsafeRingQueue<__Il2CppFullySharedGenericStructType>.TryEnqueue
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private static void ThrowQueueFull() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E5AD0 Offset: 0x12E44D0 VA: 0x1812E5AD0
	|-UnsafeRingQueue<__Il2CppFullySharedGenericStructType>.ThrowQueueFull
	*/

	// RVA: -1 Offset: -1
	public void Enqueue(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E5990 Offset: 0x12E4390 VA: 0x1812E5990
	|-UnsafeRingQueue<__Il2CppFullySharedGenericStructType>.Enqueue
	*/

	// RVA: -1 Offset: -1
	public bool TryDequeue(out T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E5B20 Offset: 0x12E4520 VA: 0x1812E5B20
	|-UnsafeRingQueue<__Il2CppFullySharedGenericStructType>.TryDequeue
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private static void ThrowQueueEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E5A80 Offset: 0x12E4480 VA: 0x1812E5A80
	|-UnsafeRingQueue<__Il2CppFullySharedGenericStructType>.ThrowQueueEmpty
	*/

	// RVA: -1 Offset: -1
	public T Dequeue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E5680 Offset: 0x12E4080 VA: 0x1812E5680
	|-UnsafeRingQueue<__Il2CppFullySharedGenericStructType>.Dequeue
	*/
}
