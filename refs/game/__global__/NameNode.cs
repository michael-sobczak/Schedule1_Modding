internal sealed class NameNode : ExpressionNode // TypeDefIndex: 12949
{
	// Fields
	internal string _name; // 0x18
	internal bool _found; // 0x20
	internal DataColumn _column; // 0x28

	// Properties
	internal override bool IsSqlColumn { get; }

	// Methods

	// RVA: 0x20A1950 Offset: 0x20A0350 VA: 0x1820A1950
	internal void .ctor(DataTable table, char[] text, int start, int pos) { }

	// RVA: 0x20A19B0 Offset: 0x20A03B0 VA: 0x1820A19B0
	internal void .ctor(DataTable table, string name) { }

	// RVA: 0x20A19F0 Offset: 0x20A03F0 VA: 0x1820A19F0 Slot: 4
	internal override bool get_IsSqlColumn() { }

	// RVA: 0x20A11F0 Offset: 0x209FBF0 VA: 0x1820A11F0 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x20A1550 Offset: 0x209FF50 VA: 0x1820A1550 Slot: 6
	internal override object Eval() { }

	// RVA: 0x20A1440 Offset: 0x209FE40 VA: 0x1820A1440 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x20A1510 Offset: 0x209FF10 VA: 0x1820A1510 Slot: 8
	internal override object Eval(int[] records) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x20A1620 Offset: 0x20A0020 VA: 0x1820A1620 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x20A1580 Offset: 0x209FF80 VA: 0x1820A1580 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x20A15D0 Offset: 0x209FFD0 VA: 0x1820A15D0 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x20A13D0 Offset: 0x209FDD0 VA: 0x1820A13D0 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0x20A1670 Offset: 0x20A0070 VA: 0x1820A1670
	internal static string ParseName(char[] text, int start, int pos) { }
}
