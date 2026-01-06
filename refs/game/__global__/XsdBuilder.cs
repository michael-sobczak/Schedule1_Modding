internal sealed class XsdBuilder : SchemaBuilder // TypeDefIndex: 8520
{
	// Fields
	private static readonly XsdBuilder.State[] SchemaElement; // 0x0
	private static readonly XsdBuilder.State[] SchemaSubelements; // 0x8
	private static readonly XsdBuilder.State[] AttributeSubelements; // 0x10
	private static readonly XsdBuilder.State[] ElementSubelements; // 0x18
	private static readonly XsdBuilder.State[] ComplexTypeSubelements; // 0x20
	private static readonly XsdBuilder.State[] SimpleContentSubelements; // 0x28
	private static readonly XsdBuilder.State[] SimpleContentExtensionSubelements; // 0x30
	private static readonly XsdBuilder.State[] SimpleContentRestrictionSubelements; // 0x38
	private static readonly XsdBuilder.State[] ComplexContentSubelements; // 0x40
	private static readonly XsdBuilder.State[] ComplexContentExtensionSubelements; // 0x48
	private static readonly XsdBuilder.State[] ComplexContentRestrictionSubelements; // 0x50
	private static readonly XsdBuilder.State[] SimpleTypeSubelements; // 0x58
	private static readonly XsdBuilder.State[] SimpleTypeRestrictionSubelements; // 0x60
	private static readonly XsdBuilder.State[] SimpleTypeListSubelements; // 0x68
	private static readonly XsdBuilder.State[] SimpleTypeUnionSubelements; // 0x70
	private static readonly XsdBuilder.State[] RedefineSubelements; // 0x78
	private static readonly XsdBuilder.State[] AttributeGroupSubelements; // 0x80
	private static readonly XsdBuilder.State[] GroupSubelements; // 0x88
	private static readonly XsdBuilder.State[] AllSubelements; // 0x90
	private static readonly XsdBuilder.State[] ChoiceSequenceSubelements; // 0x98
	private static readonly XsdBuilder.State[] IdentityConstraintSubelements; // 0xA0
	private static readonly XsdBuilder.State[] AnnotationSubelements; // 0xA8
	private static readonly XsdBuilder.State[] AnnotatedSubelements; // 0xB0
	private static readonly XsdBuilder.XsdAttributeEntry[] SchemaAttributes; // 0xB8
	private static readonly XsdBuilder.XsdAttributeEntry[] AttributeAttributes; // 0xC0
	private static readonly XsdBuilder.XsdAttributeEntry[] ElementAttributes; // 0xC8
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexTypeAttributes; // 0xD0
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleContentAttributes; // 0xD8
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleContentExtensionAttributes; // 0xE0
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleContentRestrictionAttributes; // 0xE8
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexContentAttributes; // 0xF0
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexContentExtensionAttributes; // 0xF8
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexContentRestrictionAttributes; // 0x100
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeAttributes; // 0x108
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeRestrictionAttributes; // 0x110
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeUnionAttributes; // 0x118
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeListAttributes; // 0x120
	private static readonly XsdBuilder.XsdAttributeEntry[] AttributeGroupAttributes; // 0x128
	private static readonly XsdBuilder.XsdAttributeEntry[] AttributeGroupRefAttributes; // 0x130
	private static readonly XsdBuilder.XsdAttributeEntry[] GroupAttributes; // 0x138
	private static readonly XsdBuilder.XsdAttributeEntry[] GroupRefAttributes; // 0x140
	private static readonly XsdBuilder.XsdAttributeEntry[] ParticleAttributes; // 0x148
	private static readonly XsdBuilder.XsdAttributeEntry[] AnyAttributes; // 0x150
	private static readonly XsdBuilder.XsdAttributeEntry[] IdentityConstraintAttributes; // 0x158
	private static readonly XsdBuilder.XsdAttributeEntry[] SelectorAttributes; // 0x160
	private static readonly XsdBuilder.XsdAttributeEntry[] FieldAttributes; // 0x168
	private static readonly XsdBuilder.XsdAttributeEntry[] NotationAttributes; // 0x170
	private static readonly XsdBuilder.XsdAttributeEntry[] IncludeAttributes; // 0x178
	private static readonly XsdBuilder.XsdAttributeEntry[] ImportAttributes; // 0x180
	private static readonly XsdBuilder.XsdAttributeEntry[] FacetAttributes; // 0x188
	private static readonly XsdBuilder.XsdAttributeEntry[] AnyAttributeAttributes; // 0x190
	private static readonly XsdBuilder.XsdAttributeEntry[] DocumentationAttributes; // 0x198
	private static readonly XsdBuilder.XsdAttributeEntry[] AppinfoAttributes; // 0x1A0
	private static readonly XsdBuilder.XsdAttributeEntry[] RedefineAttributes; // 0x1A8
	private static readonly XsdBuilder.XsdAttributeEntry[] AnnotationAttributes; // 0x1B0
	private static readonly XsdBuilder.XsdEntry[] SchemaEntries; // 0x1B8
	private static readonly int[] DerivationMethodValues; // 0x1C0
	private static readonly string[] DerivationMethodStrings; // 0x1C8
	private static readonly string[] FormStringValues; // 0x1D0
	private static readonly string[] UseStringValues; // 0x1D8
	private static readonly string[] ProcessContentsStringValues; // 0x1E0
	private XmlReader reader; // 0x10
	private PositionInfo positionInfo; // 0x18
	private XsdBuilder.XsdEntry currentEntry; // 0x20
	private XsdBuilder.XsdEntry nextEntry; // 0x28
	private bool hasChild; // 0x30
	private HWStack stateHistory; // 0x38
	private Stack containerStack; // 0x40
	private XmlNameTable nameTable; // 0x48
	private SchemaNames schemaNames; // 0x50
	private XmlNamespaceManager namespaceManager; // 0x58
	private bool canIncludeImport; // 0x60
	private XmlSchema schema; // 0x68
	private XmlSchemaObject xso; // 0x70
	private XmlSchemaElement element; // 0x78
	private XmlSchemaAny anyElement; // 0x80
	private XmlSchemaAttribute attribute; // 0x88
	private XmlSchemaAnyAttribute anyAttribute; // 0x90
	private XmlSchemaComplexType complexType; // 0x98
	private XmlSchemaSimpleType simpleType; // 0xA0
	private XmlSchemaComplexContent complexContent; // 0xA8
	private XmlSchemaComplexContentExtension complexContentExtension; // 0xB0
	private XmlSchemaComplexContentRestriction complexContentRestriction; // 0xB8
	private XmlSchemaSimpleContent simpleContent; // 0xC0
	private XmlSchemaSimpleContentExtension simpleContentExtension; // 0xC8
	private XmlSchemaSimpleContentRestriction simpleContentRestriction; // 0xD0
	private XmlSchemaSimpleTypeUnion simpleTypeUnion; // 0xD8
	private XmlSchemaSimpleTypeList simpleTypeList; // 0xE0
	private XmlSchemaSimpleTypeRestriction simpleTypeRestriction; // 0xE8
	private XmlSchemaGroup group; // 0xF0
	private XmlSchemaGroupRef groupRef; // 0xF8
	private XmlSchemaAll all; // 0x100
	private XmlSchemaChoice choice; // 0x108
	private XmlSchemaSequence sequence; // 0x110
	private XmlSchemaParticle particle; // 0x118
	private XmlSchemaAttributeGroup attributeGroup; // 0x120
	private XmlSchemaAttributeGroupRef attributeGroupRef; // 0x128
	private XmlSchemaNotation notation; // 0x130
	private XmlSchemaIdentityConstraint identityConstraint; // 0x138
	private XmlSchemaXPath xpath; // 0x140
	private XmlSchemaInclude include; // 0x148
	private XmlSchemaImport import; // 0x150
	private XmlSchemaAnnotation annotation; // 0x158
	private XmlSchemaAppInfo appInfo; // 0x160
	private XmlSchemaDocumentation documentation; // 0x168
	private XmlSchemaFacet facet; // 0x170
	private XmlNode[] markup; // 0x178
	private XmlSchemaRedefine redefine; // 0x180
	private ValidationEventHandler validationEventHandler; // 0x188
	private ArrayList unhandledAttributes; // 0x190
	private Hashtable namespaces; // 0x198

	// Properties
	private SchemaNames.Token CurrentElement { get; }
	private SchemaNames.Token ParentElement { get; }
	private XmlSchemaObject ParentContainer { get; }

	// Methods

	// RVA: 0x2494CF0 Offset: 0x24936F0 VA: 0x182494CF0
	internal void .ctor(XmlReader reader, XmlNamespaceManager curmgr, XmlSchema schema, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	// RVA: 0x248C950 Offset: 0x248B350 VA: 0x18248C950 Slot: 4
	internal override bool ProcessElement(string prefix, string name, string ns) { }

	// RVA: 0x248C400 Offset: 0x248AE00 VA: 0x18248C400 Slot: 5
	internal override void ProcessAttribute(string prefix, string name, string ns, string value) { }

	// RVA: 0x248BDA0 Offset: 0x248A7A0 VA: 0x18248BDA0 Slot: 6
	internal override bool IsContentParsed() { }

	// RVA: 0x74C8F0 Offset: 0x74B2F0 VA: 0x18074C8F0 Slot: 7
	internal override void ProcessMarkup(XmlNode[] markup) { }

	// RVA: 0x248C900 Offset: 0x248B300 VA: 0x18248C900 Slot: 8
	internal override void ProcessCData(string value) { }

	// RVA: 0x248EB70 Offset: 0x248D570 VA: 0x18248EB70 Slot: 9
	internal override void StartChildren() { }

	// RVA: 0x2489230 Offset: 0x2487C30 VA: 0x182489230 Slot: 10
	internal override void EndChildren() { }

	// RVA: 0x248CB40 Offset: 0x248B540 VA: 0x18248CB40
	private void Push() { }

	// RVA: 0x248C310 Offset: 0x248AD10 VA: 0x18248C310
	private void Pop() { }

	// RVA: 0x1AB5C80 Offset: 0x1AB4680 VA: 0x181AB5C80
	private SchemaNames.Token get_CurrentElement() { }

	// RVA: 0x2494FE0 Offset: 0x24939E0 VA: 0x182494FE0
	private SchemaNames.Token get_ParentElement() { }

	// RVA: 0x2494F50 Offset: 0x2493950 VA: 0x182494F50
	private XmlSchemaObject get_ParentContainer() { }

	// RVA: 0x24893A0 Offset: 0x2487DA0 VA: 0x1824893A0
	private XmlSchemaObject GetContainer(XsdBuilder.State state) { }

	// RVA: 0x248D3D0 Offset: 0x248BDD0 VA: 0x18248D3D0
	private void SetContainer(XsdBuilder.State state, object container) { }

	// RVA: 0x24875E0 Offset: 0x2485FE0 VA: 0x1824875E0
	private static void BuildAnnotated_Id(XsdBuilder builder, string value) { }

	// RVA: 0x2488AF0 Offset: 0x24874F0 VA: 0x182488AF0
	private static void BuildSchema_AttributeFormDefault(XsdBuilder builder, string value) { }

	// RVA: 0x2488C10 Offset: 0x2487610 VA: 0x182488C10
	private static void BuildSchema_ElementFormDefault(XsdBuilder builder, string value) { }

	// RVA: 0x2488D30 Offset: 0x2487730 VA: 0x182488D30
	private static void BuildSchema_TargetNamespace(XsdBuilder builder, string value) { }

	// RVA: 0x2488D60 Offset: 0x2487760 VA: 0x182488D60
	private static void BuildSchema_Version(XsdBuilder builder, string value) { }

	// RVA: 0x2488CC0 Offset: 0x24876C0 VA: 0x182488CC0
	private static void BuildSchema_FinalDefault(XsdBuilder builder, string value) { }

	// RVA: 0x2488BA0 Offset: 0x24875A0 VA: 0x182488BA0
	private static void BuildSchema_BlockDefault(XsdBuilder builder, string value) { }

	// RVA: 0x248B200 Offset: 0x2489C00 VA: 0x18248B200
	private static void InitSchema(XsdBuilder builder, string value) { }

	// RVA: 0x248AFB0 Offset: 0x24899B0 VA: 0x18248AFB0
	private static void InitInclude(XsdBuilder builder, string value) { }

	// RVA: 0x24889A0 Offset: 0x24873A0 VA: 0x1824889A0
	private static void BuildInclude_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x248AEE0 Offset: 0x24898E0 VA: 0x18248AEE0
	private static void InitImport(XsdBuilder builder, string value) { }

	// RVA: 0x2488940 Offset: 0x2487340 VA: 0x182488940
	private static void BuildImport_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x2488970 Offset: 0x2487370 VA: 0x182488970
	private static void BuildImport_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x248B130 Offset: 0x2489B30 VA: 0x18248B130
	private static void InitRedefine(XsdBuilder builder, string value) { }

	// RVA: 0x2488AC0 Offset: 0x24874C0 VA: 0x182488AC0
	private static void BuildRedefine_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x2489380 Offset: 0x2487D80 VA: 0x182489380
	private static void EndRedefine(XsdBuilder builder) { }

	// RVA: 0x2489F80 Offset: 0x2488980 VA: 0x182489F80
	private static void InitAttribute(XsdBuilder builder, string value) { }

	// RVA: 0x2487910 Offset: 0x2486310 VA: 0x182487910
	private static void BuildAttribute_Default(XsdBuilder builder, string value) { }

	// RVA: 0x2487940 Offset: 0x2486340 VA: 0x182487940
	private static void BuildAttribute_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x2487970 Offset: 0x2486370 VA: 0x182487970
	private static void BuildAttribute_Form(XsdBuilder builder, string value) { }

	// RVA: 0x2487B50 Offset: 0x2486550 VA: 0x182487B50
	private static void BuildAttribute_Use(XsdBuilder builder, string value) { }

	// RVA: 0x2487A50 Offset: 0x2486450 VA: 0x182487A50
	private static void BuildAttribute_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x2487A20 Offset: 0x2486420 VA: 0x182487A20
	private static void BuildAttribute_Name(XsdBuilder builder, string value) { }

	// RVA: 0x2487AD0 Offset: 0x24864D0 VA: 0x182487AD0
	private static void BuildAttribute_Type(XsdBuilder builder, string value) { }

	// RVA: 0x248A690 Offset: 0x2489090 VA: 0x18248A690
	private static void InitElement(XsdBuilder builder, string value) { }

	// RVA: 0x2488130 Offset: 0x2486B30 VA: 0x182488130
	private static void BuildElement_Abstract(XsdBuilder builder, string value) { }

	// RVA: 0x24881B0 Offset: 0x2486BB0 VA: 0x1824881B0
	private static void BuildElement_Block(XsdBuilder builder, string value) { }

	// RVA: 0x2488220 Offset: 0x2486C20 VA: 0x182488220
	private static void BuildElement_Default(XsdBuilder builder, string value) { }

	// RVA: 0x24882F0 Offset: 0x2486CF0 VA: 0x1824882F0
	private static void BuildElement_Form(XsdBuilder builder, string value) { }

	// RVA: 0x2488530 Offset: 0x2486F30 VA: 0x182488530
	private static void BuildElement_SubstitutionGroup(XsdBuilder builder, string value) { }

	// RVA: 0x2488250 Offset: 0x2486C50 VA: 0x182488250
	private static void BuildElement_Final(XsdBuilder builder, string value) { }

	// RVA: 0x24882C0 Offset: 0x2486CC0 VA: 0x1824882C0
	private static void BuildElement_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x24883A0 Offset: 0x2486DA0 VA: 0x1824883A0
	private static void BuildElement_MaxOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x24883D0 Offset: 0x2486DD0 VA: 0x1824883D0
	private static void BuildElement_MinOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x2488400 Offset: 0x2486E00 VA: 0x182488400
	private static void BuildElement_Name(XsdBuilder builder, string value) { }

	// RVA: 0x2488430 Offset: 0x2486E30 VA: 0x182488430
	private static void BuildElement_Nillable(XsdBuilder builder, string value) { }

	// RVA: 0x24884B0 Offset: 0x2486EB0 VA: 0x1824884B0
	private static void BuildElement_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x24885B0 Offset: 0x2486FB0 VA: 0x1824885B0
	private static void BuildElement_Type(XsdBuilder builder, string value) { }

	// RVA: 0x248B9F0 Offset: 0x248A3F0 VA: 0x18248B9F0
	private static void InitSimpleType(XsdBuilder builder, string value) { }

	// RVA: 0x24891C0 Offset: 0x2487BC0 VA: 0x1824891C0
	private static void BuildSimpleType_Name(XsdBuilder builder, string value) { }

	// RVA: 0x2489150 Offset: 0x2487B50 VA: 0x182489150
	private static void BuildSimpleType_Final(XsdBuilder builder, string value) { }

	// RVA: 0x248B900 Offset: 0x248A300 VA: 0x18248B900
	private static void InitSimpleTypeUnion(XsdBuilder builder, string value) { }

	// RVA: 0x2488F90 Offset: 0x2487990 VA: 0x182488F90
	private static void BuildSimpleTypeUnion_MemberTypes(XsdBuilder builder, string value) { }

	// RVA: 0x248B720 Offset: 0x248A120 VA: 0x18248B720
	private static void InitSimpleTypeList(XsdBuilder builder, string value) { }

	// RVA: 0x2488E90 Offset: 0x2487890 VA: 0x182488E90
	private static void BuildSimpleTypeList_ItemType(XsdBuilder builder, string value) { }

	// RVA: 0x248B810 Offset: 0x248A210 VA: 0x18248B810
	private static void InitSimpleTypeRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x2488F10 Offset: 0x2487910 VA: 0x182488F10
	private static void BuildSimpleTypeRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x248A410 Offset: 0x2488E10 VA: 0x18248A410
	private static void InitComplexType(XsdBuilder builder, string value) { }

	// RVA: 0x2487D80 Offset: 0x2486780 VA: 0x182487D80
	private static void BuildComplexType_Abstract(XsdBuilder builder, string value) { }

	// RVA: 0x2487E00 Offset: 0x2486800 VA: 0x182487E00
	private static void BuildComplexType_Block(XsdBuilder builder, string value) { }

	// RVA: 0x2487E80 Offset: 0x2486880 VA: 0x182487E80
	private static void BuildComplexType_Final(XsdBuilder builder, string value) { }

	// RVA: 0x2487EF0 Offset: 0x24868F0 VA: 0x182487EF0
	private static void BuildComplexType_Mixed(XsdBuilder builder, string value) { }

	// RVA: 0x2487F80 Offset: 0x2486980 VA: 0x182487F80
	private static void BuildComplexType_Name(XsdBuilder builder, string value) { }

	// RVA: 0x248A2D0 Offset: 0x2488CD0 VA: 0x18248A2D0
	private static void InitComplexContent(XsdBuilder builder, string value) { }

	// RVA: 0x2487D00 Offset: 0x2486700 VA: 0x182487D00
	private static void BuildComplexContent_Mixed(XsdBuilder builder, string value) { }

	// RVA: 0x248A110 Offset: 0x2488B10 VA: 0x18248A110
	private static void InitComplexContentExtension(XsdBuilder builder, string value) { }

	// RVA: 0x2487C00 Offset: 0x2486600 VA: 0x182487C00
	private static void BuildComplexContentExtension_Base(XsdBuilder builder, string value) { }

	// RVA: 0x248A220 Offset: 0x2488C20 VA: 0x18248A220
	private static void InitComplexContentRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x2487C80 Offset: 0x2486680 VA: 0x182487C80
	private static void BuildComplexContentRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x248B5E0 Offset: 0x2489FE0 VA: 0x18248B5E0
	private static void InitSimpleContent(XsdBuilder builder, string value) { }

	// RVA: 0x248B3C0 Offset: 0x2489DC0 VA: 0x18248B3C0
	private static void InitSimpleContentExtension(XsdBuilder builder, string value) { }

	// RVA: 0x2488D90 Offset: 0x2487790 VA: 0x182488D90
	private static void BuildSimpleContentExtension_Base(XsdBuilder builder, string value) { }

	// RVA: 0x248B4D0 Offset: 0x2489ED0 VA: 0x18248B4D0
	private static void InitSimpleContentRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x2488E10 Offset: 0x2487810 VA: 0x182488E10
	private static void BuildSimpleContentRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x2489EA0 Offset: 0x24888A0 VA: 0x182489EA0
	private static void InitAttributeGroup(XsdBuilder builder, string value) { }

	// RVA: 0x24878E0 Offset: 0x24862E0 VA: 0x1824878E0
	private static void BuildAttributeGroup_Name(XsdBuilder builder, string value) { }

	// RVA: 0x2489E10 Offset: 0x2488810 VA: 0x182489E10
	private static void InitAttributeGroupRef(XsdBuilder builder, string value) { }

	// RVA: 0x2487860 Offset: 0x2486260 VA: 0x182487860
	private static void BuildAttributeGroupRef_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x2489970 Offset: 0x2488370 VA: 0x182489970
	private static void InitAnyAttribute(XsdBuilder builder, string value) { }

	// RVA: 0x2487610 Offset: 0x2486010 VA: 0x182487610
	private static void BuildAnyAttribute_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x2487640 Offset: 0x2486040 VA: 0x182487640
	private static void BuildAnyAttribute_ProcessContents(XsdBuilder builder, string value) { }

	// RVA: 0x248ACB0 Offset: 0x24896B0 VA: 0x18248ACB0
	private static void InitGroup(XsdBuilder builder, string value) { }

	// RVA: 0x24887A0 Offset: 0x24871A0 VA: 0x1824887A0
	private static void BuildGroup_Name(XsdBuilder builder, string value) { }

	// RVA: 0x248AC00 Offset: 0x2489600 VA: 0x18248AC00
	private static void InitGroupRef(XsdBuilder builder, string value) { }

	// RVA: 0x2488A60 Offset: 0x2487460 VA: 0x182488A60
	private static void BuildParticle_MaxOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x2488A90 Offset: 0x2487490 VA: 0x182488A90
	private static void BuildParticle_MinOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x2488720 Offset: 0x2487120 VA: 0x182488720
	private static void BuildGroupRef_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x24897C0 Offset: 0x24881C0 VA: 0x1824897C0
	private static void InitAll(XsdBuilder builder, string value) { }

	// RVA: 0x248A060 Offset: 0x2488A60 VA: 0x18248A060
	private static void InitChoice(XsdBuilder builder, string value) { }

	// RVA: 0x248B310 Offset: 0x2489D10 VA: 0x18248B310
	private static void InitSequence(XsdBuilder builder, string value) { }

	// RVA: 0x2489C80 Offset: 0x2488680 VA: 0x182489C80
	private static void InitAny(XsdBuilder builder, string value) { }

	// RVA: 0x24876F0 Offset: 0x24860F0 VA: 0x1824876F0
	private static void BuildAny_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x2487720 Offset: 0x2486120 VA: 0x182487720
	private static void BuildAny_ProcessContents(XsdBuilder builder, string value) { }

	// RVA: 0x248B080 Offset: 0x2489A80 VA: 0x18248B080
	private static void InitNotation(XsdBuilder builder, string value) { }

	// RVA: 0x24889D0 Offset: 0x24873D0 VA: 0x1824889D0
	private static void BuildNotation_Name(XsdBuilder builder, string value) { }

	// RVA: 0x2488A00 Offset: 0x2487400 VA: 0x182488A00
	private static void BuildNotation_Public(XsdBuilder builder, string value) { }

	// RVA: 0x2488A30 Offset: 0x2487430 VA: 0x182488A30
	private static void BuildNotation_System(XsdBuilder builder, string value) { }

	// RVA: 0x248A7B0 Offset: 0x24891B0 VA: 0x18248A7B0
	private static void InitFacet(XsdBuilder builder, string value) { }

	// RVA: 0x2488630 Offset: 0x2487030 VA: 0x182488630
	private static void BuildFacet_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x24886C0 Offset: 0x24870C0 VA: 0x1824886C0
	private static void BuildFacet_Value(XsdBuilder builder, string value) { }

	// RVA: 0x248AD80 Offset: 0x2489780 VA: 0x18248AD80
	private static void InitIdentityConstraint(XsdBuilder builder, string value) { }

	// RVA: 0x24887D0 Offset: 0x24871D0 VA: 0x1824887D0
	private static void BuildIdentityConstraint_Name(XsdBuilder builder, string value) { }

	// RVA: 0x2488800 Offset: 0x2487200 VA: 0x182488800
	private static void BuildIdentityConstraint_Refer(XsdBuilder builder, string value) { }

	// RVA: 0x248B230 Offset: 0x2489C30 VA: 0x18248B230
	private static void InitSelector(XsdBuilder builder, string value) { }

	// RVA: 0x24886F0 Offset: 0x24870F0 VA: 0x1824886F0
	private static void BuildSelector_XPath(XsdBuilder builder, string value) { }

	// RVA: 0x248AB20 Offset: 0x2489520 VA: 0x18248AB20
	private static void InitField(XsdBuilder builder, string value) { }

	// RVA: 0x24886F0 Offset: 0x24870F0 VA: 0x1824886F0
	private static void BuildField_XPath(XsdBuilder builder, string value) { }

	// RVA: 0x2489870 Offset: 0x2488270 VA: 0x182489870
	private static void InitAnnotation(XsdBuilder builder, string value) { }

	// RVA: 0x2489D30 Offset: 0x2488730 VA: 0x182489D30
	private static void InitAppinfo(XsdBuilder builder, string value) { }

	// RVA: 0x24877E0 Offset: 0x24861E0 VA: 0x1824877E0
	private static void BuildAppinfo_Source(XsdBuilder builder, string value) { }

	// RVA: 0x24891F0 Offset: 0x2487BF0 VA: 0x1824891F0
	private static void EndAppinfo(XsdBuilder builder) { }

	// RVA: 0x248A5B0 Offset: 0x2488FB0 VA: 0x18248A5B0
	private static void InitDocumentation(XsdBuilder builder, string value) { }

	// RVA: 0x2487FB0 Offset: 0x24869B0 VA: 0x182487FB0
	private static void BuildDocumentation_Source(XsdBuilder builder, string value) { }

	// RVA: 0x2488030 Offset: 0x2486A30 VA: 0x182488030
	private static void BuildDocumentation_XmlLang(XsdBuilder builder, string value) { }

	// RVA: 0x2489340 Offset: 0x2487D40 VA: 0x182489340
	private static void EndDocumentation(XsdBuilder builder) { }

	// RVA: 0x2486FE0 Offset: 0x24859E0 VA: 0x182486FE0
	private void AddAttribute(XmlSchemaObject value) { }

	// RVA: 0x2487250 Offset: 0x2485C50 VA: 0x182487250
	private void AddParticle(XmlSchemaParticle particle) { }

	// RVA: 0x24895F0 Offset: 0x2487FF0 VA: 0x1824895F0
	private bool GetNextState(XmlQualifiedName qname) { }

	// RVA: 0x248BDC0 Offset: 0x248A7C0 VA: 0x18248BDC0
	private bool IsSkipableElement(XmlQualifiedName qname) { }

	// RVA: 0x248EB10 Offset: 0x248D510 VA: 0x18248EB10
	private void SetMinOccurs(XmlSchemaParticle particle, string value) { }

	// RVA: 0x248EAB0 Offset: 0x248D4B0 VA: 0x18248EAB0
	private void SetMaxOccurs(XmlSchemaParticle particle, string value) { }

	// RVA: 0x248C090 Offset: 0x248AA90 VA: 0x18248C090
	private bool ParseBoolean(string value, string attributeName) { }

	// RVA: 0x248C120 Offset: 0x248AB20 VA: 0x18248C120
	private int ParseEnum(string value, string attributeName, string[] values) { }

	// RVA: 0x248C210 Offset: 0x248AC10 VA: 0x18248C210
	private XmlQualifiedName ParseQName(string value, string attributeName) { }

	// RVA: 0x248BDF0 Offset: 0x248A7F0 VA: 0x18248BDF0
	private int ParseBlockFinalEnum(string value, string attributeName) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	private static string ParseUriReference(string s) { }

	// RVA: 0x248CF10 Offset: 0x248B910 VA: 0x18248CF10
	private void SendValidationEvent(string code, string arg0, string arg1, string arg2) { }

	// RVA: 0x248D0B0 Offset: 0x248BAB0 VA: 0x18248D0B0
	private void SendValidationEvent(string code, string msg) { }

	// RVA: 0x248D2B0 Offset: 0x248BCB0 VA: 0x18248D2B0
	private void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x248D1C0 Offset: 0x248BBC0 VA: 0x18248D1C0
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x248CF00 Offset: 0x248B900 VA: 0x18248CF00
	private void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x248CE20 Offset: 0x248B820 VA: 0x18248CE20
	private void RecordPosition() { }

	// RVA: 0x248ED50 Offset: 0x248D750 VA: 0x18248ED50
	private static void .cctor() { }
}
