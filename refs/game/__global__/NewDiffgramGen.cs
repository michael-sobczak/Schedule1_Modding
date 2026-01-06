internal sealed class NewDiffgramGen // TypeDefIndex: 13002
{
	// Fields
	internal XmlDocument _doc; // 0x10
	internal DataSet _ds; // 0x18
	internal DataTable _dt; // 0x20
	internal XmlWriter _xmlw; // 0x28
	private bool _fBefore; // 0x30
	private bool _fErrors; // 0x31
	internal Hashtable _rowsOrder; // 0x38
	private ArrayList _tables; // 0x40
	private bool _writeHierarchy; // 0x48

	// Methods

	// RVA: 0x20CA550 Offset: 0x20C8F50 VA: 0x1820CA550
	internal void .ctor(DataSet ds) { }

	// RVA: 0x20CA420 Offset: 0x20C8E20 VA: 0x1820CA420
	internal void .ctor(DataTable dt, bool writeHierarchy) { }

	// RVA: 0x20C8040 Offset: 0x20C6A40 VA: 0x1820C8040
	private void CreateTableHierarchy(DataTable dt) { }

	// RVA: 0x20C8310 Offset: 0x20C6D10 VA: 0x1820C8310
	private void DoAssignments(ArrayList tables) { }

	// RVA: 0x20C8590 Offset: 0x20C6F90 VA: 0x1820C8590
	private bool EmptyData() { }

	// RVA: 0x20CA410 Offset: 0x20C8E10 VA: 0x1820CA410
	internal void Save(XmlWriter xmlw) { }

	// RVA: 0x20C9D80 Offset: 0x20C8780 VA: 0x1820C9D80
	internal void Save(XmlWriter xmlw, DataTable table) { }

	// RVA: 0x20C9C90 Offset: 0x20C8690 VA: 0x1820C9C90
	private void GenerateTable(DataTable table) { }

	// RVA: 0x20C96B0 Offset: 0x20C80B0 VA: 0x1820C96B0
	private void GenerateTableErrors(DataTable table) { }

	// RVA: 0x20C9040 Offset: 0x20C7A40 VA: 0x1820C9040
	private void GenerateRow(DataRow row) { }

	// RVA: 0x20C86B0 Offset: 0x20C70B0 VA: 0x1820C86B0
	private void GenerateColumn(DataRow row, DataColumn col, DataRowVersion version) { }

	// RVA: 0x20C9D20 Offset: 0x20C8720 VA: 0x1820C9D20
	internal static string QualifiedName(string prefix, string name) { }
}
