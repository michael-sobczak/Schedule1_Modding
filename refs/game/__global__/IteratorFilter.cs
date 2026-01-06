internal class IteratorFilter : XPathNodeIterator // TypeDefIndex: 8564
{
	// Fields
	private XPathNodeIterator _innerIterator; // 0x18
	private string _name; // 0x20
	private int _position; // 0x28

	// Properties
	public override XPathNavigator Current { get; }
	public override int CurrentPosition { get; }

	// Methods

	// RVA: 0x249C2C0 Offset: 0x249ACC0 VA: 0x18249C2C0
	internal void .ctor(XPathNodeIterator innerIterator, string name) { }

	// RVA: 0x249C310 Offset: 0x249AD10 VA: 0x18249C310
	private void .ctor(IteratorFilter it) { }

	// RVA: 0x249C180 Offset: 0x249AB80 VA: 0x18249C180 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1B99510 Offset: 0x1B97F10 VA: 0x181B99510 Slot: 8
	public override XPathNavigator get_Current() { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430 Slot: 9
	public override int get_CurrentPosition() { }

	// RVA: 0x249C220 Offset: 0x249AC20 VA: 0x18249C220 Slot: 7
	public override bool MoveNext() { }
}
