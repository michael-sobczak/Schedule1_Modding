internal sealed class NumericExpr : ValueQuery // TypeDefIndex: 8572
{
	// Fields
	private Operator.Op _op; // 0x18
	private Query _opnd1; // 0x20
	private Query _opnd2; // 0x28

	// Properties
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0x24A25A0 Offset: 0x24A0FA0 VA: 0x1824A25A0
	public void .ctor(Operator.Op op, Query opnd1, Query opnd2) { }

	// RVA: 0x249DEA0 Offset: 0x249C8A0 VA: 0x18249DEA0
	private void .ctor(NumericExpr other) { }

	// RVA: 0x249C710 Offset: 0x249B110 VA: 0x18249C710 Slot: 13
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x24A2420 Offset: 0x24A0E20 VA: 0x1824A2420 Slot: 14
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x24A2560 Offset: 0x24A0F60 VA: 0x1824A2560
	private static double GetValue(Operator.Op op, double n1, double n2) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 16
	public override XPathResultType get_StaticType() { }

	// RVA: 0x24A2380 Offset: 0x24A0D80 VA: 0x1824A2380 Slot: 6
	public override XPathNodeIterator Clone() { }
}
