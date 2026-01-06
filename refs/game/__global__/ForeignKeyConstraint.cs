public class ForeignKeyConstraint : Constraint // TypeDefIndex: 12953
{
	// Fields
	internal Rule _deleteRule; // 0x38
	internal Rule _updateRule; // 0x3C
	internal AcceptRejectRule _acceptRejectRule; // 0x40
	private DataKey _childKey; // 0x48
	private DataKey _parentKey; // 0x50
	internal string _constraintName; // 0x58
	internal string[] _parentColumnNames; // 0x60
	internal string[] _childColumnNames; // 0x68
	internal string _parentTableName; // 0x70

	// Properties
	internal DataKey ChildKey { get; }
	[ReadOnly(True)]
	public virtual DataColumn[] Columns { get; }
	[ReadOnly(True)]
	public override DataTable Table { get; }
	internal string[] ParentColumnNames { get; }
	internal string[] ChildColumnNames { get; }
	[DefaultValue(0)]
	public virtual AcceptRejectRule AcceptRejectRule { get; set; }
	[DefaultValue(1)]
	public virtual Rule DeleteRule { get; set; }
	[ReadOnly(True)]
	public virtual DataColumn[] RelatedColumns { get; }
	internal DataColumn[] RelatedColumnsReference { get; }
	internal DataKey ParentKey { get; }
	[ReadOnly(True)]
	public virtual DataTable RelatedTable { get; }
	[DefaultValue(1)]
	public virtual Rule UpdateRule { get; set; }

	// Methods

	// RVA: 0x2099CF0 Offset: 0x20986F0 VA: 0x182099CF0
	public void .ctor(DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x2099D50 Offset: 0x2098750 VA: 0x182099D50
	public void .ctor(string constraintName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	[Browsable(False)]
	// RVA: 0x2099C40 Offset: 0x2098640 VA: 0x182099C40
	public void .ctor(string constraintName, string parentTableName, string[] parentColumnNames, string[] childColumnNames, AcceptRejectRule acceptRejectRule, Rule deleteRule, Rule updateRule) { }

	// RVA: 0x2099DF0 Offset: 0x20987F0 VA: 0x182099DF0
	internal DataKey get_ChildKey() { }

	// RVA: 0x2099E10 Offset: 0x2098810 VA: 0x182099E10 Slot: 19
	public virtual DataColumn[] get_Columns() { }

	// RVA: 0x2099EC0 Offset: 0x20988C0 VA: 0x182099EC0 Slot: 8
	public override DataTable get_Table() { }

	// RVA: 0x2099E50 Offset: 0x2098850 VA: 0x182099E50
	internal string[] get_ParentColumnNames() { }

	// RVA: 0x2099DE0 Offset: 0x20987E0 VA: 0x182099DE0
	internal string[] get_ChildColumnNames() { }

	// RVA: 0x2097BD0 Offset: 0x20965D0 VA: 0x182097BD0 Slot: 13
	internal override void CheckCanAddToCollection(ConstraintCollection constraints) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 14
	internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	// RVA: 0x20998D0 Offset: 0x20982D0 VA: 0x1820998D0
	internal bool IsKeyNull(object[] values) { }

	// RVA: 0x2099630 Offset: 0x2098030 VA: 0x182099630 Slot: 18
	internal override bool IsConstraintViolated() { }

	// RVA: 0x2096AA0 Offset: 0x20954A0 VA: 0x182096AA0 Slot: 10
	internal override bool CanEnableConstraint() { }

	// RVA: 0x2096CB0 Offset: 0x20956B0 VA: 0x182096CB0
	internal void CascadeCommit(DataRow row) { }

	// RVA: 0x2096E30 Offset: 0x2095830 VA: 0x182096E30
	internal void CascadeDelete(DataRow row) { }

	// RVA: 0x20973E0 Offset: 0x2095DE0 VA: 0x1820973E0
	internal void CascadeRollback(DataRow row) { }

	// RVA: 0x2097640 Offset: 0x2096040 VA: 0x182097640
	internal void CascadeUpdate(DataRow row) { }

	// RVA: 0x2097D50 Offset: 0x2096750 VA: 0x182097D50
	internal void CheckCanClearParentTable(DataTable table) { }

	// RVA: 0x2097E60 Offset: 0x2096860 VA: 0x182097E60
	internal void CheckCanRemoveParentRow(DataRow row) { }

	// RVA: 0x2097F20 Offset: 0x2096920 VA: 0x182097F20
	internal void CheckCascade(DataRow row, DataRowAction action) { }

	// RVA: 0x2098220 Offset: 0x2096C20 VA: 0x182098220 Slot: 15
	internal override void CheckConstraint(DataRow childRow, DataRowAction action) { }

	// RVA: 0x2099980 Offset: 0x2098380 VA: 0x182099980
	private void NonVirtualCheckState() { }

	// RVA: 0x2098510 Offset: 0x2096F10 VA: 0x182098510 Slot: 16
	internal override void CheckState() { }

	// RVA: 0x2099DC0 Offset: 0x20987C0 VA: 0x182099DC0 Slot: 20
	public virtual AcceptRejectRule get_AcceptRejectRule() { }

	// RVA: 0x2099F00 Offset: 0x2098900 VA: 0x182099F00 Slot: 21
	public virtual void set_AcceptRejectRule(AcceptRejectRule value) { }

	// RVA: 0x20991C0 Offset: 0x2097BC0 VA: 0x1820991C0 Slot: 9
	internal override bool ContainsColumn(DataColumn column) { }

	// RVA: 0x20991A0 Offset: 0x2097BA0 VA: 0x1820991A0 Slot: 11
	internal override Constraint Clone(DataSet destination) { }

	// RVA: 0x2098520 Offset: 0x2096F20 VA: 0x182098520 Slot: 12
	internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	// RVA: 0x2098BE0 Offset: 0x20975E0 VA: 0x182098BE0
	internal ForeignKeyConstraint Clone(DataTable destination) { }

	// RVA: 0x2099210 Offset: 0x2097C10 VA: 0x182099210
	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x2099E30 Offset: 0x2098830 VA: 0x182099E30 Slot: 22
	public virtual Rule get_DeleteRule() { }

	// RVA: 0x2099F50 Offset: 0x2098950 VA: 0x182099F50 Slot: 23
	public virtual void set_DeleteRule(Rule value) { }

	// RVA: 0x2099430 Offset: 0x2097E30 VA: 0x182099430 Slot: 0
	public override bool Equals(object key) { }

	// RVA: 0x1ACA830 Offset: 0x1AC9230 VA: 0x181ACA830 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2099E80 Offset: 0x2098880 VA: 0x182099E80 Slot: 24
	public virtual DataColumn[] get_RelatedColumns() { }

	// RVA: 0x2099E60 Offset: 0x2098860 VA: 0x182099E60
	internal DataColumn[] get_RelatedColumnsReference() { }

	// RVA: 0x2099E60 Offset: 0x2098860 VA: 0x182099E60
	internal DataKey get_ParentKey() { }

	// RVA: 0x2099540 Offset: 0x2097F40 VA: 0x182099540
	internal DataRelation FindParentRelation() { }

	// RVA: 0x2099EA0 Offset: 0x20988A0 VA: 0x182099EA0 Slot: 25
	public virtual DataTable get_RelatedTable() { }

	// RVA: 0x2099EE0 Offset: 0x20988E0 VA: 0x182099EE0 Slot: 26
	public virtual Rule get_UpdateRule() { }

	// RVA: 0x2099FA0 Offset: 0x20989A0 VA: 0x182099FA0 Slot: 27
	public virtual void set_UpdateRule(Rule value) { }
}
