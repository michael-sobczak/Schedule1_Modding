internal class Datatype_string : Datatype_anySimpleType // TypeDefIndex: 8287
{
	// Properties
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x2587740 Offset: 0x2586140 VA: 0x182587740 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x25878E0 Offset: 0x25862E0 VA: 0x1825878E0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x8793B0 Offset: 0x877DB0 VA: 0x1808793B0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x2580810 Offset: 0x257F210 VA: 0x182580810 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x2587750 Offset: 0x2586150 VA: 0x182587750 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x2587860 Offset: 0x2586260 VA: 0x182587860
	public void .ctor() { }
}
