internal static class MeshBuilder // TypeDefIndex: 7110
{
	// Fields
	private static ProfilerMarker s_VectorGraphics9Slice; // 0x0
	private static ProfilerMarker s_VectorGraphicsSplitTriangle; // 0x8
	private static ProfilerMarker s_VectorGraphicsScaleTriangle; // 0x10
	private static ProfilerMarker s_VectorGraphicsStretch; // 0x18
	internal static readonly int s_MaxTextMeshVertices; // 0x20

	// Methods

	// RVA: 0x2DFD230 Offset: 0x2DFBC30 VA: 0x182DFD230
	private static Vertex ConvertTextVertexToUIRVertex(MeshInfo info, int index, Vector2 offset, VertexFlags flags = 1, bool isDynamicColor = False) { }

	// RVA: 0x2DFD400 Offset: 0x2DFBE00 VA: 0x182DFD400
	private static int LimitTextVertices(int vertexCount, bool logTruncation = True) { }

	// RVA: 0x2DFD530 Offset: 0x2DFBF30 VA: 0x182DFD530
	internal static void MakeText(MeshInfo meshInfo, Vector2 offset, MeshBuilder.AllocMeshData meshAlloc, VertexFlags flags = 1, bool isDynamicColor = False) { }

	// RVA: 0x2DFDC00 Offset: 0x2DFC600 VA: 0x182DFDC00
	private static void .cctor() { }
}
