internal sealed class FollSiblingQuery : BaseAxisQuery // TypeDefIndex: 8555
{
	// Fields
	private ClonableStack<XPathNavigator> _elementStk; // 0x58
	private List<XPathNavigator> _parentStk; // 0x60
	private XPathNavigator _nextInput; // 0x68

	// Methods

	// RVA: 0x249A2F0 Offset: 0x2498CF0 VA: 0x18249A2F0
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType type) { }

	// RVA: 0x249A180 Offset: 0x2498B80 VA: 0x18249A180
	private void .ctor(FollSiblingQuery other) { }

	// RVA: 0x2499F80 Offset: 0x2498980 VA: 0x182499F80 Slot: 12
	public override void Reset() { }

	// RVA: 0x249A050 Offset: 0x2498A50 VA: 0x18249A050
	private bool Visited(XPathNavigator nav) { }

	// RVA: 0x2499E30 Offset: 0x2498830 VA: 0x182499E30
	private XPathNavigator FetchInput() { }

	// RVA: 0x2499A70 Offset: 0x2498470 VA: 0x182499A70 Slot: 15
	public override XPathNavigator Advance() { }

	// RVA: 0x2499C90 Offset: 0x2498690 VA: 0x182499C90 Slot: 6
	public override XPathNodeIterator Clone() { }
}
