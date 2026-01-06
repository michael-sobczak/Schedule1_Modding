internal abstract class FacetsChecker // TypeDefIndex: 8348
{
	// Methods

	// RVA: 0x258DE70 Offset: 0x258C870 VA: 0x18258DE70 Slot: 4
	internal virtual Exception CheckLexicalFacets(ref string parseString, XmlSchemaDatatype datatype) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 5
	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	internal virtual Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 7
	internal virtual Exception CheckValueFacets(long value, XmlSchemaDatatype datatype) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 8
	internal virtual Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 9
	internal virtual Exception CheckValueFacets(short value, XmlSchemaDatatype datatype) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 10
	internal virtual Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 11
	internal virtual Exception CheckValueFacets(double value, XmlSchemaDatatype datatype) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 12
	internal virtual Exception CheckValueFacets(float value, XmlSchemaDatatype datatype) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 13
	internal virtual Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 14
	internal virtual Exception CheckValueFacets(byte[] value, XmlSchemaDatatype datatype) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 15
	internal virtual Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 16
	internal virtual Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype) { }

	// RVA: 0x258E240 Offset: 0x258CC40 VA: 0x18258E240
	internal void CheckWhitespaceFacets(ref string s, XmlSchemaDatatype datatype) { }

	// RVA: 0x258E0D0 Offset: 0x258CAD0 VA: 0x18258E0D0
	internal Exception CheckPatternFacets(RestrictionFacets restriction, string value) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 17
	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x258E340 Offset: 0x258CD40 VA: 0x18258E340 Slot: 18
	internal virtual RestrictionFacets ConstructRestriction(DatatypeImplementation datatype, XmlSchemaObjectCollection facets, XmlNameTable nameTable) { }

	// RVA: 0x258E880 Offset: 0x258D280 VA: 0x18258E880
	internal static Decimal Power(int x, int y) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
