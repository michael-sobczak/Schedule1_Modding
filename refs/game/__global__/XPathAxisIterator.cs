internal abstract class XPathAxisIterator : XPathNodeIterator // TypeDefIndex: 8595
{
	// Fields
	internal XPathNavigator nav; // 0x18
	internal XPathNodeType type; // 0x20
	internal string name; // 0x28
	internal string uri; // 0x30
	internal int position; // 0x38
	internal bool matchSelf; // 0x3C
	internal bool first; // 0x3D

	// Properties
	public override XPathNavigator Current { get; }
	public override int CurrentPosition { get; }
	protected virtual bool Matches { get; }

	// Methods

	// RVA: 0x24B59C0 Offset: 0x24B43C0 VA: 0x1824B59C0
	public void .ctor(XPathNavigator nav, bool matchSelf) { }

	// RVA: 0x24B5A10 Offset: 0x24B4410 VA: 0x1824B5A10
	public void .ctor(XPathNavigator nav, XPathNodeType type, bool matchSelf) { }

	// RVA: 0x24B5B10 Offset: 0x24B4510 VA: 0x1824B5B10
	public void .ctor(XPathNavigator nav, string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x24B5A70 Offset: 0x24B4470 VA: 0x1824B5A70
	public void .ctor(XPathAxisIterator it) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 8
	public override XPathNavigator get_Current() { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50 Slot: 9
	public override int get_CurrentPosition() { }

	// RVA: 0x24B5C30 Offset: 0x24B4630 VA: 0x1824B5C30 Slot: 12
	protected virtual bool get_Matches() { }
}
