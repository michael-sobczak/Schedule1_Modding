internal sealed class Compiler : BaseProcessor // TypeDefIndex: 8386
{
	// Fields
	private string restrictionErrorMsg; // 0x40
	private XmlSchemaObjectTable attributes; // 0x48
	private XmlSchemaObjectTable attributeGroups; // 0x50
	private XmlSchemaObjectTable elements; // 0x58
	private XmlSchemaObjectTable schemaTypes; // 0x60
	private XmlSchemaObjectTable groups; // 0x68
	private XmlSchemaObjectTable notations; // 0x70
	private XmlSchemaObjectTable examplars; // 0x78
	private XmlSchemaObjectTable identityConstraints; // 0x80
	private Stack complexTypeStack; // 0x88
	private Hashtable schemasToCompile; // 0x90
	private Hashtable importedSchemas; // 0x98
	private XmlSchema schemaForSchema; // 0xA0

	// Methods

	// RVA: 0x242BDC0 Offset: 0x242A7C0 VA: 0x18242BDC0
	public void .ctor(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchema schemaForSchema, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x2425220 Offset: 0x2423C20 VA: 0x182425220
	public bool Execute(XmlSchemaSet schemaSet, SchemaInfo schemaCompiledInfo) { }

	// RVA: 0x2429EE0 Offset: 0x24288E0 VA: 0x182429EE0
	internal void Prepare(XmlSchema schema, bool cleanup) { }

	// RVA: 0x242BC40 Offset: 0x242A640 VA: 0x18242BC40
	private void UpdateSForSSimpleTypes() { }

	// RVA: 0x24290E0 Offset: 0x2427AE0 VA: 0x1824290E0
	private void Output(SchemaInfo schemaInfo) { }

	// RVA: 0x2425730 Offset: 0x2424130 VA: 0x182425730
	internal void ImportAllCompiledSchemas(XmlSchemaSet schemaSet) { }

	// RVA: 0x24235E0 Offset: 0x2421FE0 VA: 0x1824235E0
	internal bool Compile() { }

	// RVA: 0x241AAD0 Offset: 0x24194D0 VA: 0x18241AAD0
	private void CleanupAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x241AA50 Offset: 0x2419450 VA: 0x18241AA50
	private void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x241ACA0 Offset: 0x24196A0 VA: 0x18241ACA0
	private void CleanupComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x241B6B0 Offset: 0x241A0B0 VA: 0x18241B6B0
	private void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x241B210 Offset: 0x2419C10 VA: 0x18241B210
	private void CleanupElement(XmlSchemaElement element) { }

	// RVA: 0x241ABD0 Offset: 0x24195D0 VA: 0x18241ABD0
	private void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x241B490 Offset: 0x2419E90 VA: 0x18241B490
	private void CleanupGroup(XmlSchemaGroup group) { }

	// RVA: 0x241B4F0 Offset: 0x2419EF0 VA: 0x18241B4F0
	private void CleanupParticle(XmlSchemaParticle particle) { }

	// RVA: 0x242B100 Offset: 0x2429B00 VA: 0x18242B100
	private void ProcessSubstitutionGroups() { }

	// RVA: 0x2423010 Offset: 0x2421A10 VA: 0x182423010
	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	// RVA: 0x242B890 Offset: 0x242A290 VA: 0x18242B890
	private void RecursivelyCheckRedefinedGroups(XmlSchemaGroup redefinedGroup, XmlSchemaGroup baseGroup) { }

	// RVA: 0x242B800 Offset: 0x242A200 VA: 0x18242B800
	private void RecursivelyCheckRedefinedAttributeGroups(XmlSchemaAttributeGroup attributeGroup, XmlSchemaAttributeGroup baseAttributeGroup) { }

	// RVA: 0x2420200 Offset: 0x241EC00 VA: 0x182420200
	private void CompileGroup(XmlSchemaGroup group) { }

	// RVA: 0x2422610 Offset: 0x2421010 VA: 0x182422610
	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x241CA80 Offset: 0x241B480 VA: 0x18241CA80
	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x241A920 Offset: 0x2419320 VA: 0x18241A920
	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	// RVA: 0x241E460 Offset: 0x241CE60 VA: 0x18241E460
	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x2421F30 Offset: 0x2420930 VA: 0x182421F30
	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	// RVA: 0x24221D0 Offset: 0x2420BD0 VA: 0x1824221D0
	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	// RVA: 0x241CE90 Offset: 0x241B890 VA: 0x18241CE90
	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	// RVA: 0x241D2B0 Offset: 0x241BCB0 VA: 0x18241D2B0
	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	// RVA: 0x241A320 Offset: 0x2418D20 VA: 0x18241A320
	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	// RVA: 0x241A840 Offset: 0x2419240 VA: 0x18241A840
	private void CheckParticleDerivation(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x241EFF0 Offset: 0x241D9F0 VA: 0x18241EFF0
	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle) { }

	// RVA: 0x2418D70 Offset: 0x2417770 VA: 0x182418D70
	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root) { }

	// RVA: 0x2418470 Offset: 0x2416E70 VA: 0x182418470
	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element) { }

	// RVA: 0x24186F0 Offset: 0x24170F0 VA: 0x1824186F0
	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root) { }

	// RVA: 0x2417AB0 Offset: 0x24164B0 VA: 0x182417AB0
	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root) { }

	// RVA: 0x2417DB0 Offset: 0x24167B0 VA: 0x182417DB0
	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root) { }

	// RVA: 0x2419530 Offset: 0x2417F30 VA: 0x182419530
	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root) { }

	// RVA: 0x2419070 Offset: 0x2417A70 VA: 0x182419070
	private XmlSchemaParticle CannonicalizePointlessRoot(XmlSchemaParticle particle) { }

	// RVA: 0x2427EA0 Offset: 0x24268A0 VA: 0x182427EA0
	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x2425CF0 Offset: 0x24246F0 VA: 0x182425CF0
	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	// RVA: 0x2425B00 Offset: 0x2424500 VA: 0x182425B00
	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	// RVA: 0x2425830 Offset: 0x2424230 VA: 0x182425830
	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	// RVA: 0x2426B70 Offset: 0x2425570 VA: 0x182426B70
	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	// RVA: 0x2425F70 Offset: 0x2424970 VA: 0x182425F70
	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase) { }

	// RVA: 0x2425940 Offset: 0x2424340 VA: 0x182425940
	private bool IsChoiceFromChoiceSubstGroup(XmlSchemaChoice derivedChoice, XmlSchemaChoice baseChoice) { }

	// RVA: 0x2427050 Offset: 0x2425A50 VA: 0x182427050
	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x2427530 Offset: 0x2425F30 VA: 0x182427530
	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	// RVA: 0x2427870 Offset: 0x2426270 VA: 0x182427870
	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	// RVA: 0x2427D90 Offset: 0x2426790 VA: 0x182427D90
	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x2427CC0 Offset: 0x24266C0 VA: 0x182427CC0
	private bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs) { }

	// RVA: 0x2425550 Offset: 0x2423F50 VA: 0x182425550
	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	// RVA: 0x24273A0 Offset: 0x2425DA0 VA: 0x1824273A0
	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	// RVA: 0x24172E0 Offset: 0x2415CE0 VA: 0x1824172E0
	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0x242B7D0 Offset: 0x242A1D0 VA: 0x18242B7D0
	private void PushComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x240AE20 Offset: 0x2409820 VA: 0x18240AE20
	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	// RVA: 0x241B8E0 Offset: 0x241A2E0 VA: 0x18241B8E0
	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x2420980 Offset: 0x241F380 VA: 0x182420980
	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	// RVA: 0x2419B60 Offset: 0x2418560 VA: 0x182419B60
	private void CheckAtrributeGroupRestriction(XmlSchemaAttributeGroup baseAttributeGroup, XmlSchemaAttributeGroup derivedAttributeGroup) { }

	// RVA: 0x2427450 Offset: 0x2425E50 VA: 0x182427450
	private bool IsProcessContentsRestricted(XmlSchemaComplexType baseType, XmlSchemaAnyAttribute derivedAttributeWildcard, XmlSchemaAnyAttribute baseAttributeWildcard) { }

	// RVA: 0x241B830 Offset: 0x241A230 VA: 0x18241B830
	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x241B780 Offset: 0x241A180 VA: 0x18241B780
	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x241C0F0 Offset: 0x241AAF0 VA: 0x18241C0F0
	private void CompileAttribute(XmlSchemaAttribute xa) { }

	// RVA: 0x242BA30 Offset: 0x242A430 VA: 0x18242BA30
	private void SetDefaultFixed(XmlSchemaAttribute xa, SchemaAttDef decl) { }

	// RVA: 0x24202E0 Offset: 0x241ECE0 VA: 0x1824202E0
	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	// RVA: 0x241F180 Offset: 0x241DB80 VA: 0x18241F180
	private void CompileElement(XmlSchemaElement xe) { }

	// RVA: 0x241D610 Offset: 0x241C010 VA: 0x18241D610
	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	// RVA: 0x2416C40 Offset: 0x2415640 VA: 0x182416C40
	private bool BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	// RVA: 0x2421C40 Offset: 0x2420640 VA: 0x182421C40
	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	// RVA: 0x2421A50 Offset: 0x2420450 VA: 0x182421A50
	private void CompileParticleElements(XmlSchemaParticle particle) { }

	// RVA: 0x241E330 Offset: 0x241CD30 VA: 0x18241E330
	private void CompileComplexTypeElements(XmlSchemaComplexType complexType) { }

	// RVA: 0x2425650 Offset: 0x2424050 VA: 0x182425650
	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	// RVA: 0x24254A0 Offset: 0x2423EA0 VA: 0x1824254A0
	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	// RVA: 0x24252E0 Offset: 0x2423CE0 VA: 0x1824252E0
	private XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }

	// RVA: 0x2425190 Offset: 0x2423B90 VA: 0x182425190
	private void CopyPosition(XmlSchemaAnnotated to, XmlSchemaAnnotated from, bool copyParent) { }

	// RVA: 0x24269F0 Offset: 0x24253F0 VA: 0x1824269F0
	private bool IsFixedEqual(SchemaDeclBase baseDecl, SchemaDeclBase derivedDecl) { }
}
