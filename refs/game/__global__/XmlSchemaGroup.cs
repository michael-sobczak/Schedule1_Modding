public class XmlSchemaGroup : XmlSchemaAnnotated // TypeDefIndex: 8452
{
	// Fields
	private string name; // 0x50
	private XmlSchemaGroupBase particle; // 0x58
	private XmlSchemaParticle canonicalParticle; // 0x60
	private XmlQualifiedName qname; // 0x68
	private XmlSchemaGroup redefined; // 0x70
	private int selfReferenceCount; // 0x78

	// Properties
	[Xml("name")]
	public string Name { get; set; }
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("all", typeof(XmlSchemaAll))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	public XmlSchemaGroupBase Particle { get; set; }
	[XmlIgnore]
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnore]
	internal XmlSchemaParticle CanonicalParticle { get; set; }
	[XmlIgnore]
	internal XmlSchemaGroup Redefined { get; set; }
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
	public XmlSchemaGroupBase get_Particle() { }

	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	public void set_Particle(XmlSchemaGroupBase value) { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	internal XmlSchemaParticle get_CanonicalParticle() { }

	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	internal void set_CanonicalParticle(XmlSchemaParticle value) { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	internal XmlSchemaGroup get_Redefined() { }

	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	internal void set_Redefined(XmlSchemaGroup value) { }

	// RVA: 0x553640 Offset: 0x552040 VA: 0x180553640
	internal int get_SelfReferenceCount() { }

	// RVA: 0x96CF20 Offset: 0x96B920 VA: 0x18096CF20
	internal void set_SelfReferenceCount(int value) { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x244BBF0 Offset: 0x244A5F0 VA: 0x18244BBF0 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x244B9F0 Offset: 0x244A3F0 VA: 0x18244B9F0
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x244BC00 Offset: 0x244A600 VA: 0x18244BC00
	public void .ctor() { }
}
