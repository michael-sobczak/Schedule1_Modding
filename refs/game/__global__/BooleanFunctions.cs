internal sealed class BooleanFunctions : ValueQuery // TypeDefIndex: 8538
{
	// Fields
	private Query _arg; // 0x18
	private Function.FunctionType _funcType; // 0x20

	// Properties
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0x2496320 Offset: 0x2494D20 VA: 0x182496320
	public void .ctor(Function.FunctionType funcType, Query arg) { }

	// RVA: 0x24962D0 Offset: 0x2494CD0 VA: 0x1824962D0
	private void .ctor(BooleanFunctions other) { }

	// RVA: 0x24962B0 Offset: 0x2494CB0 VA: 0x1824962B0 Slot: 13
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x2495F10 Offset: 0x2494910 VA: 0x182495F10 Slot: 14
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x2496560 Offset: 0x2494F60 VA: 0x182496560
	internal static bool toBoolean(double number) { }

	// RVA: 0x2496370 Offset: 0x2494D70 VA: 0x182496370
	internal static bool toBoolean(string str) { }

	// RVA: 0x2496390 Offset: 0x2494D90 VA: 0x182496390
	internal bool toBoolean(XPathNodeIterator nodeIterator) { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 16
	public override XPathResultType get_StaticType() { }

	// RVA: 0x2496220 Offset: 0x2494C20 VA: 0x182496220
	private bool Not(XPathNodeIterator nodeIterator) { }

	// RVA: 0x2496120 Offset: 0x2494B20 VA: 0x182496120
	private bool Lang(XPathNodeIterator nodeIterator) { }

	// RVA: 0x2495E90 Offset: 0x2494890 VA: 0x182495E90 Slot: 6
	public override XPathNodeIterator Clone() { }
}
