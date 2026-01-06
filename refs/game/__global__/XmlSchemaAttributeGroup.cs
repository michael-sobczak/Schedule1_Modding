public class XmlSchemaAttributeGroup : XmlSchemaAnnotated // TypeDefIndex: 8415
{
	// Fields
	private string name; // 0x50
	private XmlSchemaObjectCollection attributes; // 0x58
	private XmlSchemaAnyAttribute anyAttribute; // 0x60
	private XmlQualifiedName qname; // 0x68
	private XmlSchemaAttributeGroup redefined; // 0x70
	private XmlSchemaObjectTable attributeUses; // 0x78
	private XmlSchemaAnyAttribute attributeWildcard; // 0x80
	private int selfReferenceCount; // 0x88

	// Properties
	[Xml("name")]
	public string Name { get; set; }
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }
	[XmlIgnore]
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnore]
	internal XmlSchemaObjectTable AttributeUses { get; }
	[XmlIgnore]
	internal XmlSchemaAnyAttribute AttributeWildcard { get; set; }
	[XmlIgnore]
	public XmlSchemaAttributeGroup RedefinedAttributeGroup { get; }
	[XmlIgnore]
	internal XmlSchemaAttributeGroup Redefined { get; set; }
	[XmlIgnore]
	internal int SelfReferenceCount { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public string get_Name() { }

	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	public void set_Name(string value) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x24456F0 Offset: 0x24440F0 VA: 0x1824456F0
	internal XmlSchemaObjectTable get_AttributeUses() { }

	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400
	internal XmlSchemaAnyAttribute get_AttributeWildcard() { }

	// RVA: 0x6EA770 Offset: 0x6E9170 VA: 0x1806EA770
	internal void set_AttributeWildcard(XmlSchemaAnyAttribute value) { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public XmlSchemaAttributeGroup get_RedefinedAttributeGroup() { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	internal XmlSchemaAttributeGroup get_Redefined() { }

	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	internal void set_Redefined(XmlSchemaAttributeGroup value) { }

	// RVA: 0x1063C60 Offset: 0x1062660 VA: 0x181063C60
	internal int get_SelfReferenceCount() { }

	// RVA: 0x1063DF0 Offset: 0x10627F0 VA: 0x181063DF0
	internal void set_SelfReferenceCount(int value) { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x2445520 Offset: 0x2443F20 VA: 0x182445520 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x2445640 Offset: 0x2444040 VA: 0x182445640
	public void .ctor() { }
}
