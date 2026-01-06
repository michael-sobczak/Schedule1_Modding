internal struct Smoothen // TypeDefIndex: 9170
{
	// Fields
	private static readonly float kMaxAreaTolerance; // 0x0
	private static readonly float kMaxEdgeTolerance; // 0x4

	// Methods

	// RVA: 0x2B7DAE0 Offset: 0x2B7C4E0 VA: 0x182B7DAE0
	private static void RefineEdges(ref NativeArray<int4> refinedEdges, ref NativeArray<int4> delaEdges, ref int delaEdgeCount, ref NativeArray<int4> voronoiEdges) { }

	// RVA: 0x2B7DA70 Offset: 0x2B7C470 VA: 0x182B7DA70
	private static void GetAffectingEdges(int pointIndex, NativeArray<int4> edges, int edgeCount, ref NativeArray<int> resultSet, ref NativeArray<int> checkSet, ref int resultCount) { }

	// RVA: 0x2B7CB10 Offset: 0x2B7B510 VA: 0x182B7CB10
	private static void CentroidByPoints(int triIndex, NativeArray<UTriangle> triangles, ref NativeArray<int> centroidTris, ref int centroidCount, ref float2 aggregate, ref float2 point) { }

	// RVA: 0x2B7CBB0 Offset: 0x2B7B5B0 VA: 0x182B7CBB0
	private static void CentroidByPolygon(int4 e, NativeArray<UTriangle> triangles, ref float2 centroid, ref float area, ref float distance) { }

	// RVA: 0x2B7D870 Offset: 0x2B7C270 VA: 0x182B7D870
	private static bool ConnectTriangles(ref NativeArray<int4> connectedTri, ref NativeArray<int> affectEdges, ref NativeArray<int> checkSet, NativeArray<int4> voronoiEdges, int triangleCount) { }

	// RVA: 0x2B7CCE0 Offset: 0x2B7B6E0 VA: 0x182B7CCE0
	internal static bool Condition(Allocator allocator, ref NativeArray<float2> pgPoints, int pgPointCount, NativeArray<int2> pgEdges, int pgEdgeCount, ref NativeArray<float2> vertices, ref int vertexCount, ref NativeArray<int> indices, ref int indexCount) { }

	// RVA: 0x2B7DC90 Offset: 0x2B7C690 VA: 0x182B7DC90
	private static void .cctor() { }
}
