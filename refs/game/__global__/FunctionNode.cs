internal sealed class FunctionNode : ExpressionNode // TypeDefIndex: 12867
{
	// Fields
	internal readonly string _name; // 0x18
	internal readonly int _info; // 0x20
	internal int _argumentCount; // 0x24
	internal ExpressionNode[] _arguments; // 0x28
	[Nullable(2)]
	private readonly TypeLimiter _capturedLimiter; // 0x30
	private static readonly Function[] s_funcs; // 0x0

	// Properties
	internal FunctionId Aggregate { get; }
	internal bool IsAggregate { get; }

	// Methods

	// RVA: 0x2063380 Offset: 0x2061D80 VA: 0x182063380
	internal void .ctor(DataTable table, string name) { }

	// RVA: 0x205F070 Offset: 0x205DA70 VA: 0x18205F070
	internal void AddArgument(ExpressionNode argument) { }

	// RVA: 0x205F260 Offset: 0x205DC60 VA: 0x18205F260 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x2062180 Offset: 0x2060B80 VA: 0x182062180 Slot: 6
	internal override object Eval() { }

	// RVA: 0x2061620 Offset: 0x2060020 VA: 0x182061620 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x2062140 Offset: 0x2060B40 VA: 0x182062140 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x20625A0 Offset: 0x2060FA0 VA: 0x1820625A0 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x2062630 Offset: 0x2061030 VA: 0x182062630 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x2062480 Offset: 0x2060E80 VA: 0x182062480 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x2062510 Offset: 0x2060F10 VA: 0x182062510 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x205F7F0 Offset: 0x205E1F0 VA: 0x18205F7F0 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x20626C0 Offset: 0x20610C0 VA: 0x1820626C0 Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0x20621A0 Offset: 0x2060BA0 VA: 0x1820621A0
	private Type GetDataType(ExpressionNode node) { }

	// RVA: 0x205F880 Offset: 0x205E280 VA: 0x18205F880
	private object EvalFunction(FunctionId id, object[] argumentValues, DataRow row, DataRowVersion version) { }

	// RVA: 0x20634E0 Offset: 0x2061EE0 VA: 0x1820634E0
	internal FunctionId get_Aggregate() { }

	// RVA: 0x2063580 Offset: 0x2061F80 VA: 0x182063580
	internal bool get_IsAggregate() { }

	// RVA: 0x205F590 Offset: 0x205DF90 VA: 0x18205F590
	internal void Check() { }

	// RVA: 0x20628D0 Offset: 0x20612D0 VA: 0x1820628D0
	private static void .cctor() { }
}
