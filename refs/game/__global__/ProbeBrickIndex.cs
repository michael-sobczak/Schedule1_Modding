internal class ProbeBrickIndex // TypeDefIndex: 13717
{
	// Fields
	internal const int kMaxSubdivisionLevels = 7;
	internal const int kIndexChunkSize = 243;
	private BitArray m_IndexChunks; // 0x10
	private int m_IndexInChunks; // 0x18
	private int m_NextFreeChunk; // 0x1C
	private int m_AvailableChunkCount; // 0x20
	private ComputeBuffer m_PhysicalIndexBuffer; // 0x28
	private int[] m_PhysicalIndexBufferData; // 0x30
	[CompilerGenerated]
	private int <estimatedVMemCost>k__BackingField; // 0x38
	private Vector3Int m_CenterRS; // 0x3C
	private Dictionary<Vector3Int, List<ProbeBrickIndex.VoxelMeta>> m_VoxelToBricks; // 0x48
	private Dictionary<ProbeReferenceVolume.Cell, ProbeBrickIndex.BrickMeta> m_BricksToVoxels; // 0x50
	private ObjectPool<ProbeBrickIndex.BrickMeta> m_BrickMetaPool; // 0x58
	private ObjectPool<List<ProbeBrickIndex.VoxelMeta>> m_VoxelMetaListPool; // 0x60
	private ObjectPool<ProbeBrickIndex.VoxelMeta> m_VoxelMetaPool; // 0x68
	private bool m_NeedUpdateIndexComputeBuffer; // 0x70
	private int m_UpdateMinIndex; // 0x74
	private int m_UpdateMaxIndex; // 0x78
	private static ProbeReferenceVolume.Cell g_Cell; // 0x0

	// Properties
	internal int estimatedVMemCost { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	internal int get_estimatedVMemCost() { }

	[CompilerGenerated]
	// RVA: 0x4E2930 Offset: 0x4E1330 VA: 0x1804E2930
	private void set_estimatedVMemCost(int value) { }

	// RVA: 0x2A020E0 Offset: 0x2A00AE0 VA: 0x182A020E0
	private int GetVoxelSubdivLevel() { }

	// RVA: 0x2A02A10 Offset: 0x2A01410 VA: 0x182A02A10
	private int SizeOfPhysicalIndexFromBudget(ProbeVolumeTextureMemoryBudget memoryBudget) { }

	// RVA: 0x2A03590 Offset: 0x2A01F90 VA: 0x182A03590
	internal void .ctor(ProbeVolumeTextureMemoryBudget memoryBudget) { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public int GetRemainingChunkCount() { }

	// RVA: 0x2A03530 Offset: 0x2A01F30 VA: 0x182A03530
	internal void UploadIndexData() { }

	// RVA: 0x2A01990 Offset: 0x2A00390 VA: 0x182A01990
	internal void Clear() { }

	// RVA: 0x2A02180 Offset: 0x2A00B80 VA: 0x182A02180
	private void MapBrickToVoxels(ProbeBrickIndex.Brick brick, HashSet<Vector3Int> voxels) { }

	// RVA: 0x2A01880 Offset: 0x2A00280 VA: 0x182A01880
	private void ClearVoxel(Vector3Int pos, ProbeBrickIndex.CellIndexUpdateInfo cellInfo) { }

	// RVA: 0x2A02060 Offset: 0x2A00A60 VA: 0x182A02060
	internal void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr) { }

	// RVA: 0x2A01810 Offset: 0x2A00210 VA: 0x182A01810
	internal void Cleanup() { }

	// RVA: 0x2A02480 Offset: 0x2A00E80 VA: 0x182A02480
	private int MergeIndex(int index, int size) { }

	// RVA: 0x2A01650 Offset: 0x2A00050 VA: 0x182A01650
	internal bool AssignIndexChunksToCell(int bricksCount, ref ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo, bool ignoreErrorLog) { }

	// RVA: 0x2A00E70 Offset: 0x29FF870 VA: 0x182A00E70
	public void AddBricks(ProbeReferenceVolume.Cell cell, NativeArray<ProbeBrickIndex.Brick> bricks, List<ProbeBrickPool.BrickChunkAlloc> allocations, int allocationSize, int poolWidth, int poolHeight, ProbeBrickIndex.CellIndexUpdateInfo cellInfo) { }

	// RVA: 0x2A024A0 Offset: 0x2A00EA0 VA: 0x182A024A0
	public void RemoveBricks(ProbeReferenceVolume.CellInfo cellInfo) { }

	// RVA: 0x2A02A40 Offset: 0x2A01440 VA: 0x182A02A40
	private void UpdateIndexForVoxel(Vector3Int voxel, ProbeBrickIndex.CellIndexUpdateInfo cellInfo) { }

	// RVA: 0x2A030A0 Offset: 0x2A01AA0 VA: 0x182A030A0
	private void UpdatePhysicalIndex(Vector3Int brickMin, Vector3Int brickMax, int value, ProbeBrickIndex.CellIndexUpdateInfo cellInfo) { }

	// RVA: 0x2A01E50 Offset: 0x2A00850 VA: 0x182A01E50
	private void ClipToIndexSpace(Vector3Int pos, int subdiv, out Vector3Int outMinpos, out Vector3Int outMaxpos, ProbeBrickIndex.CellIndexUpdateInfo cellInfo) { }

	// RVA: 0x2A02CA0 Offset: 0x2A016A0 VA: 0x182A02CA0
	private void UpdateIndexForVoxel(Vector3Int voxel, List<ProbeBrickIndex.ReservedBrick> bricks, List<ushort> indices, ProbeBrickIndex.CellIndexUpdateInfo cellInfo) { }
}
