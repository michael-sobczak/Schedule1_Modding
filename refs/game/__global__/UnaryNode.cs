internal sealed class UnaryNode : ExpressionNode // TypeDefIndex: 12951
{
	// Fields
	internal readonly int _op; // 0x18
	internal ExpressionNode _right; // 0x20

	// Methods

	// RVA: 0x20A70B0 Offset: 0x20A5AB0 VA: 0x1820A70B0
	internal void .ctor(DataTable table, int op, ExpressionNode right) { }

	// RVA: 0x20A6430 Offset: 0x20A4E30 VA: 0x1820A6430 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x2062180 Offset: 0x2060B80 VA: 0x182062180 Slot: 6
	internal override object Eval() { }

	// RVA: 0x20A6EB0 Offset: 0x20A58B0 VA: 0x1820A6EB0 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x20A6E80 Offset: 0x20A5880 VA: 0x1820A6E80 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x20A64C0 Offset: 0x20A4EC0 VA: 0x1820A64C0
	private object EvalUnaryOp(int op, object vl) { }

	// RVA: 0x20A6F60 Offset: 0x20A5960 VA: 0x1820A6F60 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x20A6F90 Offset: 0x20A5990 VA: 0x1820A6F90 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x20A6F00 Offset: 0x20A5900 VA: 0x1820A6F00 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x20A6F30 Offset: 0x20A5930 VA: 0x1820A6F30 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x20A6490 Offset: 0x20A4E90 VA: 0x1820A6490 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x20A6FC0 Offset: 0x20A59C0 VA: 0x1820A6FC0 Slot: 13
	internal override ExpressionNode Optimize() { }
}
