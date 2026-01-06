public sealed class XmlSchemaInference // TypeDefIndex: 8361
{
	// Fields
	internal static XmlQualifiedName ST_boolean; // 0x0
	internal static XmlQualifiedName ST_byte; // 0x8
	internal static XmlQualifiedName ST_unsignedByte; // 0x10
	internal static XmlQualifiedName ST_short; // 0x18
	internal static XmlQualifiedName ST_unsignedShort; // 0x20
	internal static XmlQualifiedName ST_int; // 0x28
	internal static XmlQualifiedName ST_unsignedInt; // 0x30
	internal static XmlQualifiedName ST_long; // 0x38
	internal static XmlQualifiedName ST_unsignedLong; // 0x40
	internal static XmlQualifiedName ST_integer; // 0x48
	internal static XmlQualifiedName ST_decimal; // 0x50
	internal static XmlQualifiedName ST_float; // 0x58
	internal static XmlQualifiedName ST_double; // 0x60
	internal static XmlQualifiedName ST_duration; // 0x68
	internal static XmlQualifiedName ST_dateTime; // 0x70
	internal static XmlQualifiedName ST_time; // 0x78
	internal static XmlQualifiedName ST_date; // 0x80
	internal static XmlQualifiedName ST_gYearMonth; // 0x88
	internal static XmlQualifiedName ST_string; // 0x90
	internal static XmlQualifiedName ST_anySimpleType; // 0x98
	internal static XmlQualifiedName[] SimpleTypes; // 0xA0
	private XmlSchema rootSchema; // 0x10
	private XmlSchemaSet schemaSet; // 0x18
	private XmlReader xtr; // 0x20
	private NameTable nametable; // 0x28
	private string TargetNamespace; // 0x30
	private XmlNamespaceManager NamespaceManager; // 0x38
	private ArrayList schemaList; // 0x40
	private XmlSchemaInference.InferenceOption occurrence; // 0x48
	private XmlSchemaInference.InferenceOption typeInference; // 0x4C

	// Properties
	public XmlSchemaInference.InferenceOption Occurrence { get; set; }
	public XmlSchemaInference.InferenceOption TypeInference { set; }

	// Methods

	// RVA: 0x4E28C0 Offset: 0x4E12C0 VA: 0x1804E28C0
	public void set_Occurrence(XmlSchemaInference.InferenceOption value) { }

	// RVA: 0x4B61C0 Offset: 0x4B4BC0 VA: 0x1804B61C0
	public XmlSchemaInference.InferenceOption get_Occurrence() { }

	// RVA: 0x4E27E0 Offset: 0x4E11E0 VA: 0x1804E27E0
	public void set_TypeInference(XmlSchemaInference.InferenceOption value) { }

	// RVA: 0x23FB310 Offset: 0x23F9D10 VA: 0x1823FB310
	public void .ctor() { }

	// RVA: 0x23F7670 Offset: 0x23F6070 VA: 0x1823F7670
	public XmlSchemaSet InferSchema(XmlReader instanceDocument) { }

	// RVA: 0x23F6E10 Offset: 0x23F5810 VA: 0x1823F6E10
	internal XmlSchemaSet InferSchema1(XmlReader instanceDocument, XmlSchemaSet schemas) { }

	// RVA: 0x23F11A0 Offset: 0x23EFBA0 VA: 0x1823F11A0
	private XmlSchemaAttribute AddAttribute(string localName, string prefix, string childURI, string attrValue, bool bCreatingNewType, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, XmlSchemaObjectTable compiledAttributes) { }

	// RVA: 0x23F2660 Offset: 0x23F1060 VA: 0x1823F2660
	private XmlSchema CreateXmlSchema(string targetNS) { }

	// RVA: 0x23F1AF0 Offset: 0x23F04F0 VA: 0x1823F1AF0
	private XmlSchemaElement AddElement(string localName, string prefix, string childURI, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, int positionWithinCollection) { }

	// RVA: 0x23F51A0 Offset: 0x23F3BA0 VA: 0x1823F51A0
	internal void InferElement(XmlSchemaElement xse, bool bCreatingNewType, XmlSchema parentSchema) { }

	// RVA: 0x23F2230 Offset: 0x23F0C30 VA: 0x1823F2230
	private XmlSchemaSimpleContentExtension CheckSimpleContentExtension(XmlSchemaComplexType ct) { }

	// RVA: 0x23F45B0 Offset: 0x23F2FB0 VA: 0x1823F45B0
	private XmlSchemaType GetEffectiveSchemaType(XmlSchemaElement elem, bool bCreatingNewType) { }

	// RVA: 0x23F30B0 Offset: 0x23F1AB0 VA: 0x1823F30B0
	internal XmlSchemaElement FindMatchingElement(bool bCreatingNewType, XmlReader xtr, XmlSchemaComplexType ct, ref int lastUsedSeqItem, ref bool bParticleChanged, XmlSchema parentSchema, bool setMaxoccurs) { }

	// RVA: 0x23F8BF0 Offset: 0x23F75F0 VA: 0x1823F8BF0
	internal void ProcessAttributes(ref XmlSchemaElement xse, XmlSchemaType effectiveSchemaType, bool bCreatingNewType, XmlSchema parentSchema) { }

	// RVA: 0x23F8880 Offset: 0x23F7280 VA: 0x1823F8880
	private void MoveAttributes(XmlSchemaSimpleContentExtension scExtension, XmlSchemaComplexType ct) { }

	// RVA: 0x23F8920 Offset: 0x23F7320 VA: 0x1823F8920
	private void MoveAttributes(XmlSchemaComplexType ct, XmlSchemaSimpleContentExtension simpleContentExtension, bool bCreatingNewType) { }

	// RVA: 0x23F2A10 Offset: 0x23F1410 VA: 0x1823F2A10
	internal XmlSchemaAttribute FindAttribute(ICollection attributes, string attrName) { }

	// RVA: 0x23F2EA0 Offset: 0x23F18A0 VA: 0x1823F2EA0
	internal XmlSchemaElement FindGlobalElement(string namespaceURI, string localName, out XmlSchema parentSchema) { }

	// RVA: 0x23F2D70 Offset: 0x23F1770 VA: 0x1823F2D70
	internal XmlSchemaElement FindElement(XmlSchemaObjectCollection elements, string elementName) { }

	// RVA: 0x23F27D0 Offset: 0x23F11D0 VA: 0x1823F27D0
	internal XmlSchemaAttribute FindAttributeRef(ICollection attributes, string attributeName, string nsURI) { }

	// RVA: 0x23F2C10 Offset: 0x23F1610 VA: 0x1823F2C10
	internal XmlSchemaElement FindElementRef(XmlSchemaObjectCollection elements, string elementName, string nsURI) { }

	// RVA: 0x23F87B0 Offset: 0x23F71B0 VA: 0x1823F87B0
	internal void MakeExistingAttributesOptional(XmlSchemaComplexType ct, XmlSchemaObjectCollection attributesInInstance) { }

	// RVA: 0x23FA2D0 Offset: 0x23F8CD0 VA: 0x1823FA2D0
	private void SwitchUseToOptional(XmlSchemaObjectCollection attributes, XmlSchemaObjectCollection attributesInInstance) { }

	// RVA: 0x23F9410 Offset: 0x23F7E10 VA: 0x1823F9410
	internal XmlQualifiedName RefineSimpleType(string s, ref int iTypeFlags) { }

	// RVA: 0x23F76F0 Offset: 0x23F60F0 VA: 0x1823F76F0
	internal static int InferSimpleType(string s, ref bool bNeedsRangeCheck) { }

	// RVA: 0x23F2700 Offset: 0x23F1100 VA: 0x1823F2700
	internal static int DateTime(string s, bool bDate, bool bTime) { }

	// RVA: 0x23F23B0 Offset: 0x23F0DB0 VA: 0x1823F23B0
	private XmlSchemaElement CreateNewElementforChoice(XmlSchemaElement copyElement) { }

	// RVA: 0x23F4730 Offset: 0x23F3130 VA: 0x1823F4730
	private static int GetSchemaType(XmlQualifiedName qname) { }

	// RVA: 0x23FA0F0 Offset: 0x23F8AF0 VA: 0x1823FA0F0
	internal void SetMinMaxOccurs(XmlSchemaElement el, bool setMaxOccurs) { }

	// RVA: 0x23FA400 Offset: 0x23F8E00 VA: 0x1823FA400
	private static void .cctor() { }
}
