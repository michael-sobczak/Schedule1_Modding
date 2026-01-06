internal class ProbeBrickBlendingPool // TypeDefIndex: 13721
{
	// Fields
	private static ComputeShader stateBlendShader; // 0x0
	private static int scenarioBlendingKernel; // 0x8
	private static readonly int _PoolDim_LerpFactor; // 0xC
	private static readonly int _ChunkList; // 0x10
	private static readonly int _State0_L0_L1Rx; // 0x14
	private static readonly int _State0_L1G_L1Ry; // 0x18
	private static readonly int _State0_L1B_L1Rz; // 0x1C
	private static readonly int _State0_L2_0; // 0x20
	private static readonly int _State0_L2_1; // 0x24
	private static readonly int _State0_L2_2; // 0x28
	private static readonly int _State0_L2_3; // 0x2C
	private static readonly int _State1_L0_L1Rx; // 0x30
	private static readonly int _State1_L1G_L1Ry; // 0x34
	private static readonly int _State1_L1B_L1Rz; // 0x38
	private static readonly int _State1_L2_0; // 0x3C
	private static readonly int _State1_L2_1; // 0x40
	private static readonly int _State1_L2_2; // 0x44
	private static readonly int _State1_L2_3; // 0x48
	private static readonly int _Out_L0_L1Rx; // 0x4C
	private static readonly int _Out_L1G_L1Ry; // 0x50
	private static readonly int _Out_L1B_L1Rz; // 0x54
	private static readonly int _Out_L2_0; // 0x58
	private static readonly int _Out_L2_1; // 0x5C
	private static readonly int _Out_L2_2; // 0x60
	private static readonly int _Out_L2_3; // 0x64
	private Vector4[] m_ChunkList; // 0x10
	private int m_MappedChunks; // 0x18
	private ProbeBrickPool m_State0; // 0x20
	private ProbeBrickPool m_State1; // 0x28
	private ProbeVolumeTextureMemoryBudget m_MemoryBudget; // 0x30
	private ProbeVolumeSHBands m_ShBands; // 0x34

	// Properties
	internal static bool isSupported { get; }
	internal bool isAllocated { get; }
	internal int estimatedVMemCost { get; }

	// Methods

	// RVA: 0x2A00DF0 Offset: 0x29FF7F0 VA: 0x182A00DF0
	internal static bool get_isSupported() { }

	// RVA: 0x29FFCB0 Offset: 0x29FE6B0 VA: 0x1829FFCB0
	internal static void Initialize(in ProbeVolumeSystemParameters parameters) { }

	// RVA: 0x6208C0 Offset: 0x61F2C0 VA: 0x1806208C0
	internal bool get_isAllocated() { }

	// RVA: 0x2A00DC0 Offset: 0x29FF7C0 VA: 0x182A00DC0
	internal int get_estimatedVMemCost() { }

	// RVA: 0x29FFC90 Offset: 0x29FE690 VA: 0x1829FFC90
	internal int GetPoolWidth() { }

	// RVA: 0x29FFC70 Offset: 0x29FE670 VA: 0x1829FFC70
	internal int GetPoolHeight() { }

	// RVA: 0x29FFC50 Offset: 0x29FE650 VA: 0x1829FFC50
	internal int GetPoolDepth() { }

	// RVA: 0x2A00D80 Offset: 0x29FF780 VA: 0x182A00D80
	internal void .ctor(ProbeVolumeBlendingTextureMemoryBudget memoryBudget, ProbeVolumeSHBands shBands) { }

	// RVA: 0x29FF6A0 Offset: 0x29FE0A0 VA: 0x1829FF6A0
	internal void AllocateResourcesIfNeeded() { }

	// RVA: 0x2A008D0 Offset: 0x29FF2D0 VA: 0x182A008D0
	internal void Update(ProbeBrickPool.DataLocation source, List<ProbeBrickPool.BrickChunkAlloc> srcLocations, List<ProbeBrickPool.BrickChunkAlloc> dstLocations, int destStartIndex, ProbeVolumeSHBands bands, int state) { }

	// RVA: 0xBA8220 Offset: 0xBA6C20 VA: 0x180BA8220
	private static int DivRoundUp(int x, int y) { }

	// RVA: 0x29FFDE0 Offset: 0x29FE7E0 VA: 0x1829FFDE0
	internal void PerformBlending(CommandBuffer cmd, float factor, ProbeBrickPool dstPool) { }

	// RVA: 0x29FF990 Offset: 0x29FE390 VA: 0x1829FF990
	internal void BlendChunks(ProbeReferenceVolume.BlendingCellInfo blendingCell, ProbeBrickPool dstPool) { }

	// RVA: 0x29FFB50 Offset: 0x29FE550 VA: 0x1829FFB50
	internal void Clear() { }

	// RVA: 0x29FF7F0 Offset: 0x29FE1F0 VA: 0x1829FF7F0
	internal bool Allocate(int numberOfBrickChunks, List<ProbeBrickPool.BrickChunkAlloc> outAllocations) { }

	// RVA: 0x29FFBB0 Offset: 0x29FE5B0 VA: 0x1829FFBB0
	internal void Deallocate(List<ProbeBrickPool.BrickChunkAlloc> allocations) { }

	// RVA: 0x29FFC10 Offset: 0x29FE610 VA: 0x1829FFC10
	internal void EnsureTextureValidity() { }

	// RVA: 0x29FFB00 Offset: 0x29FE500 VA: 0x1829FFB00
	internal void Cleanup() { }

	// RVA: 0x2A00960 Offset: 0x29FF360 VA: 0x182A00960
	private static void .cctor() { }
}
