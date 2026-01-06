internal class XmlEncodedRawTextWriter : XmlRawWriter // TypeDefIndex: 7957
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
	protected int bufBytesUsed; // 0x6C
	protected char[] bufChars; // 0x70
	protected Encoder encoder; // 0x78
	protected TextWriter writer; // 0x80
	protected bool trackTextContent; // 0x88
	protected bool inTextContent; // 0x89
	private int lastMarkPos; // 0x8C
	private int[] textContentMarks; // 0x90
	private CharEntityEncoderFallback charEntityFallback; // 0x98
	protected NewLineHandling newLineHandling; // 0xA0
	protected bool closeOutput; // 0xA4
	protected bool omitXmlDeclaration; // 0xA5
	protected string newLineChars; // 0xA8
	protected bool checkCharacters; // 0xB0
	protected XmlStandalone standalone; // 0xB4
	protected XmlOutputMethod outputMethod; // 0xB8
	protected bool autoXmlDeclaration; // 0xBC
	protected bool mergeCDataSections; // 0xBD

	// Properties
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x24CC1B0 Offset: 0x24CABB0 VA: 0x1824CC1B0
	protected void .ctor(XmlWriterSettings settings) { }

	// RVA: 0x24CC640 Offset: 0x24CB040 VA: 0x1824CC640
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x24CC2C0 Offset: 0x24CACC0 VA: 0x1824CC2C0
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x24CBEF0 Offset: 0x24CA8F0 VA: 0x1824CBEF0 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x24CC140 Offset: 0x24CAB40 VA: 0x1824CC140 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x24CA8F0 Offset: 0x24C92F0 VA: 0x1824CA8F0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x24CBA20 Offset: 0x24CA420 VA: 0x1824CBA20 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x24C94A0 Offset: 0x24C7EA0 VA: 0x1824C94A0 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x24CAF70 Offset: 0x24C9970 VA: 0x1824CAF70 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x24CB230 Offset: 0x24C9C30 VA: 0x1824CB230 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x24CB8E0 Offset: 0x24CA2E0 VA: 0x1824CB8E0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x24CAF10 Offset: 0x24C9910 VA: 0x1824CAF10 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x24CB360 Offset: 0x24C9D60 VA: 0x1824CB360 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x24CBB10 Offset: 0x24CA510 VA: 0x1824CBB10 Slot: 44
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x24CB0F0 Offset: 0x24C9AF0 VA: 0x1824CB0F0 Slot: 45
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x24C9F90 Offset: 0x24C8990 VA: 0x1824C9F90 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x24CA790 Offset: 0x24C9190 VA: 0x1824CA790 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x24CB450 Offset: 0x24C9E50 VA: 0x1824CB450 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x24CB150 Offset: 0x24C9B50 VA: 0x1824CB150 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x24CA1D0 Offset: 0x24C8BD0 VA: 0x1824CA1D0 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x24CBE70 Offset: 0x24CA870 VA: 0x1824CBE70 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x24CBC90 Offset: 0x24CA690 VA: 0x1824CBC90 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x24CBD10 Offset: 0x24CA710 VA: 0x1824CBD10 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x23B0820 Offset: 0x23AF220 VA: 0x1823B0820 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x24CB850 Offset: 0x24CA250 VA: 0x1824CB850 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x24C3BA0 Offset: 0x24C25A0 VA: 0x1824C3BA0 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x24C8690 Offset: 0x24C7090 VA: 0x1824C8690 Slot: 28
	public override void Close() { }

	// RVA: 0x24C8F90 Offset: 0x24C7990 VA: 0x1824C8F90 Slot: 29
	public override void Flush() { }

	// RVA: 0x24C8AD0 Offset: 0x24C74D0 VA: 0x1824C8AD0 Slot: 48
	protected virtual void FlushBuffer() { }

	// RVA: 0x24C87E0 Offset: 0x24C71E0 VA: 0x1824C87E0
	private void EncodeChars(int startOffset, int endOffset, bool writeAllToStream) { }

	// RVA: 0x24C8EB0 Offset: 0x24C78B0 VA: 0x1824C8EB0
	private void FlushEncoder() { }

	// RVA: 0x24C9890 Offset: 0x24C8290 VA: 0x1824C9890
	protected void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x24CABC0 Offset: 0x24C95C0 VA: 0x1824CABC0
	protected void WriteElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x24C9450 Offset: 0x24C7E50 VA: 0x1824C9450
	protected void RawText(string s) { }

	// RVA: 0x24C92A0 Offset: 0x24C7CA0 VA: 0x1824C92A0
	protected void RawText(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x24CB5A0 Offset: 0x24C9FA0 VA: 0x1824CB5A0
	protected void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x24CA3B0 Offset: 0x24C8DB0 VA: 0x1824CA3B0
	protected void WriteCommentOrPi(string text, int stopChar) { }

	// RVA: 0x24C9BB0 Offset: 0x24C85B0 VA: 0x1824C9BB0
	protected void WriteCDataSection(string text) { }

	// RVA: 0x24C8960 Offset: 0x24C7360 VA: 0x1824C8960
	private static char* EncodeSurrogate(char* pSrc, char* pSrcEnd, char* pDst) { }

	// RVA: 0x24C90E0 Offset: 0x24C7AE0 VA: 0x1824C90E0
	private char* InvalidXmlChar(int ch, char* pDst, bool entitize) { }

	// RVA: 0x24C8700 Offset: 0x24C7100 VA: 0x1824C8700
	internal void EncodeChar(ref char* pSrc, char* pSrcEnd, ref char* pDst) { }

	// RVA: 0x24C84F0 Offset: 0x24C6EF0 VA: 0x1824C84F0
	protected void ChangeTextContentMark(bool value) { }

	// RVA: 0x24C9020 Offset: 0x24C7A20 VA: 0x1824C9020
	private void GrowTextContentMarks() { }

	// RVA: 0x24CB3C0 Offset: 0x24C9DC0 VA: 0x1824CB3C0
	protected char* WriteNewLine(char* pDst) { }

	// RVA: 0x24C9210 Offset: 0x24C7C10 VA: 0x1824C9210
	protected static char* LtEntity(char* pDst) { }

	// RVA: 0x24C90C0 Offset: 0x24C7AC0 VA: 0x1824C90C0
	protected static char* GtEntity(char* pDst) { }

	// RVA: 0x24C84B0 Offset: 0x24C6EB0 VA: 0x1824C84B0
	protected static char* AmpEntity(char* pDst) { }

	// RVA: 0x24C9230 Offset: 0x24C7C30 VA: 0x1824C9230
	protected static char* QuoteEntity(char* pDst) { }

	// RVA: 0x24C94E0 Offset: 0x24C7EE0 VA: 0x1824C94E0
	protected static char* TabEntity(char* pDst) { }

	// RVA: 0x24C91F0 Offset: 0x24C7BF0 VA: 0x1824C91F0
	protected static char* LineFeedEntity(char* pDst) { }

	// RVA: 0x24C84D0 Offset: 0x24C6ED0 VA: 0x1824C84D0
	protected static char* CarriageReturnEntity(char* pDst) { }

	// RVA: 0x24C85E0 Offset: 0x24C6FE0 VA: 0x1824C85E0
	private static char* CharEntity(char* pDst, char ch) { }

	// RVA: 0x24C9270 Offset: 0x24C7C70 VA: 0x1824C9270
	protected static char* RawStartCData(char* pDst) { }

	// RVA: 0x24C9250 Offset: 0x24C7C50 VA: 0x1824C9250
	protected static char* RawEndCData(char* pDst) { }

	// RVA: 0x24C9500 Offset: 0x24C7F00 VA: 0x1824C9500
	protected void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace) { }
}
