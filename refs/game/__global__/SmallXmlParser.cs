internal class SmallXmlParser // TypeDefIndex: 3489
{
	// Fields
	private SmallXmlParser.IContentHandler handler; // 0x10
	private TextReader reader; // 0x18
	private Stack elementNames; // 0x20
	private Stack xmlSpaces; // 0x28
	private string xmlSpace; // 0x30
	private StringBuilder buffer; // 0x38
	private char[] nameBuffer; // 0x40
	private bool isWhitespace; // 0x48
	private SmallXmlParser.AttrListImpl attributes; // 0x50
	private int line; // 0x58
	private int column; // 0x5C
	private bool resetColumn; // 0x60

	// Methods

	// RVA: 0x1A97270 Offset: 0x1A95C70 VA: 0x181A97270
	public void .ctor() { }

	// RVA: 0x1A94C30 Offset: 0x1A93630 VA: 0x181A94C30
	private Exception Error(string msg) { }

	// RVA: 0x1A97190 Offset: 0x1A95B90 VA: 0x181A97190
	private Exception UnexpectedEndError() { }

	// RVA: 0x1A95030 Offset: 0x1A93A30 VA: 0x181A95030
	private bool IsNameChar(char c, bool start) { }

	// RVA: 0x1A95140 Offset: 0x1A93B40 VA: 0x181A95140
	private bool IsWhitespace(int c) { }

	// RVA: 0x1A970A0 Offset: 0x1A95AA0 VA: 0x181A970A0
	public void SkipWhitespaces() { }

	// RVA: 0x1A94F20 Offset: 0x1A93920 VA: 0x181A94F20
	private void HandleWhitespaces() { }

	// RVA: 0x1A970B0 Offset: 0x1A95AB0 VA: 0x181A970B0
	public void SkipWhitespaces(bool expected) { }

	// RVA: 0x1A95370 Offset: 0x1A93D70 VA: 0x181A95370
	private int Peek() { }

	// RVA: 0x1A97040 Offset: 0x1A95A40 VA: 0x181A97040
	private int Read() { }

	// RVA: 0x1A94D20 Offset: 0x1A93720 VA: 0x181A94D20
	public void Expect(int c) { }

	// RVA: 0x1A96F00 Offset: 0x1A95900 VA: 0x181A96F00
	private string ReadUntil(char until, bool handleReferences) { }

	// RVA: 0x1A96A60 Offset: 0x1A95460 VA: 0x181A96A60
	public string ReadName() { }

	// RVA: 0x1A95160 Offset: 0x1A93B60 VA: 0x181A95160
	public void Parse(TextReader input, SmallXmlParser.IContentHandler handler) { }

	// RVA: 0x1A94B70 Offset: 0x1A93570 VA: 0x181A94B70
	private void Cleanup() { }

	// RVA: 0x1A95BC0 Offset: 0x1A945C0 VA: 0x181A95BC0
	public void ReadContent() { }

	// RVA: 0x1A94E50 Offset: 0x1A93850 VA: 0x181A94E50
	private void HandleBufferedContent() { }

	// RVA: 0x1A95950 Offset: 0x1A94350 VA: 0x181A95950
	private void ReadCharacters() { }

	// RVA: 0x1A96C90 Offset: 0x1A95690 VA: 0x181A96C90
	private void ReadReference() { }

	// RVA: 0x1A95760 Offset: 0x1A94160 VA: 0x181A95760
	private int ReadCharacterReference() { }

	// RVA: 0x1A953A0 Offset: 0x1A93DA0 VA: 0x181A953A0
	private void ReadAttribute(SmallXmlParser.AttrListImpl a) { }

	// RVA: 0x1A95610 Offset: 0x1A94010 VA: 0x181A95610
	private void ReadCDATASection() { }

	// RVA: 0x1A95A70 Offset: 0x1A94470 VA: 0x181A95A70
	private void ReadComment() { }
}
