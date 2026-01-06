internal sealed class AggregateNode : ExpressionNode // TypeDefIndex: 12930
{
	// Fields
	private readonly AggregateType _type; // 0x18
	private readonly Aggregate _aggregate; // 0x1C
	private readonly bool _local; // 0x20
	private readonly string _relationName; // 0x28
	private readonly string _columnName; // 0x30
	private DataTable _childTable; // 0x38
	private DataColumn _column; // 0x40
	private DataRelation _relation; // 0x48

	// Methods

	// RVA: 0x2080880 Offset: 0x207F280 VA: 0x182080880
	internal void .ctor(DataTable table, FunctionId aggregateType, string columnName) { }

	// RVA: 0x2080740 Offset: 0x207F140 VA: 0x182080740
	internal void .ctor(DataTable table, FunctionId aggregateType, string columnName, bool local, string relationName) { }

	// RVA: 0x207FDC0 Offset: 0x207E7C0 VA: 0x18207FDC0 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x20801A0 Offset: 0x207EBA0 VA: 0x1820801A0
	internal static void Bind(DataRelation relation, List<DataColumn> list) { }

	// RVA: 0x2062180 Offset: 0x2060B80 VA: 0x182062180 Slot: 6
	internal override object Eval() { }

	// RVA: 0x2080430 Offset: 0x207EE30 VA: 0x182080430 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x2080390 Offset: 0x207ED90 VA: 0x182080390 Slot: 8
	internal override object Eval(int[] records) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0xAA87F0 Offset: 0xAA71F0 VA: 0x180AA87F0 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x2080300 Offset: 0x207ED00 VA: 0x182080300 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 13
	internal override ExpressionNode Optimize() { }
}
