public class Voxelize // TypeDefIndex: 13360
{
	// Fields
	public List<RasterizationMesh> inputMeshes; // 0x10
	public readonly int voxelWalkableClimb; // 0x18
	public readonly uint voxelWalkableHeight; // 0x1C
	public readonly float cellSize; // 0x20
	public readonly float cellHeight; // 0x24
	public int minRegionSize; // 0x28
	public int borderSize; // 0x2C
	public float maxEdgeLength; // 0x30
	public float maxSlope; // 0x34
	public RecastGraph.RelevantGraphSurfaceMode relevantGraphSurfaceMode; // 0x38
	public Bounds forcedBounds; // 0x3C
	public VoxelArea voxelArea; // 0x58
	public VoxelContourSet countourSet; // 0x60
	private GraphTransform transform; // 0x68
	[CompilerGenerated]
	private GraphTransform <transformVoxel2Graph>k__BackingField; // 0x70
	public int width; // 0x78
	public int depth; // 0x7C
	private Vector3 voxelOffset; // 0x80
	public const uint NotConnected = 63;
	private const int MaxLayers = 65535;
	private const int MaxRegions = 500;
	private const int UnwalkableArea = 0;
	private const ushort BorderReg = 32768;
	private const int RC_BORDER_VERTEX = 65536;
	private const int RC_AREA_BORDER = 131072;
	private const int VERTEX_BUCKET_COUNT = 4096;
	public const int RC_CONTOUR_TESS_WALL_EDGES = 1;
	public const int RC_CONTOUR_TESS_AREA_EDGES = 2;
	public const int RC_CONTOUR_TESS_TILE_EDGES = 4;
	private const int ContourRegMask = 65535;
	private readonly Vector3 cellScale; // 0x8C

	// Properties
	public GraphTransform transformVoxel2Graph { get; set; }

	// Methods

	// RVA: 0xB92130 Offset: 0xB90B30 VA: 0x180B92130
	public void BuildContours(float maxError, int maxEdgeLength, VoxelContourSet cset, int buildFlags) { }

	// RVA: 0xB97F80 Offset: 0xB96980 VA: 0x180B97F80
	private void GetClosestIndices(int[] vertsa, int nvertsa, int[] vertsb, int nvertsb, ref int ia, ref int ib) { }

	// RVA: 0xB99450 Offset: 0xB97E50 VA: 0x180B99450
	private static void ReleaseContours(VoxelContourSet cset) { }

	// RVA: 0xB990F0 Offset: 0xB97AF0 VA: 0x180B990F0
	public static bool MergeContours(ref VoxelContour ca, ref VoxelContour cb, int ia, int ib) { }

	// RVA: 0xB996A0 Offset: 0xB980A0 VA: 0x180B996A0
	public void SimplifyContour(List<int> verts, List<int> simplified, float maxError, int maxEdgeLenght, int buildFlags) { }

	// RVA: 0xB9C030 Offset: 0xB9AA30 VA: 0x180B9C030
	public void WalkContour(int x, int z, int i, ushort[] flags, List<int> verts) { }

	// RVA: 0xB981C0 Offset: 0xB96BC0 VA: 0x180B981C0
	public int GetCornerHeight(int x, int z, int i, int dir, ref bool isBorderVertex) { }

	// RVA: 0xB99570 Offset: 0xB97F70 VA: 0x180B99570
	public void RemoveDegenerateSegments(List<int> simplified) { }

	// RVA: 0xB94BF0 Offset: 0xB935F0 VA: 0x180B94BF0
	public int CalcAreaOfPolygon2D(int[] verts, int nverts) { }

	// RVA: 0xB98960 Offset: 0xB97360 VA: 0x180B98960
	public static bool Ileft(int a, int b, int c, int[] va, int[] vb, int[] vc) { }

	// RVA: 0xB95E90 Offset: 0xB94890 VA: 0x180B95E90
	public static bool Diagonal(int i, int j, int n, int[] verts, int[] indices) { }

	// RVA: 0xB98A40 Offset: 0xB97440 VA: 0x180B98A40
	public static bool InCone(int i, int j, int n, int[] verts, int[] indices) { }

	// RVA: 0xB98F90 Offset: 0xB97990 VA: 0x180B98F90
	public static bool Left(int a, int b, int c, int[] verts) { }

	// RVA: 0xB98F70 Offset: 0xB97970 VA: 0x180B98F70
	public static bool LeftOn(int a, int b, int c, int[] verts) { }

	// RVA: 0xB958A0 Offset: 0xB942A0 VA: 0x180B958A0
	public static bool Collinear(int a, int b, int c, int[] verts) { }

	// RVA: 0xB91650 Offset: 0xB90050 VA: 0x180B91650
	public static int Area2(int a, int b, int c, int[] verts) { }

	// RVA: 0xB96020 Offset: 0xB94A20 VA: 0x180B96020
	private static bool Diagonalie(int i, int j, int n, int[] verts, int[] indices) { }

	// RVA: 0xB9C520 Offset: 0xB9AF20 VA: 0x180B9C520
	public static bool Xorb(bool x, bool y) { }

	// RVA: 0xB98CC0 Offset: 0xB976C0 VA: 0x180B98CC0
	public static bool IntersectProp(int a, int b, int c, int d, int[] verts) { }

	// RVA: 0xB91720 Offset: 0xB90120 VA: 0x180B91720
	private static bool Between(int a, int b, int c, int[] verts) { }

	// RVA: 0xB98DF0 Offset: 0xB977F0 VA: 0x180B98DF0
	private static bool Intersect(int a, int b, int c, int d, int[] verts) { }

