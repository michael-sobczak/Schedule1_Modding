internal class Datatype_double : Datatype_anySimpleType // TypeDefIndex: 8290
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

	// RVA: 0x2584790 Offset: 0x2583190 VA: 0x182584790 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x2584A90 Offset: 0x2583490 VA: 0x182584A90 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xF6D420 Offset: 0xF6BE20 VA: 0x180F6D420 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x2584B30 Offset: 0x2583530 VA: 0x182584B30 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x2584AE0 Offset: 0x25834E0 VA: 0x182584AE0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x2583B20 Offset: 0x2582520 VA: 0x182583B20 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x2584710 Offset: 0x2583110 VA: 0x182584710 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x25847A0 Offset: 0x25831A0 VA: 0x1825847A0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x2584A10 Offset: 0x2583410 VA: 0x182584A10
	public void .ctor() { }

	// RVA: 0x2584930 Offset: 0x2583330 VA: 0x182584930
	private static void .cctor() { }
}
