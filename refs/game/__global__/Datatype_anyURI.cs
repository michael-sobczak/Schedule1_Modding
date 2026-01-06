internal class Datatype_anyURI : Datatype_anySimpleType // TypeDefIndex: 8310
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override bool HasValueFacets { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x2580960 Offset: 0x257F360 VA: 0x182580960 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x25820C0 Offset: 0x2580AC0 VA: 0x1825820C0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xF72860 Offset: 0xF71260 VA: 0x180F72860 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x2582160 Offset: 0x2580B60 VA: 0x182582160 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x2582110 Offset: 0x2580B10 VA: 0x182582110 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x2580810 Offset: 0x257F210 VA: 0x182580810 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x2581CD0 Offset: 0x25806D0 VA: 0x182581CD0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x2581DA0 Offset: 0x25807A0 VA: 0x182581DA0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x2582040 Offset: 0x2580A40 VA: 0x182582040
	public void .ctor() { }

	// RVA: 0x2581F60 Offset: 0x2580960 VA: 0x182581F60
	private static void .cctor() { }
}
