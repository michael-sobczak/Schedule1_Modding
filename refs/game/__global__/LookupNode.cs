internal sealed class LookupNode : ExpressionNode // TypeDefIndex: 12948
{
	// Fields
	private readonly string _relationName; // 0x18
	private readonly string _columnName; // 0x20
	private DataColumn _column; // 0x28
	private DataRelation _relation; // 0x30

	// Methods

	// RVA: 0x209E2C0 Offset: 0x209CCC0 VA: 0x18209E2C0
	internal void .ctor(DataTable table, string columnName, string relationName) { }

	// RVA: 0x209DE60 Offset: 0x209C860 VA: 0x18209DE60 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x209E130 Offset: 0x209CB30 VA: 0x18209E130 Slot: 6
	internal override object Eval() { }

	// RVA: 0x209E1A0 Offset: 0x209CBA0 VA: 0x18209E1A0 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x209E160 Offset: 0x209CB60 VA: 0x18209E160 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x209E120 Offset: 0x209CB20 VA: 0x18209E120 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 13
	internal override ExpressionNode Optimize() { }
}
