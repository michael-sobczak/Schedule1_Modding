internal class DecalSkipCulledSystem // TypeDefIndex: 8850
{
	// Fields
	private DecalEntityManager m_EntityManager; // 0x10
	private ProfilingSampler m_Sampler; // 0x18
	private Camera m_Camera; // 0x20

	// Methods

	// RVA: 0x2AE72A0 Offset: 0x2AE5CA0 VA: 0x182AE72A0
	public void .ctor(DecalEntityManager entityManager) { }

	// RVA: 0x2AE6FC0 Offset: 0x2AE59C0 VA: 0x182AE6FC0
	public void Execute(Camera camera) { }

	// RVA: 0x2AE71D0 Offset: 0x2AE5BD0 VA: 0x182AE71D0
	private void Execute(DecalCulledChunk culledChunk, int count) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770
	internal static ulong GetSceneCullingMaskFromCamera(Camera camera) { }
}
