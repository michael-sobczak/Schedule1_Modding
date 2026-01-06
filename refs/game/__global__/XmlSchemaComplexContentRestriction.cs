public class XmlSchemaComplexContentRestriction : XmlSchemaContent // TypeDefIndex: 8424
{
	// Fields
	private XmlSchemaParticle particle; // 0x50
	private XmlSchemaObjectCollection attributes; // 0x58
	private XmlSchemaAnyAttribute anyAttribute; // 0x60
	private XmlQualifiedName baseTypeName; // 0x68

	// Properties
	[Xml("base")]
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("all", typeof(XmlSchemaAll))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	public XmlSchemaParticle Particle { get; set; }
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x2446AB0 Offset: 0x24454B0 VA: 0x182446AB0
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x2446A00 Offset: 0x2445400 VA: 0x182446A00
	public void .ctor() { }
}
