public class TileHandler // TypeDefIndex: 13404
{
	// Fields
	public readonly NavmeshBase graph; // 0x10
	private readonly int tileXCount; // 0x18
	private readonly int tileZCount; // 0x1C
	private readonly Clipper clipper; // 0x20
	private readonly Dictionary<Int2, int> cached_Int2_int_dict; // 0x28
	private readonly TileHandler.TileType[] activeTileTypes; // 0x30
	private readonly int[] activeTileRotations; // 0x38
	private readonly int[] activeTileOffsets; // 0x40
	private readonly bool[] reloadedInBatch; // 0x48
	public readonly GridLookup<NavmeshClipper> cuts; // 0x50
	private int batchDepth; // 0x58
	private readonly Int3PolygonClipper simpleClipper; // 0x60

	// Properties
	private bool isBatching { get; }
	public bool isValid { get; }

	// Methods

	// RVA: 0xBB2BF0 Offset: 0xBB15F0 VA: 0x180BB2BF0
	private bool get_isBatching() { }

	// RVA: 0xBB2C00 Offset: 0xBB1600 VA: 0x180BB2C00
	public bool get_isValid() { }

	// RVA: 0xBB2940 Offset: 0xBB1340 VA: 0x180BB2940
	public void .ctor(NavmeshBase graph) { }

	// RVA: 0xBB10A0 Offset: 0xBAFAA0 VA: 0x180BB10A0
	public void OnRecalculatedTiles(NavmeshTile[] recalculatedTiles) { }

	// RVA: 0xBB0C90 Offset: 0xBAF690 VA: 0x180BB0C90
	public int GetActiveRotation(Int2 p) { }

	// RVA: 0xBB1F80 Offset: 0xBB0980 VA: 0x180BB1F80
	public TileHandler.TileType RegisterTileType(Mesh source, Int3 centerOffset, int width = 1, int depth = 1) { }

	// RVA: 0xBAD100 Offset: 0xBABB00 VA: 0x180BAD100
	public void CreateTileTypesFromGraph() { }

	// RVA: 0xBB25F0 Offset: 0xBB0FF0 VA: 0x180BB25F0
	private void UpdateTileType(NavmeshTile tile) { }

	// RVA: 0xBB23D0 Offset: 0xBB0DD0 VA: 0x180BB23D0
	public void StartBatchLoad() { }

	// RVA: 0xBB0AE0 Offset: 0xBAF4E0 VA: 0x180BB0AE0
	public void EndBatchLoad() { }

	// RVA: 0xBAD760 Offset: 0xBAC160 VA: 0x180BAD760
	private TileHandler.CuttingResult CutPoly(Int3[] verts, int[] tris, Int3[] extraShape, GraphTransform graphTransform, IntRect tiles, TileHandler.CutMode mode = 3, int perturbate = -1) { }

	// RVA: 0xBB1820 Offset: 0xBB0220 VA: 0x180BB1820
	private static List<TileHandler.Cut> PrepareNavmeshCutsForCutting(List<NavmeshCut> navmeshCuts, GraphTransform transform, IntRect cutSpaceBounds, int perturbate, bool anyNavmeshAdds) { }

	// RVA: 0xBB13C0 Offset: 0xBAFDC0 VA: 0x180BB13C0
	private static void PoolPolygon(Polygon polygon, Stack<Polygon> pool) { }

	// RVA: 0xBAD220 Offset: 0xBABC20 VA: 0x180BAD220
	private void CutAll(List<IntPoint> poly, List<int> intersectingCutIndices, List<TileHandler.Cut> cuts, PolyTree result) { }

	// RVA: 0xBAD380 Offset: 0xBABD80 VA: 0x180BAD380
	private void CutDual(List<IntPoint> poly, List<int> tmpIntersectingCuts, List<TileHandler.Cut> cuts, bool hasDual, List<List<IntPoint>> intermediateResult, PolyTree result) { }

	// RVA: 0xBAD690 Offset: 0xBAC090 VA: 0x180BAD690
	private void CutExtra(List<IntPoint> poly, List<IntPoint> extraClipShape, PolyTree result) { }

	// RVA: 0xBAC4B0 Offset: 0xBAAEB0 VA: 0x180BAC4B0
	private int ClipAgainstRectangle(Int3[] clipIn, Int3[] clipOut, Int2 size) { }

	// RVA: 0xBACEA0 Offset: 0xBAB8A0 VA: 0x180BACEA0
	private static void CopyMesh(Int3[] vertices, int[] triangles, List<Int3> outVertices, List<int> outTriangles) { }

	// RVA: 0xBAFBA0 Offset: 0xBAE5A0 VA: 0x180BAFBA0
	private void DelaunayRefinement(Int3[] verts, int[] tris, ref int tCount, bool delaunay, bool colinear) { }

	// RVA: 0xBAC2D0 Offset: 0xBAACD0 VA: 0x180BAC2D0
	public void ClearTile(int x, int z) { }

	// RVA: 0xBB20D0 Offset: 0xBB0AD0 VA: 0x180BB20D0
	public void ReloadInBounds(Bounds bounds) { }

	// RVA: 0xBB2220 Offset: 0xBB0C20 VA: 0x180BB2220
	public void ReloadInBounds(IntRect tiles) { }

	// RVA: 0xBB2310 Offset: 0xBB0D10 VA: 0x180BB2310
	public void ReloadTile(int x, int z) { }

	// RVA: 0xBB0CD0 Offset: 0xBAF6D0 VA: 0x180BB0CD0
	public void LoadTile(TileHandler.TileType tile, int x, int z, int rotation, int yoffset) { }

	[CompilerGenerated]
	// RVA: 0xBB25C0 Offset: 0xBB0FC0 VA: 0x180BB25C0
	private bool <StartBatchLoad>b__23_0(bool force) { }

	[CompilerGenerated]
	// RVA: 0xBB24E0 Offset: 0xBB0EE0 VA: 0x180BB24E0
	private bool <EndBatchLoad>b__24_0(IWorkItemContext ctx, bool force) { }
}
