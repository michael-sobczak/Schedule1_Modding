internal abstract class XPathDocumentBaseIterator : XPathNodeIterator // TypeDefIndex: 8606
{
	// Fields
	protected XPathDocumentNavigator ctxt; // 0x18
	protected int pos; // 0x20

	// Properties
	public override XPathNavigator Current { get; }
	public override int CurrentPosition { get; }

	// Methods

	// RVA: 0x24B62C0 Offset: 0x24B4CC0 VA: 0x1824B62C0
	protected void .ctor(XPathDocumentNavigator ctxt) { }

	// RVA: 0x24B6370 Offset: 0x24B4D70 VA: 0x1824B6370
	protected void .ctor(XPathDocumentBaseIterator iter) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 8
	public override XPathNavigator get_Current() { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440 Slot: 9
	public override int get_CurrentPosition() { }
}
