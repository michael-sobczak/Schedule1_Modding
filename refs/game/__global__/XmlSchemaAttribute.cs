public class XmlSchemaAttribute : XmlSchemaAnnotated // TypeDefIndex: 8414
{
	// Fields
	private string defaultValue; // 0x50
	private string fixedValue; // 0x58
	private string name; // 0x60
	private XmlSchemaForm form; // 0x68
	private XmlSchemaUse use; // 0x6C
	private XmlQualifiedName refName; // 0x70
	private XmlQualifiedName typeName; // 0x78
	private XmlQualifiedName qualifiedName; // 0x80
	private XmlSchemaSimpleType type; // 0x88
	private XmlSchemaSimpleType attributeType; // 0x90
	private SchemaAttDef attDef; // 0x98

	// Properties
	[Xml("default")]
	[DefaultValue(null)]
	public string DefaultValue { get; set; }
	[Xml("fixed")]
	[DefaultValue(null)]
	public string FixedValue { get; set; }
	[Xml("form")]
	[DefaultValue(0)]
	public XmlSchemaForm Form { get; set; }
	[Xml("name")]
	public string Name { get; set; }
	[Xml("ref")]
	public XmlQualifiedName RefName { get; set; }
	[Xml("type")]
	public XmlQualifiedName SchemaTypeName { get; set; }
	[XmlElement("simpleType")]
	public XmlSchemaSimpleType SchemaType { get; set; }
	[Xml("use")]
	[DefaultValue(0)]
	public XmlSchemaUse Use { get; set; }
	[XmlIgnore]
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnore]
	public XmlSchemaSimpleType AttributeSchemaType { get; }
	[XmlIgnore]
	internal XmlSchemaDatatype Datatype { get; }
	internal SchemaAttDef AttDef { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public string get_DefaultValue() { }

	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	public void set_DefaultValue(string value) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public string get_FixedValue() { }

	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	public void set_FixedValue(string value) { }

	// RVA: 0x54CEB0 Offset: 0x54B8B0 VA: 0x18054CEB0
	public XmlSchemaForm get_Form() { }

	// RVA: 0x54CF80 Offset: 0x54B980 VA: 0x18054CF80
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public string get_Name() { }

	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	public void set_Name(string value) { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x2445930 Offset: 0x2444330 VA: 0x182445930
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public XmlQualifiedName get_SchemaTypeName() { }

	// RVA: 0x24459E0 Offset: 0x24443E0 VA: 0x1824459E0
	public void set_SchemaTypeName(XmlQualifiedName value) { }

	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080
	public XmlSchemaSimpleType get_SchemaType() { }

	// RVA: 0x589030 Offset: 0x587A30 VA: 0x180589030
	public void set_SchemaType(XmlSchemaSimpleType value) { }

	// RVA: 0xA9F7F0 Offset: 0xA9E1F0 VA: 0x180A9F7F0
	public XmlSchemaUse get_Use() { }

	// RVA: 0xA9F820 Offset: 0xA9E220 VA: 0x180A9F820
	public void set_Use(XmlSchemaUse value) { }

	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	public XmlSchemaSimpleType get_AttributeSchemaType() { }

	// RVA: 0x2445910 Offset: 0x2444310 VA: 0x182445910
	internal XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x6EA770 Offset: 0x6E9170 VA: 0x1806EA770
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x614510 Offset: 0x612F10 VA: 0x180614510
	internal void SetAttributeType(XmlSchemaSimpleType value) { }

	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	internal SchemaAttDef get_AttDef() { }

	// RVA: 0xAA72B0 Offset: 0xAA5CB0 VA: 0x180AA72B0
	internal void set_AttDef(SchemaAttDef value) { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x2445760 Offset: 0x2444160 VA: 0x182445760 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x2445860 Offset: 0x2444260 VA: 0x182445860
	public void .ctor() { }
}
