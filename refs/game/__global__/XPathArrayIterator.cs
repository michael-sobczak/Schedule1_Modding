internal class XPathArrayIterator : ResetableIterator // TypeDefIndex: 8594
{
	// Fields
	protected IList list; // 0x18
	protected int index; // 0x20

	// Properties
	public override XPathNavigator Current { get; }
	public override int CurrentPosition { get; }
	public override int Count { get; }

	// Methods

	// RVA: 0x24B55E0 Offset: 0x24B3FE0 VA: 0x1824B55E0
	public void .ctor(XPathArrayIterator it) { }

	// RVA: 0x24B5630 Offset: 0x24B4030 VA: 0x1824B5630
	public void .ctor(XPathNodeIterator nodeIterator) { }

	// RVA: 0x24B5420 Offset: 0x24B3E20 VA: 0x1824B5420 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x24B5820 Offset: 0x24B4220 VA: 0x1824B5820 Slot: 8
	public override XPathNavigator get_Current() { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440 Slot: 9
	public override int get_CurrentPosition() { }

	// RVA: 0x24B57D0 Offset: 0x24B41D0 VA: 0x1824B57D0 Slot: 10
	public override int get_Count() { }

	// RVA: 0x24B5560 Offset: 0x24B3F60 VA: 0x1824B5560 Slot: 7
	public override bool MoveNext() { }

	// RVA: 0x24B55D0 Offset: 0x24B3FD0 VA: 0x1824B55D0 Slot: 12
	public override void Reset() { }

	// RVA: 0x24B54A0 Offset: 0x24B3EA0 VA: 0x1824B54A0 Slot: 11
	public override IEnumerator GetEnumerator() { }
}
