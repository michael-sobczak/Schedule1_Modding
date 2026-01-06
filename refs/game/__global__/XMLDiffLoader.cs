internal sealed class XMLDiffLoader // TypeDefIndex: 12987
{
	// Fields
	private ArrayList _tables; // 0x10
	private DataSet _dataSet; // 0x18
	private DataTable _dataTable; // 0x20

	// Methods

	// RVA: 0x20AC950 Offset: 0x20AB350 VA: 0x1820AC950
	internal void LoadDiffGram(DataSet ds, XmlReader dataTextReader) { }

	// RVA: 0x20AC470 Offset: 0x20AAE70 VA: 0x1820AC470
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0x20ACAF0 Offset: 0x20AB4F0 VA: 0x1820ACAF0
	internal void LoadDiffGram(DataTable dt, XmlReader dataTextReader) { }

	// RVA: 0x20ACD00 Offset: 0x20AB700 VA: 0x1820ACD00
	internal void ProcessDiffs(DataSet ds, XmlReader ssync) { }

	// RVA: 0x20AD0B0 Offset: 0x20ABAB0 VA: 0x1820AD0B0
	internal void ProcessDiffs(ArrayList tableList, XmlReader ssync) { }

	// RVA: 0x20AD960 Offset: 0x20AC360 VA: 0x1820AD960
	internal void ProcessErrors(DataSet ds, XmlReader ssync) { }

	// RVA: 0x20AD410 Offset: 0x20ABE10 VA: 0x1820AD410
	internal void ProcessErrors(ArrayList dt, XmlReader ssync) { }

	// RVA: 0x20AC740 Offset: 0x20AB140 VA: 0x1820AC740
	private DataTable GetTable(string tableName, string ns) { }

	// RVA: 0x20ADD80 Offset: 0x20AC780 VA: 0x1820ADD80
	private int ReadOldRowData(DataSet ds, ref DataTable table, ref int pos, XmlReader row) { }

	// RVA: 0x20AECE0 Offset: 0x20AD6E0 VA: 0x1820AECE0
	internal void SkipWhitespaces(XmlReader reader) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
