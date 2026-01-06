internal sealed class XsdValidator : BaseValidator // TypeDefIndex: 8529
{
	// Fields
	private int startIDConstraint; // 0x80
	private HWStack validationStack; // 0x88
	private Hashtable attPresence; // 0x90
	private XmlNamespaceManager nsManager; // 0x98
	private bool bManageNamespaces; // 0xA0
	private Hashtable IDs; // 0xA8
	private IdRefNode idRefListHead; // 0xB0
	private Parser inlineSchemaParser; // 0xB8
	private XmlSchemaContentProcessing processContents; // 0xC0
	private static readonly XmlSchemaDatatype dtCDATA; // 0x0
	private static readonly XmlSchemaDatatype dtQName; // 0x8
	private static readonly XmlSchemaDatatype dtStringArray; // 0x10
	private string NsXmlNs; // 0xC8
	private string NsXs; // 0xD0
	private string NsXsi; // 0xD8
	private string XsiType; // 0xE0
	private string XsiNil; // 0xE8
	private string XsiSchemaLocation; // 0xF0
	private string XsiNoNamespaceSchemaLocation; // 0xF8
	private string XsdSchema; // 0x100

	// Properties
	private bool IsInlineSchemaStarted { get; }
	private bool HasSchema { get; }
	public override bool PreserveWhitespace { get; }
	private bool HasIdentityConstraints { get; }

	// Methods

	// RVA: 0x24AFEA0 Offset: 0x24AE8A0 VA: 0x1824AFEA0
	internal void .ctor(BaseValidator validator) { }

	// RVA: 0x24AFE70 Offset: 0x24AE870 VA: 0x1824AFE70
	internal void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x24AC1A0 Offset: 0x24AABA0 VA: 0x1824AC1A0
	private void Init() { }

	// RVA: 0x24AFCA0 Offset: 0x24AE6A0 VA: 0x1824AFCA0 Slot: 5
	public override void Validate() { }

	// RVA: 0x24AA9D0 Offset: 0x24A93D0 VA: 0x1824AA9D0 Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x2443310 Offset: 0x2441D10 VA: 0x182443310
	private bool get_IsInlineSchemaStarted() { }

	// RVA: 0x24AD5E0 Offset: 0x24ABFE0 VA: 0x1824AD5E0
	private void ProcessInlineSchema() { }

	// RVA: 0x24AEBB0 Offset: 0x24AD5B0 VA: 0x1824AEBB0
	private void ValidateElement() { }

	// RVA: 0x24AE940 Offset: 0x24AD340 VA: 0x1824AE940
	private object ValidateChildElement() { }

	// RVA: 0x24ACE50 Offset: 0x24AB850 VA: 0x1824ACE50
	private void ProcessElement(object particle) { }

	// RVA: 0x24ADB00 Offset: 0x24AC500 VA: 0x1824ADB00
	private void ProcessXsiAttributes(out XmlQualifiedName xsiType, out string xsiNil) { }

	// RVA: 0x24AED90 Offset: 0x24AD790 VA: 0x1824AED90
	private void ValidateEndElement() { }

	// RVA: 0x24AC0C0 Offset: 0x24AAAC0 VA: 0x1824AC0C0
	private SchemaElementDecl FastGetElementDecl(object particle) { }

	// RVA: 0x24AE4A0 Offset: 0x24ACEA0 VA: 0x1824AE4A0
	private SchemaElementDecl ThoroughGetElementDecl(SchemaElementDecl elementDecl, XmlQualifiedName xsiType, string xsiNil) { }

	// RVA: 0x24AF580 Offset: 0x24ADF80 VA: 0x1824AF580
	private void ValidateStartElement() { }

	// RVA: 0x24AF0E0 Offset: 0x24ADAE0 VA: 0x1824AF0E0
	private void ValidateEndStartElement() { }

	// RVA: 0x24AC630 Offset: 0x24AB030 VA: 0x1824AC630
	private void LoadSchemaFromLocation(string uri, string url) { }

	// RVA: 0x24ACB80 Offset: 0x24AB580 VA: 0x1824ACB80
	private void LoadSchema(string uri, string url) { }

	// RVA: 0x24432F0 Offset: 0x2441CF0 VA: 0x1824432F0
	private bool get_HasSchema() { }

	// RVA: 0x2443320 Offset: 0x2441D20 VA: 0x182443320 Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x24AD850 Offset: 0x24AC250 VA: 0x1824AD850
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x24AAB20 Offset: 0x24A9520 VA: 0x1824AAB20
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x24A9FE0 Offset: 0x24A89E0 VA: 0x1824A9FE0
	internal void AddID(string name, object node) { }

	// RVA: 0x24407D0 Offset: 0x243F1D0 VA: 0x1824407D0 Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x24AC5E0 Offset: 0x24AAFE0 VA: 0x1824AC5E0
	public bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x24AE300 Offset: 0x24ACD00 VA: 0x1824AE300
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x24ACD50 Offset: 0x24AB750 VA: 0x1824ACD50
	private void Pop() { }

	// RVA: 0x24AA9D0 Offset: 0x24A93D0 VA: 0x1824AA9D0
	private void CheckForwardRefs() { }

	// RVA: 0x24AF520 Offset: 0x24ADF20 VA: 0x1824AF520
	private void ValidateStartElementIdentityConstraints() { }

	// RVA: 0x24AFED0 Offset: 0x24AE8D0 VA: 0x1824AFED0
	private bool get_HasIdentityConstraints() { }

	// RVA: 0x24AA0A0 Offset: 0x24A8AA0 VA: 0x1824AA0A0
	private void AddIdentityConstraints() { }

	// RVA: 0x24AAF60 Offset: 0x24A9960 VA: 0x1824AAF60
	private void ElementIdentityConstraints() { }

	// RVA: 0x24AA640 Offset: 0x24A9040 VA: 0x1824AA640
	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, SchemaAttDef attdef) { }

	// RVA: 0x24AE8D0 Offset: 0x24AD2D0 VA: 0x1824AE8D0
	private object UnWrapUnion(object typedValue) { }

	// RVA: 0x24AB380 Offset: 0x24A9D80 VA: 0x1824AB380
	private void EndElementIdentityConstraints() { }

	// RVA: 0x24AFD80 Offset: 0x24AE780 VA: 0x1824AFD80
	private static void .cctor() { }
}
