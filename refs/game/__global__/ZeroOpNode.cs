internal sealed class ZeroOpNode : ExpressionNode // TypeDefIndex: 12952
{
	// Fields
	internal readonly int _op; // 0x18

	// Methods

	// RVA: 0x20AEDF0 Offset: 0x20AD7F0 VA: 0x1820AEDF0
	internal void .ctor(int op) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x20AED50 Offset: 0x20AD750 VA: 0x1820AED50 Slot: 6
	internal override object Eval() { }

	// RVA: 0x5FF4F0 Offset: 0x5FDEF0 VA: 0x1805FF4F0 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x5FF4F0 Offset: 0x5FDEF0 VA: 0x1805FF4F0 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 13
	internal override ExpressionNode Optimize() { }
}
