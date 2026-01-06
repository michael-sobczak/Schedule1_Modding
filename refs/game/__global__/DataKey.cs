internal struct DataKey // TypeDefIndex: 12892
{
	// Fields
	private readonly DataColumn[] _columns; // 0x0

	// Properties
	internal DataColumn[] ColumnsReference { get; }
	internal bool HasValue { get; }
	internal DataTable Table { get; }

	// Methods

	// RVA: 0x206E700 Offset: 0x206D100 VA: 0x18206E700
	internal void .ctor(DataColumn[] columns, bool copyColumns) { }

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	internal DataColumn[] get_ColumnsReference() { }

	// RVA: 0x1CD57E0 Offset: 0x1CD41E0 VA: 0x181CD57E0
	internal bool get_HasValue() { }

	// RVA: 0x206E9D0 Offset: 0x206D3D0 VA: 0x18206E9D0
	internal DataTable get_Table() { }

	// RVA: 0x206DCD0 Offset: 0x206C6D0 VA: 0x18206DCD0
	internal void CheckState() { }

	// RVA: 0x206DE90 Offset: 0x206C890 VA: 0x18206DE90
	internal bool ColumnsEqual(DataKey key) { }

	// RVA: 0x206DDD0 Offset: 0x206C7D0 VA: 0x18206DDD0
	internal static bool ColumnsEqual(DataColumn[] column1, DataColumn[] column2) { }

	// RVA: 0x206DF50 Offset: 0x206C950 VA: 0x18206DF50
	internal bool ContainsColumn(DataColumn column) { }

	// RVA: 0x206E1D0 Offset: 0x206CBD0 VA: 0x18206E1D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x206E070 Offset: 0x206CA70 VA: 0x18206E070 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x206DFB0 Offset: 0x206C9B0 VA: 0x18206DFB0
	internal bool Equals(DataKey value) { }

	// RVA: 0x206E0F0 Offset: 0x206CAF0 VA: 0x18206E0F0
	internal string[] GetColumnNames() { }

	// RVA: 0x206E220 Offset: 0x206CC20 VA: 0x18206E220
	internal IndexField[] GetIndexDesc() { }

	// RVA: 0x206E340 Offset: 0x206CD40 VA: 0x18206E340
	internal object[] GetKeyValues(int record) { }

	// RVA: 0x206E4E0 Offset: 0x206CEE0 VA: 0x18206E4E0
	internal Index GetSortIndex() { }

	// RVA: 0x206E470 Offset: 0x206CE70 VA: 0x18206E470
	internal Index GetSortIndex(DataViewRowState recordStates) { }

	// RVA: 0x206E540 Offset: 0x206CF40 VA: 0x18206E540
	internal bool RecordsEqual(int record1, int record2) { }

	// RVA: 0x206E5F0 Offset: 0x206CFF0 VA: 0x18206E5F0
	internal DataColumn[] ToArray() { }
}
