internal struct CountingBloomFilter // TypeDefIndex: 6446
{
	// Fields
	[FixedBuffer(typeof(byte), 16384)]
	private CountingBloomFilter.<m_Counters>e__FixedBuffer m_Counters; // 0x0

	// Methods

	// RVA: 0x2E6F950 Offset: 0x2E6E350 VA: 0x182E6F950
	private void AdjustSlot(uint index, bool increment) { }

	// RVA: 0x2E6F9B0 Offset: 0x2E6E3B0 VA: 0x182E6F9B0
	private uint Hash1(uint hash) { }

	// RVA: 0x2E6F9C0 Offset: 0x2E6E3C0 VA: 0x182E6F9C0
	private uint Hash2(uint hash) { }

	// RVA: 0x2E6FA00 Offset: 0x2E6E400 VA: 0x182E6FA00
	private bool IsSlotEmpty(uint index) { }

	// RVA: 0x2E6F9D0 Offset: 0x2E6E3D0 VA: 0x182E6F9D0
	public void InsertHash(uint hash) { }

	// RVA: 0x2E6FA10 Offset: 0x2E6E410 VA: 0x182E6FA10
	public void RemoveHash(uint hash) { }

	// RVA: 0x2E6F980 Offset: 0x2E6E380 VA: 0x182E6F980
	public bool ContainsHash(uint hash) { }
}
