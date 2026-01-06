internal class Datatype_decimal : Datatype_anySimpleType // TypeDefIndex: 8291
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x2584030 Offset: 0x2582A30 VA: 0x182584030 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x2584400 Offset: 0x2582E00 VA: 0x182584400 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xA3E8F0 Offset: 0xA3D2F0 VA: 0x180A3E8F0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x25844B0 Offset: 0x2582EB0 VA: 0x1825844B0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x2584450 Offset: 0x2582E50 VA: 0x182584450 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x25844A0 Offset: 0x2582EA0 VA: 0x1825844A0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x2583F90 Offset: 0x2582990 VA: 0x182583F90 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x2584040 Offset: 0x2582A40 VA: 0x182584040 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x2584380 Offset: 0x2582D80 VA: 0x182584380
	public void .ctor() { }

	// RVA: 0x25841D0 Offset: 0x2582BD0 VA: 0x1825841D0
	private static void .cctor() { }
}
