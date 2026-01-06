internal sealed class FunctionQuery : ExtensionQuery // TypeDefIndex: 8560
{
	// Fields
	private IList<Query> _args; // 0x38
	private IXsltContextFunction _function; // 0x40

	// Properties
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0x249B460 Offset: 0x2499E60 VA: 0x18249B460
	public void .ctor(string prefix, string name, List<Query> args) { }

	// RVA: 0x249B4D0 Offset: 0x2499ED0 VA: 0x18249B4D0
	private void .ctor(FunctionQuery other) { }

	// RVA: 0x249AFB0 Offset: 0x24999B0 VA: 0x18249AFB0 Slot: 13
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x249AB30 Offset: 0x2499530 VA: 0x18249AB30 Slot: 14
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x249B7D0 Offset: 0x249A1D0 VA: 0x18249B7D0 Slot: 16
	public override XPathResultType get_StaticType() { }

	// RVA: 0x249AAD0 Offset: 0x24994D0 VA: 0x18249AAD0 Slot: 6
	public override XPathNodeIterator Clone() { }
}
