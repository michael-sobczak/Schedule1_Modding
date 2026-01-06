internal class BaseProcessor // TypeDefIndex: 8240
{
	// Fields
	private XmlNameTable nameTable; // 0x10
	private SchemaNames schemaNames; // 0x18
	private ValidationEventHandler eventHandler; // 0x20
	private XmlSchemaCompilationSettings compilationSettings; // 0x28
	private int errorCount; // 0x30
	private string NsXml; // 0x38

	// Properties
	protected XmlNameTable NameTable { get; }
	protected SchemaNames SchemaNames { get; }
	protected ValidationEventHandler EventHandler { get; }
	protected XmlSchemaCompilationSettings CompilationSettings { get; }
	protected bool HasErrors { get; }

	// Methods

	// RVA: 0x255DF60 Offset: 0x255C960 VA: 0x18255DF60
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0x255E080 Offset: 0x255CA80 VA: 0x18255E080
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	protected XmlNameTable get_NameTable() { }

	// RVA: 0x255E160 Offset: 0x255CB60 VA: 0x18255E160
	protected SchemaNames get_SchemaNames() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	protected ValidationEventHandler get_EventHandler() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	protected XmlSchemaCompilationSettings get_CompilationSettings() { }

	// RVA: 0x8FDF70 Offset: 0x8FC970 VA: 0x1808FDF70
	protected bool get_HasErrors() { }

	// RVA: 0x255CB80 Offset: 0x255B580 VA: 0x18255CB80
	protected void AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	// RVA: 0x255D240 Offset: 0x255BC40 VA: 0x18255D240
	private bool IsValidAttributeGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x255D370 Offset: 0x255BD70 VA: 0x18255D370
	private bool IsValidGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x255D4A0 Offset: 0x255BEA0 VA: 0x18255D4A0
	private bool IsValidTypeRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x255DC50 Offset: 0x255C650 VA: 0x18255DC50
	protected void SendValidationEvent(string code, XmlSchemaObject source) { }

	// RVA: 0x255D860 Offset: 0x255C260 VA: 0x18255D860
	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source) { }

	// RVA: 0x255DD40 Offset: 0x255C740 VA: 0x18255DD40
	protected void SendValidationEvent(string code, string msg1, string msg2, XmlSchemaObject source) { }

	// RVA: 0x255DAF0 Offset: 0x255C4F0 VA: 0x18255DAF0
	protected void SendValidationEvent(string code, string[] args, Exception innerException, XmlSchemaObject source) { }

	// RVA: 0x255D970 Offset: 0x255C370 VA: 0x18255D970
	protected void SendValidationEvent(string code, string msg1, string msg2, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x255D730 Offset: 0x255C130 VA: 0x18255D730
	protected void SendValidationEvent(string code, XmlSchemaObject source, XmlSeverityType severity) { }

	// RVA: 0x255DEB0 Offset: 0x255C8B0 VA: 0x18255DEB0
	protected void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x255D7C0 Offset: 0x255C1C0 VA: 0x18255D7C0
	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source, XmlSeverityType severity) { }

	// RVA: 0x255D670 Offset: 0x255C070 VA: 0x18255D670
	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x255D5D0 Offset: 0x255BFD0 VA: 0x18255D5D0
	protected void SendValidationEventNoThrow(XmlSchemaException e, XmlSeverityType severity) { }
}
