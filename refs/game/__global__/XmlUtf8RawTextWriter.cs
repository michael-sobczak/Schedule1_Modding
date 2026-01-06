internal class XmlUtf8RawTextWriter : XmlRawWriter // TypeDefIndex: 7992
{
	// Fields
	private readonly bool useAsync; // 0x28
	protected byte[] bufBytes; // 0x30
	protected Stream stream; // 0x38
	protected Encoding encoding; // 0x40
	protected XmlCharType xmlCharType; // 0x48
	protected int bufPos; // 0x50
	protected int textPos; // 0x54
	protected int contentPos; // 0x58
	protected int cdataPos; // 0x5C
	protected int attrEndPos; // 0x60
	protected int bufLen; // 0x64
	protected bool writeToNull; // 0x68
	protected bool hadDoubleBracket; // 0x69
	protected bool inAttributeValue; // 0x6A
	protected NewLineHandling newLineHandling; // 0x6C
	protected bool closeOutput; // 0x70
	protected bool omitXmlDeclaration; // 0x71
	protected string newLineChars; // 0x78
	protected bool checkCharacters; // 0x80
	protected XmlStandalone standalone; // 0x84
	protected XmlOutputMethod outputMethod; // 0x88
	protected bool autoXmlDeclaration; // 0x8C
	protected bool mergeCDataSections; // 0x8D

	// Properties
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x24DE760 Offset: 0x24DD160 VA: 0x1824DE760
	protected void .ctor(XmlWriterSettings settings) { }

	// RVA: 0x24DE510 Offset: 0x24DCF10 VA: 0x1824DE510
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x24DE280 Offset: 0x24DCC80 VA: 0x1824DE280 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x24DE4A0 Offset: 0x24DCEA0 VA: 0x1824DE4A0 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x24DCEF0 Offset: 0x24DB8F0 VA: 0x1824DCEF0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x24DDEE0 Offset: 0x24DC8E0 VA: 0x1824DDEE0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x24DBB90 Offset: 0x24DA590 VA: 0x1824DBB90 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x24DD4E0 Offset: 0x24DBEE0 VA: 0x1824DD4E0 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x24DD730 Offset: 0x24DC130 VA: 0x1824DD730 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x24DDDD0 Offset: 0x24DC7D0 VA: 0x1824DDDD0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x24DD4A0 Offset: 0x24DBEA0 VA: 0x1824DD4A0 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x24CB360 Offset: 0x24C9D60 VA: 0x1824CB360 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x24DDFB0 Offset: 0x24DC9B0 VA: 0x1824DDFB0 Slot: 44
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x24DD640 Offset: 0x24DC040 VA: 0x1824DD640 Slot: 45
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x24DC620 Offset: 0x24DB020 VA: 0x1824DC620 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x24DCDD0 Offset: 0x24DB7D0 VA: 0x1824DCDD0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x24DD8C0 Offset: 0x24DC2C0 VA: 0x1824DD8C0 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x24DD680 Offset: 0x24DC080 VA: 0x1824DD680 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x24DC810 Offset: 0x24DB210 VA: 0x1824DC810 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x24DE0E0 Offset: 0x24DCAE0 VA: 0x1824DE0E0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x24DE0E0 Offset: 0x24DCAE0 VA: 0x1824DE0E0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x24DE140 Offset: 0x24DCB40 VA: 0x1824DE140 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x23B2140 Offset: 0x23B0B40 VA: 0x1823B2140 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x24DDD30 Offset: 0x24DC730 VA: 0x1824DDD30 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x24DDD80 Offset: 0x24DC780 VA: 0x1824DDD80 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x24DB200 Offset: 0x24D9C00 VA: 0x1824DB200 Slot: 28
	public override void Close() { }

	// RVA: 0x24DB6C0 Offset: 0x24DA0C0 VA: 0x1824DB6C0 Slot: 29
	public override void Flush() { }

	// RVA: 0x24DB540 Offset: 0x24D9F40 VA: 0x1824DB540 Slot: 48
	protected virtual void FlushBuffer() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void FlushEncoder() { }

	// RVA: 0x24DBF70 Offset: 0x24DA970 VA: 0x1824DBF70
	protected void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x24DD1A0 Offset: 0x24DBBA0 VA: 0x1824DD1A0
	protected void WriteElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x24DB920 Offset: 0x24DA320 VA: 0x1824DB920
	protected void RawText(string s) { }

	// RVA: 0x24DB970 Offset: 0x24DA370 VA: 0x1824DB970
	protected void RawText(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x24DD9F0 Offset: 0x24DC3F0 VA: 0x1824DD9F0
	protected void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x24DC9D0 Offset: 0x24DB3D0 VA: 0x1824DC9D0
	protected void WriteCommentOrPi(string text, int stopChar) { }

	// RVA: 0x24DC240 Offset: 0x24DAC40 VA: 0x1824DC240
	protected void WriteCDataSection(string text) { }

	// RVA: 0x24DB8A0 Offset: 0x24DA2A0 VA: 0x1824DB8A0
	private static bool IsSurrogateByte(byte b) { }

	// RVA: 0x24DB390 Offset: 0x24D9D90 VA: 0x1824DB390
	private static byte* EncodeSurrogate(char* pSrc, char* pSrcEnd, byte* pDst) { }

	// RVA: 0x24DB720 Offset: 0x24DA120 VA: 0x1824DB720
	private byte* InvalidXmlChar(int ch, byte* pDst, bool entitize) { }

	// RVA: 0x24DB260 Offset: 0x24D9C60 VA: 0x1824DB260
	internal void EncodeChar(ref char* pSrc, char* pSrcEnd, ref byte* pDst) { }

	// RVA: 0x24DB340 Offset: 0x24D9D40 VA: 0x1824DB340
	internal static byte* EncodeMultibyteUTF8(int ch, byte* pDst) { }

	// RVA: 0x24DB150 Offset: 0x24D9B50 VA: 0x1824DB150
	internal static void CharToUTF8(ref char* pSrc, char* pSrcEnd, ref byte* pDst) { }

	// RVA: 0x24DD840 Offset: 0x24DC240 VA: 0x1824DD840
	protected byte* WriteNewLine(byte* pDst) { }

	// RVA: 0x24DB8C0 Offset: 0x24DA2C0 VA: 0x1824DB8C0
	protected static byte* LtEntity(byte* pDst) { }

	// RVA: 0x24DB710 Offset: 0x24DA110 VA: 0x1824DB710
	protected static byte* GtEntity(byte* pDst) { }

	// RVA: 0x24DB090 Offset: 0x24D9A90 VA: 0x1824DB090
	protected static byte* AmpEntity(byte* pDst) { }

	// RVA: 0x24DB8D0 Offset: 0x24DA2D0 VA: 0x1824DB8D0
	protected static byte* QuoteEntity(byte* pDst) { }

	// RVA: 0x24DBBD0 Offset: 0x24DA5D0 VA: 0x1824DBBD0
	protected static byte* TabEntity(byte* pDst) { }

	// RVA: 0x24DB8B0 Offset: 0x24DA2B0 VA: 0x1824DB8B0
	protected static byte* LineFeedEntity(byte* pDst) { }

	// RVA: 0x24DB0A0 Offset: 0x24D9AA0 VA: 0x1824DB0A0
	protected static byte* CarriageReturnEntity(byte* pDst) { }

	// RVA: 0x24DB0B0 Offset: 0x24D9AB0 VA: 0x1824DB0B0
	private static byte* CharEntity(byte* pDst, char ch) { }

	// RVA: 0x24DB900 Offset: 0x24DA300 VA: 0x1824DB900
	protected static byte* RawStartCData(byte* pDst) { }

	// RVA: 0x24DB8F0 Offset: 0x24DA2F0 VA: 0x1824DB8F0
	protected static byte* RawEndCData(byte* pDst) { }

	// RVA: 0x24DBBE0 Offset: 0x24DA5E0 VA: 0x1824DBBE0
	protected void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace) { }
}
