internal sealed class XmlToDatasetMap // TypeDefIndex: 12998
{
	// Fields
	private XmlToDatasetMap.XmlNodeIdHashtable _tableSchemaMap; // 0x10
	private XmlToDatasetMap.TableSchemaInfo _lastTableSchemaInfo; // 0x18

	// Methods

	// RVA: 0x20C76A0 Offset: 0x20C60A0 VA: 0x1820C76A0
	public void .ctor(DataSet dataSet, XmlNameTable nameTable) { }

	// RVA: 0x20C7620 Offset: 0x20C6020 VA: 0x1820C7620
	public void .ctor(XmlNameTable nameTable, DataSet dataSet) { }

	// RVA: 0x20C76E0 Offset: 0x20C60E0 VA: 0x1820C76E0
	public void .ctor(DataTable dataTable, XmlNameTable nameTable) { }

	// RVA: 0x20C7660 Offset: 0x20C6060 VA: 0x1820C7660
	public void .ctor(XmlNameTable nameTable, DataTable dataTable) { }

	// RVA: 0x20C75F0 Offset: 0x20C5FF0 VA: 0x1820C75F0
	internal static bool IsMappedColumn(DataColumn c) { }

	// RVA: 0x20C5450 Offset: 0x20C3E50 VA: 0x1820C5450
	private XmlToDatasetMap.TableSchemaInfo AddTableSchema(DataTable table, XmlNameTable nameTable) { }

	// RVA: 0x20C5590 Offset: 0x20C3F90 VA: 0x1820C5590
	private XmlToDatasetMap.TableSchemaInfo AddTableSchema(XmlNameTable nameTable, DataTable table) { }

	// RVA: 0x20C50E0 Offset: 0x20C3AE0 VA: 0x1820C50E0
	private bool AddColumnSchema(DataColumn col, XmlNameTable nameTable, XmlToDatasetMap.XmlNodeIdHashtable columns) { }

	// RVA: 0x20C5240 Offset: 0x20C3C40 VA: 0x1820C5240
	private bool AddColumnSchema(XmlNameTable nameTable, DataColumn col, XmlToDatasetMap.XmlNodeIdHashtable columns) { }

	// RVA: 0x20C5750 Offset: 0x20C4150 VA: 0x1820C5750
	private void BuildIdentityMap(DataSet dataSet, XmlNameTable nameTable) { }

	// RVA: 0x20C5DD0 Offset: 0x20C47D0 VA: 0x1820C5DD0
	private void BuildIdentityMap(XmlNameTable nameTable, DataSet dataSet) { }

	// RVA: 0x20C5B10 Offset: 0x20C4510 VA: 0x1820C5B10
	private void BuildIdentityMap(DataTable dataTable, XmlNameTable nameTable) { }

	// RVA: 0x20C6500 Offset: 0x20C4F00 VA: 0x1820C6500
	private void BuildIdentityMap(XmlNameTable nameTable, DataTable dataTable) { }

	// RVA: 0x20C7080 Offset: 0x20C5A80 VA: 0x1820C7080
	private ArrayList GetSelfAndDescendants(DataTable dt) { }

	// RVA: 0x20C6BF0 Offset: 0x20C55F0 VA: 0x1820C6BF0
	public object GetColumnSchema(XmlNode node, bool fIgnoreNamespace) { }

	// RVA: 0x20C6E00 Offset: 0x20C5800 VA: 0x1820C6E00
	public object GetColumnSchema(DataTable table, XmlReader dataReader, bool fIgnoreNamespace) { }

	// RVA: 0x20C6F80 Offset: 0x20C5980 VA: 0x1820C6F80
	public object GetSchemaForNode(XmlNode node, bool fIgnoreNamespace) { }

	// RVA: 0x20C7370 Offset: 0x20C5D70 VA: 0x1820C7370
	public DataTable GetTableForNode(XmlReader node, bool fIgnoreNamespace) { }

	// RVA: 0x20C7460 Offset: 0x20C5E60 VA: 0x1820C7460
	private void HandleSpecialColumn(DataColumn col, XmlNameTable nameTable, XmlToDatasetMap.XmlNodeIdHashtable columns) { }
}
