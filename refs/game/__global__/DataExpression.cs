internal sealed class DataExpression : IFilter // TypeDefIndex: 12935
{
	// Fields
	internal string _originalExpression; // 0x10
	private bool _parsed; // 0x18
	private bool _bound; // 0x19
	private ExpressionNode _expr; // 0x20
	private DataTable _table; // 0x28
	private readonly StorageType _storageType; // 0x30
	private readonly Type _dataType; // 0x38
	private DataColumn[] _dependency; // 0x40

	// Properties
	internal string Expression { get; }
	internal bool HasValue { get; }

	// Methods

	// RVA: 0x2088BC0 Offset: 0x20875C0 VA: 0x182088BC0
	internal void .ctor(DataTable table, string expression) { }

	// RVA: 0x2088BE0 Offset: 0x20875E0 VA: 0x182088BE0
	internal void .ctor(DataTable table, string expression, Type type) { }

	// RVA: 0x2088FA0 Offset: 0x20879A0 VA: 0x182088FA0
	internal string get_Expression() { }

	// RVA: 0x6208C0 Offset: 0x61F2C0 VA: 0x1806208C0
	internal bool get_HasValue() { }

	// RVA: 0x20883A0 Offset: 0x2086DA0 VA: 0x1820883A0
	internal void Bind(DataTable table) { }

	// RVA: 0x20884D0 Offset: 0x2086ED0 VA: 0x1820884D0
	internal bool DependsOn(DataColumn column) { }

	// RVA: 0x2088700 Offset: 0x2087100 VA: 0x182088700
	internal object Evaluate() { }

	// RVA: 0x2088500 Offset: 0x2086F00 VA: 0x182088500
	internal object Evaluate(DataRow row, DataRowVersion version) { }

	// RVA: 0x2088770 Offset: 0x2087170 VA: 0x182088770 Slot: 4
	public bool Invoke(DataRow row, DataRowVersion version) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	internal DataColumn[] GetDependency() { }

	// RVA: 0x2088820 Offset: 0x2087220 VA: 0x182088820
	internal bool IsTableAggregate() { }

	// RVA: 0x2088850 Offset: 0x2087250 VA: 0x182088850
	internal static bool IsUnknown(object value) { }

	// RVA: 0x2088710 Offset: 0x2087110 VA: 0x182088710
	internal bool HasLocalAggregate() { }

	// RVA: 0x2088740 Offset: 0x2087140 VA: 0x182088740
	internal bool HasRemoteAggregate() { }

	// RVA: 0x20888A0 Offset: 0x20872A0 VA: 0x1820888A0
	internal static bool ToBoolean(object value) { }
}
