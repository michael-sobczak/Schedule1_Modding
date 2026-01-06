internal struct TileRangeExpansionJob : IJobFor // TypeDefIndex: 9029
{
	// Fields
	[ReadOnly]
	public NativeArray<InclusiveRange> tileRanges; // 0x0
	[NativeDisableParallelForRestriction]
	public NativeArray<uint> tileMasks; // 0x10
	public int rangesPerItem; // 0x20
	public int itemsPerTile; // 0x24
	public int wordsPerTile; // 0x28
	public int2 tileResolution; // 0x2C

	// Methods

	// RVA: 0x2B2D5B0 Offset: 0x2B2BFB0 VA: 0x182B2D5B0 Slot: 4
	public void Execute(int jobIndex) { }
}
