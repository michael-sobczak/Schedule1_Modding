internal class Datatype_List : Datatype_anySimpleType // TypeDefIndex: 8282
{
	// Fields
	private DatatypeImplementation itemType; // 0x38
	private int minListSize; // 0x40

	// Properties
	public override Type ValueType { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override Type ListValueType { get; }
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x257F840 Offset: 0x257E240 VA: 0x18257F840 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x2580670 Offset: 0x257F070 VA: 0x182580670
	internal void .ctor(DatatypeImplementation type, int minListSize) { }

	// RVA: 0x257F560 Offset: 0x257DF60 VA: 0x18257F560 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0xB29900 Offset: 0xB28300 VA: 0x180B29900 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x25807B0 Offset: 0x257F1B0 VA: 0x1825807B0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x2580780 Offset: 0x257F180 VA: 0x182580780 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x2580720 Offset: 0x257F120 VA: 0x182580720 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x25807E0 Offset: 0x257F1E0 VA: 0x1825807E0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x2580810 Offset: 0x257F210 VA: 0x182580810 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x257FBA0 Offset: 0x257E5A0 VA: 0x18257FBA0 Slot: 17
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue) { }

	// RVA: 0x2580160 Offset: 0x257EB60 VA: 0x182580160 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }
}
