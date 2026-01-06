internal class XPathNodeList : XmlNodeList // TypeDefIndex: 8033
{
	// Fields
	private List<XmlNode> list; // 0x10
	private XPathNodeIterator nodeIterator; // 0x18
	private bool done; // 0x20
	private static readonly object[] nullparams; // 0x0

	// Properties
	public override int Count { get; }

	// Methods

	// RVA: 0x24EE250 Offset: 0x24ECC50 VA: 0x1824EE250
	public void .ctor(XPathNodeIterator nodeIterator) { }

	// RVA: 0x24EE2E0 Offset: 0x24ECCE0 VA: 0x1824EE2E0 Slot: 7
	public override int get_Count() { }

	// RVA: 0x24EDF30 Offset: 0x24EC930 VA: 0x1824EDF30
	private XmlNode GetNode(XPathNavigator n) { }

	// RVA: 0x24EE0E0 Offset: 0x24ECAE0 VA: 0x1824EE0E0
	internal int ReadUntil(int index) { }

	// RVA: 0x24EE040 Offset: 0x24ECA40 VA: 0x1824EE040 Slot: 6
	public override XmlNode Item(int index) { }

	// RVA: 0x24EDEC0 Offset: 0x24EC8C0 VA: 0x1824EDEC0 Slot: 8
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x24EE1E0 Offset: 0x24ECBE0 VA: 0x1824EE1E0
	private static void .cctor() { }
}
