internal class Datatype_byte : Datatype_short // TypeDefIndex: 8330
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

	// RVA: 0x2582EB0 Offset: 0x25818B0 VA: 0x182582EB0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1F80D80 Offset: 0x1F7F780 VA: 0x181F80D80 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x2582AB0 Offset: 0x25814B0 VA: 0x182582AB0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x2582F50 Offset: 0x2581950 VA: 0x182582F50 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x2582F00 Offset: 0x2581900 VA: 0x182582F00 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x2582B30 Offset: 0x2581530 VA: 0x182582B30 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x2582E30 Offset: 0x2581830 VA: 0x182582E30
	public void .ctor() { }

	// RVA: 0x2582CB0 Offset: 0x25816B0 VA: 0x182582CB0
	private static void .cctor() { }
}
