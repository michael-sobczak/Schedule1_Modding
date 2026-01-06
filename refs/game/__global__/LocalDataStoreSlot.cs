public sealed class LocalDataStoreSlot // TypeDefIndex: 3797
{
	// Fields
	private LocalDataStoreMgr m_mgr; // 0x10
	private int m_slot; // 0x18
	private long m_cookie; // 0x20

	// Properties
	internal LocalDataStoreMgr Manager { get; }
	internal int Slot { get; }
	internal long Cookie { get; }

	// Methods

	// RVA: 0x1CA9A30 Offset: 0x1CA8430 VA: 0x181CA9A30
	internal void .ctor(LocalDataStoreMgr mgr, int slot, long cookie) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal LocalDataStoreMgr get_Manager() { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	internal int get_Slot() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	internal long get_Cookie() { }

	// RVA: 0x1CA9970 Offset: 0x1CA8370 VA: 0x181CA9970 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1CA9A00 Offset: 0x1CA8400 VA: 0x181CA9A00
	internal void .ctor() { }
}
