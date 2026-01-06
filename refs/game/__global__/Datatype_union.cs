internal class Datatype_union : Datatype_anySimpleType // TypeDefIndex: 8283
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private XmlSchemaSimpleType[] types; // 0x38

	// Properties
	public override Type ValueType { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override FacetsChecker FacetsChecker { get; }
	internal override Type ListValueType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	internal XmlSchemaSimpleType[] BaseMemberTypes { get; }

	// Methods

	// RVA: 0x2587B30 Offset: 0x2586530 VA: 0x182587B30 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x2588470 Offset: 0x2586E70 VA: 0x182588470
	internal void .ctor(XmlSchemaSimpleType[] types) { }

	// RVA: 0x2587A20 Offset: 0x2586420 VA: 0x182587A20 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x25885C0 Offset: 0x2586FC0 VA: 0x1825885C0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0xA2A280 Offset: 0xA28C80 VA: 0x180A2A280 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x2588510 Offset: 0x2586F10 VA: 0x182588510 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x2588570 Offset: 0x2586F70 VA: 0x182588570 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0xF72850 Offset: 0xF71250 VA: 0x180F72850 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	internal XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	// RVA: 0x2587B40 Offset: 0x2586540 VA: 0x182587B40
	internal bool HasAtomicMembers() { }

	// RVA: 0x2587BF0 Offset: 0x25865F0 VA: 0x182587BF0
	internal bool IsUnionBaseOf(DatatypeImplementation derivedType) { }

	// RVA: 0x2587CA0 Offset: 0x25866A0 VA: 0x182587CA0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x2587F20 Offset: 0x2586920 VA: 0x182587F20 Slot: 17
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x2588390 Offset: 0x2586D90 VA: 0x182588390
	private static void .cctor() { }
}
