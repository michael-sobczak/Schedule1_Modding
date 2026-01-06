internal sealed class PrecedingQuery : BaseAxisQuery // TypeDefIndex: 8579
{
	// Fields
	private XPathNodeIterator _workIterator; // 0x58
	private ClonableStack<XPathNavigator> _ancestorStk; // 0x60

	// Properties
	public override QueryProps Properties { get; }

	// Methods

	// RVA: 0x24A5070 Offset: 0x24A3A70 VA: 0x1824A5070
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x24A51A0 Offset: 0x24A3BA0 VA: 0x1824A51A0
	private void .ctor(PrecedingQuery other) { }

	// RVA: 0x24A4FD0 Offset: 0x24A39D0 VA: 0x1824A4FD0 Slot: 12
	public override void Reset() { }

	// RVA: 0x24A4B90 Offset: 0x24A3590 VA: 0x1824A4B90 Slot: 15
	public override XPathNavigator Advance() { }

	// RVA: 0x24A4E90 Offset: 0x24A3890 VA: 0x1824A4E90 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x24A52B0 Offset: 0x24A3CB0 VA: 0x1824A52B0 Slot: 17
	public override QueryProps get_Properties() { }
}
