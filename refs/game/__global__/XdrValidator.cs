internal sealed class XdrValidator : BaseValidator // TypeDefIndex: 8403
{
	// Fields
	private HWStack validationStack; // 0x80
	private Hashtable attPresence; // 0x88
	private XmlQualifiedName name; // 0x90
	private XmlNamespaceManager nsManager; // 0x98
	private bool isProcessContents; // 0xA0
	private Hashtable IDs; // 0xA8
	private IdRefNode idRefListHead; // 0xB0
	private Parser inlineSchemaParser; // 0xB8

	// Properties
	private bool IsInlineSchemaStarted { get; }
	private bool HasSchema { get; }
	public override bool PreserveWhitespace { get; }

	// Methods

	// RVA: 0x2443260 Offset: 0x2441C60 VA: 0x182443260
	internal void .ctor(BaseValidator validator) { }

	// RVA: 0x24431A0 Offset: 0x2441BA0 VA: 0x1824431A0
	internal void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x2440800 Offset: 0x243F200 VA: 0x182440800
	private void Init() { }

	// RVA: 0x24430C0 Offset: 0x2441AC0 VA: 0x1824430C0 Slot: 5
	public override void Validate() { }

	// RVA: 0x24421A0 Offset: 0x2440BA0 VA: 0x1824421A0
	private void ValidateElement() { }

	// RVA: 0x2441FD0 Offset: 0x24409D0 VA: 0x182441FD0
	private void ValidateChildElement() { }

	// RVA: 0x2443310 Offset: 0x2441D10 VA: 0x182443310
	private bool get_IsInlineSchemaStarted() { }

	// RVA: 0x2441470 Offset: 0x243FE70 VA: 0x182441470
	private void ProcessInlineSchema() { }

	// RVA: 0x2441380 Offset: 0x243FD80 VA: 0x182441380
	private void ProcessElement() { }

	// RVA: 0x24425E0 Offset: 0x2440FE0 VA: 0x1824425E0
	private void ValidateEndElement() { }

	// RVA: 0x2441BB0 Offset: 0x24405B0 VA: 0x182441BB0
	private SchemaElementDecl ThoroughGetElementDecl() { }

	// RVA: 0x2442C30 Offset: 0x2441630 VA: 0x182442C30
	private void ValidateStartElement() { }

	// RVA: 0x24428D0 Offset: 0x24412D0 VA: 0x1824428D0
	private void ValidateEndStartElement() { }

	// RVA: 0x2440A20 Offset: 0x243F420 VA: 0x182440A20
	private void LoadSchemaFromLocation(string uri) { }

	// RVA: 0x2441080 Offset: 0x243FA80 VA: 0x182441080
	private void LoadSchema(string uri) { }

	// RVA: 0x24432F0 Offset: 0x2441CF0 VA: 0x1824432F0
	private bool get_HasSchema() { }

	// RVA: 0x2443320 Offset: 0x2441D20 VA: 0x182443320 Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x24416B0 Offset: 0x24400B0 VA: 0x1824416B0
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x2440550 Offset: 0x243EF50 VA: 0x182440550 Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x2440000 Offset: 0x243EA00 VA: 0x182440000
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x243FA20 Offset: 0x243E420 VA: 0x18243FA20
	public static void CheckDefaultValue(string value, SchemaAttDef attdef, SchemaInfo sinfo, XmlNamespaceManager nsManager, XmlNameTable NameTable, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNo, int linePos) { }

	// RVA: 0x243F960 Offset: 0x243E360 VA: 0x18243F960
	internal void AddID(string name, object node) { }

	// RVA: 0x24407D0 Offset: 0x243F1D0 VA: 0x1824407D0 Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x2441960 Offset: 0x2440360 VA: 0x182441960
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x24412B0 Offset: 0x243FCB0 VA: 0x1824412B0
	private void Pop() { }

	// RVA: 0x243FEB0 Offset: 0x243E8B0 VA: 0x18243FEB0
	private void CheckForwardRefs() { }

	// RVA: 0x2441B10 Offset: 0x2440510 VA: 0x182441B10
	private XmlQualifiedName QualifiedName(string name, string ns) { }
}
