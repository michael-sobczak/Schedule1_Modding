public class XmlSchemaGroupRef : XmlSchemaParticle // TypeDefIndex: 8454
{
	// Fields
	private XmlQualifiedName refName; // 0x78
	private XmlSchemaGroupBase particle; // 0x80
	private XmlSchemaGroup refined; // 0x88

	// Properties
	[Xml("ref")]
	public XmlQualifiedName RefName { get; set; }
	[XmlIgnore]
	public XmlSchemaGroupBase Particle { get; }
	[XmlIgnore]
	internal XmlSchemaGroup Redefined { get; set; }

	// Methods

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x244B940 Offset: 0x244A340 VA: 0x18244B940
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400
	public XmlSchemaGroupBase get_Particle() { }

	// RVA: 0x6EA770 Offset: 0x6E9170 VA: 0x1806EA770
	internal void SetParticle(XmlSchemaGroupBase value) { }

	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080
	internal XmlSchemaGroup get_Redefined() { }

	// RVA: 0x589030 Offset: 0x587A30 VA: 0x180589030
	internal void set_Redefined(XmlSchemaGroup value) { }

	// RVA: 0x244B8B0 Offset: 0x244A2B0 VA: 0x18244B8B0
	public void .ctor() { }
}
