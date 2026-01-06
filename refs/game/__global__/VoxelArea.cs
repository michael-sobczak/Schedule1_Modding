public class VoxelArea // TypeDefIndex: 13350
{
	// Fields
	public const uint MaxHeight = 65536;
	public const int MaxHeightInt = 65536;
	public const uint InvalidSpanValue = 4294967295;
	public const float AvgSpanLayerCountEstimate = 8;
	public readonly int width; // 0x10
	public readonly int depth; // 0x14
	public CompactVoxelSpan[] compactSpans; // 0x18
	public CompactVoxelCell[] compactCells; // 0x20
	public int compactSpanCount; // 0x28
	public ushort[] tmpUShortArr; // 0x30
	public int[] areaTypes; // 0x38
	public ushort[] dist; // 0x40
	public ushort maxDistance; // 0x48
	public int maxRegions; // 0x4C
	public int[] DirectionX; // 0x50
	public int[] DirectionZ; // 0x58
	public Vector3[] VectorDirection; // 0x60
	private int linkedSpanCount; // 0x68
	public LinkedVoxelSpan[] linkedSpans; // 0x70
	private int[] removedStack; // 0x78
	private int removedStackCount; // 0x80

	// Methods

	// RVA: 0xB91100 Offset: 0xB8FB00 VA: 0x180B91100
	public void Reset() { }

	// RVA: 0xB90C90 Offset: 0xB8F690 VA: 0x180B90C90
	private void ResetLinkedVoxelSpans() { }

	// RVA: 0xB91180 Offset: 0xB8FB80 VA: 0x180B91180
	public void .ctor(int width, int depth) { }

	// RVA: 0xB90A90 Offset: 0xB8F490 VA: 0x180B90A90
	public int GetSpanCountAll() { }

	// RVA: 0xB90B10 Offset: 0xB8F510 VA: 0x180B90B10
	public int GetSpanCount() { }

	// RVA: 0xB90BB0 Offset: 0xB8F5B0 VA: 0x180B90BB0
	private void PushToSpanRemovedStack(int index) { }

	// RVA: 0xB90660 Offset: 0xB8F060 VA: 0x180B90660
	public void AddLinkedSpan(int index, uint bottom, uint top, int area, int voxelWalkableClimb) { }
}
