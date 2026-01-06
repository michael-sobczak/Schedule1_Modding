internal class Datatype_hexBinary : Datatype_anySimpleType // TypeDefIndex: 8308
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

	// RVA: 0x2585F40 Offset: 0x2584940 VA: 0x182585F40 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x2585FE0 Offset: 0x25849E0 VA: 0x182585FE0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x2585FF0 Offset: 0x25849F0 VA: 0x182585FF0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x2585F90 Offset: 0x2584990 VA: 0x182585F90 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x2580810 Offset: 0x257F210 VA: 0x182580810 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x2585B50 Offset: 0x2584550 VA: 0x182585B50 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x2585C80 Offset: 0x2584680 VA: 0x182585C80 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x2585EC0 Offset: 0x25848C0 VA: 0x182585EC0
	public void .ctor() { }

	// RVA: 0x2585DE0 Offset: 0x25847E0 VA: 0x182585DE0
	private static void .cctor() { }
}
