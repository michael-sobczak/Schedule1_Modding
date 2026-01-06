internal struct NativeQueueBlockPoolData // TypeDefIndex: 15877
{
	// Fields
	internal IntPtr m_FirstBlock; // 0x0
	internal int m_NumBlocks; // 0x8
	internal int m_MaxBlocks; // 0xC
	internal const int m_BlockSize = 16384;
	internal int m_AllocLock; // 0x10

	// Methods

	// RVA: 0x2736A30 Offset: 0x2735430 VA: 0x182736A30
	public NativeQueueBlockHeader* AllocateBlock() { }

	// RVA: 0x2736BD0 Offset: 0x27355D0 VA: 0x182736BD0
	public void FreeBlock(NativeQueueBlockHeader* block) { }
}
