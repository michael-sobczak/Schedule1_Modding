public class CGVMesh : CGBounds // TypeDefIndex: 10660
{
	// Fields
	public CGVSubMesh[] SubMeshes; // 0x40
	private Nullable<SubArray<int>> sortedVertexIndices; // 0x48
	private readonly object vertexIndicesLock; // 0x60
	private SubArray<Vector3> vertices; // 0x68
	private SubArray<Vector2> uvs; // 0x78
	private SubArray<Vector2> uv2s; // 0x88
	private SubArray<Vector3> normals; // 0x98
	private SubArray<Vector4> tangents; // 0xA8
	private bool hasPartialNormals; // 0xB8
	private bool hasPartialTangents; // 0xB9

	// Properties
	public SubArray<Vector3> Vertices { get; set; }
	public SubArray<Vector2> UVs { get; set; }
	public SubArray<Vector2> UV2s { get; set; }
	public SubArray<Vector3> NormalsList { get; set; }
	public SubArray<Vector4> TangentsList { get; set; }
	[UsedImplicitly]
	[Obsolete("Use Vertices instead")]
	public Vector3[] Vertex { get; set; }
	[Obsolete("Use UVs instead")]
	[UsedImplicitly]
	public Vector2[] UV { get; set; }
	[UsedImplicitly]
	[Obsolete("Use UV2s instead")]
	public Vector2[] UV2 { get; set; }
	[UsedImplicitly]
	[Obsolete("Use NormalList instead")]
	public Vector3[] Normals { get; set; }
	[UsedImplicitly]
	[Obsolete("Use TangentsList instead")]
	public Vector4[] Tangents { get; set; }
	public override int Count { get; }
	public bool HasUV { get; }
	public bool HasUV2 { get; }
	public bool HasNormals { get; }
	public bool HasPartialNormals { get; set; }
	public bool HasTangents { get; }
	public bool HasPartialTangents { get; set; }
	public int TriangleCount { get; }

	// Methods

	// RVA: 0x4F9E50 Offset: 0x4F8850 VA: 0x1804F9E50
	public SubArray<Vector3> get_Vertices() { }

	// RVA: 0x501DB0 Offset: 0x5007B0 VA: 0x180501DB0
	public void set_Vertices(SubArray<Vector3> value) { }

	// RVA: 0x4F9C30 Offset: 0x4F8630 VA: 0x1804F9C30
	public SubArray<Vector2> get_UVs() { }

	// RVA: 0x501B90 Offset: 0x500590 VA: 0x180501B90
	public void set_UVs(SubArray<Vector2> value) { }

	// RVA: 0x501580 Offset: 0x4FFF80 VA: 0x180501580
	public SubArray<Vector2> get_UV2s() { }

	// RVA: 0x501A30 Offset: 0x500430 VA: 0x180501A30
	public void set_UV2s(SubArray<Vector2> value) { }

	// RVA: 0x4F6260 Offset: 0x4F4C60 VA: 0x1804F6260
	public SubArray<Vector3> get_NormalsList() { }

	// RVA: 0x501700 Offset: 0x500100 VA: 0x180501700
	public void set_NormalsList(SubArray<Vector3> value) { }

	// RVA: 0x5013A0 Offset: 0x4FFDA0 VA: 0x1805013A0
	public SubArray<Vector4> get_TangentsList() { }

	// RVA: 0x501860 Offset: 0x500260 VA: 0x180501860
	public void set_TangentsList(SubArray<Vector4> value) { }

	// RVA: 0x501640 Offset: 0x500040 VA: 0x180501640
	public Vector3[] get_Vertex() { }

	// RVA: 0x501C70 Offset: 0x500670 VA: 0x180501C70
	public void set_Vertex(Vector3[] value) { }

	// RVA: 0x501590 Offset: 0x4FFF90 VA: 0x180501590
	public Vector2[] get_UV() { }

	// RVA: 0x501B20 Offset: 0x500520 VA: 0x180501B20
	public void set_UV(Vector2[] value) { }

	// RVA: 0x5014D0 Offset: 0x4FFED0 VA: 0x1805014D0
	public Vector2[] get_UV2() { }

	// RVA: 0x5019C0 Offset: 0x5003C0 VA: 0x1805019C0
	public void set_UV2(Vector2[] value) { }

	// RVA: 0x5012F0 Offset: 0x4FFCF0 VA: 0x1805012F0
	public Vector3[] get_Normals() { }

	// RVA: 0x5017F0 Offset: 0x5001F0 VA: 0x1805017F0
	public void set_Normals(Vector3[] value) { }

	// RVA: 0x5013B0 Offset: 0x4FFDB0 VA: 0x1805013B0
	public Vector4[] get_Tangents() { }

	// RVA: 0x501950 Offset: 0x500350 VA: 0x180501950
	public void set_Tangents(Vector4[] value) { }

	// RVA: 0x501290 Offset: 0x4FFC90 VA: 0x180501290 Slot: 6
	public override int get_Count() { }

	// RVA: 0x5012E0 Offset: 0x4FFCE0 VA: 0x1805012E0
	public bool get_HasUV() { }

	// RVA: 0x5012D0 Offset: 0x4FFCD0 VA: 0x1805012D0
	public bool get_HasUV2() { }

	// RVA: 0x5012A0 Offset: 0x4FFCA0 VA: 0x1805012A0
	public bool get_HasNormals() { }

	// RVA: 0x4E8DE0 Offset: 0x4E77E0 VA: 0x1804E8DE0
	public bool get_HasPartialNormals() { }

	// RVA: 0x4E8EA0 Offset: 0x4E78A0 VA: 0x1804E8EA0
	private void set_HasPartialNormals(bool value) { }

	// RVA: 0x5012C0 Offset: 0x4FFCC0 VA: 0x1805012C0
	public bool get_HasTangents() { }

	// RVA: 0x5012B0 Offset: 0x4FFCB0 VA: 0x1805012B0
	public bool get_HasPartialTangents() { }

	// RVA: 0x5016F0 Offset: 0x5000F0 VA: 0x1805016F0
	private void set_HasPartialTangents(bool value) { }

	// RVA: 0x501460 Offset: 0x4FFE60 VA: 0x180501460
	public int get_TriangleCount() { }

	// RVA: 0x500890 Offset: 0x4FF290 VA: 0x180500890
	public void .ctor() { }

	// RVA: 0x4FFEB0 Offset: 0x4FE8B0 VA: 0x1804FFEB0
	public void .ctor(int vertexCount, bool addUV = False, bool addUV2 = False, bool addNormals = False, bool addTangents = False) { }

	// RVA: 0x5008C0 Offset: 0x4FF2C0 VA: 0x1805008C0
	public void .ctor(CGVolume volume) { }

	// RVA: 0x5011C0 Offset: 0x4FFBC0 VA: 0x1805011C0
	public void .ctor(CGVolume volume, IntRegion subset) { }

	// RVA: 0x5009D0 Offset: 0x4FF3D0 VA: 0x1805009D0
	public void .ctor(CGVMesh source) { }

	// RVA: 0x500940 Offset: 0x4FF340 VA: 0x180500940
	public void .ctor(CGMeshProperties meshProperties) { }

	// RVA: 0x5004C0 Offset: 0x4FEEC0 VA: 0x1805004C0
	public void .ctor(Mesh source, Material[] materials, Matrix4x4 trsMatrix) { }

	// RVA: 0x4FC8B0 Offset: 0x4FB2B0 VA: 0x1804FC8B0 Slot: 5
	protected override bool Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 7
	public override T Clone<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5CBB0 Offset: 0xE5B5B0 VA: 0x180E5CBB0
	|-CGVMesh.Clone<object>
	*/

	[Obsolete("Member not used by Curvy, will get removed next major version. Use another overload of this method")]
	[UsedImplicitly]
	// RVA: 0x4FD9F0 Offset: 0x4FC3F0 VA: 0x1804FD9F0
	public static CGVMesh Get(CGVMesh data, CGVolume source, bool addUV, bool reverseNormals) { }

	[Obsolete("Member not used by Curvy, will get removed next major version. Use another overload of this method")]
	[UsedImplicitly]
	// RVA: 0x4FD9B0 Offset: 0x4FC3B0 VA: 0x1804FD9B0
	public static CGVMesh Get(CGVMesh data, CGVolume source, IntRegion subset, bool addUV, bool reverseNormals) { }

	[NotNull]
	// RVA: 0x4FD510 Offset: 0x4FBF10 VA: 0x1804FD510
	public static CGVMesh Get(CGVMesh data, CGVolume source, IntRegion subset, bool addUV, bool addUV2, bool reverseNormals) { }

	// RVA: 0x4FF8A0 Offset: 0x4FE2A0 VA: 0x1804FF8A0
	public void SetSubMeshCount(int count) { }

	// RVA: 0x4FC640 Offset: 0x4FB040 VA: 0x1804FC640
	public void AddSubMesh(CGVSubMesh submesh) { }

	// RVA: 0x4FE5C0 Offset: 0x4FCFC0 VA: 0x1804FE5C0
	public void MergeVMesh(CGVMesh source) { }

	// RVA: 0x4FE0B0 Offset: 0x4FCAB0 VA: 0x1804FE0B0
	public void MergeVMesh(CGVMesh source, Matrix4x4 matrix) { }

	// RVA: 0x4FE640 Offset: 0x4FD040 VA: 0x1804FE640
	public void MergeVMeshes(List<CGVMesh> vMeshes, int startIndex, int endIndex) { }

	// RVA: 0x4FDAB0 Offset: 0x4FC4B0 VA: 0x1804FDAB0
	private void MergeUVsNormalsAndTangents(CGVMesh source, int preMergeVertexCount) { }

	// RVA: 0x4FD130 Offset: 0x4FBB30 VA: 0x1804FD130
	public CGVSubMesh GetMaterialSubMesh(Material mat, bool createIfMissing = True) { }

	[UsedImplicitly]
	[Obsolete("Use ToMesh instead")]
	// RVA: 0x4FC6A0 Offset: 0x4FB0A0 VA: 0x1804FC6A0
	public Mesh AsMesh() { }

	// RVA: 0x4FFB60 Offset: 0x4FE560 VA: 0x1804FFB60
	public void ToMesh(ref Mesh mesh, bool includeNormals = True, bool includeTangents = True) { }

	// RVA: 0x4FD3A0 Offset: 0x4FBDA0 VA: 0x1804FD3A0
	public Material[] GetMaterials() { }

	// RVA: 0x4FF390 Offset: 0x4FDD90 VA: 0x1804FF390 Slot: 8
	public override void RecalculateBounds() { }

	[Obsolete("Method will get remove in next major update. Copy its content if you need it")]
	[UsedImplicitly]
	// RVA: 0x4FF6E0 Offset: 0x4FE0E0 VA: 0x1804FF6E0
	public void RecalculateUV2() { }

	// RVA: 0x4FF8F0 Offset: 0x4FE2F0 VA: 0x1804FF8F0
	public void TRS(Matrix4x4 matrix) { }

	// RVA: 0x4FF370 Offset: 0x4FDD70 VA: 0x1804FF370
	private void OnVerticesChanged() { }

	// RVA: 0x4FCCD0 Offset: 0x4FB6D0 VA: 0x1804FCCD0
	public SubArray<int> GetCachedSortedVertexIndices() { }

	// RVA: 0x4FC720 Offset: 0x4FB120 VA: 0x1804FC720
	private void ClearCachedSortedVertexIndices() { }

	[CompilerGenerated]
	// RVA: 0x4FFDA0 Offset: 0x4FE7A0 VA: 0x1804FFDA0
	private void <MergeVMeshes>g__ProcessTriangleArrays|74_0(List<SubArray<int>> subArrays, Material material1) { }
}
