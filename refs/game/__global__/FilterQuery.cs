internal sealed class FilterQuery : BaseAxisQuery // TypeDefIndex: 8554
{
	// Fields
	private Query _cond; // 0x58
	private bool _noPosition; // 0x60

	// Properties
	public Query Condition { get; }
	public override QueryProps Properties { get; }

	// Methods

	// RVA: 0x2499910 Offset: 0x2498310 VA: 0x182499910
	public void .ctor(Query qyParent, Query cond, bool noPosition) { }

	// RVA: 0x2499960 Offset: 0x2498360 VA: 0x182499960
	private void .ctor(FilterQuery other) { }

	// RVA: 0x2499770 Offset: 0x2498170 VA: 0x182499770 Slot: 12
	public override void Reset() { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public Query get_Condition() { }

	// RVA: 0x24997E0 Offset: 0x24981E0 VA: 0x1824997E0 Slot: 13
	public override void SetXsltContext(XsltContext input) { }

	// RVA: 0x24993F0 Offset: 0x2497DF0 VA: 0x1824993F0 Slot: 15
	public override XPathNavigator Advance() { }

	// RVA: 0x2499570 Offset: 0x2497F70 VA: 0x182499570
	internal bool EvaluatePredicate() { }

	// RVA: 0x2499A30 Offset: 0x2498430 VA: 0x182499A30 Slot: 17
	public override QueryProps get_Properties() { }

	// RVA: 0x2499470 Offset: 0x2497E70 VA: 0x182499470 Slot: 6
	public override XPathNodeIterator Clone() { }
}
