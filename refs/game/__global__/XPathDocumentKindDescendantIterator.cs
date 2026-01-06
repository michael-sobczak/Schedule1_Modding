internal class XPathDocumentKindDescendantIterator : XPathDocumentBaseIterator // TypeDefIndex: 8610
{
	// Fields
	private XPathDocumentNavigator _end; // 0x28
	private XPathNodeType _typ; // 0x30
	private bool _matchSelf; // 0x34

	// Methods

	// RVA: 0x24B6EE0 Offset: 0x24B58E0 VA: 0x1824B6EE0
	public void .ctor(XPathDocumentNavigator root, XPathNodeType typ, bool matchSelf) { }

	// RVA: 0x24B7050 Offset: 0x24B5A50 VA: 0x1824B7050
	public void .ctor(XPathDocumentKindDescendantIterator iter) { }

	// RVA: 0x24B6D60 Offset: 0x24B5760 VA: 0x1824B6D60 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x24B6DE0 Offset: 0x24B57E0 VA: 0x1824B6DE0 Slot: 7
	public override bool MoveNext() { }
}
