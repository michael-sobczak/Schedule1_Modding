internal class Datatype_uuid : Datatype_anySimpleType // TypeDefIndex: 8343
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x2589F20 Offset: 0x2588920 VA: 0x182589F20 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x2589ED0 Offset: 0x25888D0 VA: 0x182589ED0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x2589AB0 Offset: 0x25884B0 VA: 0x182589AB0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x2589B40 Offset: 0x2588540 VA: 0x182589B40 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x2589CB0 Offset: 0x25886B0 VA: 0x182589CB0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x2589E50 Offset: 0x2588850 VA: 0x182589E50
	public void .ctor() { }

	// RVA: 0x2589D70 Offset: 0x2588770 VA: 0x182589D70
	private static void .cctor() { }
}
