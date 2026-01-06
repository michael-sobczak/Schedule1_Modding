public class XmlSchemaSet // TypeDefIndex: 8478
{
	// Fields
	private XmlNameTable nameTable; // 0x10
	private SchemaNames schemaNames; // 0x18
	private SortedList schemas; // 0x20
	private ValidationEventHandler internalEventHandler; // 0x28
	private ValidationEventHandler eventHandler; // 0x30
	private bool isCompiled; // 0x38
	private Hashtable schemaLocations; // 0x40
	private Hashtable chameleonSchemas; // 0x48
	private Hashtable targetNamespaces; // 0x50
	private bool compileAll; // 0x58
	private SchemaInfo cachedCompiledInfo; // 0x60
	private XmlReaderSettings readerSettings; // 0x68
	private XmlSchema schemaForSchema; // 0x70
	private XmlSchemaCompilationSettings compilationSettings; // 0x78
	internal XmlSchemaObjectTable elements; // 0x80
	internal XmlSchemaObjectTable attributes; // 0x88
	internal XmlSchemaObjectTable schemaTypes; // 0x90
	internal XmlSchemaObjectTable substitutionGroups; // 0x98
	private XmlSchemaObjectTable typeExtensions; // 0xA0
	private object internalSyncObject; // 0xA8

	// Properties
	internal object InternalSyncObject { get; }
	public bool IsCompiled { get; }
	public XmlResolver XmlResolver { set; }
	public XmlSchemaCompilationSettings CompilationSettings { get; set; }
	public int Count { get; }
	public XmlSchemaObjectTable GlobalElements { get; }
	public XmlSchemaObjectTable GlobalAttributes { get; }
	public XmlSchemaObjectTable GlobalTypes { get; }
	internal XmlSchemaObjectTable SubstitutionGroups { get; }
	internal Hashtable SchemaLocations { get; }
	internal XmlSchemaObjectTable TypeExtensions { get; }
	internal SchemaInfo CompiledInfo { get; }
	internal XmlReaderSettings ReaderSettings { get; }
	internal SortedList SortedSchemas { get; }

	// Methods

	// RVA: 0x245E7E0 Offset: 0x245D1E0 VA: 0x18245E7E0
	internal object get_InternalSyncObject() { }

	// RVA: 0x245E190 Offset: 0x245CB90 VA: 0x18245E190
	public void .ctor() { }

	// RVA: 0x245E1F0 Offset: 0x245CBF0 VA: 0x18245E1F0
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x245E4F0 Offset: 0x245CEF0 VA: 0x18245E4F0
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x245E960 Offset: 0x245D360 VA: 0x18245E960
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x8D2170 Offset: 0x8D0B70 VA: 0x1808D2170
	public bool get_IsCompiled() { }

	// RVA: 0x245EA20 Offset: 0x245D420 VA: 0x18245EA20
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public XmlSchemaCompilationSettings get_CompilationSettings() { }

	// RVA: 0x5F4EC0 Offset: 0x5F38C0 VA: 0x1805F4EC0
	public void set_CompilationSettings(XmlSchemaCompilationSettings value) { }

	// RVA: 0x245E630 Offset: 0x245D030 VA: 0x18245E630
	public int get_Count() { }

	// RVA: 0x245E6E0 Offset: 0x245D0E0 VA: 0x18245E6E0
	public XmlSchemaObjectTable get_GlobalElements() { }

	// RVA: 0x245E660 Offset: 0x245D060 VA: 0x18245E660
	public XmlSchemaObjectTable get_GlobalAttributes() { }

	// RVA: 0x245E760 Offset: 0x245D160 VA: 0x18245E760
	public XmlSchemaObjectTable get_GlobalTypes() { }

	// RVA: 0x245E860 Offset: 0x245D260 VA: 0x18245E860
	internal XmlSchemaObjectTable get_SubstitutionGroups() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	internal Hashtable get_SchemaLocations() { }

	// RVA: 0x245E8E0 Offset: 0x245D2E0 VA: 0x18245E8E0
	internal XmlSchemaObjectTable get_TypeExtensions() { }

	// RVA: 0x2457450 Offset: 0x2455E50 VA: 0x182457450
	public void Add(XmlSchemaSet schemas) { }

	// RVA: 0x2458030 Offset: 0x2456A30 VA: 0x182458030
	public XmlSchema Add(XmlSchema schema) { }

	// RVA: 0x245B770 Offset: 0x245A170 VA: 0x18245B770
	public bool RemoveRecursive(XmlSchema schemaToRemove) { }

	// RVA: 0x2458920 Offset: 0x2457320 VA: 0x182458920
	public bool Contains(string targetNamespace) { }

	// RVA: 0x2458310 Offset: 0x2456D10 VA: 0x182458310
	public void Compile() { }

	// RVA: 0x245D200 Offset: 0x245BC00 VA: 0x18245D200
	public XmlSchema Reprocess(XmlSchema schema) { }

	// RVA: 0x2459D90 Offset: 0x2458790 VA: 0x182459D90
	public void CopyTo(XmlSchema[] schemas, int index) { }

	// RVA: 0x245DF80 Offset: 0x245C980 VA: 0x18245DF80
	public ICollection Schemas() { }

	// RVA: 0x245DDC0 Offset: 0x245C7C0 VA: 0x18245DDC0
	public ICollection Schemas(string targetNamespace) { }

	// RVA: 0x24573F0 Offset: 0x2455DF0 VA: 0x1824573F0
	private XmlSchema Add(string targetNamespace, XmlSchema schema) { }

	// RVA: 0x2457B90 Offset: 0x2456590 VA: 0x182457B90
	internal void Add(string targetNamespace, XmlReader reader, Hashtable validatedNamespaces) { }

	// RVA: 0x2459F30 Offset: 0x2458930 VA: 0x182459F30
	internal XmlSchema FindSchemaByNSAndUrl(Uri schemaUri, string ns, DictionaryEntry[] locationsTable) { }

	// RVA: 0x2456BF0 Offset: 0x24555F0 VA: 0x182456BF0
	private void AddSchemaToSet(XmlSchema schema) { }

	// RVA: 0x245B410 Offset: 0x2459E10 VA: 0x18245B410
	private void ProcessNewSubstitutionGroups(XmlSchemaObjectTable substitutionGroupsTable, bool resolve) { }

	// RVA: 0x245D9D0 Offset: 0x245C3D0 VA: 0x18245D9D0
	private void ResolveSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup, XmlSchemaObjectTable substTable) { }

	// RVA: 0x245CEF0 Offset: 0x245B8F0 VA: 0x18245CEF0
	internal XmlSchema Remove(XmlSchema schema, bool forceCompile) { }

	// RVA: 0x2458210 Offset: 0x2456C10 VA: 0x182458210
	private void ClearTables() { }

	// RVA: 0x245B2B0 Offset: 0x2459CB0 VA: 0x18245B2B0
	internal bool PreprocessSchema(ref XmlSchema schema, string targetNamespace) { }

	// RVA: 0x245B180 Offset: 0x2459B80 VA: 0x18245B180
	internal XmlSchema ParseSchema(string targetNamespace, XmlReader reader) { }

	// RVA: 0x24589A0 Offset: 0x24573A0 VA: 0x1824589A0
	internal void CopyFromCompiledSet(XmlSchemaSet otherSet) { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	internal SchemaInfo get_CompiledInfo() { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	internal XmlReaderSettings get_ReaderSettings() { }

	// RVA: 0x245A210 Offset: 0x2458C10 VA: 0x18245A210
	internal XmlResolver GetResolver() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	internal ValidationEventHandler GetEventHandler() { }

	// RVA: 0x245A3B0 Offset: 0x2458DB0 VA: 0x18245A3B0
	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	// RVA: 0x245A520 Offset: 0x2458F20 VA: 0x18245A520
	internal bool IsSchemaLoaded(Uri schemaUri, string targetNamespace, out XmlSchema schema) { }

	// RVA: 0x245A230 Offset: 0x2458C30 VA: 0x18245A230
	internal bool GetSchemaByUri(Uri schemaUri, out XmlSchema schema) { }

	// RVA: 0x245A470 Offset: 0x2458E70 VA: 0x18245A470
	internal string GetTargetNamespace(XmlSchema schema) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	internal SortedList get_SortedSchemas() { }

	// RVA: 0x245BFF0 Offset: 0x245A9F0 VA: 0x18245BFF0
	private void RemoveSchemaFromCaches(XmlSchema schema) { }

	// RVA: 0x245C490 Offset: 0x245AE90 VA: 0x18245C490
	private void RemoveSchemaFromGlobalTables(XmlSchema schema) { }

	// RVA: 0x2457020 Offset: 0x2455A20 VA: 0x182457020
	private bool AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	// RVA: 0x245E070 Offset: 0x245CA70 VA: 0x18245E070
	private void VerifyTables() { }

	// RVA: 0x245A4D0 Offset: 0x2458ED0 VA: 0x18245A4D0
	private void InternalValidationCallback(object sender, ValidationEventArgs e) { }

	// RVA: 0x245DFB0 Offset: 0x245C9B0 VA: 0x18245DFB0
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }
}
