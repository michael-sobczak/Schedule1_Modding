internal sealed class VariableQuery : ExtensionQuery // TypeDefIndex: 8592
{
	// Fields
	private IXsltContextVariable _variable; // 0x38

	// Properties
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0x24B50D0 Offset: 0x24B3AD0 VA: 0x1824B50D0
	public void .ctor(string name, string prefix) { }

	// RVA: 0x24B50F0 Offset: 0x24B3AF0 VA: 0x1824B50F0
	private void .ctor(VariableQuery other) { }

	// RVA: 0x24B4FF0 Offset: 0x24B39F0 VA: 0x1824B4FF0 Slot: 13
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x24B4ED0 Offset: 0x24B38D0 VA: 0x1824B4ED0 Slot: 14
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x24B5130 Offset: 0x24B3B30 VA: 0x1824B5130 Slot: 16
	public override XPathResultType get_StaticType() { }

	// RVA: 0x24B4E60 Offset: 0x24B3860 VA: 0x1824B4E60 Slot: 6
	public override XPathNodeIterator Clone() { }
}