	// RVA: 0xB9AD30 Offset: 0xB99730 VA: 0x180B9AD30
	private static bool Vequal(int a, int b, int[] verts) { }

	// RVA: 0xB99440 Offset: 0xB97E40 VA: 0x180B99440
	public static int Prev(int i, int n) { }

	// RVA: 0xB99430 Offset: 0xB97E30 VA: 0x180B99430
	public static int Next(int i, int n) { }

	// RVA: 0xB92E60 Offset: 0xB91860 VA: 0x180B92E60
	public void BuildPolyMesh(VoxelContourSet cset, int nvp, out VoxelMesh mesh) { }

	// RVA: 0xB9A670 Offset: 0xB99070 VA: 0x180B9A670
	private int Triangulate(int n, int[] verts, ref int[] indices, ref int[] tris) { }

	[CompilerGenerated]
	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public GraphTransform get_transformVoxel2Graph() { }

	[CompilerGenerated]
	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	private void set_transformVoxel2Graph(GraphTransform value) { }

	// RVA: 0xB958C0 Offset: 0xB942C0 VA: 0x180B958C0
	public Vector3 CompactSpanToVector(int x, int z, int i) { }

	// RVA: 0xB9AC10 Offset: 0xB99610 VA: 0x180B9AC10
	public void VectorToIndex(Vector3 p, out int x, out int z) { }

	// RVA: 0xB9C530 Offset: 0xB9AF30 VA: 0x180B9C530
	public void .ctor(float ch, float cs, float walkableClimb, float walkableHeight, float maxSlope, float maxEdgeLength) { }

	// RVA: 0xB98BA0 Offset: 0xB975A0 VA: 0x180B98BA0
	public void Init() { }

	// RVA: 0xB9B010 Offset: 0xB99A10 VA: 0x180B9B010
	public void VoxelizeInput(GraphTransform graphTransform, Bounds graphSpaceBounds) { }

	// RVA: 0xB95AC0 Offset: 0xB944C0 VA: 0x180B95AC0
	public void DebugDrawSpans() { }

	// RVA: 0xB91C20 Offset: 0xB90620 VA: 0x180B91C20
	public void BuildCompactField() { }

	// RVA: 0xB947C0 Offset: 0xB931C0 VA: 0x180B947C0
	public void BuildVoxelConnections() { }

	// RVA: 0xB96270 Offset: 0xB94C70 VA: 0x180B96270
	private void DrawLine(int a, int b, int[] indices, int[] verts, Color color) { }

	// RVA: 0xB9AFA0 Offset: 0xB999A0 VA: 0x180B9AFA0
	public Vector3 VoxelToWorld(int x, int y, int z) { }

	// RVA: 0xB9ADA0 Offset: 0xB997A0 VA: 0x180B9ADA0
	public Int3 VoxelToWorldInt3(Int3 voxelPosition) { }

	// RVA: 0xB95970 Offset: 0xB94370 VA: 0x180B95970
	private Vector3 ConvertPosWithoutOffset(int x, int y, int z) { }

	// RVA: 0xB95A00 Offset: 0xB94400 VA: 0x180B95A00
	private Vector3 ConvertPosition(int x, int z, int i) { }

	// RVA: 0xB96780 Offset: 0xB95180 VA: 0x180B96780
	public void ErodeWalkableArea(int radius) { }

	// RVA: 0xB92D30 Offset: 0xB91730 VA: 0x180B92D30
	public void BuildDistanceField() { }

	[Obsolete("This function is not complete and should not be used")]
	// RVA: 0xB96500 Offset: 0xB94F00 VA: 0x180B96500
	public void ErodeVoxels(int radius) { }

	// RVA: 0xB96E30 Offset: 0xB95830 VA: 0x180B96E30
	public void FilterLowHeightSpans(uint voxelWalkableHeight, float cs, float ch) { }

	// RVA: 0xB968B0 Offset: 0xB952B0 VA: 0x180B968B0
	public void FilterLedges(uint voxelWalkableHeight, int voxelWalkableClimb, float cs, float ch) { }

	// RVA: 0xB97940 Offset: 0xB96340 VA: 0x180B97940
	public bool FloodRegion(int x, int z, int i, uint level, ushort r, ushort[] srcReg, ushort[] srcDist, Int3[] stack, int[] flags, bool[] closed) { }

	// RVA: 0xB98FB0 Offset: 0xB979B0 VA: 0x180B98FB0
	public void MarkRectWithRegion(int minx, int maxx, int minz, int maxz, ushort region, ushort[] srcReg) { }

	// RVA: 0xB94CF0 Offset: 0xB936F0 VA: 0x180B94CF0
	public ushort CalculateDistanceField(ushort[] src) { }

	// RVA: 0xB91830 Offset: 0xB90230 VA: 0x180B91830
	public ushort[] BoxBlur(ushort[] src, ushort[] dst) { }

	// RVA: 0xB934F0 Offset: 0xB91EF0 VA: 0x180B934F0
	public void BuildRegions() { }

	// RVA: 0xB9C680 Offset: 0xB9B080 VA: 0x180B9C680
	private static int union_find_find(int[] arr, int x) { }

	// RVA: 0xB9C6E0 Offset: 0xB9B0E0 VA: 0x180B9C6E0
	private static void union_find_union(int[] arr, int a, int b) { }

	// RVA: 0xB96F60 Offset: 0xB95960 VA: 0x180B96F60
	public void FilterSmallRegions(ushort[] reg, int minRegionSize, int maxRegions) { }
}
