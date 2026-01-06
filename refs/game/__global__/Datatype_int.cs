internal class Datatype_int : Datatype_long // TypeDefIndex: 8328
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

	// RVA: 0x2586440 Offset: 0x2584E40 VA: 0x182586440 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x25864E0 Offset: 0x2584EE0 VA: 0x1825864E0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x2586040 Offset: 0x2584A40 VA: 0x182586040 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x25864F0 Offset: 0x2584EF0 VA: 0x1825864F0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x2586490 Offset: 0x2584E90 VA: 0x182586490 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x25860C0 Offset: 0x2584AC0 VA: 0x1825860C0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x25863C0 Offset: 0x2584DC0 VA: 0x1825863C0
	public void .ctor() { }

	// RVA: 0x2586240 Offset: 0x2584C40 VA: 0x182586240
	private static void .cctor() { }
}
