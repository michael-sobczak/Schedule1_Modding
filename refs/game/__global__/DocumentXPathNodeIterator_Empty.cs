internal sealed class DocumentXPathNodeIterator_Empty : XPathNodeIterator // TypeDefIndex: 8024
{
	// Fields
	private XPathNavigator nav; // 0x18

	// Properties
	public override XPathNavigator Current { get; }
	public override int CurrentPosition { get; }
	public override int Count { get; }

	// Methods

	// RVA: 0x24ED6A0 Offset: 0x24EC0A0 VA: 0x1824ED6A0
	internal void .ctor(DocumentXPathNavigator nav) { }

	// RVA: 0x24ED700 Offset: 0x24EC100 VA: 0x1824ED700
	internal void .ctor(DocumentXPathNodeIterator_Empty other) { }

	// RVA: 0x24ED610 Offset: 0x24EC010 VA: 0x1824ED610 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	public override bool MoveNext() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 8
	public override XPathNavigator get_Current() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 9
	public override int get_CurrentPosition() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 10
	public override int get_Count() { }
}
