internal class ShadowUtility // TypeDefIndex: 8734
{
	// Methods

	// RVA: 0x2AD36F0 Offset: 0x2AD20F0 VA: 0x182AD36F0
	private static ShadowUtility.Edge CreateEdge(int triangleIndexA, int triangleIndexB, List<Vector3> vertices, List<int> triangles) { }

	// RVA: 0x2AD4B50 Offset: 0x2AD3550 VA: 0x182AD4B50
	private static void PopulateEdgeArray(List<Vector3> vertices, List<int> triangles, List<ShadowUtility.Edge> edges) { }

	// RVA: 0x2AD49D0 Offset: 0x2AD33D0 VA: 0x182AD49D0
	private static bool IsOutsideEdge(int edgeIndex, List<ShadowUtility.Edge> edgesToProcess) { }

	// RVA: 0x2AD4DD0 Offset: 0x2AD37D0 VA: 0x182AD4DD0
	private static void SortEdges(List<ShadowUtility.Edge> edgesToProcess) { }

	// RVA: 0x2AD39E0 Offset: 0x2AD23E0 VA: 0x182AD39E0
	private static void CreateShadowTriangles(List<Vector3> vertices, List<Color> colors, List<int> triangles, List<Vector4> tangents, List<ShadowUtility.Edge> edges) { }

	// RVA: 0x2AD49A0 Offset: 0x2AD33A0 VA: 0x182AD49A0
	private static object InterpCustomVertexData(Vec3 position, object[] data, float[] weights) { }

	// RVA: 0x2AD48B0 Offset: 0x2AD32B0 VA: 0x182AD48B0
	private static void InitializeTangents(int tangentsToAdd, List<Vector4> tangents) { }

	// RVA: 0x2AD33C0 Offset: 0x2AD1DC0 VA: 0x182AD33C0
	internal static Bounds CalculateLocalBounds(Vector3[] inVertices) { }

	// RVA: 0x2AD3DC0 Offset: 0x2AD27C0 VA: 0x182AD3DC0
	public static Bounds GenerateShadowMesh(Mesh mesh, Vector3[] shapePath) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
