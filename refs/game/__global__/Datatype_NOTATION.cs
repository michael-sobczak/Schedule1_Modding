internal class Datatype_NOTATION : Datatype_anySimpleType // TypeDefIndex: 8323
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

	// RVA: 0x2580F70 Offset: 0x257F970 VA: 0x182580F70 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xF729C0 Offset: 0xF713C0 VA: 0x180F729C0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x6AA790 Offset: 0x6A9190 VA: 0x1806AA790 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x2580810 Offset: 0x257F210 VA: 0x182580810 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x2581020 Offset: 0x257FA20 VA: 0x182581020 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x2580FD0 Offset: 0x257F9D0 VA: 0x182580FD0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x2580970 Offset: 0x257F370 VA: 0x182580970 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x2580B60 Offset: 0x257F560 VA: 0x182580B60 Slot: 22
	internal override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	// RVA: 0x2580EF0 Offset: 0x257F8F0 VA: 0x182580EF0
	public void .ctor() { }

	// RVA: 0x2580E10 Offset: 0x257F810 VA: 0x182580E10
	private static void .cctor() { }
}
