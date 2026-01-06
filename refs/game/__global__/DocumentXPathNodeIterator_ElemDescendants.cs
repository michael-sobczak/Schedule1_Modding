internal abstract class DocumentXPathNodeIterator_ElemDescendants : XPathNodeIterator // TypeDefIndex: 8025
{
	// Fields
	private DocumentXPathNavigator nav; // 0x18
	private int level; // 0x20
	private int position; // 0x24

	// Properties
	public override XPathNavigator Current { get; }
	public override int CurrentPosition { get; }

	// Methods

	// RVA: 0x24ED470 Offset: 0x24EBE70 VA: 0x1824ED470
	internal void .ctor(DocumentXPathNavigator nav) { }

	// RVA: 0x24ED540 Offset: 0x24EBF40 VA: 0x1824ED540
	internal void .ctor(DocumentXPathNodeIterator_ElemDescendants other) { }

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract bool Match(XmlNode node);

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 8
	public override XPathNavigator get_Current() { }

	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40 Slot: 9
	public override int get_CurrentPosition() { }

	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	protected void SetPosition(int pos) { }

	// RVA: 0x24ED300 Offset: 0x24EBD00 VA: 0x1824ED300 Slot: 7
	public override bool MoveNext() { }
}
