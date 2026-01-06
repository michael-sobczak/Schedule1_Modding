internal sealed class SchemaCollectionCompiler : BaseProcessor // TypeDefIndex: 8373
{
	// Fields
	private bool compileContentModel; // 0x40
	private XmlSchemaObjectTable examplars; // 0x48
	private Stack complexTypeStack; // 0x50
	private XmlSchema schema; // 0x58

	// Methods

	// RVA: 0x240DFF0 Offset: 0x240C9F0 VA: 0x18240DFF0
	public void .ctor(XmlNameTable nameTable, ValidationEventHandler eventHandler) { }

	// RVA: 0x240AA10 Offset: 0x2409410 VA: 0x18240AA10
	public bool Execute(XmlSchema schema, SchemaInfo schemaInfo, bool compileContentModel) { }

	// RVA: 0x240DC60 Offset: 0x240C660 VA: 0x18240DC60
	private void Prepare() { }

	// RVA: 0x23FFCF0 Offset: 0x23FE6F0 VA: 0x1823FFCF0
	private void Cleanup() { }

	// RVA: 0x24009B0 Offset: 0x23FF3B0 VA: 0x1824009B0
	internal static void Cleanup(XmlSchema schema) { }

	// RVA: 0x2408E90 Offset: 0x2407890 VA: 0x182408E90
	private void Compile() { }

	// RVA: 0x240CFB0 Offset: 0x240B9B0 VA: 0x18240CFB0
	private void Output(SchemaInfo schemaInfo) { }

	// RVA: 0x23FF340 Offset: 0x23FDD40 VA: 0x1823FF340
	private static void CleanupAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x23FF2E0 Offset: 0x23FDCE0 VA: 0x1823FF2E0
	private static void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x23FF490 Offset: 0x23FDE90 VA: 0x1823FF490
	private static void CleanupComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x23FFCD0 Offset: 0x23FE6D0 VA: 0x1823FFCD0
	private static void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x23FF8E0 Offset: 0x23FE2E0 VA: 0x1823FF8E0
	private static void CleanupElement(XmlSchemaElement element) { }

	// RVA: 0x23FF390 Offset: 0x23FDD90 VA: 0x1823FF390
	private static void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x23FFAB0 Offset: 0x23FE4B0 VA: 0x1823FFAB0
	private static void CleanupGroup(XmlSchemaGroup group) { }

	// RVA: 0x23FFAF0 Offset: 0x23FE4F0 VA: 0x1823FFAF0
	private static void CleanupParticle(XmlSchemaParticle particle) { }

	// RVA: 0x2408950 Offset: 0x2407350 VA: 0x182408950
	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroupV1Compat substitutionGroup) { }

	// RVA: 0x23FEF70 Offset: 0x23FD970 VA: 0x1823FEF70
	private void CheckSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	// RVA: 0x2405DE0 Offset: 0x24047E0 VA: 0x182405DE0
	private void CompileGroup(XmlSchemaGroup group) { }

	// RVA: 0x2407F80 Offset: 0x2406980 VA: 0x182407F80
	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x24025B0 Offset: 0x2400FB0 VA: 0x1824025B0
	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x23FF1B0 Offset: 0x23FDBB0 VA: 0x1823FF1B0
	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	// RVA: 0x2404070 Offset: 0x2402A70 VA: 0x182404070
	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x24078A0 Offset: 0x24062A0 VA: 0x1824078A0
	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	// RVA: 0x2407B40 Offset: 0x2406540 VA: 0x182407B40
	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	// RVA: 0x2402A90 Offset: 0x2401490 VA: 0x182402A90
	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	// RVA: 0x2402F90 Offset: 0x2401990 VA: 0x182402F90
	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	// RVA: 0x23FEE30 Offset: 0x23FD830 VA: 0x1823FEE30
	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	// RVA: 0x2404CB0 Offset: 0x24036B0 VA: 0x182404CB0
	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle, bool substitution) { }

	// RVA: 0x23FE370 Offset: 0x23FCD70 VA: 0x1823FE370
	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root, bool substitution) { }

	// RVA: 0x23FDB40 Offset: 0x23FC540 VA: 0x1823FDB40
	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element, bool substitution) { }

	// RVA: 0x23FDCE0 Offset: 0x23FC6E0 VA: 0x1823FDCE0
	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root, bool substitution) { }

	// RVA: 0x23FCF10 Offset: 0x23FB910 VA: 0x1823FCF10
	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root, bool substitution) { }

	// RVA: 0x23FD4C0 Offset: 0x23FBEC0 VA: 0x1823FD4C0
	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root, bool substitution) { }

	// RVA: 0x23FE820 Offset: 0x23FD220 VA: 0x1823FE820
	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root, bool substitution) { }

	// RVA: 0x240C3C0 Offset: 0x240ADC0 VA: 0x18240C3C0
	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x240B0D0 Offset: 0x2409AD0 VA: 0x18240B0D0
	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	// RVA: 0x240B060 Offset: 0x2409A60 VA: 0x18240B060
	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	// RVA: 0x240B000 Offset: 0x2409A00 VA: 0x18240B000
	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	// RVA: 0x240B5A0 Offset: 0x2409FA0 VA: 0x18240B5A0
	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	// RVA: 0x240B210 Offset: 0x2409C10 VA: 0x18240B210
	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x240B860 Offset: 0x240A260 VA: 0x18240B860
	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x240BBE0 Offset: 0x240A5E0 VA: 0x18240BBE0
	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	// RVA: 0x240BF20 Offset: 0x240A920 VA: 0x18240BF20
	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	// RVA: 0x23FCAE0 Offset: 0x23FB4E0 VA: 0x1823FCAE0
	private void CalculateSequenceRange(XmlSchemaSequence sequence, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0x240C2B0 Offset: 0x240ACB0 VA: 0x18240C2B0
	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x240C1E0 Offset: 0x240ABE0 VA: 0x18240C1E0
	private bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs) { }

	// RVA: 0x240AD20 Offset: 0x2409720 VA: 0x18240AD20
	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	// RVA: 0x240BB30 Offset: 0x240A530 VA: 0x18240BB30
	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	// RVA: 0x23FC140 Offset: 0x23FAB40 VA: 0x1823FC140
	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0x240DFC0 Offset: 0x240C9C0 VA: 0x18240DFC0
	private void PushComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x240AE20 Offset: 0x2409820 VA: 0x18240AE20
	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	// RVA: 0x24012D0 Offset: 0x23FFCD0 VA: 0x1824012D0
	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x2406570 Offset: 0x2404F70 VA: 0x182406570
	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	// RVA: 0x2401220 Offset: 0x23FFC20 VA: 0x182401220
	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x2401170 Offset: 0x23FFB70 VA: 0x182401170
	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x24019A0 Offset: 0x24003A0 VA: 0x1824019A0
	private void CompileAttribute(XmlSchemaAttribute xa) { }

	// RVA: 0x2405ED0 Offset: 0x24048D0 VA: 0x182405ED0
	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	// RVA: 0x2404E60 Offset: 0x2403860 VA: 0x182404E60
	private void CompileElement(XmlSchemaElement xe) { }

	// RVA: 0x2403310 Offset: 0x2401D10 VA: 0x182403310
	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	// RVA: 0x23FBAA0 Offset: 0x23FA4A0 VA: 0x1823FBAA0
	private void BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	// RVA: 0x24075B0 Offset: 0x2405FB0 VA: 0x1824075B0
	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	// RVA: 0x24029C0 Offset: 0x24013C0 VA: 0x1824029C0
	private void CompileCompexTypeElements(XmlSchemaComplexType complexType) { }

	// RVA: 0x240AEA0 Offset: 0x24098A0 VA: 0x18240AEA0
	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	// RVA: 0x240AC60 Offset: 0x2409660 VA: 0x18240AC60
	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	// RVA: 0x240AA90 Offset: 0x2409490 VA: 0x18240AA90
	private XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }
}
