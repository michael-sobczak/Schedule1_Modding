internal class Datatype_duration : Datatype_anySimpleType // TypeDefIndex: 8292
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

	// RVA: 0x2580960 Offset: 0x257F360 VA: 0x182580960 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x2584F90 Offset: 0x2583990 VA: 0x182584F90 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1DF3BD0 Offset: 0x1DF25D0 VA: 0x181DF3BD0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x2585040 Offset: 0x2583A40 VA: 0x182585040 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x2584FF0 Offset: 0x25839F0 VA: 0x182584FF0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x2583B20 Offset: 0x2582520 VA: 0x182583B20 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x2584B80 Offset: 0x2583580 VA: 0x182584B80 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x2584C20 Offset: 0x2583620 VA: 0x182584C20 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x2584F10 Offset: 0x2583910 VA: 0x182584F10
	public void .ctor() { }

	// RVA: 0x2584E30 Offset: 0x2583830 VA: 0x182584E30
	private static void .cctor() { }
}
