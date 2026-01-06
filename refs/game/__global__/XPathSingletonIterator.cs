internal class XPathSingletonIterator : ResetableIterator // TypeDefIndex: 8605
{
	// Fields
	private XPathNavigator _nav; // 0x18
	private int _position; // 0x20

	// Properties
	public override XPathNavigator Current { get; }
	public override int CurrentPosition { get; }
	public override int Count { get; }

	// Methods

	// RVA: 0x24C0980 Offset: 0x24BF380 VA: 0x1824C0980
	public void .ctor(XPathNavigator nav) { }

	// RVA: 0x24C0920 Offset: 0x24BF320 VA: 0x1824C0920
	public void .ctor(XPathNavigator nav, bool moved) { }

	// RVA: 0x24C08B0 Offset: 0x24BF2B0 VA: 0x1824C08B0
	public void .ctor(XPathSingletonIterator it) { }

	// RVA: 0x24C07F0 Offset: 0x24BF1F0 VA: 0x1824C07F0 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 8
	public override XPathNavigator get_Current() { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440 Slot: 9
	public override int get_CurrentPosition() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 10
	public override int get_Count() { }

	// RVA: 0x24C0890 Offset: 0x24BF290 VA: 0x1824C0890 Slot: 7
	public override bool MoveNext() { }

	// RVA: 0x24B55D0 Offset: 0x24B3FD0 VA: 0x1824B55D0 Slot: 12
	public override void Reset() { }
}
