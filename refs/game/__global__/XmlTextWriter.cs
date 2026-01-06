public class XmlTextWriter : XmlWriter // TypeDefIndex: 7991
{
	// Fields
	private TextWriter textWriter; // 0x18
	private XmlTextEncoder xmlEncoder; // 0x20
	private Encoding encoding; // 0x28
	private Formatting formatting; // 0x30
	private bool indented; // 0x34
	private int indentation; // 0x38
	private char indentChar; // 0x3C
	private XmlTextWriter.TagInfo[] stack; // 0x40
	private int top; // 0x48
	private XmlTextWriter.State[] stateTable; // 0x50
	private XmlTextWriter.State currentState; // 0x58
	private XmlTextWriter.Token lastToken; // 0x5C
	private XmlTextWriterBase64Encoder base64Encoder; // 0x60
	private char quoteChar; // 0x68
	private char curQuoteChar; // 0x6A
	private bool namespaces; // 0x6C
	private XmlTextWriter.SpecialAttr specialAttr; // 0x70
	private string prefixForXmlNs; // 0x78
	private bool flush; // 0x80
	private XmlTextWriter.Namespace[] nsStack; // 0x88
	private int nsTop; // 0x90
	private Dictionary<string, int> nsHashtable; // 0x98
	private bool useNsHashtable; // 0xA0
	private XmlCharType xmlCharType; // 0xA8
	private static string[] stateName; // 0x0
	private static string[] tokenName; // 0x8
	private static readonly XmlTextWriter.State[] stateTableDefault; // 0x10
	private static readonly XmlTextWriter.State[] stateTableDocument; // 0x18

	// Properties
	public Stream BaseStream { get; }
	public bool Namespaces { set; }
	public Formatting Formatting { set; }
	public char QuoteChar { set; }
	public override WriteState WriteState { get; }

	// Methods

	// RVA: 0x24D9CE0 Offset: 0x24D86E0 VA: 0x1824D9CE0
	internal void .ctor() { }

	// RVA: 0x24DA060 Offset: 0x24D8A60 VA: 0x1824DA060
	public void .ctor(Stream w, Encoding encoding) { }

	// RVA: 0x24D9F10 Offset: 0x24D8910 VA: 0x1824D9F10
	public void .ctor(string filename, Encoding encoding) { }

	// RVA: 0x24D9E40 Offset: 0x24D8840 VA: 0x1824D9E40
	public void .ctor(TextWriter w) { }

	// RVA: 0x24DA160 Offset: 0x24D8B60 VA: 0x1824DA160
	public Stream get_BaseStream() { }

	// RVA: 0x24DA260 Offset: 0x24D8C60 VA: 0x1824DA260
	public void set_Namespaces(bool value) { }

	// RVA: 0x24DA250 Offset: 0x24D8C50 VA: 0x1824DA250
	public void set_Formatting(Formatting value) { }

	// RVA: 0x24DA2E0 Offset: 0x24D8CE0 VA: 0x1824DA2E0
	public void set_QuoteChar(char value) { }

	// RVA: 0x24D8FA0 Offset: 0x24D79A0 VA: 0x1824D8FA0 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x24D8F80 Offset: 0x24D7980 VA: 0x1824D8F80 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x24D7E50 Offset: 0x24D6850 VA: 0x1824D7E50 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x24D79B0 Offset: 0x24D63B0 VA: 0x1824D79B0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x24D8FB0 Offset: 0x24D79B0 VA: 0x1824D8FB0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x24D7FF0 Offset: 0x24D69F0 VA: 0x1824D7FF0 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x24D8470 Offset: 0x24D6E70 VA: 0x1824D8470 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x24D8770 Offset: 0x24D7170 VA: 0x1824D8770 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x24D7E00 Offset: 0x24D6800 VA: 0x1824D7E00 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x24D7590 Offset: 0x24D5F90 VA: 0x1824D7590 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x24D7810 Offset: 0x24D6210 VA: 0x1824D7810 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x24D8480 Offset: 0x24D6E80 VA: 0x1824D8480 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x24D83F0 Offset: 0x24D6DF0 VA: 0x1824D83F0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x24D7700 Offset: 0x24D6100 VA: 0x1824D7700 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x24D9640 Offset: 0x24D8040 VA: 0x1824D9640 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x24D9530 Offset: 0x24D7F30 VA: 0x1824D9530 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x24D95B0 Offset: 0x24D7FB0 VA: 0x1824D95B0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x24D7770 Offset: 0x24D6170 VA: 0x1824D7770 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x24D8660 Offset: 0x24D7060 VA: 0x1824D8660 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x24D8700 Offset: 0x24D7100 VA: 0x1824D8700 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x24D73F0 Offset: 0x24D5DF0 VA: 0x1824D73F0 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x24D7500 Offset: 0x24D5F00 VA: 0x1824D7500 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x24DA1E0 Offset: 0x24D8BE0 VA: 0x1824DA1E0 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x24D5A50 Offset: 0x24D4450 VA: 0x1824D5A50 Slot: 28
	public override void Close() { }

	// RVA: 0x1C19CA0 Offset: 0x1C186A0 VA: 0x181C19CA0 Slot: 29
	public override void Flush() { }

	// RVA: 0x24D67C0 Offset: 0x24D51C0 VA: 0x1824D67C0 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0x24D6D90 Offset: 0x24D5790 VA: 0x1824D6D90
	private void StartDocument(int standalone) { }

	// RVA: 0x24D5440 Offset: 0x24D3E40 VA: 0x1824D5440
	private void AutoComplete(XmlTextWriter.Token token) { }

	// RVA: 0x24D53E0 Offset: 0x24D3DE0 VA: 0x1824D53E0
	private void AutoCompleteAll() { }

	// RVA: 0x24D6080 Offset: 0x24D4A80 VA: 0x1824D6080
	private void InternalWriteEndElement(bool longFormat) { }

	// RVA: 0x24D8000 Offset: 0x24D6A00 VA: 0x1824D8000
	private void WriteEndStartTag(bool empty) { }

	// RVA: 0x24D7DA0 Offset: 0x24D67A0 VA: 0x1824D7DA0
	private void WriteEndAttributeQuote() { }

	// RVA: 0x24D5F90 Offset: 0x24D4990 VA: 0x1824D5F90
	private void Indent(bool beforeEndElement) { }

	// RVA: 0x24D69D0 Offset: 0x24D53D0 VA: 0x1824D69D0
	private void PushNamespace(string prefix, string ns, bool declared) { }

	// RVA: 0x24D5120 Offset: 0x24D3B20 VA: 0x1824D5120
	private void AddNamespace(string prefix, string ns, bool declared) { }

	// RVA: 0x24D52F0 Offset: 0x24D3CF0 VA: 0x1824D52F0
	private void AddToNamespaceHashtable(int namespaceIndex) { }

	// RVA: 0x24D68D0 Offset: 0x24D52D0 VA: 0x1824D68D0
	private void PopNamespaces(int indexFrom, int indexTo) { }

	// RVA: 0x24D5C50 Offset: 0x24D4650 VA: 0x1824D5C50
	private string GeneratePrefix() { }

	// RVA: 0x24D6480 Offset: 0x24D4E80 VA: 0x1824D6480
	private void InternalWriteProcessingInstruction(string name, string text) { }

	// RVA: 0x24D66D0 Offset: 0x24D50D0 VA: 0x1824D66D0
	private int LookupNamespace(string prefix) { }

	// RVA: 0x24D6590 Offset: 0x24D4F90 VA: 0x1824D6590
	private int LookupNamespaceInCurrentScope(string prefix) { }

	// RVA: 0x24D5B20 Offset: 0x24D4520 VA: 0x1824D5B20
	private string FindPrefix(string ns) { }

	// RVA: 0x24D7090 Offset: 0x24D5A90 VA: 0x1824D7090
	private void ValidateName(string name, bool isNCName) { }

	// RVA: 0x24D5D50 Offset: 0x24D4750 VA: 0x1824D5D50
	private void HandleSpecialAttribute() { }

	// RVA: 0x24D72B0 Offset: 0x24D5CB0 VA: 0x1824D72B0
	private void VerifyPrefixXml(string prefix, string ns) { }

	// RVA: 0x24D6CC0 Offset: 0x24D56C0 VA: 0x1824D6CC0
	private void PushStack() { }

	// RVA: 0x24D5C10 Offset: 0x24D4610 VA: 0x1824D5C10
	private void FlushEncoders() { }

	// RVA: 0x24D9750 Offset: 0x24D8150 VA: 0x1824D9750
	private static void .cctor() { }
}
