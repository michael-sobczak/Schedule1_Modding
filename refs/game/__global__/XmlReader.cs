public abstract class XmlReader : IDisposable // TypeDefIndex: 7964
{
	// Fields
	private static uint IsTextualNodeBitmap; // 0x0
	private static uint CanReadContentAsBitmap; // 0x4
	private static uint HasValueBitmap; // 0x8

	// Properties
	public virtual XmlReaderSettings Settings { get; }
	public abstract XmlNodeType NodeType { get; }
	public virtual string Name { get; }
	public abstract string LocalName { get; }
	public abstract string NamespaceURI { get; }
	public abstract string Prefix { get; }
	public abstract string Value { get; }
	public abstract int Depth { get; }
	public abstract string BaseURI { get; }
	public abstract bool IsEmptyElement { get; }
	public virtual bool IsDefault { get; }
	public virtual char QuoteChar { get; }
	public virtual XmlSpace XmlSpace { get; }
	public virtual string XmlLang { get; }
	public virtual IXmlSchemaInfo SchemaInfo { get; }
	public virtual Type ValueType { get; }
	public abstract int AttributeCount { get; }
	public abstract bool EOF { get; }
	public abstract ReadState ReadState { get; }
	public abstract XmlNameTable NameTable { get; }
	public virtual bool CanResolveEntity { get; }
	public virtual bool CanReadValueChunk { get; }
	public virtual bool HasAttributes { get; }
	internal virtual XmlNamespaceManager NamespaceManager { get; }
	internal bool IsDefaultInternal { get; }
	internal virtual IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 5
	public virtual XmlReaderSettings get_Settings() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract XmlNodeType get_NodeType();

	// RVA: 0x24D23D0 Offset: 0x24D0DD0 VA: 0x1824D23D0 Slot: 7
	public virtual string get_Name() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_LocalName();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_NamespaceURI();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract string get_Prefix();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract string get_Value();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int get_Depth();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract string get_BaseURI();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool get_IsEmptyElement();

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 15
	public virtual bool get_IsDefault() { }

	// RVA: 0x24D24E0 Offset: 0x24D0EE0 VA: 0x1824D24E0 Slot: 16
	public virtual char get_QuoteChar() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 17
	public virtual XmlSpace get_XmlSpace() { }

	// RVA: 0x24D2590 Offset: 0x24D0F90 VA: 0x1824D2590 Slot: 18
	public virtual string get_XmlLang() { }

	// RVA: 0x24D24F0 Offset: 0x24D0EF0 VA: 0x1824D24F0 Slot: 19
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x24D2530 Offset: 0x24D0F30 VA: 0x1824D2530 Slot: 20
	public virtual Type get_ValueType() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract int get_AttributeCount();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract string GetAttribute(string name);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract string GetAttribute(string name, string namespaceURI);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract string GetAttribute(int i);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract bool MoveToAttribute(string name);

	// RVA: 0x24D0AB0 Offset: 0x24CF4B0 VA: 0x1824D0AB0 Slot: 26
	public virtual void MoveToAttribute(int i) { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract bool MoveToFirstAttribute();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract bool MoveToNextAttribute();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract bool MoveToElement();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract bool ReadAttributeValue();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract bool Read();

	// RVA: -1 Offset: -1 Slot: 32
	public abstract bool get_EOF();

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 33
	public virtual void Close() { }

	// RVA: -1 Offset: -1 Slot: 34
	public abstract ReadState get_ReadState();

	// RVA: 0x24D1B20 Offset: 0x24D0520 VA: 0x1824D1B20 Slot: 35
	public virtual void Skip() { }

	// RVA: -1 Offset: -1 Slot: 36
	public abstract XmlNameTable get_NameTable();

	// RVA: -1 Offset: -1 Slot: 37
	public abstract string LookupNamespace(string prefix);

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 38
	public virtual bool get_CanResolveEntity() { }

	// RVA: -1 Offset: -1 Slot: 39
	public abstract void ResolveEntity();

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 40
	public virtual bool get_CanReadValueChunk() { }

	// RVA: 0x24D18E0 Offset: 0x24D02E0 VA: 0x1824D18E0 Slot: 41
	public virtual int ReadValueChunk(char[] buffer, int index, int count) { }

	[EditorBrowsable(1)]
	// RVA: 0x24D1550 Offset: 0x24CFF50 VA: 0x1824D1550 Slot: 42
	public virtual string ReadString() { }

	// RVA: 0x24D0B80 Offset: 0x24CF580 VA: 0x1824D0B80 Slot: 43
	public virtual XmlNodeType MoveToContent() { }

	// RVA: 0x24D1450 Offset: 0x24CFE50 VA: 0x1824D1450 Slot: 44
	public virtual void ReadStartElement() { }

	[EditorBrowsable(1)]
	// RVA: 0x24D0C20 Offset: 0x24CF620 VA: 0x1824D0C20 Slot: 45
	public virtual string ReadElementString() { }

	// RVA: 0x24D0ED0 Offset: 0x24CF8D0 VA: 0x1824D0ED0 Slot: 46
	public virtual void ReadEndElement() { }

	// RVA: 0x24D09A0 Offset: 0x24CF3A0 VA: 0x1824D09A0 Slot: 47
	public virtual bool IsStartElement(string localname, string ns) { }

	// RVA: 0x24D17B0 Offset: 0x24D01B0 VA: 0x1824D17B0 Slot: 48
	public virtual bool ReadToFollowing(string name) { }

	// RVA: 0x24D0FD0 Offset: 0x24CF9D0 VA: 0x1824D0FD0 Slot: 49
	public virtual string ReadInnerXml() { }

	// RVA: 0x24D1D50 Offset: 0x24D0750 VA: 0x1824D1D50
	private void WriteNode(XmlWriter xtw, bool defattr) { }

	// RVA: 0x24D1C30 Offset: 0x24D0630 VA: 0x1824D1C30
	private void WriteAttributeValue(XmlWriter xtw) { }

	// RVA: 0x24D02C0 Offset: 0x24CECC0 VA: 0x1824D02C0
	private XmlWriter CreateWriterForInnerOuterXml(StringWriter sw) { }

	// RVA: 0x24D1940 Offset: 0x24D0340 VA: 0x1824D1940
	private void SetNamespacesFlag(XmlTextWriter xtw) { }

	// RVA: 0x24D2310 Offset: 0x24D0D10 VA: 0x1824D2310 Slot: 50
	public virtual bool get_HasAttributes() { }

	// RVA: 0x24D08D0 Offset: 0x24CF2D0 VA: 0x1824D08D0 Slot: 4
	public void Dispose() { }

	// RVA: 0x24D08F0 Offset: 0x24CF2F0 VA: 0x1824D08F0 Slot: 51
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 52
	internal virtual XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x24D0A40 Offset: 0x24CF440 VA: 0x1824D0A40
	internal static bool IsTextualNode(XmlNodeType nodeType) { }

	// RVA: 0x24D0930 Offset: 0x24CF330 VA: 0x1824D0930
	internal static bool HasValueInternal(XmlNodeType nodeType) { }

	// RVA: 0x24D1A30 Offset: 0x24D0430 VA: 0x1824D1A30
	private bool SkipSubtree() { }

	// RVA: 0x24D2340 Offset: 0x24D0D40 VA: 0x1824D2340
	internal bool get_IsDefaultInternal() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 53
	internal virtual IDtdInfo get_DtdInfo() { }

	// RVA: 0x24D0590 Offset: 0x24CEF90 VA: 0x1824D0590
	public static XmlReader Create(Stream input, XmlReaderSettings settings, string baseUri) { }

	// RVA: 0x24D03E0 Offset: 0x24CEDE0 VA: 0x1824D03E0
	public static XmlReader Create(TextReader input, XmlReaderSettings settings) { }

	// RVA: 0x24D0760 Offset: 0x24CF160 VA: 0x1824D0760
	public static XmlReader Create(TextReader input, XmlReaderSettings settings, string baseUri) { }

	// RVA: 0x24CFF40 Offset: 0x24CE940 VA: 0x1824CFF40
	internal static XmlReader CreateSqlReader(Stream input, XmlReaderSettings settings, XmlParserContext inputContext) { }

	// RVA: 0x24CFEA0 Offset: 0x24CE8A0 VA: 0x1824CFEA0
	internal static int CalcBufferSize(Stream input) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x24D22A0 Offset: 0x24D0CA0 VA: 0x1824D22A0
	private static void .cctor() { }
}
