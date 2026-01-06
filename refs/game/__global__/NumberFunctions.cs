internal sealed class NumberFunctions : ValueQuery // TypeDefIndex: 8571
{
	// Fields
	private Query _arg; // 0x18
	private Function.FunctionType _ftype; // 0x20

	// Properties
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0x2496320 Offset: 0x2494D20 VA: 0x182496320
	public void .ctor(Function.FunctionType ftype, Query arg) { }

	// RVA: 0x24962D0 Offset: 0x2494CD0 VA: 0x1824962D0
	private void .ctor(NumberFunctions other) { }

	// RVA: 0x24962B0 Offset: 0x2494CB0 VA: 0x1824962B0 Slot: 13
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x24A1F00 Offset: 0x24A0900 VA: 0x1824A1F00
	internal static double Number(bool arg) { }

	// RVA: 0x24A1F20 Offset: 0x24A0920 VA: 0x1824A1F20
	internal static double Number(string arg) { }

	// RVA: 0x24A1B00 Offset: 0x24A0500 VA: 0x1824A1B00 Slot: 14
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x24A1F70 Offset: 0x24A0970 VA: 0x1824A1F70
	private double Number(XPathNodeIterator nodeIterator) { }

	// RVA: 0x24A22A0 Offset: 0x24A0CA0 VA: 0x1824A22A0
	private double Sum(XPathNodeIterator nodeIterator) { }

	// RVA: 0x24A1E40 Offset: 0x24A0840 VA: 0x1824A1E40
	private double Floor(XPathNodeIterator nodeIterator) { }

	// RVA: 0x24A19C0 Offset: 0x24A03C0 VA: 0x1824A19C0
	private double Ceiling(XPathNodeIterator nodeIterator) { }

	// RVA: 0x24A2210 Offset: 0x24A0C10 VA: 0x1824A2210
	private double Round(XPathNodeIterator nodeIterator) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 16
	public override XPathResultType get_StaticType() { }

	// RVA: 0x24A1A80 Offset: 0x24A0480 VA: 0x1824A1A80 Slot: 6
	public override XPathNodeIterator Clone() { }
}
