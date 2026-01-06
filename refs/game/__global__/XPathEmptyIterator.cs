internal sealed class XPathEmptyIterator : ResetableIterator // TypeDefIndex: 8598
{
	// Fields
	public static XPathEmptyIterator Instance; // 0x0

	// Properties
	public override XPathNavigator Current { get; }
	public override int CurrentPosition { get; }
	public override int Count { get; }

	// Methods

	// RVA: 0x24B24B0 Offset: 0x24B0EB0 VA: 0x1824B24B0
	private void .ctor() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 8
	public override XPathNavigator get_Current() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 9
	public override int get_CurrentPosition() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 10
	public override int get_Count() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	public override bool MoveNext() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 12
	public override void Reset() { }

	// RVA: 0x24B9EC0 Offset: 0x24B88C0 VA: 0x1824B9EC0
	private static void .cctor() { }
}
