internal abstract class CacheAxisQuery : BaseAxisQuery // TypeDefIndex: 8539
{
	// Fields
	protected List<XPathNavigator> outputBuffer; // 0x58

	// Properties
	public override XPathNavigator Current { get; }
	public override int CurrentPosition { get; }
	public override int Count { get; }
	public override QueryProps Properties { get; }

	// Methods

	// RVA: 0x24968C0 Offset: 0x24952C0 VA: 0x1824968C0
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x2496790 Offset: 0x2495190 VA: 0x182496790
	protected void .ctor(CacheAxisQuery other) { }

	// RVA: 0x2496780 Offset: 0x2495180 VA: 0x182496780 Slot: 12
	public override void Reset() { }

	// RVA: 0x24966D0 Offset: 0x24950D0 VA: 0x1824966D0 Slot: 14
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x2496660 Offset: 0x2495060 VA: 0x182496660 Slot: 15
	public override XPathNavigator Advance() { }

	// RVA: 0x2496A40 Offset: 0x2495440 VA: 0x182496A40 Slot: 8
	public override XPathNavigator get_Current() { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220 Slot: 9
	public override int get_CurrentPosition() { }

	// RVA: 0x2496A00 Offset: 0x2495400 VA: 0x182496A00 Slot: 10
	public override int get_Count() { }

	// RVA: 0x1BF2250 Offset: 0x1BF0C50 VA: 0x181BF2250 Slot: 17
	public override QueryProps get_Properties() { }
}
