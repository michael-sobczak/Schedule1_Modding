internal struct MeshInfo // TypeDefIndex: 16716
{
	// Fields
	private static readonly Color32 k_DefaultColor; // 0x0
	private static readonly Vector3 k_DefaultNormal; // 0x4
	private static readonly Vector4 k_DefaultTangent; // 0x10
	public int vertexCount; // 0x0
	public Vector3[] vertices; // 0x8
	public Vector3[] normals; // 0x10
	public Vector4[] tangents; // 0x18
	public Vector4[] uvs0; // 0x20
	public Vector2[] uvs2; // 0x28
	public Color32[] colors32; // 0x30
	public int[] triangles; // 0x38
	public Material material; // 0x40
	internal GlyphRenderMode glyphRenderMode; // 0x48

	// Methods

	// RVA: 0x2D595A0 Offset: 0x2D57FA0 VA: 0x182D595A0
	public void .ctor(int size) { }

	// RVA: 0x2D58A90 Offset: 0x2D57490 VA: 0x182D58A90
	internal void ResizeMeshInfo(int size) { }

	// RVA: 0x2D58A50 Offset: 0x2D57450 VA: 0x182D58A50
	internal void Clear(bool uploadChanges) { }

	// RVA: 0x2D58A10 Offset: 0x2D57410 VA: 0x182D58A10
	internal void ClearUnusedVertices() { }

	// RVA: 0x2D58C90 Offset: 0x2D57690 VA: 0x182D58C90
	internal void SortGeometry(VertexSortingOrder order) { }

	// RVA: 0x2D58D40 Offset: 0x2D57740 VA: 0x182D58D40
	internal void SwapVertexData(int src, int dst) { }

	// RVA: 0x2D59510 Offset: 0x2D57F10 VA: 0x182D59510
	private static void .cctor() { }
}
