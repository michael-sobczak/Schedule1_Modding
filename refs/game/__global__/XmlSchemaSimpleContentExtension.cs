public class XmlSchemaSimpleContentExtension : XmlSchemaContent // TypeDefIndex: 8480
{
	// Fields
	private XmlSchemaObjectCollection attributes; // 0x50
	private XmlSchemaAnyAttribute anyAttribute; // 0x58
	private XmlQualifiedName baseTypeName; // 0x60

	// Properties
	[Xml("base")]
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x245EAF0 Offset: 0x245D4F0 VA: 0x18245EAF0
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x245EA40 Offset: 0x245D440 VA: 0x18245EA40
	public void .ctor() { }
}
