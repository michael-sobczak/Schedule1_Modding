internal class Datatype_unsignedInt : Datatype_unsignedLong // TypeDefIndex: 8333
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

	// RVA: 0x2588EE0 Offset: 0x25878E0 VA: 0x182588EE0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x2588F80 Offset: 0x2587980 VA: 0x182588F80 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x2588AF0 Offset: 0x25874F0 VA: 0x182588AF0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x2588F90 Offset: 0x2587990 VA: 0x182588F90 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x2588F30 Offset: 0x2587930 VA: 0x182588F30 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x2588B70 Offset: 0x2587570 VA: 0x182588B70 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x2588E90 Offset: 0x2587890 VA: 0x182588E90
	public void .ctor() { }

	// RVA: 0x2588CF0 Offset: 0x25876F0 VA: 0x182588CF0
	private static void .cctor() { }
}
