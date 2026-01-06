internal class ProbeVolumeAsset : ScriptableObject // TypeDefIndex: 13752
{
	// Fields
	[SerializeField]
	protected internal int m_Version; // 0x18
	[SerializeField]
	internal ProbeReferenceVolume.Cell[] cells; // 0x20
	[SerializeField]
	internal ProbeVolumeAsset.CellCounts[] cellCounts; // 0x28
	[SerializeField]
	internal ProbeVolumeAsset.CellCounts totalCellCounts; // 0x30
	[SerializeField]
	internal Vector3Int maxCellPosition; // 0x40
	[SerializeField]
	internal Vector3Int minCellPosition; // 0x4C
	[SerializeField]
	internal Bounds globalBounds; // 0x58
	[SerializeField]
	internal ProbeVolumeSHBands bands; // 0x70
	[SerializeField]
	internal int chunkSizeInBricks; // 0x74
	[SerializeField]
	private string m_AssetFullPath; // 0x78
	[SerializeField]
	internal int cellSizeInBricks; // 0x80
	[SerializeField]
	internal int simplificationLevels; // 0x84
	[SerializeField]
	internal float minDistanceBetweenProbes; // 0x88

	// Properties
	public int Version { get; }
	internal int maxSubdivision { get; }
	internal float minBrickSize { get; }

	// Methods

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public int get_Version() { }

	// RVA: 0x2A22020 Offset: 0x2A20A20 VA: 0x182A22020
	internal int get_maxSubdivision() { }

	// RVA: 0x2A22030 Offset: 0x2A20A30 VA: 0x182A22030
	internal float get_minBrickSize() { }

	// RVA: 0x2A21280 Offset: 0x2A1FC80 VA: 0x182A21280
	internal bool CompatibleWith(ProbeVolumeAsset otherAsset) { }

	// RVA: 0x2A21300 Offset: 0x2A1FD00 VA: 0x182A21300
	internal bool IsInvalid() { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public string GetSerializedFullPath() { }

	// RVA: 0x2A21250 Offset: 0x2A1FC50 VA: 0x182A21250
	private static int AlignUp16(int count) { }

	// RVA: -1 Offset: -1
	private NativeArray<T> GetSubArray<T>(NativeArray<byte> input, int count, ref int offset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF27340 Offset: 0xF25D40 VA: 0x180F27340
	|-ProbeVolumeAsset.GetSubArray<byte>
	|
	|-RVA: 0xF27530 Offset: 0xF25F30 VA: 0x180F27530
	|-ProbeVolumeAsset.GetSubArray<float>
	|
	|-RVA: 0xF27620 Offset: 0xF26020 VA: 0x180F27620
	|-ProbeVolumeAsset.GetSubArray<ushort>
	|
	|-RVA: 0xF27710 Offset: 0xF26110 VA: 0x180F27710
	|-ProbeVolumeAsset.GetSubArray<Vector3>
	|
	|-RVA: 0xF27420 Offset: 0xF25E20 VA: 0x180F27420
	|-ProbeVolumeAsset.GetSubArray<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0xF27250 Offset: 0xF25C50 VA: 0x180F27250
	|-ProbeVolumeAsset.GetSubArray<ProbeBrickIndex.Brick>
	*/

	// RVA: 0x2A219F0 Offset: 0x2A203F0 VA: 0x182A219F0
	internal bool ResolveSharedCellData(TextAsset cellSharedDataAsset, TextAsset cellSupportDataAsset) { }

	// RVA: 0x2A21320 Offset: 0x2A1FD20 VA: 0x182A21320
	internal bool ResolvePerScenarioCellData(TextAsset cellDataAsset, TextAsset cellOptionalDataAsset, int stateIndex) { }

	// RVA: 0x2A21FC0 Offset: 0x2A209C0 VA: 0x182A21FC0
	public void .ctor() { }
}
