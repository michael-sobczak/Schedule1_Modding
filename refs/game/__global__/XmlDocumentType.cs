public class XmlDocumentType : XmlLinkedNode // TypeDefIndex: 8045
{
	// Fields
	private string name; // 0x20
	private string publicId; // 0x28
	private string systemId; // 0x30
	private string internalSubset; // 0x38
	private bool namespaces; // 0x40
	private XmlNamedNodeMap entities; // 0x48
	private XmlNamedNodeMap notations; // 0x50
	private SchemaInfo schemaInfo; // 0x58

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override bool IsReadOnly { get; }
	public XmlNamedNodeMap Entities { get; }
	public XmlNamedNodeMap Notations { get; }
	public string PublicId { get; }
	public string SystemId { get; }
	public string InternalSubset { get; }
	internal bool ParseWithNamespaces { get; }
	internal SchemaInfo DtdSchemaInfo { get; set; }

	// Methods

	// RVA: 0x250D570 Offset: 0x250BF70 VA: 0x18250D570
	protected internal void .ctor(string name, string publicId, string systemId, string internalSubset, XmlDocument doc) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 38
	public override string get_LocalName() { }

	// RVA: 0xA2A280 Offset: 0xA28C80 VA: 0x180A2A280 Slot: 11
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x250D4C0 Offset: 0x250BEC0 VA: 0x18250D4C0 Slot: 33
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 39
	public override bool get_IsReadOnly() { }

	// RVA: 0x250D740 Offset: 0x250C140 VA: 0x18250D740
	public XmlNamedNodeMap get_Entities() { }

	// RVA: 0x250D7C0 Offset: 0x250C1C0 VA: 0x18250D7C0
	public XmlNamedNodeMap get_Notations() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_PublicId() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_SystemId() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public string get_InternalSubset() { }

	// RVA: 0x4988A0 Offset: 0x4972A0 VA: 0x1804988A0
	internal bool get_ParseWithNamespaces() { }

	// RVA: 0x250D520 Offset: 0x250BF20 VA: 0x18250D520 Slot: 45
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 46
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	internal SchemaInfo get_DtdSchemaInfo() { }

	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	internal void set_DtdSchemaInfo(SchemaInfo value) { }
}
