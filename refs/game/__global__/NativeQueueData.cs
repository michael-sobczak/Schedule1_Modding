internal struct NativeQueueData // TypeDefIndex: 15879
{
	// Fields
	public IntPtr m_FirstBlock; // 0x0
	public IntPtr m_LastBlock; // 0x8
	public int m_MaxItems; // 0x10
	public int m_CurrentRead; // 0x14
	public byte* m_CurrentWriteBlockTLS; // 0x18

	// Methods

	// RVA: 0x2737390 Offset: 0x2735D90 VA: 0x182737390
	internal NativeQueueBlockHeader* GetCurrentWriteBlockTLS(int threadIndex) { }

	// RVA: 0x27373A0 Offset: 0x2735DA0 VA: 0x1827373A0
	internal void SetCurrentWriteBlockTLS(int threadIndex, NativeQueueBlockHeader* currentWriteBlock) { }

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public static NativeQueueBlockHeader* AllocateWriteBlockMT<T>(NativeQueueData* data, NativeQueueBlockPoolData* pool, int threadIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0A270 Offset: 0xF08C70 VA: 0x180F0A270
	|-NativeQueueData.AllocateWriteBlockMT<__Il2CppFullySharedGenericStructType>
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public static void AllocateQueue<T>(AllocatorManager.AllocatorHandle label, out NativeQueueData* outBuf) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0A170 Offset: 0xF08B70 VA: 0x180F0A170
	|-NativeQueueData.AllocateQueue<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2737210 Offset: 0x2735C10 VA: 0x182737210
	public static void DeallocateQueue(NativeQueueData* data, NativeQueueBlockPoolData* pool, AllocatorManager.AllocatorHandle allocation) { }
}
