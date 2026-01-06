public sealed class DataRowCollection : InternalDataCollectionBase // TypeDefIndex: 12904
{
	// Fields
	private readonly DataTable _table; // 0x10
	private readonly DataRowCollection.DataRowTree _list; // 0x18
	internal int _nullInList; // 0x20

	// Properties
	public override int Count { get; }
	public DataRow Item { get; }

	// Methods

	// RVA: 0x20743D0 Offset: 0x2072DD0 VA: 0x1820743D0
	internal void .ctor(DataTable table) { }

	// RVA: 0x20744A0 Offset: 0x2072EA0 VA: 0x1820744A0 Slot: 9
	public override int get_Count() { }

	// RVA: 0x20744F0 Offset: 0x2072EF0 VA: 0x1820744F0
	public DataRow get_Item(int index) { }

	// RVA: 0x2073DB0 Offset: 0x20727B0 VA: 0x182073DB0
	public void Add(DataRow row) { }

	// RVA: 0x20740A0 Offset: 0x2072AA0 VA: 0x1820740A0
	internal void DiffInsertAt(DataRow row, int pos) { }

	// RVA: 0x2074340 Offset: 0x2072D40 VA: 0x182074340
	public int IndexOf(DataRow row) { }

	// RVA: 0x2073D30 Offset: 0x2072730 VA: 0x182073D30
	internal DataRow AddWithColumnEvents(object[] values) { }

	// RVA: 0x2073DE0 Offset: 0x20727E0 VA: 0x182073DE0
	internal void ArrayAdd(DataRow row) { }

	// RVA: 0x2073EA0 Offset: 0x20728A0 VA: 0x182073EA0
	internal void ArrayInsert(DataRow row, int pos) { }

	// RVA: 0x2073E50 Offset: 0x2072850 VA: 0x182073E50
	internal void ArrayClear() { }

	// RVA: 0x2073F20 Offset: 0x2072920 VA: 0x182073F20
	internal void ArrayRemove(DataRow row) { }

	// RVA: 0x2074030 Offset: 0x2072A30 VA: 0x182074030 Slot: 10
	public override void CopyTo(Array ar, int index) { }

	// RVA: 0x2073FC0 Offset: 0x20729C0 VA: 0x182073FC0
	public void CopyTo(DataRow[] array, int index) { }

	// RVA: 0x20742F0 Offset: 0x2072CF0 VA: 0x1820742F0 Slot: 11
	public override IEnumerator GetEnumerator() { }
}
