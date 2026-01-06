internal sealed class LocalDataStoreMgr // TypeDefIndex: 3798
{
	// Fields
	private const int InitialSlotTableSize = 64;
	private const int SlotTableDoubleThreshold = 512;
	private const int LargeSlotTableSizeIncrease = 128;
	private bool[] m_SlotInfoTable; // 0x10
	private int m_FirstAvailableSlot; // 0x18
	private List<LocalDataStore> m_ManagedLocalDataStores; // 0x20
	private Dictionary<string, LocalDataStoreSlot> m_KeyToSlotMap; // 0x28
	private long m_CookieGenerator; // 0x30

	// Methods

	// RVA: 0x1CA9190 Offset: 0x1CA7B90 VA: 0x181CA9190
	public LocalDataStoreHolder CreateLocalDataStore() { }

	// RVA: 0x1CA9390 Offset: 0x1CA7D90 VA: 0x181CA9390
	public void DeleteLocalDataStore(LocalDataStore store) { }

	// RVA: 0x1CA8E40 Offset: 0x1CA7840 VA: 0x181CA8E40
	public LocalDataStoreSlot AllocateDataSlot() { }

	// RVA: 0x1CA90A0 Offset: 0x1CA7AA0 VA: 0x181CA90A0
	public LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	// RVA: 0x1CA96F0 Offset: 0x1CA80F0 VA: 0x181CA96F0
	public LocalDataStoreSlot GetNamedDataSlot(string name) { }

	// RVA: 0x1CA9620 Offset: 0x1CA8020 VA: 0x181CA9620
	public void FreeNamedDataSlot(string name) { }

	// RVA: 0x1CA9460 Offset: 0x1CA7E60 VA: 0x181CA9460
	internal void FreeDataSlot(int slot, long cookie) { }

	// RVA: 0x1CA9800 Offset: 0x1CA8200 VA: 0x181CA9800
	public void ValidateSlot(LocalDataStoreSlot slot) { }

	// RVA: 0xC4AA50 Offset: 0xC49450 VA: 0x180C4AA50
	internal int GetSlotTableLength() { }

	// RVA: 0x1CA9880 Offset: 0x1CA8280 VA: 0x181CA9880
	public void .ctor() { }
}
