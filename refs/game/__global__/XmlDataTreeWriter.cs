internal sealed class XmlDataTreeWriter // TypeDefIndex: 13003
{
	// Fields
	private XmlWriter _xmlw; // 0x10
	private DataSet _ds; // 0x18
	private DataTable _dt; // 0x20
	private ArrayList _dTables; // 0x28
	private DataTable[] _topLevelTables; // 0x30
	private bool _fFromTable; // 0x38
	private bool _isDiffgram; // 0x39
	private Hashtable _rowsOrder; // 0x40
	private bool _writeHierarchy; // 0x48

	// Methods

	// RVA: 0x20CFCF0 Offset: 0x20CE6F0 VA: 0x1820CFCF0
	internal void .ctor(DataSet ds) { }

	// RVA: 0x20CFAF0 Offset: 0x20CE4F0 VA: 0x1820CFAF0
	internal void .ctor(DataTable dt, bool writeHierarchy) { }

	// RVA: 0x20CD080 Offset: 0x20CBA80 VA: 0x1820CD080
	private DataTable[] CreateToplevelTables() { }

	// RVA: 0x20CCDB0 Offset: 0x20CB7B0 VA: 0x1820CCDB0
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0x20CD6D0 Offset: 0x20CC0D0 VA: 0x1820CD6D0
	internal static bool RowHasErrors(DataRow row) { }

	// RVA: 0x20CD7B0 Offset: 0x20CC1B0 VA: 0x1820CD7B0
	internal void SaveDiffgramData(XmlWriter xw, Hashtable rowsOrder) { }

	// RVA: 0x20CDD70 Offset: 0x20CC770 VA: 0x1820CDD70
	internal void Save(XmlWriter xw, bool writeSchema) { }

	// RVA: 0x20CD380 Offset: 0x20CBD80 VA: 0x1820CD380
	private ArrayList GetNestedChildRelations(DataRow row) { }

	// RVA: 0x20CE5B0 Offset: 0x20CCFB0 VA: 0x1820CE5B0
	internal void XmlDataRowWriter(DataRow row, string encodedTableName) { }

	// RVA: 0x20CD620 Offset: 0x20CC020 VA: 0x1820CD620
	internal static bool PreserveSpace(object value) { }
}
