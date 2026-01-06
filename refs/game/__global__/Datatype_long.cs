internal class Datatype_long : Datatype_integer // TypeDefIndex: 8327
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	internal override bool HasValueFacets { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x2586A80 Offset: 0x2585480 VA: 0x182586A80 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x2586B20 Offset: 0x2585520 VA: 0x182586B20 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x25866F0 Offset: 0x25850F0 VA: 0x1825866F0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x2586B30 Offset: 0x2585530 VA: 0x182586B30 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x2586AD0 Offset: 0x25854D0 VA: 0x182586AD0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x2586770 Offset: 0x2585170 VA: 0x182586770 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x25866A0 Offset: 0x25850A0 VA: 0x1825866A0
	public void .ctor() { }

	// RVA: 0x25868F0 Offset: 0x25852F0 VA: 0x1825868F0
	private static void .cctor() { }
}
