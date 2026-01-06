public class XmlSchemaInfo : IXmlSchemaInfo // TypeDefIndex: 8462
{
	// Fields
	private bool isDefault; // 0x10
	private bool isNil; // 0x11
	private XmlSchemaElement schemaElement; // 0x18
	private XmlSchemaAttribute schemaAttribute; // 0x20
	private XmlSchemaType schemaType; // 0x28
	private XmlSchemaSimpleType memberType; // 0x30
	private XmlSchemaValidity validity; // 0x38
	private XmlSchemaContentType contentType; // 0x3C

	// Properties
	public XmlSchemaValidity Validity { get; set; }
	public bool IsDefault { get; set; }
	public bool IsNil { get; set; }
	public XmlSchemaSimpleType MemberType { get; set; }
	public XmlSchemaType SchemaType { get; set; }
	public XmlSchemaElement SchemaElement { get; set; }
	public XmlSchemaAttribute SchemaAttribute { get; set; }
	public XmlSchemaContentType ContentType { get; }
	internal XmlSchemaType XmlType { get; }
	internal bool HasDefaultValue { get; }
	internal bool IsUnionType { get; }

	// Methods

	// RVA: 0x244BE50 Offset: 0x244A850 VA: 0x18244BE50
	public void .ctor() { }

	// RVA: 0x244BDD0 Offset: 0x244A7D0 VA: 0x18244BDD0
	internal void .ctor(XmlSchemaValidity validity) { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50 Slot: 4
	public XmlSchemaValidity get_Validity() { }

	// RVA: 0x4E2930 Offset: 0x4E1330 VA: 0x1804E2930
	public void set_Validity(XmlSchemaValidity value) { }

	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40 Slot: 5
	public bool get_IsDefault() { }

	// RVA: 0x498A80 Offset: 0x497480 VA: 0x180498A80
	public void set_IsDefault(bool value) { }

	// RVA: 0x498A50 Offset: 0x497450 VA: 0x180498A50 Slot: 6
	public bool get_IsNil() { }

	// RVA: 0x498A90 Offset: 0x497490 VA: 0x180498A90
	public void set_IsNil(bool value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0 Slot: 7
	public XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_MemberType(XmlSchemaSimpleType value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0 Slot: 8
	public XmlSchemaType get_SchemaType() { }

	// RVA: 0x244BFE0 Offset: 0x244A9E0 VA: 0x18244BFE0
	public void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 9
	public XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x244BFA0 Offset: 0x244A9A0 VA: 0x18244BFA0
	public void set_SchemaElement(XmlSchemaElement value) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 10
	public XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x244BF60 Offset: 0x244A960 VA: 0x18244BF60
	public void set_SchemaAttribute(XmlSchemaAttribute value) { }

	// RVA: 0xC21BD0 Offset: 0xC205D0 VA: 0x180C21BD0
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x244BF40 Offset: 0x244A940 VA: 0x18244BF40
	internal XmlSchemaType get_XmlType() { }

	// RVA: 0x244BEC0 Offset: 0x244A8C0 VA: 0x18244BEC0
	internal bool get_HasDefaultValue() { }

	// RVA: 0x244BF00 Offset: 0x244A900 VA: 0x18244BF00
	internal bool get_IsUnionType() { }

	// RVA: 0x244BD60 Offset: 0x244A760 VA: 0x18244BD60
	internal void Clear() { }
}
