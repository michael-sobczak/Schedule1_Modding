public sealed class XmlReaderSettings // TypeDefIndex: 7965
{
	// Fields
	private bool useAsync; // 0x10
	private XmlNameTable nameTable; // 0x18
	private XmlResolver xmlResolver; // 0x20
	private int lineNumberOffset; // 0x28
	private int linePositionOffset; // 0x2C
	private ConformanceLevel conformanceLevel; // 0x30
	private bool checkCharacters; // 0x34
	private long maxCharactersInDocument; // 0x38
	private long maxCharactersFromEntities; // 0x40
	private bool ignoreWhitespace; // 0x48
	private bool ignorePIs; // 0x49
	private bool ignoreComments; // 0x4A
	private DtdProcessing dtdProcessing; // 0x4C
	private ValidationType validationType; // 0x50
	private XmlSchemaValidationFlags validationFlags; // 0x54
	private XmlSchemaSet schemas; // 0x58
	private ValidationEventHandler valEventHandler; // 0x60
	private bool closeInput; // 0x68
	private bool isReadOnly; // 0x69
	[CompilerGenerated]
	private bool <IsXmlResolverSet>k__BackingField; // 0x6A
	private static Nullable<bool> s_enableLegacyXmlSettings; // 0x0

	// Properties
	public bool Async { get; set; }
	public XmlNameTable NameTable { get; set; }
	internal bool IsXmlResolverSet { get; set; }
	public XmlResolver XmlResolver { set; }
	public int LineNumberOffset { get; set; }
	public int LinePositionOffset { get; set; }
	public ConformanceLevel ConformanceLevel { get; set; }
	public bool CheckCharacters { get; set; }
	public long MaxCharactersInDocument { get; set; }
	public long MaxCharactersFromEntities { get; set; }
	public bool IgnoreWhitespace { get; set; }
	public bool IgnoreProcessingInstructions { get; set; }
	public bool IgnoreComments { get; set; }
	public DtdProcessing DtdProcessing { get; set; }
	public bool CloseInput { get; set; }
	public ValidationType ValidationType { get; set; }
	public XmlSchemaValidationFlags ValidationFlags { get; set; }
	public XmlSchemaSet Schemas { get; set; }
	internal bool ReadOnly { set; }

	// Methods

	// RVA: 0x24CF5D0 Offset: 0x24CDFD0 VA: 0x1824CF5D0
	public void .ctor() { }

	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	public bool get_Async() { }

	// RVA: 0x24CF740 Offset: 0x24CE140 VA: 0x1824CF740
	public void set_Async(bool value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public XmlNameTable get_NameTable() { }

	// RVA: 0x24CFC40 Offset: 0x24CE640 VA: 0x1824CFC40
	public void set_NameTable(XmlNameTable value) { }

	[CompilerGenerated]
	// RVA: 0xCE3DD0 Offset: 0xCE27D0 VA: 0x180CE3DD0
	internal bool get_IsXmlResolverSet() { }

	[CompilerGenerated]
	// RVA: 0xCE3E30 Offset: 0xCE2830 VA: 0x180CE3E30
	internal void set_IsXmlResolverSet(bool value) { }

	// RVA: 0x24CFE40 Offset: 0x24CE840 VA: 0x1824CFE40
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	internal XmlResolver GetXmlResolver() { }

	// RVA: 0x24CF3C0 Offset: 0x24CDDC0 VA: 0x1824CF3C0
	internal XmlResolver GetXmlResolver_CheckConfig() { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public int get_LineNumberOffset() { }

	// RVA: 0x24CFA60 Offset: 0x24CE460 VA: 0x1824CFA60
	public void set_LineNumberOffset(int value) { }

	// RVA: 0x65E590 Offset: 0x65CF90 VA: 0x18065E590
	public int get_LinePositionOffset() { }

	// RVA: 0x24CFAB0 Offset: 0x24CE4B0 VA: 0x1824CFAB0
	public void set_LinePositionOffset(int value) { }

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	public ConformanceLevel get_ConformanceLevel() { }

	// RVA: 0x24CF830 Offset: 0x24CE230 VA: 0x1824CF830
	public void set_ConformanceLevel(ConformanceLevel value) { }

	// RVA: 0x66AFB0 Offset: 0x6699B0 VA: 0x18066AFB0
	public bool get_CheckCharacters() { }

	// RVA: 0x24CF790 Offset: 0x24CE190 VA: 0x1824CF790
	public void set_CheckCharacters(bool value) { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public long get_MaxCharactersInDocument() { }

	// RVA: 0x24CFBA0 Offset: 0x24CE5A0 VA: 0x1824CFBA0
	public void set_MaxCharactersInDocument(long value) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public long get_MaxCharactersFromEntities() { }

	// RVA: 0x24CFB00 Offset: 0x24CE500 VA: 0x1824CFB00
	public void set_MaxCharactersFromEntities(long value) { }

	// RVA: 0x4D60D0 Offset: 0x4D4AD0 VA: 0x1804D60D0
	public bool get_IgnoreWhitespace() { }

	// RVA: 0x24CFA10 Offset: 0x24CE410 VA: 0x1824CFA10
	public void set_IgnoreWhitespace(bool value) { }

	// RVA: 0x4D6190 Offset: 0x4D4B90 VA: 0x1804D6190
	public bool get_IgnoreProcessingInstructions() { }

	// RVA: 0x24CF9C0 Offset: 0x24CE3C0 VA: 0x1824CF9C0
	public void set_IgnoreProcessingInstructions(bool value) { }

	// RVA: 0x24CF6C0 Offset: 0x24CE0C0 VA: 0x1824CF6C0
	public bool get_IgnoreComments() { }

	// RVA: 0x24CF970 Offset: 0x24CE370 VA: 0x1824CF970
	public void set_IgnoreComments(bool value) { }

	// RVA: 0x4D60C0 Offset: 0x4D4AC0 VA: 0x1804D60C0
	public DtdProcessing get_DtdProcessing() { }

	// RVA: 0x24CF8D0 Offset: 0x24CE2D0 VA: 0x1824CF8D0
	public void set_DtdProcessing(DtdProcessing value) { }

	// RVA: 0xCE3DC0 Offset: 0xCE27C0 VA: 0x180CE3DC0
	public bool get_CloseInput() { }

	// RVA: 0x24CF7E0 Offset: 0x24CE1E0 VA: 0x1824CF7E0
	public void set_CloseInput(bool value) { }

	// RVA: 0x4B61B0 Offset: 0x4B4BB0 VA: 0x1804B61B0
	public ValidationType get_ValidationType() { }

	// RVA: 0x24CFDA0 Offset: 0x24CE7A0 VA: 0x1824CFDA0
	public void set_ValidationType(ValidationType value) { }

	// RVA: 0x4C3B40 Offset: 0x4C2540 VA: 0x1804C3B40
	public XmlSchemaValidationFlags get_ValidationFlags() { }

	// RVA: 0x24CFD00 Offset: 0x24CE700 VA: 0x1824CFD00
	public void set_ValidationFlags(XmlSchemaValidationFlags value) { }

	// RVA: 0x24CF6D0 Offset: 0x24CE0D0 VA: 0x1824CF6D0
	public XmlSchemaSet get_Schemas() { }

	// RVA: 0x24CFCA0 Offset: 0x24CE6A0 VA: 0x1824CFCA0
	public void set_Schemas(XmlSchemaSet value) { }

	// RVA: 0x24CEED0 Offset: 0x24CD8D0 VA: 0x1824CEED0
	public XmlReaderSettings Clone() { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	internal ValidationEventHandler GetEventHandler() { }

	// RVA: 0x24CF140 Offset: 0x24CDB40 VA: 0x1824CF140
	internal XmlReader CreateReader(Stream input, Uri baseUri, string baseUriString, XmlParserContext inputContext) { }

	// RVA: 0x24CF010 Offset: 0x24CDA10 VA: 0x1824CF010
	internal XmlReader CreateReader(TextReader input, string baseUriString, XmlParserContext inputContext) { }

	// RVA: 0xCE3DF0 Offset: 0xCE27F0 VA: 0x180CE3DF0
	internal void set_ReadOnly(bool value) { }

	// RVA: 0x24CEE20 Offset: 0x24CD820 VA: 0x1824CEE20
	private void CheckReadOnly(string propertyName) { }

	// RVA: 0x24CF4E0 Offset: 0x24CDEE0 VA: 0x1824CF4E0
	private void Initialize() { }

	// RVA: 0x24CF3F0 Offset: 0x24CDDF0 VA: 0x1824CF3F0
	private void Initialize(XmlResolver resolver) { }

	// RVA: 0x24CEF30 Offset: 0x24CD930 VA: 0x1824CEF30
	private static XmlResolver CreateDefaultResolver() { }

	// RVA: 0x24CECE0 Offset: 0x24CD6E0 VA: 0x1824CECE0
	internal XmlReader AddValidation(XmlReader reader) { }

	// RVA: 0x24CEF80 Offset: 0x24CD980 VA: 0x1824CEF80
	private XmlValidatingReaderImpl CreateDtdValidatingReader(XmlReader baseReader) { }

	// RVA: 0x24CF2F0 Offset: 0x24CDCF0 VA: 0x1824CF2F0
	internal static bool EnableLegacyXmlSettings() { }
}
