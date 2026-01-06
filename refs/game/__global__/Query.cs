internal abstract class Query : ResetableIterator // TypeDefIndex: 8581
{
	// Properties
	public override int Count { get; }
	public abstract XPathResultType StaticType { get; }
	public virtual QueryProps Properties { get; }

	// Methods

	// RVA: 0x24B24B0 Offset: 0x24B0EB0 VA: 0x1824B24B0
	public void .ctor() { }

	// RVA: 0x24B24D0 Offset: 0x24B0ED0 VA: 0x1824B24D0
	protected void .ctor(Query other) { }

	// RVA: 0x24B2480 Offset: 0x24B0E80 VA: 0x1824B2480 Slot: 7
	public override bool MoveNext() { }

	// RVA: 0x24B2510 Offset: 0x24B0F10 VA: 0x1824B2510 Slot: 10
	public override int get_Count() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 13
	public virtual void SetXsltContext(XsltContext context) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract object Evaluate(XPathNodeIterator nodeIterator);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract XPathNavigator Advance();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract XPathResultType get_StaticType();

	// RVA: 0xF6D420 Offset: 0xF6BE20 VA: 0x180F6D420 Slot: 17
	public virtual QueryProps get_Properties() { }

	// RVA: 0x24B1F90 Offset: 0x24B0990 VA: 0x1824B1F90
	public static Query Clone(Query input) { }

	// RVA: 0x24B2020 Offset: 0x24B0A20 VA: 0x1824B2020
	protected static XPathNodeIterator Clone(XPathNodeIterator input) { }

	// RVA: 0x24B2040 Offset: 0x24B0A40 VA: 0x1824B2040
	protected static XPathNavigator Clone(XPathNavigator input) { }

	// RVA: 0x24B22B0 Offset: 0x24B0CB0 VA: 0x1824B22B0
	public static bool Insert(List<XPathNavigator> buffer, XPathNavigator nav) { }

	// RVA: 0x24B21B0 Offset: 0x24B0BB0 VA: 0x1824B21B0
	private static int GetMedian(int l, int r) { }

	// RVA: 0x24B2060 Offset: 0x24B0A60 VA: 0x1824B2060
	public static XmlNodeOrder CompareNodes(XPathNavigator l, XPathNavigator r) { }

	// RVA: 0x24B21C0 Offset: 0x24B0BC0 VA: 0x1824B21C0
	protected XPathResultType GetXPathType(object value) { }
}
