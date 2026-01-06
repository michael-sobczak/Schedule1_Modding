internal class Datatype_base64Binary : Datatype_anySimpleType // TypeDefIndex: 8309
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

	// RVA: 0x25825A0 Offset: 0x2580FA0 VA: 0x1825825A0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x2582640 Offset: 0x2581040 VA: 0x182582640 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x2582650 Offset: 0x2581050 VA: 0x182582650 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x25825F0 Offset: 0x2580FF0 VA: 0x1825825F0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x2580810 Offset: 0x257F210 VA: 0x182580810 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x25821B0 Offset: 0x2580BB0 VA: 0x1825821B0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x25822E0 Offset: 0x2580CE0 VA: 0x1825822E0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x2582520 Offset: 0x2580F20 VA: 0x182582520
	public void .ctor() { }

	// RVA: 0x2582440 Offset: 0x2580E40 VA: 0x182582440
	private static void .cctor() { }
}
