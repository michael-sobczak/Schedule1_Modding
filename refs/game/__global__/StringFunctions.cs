internal sealed class StringFunctions : ValueQuery // TypeDefIndex: 8588
{
	// Fields
	private Function.FunctionType _funcType; // 0x18
	private IList<Query> _argList; // 0x20
	private static readonly CompareInfo s_compareInfo; // 0x0

	// Properties
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0x24B4060 Offset: 0x24B2A60 VA: 0x1824B4060
	public void .ctor(Function.FunctionType funcType, IList<Query> argList) { }

	// RVA: 0x24B40B0 Offset: 0x24B2AB0 VA: 0x1824B40B0
	private void .ctor(StringFunctions other) { }

	// RVA: 0x24B3280 Offset: 0x24B1C80 VA: 0x1824B3280 Slot: 13
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x24B2B00 Offset: 0x24B1500 VA: 0x1824B2B00 Slot: 14
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x24B46D0 Offset: 0x24B30D0 VA: 0x1824B46D0
	internal static string toString(double num) { }

	// RVA: 0x24B4340 Offset: 0x24B2D40 VA: 0x1824B4340
	internal static string toString(bool b) { }

	// RVA: 0x24B4390 Offset: 0x24B2D90 VA: 0x1824B4390
	private string toString(XPathNodeIterator nodeIterator) { }

	// RVA: 0x24B4310 Offset: 0x24B2D10 VA: 0x1824B4310 Slot: 16
	public override XPathResultType get_StaticType() { }

	// RVA: 0x24B2740 Offset: 0x24B1140 VA: 0x1824B2740
	private string Concat(XPathNodeIterator nodeIterator) { }

	// RVA: 0x24B3440 Offset: 0x24B1E40 VA: 0x1824B3440
	private bool StartsWith(XPathNodeIterator nodeIterator) { }

	// RVA: 0x24B2990 Offset: 0x24B1390 VA: 0x1824B2990
	private bool Contains(XPathNodeIterator nodeIterator) { }

	// RVA: 0x24B3890 Offset: 0x24B2290 VA: 0x1824B3890
	private string SubstringBefore(XPathNodeIterator nodeIterator) { }

	// RVA: 0x24B36B0 Offset: 0x24B20B0 VA: 0x1824B36B0
	private string SubstringAfter(XPathNodeIterator nodeIterator) { }

	// RVA: 0x24B3A60 Offset: 0x24B2460 VA: 0x1824B3A60
	private string Substring(XPathNodeIterator nodeIterator) { }

	// RVA: 0x24B35A0 Offset: 0x24B1FA0 VA: 0x1824B35A0
	private double StringLength(XPathNodeIterator nodeIterator) { }

	// RVA: 0x24B3050 Offset: 0x24B1A50 VA: 0x1824B3050
	private string Normalize(XPathNodeIterator nodeIterator) { }

	// RVA: 0x24B3D20 Offset: 0x24B2720 VA: 0x1824B3D20
	private string Translate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x24B26E0 Offset: 0x24B10E0 VA: 0x1824B26E0 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x24B3FC0 Offset: 0x24B29C0 VA: 0x1824B3FC0
	private static void .cctor() { }
}
