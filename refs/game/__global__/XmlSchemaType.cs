public class XmlSchemaType : XmlSchemaAnnotated // TypeDefIndex: 8489
{
	// Fields
	private string name; // 0x50
	private XmlSchemaDerivationMethod final; // 0x58
	private XmlSchemaDerivationMethod derivedBy; // 0x5C
	private XmlSchemaType baseSchemaType; // 0x60
	private XmlSchemaDatatype datatype; // 0x68
	private XmlSchemaDerivationMethod finalResolved; // 0x70
	private SchemaElementDecl elementDecl; // 0x78
	private XmlQualifiedName qname; // 0x80
	private XmlSchemaType redefined; // 0x88
	private XmlSchemaContentType contentType; // 0x90

	// Properties
	[Xml("name")]
	public string Name { get; set; }
	[Xml("final")]
	[DefaultValue(256)]
	public XmlSchemaDerivationMethod Final { get; set; }
	[XmlIgnore]
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnore]
	public XmlSchemaDerivationMethod FinalResolved { get; }
	[XmlIgnore]
	public XmlSchemaType BaseXmlSchemaType { get; }
	[XmlIgnore]
	public XmlSchemaDerivationMethod DerivedBy { get; }
	[XmlIgnore]
	public XmlSchemaDatatype Datatype { get; }
	[XmlIgnore]
	public virtual bool IsMixed { get; set; }
	[XmlIgnore]
	public XmlTypeCode TypeCode { get; }
	[XmlIgnore]
	internal XmlValueConverter ValueConverter { get; }
	internal XmlSchemaContentType SchemaContentType { get; }
	internal SchemaElementDecl ElementDecl { get; set; }
	[XmlIgnore]
	internal XmlSchemaType Redefined { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x245FA20 Offset: 0x245E420 VA: 0x18245FA20
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlQualifiedName qualifiedName) { }

	// RVA: 0x245FAF0 Offset: 0x245E4F0 VA: 0x18245FAF0
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlTypeCode typeCode) { }

	// RVA: 0x245F7C0 Offset: 0x245E1C0 VA: 0x18245F7C0
	public static XmlSchemaComplexType GetBuiltInComplexType(XmlQualifiedName qualifiedName) { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public string get_Name() { }

	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	public void set_Name(string value) { }

	// RVA: 0x4C3B30 Offset: 0x4C2530 VA: 0x1804C3B30
	public XmlSchemaDerivationMethod get_Final() { }

	// RVA: 0x4E2910 Offset: 0x4E1310 VA: 0x1804E2910
	public void set_Final(XmlSchemaDerivationMethod value) { }

	// RVA: 0xD005C0 Offset: 0xCFEFC0 VA: 0x180D005C0
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x501290 Offset: 0x4FFC90 VA: 0x180501290
	public XmlSchemaDerivationMethod get_FinalResolved() { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public XmlSchemaType get_BaseXmlSchemaType() { }

	// RVA: 0x54CEC0 Offset: 0x54B8C0 VA: 0x18054CEC0
	public XmlSchemaDerivationMethod get_DerivedBy() { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 14
	public virtual bool get_IsMixed() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 15
	public virtual void set_IsMixed(bool value) { }

	// RVA: 0x245FDF0 Offset: 0x245E7F0 VA: 0x18245FDF0
	public XmlTypeCode get_TypeCode() { }

	// RVA: 0x245FEB0 Offset: 0x245E8B0 VA: 0x18245FEB0
	internal XmlValueConverter get_ValueConverter() { }

	// RVA: 0x4E2430 Offset: 0x4E0E30 VA: 0x1804E2430
	internal XmlSchemaContentType get_SchemaContentType() { }

	// RVA: 0x245FD90 Offset: 0x245E790 VA: 0x18245FD90
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0xA9F800 Offset: 0xA9E200 VA: 0x180A9F800
	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	internal void SetBaseSchemaType(XmlSchemaType value) { }

	// RVA: 0x8E6930 Offset: 0x8E5330 VA: 0x1808E6930
	internal void SetDerivedBy(XmlSchemaDerivationMethod value) { }

	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	internal void SetDatatype(XmlSchemaDatatype value) { }

	// RVA: 0x245FDD0 Offset: 0x245E7D0 VA: 0x18245FDD0
	internal SchemaElementDecl get_ElementDecl() { }

	// RVA: 0x245FF30 Offset: 0x245E930 VA: 0x18245FF30
	internal void set_ElementDecl(SchemaElementDecl value) { }

	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080
	internal XmlSchemaType get_Redefined() { }

	// RVA: 0x589030 Offset: 0x587A30 VA: 0x180589030
	internal void set_Redefined(XmlSchemaType value) { }

	// RVA: 0x589020 Offset: 0x587A20 VA: 0x180589020
	internal void SetContentType(XmlSchemaContentType value) { }

	// RVA: 0x245FC10 Offset: 0x245E610 VA: 0x18245FC10
	public static bool IsDerivedFrom(XmlSchemaType derivedType, XmlSchemaType baseType, XmlSchemaDerivationMethod except) { }

	// RVA: 0x245FB40 Offset: 0x245E540 VA: 0x18245FB40
	internal static bool IsDerivedFromDatatype(XmlSchemaDatatype derivedDataType, XmlSchemaDatatype baseDataType, XmlSchemaDerivationMethod except) { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x245F590 Offset: 0x245DF90 VA: 0x18245F590
	public void .ctor() { }
}
