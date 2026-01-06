internal class ProbeCellIndices // TypeDefIndex: 13723
{
	// Fields
	private const int kUintPerEntry = 3;
	[CompilerGenerated]
	private int <estimatedVMemCost>k__BackingField; // 0x10
	private ComputeBuffer m_IndexOfIndicesBuffer; // 0x18
	private uint[] m_IndexOfIndicesData; // 0x20
	private Vector3Int m_CellCount; // 0x28
	private Vector3Int m_CellMin; // 0x34
	private int m_CellSizeInMinBricks; // 0x40
	private bool m_NeedUpdateComputeBuffer; // 0x44

	// Properties
	internal int estimatedVMemCost { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	internal int get_estimatedVMemCost() { }

	[CompilerGenerated]
	// RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	private void set_estimatedVMemCost(int value) { }

	// RVA: 0x5871F0 Offset: 0x585BF0 VA: 0x1805871F0
	internal Vector3Int GetCellIndexDimension() { }

	// RVA: 0x26D5E20 Offset: 0x26D4820 VA: 0x1826D5E20
	internal Vector3Int GetCellMinPosition() { }

	// RVA: 0x2A05550 Offset: 0x2A03F50 VA: 0x182A05550
	private int GetFlatIndex(Vector3Int normalizedPos) { }

	// RVA: 0x2A059B0 Offset: 0x2A043B0 VA: 0x182A059B0
	internal void .ctor(Vector3Int cellMin, Vector3Int cellMax, int cellSizeInMinBricks) { }

	// RVA: 0x2A05500 Offset: 0x2A03F00 VA: 0x182A05500
	internal int GetFlatIdxForCell(Vector3Int cellPosition) { }

	// RVA: 0x2A05650 Offset: 0x2A04050 VA: 0x182A05650
	internal void UpdateCell(int cellFlatIdx, ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo) { }

	// RVA: 0x2A055C0 Offset: 0x2A03FC0 VA: 0x182A055C0
	internal void MarkCellAsUnloaded(int cellFlatIdx) { }

	// RVA: 0x2A05620 Offset: 0x2A04020 VA: 0x182A05620
	internal void PushComputeData() { }

	// RVA: 0x2A05570 Offset: 0x2A03F70 VA: 0x182A05570
	internal void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr) { }

	// RVA: 0x2A05490 Offset: 0x2A03E90 VA: 0x182A05490
	internal void Cleanup() { }
}
