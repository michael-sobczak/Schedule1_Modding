internal class XmlAsyncCheckReader : XmlReader // TypeDefIndex: 7950
{
	// Fields
	private readonly XmlReader coreReader; // 0x10
	private Task lastTask; // 0x18

	// Properties
	internal XmlReader CoreReader { get; }
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override Type ValueType { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	public override bool CanResolveEntity { get; }
	public override bool CanReadValueChunk { get; }
	public override bool HasAttributes { get; }
	internal override XmlNamespaceManager NamespaceManager { get; }
	internal override IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal XmlReader get_CoreReader() { }

	// RVA: 0x24C4BF0 Offset: 0x24C35F0 VA: 0x1824C4BF0
	public static XmlAsyncCheckReader CreateAsyncCheckWrapper(XmlReader reader) { }

	// RVA: 0x24C5530 Offset: 0x24C3F30 VA: 0x1824C5530
	public void .ctor(XmlReader reader) { }

	// RVA: 0x24C4B20 Offset: 0x24C3520 VA: 0x1824C4B20
	private void CheckAsync() { }

	// RVA: 0x24C5AE0 Offset: 0x24C44E0 VA: 0x1824C5AE0 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x24C59A0 Offset: 0x24C43A0 VA: 0x1824C59A0 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x24C58E0 Offset: 0x24C42E0 VA: 0x1824C58E0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24C5860 Offset: 0x24C4260 VA: 0x1824C5860 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x24C5960 Offset: 0x24C4360 VA: 0x1824C5960 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x24C59E0 Offset: 0x24C43E0 VA: 0x1824C59E0 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x24C5C20 Offset: 0x24C4620 VA: 0x1824C5C20 Slot: 11
	public override string get_Value() { }

	// RVA: 0x24C56E0 Offset: 0x24C40E0 VA: 0x1824C56E0 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x24C5620 Offset: 0x24C4020 VA: 0x1824C5620 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x24C5820 Offset: 0x24C4220 VA: 0x1824C5820 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x24C57E0 Offset: 0x24C41E0 VA: 0x1824C57E0 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x24C5A20 Offset: 0x24C4420 VA: 0x1824C5A20 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0x24C5CA0 Offset: 0x24C46A0 VA: 0x1824C5CA0 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x24C5C60 Offset: 0x24C4660 VA: 0x1824C5C60 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x24C5AA0 Offset: 0x24C44A0 VA: 0x1824C5AA0 Slot: 19
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x24C5BE0 Offset: 0x24C45E0 VA: 0x1824C5BE0 Slot: 20
	public override Type get_ValueType() { }

	// RVA: 0x24C55E0 Offset: 0x24C3FE0 VA: 0x1824C55E0 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x24C4F30 Offset: 0x24C3930 VA: 0x1824C4F30 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x24C4F80 Offset: 0x24C3980 VA: 0x1824C4F80 Slot: 23
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x24C4EE0 Offset: 0x24C38E0 VA: 0x1824C4EE0 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x24C50E0 Offset: 0x24C3AE0 VA: 0x1824C50E0 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x24C5090 Offset: 0x24C3A90 VA: 0x1824C5090 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x24C51B0 Offset: 0x24C3BB0 VA: 0x1824C51B0 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x24C51F0 Offset: 0x24C3BF0 VA: 0x1824C51F0 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x24C5170 Offset: 0x24C3B70 VA: 0x1824C5170 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x24C5230 Offset: 0x24C3C30 VA: 0x1824C5230 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x24C5470 Offset: 0x24C3E70 VA: 0x1824C5470 Slot: 31
	public override bool Read() { }

	// RVA: 0x24C5760 Offset: 0x24C4160 VA: 0x1824C5760 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x24C4BB0 Offset: 0x24C35B0 VA: 0x1824C4BB0 Slot: 33
	public override void Close() { }

	// RVA: 0x24C5A60 Offset: 0x24C4460 VA: 0x1824C5A60 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x24C54F0 Offset: 0x24C3EF0 VA: 0x1824C54F0 Slot: 35
	public override void Skip() { }

	// RVA: 0x24C58A0 Offset: 0x24C42A0 VA: 0x1824C58A0 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x24C5040 Offset: 0x24C3A40 VA: 0x1824C5040 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x24C56A0 Offset: 0x24C40A0 VA: 0x1824C56A0 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0x24C54B0 Offset: 0x24C3EB0 VA: 0x1824C54B0 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x24C5660 Offset: 0x24C4060 VA: 0x1824C5660 Slot: 40
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x24C5400 Offset: 0x24C3E00 VA: 0x1824C5400 Slot: 41
	public override int ReadValueChunk(char[] buffer, int index, int count) { }

	// RVA: 0x24C5370 Offset: 0x24C3D70 VA: 0x1824C5370 Slot: 42
	public override string ReadString() { }

	// RVA: 0x24C5130 Offset: 0x24C3B30 VA: 0x1824C5130 Slot: 43
	public override XmlNodeType MoveToContent() { }

	// RVA: 0x24C5330 Offset: 0x24C3D30 VA: 0x1824C5330 Slot: 44
	public override void ReadStartElement() { }

	// RVA: 0x24C5270 Offset: 0x24C3C70 VA: 0x1824C5270 Slot: 45
	public override string ReadElementString() { }

	// RVA: 0x24C52B0 Offset: 0x24C3CB0 VA: 0x1824C52B0 Slot: 46
	public override void ReadEndElement() { }

	// RVA: 0x24C4FE0 Offset: 0x24C39E0 VA: 0x1824C4FE0 Slot: 47
	public override bool IsStartElement(string localname, string ns) { }

	// RVA: 0x24C53B0 Offset: 0x24C3DB0 VA: 0x1824C53B0 Slot: 48
	public override bool ReadToFollowing(string name) { }

	// RVA: 0x24C52F0 Offset: 0x24C3CF0 VA: 0x1824C52F0 Slot: 49
	public override string ReadInnerXml() { }

	// RVA: 0x24C57A0 Offset: 0x24C41A0 VA: 0x1824C57A0 Slot: 50
	public override bool get_HasAttributes() { }

	// RVA: 0x24C4EA0 Offset: 0x24C38A0 VA: 0x1824C4EA0 Slot: 51
	protected override void Dispose(bool disposing) { }

	// RVA: 0x24C5920 Offset: 0x24C4320 VA: 0x1824C5920 Slot: 52
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x24C5720 Offset: 0x24C4120 VA: 0x1824C5720 Slot: 53
	internal override IDtdInfo get_DtdInfo() { }
}
