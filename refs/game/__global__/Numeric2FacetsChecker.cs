internal class Numeric2FacetsChecker : FacetsChecker // TypeDefIndex: 8350
{
	// Methods

	// RVA: 0x2594E00 Offset: 0x2593800 VA: 0x182594E00 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x2594AA0 Offset: 0x25934A0 VA: 0x182594AA0 Slot: 11
	internal override Exception CheckValueFacets(double value, XmlSchemaDatatype datatype) { }

	// RVA: 0x2594DE0 Offset: 0x25937E0 VA: 0x182594DE0 Slot: 12
	internal override Exception CheckValueFacets(float value, XmlSchemaDatatype datatype) { }

	// RVA: 0x2594F50 Offset: 0x2593950 VA: 0x182594F50 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x2594E90 Offset: 0x2593890 VA: 0x182594E90
	private bool MatchEnumeration(double value, ArrayList enumeration, XmlValueConverter valueConverter) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
