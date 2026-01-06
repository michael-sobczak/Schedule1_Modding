internal abstract class ValueQuery : Query // TypeDefIndex: 8590
{
	// Properties
	public sealed override XPathNavigator Current { get; }
	public sealed override int CurrentPosition { get; }
	public sealed override int Count { get; }

	// Methods

	// RVA: 0x24B24B0 Offset: 0x24B0EB0 VA: 0x1824B24B0
	public void .ctor() { }

	// RVA: 0x24B24D0 Offset: 0x24B0ED0 VA: 0x1824B24D0
	protected void .ctor(ValueQuery other) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 12
	public sealed override void Reset() { }

	// RVA: 0x24B4E20 Offset: 0x24B3820 VA: 0x1824B4E20 Slot: 8
	public sealed override XPathNavigator get_Current() { }

	// RVA: 0x24B4DE0 Offset: 0x24B37E0 VA: 0x1824B4DE0 Slot: 9
	public sealed override int get_CurrentPosition() { }

	// RVA: 0x24B4DA0 Offset: 0x24B37A0 VA: 0x1824B4DA0 Slot: 10
	public sealed override int get_Count() { }

	// RVA: 0x24B4D60 Offset: 0x24B3760 VA: 0x1824B4D60 Slot: 15
	public sealed override XPathNavigator Advance() { }
}
