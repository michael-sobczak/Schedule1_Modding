internal class XmlTypeMapMemberAttribute : XmlTypeMapMember // TypeDefIndex: 8214
{
	// Fields
	private string _attributeName; // 0x58
	private string _namespace; // 0x60
	private XmlSchemaForm _form; // 0x68
	private XmlTypeMapping _mappedType; // 0x70

	// Properties
	public string AttributeName { get; set; }
	public string Namespace { get; set; }
	public XmlSchemaForm Form { set; }
	public XmlTypeMapping MappedType { get; set; }

	// Methods

	// RVA: 0x2573AD0 Offset: 0x25724D0 VA: 0x182573AD0
	public void .ctor() { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public string get_AttributeName() { }

	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	public void set_AttributeName(string value) { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public string get_Namespace() { }

	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	public void set_Namespace(string value) { }

	// RVA: 0x54CF80 Offset: 0x54B980 VA: 0x18054CF80
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public XmlTypeMapping get_MappedType() { }

	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	public void set_MappedType(XmlTypeMapping value) { }
}
