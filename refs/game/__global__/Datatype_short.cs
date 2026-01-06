internal class Datatype_short : Datatype_int // TypeDefIndex: 8329
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

	// RVA: 0x2587640 Offset: 0x2586040 VA: 0x182587640 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x25876E0 Offset: 0x25860E0 VA: 0x1825876E0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x2587270 Offset: 0x2585C70 VA: 0x182587270 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x25876F0 Offset: 0x25860F0 VA: 0x1825876F0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x2587690 Offset: 0x2586090 VA: 0x182587690 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x25872F0 Offset: 0x2585CF0 VA: 0x1825872F0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x25875F0 Offset: 0x2585FF0 VA: 0x1825875F0
	public void .ctor() { }

	// RVA: 0x2587470 Offset: 0x2585E70 VA: 0x182587470
	private static void .cctor() { }
}
