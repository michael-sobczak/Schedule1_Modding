public class DataRelation // TypeDefIndex: 12893
{
	// Fields
	private DataSet _dataSet; // 0x10
	internal PropertyCollection _extendedProperties; // 0x18
	internal string _relationName; // 0x20
	private DataKey _childKey; // 0x28
	private DataKey _parentKey; // 0x30
	private UniqueConstraint _parentKeyConstraint; // 0x38
	private ForeignKeyConstraint _childKeyConstraint; // 0x40
	internal string[] _parentColumnNames; // 0x48
	internal string[] _childColumnNames; // 0x50
	internal string _parentTableName; // 0x58
	internal string _childTableName; // 0x60
	internal string _parentTableNamespace; // 0x68
	internal string _childTableNamespace; // 0x70
	internal bool _nested; // 0x78
	internal bool _createConstraints; // 0x79
	private bool _checkMultipleNested; // 0x7A
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x7C
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanging; // 0x80

	// Properties
	public virtual DataColumn[] ChildColumns { get; }
	internal DataColumn[] ChildColumnsReference { get; }
	internal DataKey ChildKey { get; }
	public virtual DataTable ChildTable { get; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public virtual DataSet DataSet { get; }
	internal string[] ParentColumnNames { get; }
	internal string[] ChildColumnNames { get; }
	public virtual DataColumn[] ParentColumns { get; }
	internal DataColumn[] ParentColumnsReference { get; }
	internal DataKey ParentKey { get; }
	public virtual DataTable ParentTable { get; }
	[DefaultValue("")]
	public virtual string RelationName { get; }
	[DefaultValue(False)]
	public virtual bool Nested { get; set; }
	public virtual UniqueConstraint ParentKeyConstraint { get; }
	public virtual ForeignKeyConstraint ChildKeyConstraint { get; }
	[Browsable(False)]
	public PropertyCollection ExtendedProperties { get; }
	internal bool CheckMultipleNested { get; set; }
	internal int ObjectID { get; }

	// Methods

	// RVA: 0x20725F0 Offset: 0x2070FF0 VA: 0x1820725F0
	public void .ctor(string relationName, DataColumn parentColumn, DataColumn childColumn, bool createConstraints) { }

	// RVA: 0x2072910 Offset: 0x2071310 VA: 0x182072910
	public void .ctor(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x2072840 Offset: 0x2071240 VA: 0x182072840
	public void .ctor(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	[Browsable(False)]
	// RVA: 0x2072A60 Offset: 0x2071460 VA: 0x182072A60
	public void .ctor(string relationName, string parentTableName, string childTableName, string[] parentColumnNames, string[] childColumnNames, bool nested) { }

	[Browsable(False)]
	// RVA: 0x2072930 Offset: 0x2071330 VA: 0x182072930
	public void .ctor(string relationName, string parentTableName, string parentTableNamespace, string childTableName, string childTableNamespace, string[] parentColumnNames, string[] childColumnNames, bool nested) { }

	// RVA: 0x2072B90 Offset: 0x2071590 VA: 0x182072B90 Slot: 4
	public virtual DataColumn[] get_ChildColumns() { }

	// RVA: 0x2072B70 Offset: 0x2071570 VA: 0x182072B70
	internal DataColumn[] get_ChildColumnsReference() { }

	// RVA: 0x2072B70 Offset: 0x2071570 VA: 0x182072B70
	internal DataKey get_ChildKey() { }

	// RVA: 0x2072BD0 Offset: 0x20715D0 VA: 0x182072BD0 Slot: 5
	public virtual DataTable get_ChildTable() { }

	// RVA: 0x2072C10 Offset: 0x2071610 VA: 0x182072C10 Slot: 6
	public virtual DataSet get_DataSet() { }

	// RVA: 0x2072CC0 Offset: 0x20716C0 VA: 0x182072CC0
	internal string[] get_ParentColumnNames() { }

	// RVA: 0x2072B60 Offset: 0x2071560 VA: 0x182072B60
	internal string[] get_ChildColumnNames() { }

	// RVA: 0x2071EE0 Offset: 0x20708E0 VA: 0x182071EE0
	private static bool IsKeyNull(object[] values) { }

	// RVA: 0x20717E0 Offset: 0x20701E0 VA: 0x1820717E0
	internal static DataRow[] GetChildRows(DataKey parentKey, DataKey childKey, DataRow parentRow, DataRowVersion version) { }

	// RVA: 0x2071B80 Offset: 0x2070580 VA: 0x182071B80
	internal static DataRow[] GetParentRows(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	// RVA: 0x2071970 Offset: 0x2070370 VA: 0x182071970
	internal static DataRow GetParentRow(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	// RVA: 0x2072170 Offset: 0x2070B70 VA: 0x182072170
	internal void SetDataSet(DataSet dataSet) { }

	// RVA: 0x2072CD0 Offset: 0x20716D0 VA: 0x182072CD0 Slot: 7
	public virtual DataColumn[] get_ParentColumns() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	internal DataColumn[] get_ParentColumnsReference() { }

	// RVA: 0x2072D10 Offset: 0x2071710 VA: 0x182072D10
	internal DataKey get_ParentKey() { }

	// RVA: 0x2072D30 Offset: 0x2071730 VA: 0x182072D30 Slot: 8
	public virtual DataTable get_ParentTable() { }

	// RVA: 0x2072D70 Offset: 0x2071770 VA: 0x182072D70 Slot: 9
	public virtual string get_RelationName() { }

	// RVA: 0x2070300 Offset: 0x206ED00 VA: 0x182070300
	internal void CheckNamespaceValidityForNestedRelations(string ns) { }

	// RVA: 0x2070590 Offset: 0x206EF90 VA: 0x182070590
	internal void CheckNestedRelations() { }

	// RVA: 0x2072CA0 Offset: 0x20716A0 VA: 0x182072CA0 Slot: 10
	public virtual bool get_Nested() { }

	// RVA: 0x2072D90 Offset: 0x2071790 VA: 0x182072D90 Slot: 11
	public virtual void set_Nested(bool value) { }

	// RVA: 0x2072CF0 Offset: 0x20716F0 VA: 0x182072CF0 Slot: 12
	public virtual UniqueConstraint get_ParentKeyConstraint() { }

	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	internal void SetParentKeyConstraint(UniqueConstraint value) { }

	// RVA: 0x2072BB0 Offset: 0x20715B0 VA: 0x182072BB0 Slot: 13
	public virtual ForeignKeyConstraint get_ChildKeyConstraint() { }

	// RVA: 0x2072C30 Offset: 0x2071630 VA: 0x182072C30
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x1E019E0 Offset: 0x1E003E0 VA: 0x181E019E0
	internal bool get_CheckMultipleNested() { }

	// RVA: 0x1E01CF0 Offset: 0x1E006F0 VA: 0x181E01CF0
	internal void set_CheckMultipleNested(bool value) { }

	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	internal void SetChildKeyConstraint(ForeignKeyConstraint value) { }

	// RVA: 0x2070AD0 Offset: 0x206F4D0 VA: 0x182070AD0
	internal void CheckState() { }

	// RVA: 0x20709D0 Offset: 0x206F3D0 VA: 0x1820709D0
	protected void CheckStateForProperty() { }

	// RVA: 0x20714E0 Offset: 0x206FEE0 VA: 0x1820714E0
	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	// RVA: 0x2070DC0 Offset: 0x206F7C0 VA: 0x182070DC0
	internal DataRelation Clone(DataSet destination) { }

	// RVA: 0x2071F90 Offset: 0x2070990 VA: 0x182071F90
	protected internal void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0x2072060 Offset: 0x2070A60 VA: 0x182072060
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0x4BC030 Offset: 0x4BAA30 VA: 0x1804BC030 Slot: 3
	public override string ToString() { }

	// RVA: 0x2072190 Offset: 0x2070B90 VA: 0x182072190
	internal void ValidateMultipleNestedRelations() { }

	// RVA: 0x2071D10 Offset: 0x2070710 VA: 0x182071D10
	private bool IsAutoGenerated(DataColumn col) { }

	// RVA: 0x6A4D90 Offset: 0x6A3790 VA: 0x1806A4D90
	internal int get_ObjectID() { }
}
