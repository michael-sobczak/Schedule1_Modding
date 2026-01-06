internal sealed class XmlEventCache : XmlRawWriter // TypeDefIndex: 7961
{
	// Fields
	private List<XmlEventCache.XmlEvent[]> pages; // 0x28
	private XmlEventCache.XmlEvent[] pageCurr; // 0x30
	private int pageSize; // 0x38
	private bool hasRootNode; // 0x3C
	private StringConcat singleText; // 0x40
	private string baseUri; // 0x78

	// Methods

	// RVA: 0x24CE0A0 Offset: 0x24CCAA0 VA: 0x1824CE0A0
	public void .ctor(string baseUri, bool hasRootNode) { }

	// RVA: 0x24CCB40 Offset: 0x24CB540 VA: 0x1824CCB40
	public void EndEvents() { }

	// RVA: 0x24CCB90 Offset: 0x24CB590 VA: 0x1824CCB90
	public void EventsToWriter(XmlWriter writer) { }

	// RVA: 0x24CDAE0 Offset: 0x24CC4E0 VA: 0x1824CDAE0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x24CDDC0 Offset: 0x24CC7C0 VA: 0x1824CDDC0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x24CDD90 Offset: 0x24CC790 VA: 0x1824CDD90 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x24CDB90 Offset: 0x24CC590 VA: 0x1824CDB90 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x24CD980 Offset: 0x24CC380 VA: 0x1824CD980 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x24CDA80 Offset: 0x24CC480 VA: 0x1824CDA80 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x24CDD00 Offset: 0x24CC700 VA: 0x1824CDD00 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x24CDF40 Offset: 0x24CC940 VA: 0x1824CDF40 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x24CDDF0 Offset: 0x24CC7F0 VA: 0x1824CDDF0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x24C6D80 Offset: 0x24C5780 VA: 0x1824C6D80 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x24C7020 Offset: 0x24C5A20 VA: 0x1824C7020 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x24CDD30 Offset: 0x24CC730 VA: 0x1824CDD30 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x24CDC40 Offset: 0x24CC640 VA: 0x1824CDC40 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x24CD9E0 Offset: 0x24CC3E0 VA: 0x1824CD9E0 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x24CDE70 Offset: 0x24CC870 VA: 0x1824CDE70 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x24CD880 Offset: 0x24CC280 VA: 0x1824CD880 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x24CD900 Offset: 0x24CC300 VA: 0x1824CD900 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x24CCA50 Offset: 0x24CB450 VA: 0x1824CCA50 Slot: 28
	public override void Close() { }

	// RVA: 0x24CD5B0 Offset: 0x24CBFB0 VA: 0x1824CD5B0 Slot: 29
	public override void Flush() { }

	// RVA: 0xD53E50 Offset: 0xD52850 VA: 0x180D53E50 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0x24CCA90 Offset: 0x24CB490 VA: 0x1824CCA90 Slot: 34
	protected override void Dispose(bool disposing) { }

	// RVA: 0x24CDFA0 Offset: 0x24CC9A0 VA: 0x1824CDFA0 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x24CE040 Offset: 0x24CCA40 VA: 0x1824CE040 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x24CD780 Offset: 0x24CC180 VA: 0x1824CD780 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x24CDC10 Offset: 0x24CC610 VA: 0x1824CDC10 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x24CDCA0 Offset: 0x24CC6A0 VA: 0x1824CDCA0 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x24CDCD0 Offset: 0x24CC6D0 VA: 0x1824CDCD0 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x24CDBD0 Offset: 0x24CC5D0 VA: 0x1824CDBD0 Slot: 46
	internal override void WriteEndBase64() { }

	// RVA: 0x24CC7E0 Offset: 0x24CB1E0 VA: 0x1824CC7E0
	private void AddEvent(XmlEventCache.XmlEventType eventType) { }

	// RVA: 0x24CC950 Offset: 0x24CB350 VA: 0x1824CC950
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1) { }

	// RVA: 0x24CC9C0 Offset: 0x24CB3C0 VA: 0x1824CC9C0
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2) { }

	// RVA: 0x24CC740 Offset: 0x24CB140 VA: 0x1824CC740
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3) { }

	// RVA: 0x24CC8A0 Offset: 0x24CB2A0 VA: 0x1824CC8A0
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o) { }

	// RVA: 0x24CC830 Offset: 0x24CB230 VA: 0x1824CC830
	private void AddEvent(XmlEventCache.XmlEventType eventType, object o) { }

	// RVA: 0x24CD5F0 Offset: 0x24CBFF0 VA: 0x1824CD5F0
	private int NewEvent() { }

	// RVA: 0x24CD7C0 Offset: 0x24CC1C0 VA: 0x1824CD7C0
	private static byte[] ToBytes(byte[] buffer, int index, int count) { }
}
