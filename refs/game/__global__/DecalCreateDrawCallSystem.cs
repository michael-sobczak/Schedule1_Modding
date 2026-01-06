internal class DecalCreateDrawCallSystem // TypeDefIndex: 8841
{
	// Fields
	private DecalEntityManager m_EntityManager; // 0x10
	private ProfilingSampler m_Sampler; // 0x18
	private float m_MaxDrawDistance; // 0x20

	// Properties
	public float maxDrawDistance { get; set; }

	// Methods

	// RVA: 0x4975C0 Offset: 0x495FC0 VA: 0x1804975C0
	public float get_maxDrawDistance() { }

	// RVA: 0x49CD70 Offset: 0x49B770 VA: 0x18049CD70
	public void set_maxDrawDistance(float value) { }

	// RVA: 0x2AE03C0 Offset: 0x2ADEDC0 VA: 0x182AE03C0
	public void .ctor(DecalEntityManager entityManager, float maxDrawDistance) { }

	// RVA: 0x2ADFD70 Offset: 0x2ADE770 VA: 0x182ADFD70
	public void Execute() { }

	// RVA: 0x2AE0190 Offset: 0x2ADEB90 VA: 0x182AE0190
	private void Execute(DecalCachedChunk cachedChunk, DecalCulledChunk culledChunk, DecalDrawCallChunk drawCallChunk, int count) { }
}
