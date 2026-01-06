internal class Datatype_char : Datatype_anySimpleType // TypeDefIndex: 8341
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x2583400 Offset: 0x2581E00 VA: 0x182583400 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x25833B0 Offset: 0x2581DB0 VA: 0x1825833B0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x2582FA0 Offset: 0x25819A0 VA: 0x182582FA0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x2583040 Offset: 0x2581A40 VA: 0x182583040 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x25831A0 Offset: 0x2581BA0 VA: 0x1825831A0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x2583330 Offset: 0x2581D30 VA: 0x182583330
	public void .ctor() { }

	// RVA: 0x2583250 Offset: 0x2581C50 VA: 0x182583250
	private static void .cctor() { }
}
