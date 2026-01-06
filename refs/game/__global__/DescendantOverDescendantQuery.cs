internal sealed class DescendantOverDescendantQuery : DescendantBaseQuery // TypeDefIndex: 8549
{
	// Fields
	private int _level; // 0x60

	// Methods

	// RVA: 0x24984E0 Offset: 0x2496EE0 VA: 0x1824984E0
	public void .ctor(Query qyParent, bool matchSelf, string name, string prefix, XPathNodeType typeTest, bool abbrAxis) { }

	// RVA: 0x24984A0 Offset: 0x2496EA0 VA: 0x1824984A0
	private void .ctor(DescendantOverDescendantQuery other) { }

	// RVA: 0x2498450 Offset: 0x2496E50 VA: 0x182498450 Slot: 12
	public override void Reset() { }

	// RVA: 0x24981A0 Offset: 0x2496BA0 VA: 0x1824981A0 Slot: 15
	public override XPathNavigator Advance() { }

	// RVA: 0x24983A0 Offset: 0x2496DA0 VA: 0x1824983A0
	private bool MoveToFirstChild() { }

	// RVA: 0x24983E0 Offset: 0x2496DE0 VA: 0x1824983E0
	private bool MoveUpUntilNext() { }

	// RVA: 0x2498330 Offset: 0x2496D30 VA: 0x182498330 Slot: 6
	public override XPathNodeIterator Clone() { }
}
