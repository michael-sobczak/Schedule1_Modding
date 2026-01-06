internal class DecalEntityManager : IDisposable // TypeDefIndex: 8849
{
	// Fields
	public List<DecalEntityChunk> entityChunks; // 0x10
	public List<DecalCachedChunk> cachedChunks; // 0x18
	public List<DecalCulledChunk> culledChunks; // 0x20
	public List<DecalDrawCallChunk> drawCallChunks; // 0x28
	public int chunkCount; // 0x30
	private ProfilingSampler m_AddDecalSampler; // 0x38
	private ProfilingSampler m_ResizeChunks; // 0x40
	private ProfilingSampler m_SortChunks; // 0x48
	private DecalEntityIndexer m_DecalEntityIndexer; // 0x50
	private Dictionary<Material, int> m_MaterialToChunkIndex; // 0x58
	private List<DecalEntityManager.CombinedChunks> m_CombinedChunks; // 0x60
	private List<int> m_CombinedChunkRemmap; // 0x68
	private Material m_ErrorMaterial; // 0x70
	private Mesh m_DecalProjectorMesh; // 0x78

	// Properties
	public Material errorMaterial { get; }
	public Mesh decalProjectorMesh { get; }

	// Methods

	// RVA: 0x2AE5840 Offset: 0x2AE4240 VA: 0x182AE5840
	public Material get_errorMaterial() { }

	// RVA: 0x2AE5750 Offset: 0x2AE4150 VA: 0x182AE5750
	public Mesh get_decalProjectorMesh() { }

	// RVA: 0x2AE5390 Offset: 0x2AE3D90 VA: 0x182AE5390
	public void .ctor() { }

	// RVA: 0x2AE4180 Offset: 0x2AE2B80 VA: 0x182AE4180
	public bool IsValid(DecalEntity decalEntity) { }

	// RVA: 0x2AE2F00 Offset: 0x2AE1900 VA: 0x182AE2F00
	public DecalEntity CreateDecalEntity(DecalProjector decalProjector) { }

	// RVA: 0x2AE2980 Offset: 0x2AE1380 VA: 0x182AE2980
	private int CreateChunkIndex(Material material) { }

	// RVA: 0x2AE41A0 Offset: 0x2AE2BA0 VA: 0x182AE41A0
	public void UpdateAllDecalEntitiesData() { }

	// RVA: 0x2AE4370 Offset: 0x2AE2D70 VA: 0x182AE4370
	public void UpdateDecalEntityData(DecalEntity decalEntity, DecalProjector decalProjector) { }

	// RVA: 0x2AE3490 Offset: 0x2AE1E90 VA: 0x182AE3490
	public void DestroyDecalEntity(DecalEntity decalEntity) { }

	// RVA: 0x2AE48E0 Offset: 0x2AE32E0 VA: 0x182AE48E0
	public void Update() { }

	// RVA: 0x2AE3800 Offset: 0x2AE2200 VA: 0x182AE3800 Slot: 4
	public void Dispose() { }
}
