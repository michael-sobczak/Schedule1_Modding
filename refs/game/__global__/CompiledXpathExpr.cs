internal class CompiledXpathExpr : XPathExpression // TypeDefIndex: 8545
{
	// Fields
	private Query _query; // 0x10
	private string _expr; // 0x18
	private bool _needContext; // 0x20

	// Properties
	internal Query QueryTree { get; }

	// Methods

	// RVA: 0x2497E50 Offset: 0x2496850 VA: 0x182497E50
	internal void .ctor(Query query, string expression, bool needContext) { }

	// RVA: 0x2497EC0 Offset: 0x24968C0 VA: 0x182497EC0
	internal Query get_QueryTree() { }

	// RVA: 0x2497D20 Offset: 0x2496720 VA: 0x182497D20 Slot: 4
	public override void SetContext(IXmlNamespaceResolver nsResolver) { }
}
