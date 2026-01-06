public class XElement : XContainer, IXmlSerializable // TypeDefIndex: 18622
{
	// Fields
	internal XName name; // 0x30
	internal XAttribute lastAttr; // 0x38

	// Properties
	public bool HasAttributes { get; }
	public bool IsEmpty { get; }
	public XName Name { get; }
	public override XmlNodeType NodeType { get; }
	public string Value { get; set; }

	// Methods

	// RVA: 0x23C9490 Offset: 0x23C7E90 VA: 0x1823C9490
	public void .ctor(XName name) { }

	// RVA: 0x23C9270 Offset: 0x23C7C70 VA: 0x1823C9270
	public void .ctor(XElement other) { }

	// RVA: 0x23C9400 Offset: 0x23C7E00 VA: 0x1823C9400
	public void .ctor(XStreamingElement other) { }

	// RVA: 0xC0E4D0 Offset: 0xC0CED0 VA: 0x180C0E4D0
	public bool get_HasAttributes() { }

	// RVA: 0x23C9510 Offset: 0x23C7F10 VA: 0x1823C9510
	public bool get_IsEmpty() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public XName get_Name() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x23C9520 Offset: 0x23C7F20 VA: 0x1823C9520
	public string get_Value() { }

	// RVA: 0x23C9640 Offset: 0x23C8040 VA: 0x1823C9640
	public void set_Value(string value) { }

	// RVA: 0x23C7F40 Offset: 0x23C6940 VA: 0x1823C7F40
	public XAttribute Attribute(XName name) { }

	// RVA: 0x23C7F80 Offset: 0x23C6980 VA: 0x1823C7F80
	public IEnumerable<XAttribute> Attributes() { }

	// RVA: 0x23C8380 Offset: 0x23C6D80 VA: 0x1823C8380
	public string GetPrefixOfNamespace(XNamespace ns) { }

	// RVA: 0x23C91B0 Offset: 0x23C7BB0 VA: 0x1823C91B0 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 15
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x23C8DF0 Offset: 0x23C77F0 VA: 0x1823C8DF0 Slot: 16
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x79ED10 Offset: 0x79D710 VA: 0x18079ED10 Slot: 17
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x23C7AD0 Offset: 0x23C64D0 VA: 0x1823C7AD0 Slot: 11
	internal override void AddAttribute(XAttribute a) { }

	// RVA: 0x23C7950 Offset: 0x23C6350 VA: 0x1823C7950 Slot: 12
	internal override void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x23C7DC0 Offset: 0x23C67C0 VA: 0x1823C7DC0
	internal void AppendAttribute(XAttribute a) { }

	// RVA: 0x23C7D30 Offset: 0x23C6730 VA: 0x1823C7D30
	internal void AppendAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x23C8010 Offset: 0x23C6A10 VA: 0x1823C8010 Slot: 10
	internal override XNode CloneNode() { }

	[IteratorStateMachine(typeof(XElement.<GetAttributes>d__116))]
	// RVA: 0x23C81D0 Offset: 0x23C6BD0 VA: 0x1823C81D0
	private IEnumerable<XAttribute> GetAttributes(XName name) { }

	// RVA: 0x23C8260 Offset: 0x23C6C60 VA: 0x1823C8260
	private string GetNamespaceOfPrefixInScope(string prefix, XElement outOfScope) { }

	// RVA: 0x23C8CD0 Offset: 0x23C76D0 VA: 0x1823C8CD0
	private void ReadElementFrom(XmlReader r, LoadOptions o) { }

	// RVA: 0x23C8650 Offset: 0x23C7050 VA: 0x1823C8650
	private void ReadElementFromImpl(XmlReader r, LoadOptions o) { }

	// RVA: 0x23C8D70 Offset: 0x23C7770 VA: 0x1823C8D70
	internal void SetEndElementLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x23C9010 Offset: 0x23C7A10 VA: 0x1823C9010 Slot: 13
	internal override void ValidateNode(XNode node, XNode previous) { }
}
