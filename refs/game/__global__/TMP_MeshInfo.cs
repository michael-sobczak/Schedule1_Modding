public struct TMP_MeshInfo // TypeDefIndex: 14947
{
	// Fields
	private static readonly Color32 s_DefaultColor; // 0x0
	private static readonly Vector3 s_DefaultNormal; // 0x4
	private static readonly Vector4 s_DefaultTangent; // 0x10
	private static readonly Bounds s_DefaultBounds; // 0x20
	public Mesh mesh; // 0x0
	public int vertexCount; // 0x8
	public Vector3[] vertices; // 0x10
	public Vector3[] normals; // 0x18
	public Vector4[] tangents; // 0x20
	public Vector4[] uvs0; // 0x28
	public Vector2[] uvs2; // 0x30
	public Color32[] colors32; // 0x38
	public int[] triangles; // 0x40
	public Material material; // 0x48

	// Methods

	// RVA: 0x2C25170 Offset: 0x2C23B70 VA: 0x182C25170
	public void .ctor(Mesh mesh, int size) { }

	// RVA: 0x2C257C0 Offset: 0x2C241C0 VA: 0x182C257C0
	public void .ctor(Mesh mesh, int size, bool isVolumetric) { }

	// RVA: 0x2C23630 Offset: 0x2C22030 VA: 0x182C23630
	public void ResizeMeshInfo(int size) { }

	// RVA: 0x2C23B40 Offset: 0x2C22540 VA: 0x182C23B40
	public void ResizeMeshInfo(int size, bool isVolumetric) { }

	// RVA: 0x2C23440 Offset: 0x2C21E40 VA: 0x182C23440
	public void Clear() { }

	// RVA: 0x2C234F0 Offset: 0x2C21EF0 VA: 0x182C234F0
	public void Clear(bool uploadChanges) { }

	// RVA: 0x2C23400 Offset: 0x2C21E00 VA: 0x182C23400
	public void ClearUnusedVertices() { }

	// RVA: 0x2C23310 Offset: 0x2C21D10 VA: 0x182C23310
	public void ClearUnusedVertices(int startIndex) { }

	// RVA: 0x2C23350 Offset: 0x2C21D50 VA: 0x182C23350
	public void ClearUnusedVertices(int startIndex, bool updateMesh) { }

	// RVA: 0x2C246B0 Offset: 0x2C230B0 VA: 0x182C246B0
	public void SortGeometry(VertexSortingOrder order) { }

	// RVA: 0x2C24760 Offset: 0x2C23160 VA: 0x182C24760
	public void SortGeometry(IList<int> sortingOrder) { }

	// RVA: 0x2C24900 Offset: 0x2C23300 VA: 0x182C24900
	public void SwapVertexData(int src, int dst) { }

	// RVA: 0x2C250D0 Offset: 0x2C23AD0 VA: 0x182C250D0
	private static void .cctor() { }
}
