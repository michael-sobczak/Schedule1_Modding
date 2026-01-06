internal sealed class EmptyQuery : Query // TypeDefIndex: 8551
{
	// Properties
	public override int CurrentPosition { get; }
	public override int Count { get; }
	public override QueryProps Properties { get; }
	public override XPathResultType StaticType { get; }
	public override XPathNavigator Current { get; }

	// Methods

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 15
	public override XPathNavigator Advance() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 14
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 9
	public override int get_CurrentPosition() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 10
	public override int get_Count() { }

	// RVA: 0x1BF2250 Offset: 0x1BF0C50 VA: 0x181BF2250 Slot: 17
	public override QueryProps get_Properties() { }

	// RVA: 0x583670 Offset: 0x582070 VA: 0x180583670 Slot: 16
	public override XPathResultType get_StaticType() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 12
	public override void Reset() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 8
	public override XPathNavigator get_Current() { }

	// RVA: 0x24989C0 Offset: 0x24973C0 VA: 0x1824989C0
	public void .ctor() { }
}
