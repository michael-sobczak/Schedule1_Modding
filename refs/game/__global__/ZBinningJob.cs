internal struct ZBinningJob : IJobFor // TypeDefIndex: 9035
{
	// Fields
	public const int batchSize = 128;
	public const int headerLength = 2;
	[NativeDisableParallelForRestriction]
	public NativeArray<uint> bins; // 0x0
	[ReadOnly]
	public NativeArray<float2> minMaxZs; // 0x10
	public float zBinScale; // 0x20
	public float zBinOffset; // 0x24
	public int binCount; // 0x28
	public int wordsPerTile; // 0x2C
	public int lightCount; // 0x30
	public int reflectionProbeCount; // 0x34
	public int batchCount; // 0x38
	public int viewCount; // 0x3C
	public bool isOrthographic; // 0x40

	// Methods

	// RVA: 0x2B3FCA0 Offset: 0x2B3E6A0 VA: 0x182B3FCA0
	private static uint EncodeHeader(uint min, uint max) { }

	// RVA: 0x2B3FC40 Offset: 0x2B3E640 VA: 0x182B3FC40
	private static ValueTuple<uint, uint> DecodeHeader(uint zBin) { }

	// RVA: 0x2B3FCB0 Offset: 0x2B3E6B0 VA: 0x182B3FCB0 Slot: 4
	public void Execute(int jobIndex) { }

	// RVA: 0x2B3FDE0 Offset: 0x2B3E7E0 VA: 0x182B3FDE0
	private void FillZBins(int binStart, int binEnd, int itemStart, int itemEnd, int headerIndex, int itemOffset, int binOffset) { }
}
