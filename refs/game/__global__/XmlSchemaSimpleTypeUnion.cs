public class XmlSchemaSimpleTypeUnion : XmlSchemaSimpleTypeContent // TypeDefIndex: 8486
{
	// Fields
	private XmlSchemaObjectCollection baseTypes; // 0x50
	private XmlQualifiedName[] memberTypes; // 0x58
	private XmlSchemaSimpleType[] baseMemberTypes; // 0x60

	// Properties
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaObjectCollection BaseTypes { get; }
	[Xml("memberTypes")]
	public XmlQualifiedName[] MemberTypes { get; set; }
	[XmlIgnore]
	public XmlSchemaSimpleType[] BaseMemberTypes { get; }

	// Methods

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public XmlSchemaObjectCollection get_BaseTypes() { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public XmlQualifiedName[] get_MemberTypes() { }

	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	public void set_MemberTypes(XmlQualifiedName[] value) { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	internal void SetBaseMemberTypes(XmlSchemaSimpleType[] baseMemberTypes) { }

	// RVA: 0x245F210 Offset: 0x245DC10 VA: 0x18245F210 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x245F3F0 Offset: 0x245DDF0 VA: 0x18245F3F0
	public void .ctor() { }
}
