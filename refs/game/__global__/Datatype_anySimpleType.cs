internal class Datatype_anySimpleType : DatatypeImplementation // TypeDefIndex: 8284
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override Type ValueType { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override Type ListValueType { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0x2581A30 Offset: 0x2580430 VA: 0x182581A30 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x2581BE0 Offset: 0x25805E0 VA: 0x182581BE0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x2581C80 Offset: 0x2580680 VA: 0x182581C80 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0xA2A280 Offset: 0xA28C80 VA: 0x180A2A280 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x2581C30 Offset: 0x2580630 VA: 0x182581C30 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x8793B0 Offset: 0x877DB0 VA: 0x1808793B0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x25819C0 Offset: 0x25803C0 VA: 0x1825819C0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x2581A80 Offset: 0x2580480 VA: 0x182581A80 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x2581B90 Offset: 0x2580590 VA: 0x182581B90
	public void .ctor() { }

	// RVA: 0x2581AB0 Offset: 0x25804B0 VA: 0x182581AB0
	private static void .cctor() { }
}
