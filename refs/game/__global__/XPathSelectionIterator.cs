internal class XPathSelectionIterator : ResetableIterator // TypeDefIndex: 8603
{
	// Fields
	private XPathNavigator _nav; // 0x18
	private Query _query; // 0x20
	private int _position; // 0x28

	// Properties
	public override int Count { get; }
	public override XPathNavigator Current { get; }
	public override int CurrentPosition { get; }

	// Methods

	// RVA: 0x24C0520 Offset: 0x24BEF20 VA: 0x1824C0520
	internal void .ctor(XPathNavigator nav, Query query) { }

	// RVA: 0x24C05A0 Offset: 0x24BEFA0 VA: 0x1824C05A0
	protected void .ctor(XPathSelectionIterator it) { }

	// RVA: 0x20A6F30 Offset: 0x20A5930 VA: 0x1820A6F30 Slot: 12
	public override void Reset() { }

	// RVA: 0x24C0480 Offset: 0x24BEE80 VA: 0x1824C0480 Slot: 7
	public override bool MoveNext() { }

	// RVA: 0x20A6F90 Offset: 0x20A5990 VA: 0x1820A6F90 Slot: 10
	public override int get_Count() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 8
	public override XPathNavigator get_Current() { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430 Slot: 9
	public override int get_CurrentPosition() { }

	// RVA: 0x24C0320 Offset: 0x24BED20 VA: 0x1824C0320 Slot: 6
	public override XPathNodeIterator Clone() { }
}
