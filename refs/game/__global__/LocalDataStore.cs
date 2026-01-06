internal sealed class LocalDataStore // TypeDefIndex: 3796
{
	// Fields
	private LocalDataStoreElement[] m_DataTable; // 0x10
	private LocalDataStoreMgr m_Manager; // 0x18

	// Methods

	// RVA: 0x1CAA030 Offset: 0x1CA8A30 VA: 0x181CAA030
	public void .ctor(LocalDataStoreMgr mgr, int InitialCapacity) { }

	// RVA: 0x1CA9A90 Offset: 0x1CA8490 VA: 0x181CA9A90
	internal void Dispose() { }

	// RVA: 0x1CA9B20 Offset: 0x1CA8520 VA: 0x181CA9B20
	public object GetData(LocalDataStoreSlot slot) { }

	// RVA: 0x1CA9EF0 Offset: 0x1CA88F0 VA: 0x181CA9EF0
	public void SetData(LocalDataStoreSlot slot, object data) { }

	// RVA: 0x1CA9AC0 Offset: 0x1CA84C0 VA: 0x181CA9AC0
	internal void FreeData(int slot, long cookie) { }

	// RVA: 0x1CA9C50 Offset: 0x1CA8650 VA: 0x181CA9C50
	private LocalDataStoreElement PopulateElement(LocalDataStoreSlot slot) { }
}
