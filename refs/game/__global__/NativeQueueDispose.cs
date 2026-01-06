internal struct NativeQueueDispose // TypeDefIndex: 15882
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	internal NativeQueueData* m_Buffer; // 0x0
	[NativeDisableUnsafePtrRestriction]
	internal NativeQueueBlockPoolData* m_QueuePool; // 0x8
	internal AllocatorManager.AllocatorHandle m_AllocatorLabel; // 0x10

	// Methods

	// RVA: 0x27373C0 Offset: 0x2735DC0 VA: 0x1827373C0
	public void Dispose() { }
}
