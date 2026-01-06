internal class ContextQuery : Query // TypeDefIndex: 8546
{
	// Fields
	protected XPathNavigator contextNode; // 0x18

	// Properties
	public override XPathNavigator Current { get; }
	public override XPathResultType StaticType { get; }
	public override int CurrentPosition { get; }
	public override int Count { get; }
	public override QueryProps Properties { get; }

	// Methods

	// RVA: 0x24951A0 Offset: 0x2493BA0 VA: 0x1824951A0
	public void .ctor() { }

	// RVA: 0x2495160 Offset: 0x2493B60 VA: 0x182495160
	protected void .ctor(ContextQuery other) { }

	// RVA: 0x2496780 Offset: 0x2495180 VA: 0x182496780 Slot: 12
	public override void Reset() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 8
	public override XPathNavigator get_Current() { }

	// RVA: 0x2497FA0 Offset: 0x24969A0 VA: 0x182497FA0 Slot: 14
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x2497F10 Offset: 0x2496910 VA: 0x182497F10 Slot: 15
	public override XPathNavigator Advance() { }

	// RVA: 0x2497F30 Offset: 0x2496930 VA: 0x182497F30 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x583670 Offset: 0x582070 VA: 0x180583670 Slot: 16
	public override XPathResultType get_StaticType() { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220 Slot: 9
	public override int get_CurrentPosition() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 10
	public override int get_Count() { }

	// RVA: 0x1BF2250 Offset: 0x1BF0C50 VA: 0x181BF2250 Slot: 17
	public override QueryProps get_Properties() { }
}
