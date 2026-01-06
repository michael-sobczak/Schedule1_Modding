public sealed class XmlAttributeCollection : XmlNamedNodeMap, ICollection, IEnumerable // TypeDefIndex: 8036
{
	// Properties
	public XmlAttribute ItemOf { get; }
	public XmlAttribute ItemOf { get; }
	public XmlAttribute ItemOf { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private int System.Collections.ICollection.Count { get; }

	// Methods

	// RVA: 0x22B0EA0 Offset: 0x22AF8A0 VA: 0x1822B0EA0
	internal void .ctor(XmlNode parent) { }

	// RVA: 0x24EF930 Offset: 0x24EE330 VA: 0x1824EF930
	public XmlAttribute get_ItemOf(int i) { }

	// RVA: 0x24EFA20 Offset: 0x24EE420 VA: 0x1824EFA20
	public XmlAttribute get_ItemOf(string name) { }

	// RVA: 0x24EF7E0 Offset: 0x24EE1E0 VA: 0x1824EF7E0
	public XmlAttribute get_ItemOf(string localName, string namespaceURI) { }

	// RVA: 0x24EE800 Offset: 0x24ED200 VA: 0x1824EE800
	internal int FindNodeOffsetNS(XmlAttribute node) { }

	// RVA: 0x24EF520 Offset: 0x24EDF20 VA: 0x1824EF520 Slot: 6
	public override XmlNode SetNamedItem(XmlNode node) { }

	// RVA: 0x24EE530 Offset: 0x24ECF30 VA: 0x1824EE530
	public XmlAttribute Append(XmlAttribute node) { }

	// RVA: 0x24EF3A0 Offset: 0x24EDDA0 VA: 0x1824EF3A0
	public XmlAttribute Remove(XmlAttribute node) { }

	// RVA: 0x24EEE80 Offset: 0x24ED880 VA: 0x1824EEE80
	public XmlAttribute RemoveAt(int i) { }

	// RVA: 0x24EEDA0 Offset: 0x24ED7A0 VA: 0x1824EEDA0
	public void RemoveAll() { }

	// RVA: 0x24EF740 Offset: 0x24EE140 VA: 0x1824EF740 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x24EF7D0 Offset: 0x24EE1D0 VA: 0x1824EF7D0 Slot: 14
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x24EE340 Offset: 0x24ECD40 VA: 0x1824EE340 Slot: 9
	internal override XmlNode AddNode(XmlNode node) { }

	// RVA: 0x24EE9A0 Offset: 0x24ED3A0 VA: 0x1824EE9A0 Slot: 12
	internal override XmlNode InsertNodeAt(int i, XmlNode node) { }

	// RVA: 0x24EF030 Offset: 0x24EDA30 VA: 0x1824EF030 Slot: 11
	internal override XmlNode RemoveNodeAt(int i) { }

	// RVA: 0x24EE720 Offset: 0x24ED120 VA: 0x1824EE720
	internal void Detach(XmlAttribute attr) { }

	// RVA: 0x24EEA40 Offset: 0x24ED440 VA: 0x1824EEA40
	internal void InsertParentIntoElementIdAttrMap(XmlAttribute attr) { }

	// RVA: 0x24EF210 Offset: 0x24EDC10 VA: 0x1824EF210
	internal void RemoveParentFromElementIdAttrMap(XmlAttribute attr) { }

	// RVA: 0x24EEF30 Offset: 0x24ED930 VA: 0x1824EEF30
	internal int RemoveDuplicateAttribute(XmlAttribute attr) { }

	// RVA: 0x24EEC90 Offset: 0x24ED690 VA: 0x1824EEC90
	internal bool PrepareParentInElementIdAttrMap(string attrPrefix, string attrLocalName) { }

	// RVA: 0x24EF440 Offset: 0x24EDE40 VA: 0x1824EF440
	internal void ResetParentInElementIdAttrMap(string oldVal, string newVal) { }

	// RVA: 0x24EEBD0 Offset: 0x24ED5D0 VA: 0x1824EEBD0
	internal XmlAttribute InternalAppendAttribute(XmlAttribute node) { }
}
