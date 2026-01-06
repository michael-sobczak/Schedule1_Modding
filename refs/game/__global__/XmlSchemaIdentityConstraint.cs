public class XmlSchemaIdentityConstraint : XmlSchemaAnnotated // TypeDefIndex: 8455
{
	// Fields
	private string name; // 0x50
	private XmlSchemaXPath selector; // 0x58
	private XmlSchemaObjectCollection fields; // 0x60
	private XmlQualifiedName qualifiedName; // 0x68
	private CompiledIdentityConstraint compiledConstraint; // 0x70

	// Properties
	[Xml("name")]
	public string Name { get; set; }
	[XmlElement("selector", typeof(XmlSchemaXPath))]
	public XmlSchemaXPath Selector { get; set; }
	[XmlElement("field", typeof(XmlSchemaXPath))]
	public XmlSchemaObjectCollection Fields { get; }
	[XmlIgnore]
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnore]
	internal CompiledIdentityConstraint CompiledConstraint { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public string get_Name() { }

	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	public void set_Name(string value) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public XmlSchemaXPath get_Selector() { }

	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	public void set_Selector(XmlSchemaXPath value) { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public XmlSchemaObjectCollection get_Fields() { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	internal CompiledIdentityConstraint get_CompiledConstraint() { }

	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	internal void set_CompiledConstraint(CompiledIdentityConstraint value) { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x244BC70 Offset: 0x244A670 VA: 0x18244BC70
	public void .ctor() { }
}
