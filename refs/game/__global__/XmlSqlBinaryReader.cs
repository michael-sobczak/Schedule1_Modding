internal sealed class XmlSqlBinaryReader : XmlReader, IXmlNamespaceResolver // TypeDefIndex: 7907
{
	// Fields
	internal static readonly Type TypeOfObject; // 0x0
	internal static readonly Type TypeOfString; // 0x8
	private static Type[] TokenTypeMap; // 0x10
	private static byte[] XsdKatmaiTimeScaleToValueLengthMap; // 0x18
	private static ReadState[] ScanState2ReadState; // 0x20
	private Stream inStrm; // 0x10
	private byte[] data; // 0x18
	private int pos; // 0x20
	private int mark; // 0x24
	private int end; // 0x28
	private long offset; // 0x30
	private bool eof; // 0x38
	private bool sniffed; // 0x39
	private bool isEmpty; // 0x3A
	private int docState; // 0x3C
	private XmlSqlBinaryReader.SymbolTables symbolTables; // 0x40
	private XmlNameTable xnt; // 0x60
	private bool xntFromSettings; // 0x68
	private string xml; // 0x70
	private string xmlns; // 0x78
	private string nsxmlns; // 0x80
	private string baseUri; // 0x88
	private XmlSqlBinaryReader.ScanState state; // 0x90
	private XmlNodeType nodetype; // 0x94
	private BinXmlToken token; // 0x98
	private int attrIndex; // 0x9C
	private XmlSqlBinaryReader.QName qnameOther; // 0xA0
	private XmlSqlBinaryReader.QName qnameElement; // 0xB8
	private XmlNodeType parentNodeType; // 0xD0
	private XmlSqlBinaryReader.ElemInfo[] elementStack; // 0xD8
	private int elemDepth; // 0xE0
	private XmlSqlBinaryReader.AttrInfo[] attributes; // 0xE8
	private int[] attrHashTbl; // 0xF0
	private int attrCount; // 0xF8
	private int posAfterAttrs; // 0xFC
	private bool xmlspacePreserve; // 0x100
	private int tokLen; // 0x104
	private int tokDataPos; // 0x108
	private bool hasTypedValue; // 0x10C
	private Type valueType; // 0x110
	private string stringValue; // 0x118
	private Dictionary<string, XmlSqlBinaryReader.NamespaceDecl> namespaces; // 0x120
	private XmlSqlBinaryReader.NestedBinXml prevNameInfo; // 0x128
	private XmlReader textXmlReader; // 0x130
	private bool closeInput; // 0x138
	private bool checkCharacters; // 0x139
	private bool ignoreWhitespace; // 0x13A
	private bool ignorePIs; // 0x13B
	private bool ignoreComments; // 0x13C
	private DtdProcessing dtdProcessing; // 0x140
	private SecureStringHasher hasher; // 0x148
	private XmlCharType xmlCharType; // 0x150
	private Encoding unicode; // 0x158
	private byte version; // 0x160

	// Properties
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override Type ValueType { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override XmlNameTable NameTable { get; }
	public override ReadState ReadState { get; }

	// Methods

	// RVA: 0x23BF3C0 Offset: 0x23BDDC0 VA: 0x1823BF3C0
	public void .ctor(Stream stream, byte[] data, int len, string baseUri, bool closeInput, XmlReaderSettings settings) { }

	// RVA: 0x23BFB50 Offset: 0x23BE550 VA: 0x1823BFB50 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x1D0F570 Offset: 0x1D0DF70 VA: 0x181D0F570 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x4B61A0 Offset: 0x4B4BA0 VA: 0x1804B61A0 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x4B6150 Offset: 0x4B4B50 VA: 0x1804B6150 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x23BFC70 Offset: 0x23BE670 VA: 0x1823BFC70 Slot: 11
	public override string get_Value() { }

	// RVA: 0x23BF9D0 Offset: 0x23BE3D0 VA: 0x1823BF9D0 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x23BFAB0 Offset: 0x23BE4B0 VA: 0x1823BFAB0 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x23C0130 Offset: 0x23BEB30 VA: 0x1823C0130 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x23C0060 Offset: 0x23BEA60 VA: 0x1823C0060 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x5231F0 Offset: 0x521BF0 VA: 0x1805231F0 Slot: 20
	public override Type get_ValueType() { }

	// RVA: 0x23BF970 Offset: 0x23BE370 VA: 0x1823BF970 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x23B6020 Offset: 0x23B4A20 VA: 0x1823B6020 Slot: 23
	public override string GetAttribute(string name, string ns) { }

	// RVA: 0x23B61B0 Offset: 0x23B4BB0 VA: 0x1823B61B0 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x23B5F70 Offset: 0x23B4970 VA: 0x1823B5F70 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x23B8350 Offset: 0x23B6D50 VA: 0x1823B8350 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x23B82A0 Offset: 0x23B6CA0 VA: 0x1823B82A0 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x23B8510 Offset: 0x23B6F10 VA: 0x1823B8510 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x23B85A0 Offset: 0x23B6FA0 VA: 0x1823B85A0 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x23B83E0 Offset: 0x23B6DE0 VA: 0x1823B83E0 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x23BFAA0 Offset: 0x23BE4A0 VA: 0x1823BFAA0 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x23B9620 Offset: 0x23B8020 VA: 0x1823B9620 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x23B45C0 Offset: 0x23B2FC0 VA: 0x1823B45C0 Slot: 33
	public override void Close() { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x23B81E0 Offset: 0x23B6BE0 VA: 0x1823B81E0 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x23BB180 Offset: 0x23B9B80 VA: 0x1823BB180 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x23BFAD0 Offset: 0x23BE4D0 VA: 0x1823BFAD0 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x23BAD50 Offset: 0x23B9750 VA: 0x1823BAD50 Slot: 31
	public override bool Read() { }

	// RVA: 0x23BC5F0 Offset: 0x23BAFF0 VA: 0x1823BC5F0 Slot: 54
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x23BC970 Offset: 0x23BB370 VA: 0x1823BC970 Slot: 56
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x23BEF60 Offset: 0x23BD960 VA: 0x1823BEF60
	private void VerifyVersion(int requiredVersion, BinXmlToken token) { }

	// RVA: 0x23B3B30 Offset: 0x23B2530 VA: 0x1823B3B30
	private void AddInitNamespace(string prefix, string uri) { }

	// RVA: 0x23B3C70 Offset: 0x23B2670 VA: 0x1823B3C70
	private void AddName() { }

	// RVA: 0x23B3DC0 Offset: 0x23B27C0 VA: 0x1823B3DC0
	private void AddQName() { }

	// RVA: 0x23B8650 Offset: 0x23B7050 VA: 0x1823B8650
	private void NameFlush() { }

	// RVA: 0x23BC4C0 Offset: 0x23BAEC0 VA: 0x1823BC4C0
	private void SkipExtn() { }

	// RVA: 0x23BA9A0 Offset: 0x23B93A0 VA: 0x1823BA9A0
	private int ReadQNameRef() { }

	// RVA: 0x23BA8D0 Offset: 0x23B92D0 VA: 0x1823BA8D0
	private int ReadNameRef() { }

	// RVA: 0x23B4680 Offset: 0x23B3080 VA: 0x1823B4680
	private bool FillAllowEOF() { }

	// RVA: 0x23B48D0 Offset: 0x23B32D0 VA: 0x1823B48D0
	private void Fill_(int require) { }

	// RVA: 0x23B4950 Offset: 0x23B3350 VA: 0x1823B4950
	private void Fill(int require) { }

	// RVA: 0x23B9800 Offset: 0x23B8200 VA: 0x1823B9800
	private byte ReadByte() { }

	// RVA: 0x23BACF0 Offset: 0x23B96F0 VA: 0x1823BACF0
	private ushort ReadUShort() { }

	// RVA: 0x23B8C70 Offset: 0x23B7670 VA: 0x1823B8C70
	private int ParseMB32() { }

	// RVA: 0x23B8B10 Offset: 0x23B7510 VA: 0x1823B8B10
	private int ParseMB32_(byte b) { }

	// RVA: 0x23B8CD0 Offset: 0x23B76D0 VA: 0x1823B8CD0
	private int ParseMB32(int pos) { }

	// RVA: 0x23B8C70 Offset: 0x23B7670 VA: 0x1823B8C70
	private int ParseMB64() { }

	// RVA: 0x23B8ED0 Offset: 0x23B78D0 VA: 0x1823B8ED0
	private BinXmlToken PeekToken() { }

	// RVA: 0x23BAA70 Offset: 0x23B9470 VA: 0x1823BAA70
	private BinXmlToken ReadToken() { }

	// RVA: 0x23B8720 Offset: 0x23B7120 VA: 0x1823B8720
	private BinXmlToken NextToken2(BinXmlToken token) { }

	// RVA: 0x23B86B0 Offset: 0x23B70B0 VA: 0x1823B86B0
	private BinXmlToken NextToken1() { }

	// RVA: 0x23B8A70 Offset: 0x23B7470 VA: 0x1823B8A70
	private BinXmlToken NextToken() { }

	// RVA: 0x23B8EB0 Offset: 0x23B78B0 VA: 0x1823B8EB0
	private BinXmlToken PeekNextToken() { }

	// RVA: 0x23BAED0 Offset: 0x23B98D0 VA: 0x1823BAED0
	private BinXmlToken RescanNextToken() { }

	// RVA: 0x23B8DF0 Offset: 0x23B77F0 VA: 0x1823B8DF0
	private string ParseText() { }

	// RVA: 0x23BC1F0 Offset: 0x23BABF0 VA: 0x1823BC1F0
	private int ScanText(out int start) { }

	// RVA: 0x23B6630 Offset: 0x23B5030 VA: 0x1823B6630
	private string GetString(int pos, int cch) { }

	// RVA: 0x23B65F0 Offset: 0x23B4FF0 VA: 0x1823B65F0
	private string GetStringAligned(byte[] data, int offset, int cch) { }

	// RVA: 0x23B5DF0 Offset: 0x23B47F0 VA: 0x1823B5DF0
	private string GetAttributeText(int i) { }

	// RVA: 0x23B8040 Offset: 0x23B6A40 VA: 0x1823B8040
	private int LocateAttribute(string name, string ns) { }

	// RVA: 0x23B80F0 Offset: 0x23B6AF0 VA: 0x1823B80F0
	private int LocateAttribute(string name) { }

	// RVA: 0x23B9230 Offset: 0x23B7C30 VA: 0x1823B9230
	private void PositionOnAttribute(int i) { }

	// RVA: 0x23B6AF0 Offset: 0x23B54F0 VA: 0x1823B6AF0
	private void GrowElements() { }

	// RVA: 0x23B6A50 Offset: 0x23B5450 VA: 0x1823B6A50
	private void GrowAttributes() { }

	// RVA: 0x23B45A0 Offset: 0x23B2FA0 VA: 0x1823B45A0
	private void ClearAttributes() { }

	// RVA: 0x23B9350 Offset: 0x23B7D50 VA: 0x1823B9350
	private void PushNamespace(string prefix, string ns, bool implied) { }

	// RVA: 0x23B9150 Offset: 0x23B7B50 VA: 0x1823B9150
	private void PopNamespaces(XmlSqlBinaryReader.NamespaceDecl firstInScopeChain) { }

	// RVA: 0x23B4BA0 Offset: 0x23B35A0 VA: 0x1823B4BA0
	private void GenerateImpliedXmlnsAttrs() { }

	// RVA: 0x23BA1F0 Offset: 0x23B8BF0 VA: 0x1823BA1F0
	private bool ReadInit(bool skipXmlDecl) { }

	// RVA: 0x23BB1C0 Offset: 0x23B9BC0 VA: 0x1823BB1C0
	private void ScanAttributes() { }

	// RVA: 0x23BC350 Offset: 0x23BAD50 VA: 0x1823BC350
	private void SimpleCheckForDuplicateAttributes() { }

	// RVA: 0x23B6B90 Offset: 0x23B5590 VA: 0x1823B6B90
	private void HashCheckForDuplicateAttributes() { }

	// RVA: 0x23BEFB0 Offset: 0x23BD9B0 VA: 0x1823BEFB0
	private string XmlDeclValue() { }

	// RVA: 0x23B40B0 Offset: 0x23B2AB0 VA: 0x1823B40B0
	private string CDATAValue() { }

	// RVA: 0x23B49E0 Offset: 0x23B33E0 VA: 0x1823B49E0
	private void FinishCDATA() { }

	// RVA: 0x23B4A80 Offset: 0x23B3480 VA: 0x1823B4A80
	private void FinishEndElement() { }

	// RVA: 0x23B9850 Offset: 0x23B8250 VA: 0x1823B9850
	private bool ReadDoc() { }

	// RVA: 0x23B6F90 Offset: 0x23B5990 VA: 0x1823B6F90
	private void ImplReadData(BinXmlToken tokenType) { }

	// RVA: 0x23B7550 Offset: 0x23B5F50 VA: 0x1823B7550
	private void ImplReadElement() { }

	// RVA: 0x23B7920 Offset: 0x23B6320 VA: 0x1823B7920
	private void ImplReadEndElement() { }

	// RVA: 0x23B7140 Offset: 0x23B5B40 VA: 0x1823B7140
	private void ImplReadDoctype() { }

	// RVA: 0x23B7BC0 Offset: 0x23B65C0 VA: 0x1823B7BC0
	private void ImplReadPI() { }

	// RVA: 0x23B6F50 Offset: 0x23B5950 VA: 0x1823B6F50
	private void ImplReadComment() { }

	// RVA: 0x23B6EC0 Offset: 0x23B58C0 VA: 0x1823B6EC0
	private void ImplReadCDATA() { }

	// RVA: 0x23B7A90 Offset: 0x23B6490 VA: 0x1823B7A90
	private void ImplReadNest() { }

	// RVA: 0x23B7A20 Offset: 0x23B6420 VA: 0x1823B7A20
	private void ImplReadEndNest() { }

	// RVA: 0x23B7C40 Offset: 0x23B6640 VA: 0x1823B7C40
	private void ImplReadXmlText() { }

	// RVA: 0x23BCDC0 Offset: 0x23BB7C0 VA: 0x1823BCDC0
	private void UpdateFromTextReader() { }

	// RVA: 0x23BCEE0 Offset: 0x23BB8E0 VA: 0x1823BCEE0
	private bool UpdateFromTextReader(bool needUpdate) { }

	// RVA: 0x23B41F0 Offset: 0x23B2BF0 VA: 0x1823B41F0
	private void CheckAllowContent() { }

	// RVA: 0x23B4E10 Offset: 0x23B3810 VA: 0x1823B4E10
	private void GenerateTokenTypeMap() { }

	// RVA: 0x23B6800 Offset: 0x23B5200 VA: 0x1823B6800
	private Type GetValueType(BinXmlToken token) { }

	// RVA: 0x23B9600 Offset: 0x23B8000 VA: 0x1823B9600
	private void ReScanOverValue(BinXmlToken token) { }

	// RVA: 0x23BBFD0 Offset: 0x23BA9D0 VA: 0x1823BBFD0
	private XmlNodeType ScanOverValue(BinXmlToken token, bool attr, bool checkChars) { }

	// RVA: 0x23BB950 Offset: 0x23BA350 VA: 0x1823BB950
	private XmlNodeType ScanOverAnyValue(BinXmlToken token, bool attr, bool checkChars) { }

	// RVA: 0x23B42F0 Offset: 0x23B2CF0 VA: 0x1823B42F0
	private XmlNodeType CheckText(bool attr) { }

	// RVA: 0x23B4250 Offset: 0x23B2C50 VA: 0x1823B4250
	private XmlNodeType CheckTextIsWS() { }

	// RVA: 0x23B4540 Offset: 0x23B2F40 VA: 0x1823B4540
	private void CheckValueTokenBounds() { }

	// RVA: 0x23B68F0 Offset: 0x23B52F0 VA: 0x1823B68F0
	private int GetXsdKatmaiTokenLength(BinXmlToken token) { }

	// RVA: 0x23BF110 Offset: 0x23BDB10 VA: 0x1823BF110
	private int XsdKatmaiTimeScaleToValueLength(byte scale) { }

	// RVA: 0x23BE060 Offset: 0x23BCA60 VA: 0x1823BE060
	private long ValueAsLong() { }

	// RVA: 0x23BEEC0 Offset: 0x23BD8C0 VA: 0x1823BEEC0
	private ulong ValueAsULong() { }

	// RVA: 0x23BDB40 Offset: 0x23BC540 VA: 0x1823BDB40
	private Decimal ValueAsDecimal() { }

	// RVA: 0x23BDE60 Offset: 0x23BC860 VA: 0x1823BDE60
	private double ValueAsDouble() { }

	// RVA: 0x23BCF00 Offset: 0x23BB900 VA: 0x1823BCF00
	private string ValueAsDateTimeString() { }

	// RVA: 0x23BE5A0 Offset: 0x23BCFA0 VA: 0x1823BE5A0
	private string ValueAsString(BinXmlToken token) { }

	// RVA: 0x23B6380 Offset: 0x23B4D80 VA: 0x1823B6380
	private short GetInt16(int pos) { }

	// RVA: 0x23B6380 Offset: 0x23B4D80 VA: 0x1823B6380
	private ushort GetUInt16(int pos) { }

	// RVA: 0x23B63D0 Offset: 0x23B4DD0 VA: 0x1823B63D0
	private int GetInt32(int pos) { }

	// RVA: 0x23B63D0 Offset: 0x23B4DD0 VA: 0x1823B63D0
	private uint GetUInt32(int pos) { }

	// RVA: 0x23B6450 Offset: 0x23B4E50 VA: 0x1823B6450
	private long GetInt64(int pos) { }

	// RVA: 0x23B6450 Offset: 0x23B4E50 VA: 0x1823B6450
	private ulong GetUInt64(int pos) { }

	// RVA: 0x23B6570 Offset: 0x23B4F70 VA: 0x1823B6570
	private float GetSingle(int offset) { }

	// RVA: 0x23B6220 Offset: 0x23B4C20 VA: 0x1823B6220
	private double GetDouble(int offset) { }

	// RVA: 0x23BCBE0 Offset: 0x23BB5E0 VA: 0x1823BCBE0
	private Exception ThrowUnexpectedToken(BinXmlToken token) { }

	// RVA: 0x23BCD50 Offset: 0x23BB750 VA: 0x1823BCD50
	private Exception ThrowXmlException(string res) { }

	// RVA: 0x23BCC70 Offset: 0x23BB670 VA: 0x1823BCC70
	private Exception ThrowXmlException(string res, string arg1, string arg2) { }

	// RVA: 0x23BCB70 Offset: 0x23BB570 VA: 0x1823BCB70
	private Exception ThrowNotSupported(string res) { }

	// RVA: 0x23BF1E0 Offset: 0x23BDBE0 VA: 0x1823BF1E0
	private static void .cctor() { }
}
