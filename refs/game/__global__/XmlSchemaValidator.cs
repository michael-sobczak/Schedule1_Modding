public sealed class XmlSchemaValidator // TypeDefIndex: 8496
{
	// Fields
	private XmlSchemaSet schemaSet; // 0x10
	private XmlSchemaValidationFlags validationFlags; // 0x18
	private int startIDConstraint; // 0x1C
	private bool isRoot; // 0x20
	private bool rootHasSchema; // 0x21
	private bool attrValid; // 0x22
	private bool checkEntity; // 0x23
	private SchemaInfo compiledSchemaInfo; // 0x28
	private IDtdInfo dtdSchemaInfo; // 0x30
	private Hashtable validatedNamespaces; // 0x38
	private HWStack validationStack; // 0x40
	private ValidationState context; // 0x48
	private ValidatorState currentState; // 0x50
	private Hashtable attPresence; // 0x58
	private SchemaAttDef wildID; // 0x60
	private Hashtable IDs; // 0x68
	private IdRefNode idRefListHead; // 0x70
	private XmlQualifiedName contextQName; // 0x78
	private string NsXs; // 0x80
	private string NsXsi; // 0x88
	private string NsXmlNs; // 0x90
	private string NsXml; // 0x98
	private XmlSchemaObject partialValidationType; // 0xA0
	private StringBuilder textValue; // 0xA8
	private ValidationEventHandler eventHandler; // 0xB0
	private object validationEventSender; // 0xB8
	private XmlNameTable nameTable; // 0xC0
	private IXmlLineInfo positionInfo; // 0xC8
	private IXmlLineInfo dummyPositionInfo; // 0xD0
	private XmlResolver xmlResolver; // 0xD8
	private Uri sourceUri; // 0xE0
	private string sourceUriString; // 0xE8
	private IXmlNamespaceResolver nsResolver; // 0xF0
	private XmlSchemaContentProcessing processContents; // 0xF8
	private string xsiTypeString; // 0x100
	private string xsiNilString; // 0x108
	private string xsiSchemaLocationString; // 0x110
	private string xsiNoNamespaceSchemaLocationString; // 0x118
	private static readonly XmlSchemaDatatype dtQName; // 0x0
	private static readonly XmlSchemaDatatype dtCDATA; // 0x8
	private static readonly XmlSchemaDatatype dtStringArray; // 0x10
	private static XmlSchemaParticle[] EmptyParticleArray; // 0x18
	private static XmlSchemaAttribute[] EmptyAttributeArray; // 0x20
	private XmlCharType xmlCharType; // 0x120
	internal static bool[,] ValidStates; // 0x28
	private static string[] MethodNames; // 0x30

	// Properties
	public XmlResolver XmlResolver { set; }
	public IXmlLineInfo LineInfoProvider { set; }
	public Uri SourceUri { set; }
	public object ValidationEventSender { set; }
	internal XmlSchemaSet SchemaSet { get; }
	internal XmlSchemaValidationFlags ValidationFlags { get; }
	internal XmlSchemaContentType CurrentContentType { get; }
	private bool StrictlyAssessed { get; }
	private bool HasSchema { get; }
	private bool HasIdentityConstraints { get; }
	internal bool ProcessIdentityConstraints { get; }
	internal bool ReportValidationWarnings { get; }
	internal bool ProcessSchemaHints { get; }

	// Methods

	// RVA: 0x246C560 Offset: 0x246AF60 VA: 0x18246C560
	public void .ctor(XmlNameTable nameTable, XmlSchemaSet schemas, IXmlNamespaceResolver namespaceResolver, XmlSchemaValidationFlags validationFlags) { }

	// RVA: 0x2465EC0 Offset: 0x24648C0 VA: 0x182465EC0
	private void Init() { }

	// RVA: 0x2468B00 Offset: 0x2467500 VA: 0x182468B00
	private void Reset() { }

	// RVA: 0x4E8E20 Offset: 0x4E7820 VA: 0x1804E8E20
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x246CBD0 Offset: 0x246B5D0 VA: 0x18246CBD0
	public void set_LineInfoProvider(IXmlLineInfo value) { }

	// RVA: 0x246CC00 Offset: 0x246B600 VA: 0x18246CC00
	public void set_SourceUri(Uri value) { }

	// RVA: 0x4B6CA0 Offset: 0x4B56A0 VA: 0x1804B6CA0
	public void set_ValidationEventSender(object value) { }

	// RVA: 0x246C940 Offset: 0x246B340 VA: 0x18246C940
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x246CB20 Offset: 0x246B520 VA: 0x18246CB20
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x24605F0 Offset: 0x245EFF0 VA: 0x1824605F0
	public void AddSchema(XmlSchema schema) { }

	// RVA: 0x2466310 Offset: 0x2464D10 VA: 0x182466310
	public void Initialize() { }

	// RVA: 0x2466470 Offset: 0x2464E70 VA: 0x182466470
	public void Initialize(XmlSchemaObject partialValidationType) { }

	// RVA: 0x246B300 Offset: 0x2469D00 VA: 0x18246B300
	public void ValidateElement(string localName, string namespaceUri, XmlSchemaInfo schemaInfo, string xsiType, string xsiNil, string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	// RVA: 0x246AD10 Offset: 0x2469710 VA: 0x18246AD10
	public object ValidateAttribute(string localName, string namespaceUri, XmlValueGetter attributeValue, XmlSchemaInfo schemaInfo) { }

	// RVA: 0x246A270 Offset: 0x2468C70 VA: 0x18246A270
	private object ValidateAttribute(string lName, string ns, XmlValueGetter attributeValueGetter, string attributeStringValue, XmlSchemaInfo schemaInfo) { }

	// RVA: 0x246B830 Offset: 0x246A230 VA: 0x18246B830
	public void ValidateEndOfAttributes(XmlSchemaInfo schemaInfo) { }

	// RVA: 0x246B960 Offset: 0x246A360 VA: 0x18246B960
	public void ValidateText(XmlValueGetter elementValue) { }

	// RVA: 0x246B9D0 Offset: 0x246A3D0 VA: 0x18246B9D0
	private void ValidateText(string elementStringValue, XmlValueGetter elementValueGetter) { }

	// RVA: 0x246C0A0 Offset: 0x246AAA0 VA: 0x18246C0A0
	public void ValidateWhitespace(XmlValueGetter elementValue) { }

	// RVA: 0x246BE30 Offset: 0x246A830 VA: 0x18246BE30
	private void ValidateWhitespace(string elementStringValue, XmlValueGetter elementValueGetter) { }

	// RVA: 0x246B820 Offset: 0x246A220 VA: 0x18246B820
	public object ValidateEndElement(XmlSchemaInfo schemaInfo) { }

	// RVA: 0x24696B0 Offset: 0x24680B0 VA: 0x1824696B0
	public void SkipToEndElement(XmlSchemaInfo schemaInfo) { }

	// RVA: 0x24648B0 Offset: 0x24632B0 VA: 0x1824648B0
	public void EndValidation() { }

	// RVA: 0x2465770 Offset: 0x2464170 VA: 0x182465770
	internal void GetUnspecifiedDefaultAttributes(ArrayList defaultAttributes, bool createNodeData) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal XmlSchemaSet get_SchemaSet() { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	internal XmlSchemaValidationFlags get_ValidationFlags() { }

	// RVA: 0x246C9F0 Offset: 0x246B3F0 VA: 0x18246C9F0
	internal XmlSchemaContentType get_CurrentContentType() { }

	// RVA: 0x2469690 Offset: 0x2468090 VA: 0x182469690
	internal void SetDtdSchemaInfo(IDtdInfo dtdSchemaInfo) { }

	// RVA: 0x246CAE0 Offset: 0x246B4E0 VA: 0x18246CAE0
	private bool get_StrictlyAssessed() { }

	// RVA: 0x246CA50 Offset: 0x246B450 VA: 0x18246CA50
	private bool get_HasSchema() { }

	// RVA: 0x2465080 Offset: 0x2463A80 VA: 0x182465080
	internal string GetConcatenatedValue() { }

	// RVA: 0x2466750 Offset: 0x2465150 VA: 0x182466750
	private object InternalValidateEndElement(XmlSchemaInfo schemaInfo, object typedValue) { }

	// RVA: 0x24681E0 Offset: 0x2466BE0 VA: 0x1824681E0
	private void ProcessSchemaLocations(string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	// RVA: 0x246AD90 Offset: 0x2469790 VA: 0x18246AD90
	private object ValidateElementContext(XmlQualifiedName elementName, out bool invalidElementInContext) { }

	// RVA: 0x24654C0 Offset: 0x2463EC0 VA: 0x1824654C0
	private XmlSchemaElement GetSubstitutionGroupHead(XmlQualifiedName member) { }

	// RVA: 0x2469F60 Offset: 0x2468960 VA: 0x182469F60
	private object ValidateAtomicValue(string stringValue, out XmlSchemaSimpleType memberType) { }

	// RVA: 0x2469B30 Offset: 0x2468530 VA: 0x182469B30
	private object ValidateAtomicValue(object parsedValue, out XmlSchemaSimpleType memberType) { }

	// RVA: 0x2465700 Offset: 0x2464100 VA: 0x182465700
	private string GetTypeName(SchemaDeclBase decl) { }

	// RVA: 0x2468BC0 Offset: 0x24675C0 VA: 0x182468BC0
	private void SaveTextValue(object value) { }

	// RVA: 0x2468810 Offset: 0x2467210 VA: 0x182468810
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x2467220 Offset: 0x2465C20 VA: 0x182467220
	private void Pop() { }

	// RVA: 0x2464D20 Offset: 0x2463720 VA: 0x182464D20
	private SchemaElementDecl FastGetElementDecl(XmlQualifiedName elementName, object particle) { }

	// RVA: 0x2462100 Offset: 0x2460B00 VA: 0x182462100
	private SchemaElementDecl CheckXsiTypeAndNil(SchemaElementDecl elementDecl, string xsiType, string xsiNil, ref bool declFound) { }

	// RVA: 0x24698F0 Offset: 0x24682F0 VA: 0x1824698F0
	private void ThrowDeclNotFoundWarningOrError(bool declFound) { }

	// RVA: 0x2461320 Offset: 0x245FD20 VA: 0x182461320
	private void CheckElementProperties() { }

	// RVA: 0x246B900 Offset: 0x246A300 VA: 0x18246B900
	private void ValidateStartElementIdentityConstraints() { }

	// RVA: 0x2461860 Offset: 0x2460260 VA: 0x182461860
	private SchemaAttDef CheckIsXmlAttribute(XmlQualifiedName attQName) { }

	// RVA: 0x2460A30 Offset: 0x245F430 VA: 0x182460A30
	private void AddXmlNamespaceSchema() { }

	// RVA: 0x24619F0 Offset: 0x24603F0 VA: 0x1824619F0
	internal object CheckMixedValueConstraint(string elementValue) { }

	// RVA: 0x2466DC0 Offset: 0x24657C0 VA: 0x182466DC0
	private void LoadSchema(string uri, string url) { }

	// RVA: 0x2468A90 Offset: 0x2467490 VA: 0x182468A90
	internal void RecompileSchemaSet() { }

	// RVA: 0x24684E0 Offset: 0x2466EE0 VA: 0x1824684E0
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name, bool attrValue) { }

	// RVA: 0x2461060 Offset: 0x245FA60 VA: 0x182461060
	private object CheckAttributeValue(object value, SchemaAttDef attdef) { }

	// RVA: 0x2461410 Offset: 0x245FE10 VA: 0x182461410
	private object CheckElementValue(string stringValue) { }

	// RVA: 0x2461F60 Offset: 0x2460960 VA: 0x182461F60
	private void CheckTokenizedTypes(XmlSchemaDatatype dtype, object typedValue, bool attrValue) { }

	// RVA: 0x2465050 Offset: 0x2463A50 VA: 0x182465050
	private object FindId(string name) { }

	// RVA: 0x2461730 Offset: 0x2460130 VA: 0x182461730
	private void CheckForwardRefs() { }

	// RVA: 0x246CA30 Offset: 0x246B430 VA: 0x18246CA30
	private bool get_HasIdentityConstraints() { }

	// RVA: 0x246CAA0 Offset: 0x246B4A0 VA: 0x18246CAA0
	internal bool get_ProcessIdentityConstraints() { }

	// RVA: 0x246CAD0 Offset: 0x246B4D0 VA: 0x18246CAD0
	internal bool get_ReportValidationWarnings() { }

	// RVA: 0x246CAB0 Offset: 0x246B4B0 VA: 0x18246CAB0
	internal bool get_ProcessSchemaHints() { }

	// RVA: 0x2461CD0 Offset: 0x24606D0 VA: 0x182461CD0
	private void CheckStateTransition(ValidatorState toState, string methodName) { }

	// RVA: 0x2462820 Offset: 0x2461220 VA: 0x182462820
	private void ClearPSVI() { }

	// RVA: 0x2461B00 Offset: 0x2460500 VA: 0x182461B00
	private void CheckRequiredAttributes(SchemaElementDecl currentElementDecl) { }

	// RVA: 0x2465350 Offset: 0x2463D50 VA: 0x182465350
	private XmlSchemaElement GetSchemaElement() { }

	// RVA: 0x24650B0 Offset: 0x2463AB0 VA: 0x1824650B0
	internal string GetDefaultAttributePrefix(string attributeNS) { }

	// RVA: 0x2460070 Offset: 0x245EA70 VA: 0x182460070
	private void AddIdentityConstraints() { }

	// RVA: 0x2462EE0 Offset: 0x24618E0 VA: 0x182462EE0
	private void ElementIdentityConstraints() { }

	// RVA: 0x2460B10 Offset: 0x245F510 VA: 0x182460B10
	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, XmlSchemaDatatype datatype) { }

	// RVA: 0x2463CA0 Offset: 0x24626A0 VA: 0x182463CA0
	private void EndElementIdentityConstraints(object typedValue, string stringValue, XmlSchemaDatatype datatype) { }

	// RVA: 0x2463280 Offset: 0x2461C80 VA: 0x182463280
	internal static void ElementValidationError(XmlQualifiedName name, ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	// RVA: 0x2462880 Offset: 0x2461280 VA: 0x182462880
	internal static void CompleteValidationError(ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	// RVA: 0x2467390 Offset: 0x2465D90 VA: 0x182467390
	internal static string PrintExpectedElements(ArrayList expected, bool getParticles) { }

	// RVA: 0x2467F20 Offset: 0x2466920 VA: 0x182467F20
	private static string PrintNames(ArrayList expected) { }

	// RVA: 0x2467910 Offset: 0x2466310 VA: 0x182467910
	private static void PrintNamesWithNS(ArrayList expected, StringBuilder builder) { }

	// RVA: 0x2464AE0 Offset: 0x24634E0 VA: 0x182464AE0
	private static void EnumerateAny(StringBuilder builder, string namespaces) { }

	// RVA: 0x2468A20 Offset: 0x2467420 VA: 0x182468A20
	internal static string QNameString(string localName, string ns) { }

	// RVA: 0x2460FF0 Offset: 0x245F9F0 VA: 0x182460FF0
	internal static string BuildElementName(XmlQualifiedName qname) { }

	// RVA: 0x2460E60 Offset: 0x245F860 VA: 0x182460E60
	internal static string BuildElementName(string localName, string ns) { }

	// RVA: 0x24680B0 Offset: 0x2466AB0 VA: 0x1824680B0
	private void ProcessEntity(string name) { }

	// RVA: 0x24690B0 Offset: 0x2467AB0 VA: 0x1824690B0
	private void SendValidationEvent(string code) { }

	// RVA: 0x2469210 Offset: 0x2467C10 VA: 0x182469210
	private void SendValidationEvent(string code, string[] args) { }

	// RVA: 0x2469110 Offset: 0x2467B10 VA: 0x182469110
	private void SendValidationEvent(string code, string arg) { }

	// RVA: 0x2468D40 Offset: 0x2467740 VA: 0x182468D40
	private void SendValidationEvent(string code, string arg1, string arg2) { }

	// RVA: 0x2469420 Offset: 0x2467E20 VA: 0x182469420
	private void SendValidationEvent(string code, string[] args, Exception innerException, XmlSeverityType severity) { }

	// RVA: 0x2468C20 Offset: 0x2467620 VA: 0x182468C20
	private void SendValidationEvent(string code, string[] args, Exception innerException) { }

	// RVA: 0x2468C10 Offset: 0x2467610 VA: 0x182468C10
	private void SendValidationEvent(XmlSchemaValidationException e) { }

	// RVA: 0x2469330 Offset: 0x2467D30 VA: 0x182469330
	private void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x2469570 Offset: 0x2467F70 VA: 0x182469570
	private void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	// RVA: 0x2468EB0 Offset: 0x24678B0 VA: 0x182468EB0
	private void SendValidationEvent(XmlSchemaValidationException e, XmlSeverityType severity) { }

	// RVA: 0x2468FF0 Offset: 0x24679F0 VA: 0x182468FF0
	internal static void SendValidationEvent(ValidationEventHandler eventHandler, object sender, XmlSchemaValidationException e, XmlSeverityType severity) { }

	// RVA: 0x246C110 Offset: 0x246AB10 VA: 0x18246C110
	private static void .cctor() { }
}
