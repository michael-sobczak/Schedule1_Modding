internal class RecastMeshGatherer // TypeDefIndex: 13365
{
	// Fields
	private readonly int terrainSampleSize; // 0x10
	private readonly LayerMask mask; // 0x14
	private readonly List<string> tagMask; // 0x18
	private readonly float colliderRasterizeDetail; // 0x20
	private readonly Bounds bounds; // 0x24
	private static readonly int[] BoxColliderTris; // 0x0
	private static readonly Vector3[] BoxColliderVerts; // 0x8
	private List<RecastMeshGatherer.CapsuleCache> capsuleCache; // 0x40

	// Methods

	// RVA: 0xBAC130 Offset: 0xBAAB30 VA: 0x180BAC130
	public void .ctor(Bounds bounds, int terrainSampleSize, LayerMask mask, List<string> tagMask, float colliderRasterizeDetail) { }

	// RVA: 0xBA9AB0 Offset: 0xBA84B0 VA: 0x180BA9AB0
	private static List<MeshFilter> FilterMeshes(MeshFilter[] meshFilters, List<string> tagMask, LayerMask layerMask) { }

	// RVA: 0xBA8D10 Offset: 0xBA7710 VA: 0x180BA8D10
	public void CollectSceneMeshes(List<RasterizationMesh> meshes) { }

	// RVA: 0xBA8570 Offset: 0xBA6F70 VA: 0x180BA8570
	public void CollectRecastMeshObjs(List<RasterizationMesh> buffer) { }

	// RVA: 0xBA9290 Offset: 0xBA7C90 VA: 0x180BA9290
	public void CollectTerrainMeshes(bool rasterizeTrees, float desiredChunkSize, List<RasterizationMesh> result) { }

	// RVA: 0xBAA250 Offset: 0xBA8C50 VA: 0x180BAA250
	private void GenerateTerrainChunks(Terrain terrain, Bounds bounds, float desiredChunkSize, List<RasterizationMesh> result) { }

	// RVA: 0xBA8220 Offset: 0xBA6C20 VA: 0x180BA8220
	private static int CeilDivision(int lhs, int rhs) { }

	// RVA: 0xBA9D20 Offset: 0xBA8720 VA: 0x180BA9D20
	private RasterizationMesh GenerateHeightmapChunk(float[,] heights, Vector3 sampleSize, Vector3 offset, int x0, int z0, int width, int depth, int stride) { }

	// RVA: 0xBA9400 Offset: 0xBA7E00 VA: 0x180BA9400
	private void CollectTreeMeshes(Terrain terrain, List<RasterizationMesh> result) { }

	// RVA: 0xBA8230 Offset: 0xBA6C30 VA: 0x180BA8230
	public void CollectColliderMeshes(List<RasterizationMesh> result) { }

	// RVA: 0xBABEE0 Offset: 0xBAA8E0 VA: 0x180BABEE0
	private RasterizationMesh RasterizeCollider(Collider col) { }

	// RVA: 0xBAB620 Offset: 0xBAA020 VA: 0x180BAB620
	private RasterizationMesh RasterizeCollider(Collider col, Matrix4x4 localToWorldMatrix) { }

	// RVA: 0xBAA900 Offset: 0xBA9300 VA: 0x180BAA900
	private RasterizationMesh RasterizeBoxCollider(BoxCollider collider, Matrix4x4 localToWorldMatrix) { }

	// RVA: 0xBAABB0 Offset: 0xBA95B0 VA: 0x180BAABB0
	private RasterizationMesh RasterizeCapsuleCollider(float radius, float height, Bounds bounds, Matrix4x4 localToWorldMatrix) { }

	// RVA: 0xBABF70 Offset: 0xBAA970 VA: 0x180BABF70
	private static void .cctor() { }
}
