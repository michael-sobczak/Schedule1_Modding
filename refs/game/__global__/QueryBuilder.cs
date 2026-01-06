internal sealed class QueryBuilder // TypeDefIndex: 8584
{
	// Fields
	private string _query; // 0x10
	private bool _allowVar; // 0x18
	private bool _allowKey; // 0x19
	private bool _allowCurrent; // 0x1A
	private bool _needContext; // 0x1B
	private BaseAxisQuery _firstInput; // 0x20
	private int _parseDepth; // 0x28

	// Methods

	// RVA: 0x24B1F80 Offset: 0x24B0980 VA: 0x1824B1F80
	private void Reset() { }

	// RVA: 0x24B0330 Offset: 0x24AED30 VA: 0x1824B0330
	private Query ProcessAxis(Axis root, QueryBuilder.Flags flags, out QueryBuilder.Props props) { }

	// RVA: 0x24B0130 Offset: 0x24AEB30 VA: 0x1824B0130
	private static bool CanBeNumber(Query q) { }

	// RVA: 0x24B0B60 Offset: 0x24AF560 VA: 0x1824B0B60
	private Query ProcessFilter(Filter root, QueryBuilder.Flags flags, out QueryBuilder.Props props) { }

	// RVA: 0x24B1CC0 Offset: 0x24B06C0 VA: 0x1824B1CC0
	private Query ProcessOperator(Operator root, out QueryBuilder.Props props) { }

	// RVA: 0x24B1EC0 Offset: 0x24B08C0 VA: 0x1824B1EC0
	private Query ProcessVariable(Variable root) { }

	// RVA: 0x24B10E0 Offset: 0x24AFAE0 VA: 0x1824B10E0
	private Query ProcessFunction(Function root, out QueryBuilder.Props props) { }

	// RVA: 0x24B0190 Offset: 0x24AEB90 VA: 0x1824B0190
	private List<Query> ProcessArguments(List<AstNode> args, out QueryBuilder.Props props) { }

	// RVA: 0x24B1670 Offset: 0x24B0070 VA: 0x1824B1670
	private Query ProcessNode(AstNode root, QueryBuilder.Flags flags, out QueryBuilder.Props props) { }

	// RVA: 0x24B0000 Offset: 0x24AEA00 VA: 0x1824B0000
	private Query Build(AstNode root, string query) { }

	// RVA: 0x24AFF40 Offset: 0x24AE940 VA: 0x1824AFF40
	internal Query Build(string query, bool allowVar, bool allowKey) { }

	// RVA: 0x24B0060 Offset: 0x24AEA60 VA: 0x1824B0060
	internal Query Build(string query, out bool needContext) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
