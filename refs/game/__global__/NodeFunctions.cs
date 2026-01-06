internal sealed class NodeFunctions : ValueQuery // TypeDefIndex: 8570
{
	// Fields
	private Query _arg; // 0x18
	private Function.FunctionType _funcType; // 0x20
	private XsltContext _xsltContext; // 0x28

	// Properties
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0x24A1780 Offset: 0x24A0180 VA: 0x1824A1780
	public void .ctor(Function.FunctionType funcType, Query arg) { }

	// RVA: 0x24A1700 Offset: 0x24A0100 VA: 0x1824A1700 Slot: 13
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x24A13C0 Offset: 0x249FDC0 VA: 0x1824A13C0
	private XPathNavigator EvaluateArg(XPathNodeIterator context) { }

	// RVA: 0x24A1440 Offset: 0x249FE40 VA: 0x1824A1440 Slot: 14
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x24A17C0 Offset: 0x24A01C0 VA: 0x1824A17C0 Slot: 16
	public override XPathResultType get_StaticType() { }

	// RVA: 0x24A1320 Offset: 0x249FD20 VA: 0x1824A1320 Slot: 6
	public override XPathNodeIterator Clone() { }
}
