internal class DecalUpdateCullingGroupSystem // TypeDefIndex: 8856
{
	// Fields
	private float[] m_BoundingDistance; // 0x10
	private Camera m_Camera; // 0x18
	private DecalEntityManager m_EntityManager; // 0x20
	private ProfilingSampler m_Sampler; // 0x28

	// Properties
	public float boundingDistance { get; set; }

	// Methods

	// RVA: 0x2AE8110 Offset: 0x2AE6B10 VA: 0x182AE8110
	public float get_boundingDistance() { }

	// RVA: 0x2AE8140 Offset: 0x2AE6B40 VA: 0x182AE8140
	public void set_boundingDistance(float value) { }

	// RVA: 0x2AE8020 Offset: 0x2AE6A20 VA: 0x182AE8020
	public void .ctor(DecalEntityManager entityManager, float drawDistance) { }

	// RVA: 0x2AE7B70 Offset: 0x2AE6570 VA: 0x182AE7B70
	public void Execute(Camera camera) { }

	// RVA: 0x2AE7E90 Offset: 0x2AE6890 VA: 0x182AE7E90
	public void Execute(DecalCachedChunk cachedChunk, DecalCulledChunk culledChunk, int count) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770
	internal static ulong GetSceneCullingMaskFromCamera(Camera camera) { }
}
