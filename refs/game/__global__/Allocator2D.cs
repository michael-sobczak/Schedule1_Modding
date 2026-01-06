internal class Allocator2D // TypeDefIndex: 7074
{
	// Fields
	private readonly Vector2Int m_MinSize; // 0x10
	private readonly Vector2Int m_MaxSize; // 0x18
	private readonly Vector2Int m_MaxAllocSize; // 0x20
	private readonly int m_RowHeightBias; // 0x28
	private readonly Allocator2D.Row[] m_Rows; // 0x30
	private readonly List<Allocator2D.Area> m_Areas; // 0x38

	// Methods

	// RVA: 0x2DF9070 Offset: 0x2DF7A70 VA: 0x182DF9070
	public void .ctor(Vector2Int minSize, Vector2Int maxSize, int rowHeightBias) { }

	// RVA: 0x2DF8B30 Offset: 0x2DF7530 VA: 0x182DF8B30
	public bool TryAllocate(int width, int height, out Allocator2D.Alloc2D alloc2D) { }

	// RVA: 0x2DF88C0 Offset: 0x2DF72C0 VA: 0x182DF88C0
	public void Free(Allocator2D.Alloc2D alloc2D) { }

	// RVA: 0x2DF8530 Offset: 0x2DF6F30 VA: 0x182DF8530
	private static void BuildAreas(List<Allocator2D.Area> areas, Vector2Int minSize, Vector2Int maxSize) { }

	// RVA: 0x2DF87E0 Offset: 0x2DF71E0 VA: 0x182DF87E0
	private static Vector2Int ComputeMaxAllocSize(List<Allocator2D.Area> areas, int rowHeightBias) { }

	// RVA: 0x2DF8770 Offset: 0x2DF7170 VA: 0x182DF8770
	private static Allocator2D.Row[] BuildRowArray(int maxRowHeight, int rowHeightBias) { }
}
