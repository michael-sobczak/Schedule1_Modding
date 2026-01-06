public struct NativeQueue.ParallelWriter<T> // TypeDefIndex: 15880
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	internal NativeQueueData* m_Buffer; // 0x0
	[NativeDisableUnsafePtrRestriction]
	internal NativeQueueBlockPoolData* m_QueuePool; // 0x0
	[NativeSetThreadIndex]
	internal int m_ThreadIndex; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Enqueue(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F27B0 Offset: 0x10F11B0 VA: 0x1810F27B0
	|-NativeQueue.ParallelWriter<__Il2CppFullySharedGenericStructType>.Enqueue
	*/
}
