internal class Datatype_QName : Datatype_anySimpleType // TypeDefIndex: 8311
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0x2580960 Offset: 0x257F360 VA: 0x182580960 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x25817F0 Offset: 0x25801F0 VA: 0x1825817F0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xF72990 Offset: 0xF71390 VA: 0x180F72990 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xA2A280 Offset: 0xA28C80 VA: 0x180A2A280 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x2580810 Offset: 0x257F210 VA: 0x182580810 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x25818A0 Offset: 0x25802A0 VA: 0x1825818A0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x2581850 Offset: 0x2580250 VA: 0x182581850 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x25814A0 Offset: 0x257FEA0 VA: 0x1825814A0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x2581770 Offset: 0x2580170 VA: 0x182581770
	public void .ctor() { }

	// RVA: 0x2581690 Offset: 0x2580090 VA: 0x182581690
	private static void .cctor() { }
}
