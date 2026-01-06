internal class XPathDocumentElementDescendantIterator : XPathDocumentBaseIterator // TypeDefIndex: 8609
{
	// Fields
	private XPathDocumentNavigator _end; // 0x28
	private string _localName; // 0x30
	private string _namespaceUri; // 0x38
	private bool _matchSelf; // 0x40

	// Methods

	// RVA: 0x24B68F0 Offset: 0x24B52F0 VA: 0x1824B68F0
	public void .ctor(XPathDocumentNavigator root, string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x24B6B10 Offset: 0x24B5510 VA: 0x1824B6B10
	public void .ctor(XPathDocumentElementDescendantIterator iter) { }

	// RVA: 0x24B6700 Offset: 0x24B5100 VA: 0x1824B6700 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x24B67A0 Offset: 0x24B51A0 VA: 0x1824B67A0 Slot: 7
	public override bool MoveNext() { }
}
