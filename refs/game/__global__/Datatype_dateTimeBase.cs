internal class Datatype_dateTimeBase : Datatype_anySimpleType // TypeDefIndex: 8295
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private XsdDateTimeFlags dateTimeFlags; // 0x38

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x25835B0 Offset: 0x2581FB0 VA: 0x1825835B0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x2583A80 Offset: 0x2582480 VA: 0x182583A80 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x578D50 Offset: 0x577750 VA: 0x180578D50 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x25839F0 Offset: 0x25823F0 VA: 0x1825839F0
	internal void .ctor(XsdDateTimeFlags dateTimeFlags) { }

	// RVA: 0x2583B30 Offset: 0x2582530 VA: 0x182583B30 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x2583AD0 Offset: 0x25824D0 VA: 0x182583AD0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x2583B20 Offset: 0x2582520 VA: 0x182583B20 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x2583450 Offset: 0x2581E50 VA: 0x182583450 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x25835C0 Offset: 0x2581FC0 VA: 0x1825835C0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x2583910 Offset: 0x2582310 VA: 0x182583910
	private static void .cctor() { }
}
