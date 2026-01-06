internal class Datatype_QNameXdr : Datatype_anySimpleType // TypeDefIndex: 8339
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	public override XmlTokenizedType TokenizedType { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0xA2A280 Offset: 0xA28C80 VA: 0x180A2A280 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x2581080 Offset: 0x257FA80 VA: 0x182581080 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x2581450 Offset: 0x257FE50 VA: 0x182581450 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x2581400 Offset: 0x257FE00 VA: 0x182581400 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x2581380 Offset: 0x257FD80 VA: 0x182581380
	public void .ctor() { }

	// RVA: 0x25812A0 Offset: 0x257FCA0 VA: 0x1825812A0
	private static void .cctor() { }
}
