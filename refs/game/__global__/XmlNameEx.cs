internal sealed class XmlNameEx : XmlName // TypeDefIndex: 8055
{
	// Fields
	private byte flags; // 0x48
	private XmlSchemaSimpleType memberType; // 0x50
	private XmlSchemaType schemaType; // 0x58
	private object decl; // 0x60

	// Properties
	public override XmlSchemaValidity Validity { get; }
	public override bool IsDefault { get; }
	public override bool IsNil { get; }
	public override XmlSchemaSimpleType MemberType { get; }
	public override XmlSchemaType SchemaType { get; }
	public override XmlSchemaElement SchemaElement { get; }
	public override XmlSchemaAttribute SchemaAttribute { get; }

	// Methods

	// RVA: 0x2515710 Offset: 0x2514110 VA: 0x182515710
	internal void .ctor(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x25159E0 Offset: 0x25143E0 VA: 0x1825159E0 Slot: 11
	public override XmlSchemaValidity get_Validity() { }

	// RVA: 0x25158C0 Offset: 0x25142C0 VA: 0x1825158C0 Slot: 12
	public override bool get_IsDefault() { }

	// RVA: 0x25158D0 Offset: 0x25142D0 VA: 0x1825158D0 Slot: 13
	public override bool get_IsNil() { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0 Slot: 14
	public override XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0 Slot: 15
	public override XmlSchemaType get_SchemaType() { }

	// RVA: 0x2515960 Offset: 0x2514360 VA: 0x182515960 Slot: 16
	public override XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x25158E0 Offset: 0x25142E0 VA: 0x1825158E0 Slot: 17
	public override XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x2515700 Offset: 0x2514100 VA: 0x182515700
	public void SetValidity(XmlSchemaValidity value) { }

	// RVA: 0x25156A0 Offset: 0x25140A0 VA: 0x1825156A0
	public void SetIsDefault(bool value) { }

	// RVA: 0x25156D0 Offset: 0x25140D0 VA: 0x1825156D0
	public void SetIsNil(bool value) { }

	// RVA: 0x25154C0 Offset: 0x2513EC0 VA: 0x1825154C0 Slot: 18
	public override bool Equals(IXmlSchemaInfo schemaInfo) { }
}
