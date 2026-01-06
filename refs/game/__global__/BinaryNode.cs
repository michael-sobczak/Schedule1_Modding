internal class BinaryNode : ExpressionNode // TypeDefIndex: 12932
{
	// Fields
	internal int _op; // 0x18
	internal ExpressionNode _left; // 0x20
	internal ExpressionNode _right; // 0x28

	// Methods

	// RVA: 0x20879F0 Offset: 0x20863F0 VA: 0x1820879F0
	internal void .ctor(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	// RVA: 0x20817D0 Offset: 0x20801D0 VA: 0x1820817D0 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x2062180 Offset: 0x2060B80 VA: 0x182062180 Slot: 6
	internal override object Eval() { }

	// RVA: 0x2086760 Offset: 0x2085160 VA: 0x182086760 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x20866D0 Offset: 0x20850D0 VA: 0x1820866D0 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x2086B50 Offset: 0x2085550 VA: 0x182086B50 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x2086CA0 Offset: 0x20856A0 VA: 0x182086CA0 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x2086A90 Offset: 0x2085490 VA: 0x182086A90 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x2086AF0 Offset: 0x20854F0 VA: 0x182086AF0 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x2081850 Offset: 0x2080250 VA: 0x182081850 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x2086D00 Offset: 0x2085700 VA: 0x182086D00 Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0x20878C0 Offset: 0x20862C0 VA: 0x1820878C0
	internal void SetTypeMismatchError(int op, Type left, Type right) { }

	// RVA: 0x2086710 Offset: 0x2085110 VA: 0x182086710
	private static object Eval(ExpressionNode expr, DataRow row, DataRowVersion version, int[] recordNos) { }

	// RVA: 0x20808A0 Offset: 0x207F2A0 VA: 0x1820808A0
	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op) { }

	// RVA: 0x20808D0 Offset: 0x207F2D0 VA: 0x1820808D0
	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op, CompareInfo comparer) { }

	// RVA: 0x20818C0 Offset: 0x20802C0 VA: 0x1820818C0
	private object EvalBinaryOp(int op, ExpressionNode left, ExpressionNode right, DataRow row, DataRowVersion version, int[] recordNos) { }

	// RVA: 0x2086900 Offset: 0x2085300 VA: 0x182086900
	private BinaryNode.DataTypePrecedence GetPrecedence(StorageType storageType) { }

	// RVA: 0x2086790 Offset: 0x2085190 VA: 0x182086790
	private static StorageType GetPrecedenceType(BinaryNode.DataTypePrecedence code) { }

	// RVA: 0x2086C30 Offset: 0x2085630 VA: 0x182086C30
	private bool IsMixed(StorageType left, StorageType right) { }

	// RVA: 0x2086BB0 Offset: 0x20855B0 VA: 0x182086BB0
	private bool IsMixedSql(StorageType left, StorageType right) { }

	// RVA: 0x2087570 Offset: 0x2085F70 VA: 0x182087570
	internal StorageType ResultType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	// RVA: 0x20870D0 Offset: 0x2085AD0 VA: 0x1820870D0
	internal StorageType ResultSqlType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	// RVA: 0x2087900 Offset: 0x2086300 VA: 0x182087900
	private int SqlResultType(int typeCode) { }
}
