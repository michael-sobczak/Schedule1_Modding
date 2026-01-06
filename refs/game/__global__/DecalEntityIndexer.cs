internal class DecalEntityIndexer // TypeDefIndex: 8844
{
	// Fields
	private List<DecalEntityIndexer.DecalEntityItem> m_Entities; // 0x10
	private Queue<int> m_FreeIndices; // 0x18

	// Methods

	// RVA: 0x2AE2620 Offset: 0x2AE1020 VA: 0x182AE2620
	public bool IsValid(DecalEntity decalEntity) { }

	// RVA: 0x2AE22F0 Offset: 0x2AE0CF0 VA: 0x182AE22F0
	public DecalEntity CreateDecalEntity(int arrayIndex, int chunkIndex) { }

	// RVA: 0x2AE24E0 Offset: 0x2AE0EE0 VA: 0x182AE24E0
	public void DestroyDecalEntity(DecalEntity decalEntity) { }

	// RVA: 0x2AE25A0 Offset: 0x2AE0FA0 VA: 0x182AE25A0
	public DecalEntityIndexer.DecalEntityItem GetItem(DecalEntity decalEntity) { }

	// RVA: 0x2AE2800 Offset: 0x2AE1200 VA: 0x182AE2800
	public void UpdateIndex(DecalEntity decalEntity, int newArrayIndex) { }

	// RVA: 0x2AE26B0 Offset: 0x2AE10B0 VA: 0x182AE26B0
	public void RemapChunkIndices(List<int> remaper) { }

	// RVA: 0x2AE2280 Offset: 0x2AE0C80 VA: 0x182AE2280
	public void Clear() { }

	// RVA: 0x2AE28C0 Offset: 0x2AE12C0 VA: 0x182AE28C0
	public void .ctor() { }
}
