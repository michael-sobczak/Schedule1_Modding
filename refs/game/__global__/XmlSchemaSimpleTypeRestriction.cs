public class XmlSchemaSimpleTypeRestriction : XmlSchemaSimpleTypeContent // TypeDefIndex: 8485
{
	// Fields
	private XmlQualifiedName baseTypeName; // 0x50
	private XmlSchemaSimpleType baseType; // 0x58
	private XmlSchemaObjectCollection facets; // 0x60

	// Properties
	[Xml("base")]
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaSimpleType BaseType { get; set; }
	[XmlElement("minInclusive", typeof(XmlSchemaMinInclusiveFacet))]
	[XmlElement("maxLength", typeof(XmlSchemaMaxLengthFacet))]
	[XmlElement("fractionDigits", typeof(XmlSchemaFractionDigitsFacet))]
	[XmlElement("totalDigits", typeof(XmlSchemaTotalDigitsFacet))]
	[XmlElement("length", typeof(XmlSchemaLengthFacet))]
	[XmlElement("maxInclusive", typeof(XmlSchemaMaxInclusiveFacet))]
	[XmlElement("minLength", typeof(XmlSchemaMinLengthFacet))]
	[XmlElement("maxExclusive", typeof(XmlSchemaMaxExclusiveFacet))]
	[XmlElement("minExclusive", typeof(XmlSchemaMinExclusiveFacet))]
	[XmlElement("enumeration", typeof(XmlSchemaEnumerationFacet))]
	[XmlElement("pattern", typeof(XmlSchemaPatternFacet))]
	[XmlElement("whiteSpace", typeof(XmlSchemaWhiteSpaceFacet))]
	public XmlSchemaObjectCollection Facets { get; }

	// Methods

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x245F160 Offset: 0x245DB60 VA: 0x18245F160
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public XmlSchemaSimpleType get_BaseType() { }

	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	public void set_BaseType(XmlSchemaSimpleType value) { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public XmlSchemaObjectCollection get_Facets() { }

	// RVA: 0x245EF80 Offset: 0x245D980 VA: 0x18245EF80 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x245F0B0 Offset: 0x245DAB0 VA: 0x18245F0B0
	public void .ctor() { }
}
