internal class HtmlUtf8RawTextWriter : XmlUtf8RawTextWriter // TypeDefIndex: 7919
{
	// Fields
	protected ByteStack elementScope; // 0x90
	protected ElementProperties currentElementProperties; // 0x98
	private AttributeProperties currentAttributeProperties; // 0x9C
	private bool endsWithAmpersand; // 0xA0
	private byte[] uriEscapingBuffer; // 0xA8
	private string mediaType; // 0xB0
	private bool doNotEscapeUriAttributes; // 0xB8
	protected static TernaryTreeReadOnly elementPropertySearch; // 0x0
	protected static TernaryTreeReadOnly attributePropertySearch; // 0x8

	// Methods

	// RVA: 0x23B3300 Offset: 0x23B1D00 VA: 0x1823B3300
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x23B2190 Offset: 0x23B0B90 VA: 0x1823B2190 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x23B2D10 Offset: 0x23B1710 VA: 0x1823B2D10 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x23B1F80 Offset: 0x23B0980 VA: 0x1823B1F80 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x23B23F0 Offset: 0x23B0DF0 VA: 0x1823B23F0 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x23B2560 Offset: 0x23B0F60 VA: 0x1823B2560 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x23B2BB0 Offset: 0x23B15B0 VA: 0x1823B2BB0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x23B2380 Offset: 0x23B0D80 VA: 0x1823B2380 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x23B2AB0 Offset: 0x23B14B0 VA: 0x1823B2AB0 Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x23B2E20 Offset: 0x23B1820 VA: 0x1823B2E20 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x23B2500 Offset: 0x23B0F00 VA: 0x1823B2500 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x23B20E0 Offset: 0x23B0AE0 VA: 0x1823B20E0 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x23B2F00 Offset: 0x23B1900 VA: 0x1823B2F00 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x23B2140 Offset: 0x23B0B40 VA: 0x1823B2140 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x23B1CA0 Offset: 0x23B06A0 VA: 0x1823B1CA0
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x23B29A0 Offset: 0x23B13A0 VA: 0x1823B29A0
	protected void WriteMetaElement() { }

	// RVA: 0x23B2980 Offset: 0x23B1380 VA: 0x1823B2980
	protected void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x23B2670 Offset: 0x23B1070 VA: 0x1823B2670
	protected void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x23B26C0 Offset: 0x23B10C0 VA: 0x1823B26C0
	private void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x23B2F60 Offset: 0x23B1960 VA: 0x1823B2F60
	private void WriteUriAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x23B1EE0 Offset: 0x23B08E0 VA: 0x1823B1EE0
	private void OutputRestAmps() { }
}
