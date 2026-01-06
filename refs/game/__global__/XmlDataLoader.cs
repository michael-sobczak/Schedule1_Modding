internal sealed class XmlDataLoader // TypeDefIndex: 12993
{
	// Fields
	private DataSet _dataSet; // 0x10
	private XmlToDatasetMap _nodeToSchemaMap; // 0x18
	private Hashtable _nodeToRowMap; // 0x20
	private Stack _childRowsStack; // 0x28
	private Hashtable _htableExcludedNS; // 0x30
	private bool _fIsXdr; // 0x38
	internal bool _isDiffgram; // 0x39
	private XmlElement _topMostNode; // 0x40
	private bool _ignoreSchema; // 0x48
	private DataTable _dataTable; // 0x50
	private bool _isTableLevel; // 0x58
	private bool _fromInference; // 0x59
	private XmlReader _dataReader; // 0x60
	private object _XSD_XMLNS_NS; // 0x68
	private object _XDR_SCHEMA; // 0x70
	private object _XDRNS; // 0x78
	private object _SQL_SYNC; // 0x80
	private object _UPDGNS; // 0x88
	private object _XSD_SCHEMA; // 0x90
	private object _XSDNS; // 0x98
	private object _DFFNS; // 0xA0
	private object _MSDNS; // 0xA8
	private object _DIFFID; // 0xB0
	private object _HASCHANGES; // 0xB8
	private object _ROWORDER; // 0xC0

	// Properties
	internal bool FromInference { get; set; }

	// Methods

	// RVA: 0x20C4AB0 Offset: 0x20C34B0 VA: 0x1820C4AB0
	internal void .ctor(DataSet dataset, bool IsXdr, bool ignoreSchema) { }

	// RVA: 0x20C4D20 Offset: 0x20C3720 VA: 0x1820C4D20
	internal void .ctor(DataSet dataset, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	// RVA: 0x20C4B50 Offset: 0x20C3550 VA: 0x1820C4B50
	internal void .ctor(DataTable datatable, bool IsXdr, bool ignoreSchema) { }

	// RVA: 0x20C4C10 Offset: 0x20C3610 VA: 0x1820C4C10
	internal void .ctor(DataTable datatable, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	// RVA: 0x79D110 Offset: 0x79BB10 VA: 0x18079D110
	internal bool get_FromInference() { }

	// RVA: 0x79D240 Offset: 0x79BC40 VA: 0x18079D240
	internal void set_FromInference(bool value) { }

	// RVA: 0x20BFAA0 Offset: 0x20BE4A0 VA: 0x1820BFAA0
	private void AttachRows(DataRow parentRow, XmlNode parentElement) { }

	// RVA: 0x20BFC30 Offset: 0x20BE630 VA: 0x1820BFC30
	private int CountNonNSAttributes(XmlNode node) { }

	// RVA: 0x20C0590 Offset: 0x20BEF90 VA: 0x1820C0590
	private string GetValueForTextOnlyColums(XmlNode n) { }

	// RVA: 0x20C0140 Offset: 0x20BEB40 VA: 0x1820C0140
	private string GetInitialTextFromNodes(ref XmlNode n) { }

	// RVA: 0x20C04E0 Offset: 0x20BEEE0 VA: 0x1820C04E0
	private DataColumn GetTextOnlyColumn(DataRow row) { }

	// RVA: 0x20C0440 Offset: 0x20BEE40 VA: 0x1820C0440
	internal DataRow GetRowFromElement(XmlElement e) { }

	// RVA: 0x20BFDD0 Offset: 0x20BE7D0 VA: 0x1820BFDD0
	internal bool FColumnElement(XmlElement e) { }

	// RVA: 0x20BFEF0 Offset: 0x20BE8F0 VA: 0x1820BFEF0
	private bool FExcludedNamespace(string ns) { }

	// RVA: 0x20C0020 Offset: 0x20BEA20 VA: 0x1820C0020
	private bool FIgnoreNamespace(XmlNode node) { }

	// RVA: 0x20BFF90 Offset: 0x20BE990 VA: 0x1820BFF90
	private bool FIgnoreNamespace(XmlReader node) { }

	// RVA: 0x20C0BC0 Offset: 0x20BF5C0 VA: 0x1820C0BC0
	internal bool IsTextLikeNode(XmlNodeType n) { }

	// RVA: 0x20C0C20 Offset: 0x20BF620 VA: 0x1820C0C20
	internal bool IsTextOnly(DataColumn c) { }

	// RVA: 0x20C1720 Offset: 0x20C0120 VA: 0x1820C1720
	internal void LoadData(XmlDocument xdoc) { }

	// RVA: 0x20C1E00 Offset: 0x20C0800 VA: 0x1820C1E00
	private void LoadRowData(DataRow row, XmlElement rowElement) { }

	// RVA: 0x20C2B90 Offset: 0x20C1590 VA: 0x1820C2B90
	private void LoadRows(DataRow parentRow, XmlNode parentElement) { }

	// RVA: 0x20C4A60 Offset: 0x20C3460 VA: 0x1820C4A60
	private void SetRowValueFromXmlText(DataRow row, DataColumn col, string xmlText) { }

	// RVA: 0x20C0870 Offset: 0x20BF270 VA: 0x1820C0870
	private void InitNameTable() { }

	// RVA: 0x20C1A10 Offset: 0x20C0410 VA: 0x1820C1A10
	internal void LoadData(XmlReader reader) { }

	// RVA: 0x20C3EB0 Offset: 0x20C28B0 VA: 0x1820C3EB0
	private void LoadTopMostTable(DataTable table) { }

	// RVA: 0x20C2F50 Offset: 0x20C1950 VA: 0x1820C2F50
	private void LoadTable(DataTable table, bool isNested) { }

	// RVA: 0x20C0C60 Offset: 0x20BF660 VA: 0x1820C0C60
	private void LoadColumn(DataColumn column, object[] foundColumns) { }

	// RVA: 0x20C4810 Offset: 0x20C3210 VA: 0x1820C4810
	private bool ProcessXsdSchema() { }
}
