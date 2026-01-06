internal class BestFitAllocator // TypeDefIndex: 7088
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly uint <totalSize>k__BackingField; // 0x10
	private BestFitAllocator.Block m_FirstBlock; // 0x18
	private BestFitAllocator.Block m_FirstAvailableBlock; // 0x20
	private BestFitAllocator.BlockPool m_BlockPool; // 0x28
	private uint m_HighWatermark; // 0x30

	// Properties
	public uint totalSize { get; }
	public uint highWatermark { get; }

	// Methods

	// RVA: 0x2DFA480 Offset: 0x2DF8E80 VA: 0x182DFA480
	public void .ctor(uint size) { }

	[CompilerGenerated]
	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public uint get_totalSize() { }

	// RVA: 0x1E0CE80 Offset: 0x1E0B880 VA: 0x181E0CE80
	public uint get_highWatermark() { }

	// RVA: 0x2DF9C00 Offset: 0x2DF8600 VA: 0x182DF9C00
	public Alloc Allocate(uint size) { }

	// RVA: 0x2DFA0B0 Offset: 0x2DF8AB0 VA: 0x182DFA0B0
	public void Free(Alloc alloc) { }

	// RVA: 0x2DF9F70 Offset: 0x2DF8970 VA: 0x182DF9F70
	private BestFitAllocator.Block CoalesceBlockWithPrevious(BestFitAllocator.Block block) { }

	// RVA: 0x2DF9F30 Offset: 0x2DF8930 VA: 0x182DF9F30
	private BestFitAllocator.Block BestFitFindAvailableBlock(uint size) { }

	// RVA: 0x2DFA310 Offset: 0x2DF8D10 VA: 0x182DFA310
	private void SplitBlock(BestFitAllocator.Block block, uint size) { }
}
