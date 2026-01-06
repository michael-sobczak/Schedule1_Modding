internal abstract class ExpressionNode // TypeDefIndex: 12936
{
	// Fields
	private DataTable _table; // 0x10

	// Properties
	internal IFormatProvider FormatProvider { get; }
	internal virtual bool IsSqlColumn { get; }
	protected DataTable table { get; }

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	protected void .ctor(DataTable table) { }

	// RVA: 0x2092A70 Offset: 0x2091470 VA: 0x182092A70
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 4
	internal virtual bool get_IsSqlColumn() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	protected DataTable get_table() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	protected void BindTable(DataTable table) { }

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract void Bind(DataTable table, List<DataColumn> list);

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract object Eval();

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract object Eval(DataRow row, DataRowVersion version);

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract object Eval(int[] recordNos);

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract bool IsConstant();

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract bool IsTableConstant();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract bool HasLocalAggregate();

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract bool HasRemoteAggregate();

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract ExpressionNode Optimize();

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 14
	internal virtual bool DependsOn(DataColumn column) { }

	// RVA: 0x2092940 Offset: 0x2091340 VA: 0x182092940
	internal static bool IsInteger(StorageType type) { }

	// RVA: 0x2092920 Offset: 0x2091320 VA: 0x182092920
	internal static bool IsIntegerSql(StorageType type) { }

	// RVA: 0x2092A10 Offset: 0x2091410 VA: 0x182092A10
	internal static bool IsSigned(StorageType type) { }

	// RVA: 0x20929D0 Offset: 0x20913D0 VA: 0x1820929D0
	internal static bool IsSignedSql(StorageType type) { }

	// RVA: 0x2092A50 Offset: 0x2091450 VA: 0x182092A50
	internal static bool IsUnsigned(StorageType type) { }

	// RVA: 0x2092A30 Offset: 0x2091430 VA: 0x182092A30
	internal static bool IsUnsignedSql(StorageType type) { }

	// RVA: 0x20929A0 Offset: 0x20913A0 VA: 0x1820929A0
	internal static bool IsNumeric(StorageType type) { }

	// RVA: 0x2092960 Offset: 0x2091360 VA: 0x182092960
	internal static bool IsNumericSql(StorageType type) { }

	// RVA: 0x2092900 Offset: 0x2091300 VA: 0x182092900
	internal static bool IsFloat(StorageType type) { }

	// RVA: 0x20928E0 Offset: 0x20912E0 VA: 0x1820928E0
	internal static bool IsFloatSql(StorageType type) { }
}
