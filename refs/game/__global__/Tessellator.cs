internal struct Tessellator // TypeDefIndex: 9177
{
	// Fields
	private NativeArray<int2> m_Edges; // 0x0
	private NativeArray<UStar> m_Stars; // 0x10
	private NativeArray<int3> m_Cells; // 0x20
	private int m_CellCount; // 0x30
	private NativeArray<int> m_ILArray; // 0x38
	private NativeArray<int> m_IUArray; // 0x48
	private NativeArray<int> m_SPArray; // 0x58
	private int m_NumEdges; // 0x68
	private int m_NumHulls; // 0x6C
	private int m_NumPoints; // 0x70
	private int m_StarCount; // 0x74
	private NativeArray<int> m_Flags; // 0x78
	private NativeArray<int> m_Neighbors; // 0x88
	private NativeArray<int> m_Constraints; // 0x98
	private Allocator m_Allocator; // 0xA8

	// Methods

	// RVA: 0x2B7F3C0 Offset: 0x2B7DDC0 VA: 0x182B7F3C0
	private static float FindSplit(UHull hull, UEvent edge) { }

	// RVA: 0x587060 Offset: 0x585A60 VA: 0x180587060
	private void SetAllocator(Allocator allocator) { }

	// RVA: 0x2B7DCE0 Offset: 0x2B7C6E0 VA: 0x182B7DCE0
	private bool AddPoint(NativeArray<UHull> hulls, int hullCount, NativeArray<float2> points, float2 p, int idx) { }

	// RVA: 0x2B7FA20 Offset: 0x2B7E420 VA: 0x182B7FA20
	private static void InsertHull(NativeArray<UHull> Hulls, int Pos, ref int Count, UHull Value) { }

	// RVA: 0x2B7F1B0 Offset: 0x2B7DBB0 VA: 0x182B7F1B0
	private static void EraseHull(NativeArray<UHull> Hulls, int Pos, ref int Count) { }

	// RVA: 0x2B80810 Offset: 0x2B7F210 VA: 0x182B80810
	private bool SplitHulls(NativeArray<UHull> hulls, ref int hullCount, NativeArray<float2> points, UEvent evt) { }

	// RVA: 0x2B7FB70 Offset: 0x2B7E570 VA: 0x182B7FB70
	private bool MergeHulls(NativeArray<UHull> hulls, ref int hullCount, NativeArray<float2> points, UEvent evt) { }

	// RVA: 0x2B7FAE0 Offset: 0x2B7E4E0 VA: 0x182B7FAE0
	private static void InsertUniqueEdge(NativeArray<int2> edges, int2 e, ref int edgeCount) { }

	// RVA: 0x2B7FED0 Offset: 0x2B7E8D0 VA: 0x182B7FED0
	private void PrepareDelaunay(NativeArray<int2> edges, int edgeCount) { }

	// RVA: 0x2B7FE00 Offset: 0x2B7E800 VA: 0x182B7FE00
	private int OppositeOf(int a, int b) { }

	// RVA: 0x2B7F220 Offset: 0x2B7DC20 VA: 0x182B7F220
	private int FindConstraint(int a, int b) { }

	// RVA: 0x2B7E1A0 Offset: 0x2B7CBA0 VA: 0x182B7E1A0
	private void AddTriangle(int i, int j, int k) { }

	// RVA: 0x2B80630 Offset: 0x2B7F030 VA: 0x182B80630
	private void RemovePair(int r, int j, int k) { }

	// RVA: 0x2B80790 Offset: 0x2B7F190 VA: 0x182B80790
	private void RemoveTriangle(int i, int j, int k) { }

	// RVA: 0x2B7F0A0 Offset: 0x2B7DAA0 VA: 0x182B7F0A0
	private void EdgeFlip(int i, int j) { }

	// RVA: 0x2B7F670 Offset: 0x2B7E070 VA: 0x182B7F670
	private bool Flip(NativeArray<float2> points, ref NativeArray<int> stack, ref int stackCount, int a, int b, int x) { }

	// RVA: 0x2B7F880 Offset: 0x2B7E280 VA: 0x182B7F880
	private NativeArray<int3> GetCells(ref int count) { }

	// RVA: 0x2B7E370 Offset: 0x2B7CD70 VA: 0x182B7E370
	internal bool ApplyDelaunay(NativeArray<float2> points, NativeArray<int2> edges) { }

	// RVA: 0x2B7F2D0 Offset: 0x2B7DCD0 VA: 0x182B7F2D0
	private int FindNeighbor(NativeArray<int3> cells, int count, int a, int b, int c) { }

	// RVA: 0x2B7EB40 Offset: 0x2B7D540 VA: 0x182B7EB40
	private NativeArray<int3> Constrain(ref int count) { }

	// RVA: 0x2B80400 Offset: 0x2B7EE00 VA: 0x182B80400
	internal NativeArray<int3> RemoveExterior(ref int cellCount) { }

	// RVA: 0x2B80520 Offset: 0x2B7EF20 VA: 0x182B80520
	internal NativeArray<int3> RemoveInterior(int cellCount) { }

	// RVA: 0x2B80F40 Offset: 0x2B7F940 VA: 0x182B80F40
	internal bool Triangulate(NativeArray<float2> points, int pointCount, NativeArray<int2> edges, int edgeCount) { }

	// RVA: 0x2B80C20 Offset: 0x2B7F620 VA: 0x182B80C20
	internal static bool Tessellate(Allocator allocator, NativeArray<float2> pgPoints, int pgPointCount, NativeArray<int2> pgEdges, int pgEdgeCount, ref NativeArray<float2> outputVertices, ref int vertexCount, ref NativeArray<int> outputIndices, ref int indexCount) { }

	// RVA: 0x2B7E9E0 Offset: 0x2B7D3E0 VA: 0x182B7E9E0
	internal void Cleanup() { }
}
