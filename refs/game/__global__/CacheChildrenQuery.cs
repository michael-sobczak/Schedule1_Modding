internal sealed class CacheChildrenQuery : ChildrenQuery // TypeDefIndex: 8540
{
	// Fields
	private XPathNavigator _nextInput; // 0x60
	private ClonableStack<XPathNavigator> _elementStk; // 0x68
	private ClonableStack<int> _positionStk; // 0x70
	private bool _needInput; // 0x78

	// Methods

	// RVA: 0x2497340 Offset: 0x2495D40 VA: 0x182497340
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType type) { }

	// RVA: 0x2497270 Offset: 0x2495C70 VA: 0x182497270
	private void .ctor(CacheChildrenQuery other) { }

	// RVA: 0x2497150 Offset: 0x2495B50 VA: 0x182497150 Slot: 12
	public override void Reset() { }

	// RVA: 0x2496AA0 Offset: 0x24954A0 VA: 0x182496AA0 Slot: 15
	public override XPathNavigator Advance() { }

	// RVA: 0x2496FC0 Offset: 0x24959C0 VA: 0x182496FC0
	private bool DecideNextNode() { }

	// RVA: 0x24970D0 Offset: 0x2495AD0 VA: 0x1824970D0
	private XPathNavigator GetNextInput() { }

	// RVA: 0x2496EC0 Offset: 0x24958C0 VA: 0x182496EC0 Slot: 6
	public override XPathNodeIterator Clone() { }
}
