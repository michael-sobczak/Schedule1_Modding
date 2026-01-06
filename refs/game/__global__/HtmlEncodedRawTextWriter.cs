internal class HtmlEncodedRawTextWriter : XmlEncodedRawTextWriter // TypeDefIndex: 7916
{
	// Fields
	protected ByteStack elementScope; // 0xC0
	protected ElementProperties currentElementProperties; // 0xC8
	private AttributeProperties currentAttributeProperties; // 0xCC
	private bool endsWithAmpersand; // 0xD0
	private byte[] uriEscapingBuffer; // 0xD8
	private string mediaType; // 0xE0
	private bool doNotEscapeUriAttributes; // 0xE8
	protected static TernaryTreeReadOnly elementPropertySearch; // 0x0
	protected static TernaryTreeReadOnly attributePropertySearch; // 0x8

	// Methods

	// RVA: 0x23B1B50 Offset: 0x23B0550 VA: 0x1823B1B50
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x23B1B80 Offset: 0x23B0580 VA: 0x1823B1B80
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x23B08B0 Offset: 0x23AF2B0 VA: 0x1823B08B0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x23B1530 Offset: 0x23AFF30 VA: 0x1823B1530 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x23B0760 Offset: 0x23AF160 VA: 0x1823B0760 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x23B0B60 Offset: 0x23AF560 VA: 0x1823B0B60 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x23B0CF0 Offset: 0x23AF6F0 VA: 0x1823B0CF0 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x23B13B0 Offset: 0x23AFDB0 VA: 0x1823B13B0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x23B0AD0 Offset: 0x23AF4D0 VA: 0x1823B0AD0 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x23B1280 Offset: 0x23AFC80 VA: 0x1823B1280 Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x23B1660 Offset: 0x23B0060 VA: 0x1823B1660 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x23B0C90 Offset: 0x23AF690 VA: 0x1823B0C90 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x23B07C0 Offset: 0x23AF1C0 VA: 0x1823B07C0 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x23B1750 Offset: 0x23B0150 VA: 0x1823B1750 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x23B0820 Offset: 0x23AF220 VA: 0x1823B0820 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x23B0480 Offset: 0x23AEE80 VA: 0x1823B0480
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x23B1170 Offset: 0x23AFB70 VA: 0x1823B1170
	protected void WriteMetaElement() { }

	// RVA: 0x23B1150 Offset: 0x23AFB50 VA: 0x1823B1150
	protected void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x23B0E20 Offset: 0x23AF820 VA: 0x1823B0E20
	protected void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x23B0E70 Offset: 0x23AF870 VA: 0x1823B0E70
	private void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x23B17B0 Offset: 0x23B01B0 VA: 0x1823B17B0
	private void WriteUriAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x23B06C0 Offset: 0x23AF0C0 VA: 0x1823B06C0
	private void OutputRestAmps() { }
}
