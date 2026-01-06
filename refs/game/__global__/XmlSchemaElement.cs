public class XmlSchemaElement : XmlSchemaParticle // TypeDefIndex: 8433
{
	// Fields
	private bool isAbstract; // 0x78
	private bool hasAbstractAttribute; // 0x79
	private bool isNillable; // 0x7A
	private bool hasNillableAttribute; // 0x7B
	private bool isLocalTypeDerivationChecked; // 0x7C
	private XmlSchemaDerivationMethod block; // 0x80
	private XmlSchemaDerivationMethod final; // 0x84
	private XmlSchemaForm form; // 0x88
	private string defaultValue; // 0x90
	private string fixedValue; // 0x98
	private string name; // 0xA0
	private XmlQualifiedName refName; // 0xA8
	private XmlQualifiedName substitutionGroup; // 0xB0
	private XmlQualifiedName typeName; // 0xB8
	private XmlSchemaType type; // 0xC0
	private XmlQualifiedName qualifiedName; // 0xC8
	private XmlSchemaType elementType; // 0xD0
	private XmlSchemaDerivationMethod blockResolved; // 0xD8
	private XmlSchemaDerivationMethod finalResolved; // 0xDC
	private XmlSchemaObjectCollection constraints; // 0xE0
	private SchemaElementDecl elementDecl; // 0xE8

	// Properties
	[DefaultValue(False)]
	[Xml("abstract")]
	public bool IsAbstract { get; set; }
	[DefaultValue(256)]
	[Xml("block")]
	public XmlSchemaDerivationMethod Block { get; set; }
	[Xml("default")]
	[DefaultValue(null)]
	public string DefaultValue { get; set; }
	[Xml("final")]
	[DefaultValue(256)]
	public XmlSchemaDerivationMethod Final { get; set; }
	[DefaultValue(null)]
	[Xml("fixed")]
	public string FixedValue { get; set; }
	[DefaultValue(0)]
	[Xml("form")]
	public XmlSchemaForm Form { get; set; }
	[Xml("name")]
	[DefaultValue("")]
	public string Name { get; set; }
	[Xml("nillable")]
	[DefaultValue(False)]
	public bool IsNillable { get; set; }
	[XmlIgnore]
	internal bool HasNillableAttribute { get; }
	[XmlIgnore]
	internal bool HasAbstractAttribute { get; }
	[Xml("ref")]
	public XmlQualifiedName RefName { get; set; }
	[Xml("substitutionGroup")]
	public XmlQualifiedName SubstitutionGroup { get; set; }
	[Xml("type")]
	public XmlQualifiedName SchemaTypeName { get; set; }
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	[XmlElement("complexType", typeof(XmlSchemaComplexType))]
	public XmlSchemaType SchemaType { get; set; }
	[XmlElement("key", typeof(XmlSchemaKey))]
	[XmlElement("keyref", typeof(XmlSchemaKeyref))]
	[XmlElement("unique", typeof(XmlSchemaUnique))]
	public XmlSchemaObjectCollection Constraints { get; }
	[XmlIgnore]
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnore]
	public XmlSchemaType ElementSchemaType { get; }
	[XmlIgnore]
	public XmlSchemaDerivationMethod BlockResolved { get; }
	[XmlIgnore]
	public XmlSchemaDerivationMethod FinalResolved { get; }
	internal bool HasConstraints { get; }
	internal bool IsLocalTypeDerivationChecked { get; set; }
	internal SchemaElementDecl ElementDecl { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }
	[XmlIgnore]
	internal override string NameString { get; }

	// Methods

	// RVA: 0x4E23F0 Offset: 0x4E0DF0 VA: 0x1804E23F0
	public bool get_IsAbstract() { }

	// RVA: 0x244A850 Offset: 0x2449250 VA: 0x18244A850
	public void set_IsAbstract(bool value) { }

	// RVA: 0x4D6280 Offset: 0x4D4C80 VA: 0x1804D6280
	public XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x4D6540 Offset: 0x4D4F40 VA: 0x1804D6540
	public void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	public string get_DefaultValue() { }

	// RVA: 0x614510 Offset: 0x612F10 VA: 0x180614510
	public void set_DefaultValue(string value) { }

	// RVA: 0x6A52B0 Offset: 0x6A3CB0 VA: 0x1806A52B0
	public XmlSchemaDerivationMethod get_Final() { }

	// RVA: 0x9883D0 Offset: 0x986DD0 VA: 0x1809883D0
	public void set_Final(XmlSchemaDerivationMethod value) { }

	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	public string get_FixedValue() { }

	// RVA: 0xAA72B0 Offset: 0xAA5CB0 VA: 0x180AA72B0
	public void set_FixedValue(string value) { }

	// RVA: 0x1063C60 Offset: 0x1062660 VA: 0x181063C60
	public XmlSchemaForm get_Form() { }

	// RVA: 0x1063DF0 Offset: 0x10627F0 VA: 0x181063DF0
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190
	public string get_Name() { }

	// RVA: 0x4B6D00 Offset: 0x4B5700 VA: 0x1804B6D00
	public void set_Name(string value) { }

	// RVA: 0x1E019E0 Offset: 0x1E003E0 VA: 0x181E019E0
	public bool get_IsNillable() { }

	// RVA: 0x244A860 Offset: 0x2449260 VA: 0x18244A860
	public void set_IsNillable(bool value) { }

	// RVA: 0x244A810 Offset: 0x2449210 VA: 0x18244A810
	internal bool get_HasNillableAttribute() { }

	// RVA: 0x1E01A60 Offset: 0x1E00460 VA: 0x181E01A60
	internal bool get_HasAbstractAttribute() { }

	// RVA: 0x4B61A0 Offset: 0x4B4BA0 VA: 0x1804B61A0
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x244A870 Offset: 0x2449270 VA: 0x18244A870
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x4B6150 Offset: 0x4B4B50 VA: 0x1804B6150
	public XmlQualifiedName get_SubstitutionGroup() { }

	// RVA: 0x244A9D0 Offset: 0x24493D0 VA: 0x18244A9D0
	public void set_SubstitutionGroup(XmlQualifiedName value) { }

	// RVA: 0x4B6160 Offset: 0x4B4B60 VA: 0x1804B6160
	public XmlQualifiedName get_SchemaTypeName() { }

	// RVA: 0x244A920 Offset: 0x2449320 VA: 0x18244A920
	public void set_SchemaTypeName(XmlQualifiedName value) { }

	// RVA: 0x4B6140 Offset: 0x4B4B40 VA: 0x1804B6140
	public XmlSchemaType get_SchemaType() { }

	// RVA: 0x4B6C60 Offset: 0x4B5660 VA: 0x1804B6C60
	public void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x244A760 Offset: 0x2449160 VA: 0x18244A760
	public XmlSchemaObjectCollection get_Constraints() { }

	// RVA: 0x4B6170 Offset: 0x4B4B70 VA: 0x1804B6170
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x4B6180 Offset: 0x4B4B80 VA: 0x1804B6180
	public XmlSchemaType get_ElementSchemaType() { }

	// RVA: 0x516290 Offset: 0x514C90 VA: 0x180516290
	public XmlSchemaDerivationMethod get_BlockResolved() { }

	// RVA: 0x510B10 Offset: 0x50F510 VA: 0x180510B10
	public XmlSchemaDerivationMethod get_FinalResolved() { }

	// RVA: 0x4B6CC0 Offset: 0x4B56C0 VA: 0x1804B6CC0
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x4B6CE0 Offset: 0x4B56E0 VA: 0x1804B6CE0
	internal void SetElementType(XmlSchemaType value) { }

	// RVA: 0xB39BE0 Offset: 0xB385E0 VA: 0x180B39BE0
	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0xB39BD0 Offset: 0xB385D0 VA: 0x180B39BD0
	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x244A7E0 Offset: 0x24491E0 VA: 0x18244A7E0
	internal bool get_HasConstraints() { }

	// RVA: 0x83DBA0 Offset: 0x83C5A0 VA: 0x18083DBA0
	internal bool get_IsLocalTypeDerivationChecked() { }

	// RVA: 0x83DBD0 Offset: 0x83C5D0 VA: 0x18083DBD0
	internal void set_IsLocalTypeDerivationChecked(bool value) { }

	// RVA: 0x4E8CB0 Offset: 0x4E76B0 VA: 0x1804E8CB0
	internal SchemaElementDecl get_ElementDecl() { }

	// RVA: 0x4E8E60 Offset: 0x4E7860 VA: 0x1804E8E60
	internal void set_ElementDecl(SchemaElementDecl value) { }

	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x4B6D00 Offset: 0x4B5700 VA: 0x1804B6D00 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x244A820 Offset: 0x2449220 VA: 0x18244A820 Slot: 15
	internal override string get_NameString() { }

	// RVA: 0x244A630 Offset: 0x2449030 VA: 0x18244A630 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x244A3A0 Offset: 0x2448DA0 VA: 0x18244A3A0
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x244A640 Offset: 0x2449040 VA: 0x18244A640
	public void .ctor() { }
}
