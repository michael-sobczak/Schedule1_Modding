internal class SecurityParser : SmallXmlParser, SmallXmlParser.IContentHandler // TypeDefIndex: 3485
{
	// Fields
	private SecurityElement root; // 0x68
	private SecurityElement current; // 0x70
	private Stack stack; // 0x78

	// Methods

	// RVA: 0x1A8ECD0 Offset: 0x1A8D6D0 VA: 0x181A8ECD0
	public void .ctor() { }

	// RVA: 0x1A8E7B0 Offset: 0x1A8D1B0 VA: 0x181A8E7B0
	public void LoadXml(string xml) { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public SecurityElement ToXml() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 4
	public void OnStartParsing(SmallXmlParser parser) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 8
	public void OnProcessingInstruction(string name, string text) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 10
	public void OnIgnorableWhitespace(string s) { }

	// RVA: 0x1A8E9A0 Offset: 0x1A8D3A0 VA: 0x181A8E9A0 Slot: 6
	public void OnStartElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x1A8E8E0 Offset: 0x1A8D2E0 VA: 0x181A8E8E0 Slot: 7
	public void OnEndElement(string name) { }

	// RVA: 0x1A8E860 Offset: 0x1A8D260 VA: 0x181A8E860 Slot: 9
	public void OnChars(string ch) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public void OnEndParsing(SmallXmlParser parser) { }
}
