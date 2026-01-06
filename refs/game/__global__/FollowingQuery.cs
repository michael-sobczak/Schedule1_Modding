internal sealed class FollowingQuery : BaseAxisQuery // TypeDefIndex: 8556
{
	// Fields
	private XPathNavigator _input; // 0x58
	private XPathNodeIterator _iterator; // 0x60

	// Methods

	// RVA: 0x24954C0 Offset: 0x2493EC0 VA: 0x1824954C0
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x249A880 Offset: 0x2499280 VA: 0x18249A880
	private void .ctor(FollowingQuery other) { }

	// RVA: 0x2498820 Offset: 0x2497220 VA: 0x182498820 Slot: 12
	public override void Reset() { }

	// RVA: 0x249A470 Offset: 0x2498E70 VA: 0x18249A470 Slot: 15
	public override XPathNavigator Advance() { }

	// RVA: 0x249A770 Offset: 0x2499170 VA: 0x18249A770 Slot: 6
	public override XPathNodeIterator Clone() { }
}
