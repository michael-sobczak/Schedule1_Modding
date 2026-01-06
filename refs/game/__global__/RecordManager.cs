internal sealed class RecordManager // TypeDefIndex: 12970
{
	// Fields
	private readonly DataTable _table; // 0x10
	private int _lastFreeRecord; // 0x18
	private int _minimumCapacity; // 0x1C
	private int _recordCapacity; // 0x20
	private readonly List<int> _freeRecordList; // 0x28
	private DataRow[] _rows; // 0x30

	// Properties
	internal int LastFreeRecord { get; }
	internal int MinimumCapacity { get; set; }
	internal int RecordCapacity { get; set; }
	internal DataRow Item { get; set; }

	// Methods

	// RVA: 0x20A3450 Offset: 0x20A1E50 VA: 0x1820A3450
	internal void .ctor(DataTable table) { }

	// RVA: 0x20A30D0 Offset: 0x20A1AD0 VA: 0x1820A30D0
	private void GrowRecordCapacity() { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	internal int get_LastFreeRecord() { }

	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	internal int get_MinimumCapacity() { }

	// RVA: 0x20A35E0 Offset: 0x20A1FE0 VA: 0x1820A35E0
	internal void set_MinimumCapacity(int value) { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	internal int get_RecordCapacity() { }

	// RVA: 0x20A3620 Offset: 0x20A2020 VA: 0x1820A3620
	internal void set_RecordCapacity(int value) { }

	// RVA: 0x20A32F0 Offset: 0x20A1CF0 VA: 0x1820A32F0
	internal static int NewCapacity(int capacity) { }

	// RVA: 0x20A33D0 Offset: 0x20A1DD0 VA: 0x1820A33D0
	private int NormalizedMinimumCapacity(int capacity) { }

	// RVA: 0x20A3300 Offset: 0x20A1D00 VA: 0x1820A3300
	internal int NewRecordBase() { }

	// RVA: 0x20A2F60 Offset: 0x20A1960 VA: 0x1820A2F60
	internal void FreeRecord(ref int record) { }

	// RVA: 0x20A2A80 Offset: 0x20A1480 VA: 0x1820A2A80
	internal void Clear(bool clearAll) { }

	// RVA: 0x20A3530 Offset: 0x20A1F30 VA: 0x1820A3530
	internal DataRow get_Item(int record) { }

	// RVA: 0x20A3560 Offset: 0x20A1F60 VA: 0x1820A3560
	internal void set_Item(int record, DataRow value) { }

	// RVA: 0x20A32D0 Offset: 0x20A1CD0 VA: 0x1820A32D0
	internal int ImportRecord(DataTable src, int record) { }

	// RVA: 0x20A2C90 Offset: 0x20A1690 VA: 0x1820A2C90
	internal int CopyRecord(DataTable src, int record, int copy) { }

	// RVA: 0x20A3410 Offset: 0x20A1E10 VA: 0x1820A3410
	internal void SetRowCache(DataRow[] newRows) { }
}
