internal class Datatype_unsignedShort : Datatype_unsignedInt // TypeDefIndex: 8334
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

	// RVA: 0x2589960 Offset: 0x2588360 VA: 0x182589960 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xB791E0 Offset: 0xB77BE0 VA: 0x180B791E0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x2589540 Offset: 0x2587F40 VA: 0x182589540 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x2589A00 Offset: 0x2588400 VA: 0x182589A00 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x25899B0 Offset: 0x25883B0 VA: 0x1825899B0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x25895C0 Offset: 0x2587FC0 VA: 0x1825895C0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x25898E0 Offset: 0x25882E0 VA: 0x1825898E0
	public void .ctor() { }

	// RVA: 0x2589740 Offset: 0x2588140 VA: 0x182589740
	private static void .cctor() { }
}
