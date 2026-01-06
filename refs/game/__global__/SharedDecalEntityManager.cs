internal class SharedDecalEntityManager : IDisposable // TypeDefIndex: 8984
{
	// Fields
	private DecalEntityManager m_DecalEntityManager; // 0x10
	private int m_ReferenceCounter; // 0x18

	// Methods

	// RVA: 0x2B2B1C0 Offset: 0x2B29BC0 VA: 0x182B2B1C0
	public DecalEntityManager Get() { }

	// RVA: 0x2B2B5D0 Offset: 0x2B29FD0 VA: 0x182B2B5D0
	public void Release(DecalEntityManager decalEntityManager) { }

	// RVA: 0x2B2B030 Offset: 0x2B29A30 VA: 0x182B2B030 Slot: 4
	public void Dispose() { }

	// RVA: 0x2B2B470 Offset: 0x2B29E70 VA: 0x182B2B470
	private void OnDecalAdd(DecalProjector decalProjector) { }

	// RVA: 0x2B2B5A0 Offset: 0x2B29FA0 VA: 0x182B2B5A0
	private void OnDecalRemove(DecalProjector decalProjector) { }

	// RVA: 0x2B2B540 Offset: 0x2B29F40 VA: 0x182B2B540
	private void OnDecalPropertyChange(DecalProjector decalProjector) { }

	// RVA: 0x2B2B450 Offset: 0x2B29E50 VA: 0x182B2B450
	private void OnAllDecalPropertyChange() { }

	// RVA: 0x2B2B4D0 Offset: 0x2B29ED0 VA: 0x182B2B4D0
	private void OnDecalMaterialChange(DecalProjector decalProjector) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
