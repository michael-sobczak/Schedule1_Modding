internal class DocumentXPathNodeIterator_ElemChildren : DocumentXPathNodeIterator_ElemDescendants // TypeDefIndex: 8030
{
	// Fields
	protected string localNameAtom; // 0x28
	protected string nsAtom; // 0x30

	// Methods

	// RVA: 0x24ED090 Offset: 0x24EBA90 VA: 0x1824ED090
	internal void .ctor(DocumentXPathNavigator nav, string localNameAtom, string nsAtom) { }

	// RVA: 0x24ED0E0 Offset: 0x24EBAE0 VA: 0x1824ED0E0
	internal void .ctor(DocumentXPathNodeIterator_ElemChildren other) { }

	// RVA: 0x24ED130 Offset: 0x24EBB30 VA: 0x1824ED130 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x24ED1C0 Offset: 0x24EBBC0 VA: 0x1824ED1C0 Slot: 12
	protected override bool Match(XmlNode node) { }
}
