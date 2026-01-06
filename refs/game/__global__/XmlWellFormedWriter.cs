internal class XmlWellFormedWriter : XmlWriter // TypeDefIndex: 8010
{
	// Fields
	private XmlWriter writer; // 0x18
	private XmlRawWriter rawWriter; // 0x20
	private IXmlNamespaceResolver predefinedNamespaces; // 0x28
	private XmlWellFormedWriter.Namespace[] nsStack; // 0x30
	private int nsTop; // 0x38
	private Dictionary<string, int> nsHashtable; // 0x40
	private bool useNsHashtable; // 0x48
	private XmlWellFormedWriter.ElementScope[] elemScopeStack; // 0x50
	private int elemTop; // 0x58
	private XmlWellFormedWriter.AttrName[] attrStack; // 0x60
	private int attrCount; // 0x68
	private Dictionary<string, int> attrHashTable; // 0x70
	private XmlWellFormedWriter.SpecialAttribute specAttr; // 0x78
	private XmlWellFormedWriter.AttributeValueCache attrValueCache; // 0x80
	private string curDeclPrefix; // 0x88
	private XmlWellFormedWriter.State[] stateTable; // 0x90
	private XmlWellFormedWriter.State currentState; // 0x98
	private bool checkCharacters; // 0x9C
	private bool omitDuplNamespaces; // 0x9D
	private bool writeEndDocumentOnClose; // 0x9E
	private ConformanceLevel conformanceLevel; // 0xA0
	private bool dtdWritten; // 0xA4
	private bool xmlDeclFollows; // 0xA5
	private XmlCharType xmlCharType; // 0xA8
	private SecureStringHasher hasher; // 0xB0
	internal static readonly string[] stateName; // 0x0
	internal static readonly string[] tokenName; // 0x8
	private static WriteState[] state2WriteState; // 0x10
	private static readonly XmlWellFormedWriter.State[] StateTableDocument; // 0x18
	private static readonly XmlWellFormedWriter.State[] StateTableAuto; // 0x20

	// Properties
	public override WriteState WriteState { get; }
	internal XmlRawWriter RawWriter { get; }
	private bool SaveAttrValue { get; }
	private bool InBase64 { get; }
	private bool IsClosedOrErrorState { get; }

	// Methods

	// RVA: 0x24E5D20 Offset: 0x24E4720 VA: 0x1824E5D20
	internal void .ctor(XmlWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x24E62E0 Offset: 0x24E4CE0 VA: 0x1824E62E0 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x24E4E40 Offset: 0x24E3840 VA: 0x1824E4E40 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x24E4E10 Offset: 0x24E3810 VA: 0x1824E4E10 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x24E3AD0 Offset: 0x24E24D0 VA: 0x1824E3AD0 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x24E2DA0 Offset: 0x24E17A0 VA: 0x1824E2DA0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x24E4E50 Offset: 0x24E3850 VA: 0x1824E4E50 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x24E3BE0 Offset: 0x24E25E0 VA: 0x1824E3BE0 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x24E3EC0 Offset: 0x24E28C0 VA: 0x1824E3EC0 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x24E45B0 Offset: 0x24E2FB0 VA: 0x1824E45B0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string namespaceName) { }

	// RVA: 0x24E3210 Offset: 0x24E1C10 VA: 0x1824E3210 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x24E28D0 Offset: 0x24E12D0 VA: 0x1824E28D0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x24E2CE0 Offset: 0x24E16E0 VA: 0x1824E2CE0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x24E4090 Offset: 0x24E2A90 VA: 0x1824E4090 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x24E3DB0 Offset: 0x24E27B0 VA: 0x1824E3DB0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x24E2990 Offset: 0x24E1390 VA: 0x1824E2990 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x24E5270 Offset: 0x24E3C70 VA: 0x1824E5270 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x24E5470 Offset: 0x24E3E70 VA: 0x1824E5470 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x24E51C0 Offset: 0x24E3BC0 VA: 0x1824E51C0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x24E2AD0 Offset: 0x24E14D0 VA: 0x1824E2AD0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x24E43A0 Offset: 0x24E2DA0 VA: 0x1824E43A0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x24E42F0 Offset: 0x24E2CF0 VA: 0x1824E42F0 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x24E2600 Offset: 0x24E1000 VA: 0x1824E2600 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x24E0CA0 Offset: 0x24DF6A0 VA: 0x1824E0CA0 Slot: 28
	public override void Close() { }

	// RVA: 0x24E0EE0 Offset: 0x24DF8E0 VA: 0x1824E0EE0 Slot: 29
	public override void Flush() { }

	// RVA: 0x24E14D0 Offset: 0x24DFED0 VA: 0x1824E14D0 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0x24E53B0 Offset: 0x24E3DB0 VA: 0x1824E53B0 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0x24E27E0 Offset: 0x24E11E0 VA: 0x1824E27E0 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	internal XmlRawWriter get_RawWriter() { }

	// RVA: 0x23FB8E0 Offset: 0x23FA2E0 VA: 0x1823FB8E0
	private bool get_SaveAttrValue() { }

	// RVA: 0x24E62B0 Offset: 0x24E4CB0 VA: 0x1824E62B0
	private bool get_InBase64() { }

	// RVA: 0x24E2150 Offset: 0x24E0B50 VA: 0x1824E2150
	private void SetSpecialAttribute(XmlWellFormedWriter.SpecialAttribute special) { }

	// RVA: 0x24E4C80 Offset: 0x24E3680 VA: 0x1824E4C80
	private void WriteStartDocumentImpl(XmlStandalone standalone) { }

	// RVA: 0x24E23D0 Offset: 0x24E0DD0 VA: 0x1824E23D0
	private void StartFragment() { }

	// RVA: 0x24E1CF0 Offset: 0x24E06F0 VA: 0x1824E1CF0
	private void PushNamespaceImplicit(string prefix, string ns) { }

	// RVA: 0x24E1780 Offset: 0x24E0180 VA: 0x1824E1780
	private bool PushNamespaceExplicit(string prefix, string ns) { }

	// RVA: 0x24E0360 Offset: 0x24DED60 VA: 0x1824E0360
	private void AddNamespace(string prefix, string ns, XmlWellFormedWriter.NamespaceKind kind) { }

	// RVA: 0x24E0640 Offset: 0x24DF040 VA: 0x1824E0640
	private void AddToNamespaceHashtable(int namespaceIndex) { }

	// RVA: 0x24E12F0 Offset: 0x24DFCF0 VA: 0x1824E12F0
	private int LookupNamespaceIndex(string prefix) { }

	// RVA: 0x24E1690 Offset: 0x24E0090 VA: 0x1824E1690
	private void PopNamespaces(int indexFrom, int indexTo) { }

	// RVA: 0x24E0DE0 Offset: 0x24DF7E0 VA: 0x1824E0DE0
	private static XmlException DupAttrException(string prefix, string localName) { }

	// RVA: 0x24E0720 Offset: 0x24DF120 VA: 0x1824E0720
	private void AdvanceState(XmlWellFormedWriter.Token token) { }

	// RVA: 0x24E21F0 Offset: 0x24E0BF0 VA: 0x1824E21F0
	private void StartElementContent() { }

	// RVA: 0x24E1080 Offset: 0x24DFA80 VA: 0x1824E1080
	private static string GetStateName(XmlWellFormedWriter.State state) { }

	// RVA: 0x24E13E0 Offset: 0x24DFDE0 VA: 0x1824E13E0
	internal string LookupNamespace(string prefix) { }

	// RVA: 0x24E1230 Offset: 0x24DFC30 VA: 0x1824E1230
	private string LookupLocalNamespace(string prefix) { }

	// RVA: 0x24E0F40 Offset: 0x24DF940 VA: 0x1824E0F40
	private string GeneratePrefix() { }

	// RVA: 0x24E0B50 Offset: 0x24DF550 VA: 0x1824E0B50
	private void CheckNCName(string ncname) { }

	// RVA: 0x24E1110 Offset: 0x24DFB10 VA: 0x1824E1110
	private static Exception InvalidCharsException(string name, int badCharIndex) { }

	// RVA: 0x24E23E0 Offset: 0x24E0DE0 VA: 0x1824E23E0
	private void ThrowInvalidStateTransition(XmlWellFormedWriter.Token token, XmlWellFormedWriter.State currentState) { }

	// RVA: 0x24E62D0 Offset: 0x24E4CD0 VA: 0x1824E62D0
	private bool get_IsClosedOrErrorState() { }

	// RVA: 0x24E0080 Offset: 0x24DEA80 VA: 0x1824E0080
	private void AddAttribute(string prefix, string localName, string namespaceName) { }

	// RVA: 0x24E04F0 Offset: 0x24DEEF0 VA: 0x1824E04F0
	private void AddToAttrHashTable(int attributeIndex) { }

	// RVA: 0x24E55C0 Offset: 0x24E3FC0 VA: 0x1824E55C0
	private static void .cctor() { }
}
