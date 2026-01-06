public class XmlSchemaSimpleContentRestriction : XmlSchemaContent // TypeDefIndex: 8481
{
	// Fields
	private XmlQualifiedName baseTypeName; // 0x50
	private XmlSchemaSimpleType baseType; // 0x58
	private XmlSchemaObjectCollection facets; // 0x60
	private XmlSchemaObjectCollection attributes; // 0x68
	private XmlSchemaAnyAttribute anyAttribute; // 0x70

	// Properties
	[Xml("base")]
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaSimpleType BaseType { get; set; }
	[XmlElement("pattern", typeof(XmlSchemaPatternFacet))]
	[XmlElement("maxLength", typeof(XmlSchemaMaxLengthFacet))]
	[XmlElement("length", typeof(XmlSchemaLengthFacet))]
	[XmlElement("minLength", typeof(XmlSchemaMinLengthFacet))]
	[XmlElement("whiteSpace", typeof(XmlSchemaWhiteSpaceFacet))]
	[XmlElement("fractionDigits", typeof(XmlSchemaFractionDigitsFacet))]
	[XmlElement("totalDigits", typeof(XmlSchemaTotalDigitsFacet))]
	[XmlElement("minExclusive", typeof(XmlSchemaMinExclusiveFacet))]
	[XmlElement("minInclusive", typeof(XmlSchemaMinInclusiveFacet))]
	[XmlElement("maxExclusive", typeof(XmlSchemaMaxExclusiveFacet))]
	[XmlElement("maxInclusive", typeof(XmlSchemaMaxInclusiveFacet))]
	[XmlElement("enumeration", typeof(XmlSchemaEnumerationFacet))]
	public XmlSchemaObjectCollection Facets { get; }
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x245EC80 Offset: 0x245D680 VA: 0x18245EC80
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public XmlSchemaSimpleType get_BaseType() { }

	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	public void set_BaseType(XmlSchemaSimpleType value) { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public XmlSchemaObjectCollection get_Facets() { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x245EBA0 Offset: 0x245D5A0 VA: 0x18245EBA0
	public void .ctor() { }
}
