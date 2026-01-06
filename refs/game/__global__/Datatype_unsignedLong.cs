internal class Datatype_unsignedLong : Datatype_nonNegativeInteger // TypeDefIndex: 8332
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x2589450 Offset: 0x2587E50 VA: 0x182589450 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xF72880 Offset: 0xF71280 VA: 0x180F72880 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x2588FE0 Offset: 0x25879E0 VA: 0x182588FE0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x25894F0 Offset: 0x2587EF0 VA: 0x1825894F0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x25894A0 Offset: 0x2587EA0 VA: 0x1825894A0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x2589060 Offset: 0x2587A60 VA: 0x182589060 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x25893D0 Offset: 0x2587DD0 VA: 0x1825893D0
	public void .ctor() { }

	// RVA: 0x2589230 Offset: 0x2587C30 VA: 0x182589230
	private static void .cctor() { }
}
