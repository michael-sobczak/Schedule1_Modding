internal abstract class CacheOutputQuery : Query // TypeDefIndex: 8541
{
	// Fields
	internal Query input; // 0x18
	protected List<XPathNavigator> outputBuffer; // 0x20

	// Properties
	public override XPathNavigator Current { get; }
	public override XPathResultType StaticType { get; }
	public override int CurrentPosition { get; }
	public override int Count { get; }
	public override QueryProps Properties { get; }

	// Methods

	// RVA: 0x24976F0 Offset: 0x24960F0 VA: 0x1824976F0
	public void .ctor(Query input) { }

	// RVA: 0x2497620 Offset: 0x2496020 VA: 0x182497620
	protected void .ctor(CacheOutputQuery other) { }

	// RVA: 0x2496780 Offset: 0x2495180 VA: 0x182496780 Slot: 12
	public override void Reset() { }

	// RVA: 0x1B9C240 Offset: 0x1B9AC40 VA: 0x181B9C240 Slot: 13
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x2497590 Offset: 0x2495F90 VA: 0x182497590 Slot: 14
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x2497520 Offset: 0x2495F20 VA: 0x182497520 Slot: 15
	public override XPathNavigator Advance() { }

	// RVA: 0x24977D0 Offset: 0x24961D0 VA: 0x1824977D0 Slot: 8
	public override XPathNavigator get_Current() { }

	// RVA: 0x583670 Offset: 0x582070 VA: 0x180583670 Slot: 16
	public override XPathResultType get_StaticType() { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220 Slot: 9
	public override int get_CurrentPosition() { }

	// RVA: 0x2497790 Offset: 0x2496190 VA: 0x182497790 Slot: 10
	public override int get_Count() { }

	// RVA: 0x1BF2250 Offset: 0x1BF0C50 VA: 0x181BF2250 Slot: 17
	public override QueryProps get_Properties() { }
}
