internal class Datatype_float : Datatype_anySimpleType // TypeDefIndex: 8289
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

	// RVA: 0x2584790 Offset: 0x2583190 VA: 0x182584790 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x2585A60 Offset: 0x2584460 VA: 0x182585A60 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1CDA040 Offset: 0x1CD8A40 VA: 0x181CDA040 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x2585B00 Offset: 0x2584500 VA: 0x182585B00 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x2585AB0 Offset: 0x25844B0 VA: 0x182585AB0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x2583B20 Offset: 0x2582520 VA: 0x182583B20 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x25856F0 Offset: 0x25840F0 VA: 0x1825856F0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x2585770 Offset: 0x2584170 VA: 0x182585770 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x25859E0 Offset: 0x25843E0 VA: 0x1825859E0
	public void .ctor() { }

	// RVA: 0x2585900 Offset: 0x2584300 VA: 0x182585900
	private static void .cctor() { }
}
