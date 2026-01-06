public class XmlSchemaComplexType : XmlSchemaType // TypeDefIndex: 8425
{
	// Fields
	private XmlSchemaDerivationMethod block; // 0x98
	private XmlSchemaContentModel contentModel; // 0xA0
	private XmlSchemaParticle particle; // 0xA8
	private XmlSchemaObjectCollection attributes; // 0xB0
	private XmlSchemaAnyAttribute anyAttribute; // 0xB8
	private XmlSchemaParticle contentTypeParticle; // 0xC0
	private XmlSchemaDerivationMethod blockResolved; // 0xC8
	private XmlSchemaObjectTable localElements; // 0xD0
	private XmlSchemaObjectTable attributeUses; // 0xD8
	private XmlSchemaAnyAttribute attributeWildcard; // 0xE0
	private static XmlSchemaComplexType anyTypeLax; // 0x0
	private static XmlSchemaComplexType anyTypeSkip; // 0x8
	private static XmlSchemaComplexType untypedAnyType; // 0x10
	private byte pvFlags; // 0xE8

	// Properties
	[XmlIgnore]
	internal static XmlSchemaComplexType AnyType { get; }
	[XmlIgnore]
	internal static XmlSchemaComplexType UntypedAnyType { get; }
	internal static ContentValidator AnyTypeContentValidator { get; }
	[Xml("abstract")]
	[DefaultValue(False)]
	public bool IsAbstract { get; set; }
	[DefaultValue(256)]
	[Xml("block")]
	public XmlSchemaDerivationMethod Block { get; set; }
	[DefaultValue(False)]
	[Xml("mixed")]
	public override bool IsMixed { get; set; }
	[XmlElement("complexContent", typeof(XmlSchemaComplexContent))]
	[XmlElement("simpleContent", typeof(XmlSchemaSimpleContent))]
	public XmlSchemaContentModel ContentModel { get; set; }
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	[XmlElement("all", typeof(XmlSchemaAll))]
	public XmlSchemaParticle Particle { get; set; }
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }
	[XmlIgnore]
	public XmlSchemaContentType ContentType { get; }
	[XmlIgnore]
	public XmlSchemaParticle ContentTypeParticle { get; }
	[XmlIgnore]
	public XmlSchemaDerivationMethod BlockResolved { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable AttributeUses { get; }
	[XmlIgnore]
	public XmlSchemaAnyAttribute AttributeWildcard { get; }
	[XmlIgnore]
	internal XmlSchemaObjectTable LocalElements { get; }
	internal bool HasWildCard { set; }

	// Methods

	// RVA: 0x2448A70 Offset: 0x2447470 VA: 0x182448A70
	private static void .cctor() { }

	// RVA: 0x2448110 Offset: 0x2446B10 VA: 0x182448110
	private static XmlSchemaComplexType CreateAnyType(XmlSchemaContentProcessing processContents) { }

	// RVA: 0x2448E00 Offset: 0x2447800 VA: 0x182448E00
	public void .ctor() { }

	// RVA: 0x2448EF0 Offset: 0x24478F0 VA: 0x182448EF0
	internal static XmlSchemaComplexType get_AnyType() { }

	// RVA: 0x24490E0 Offset: 0x2447AE0 VA: 0x1824490E0
	internal static XmlSchemaComplexType get_UntypedAnyType() { }

	// RVA: 0x2448E80 Offset: 0x2447880 VA: 0x182448E80
	internal static ContentValidator get_AnyTypeContentValidator() { }

	// RVA: 0x2449040 Offset: 0x2447A40 VA: 0x182449040
	public bool get_IsAbstract() { }

	// RVA: 0x2449160 Offset: 0x2447B60 VA: 0x182449160
	public void set_IsAbstract(bool value) { }

	// RVA: 0x4B62D0 Offset: 0x4B4CD0 VA: 0x1804B62D0
	public XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x4B7090 Offset: 0x4B5A90 VA: 0x1804B7090
	public void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x2449050 Offset: 0x2447A50 VA: 0x182449050 Slot: 14
	public override bool get_IsMixed() { }

	// RVA: 0x2449190 Offset: 0x2447B90 VA: 0x182449190 Slot: 15
	public override void set_IsMixed(bool value) { }

	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190
	public XmlSchemaContentModel get_ContentModel() { }

	// RVA: 0x4B6D00 Offset: 0x4B5700 VA: 0x1804B6D00
	public void set_ContentModel(XmlSchemaContentModel value) { }

	// RVA: 0x4B61A0 Offset: 0x4B4BA0 VA: 0x1804B61A0
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x4B6D20 Offset: 0x4B5720 VA: 0x1804B6D20
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x2448FC0 Offset: 0x24479C0 VA: 0x182448FC0
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x4B6160 Offset: 0x4B4B60 VA: 0x1804B6160
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x4B6CA0 Offset: 0x4B56A0 VA: 0x1804B6CA0
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x4E2430 Offset: 0x4E0E30 VA: 0x1804E2430
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x4B6140 Offset: 0x4B4B40 VA: 0x1804B6140
	public XmlSchemaParticle get_ContentTypeParticle() { }

	// RVA: 0x4F2350 Offset: 0x4F0D50 VA: 0x1804F2350
	public XmlSchemaDerivationMethod get_BlockResolved() { }

	// RVA: 0x2448F40 Offset: 0x2447940 VA: 0x182448F40
	public XmlSchemaObjectTable get_AttributeUses() { }

	// RVA: 0x4E8CA0 Offset: 0x4E76A0 VA: 0x1804E8CA0
	public XmlSchemaAnyAttribute get_AttributeWildcard() { }

	// RVA: 0x2449060 Offset: 0x2447A60 VA: 0x182449060
	internal XmlSchemaObjectTable get_LocalElements() { }

	// RVA: 0x4B6C60 Offset: 0x4B5660 VA: 0x1804B6C60
	internal void SetContentTypeParticle(XmlSchemaParticle value) { }

	// RVA: 0x4F2500 Offset: 0x4F0F00 VA: 0x1804F2500
	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x4E8E40 Offset: 0x4E7840 VA: 0x1804E8E40
	internal void SetAttributeWildcard(XmlSchemaAnyAttribute value) { }

	// RVA: 0x2449130 Offset: 0x2447B30 VA: 0x182449130
	internal void set_HasWildCard(bool value) { }

	// RVA: 0x4B6C80 Offset: 0x4B5680 VA: 0x1804B6C80
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x2447E80 Offset: 0x2446880 VA: 0x182447E80
	internal bool ContainsIdAttribute(bool findAll) { }

	// RVA: 0x2447E70 Offset: 0x2446870 VA: 0x182447E70 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x24474A0 Offset: 0x2445EA0 VA: 0x1824474A0
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x2446B70 Offset: 0x2445570 VA: 0x182446B70
	private void ClearCompiledState() { }

	// RVA: 0x2446C30 Offset: 0x2445630 VA: 0x182446C30
	internal static XmlSchemaObjectCollection CloneAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x2446EB0 Offset: 0x24458B0 VA: 0x182446EB0
	private static XmlSchemaObjectCollection CloneGroupBaseParticles(XmlSchemaObjectCollection groupBaseParticles, XmlSchema parentSchema) { }

	// RVA: 0x2446FF0 Offset: 0x24459F0 VA: 0x182446FF0
	internal static XmlSchemaParticle CloneParticle(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	// RVA: 0x24485E0 Offset: 0x2446FE0 VA: 0x1824485E0
	private static XmlSchemaForm GetResolvedElementForm(XmlSchema parentSchema, XmlSchemaElement element) { }

	// RVA: 0x2448770 Offset: 0x2447170 VA: 0x182448770
	internal static bool HasParticleRef(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	// RVA: 0x2448610 Offset: 0x2447010 VA: 0x182448610
	internal static bool HasAttributeQNameRef(XmlSchemaObjectCollection attributes) { }
}
