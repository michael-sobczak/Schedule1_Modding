internal class Datatype_unsignedByte : Datatype_unsignedShort // TypeDefIndex: 8335
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

	// RVA: 0x2588A00 Offset: 0x2587400 VA: 0x182588A00 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1FA7E20 Offset: 0x1FA6820 VA: 0x181FA7E20 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x2588610 Offset: 0x2587010 VA: 0x182588610 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x2588AA0 Offset: 0x25874A0 VA: 0x182588AA0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x2588A50 Offset: 0x2587450 VA: 0x182588A50 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x2588690 Offset: 0x2587090 VA: 0x182588690 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x25889B0 Offset: 0x25873B0 VA: 0x1825889B0
	public void .ctor() { }

	// RVA: 0x2588810 Offset: 0x2587210 VA: 0x182588810
	private static void .cctor() { }
}
