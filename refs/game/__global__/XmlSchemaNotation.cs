public class XmlSchemaNotation : XmlSchemaAnnotated // TypeDefIndex: 8463
{
	// Fields
	private string name; // 0x50
	private string publicId; // 0x58
	private string systemId; // 0x60
	private XmlQualifiedName qname; // 0x68

	// Properties
	[Xml("name")]
	public string Name { get; set; }
	[Xml("public")]
	public string Public { get; set; }
	[Xml("system")]
	public string System { get; set; }
	[XmlIgnore]
	internal XmlQualifiedName QualifiedName { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public string get_Name() { }

	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	public void set_Name(string value) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public string get_Public() { }

	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	public void set_Public(string value) { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public string get_System() { }

	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	public void set_System(string value) { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	internal XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	internal void set_QualifiedName(XmlQualifiedName value) { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x244C2D0 Offset: 0x244ACD0 VA: 0x18244C2D0
	public void .ctor() { }
}
