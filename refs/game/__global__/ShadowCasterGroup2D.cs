public abstract class ShadowCasterGroup2D : MonoBehaviour // TypeDefIndex: 8729
{
	// Fields
	[SerializeField]
	internal int m_ShadowGroup; // 0x20
	private List<ShadowCaster2D> m_ShadowCasters; // 0x28

	// Methods

	// RVA: 0x2AD01B0 Offset: 0x2ACEBB0 VA: 0x182AD01B0 Slot: 4
	internal virtual void CacheValues() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public List<ShadowCaster2D> GetShadowCasters() { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public int GetShadowGroup() { }

	// RVA: 0x2AD0250 Offset: 0x2ACEC50 VA: 0x182AD0250
	public void RegisterShadowCaster2D(ShadowCaster2D shadowCaster2D) { }

	// RVA: 0x2AD0350 Offset: 0x2ACED50 VA: 0x182AD0350
	public void UnregisterShadowCaster2D(ShadowCaster2D shadowCaster2D) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	protected void .ctor() { }
}
