internal sealed class XPathAncestorQuery : CacheAxisQuery // TypeDefIndex: 8593
{
	// Fields
	private bool _matchSelf; // 0x60

	// Properties
	public override int CurrentPosition { get; }
	public override QueryProps Properties { get; }

	// Methods

	// RVA: 0x24B5360 Offset: 0x24B3D60 VA: 0x1824B5360
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest, bool matchSelf) { }

	// RVA: 0x24B5390 Offset: 0x24B3D90 VA: 0x1824B5390
	private void .ctor(XPathAncestorQuery other) { }

	// RVA: 0x24B5210 Offset: 0x24B3C10 VA: 0x1824B5210 Slot: 14
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x24B51A0 Offset: 0x24B3BA0 VA: 0x1824B51A0 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x24B53D0 Offset: 0x24B3DD0 VA: 0x1824B53D0 Slot: 9
	public override int get_CurrentPosition() { }

	// RVA: 0x24B26C0 Offset: 0x24B10C0 VA: 0x1824B26C0 Slot: 17
	public override QueryProps get_Properties() { }
}
