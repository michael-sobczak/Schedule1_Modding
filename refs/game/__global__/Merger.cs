internal sealed class Merger // TypeDefIndex: 12957
{
	// Fields
	private DataSet _dataSet; // 0x10
	private DataTable _dataTable; // 0x18
	private bool _preserveChanges; // 0x20
	private MissingSchemaAction _missingSchemaAction; // 0x24
	private bool _isStandAlonetable; // 0x28
	private bool _IgnoreNSforTableLookup; // 0x29

	// Methods

	// RVA: 0x20A1190 Offset: 0x209FB90 VA: 0x1820A1190
	internal void .ctor(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0x20A1120 Offset: 0x209FB20 VA: 0x1820A1120
	internal void .ctor(DataTable dataTable, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0x209E8A0 Offset: 0x209D2A0 VA: 0x18209E8A0
	internal void MergeDataSet(DataSet source) { }

	// RVA: 0x20A0900 Offset: 0x209F300 VA: 0x1820A0900
	internal void MergeTable(DataTable src) { }

	// RVA: 0x20A0B70 Offset: 0x209F570 VA: 0x1820A0B70
	private void MergeTable(DataTable src, DataTable dst) { }

	// RVA: 0x209FFA0 Offset: 0x209E9A0 VA: 0x18209FFA0
	private DataTable MergeSchema(DataTable table) { }

	// RVA: 0x20A0860 Offset: 0x209F260 VA: 0x1820A0860
	private void MergeTableData(DataTable src) { }

	// RVA: 0x209E540 Offset: 0x209CF40 VA: 0x18209E540
	private void MergeConstraints(DataSet source) { }

	// RVA: 0x209E5D0 Offset: 0x209CFD0 VA: 0x18209E5D0
	private void MergeConstraints(DataTable table) { }

	// RVA: 0x209F6B0 Offset: 0x209E0B0 VA: 0x18209F6B0
	private void MergeRelation(DataRelation relation) { }

	// RVA: 0x209F4F0 Offset: 0x209DEF0 VA: 0x18209F4F0
	private void MergeExtendedProperties(PropertyCollection src, PropertyCollection dst) { }

	// RVA: 0x209E3A0 Offset: 0x209CDA0 VA: 0x18209E3A0
	private DataKey GetSrcKey(DataTable src, DataTable dst) { }
}
