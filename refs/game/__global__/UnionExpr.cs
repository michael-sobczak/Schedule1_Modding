internal sealed class UnionExpr : Query // TypeDefIndex: 8589
{
	// Fields
	internal Query qy1; // 0x18
	internal Query qy2; // 0x20
	private bool _advance1; // 0x28
	private bool _advance2; // 0x29
	private XPathNavigator _currentNode; // 0x30
	private XPathNavigator _nextNode; // 0x38

	// Properties
	public override XPathResultType StaticType { get; }
	public override XPathNavigator Current { get; }
	public override int CurrentPosition { get; }

	// Methods

	// RVA: 0x24B4CC0 Offset: 0x24B36C0 VA: 0x1824B4CC0
	public void .ctor(Query query1, Query query2) { }

	// RVA: 0x24B4AD0 Offset: 0x24B34D0 VA: 0x1824B4AD0
	private void .ctor(UnionExpr other) { }

	// RVA: 0x24B4A60 Offset: 0x24B3460 VA: 0x1824B4A60 Slot: 12
	public override void Reset() { }

	// RVA: 0x2495C70 Offset: 0x2494670 VA: 0x182495C70 Slot: 13
	public override void SetXsltContext(XsltContext xsltContext) { }

	// RVA: 0x24B4900 Offset: 0x24B3300 VA: 0x1824B4900 Slot: 14
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x24B4A20 Offset: 0x24B3420 VA: 0x1824B4A20
	private XPathNavigator ProcessSamePosition(XPathNavigator result) { }

	// RVA: 0x24B49D0 Offset: 0x24B33D0 VA: 0x1824B49D0
	private XPathNavigator ProcessBeforePosition(XPathNavigator res1, XPathNavigator res2) { }

	// RVA: 0x24B4980 Offset: 0x24B3380 VA: 0x1824B4980
	private XPathNavigator ProcessAfterPosition(XPathNavigator res1, XPathNavigator res2) { }

	// RVA: 0x24B4720 Offset: 0x24B3120 VA: 0x1824B4720 Slot: 15
	public override XPathNavigator Advance() { }

	// RVA: 0x583670 Offset: 0x582070 VA: 0x180583670 Slot: 16
	public override XPathResultType get_StaticType() { }

	// RVA: 0x24B48A0 Offset: 0x24B32A0 VA: 0x1824B48A0 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0 Slot: 8
	public override XPathNavigator get_Current() { }

	// RVA: 0x24B4D20 Offset: 0x24B3720 VA: 0x1824B4D20 Slot: 9
	public override int get_CurrentPosition() { }
}
