internal class ProbeBrickPool // TypeDefIndex: 13720
{
	// Fields
	private const int kProbePoolChunkSizeInBricks = 128;
	internal const int kBrickCellCount = 3;
	internal const int kBrickProbeCountPerDim = 4;
	internal const int kBrickProbeCountTotal = 64;
	internal const int kChunkProbeCountPerDim = 512;
	[CompilerGenerated]
	private int <estimatedVMemCost>k__BackingField; // 0x10
	private const int kMaxPoolWidth = 2048;
	internal ProbeBrickPool.DataLocation m_Pool; // 0x18
	private ProbeBrickPool.BrickChunkAlloc m_NextFreeChunk; // 0x68
	private Stack<ProbeBrickPool.BrickChunkAlloc> m_FreeList; // 0x78
	private int m_AvailableChunkCount; // 0x80
	private ProbeVolumeSHBands m_SHBands; // 0x84
	private bool m_ContainsValidity; // 0x88

	// Properties
	internal int estimatedVMemCost { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	internal int get_estimatedVMemCost() { }

	[CompilerGenerated]
	// RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	private void set_estimatedVMemCost(int value) { }

	// RVA: 0x2A05300 Offset: 0x2A03D00 VA: 0x182A05300
	internal void .ctor(ProbeVolumeTextureMemoryBudget memoryBudget, ProbeVolumeSHBands shBands, bool allocateValidityData = True) { }

	// RVA: 0x4D6280 Offset: 0x4D4C80 VA: 0x1804D6280
	public int GetRemainingChunkCount() { }

	// RVA: 0x2A046A0 Offset: 0x2A030A0 VA: 0x182A046A0
	internal void EnsureTextureValidity() { }

	// RVA: 0xF728A0 Offset: 0xF712A0 VA: 0x180F728A0
	internal static int GetChunkSizeInBrickCount() { }

	// RVA: 0xF72A60 Offset: 0xF71460 VA: 0x180F72A60
	internal static int GetChunkSizeInProbeCount() { }

	// RVA: 0x4C3B30 Offset: 0x4C2530 VA: 0x1804C3B30
	internal int GetPoolWidth() { }

	// RVA: 0x54CEC0 Offset: 0x54B8C0 VA: 0x18054CEC0
	internal int GetPoolHeight() { }

	// RVA: 0x2A047C0 Offset: 0x2A031C0 VA: 0x182A047C0
	internal Vector3Int GetPoolDimensions() { }

	// RVA: 0x2A047E0 Offset: 0x2A031E0 VA: 0x182A047E0
	internal void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr) { }

	// RVA: 0x2A03D60 Offset: 0x2A02760 VA: 0x182A03D60
	internal void Clear() { }

	// RVA: 0xBA8220 Offset: 0xBA6C20 VA: 0x180BA8220
	internal static int GetChunkCount(int brickCount, int chunkSizeInBricks) { }

	// RVA: 0x2A03B20 Offset: 0x2A02520 VA: 0x182A03B20
	internal bool Allocate(int numberOfBrickChunks, List<ProbeBrickPool.BrickChunkAlloc> outAllocations, bool ignoreErrorLog) { }

	// RVA: 0x2A04520 Offset: 0x2A02F20 VA: 0x182A04520
	internal void Deallocate(List<ProbeBrickPool.BrickChunkAlloc> allocations) { }

	// RVA: 0x2A04EB0 Offset: 0x2A038B0 VA: 0x182A04EB0
	internal void Update(ProbeBrickPool.DataLocation source, List<ProbeBrickPool.BrickChunkAlloc> srcLocations, List<ProbeBrickPool.BrickChunkAlloc> dstLocations, int destStartIndex, ProbeVolumeSHBands bands) { }

	// RVA: 0x2A04CB0 Offset: 0x2A036B0 VA: 0x182A04CB0
	internal void UpdateValidity(ProbeBrickPool.DataLocation source, List<ProbeBrickPool.BrickChunkAlloc> srcLocations, List<ProbeBrickPool.BrickChunkAlloc> dstLocations, int destStartIndex) { }

	// RVA: 0x2A04C30 Offset: 0x2A03630 VA: 0x182A04C30
	internal static Vector3Int ProbeCountToDataLocSize(int numProbes) { }

	// RVA: 0x2A042D0 Offset: 0x2A02CD0 VA: 0x182A042D0
	public static Texture CreateDataTexture(int width, int height, int depth, GraphicsFormat format, string name, bool allocateRendertexture, ref int allocatedBytes) { }

	// RVA: 0x2A03DB0 Offset: 0x2A027B0 VA: 0x182A03DB0
	public static ProbeBrickPool.DataLocation CreateDataLocation(int numProbes, bool compressed, ProbeVolumeSHBands bands, string name, bool allocateRendertexture, bool allocateValidityData, out int allocatedBytes) { }

	// RVA: 0x2A04680 Offset: 0x2A03080 VA: 0x182A04680
	private void DerivePoolSizeFromBudget(ProbeVolumeTextureMemoryBudget memoryBudget, out int width, out int height, out int depth) { }

	// RVA: 0x2A03D50 Offset: 0x2A02750 VA: 0x182A03D50
	internal void Cleanup() { }
}
