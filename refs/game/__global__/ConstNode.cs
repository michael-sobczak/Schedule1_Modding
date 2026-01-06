internal sealed class ConstNode : ExpressionNode // TypeDefIndex: 12934
{
	// Fields
	internal readonly object _val; // 0x18

	// Methods

	// RVA: 0x2088380 Offset: 0x2086D80 VA: 0x182088380
	internal void .ctor(DataTable table, ValueType type, object constant) { }

	// RVA: 0x2088010 Offset: 0x2086A10 VA: 0x182088010
	internal void .ctor(DataTable table, ValueType type, object constant, bool fParseQuotes) { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 6
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

	// RVA: 0x2087A60 Offset: 0x2086460 VA: 0x182087A60
	private object SmallestDecimal(object constant) { }

	// RVA: 0x2087CF0 Offset: 0x20866F0 VA: 0x182087CF0
	private object SmallestNumeric(object constant) { }
}
