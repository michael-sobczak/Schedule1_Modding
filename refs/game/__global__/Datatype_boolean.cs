internal class Datatype_boolean : Datatype_anySimpleType // TypeDefIndex: 8288
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x2582730 Offset: 0x2581130 VA: 0x182582730 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x25829C0 Offset: 0x25813C0 VA: 0x1825829C0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x572F50 Offset: 0x571950 VA: 0x180572F50 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x2582A60 Offset: 0x2581460 VA: 0x182582A60 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x2582A10 Offset: 0x2581410 VA: 0x182582A10 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0xB648E0 Offset: 0xB632E0 VA: 0x180B648E0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x25826A0 Offset: 0x25810A0 VA: 0x1825826A0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x2582740 Offset: 0x2581140 VA: 0x182582740 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x2582940 Offset: 0x2581340 VA: 0x182582940
	public void .ctor() { }

	// RVA: 0x2582860 Offset: 0x2581260 VA: 0x182582860
	private static void .cctor() { }
}
