internal struct XPathNodeRef // TypeDefIndex: 8613
{
	// Fields
	private XPathNode[] _page; // 0x0
	private int _idx; // 0x8

	// Properties
	public XPathNode[] Page { get; }
	public int Index { get; }

	// Methods

	// RVA: 0xD900B0 Offset: 0xD8EAB0 VA: 0x180D900B0
	public void .ctor(XPathNode[] page, int idx) { }

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public XPathNode[] get_Page() { }

	// RVA: 0x489DD0 Offset: 0x4887D0 VA: 0x180489DD0
	public int get_Index() { }

	// RVA: 0x24BB440 Offset: 0x24B9E40 VA: 0x1824BB440 Slot: 2
	public override int GetHashCode() { }
}
