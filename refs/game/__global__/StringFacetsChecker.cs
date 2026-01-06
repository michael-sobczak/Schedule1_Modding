internal class StringFacetsChecker : FacetsChecker // TypeDefIndex: 8353
{
	// Fields
	private static Regex languagePattern; // 0x0

	// Properties
	private static Regex LanguagePattern { get; }

	// Methods

	// RVA: 0x2596BA0 Offset: 0x25955A0 VA: 0x182596BA0
	private static Regex get_LanguagePattern() { }

	// RVA: 0x25964D0 Offset: 0x2594ED0 VA: 0x1825964D0 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x25964B0 Offset: 0x2594EB0 VA: 0x1825964B0 Slot: 13
	internal override Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	// RVA: 0x2596560 Offset: 0x2594F60 VA: 0x182596560
	internal Exception CheckValueFacets(string value, XmlSchemaDatatype datatype, bool verifyUri) { }

	// RVA: 0x2596990 Offset: 0x2595390 VA: 0x182596990 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x25967C0 Offset: 0x25951C0 VA: 0x1825967C0
	private bool MatchEnumeration(string value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x25961B0 Offset: 0x2594BB0 VA: 0x1825961B0
	private Exception CheckBuiltInFacets(string s, XmlTypeCode typeCode, bool verifyUri) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
