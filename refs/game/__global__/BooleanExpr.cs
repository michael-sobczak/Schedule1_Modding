internal sealed class BooleanExpr : ValueQuery // TypeDefIndex: 8537
{
	// Fields
	private Query _opnd1; // 0x18
	private Query _opnd2; // 0x20
	private bool _isOr; // 0x28

	// Properties
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0x2495D40 Offset: 0x2494740 VA: 0x182495D40
	public void .ctor(Operator.Op op, Query opnd1, Query opnd2) { }

	// RVA: 0x2495CD0 Offset: 0x24946D0 VA: 0x182495CD0
	private void .ctor(BooleanExpr other) { }

	// RVA: 0x2495C70 Offset: 0x2494670 VA: 0x182495C70 Slot: 13
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x2495BA0 Offset: 0x24945A0 VA: 0x182495BA0 Slot: 14
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x2495B00 Offset: 0x2494500 VA: 0x182495B00 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 16
	public override XPathResultType get_StaticType() { }
}
