public sealed class XmlAtomicValue : XPathItem, ICloneable // TypeDefIndex: 8406
{
	// Fields
	private XmlSchemaType xmlType; // 0x10
	private object objVal; // 0x18
	private TypeCode clrType; // 0x20
	private XmlAtomicValue.Union unionVal; // 0x28
	private XmlAtomicValue.NamespacePrefixForQName nsPrefix; // 0x30

	// Properties
	public override XmlSchemaType XmlType { get; }
	public override Type ValueType { get; }
	public override object TypedValue { get; }
	public override bool ValueAsBoolean { get; }
	public override DateTime ValueAsDateTime { get; }
	public override double ValueAsDouble { get; }
	public override int ValueAsInt { get; }
	public override long ValueAsLong { get; }
	public override string Value { get; }

	// Methods

	// RVA: 0x2443640 Offset: 0x2442040 VA: 0x182443640
	internal void .ctor(XmlSchemaType xmlType, bool value) { }

	// RVA: 0x2443E80 Offset: 0x2442880 VA: 0x182443E80
	internal void .ctor(XmlSchemaType xmlType, DateTime value) { }

	// RVA: 0x2443F20 Offset: 0x2442920 VA: 0x182443F20
	internal void .ctor(XmlSchemaType xmlType, double value) { }

	// RVA: 0x2443AB0 Offset: 0x24424B0 VA: 0x182443AB0
	internal void .ctor(XmlSchemaType xmlType, int value) { }

	// RVA: 0x2443A10 Offset: 0x2442410 VA: 0x182443A10
	internal void .ctor(XmlSchemaType xmlType, long value) { }

	// RVA: 0x2443D90 Offset: 0x2442790 VA: 0x182443D90
	internal void .ctor(XmlSchemaType xmlType, string value) { }

	// RVA: 0x24437D0 Offset: 0x24421D0 VA: 0x1824437D0
	internal void .ctor(XmlSchemaType xmlType, string value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x24436E0 Offset: 0x24420E0 VA: 0x1824436E0
	internal void .ctor(XmlSchemaType xmlType, object value) { }

	// RVA: 0x2443B50 Offset: 0x2442550 VA: 0x182443B50
	internal void .ctor(XmlSchemaType xmlType, object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 15
	private object System.ICloneable.Clone() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 4
	public override XmlSchemaType get_XmlType() { }

	// RVA: 0x2444720 Offset: 0x2443120 VA: 0x182444720 Slot: 7
	public override Type get_ValueType() { }

	// RVA: 0x2443FC0 Offset: 0x24429C0 VA: 0x182443FC0 Slot: 6
	public override object get_TypedValue() { }

	// RVA: 0x24441D0 Offset: 0x2442BD0 VA: 0x1824441D0 Slot: 8
	public override bool get_ValueAsBoolean() { }

	// RVA: 0x24442E0 Offset: 0x2442CE0 VA: 0x1824442E0 Slot: 9
	public override DateTime get_ValueAsDateTime() { }

	// RVA: 0x24443F0 Offset: 0x2442DF0 VA: 0x1824443F0 Slot: 10
	public override double get_ValueAsDouble() { }

	// RVA: 0x2444500 Offset: 0x2442F00 VA: 0x182444500 Slot: 11
	public override int get_ValueAsInt() { }

	// RVA: 0x2444610 Offset: 0x2443010 VA: 0x182444610 Slot: 12
	public override long get_ValueAsLong() { }

	// RVA: 0x2443410 Offset: 0x2441E10 VA: 0x182443410 Slot: 14
	public override object ValueAs(Type type, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x2444760 Offset: 0x2443160 VA: 0x182444760 Slot: 5
	public override string get_Value() { }

	// RVA: 0x618750 Offset: 0x617150 VA: 0x180618750 Slot: 3
	public override string ToString() { }

	// RVA: 0x2443360 Offset: 0x2441D60 VA: 0x182443360
	private string GetPrefixFromQName(string value) { }
}
