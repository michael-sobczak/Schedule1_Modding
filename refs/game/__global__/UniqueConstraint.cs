public class UniqueConstraint : Constraint // TypeDefIndex: 12984
{
	// Fields
	private DataKey _key; // 0x38
	private Index _constraintIndex; // 0x40
	internal bool _bPrimaryKey; // 0x48
	internal string _constraintName; // 0x50
	internal string[] _columnNames; // 0x58

	// Properties
	internal string[] ColumnNames { get; }
	internal Index ConstraintIndex { get; }
	[ReadOnly(True)]
	public virtual DataColumn[] Columns { get; }
	internal DataColumn[] ColumnsReference { get; }
	public bool IsPrimaryKey { get; }
	internal override bool InCollection { set; }
	internal DataKey Key { get; }
	[ReadOnly(True)]
	public override DataTable Table { get; }

	// Methods

	// RVA: 0x20A83D0 Offset: 0x20A6DD0 VA: 0x1820A83D0
	public void .ctor(DataColumn column) { }

	// RVA: 0x20A8490 Offset: 0x20A6E90 VA: 0x1820A8490
	public void .ctor(string name, DataColumn[] columns) { }

	// RVA: 0x20A8390 Offset: 0x20A6D90 VA: 0x1820A8390
	public void .ctor(DataColumn[] columns) { }

	[Browsable(False)]
	// RVA: 0x20A8520 Offset: 0x20A6F20 VA: 0x1820A8520
	public void .ctor(string name, string[] columnNames, bool isPrimaryKey) { }

	// RVA: 0x20A84D0 Offset: 0x20A6ED0 VA: 0x1820A84D0
	public void .ctor(string name, DataColumn[] columns, bool isPrimaryKey) { }

	// RVA: 0x20A8590 Offset: 0x20A6F90 VA: 0x1820A8590
	internal string[] get_ColumnNames() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	internal Index get_ConstraintIndex() { }

	// RVA: 0x20A7E40 Offset: 0x20A6840 VA: 0x1820A7E40
	internal void ConstraintIndexClear() { }

	// RVA: 0x20A7E80 Offset: 0x20A6880 VA: 0x1820A7E80
	internal void ConstraintIndexInitialize() { }

	// RVA: 0x20A7520 Offset: 0x20A5F20 VA: 0x1820A7520 Slot: 16
	internal override void CheckState() { }

	// RVA: 0x20A7520 Offset: 0x20A5F20 VA: 0x1820A7520
	private void NonVirtualCheckState() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 13
	internal override void CheckCanAddToCollection(ConstraintCollection constraints) { }

	// RVA: 0x20A7100 Offset: 0x20A5B00 VA: 0x1820A7100 Slot: 14
	internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	// RVA: 0x20A72C0 Offset: 0x20A5CC0 VA: 0x1820A72C0 Slot: 10
	internal override bool CanEnableConstraint() { }

	// RVA: 0x20A80B0 Offset: 0x20A6AB0 VA: 0x1820A80B0 Slot: 18
	internal override bool IsConstraintViolated() { }

	// RVA: 0x20A7340 Offset: 0x20A5D40 VA: 0x1820A7340 Slot: 15
	internal override void CheckConstraint(DataRow row, DataRowAction action) { }

	// RVA: 0x20A7ED0 Offset: 0x20A68D0 VA: 0x1820A7ED0 Slot: 9
	internal override bool ContainsColumn(DataColumn column) { }

	// RVA: 0x20991A0 Offset: 0x2097BA0 VA: 0x1820991A0 Slot: 11
	internal override Constraint Clone(DataSet destination) { }

	// RVA: 0x20A7960 Offset: 0x20A6360 VA: 0x1820A7960 Slot: 12
	internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	// RVA: 0x20A7530 Offset: 0x20A5F30 VA: 0x1820A7530
	internal UniqueConstraint Clone(DataTable table) { }

	// RVA: 0x20A85A0 Offset: 0x20A6FA0 VA: 0x1820A85A0 Slot: 19
	public virtual DataColumn[] get_Columns() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	internal DataColumn[] get_ColumnsReference() { }

	// RVA: 0x20A85B0 Offset: 0x20A6FB0 VA: 0x1820A85B0
	public bool get_IsPrimaryKey() { }

	// RVA: 0x20A7EE0 Offset: 0x20A68E0 VA: 0x1820A7EE0
	private void Create(string constraintName, DataColumn[] columns) { }

	// RVA: 0x20A7FF0 Offset: 0x20A69F0 VA: 0x1820A7FF0 Slot: 0
	public override bool Equals(object key2) { }

	// RVA: 0x1ACA830 Offset: 0x1AC9230 VA: 0x181ACA830 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20A8640 Offset: 0x20A7040 VA: 0x1820A8640 Slot: 7
	internal override void set_InCollection(bool value) { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	internal DataKey get_Key() { }

	// RVA: 0x20A8610 Offset: 0x20A7010 VA: 0x1820A8610 Slot: 8
	public override DataTable get_Table() { }
}
