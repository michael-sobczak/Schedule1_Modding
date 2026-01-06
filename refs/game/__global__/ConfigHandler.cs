internal class ConfigHandler : SmallXmlParser.IContentHandler // TypeDefIndex: 4282
{
	// Fields
	private ArrayList typeEntries; // 0x10
	private ArrayList channelInstances; // 0x18
	private ChannelData currentChannel; // 0x20
	private Stack currentProviderData; // 0x28
	private string currentClientUrl; // 0x30
	private string appName; // 0x38
	private string currentXmlPath; // 0x40
	private bool onlyDelayedChannels; // 0x48

	// Methods

	// RVA: 0x1B0AA50 Offset: 0x1B09450 VA: 0x181B0AA50
	public void .ctor(bool onlyDelayedChannels) { }

	// RVA: 0x1B0A960 Offset: 0x1B09360 VA: 0x181B0A960
	private void ValidatePath(string element, string[] paths) { }

	// RVA: 0x1B072D0 Offset: 0x1B05CD0 VA: 0x181B072D0
	private bool CheckPath(string path) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 4
	public void OnStartParsing(SmallXmlParser parser) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 8
	public void OnProcessingInstruction(string name, string text) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 10
	public void OnIgnorableWhitespace(string s) { }

	// RVA: 0x1B07760 Offset: 0x1B06160 VA: 0x181B07760 Slot: 6
	public void OnStartElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x1B078C0 Offset: 0x1B062C0 VA: 0x181B078C0
	public void ParseElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x1B075A0 Offset: 0x1B05FA0 VA: 0x181B075A0 Slot: 7
	public void OnEndElement(string name) { }

	// RVA: 0x1B09420 Offset: 0x1B07E20 VA: 0x181B09420
	private void ReadCustomProviderData(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x1B099B0 Offset: 0x1B083B0 VA: 0x181B099B0
	private void ReadLifetine(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x1B08680 Offset: 0x1B07080 VA: 0x181B08680
	private TimeSpan ParseTime(string s) { }

	// RVA: 0x1B08A00 Offset: 0x1B07400 VA: 0x181B08A00
	private void ReadChannel(SmallXmlParser.IAttrList attrs, bool isTemplate) { }

	// RVA: 0x1B09F90 Offset: 0x1B08990 VA: 0x181B09F90
	private ProviderData ReadProvider(string name, SmallXmlParser.IAttrList attrs, bool isTemplate) { }

	// RVA: 0x1B08F90 Offset: 0x1B07990 VA: 0x181B08F90
	private void ReadClientActivated(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x1B0A470 Offset: 0x1B08E70 VA: 0x181B0A470
	private void ReadServiceActivated(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x1B09200 Offset: 0x1B07C00 VA: 0x181B09200
	private void ReadClientWellKnown(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x1B0A650 Offset: 0x1B09050 VA: 0x181B0A650
	private void ReadServiceWellKnown(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x1B09800 Offset: 0x1B08200 VA: 0x181B09800
	private void ReadInteropXml(SmallXmlParser.IAttrList attrs, bool isElement) { }

	// RVA: 0x1B09D00 Offset: 0x1B08700 VA: 0x181B09D00
	private void ReadPreload(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x1B074C0 Offset: 0x1B05EC0 VA: 0x181B074C0
	private string GetNotNull(SmallXmlParser.IAttrList attrs, string name) { }

	// RVA: 0x1B073E0 Offset: 0x1B05DE0 VA: 0x181B073E0
	private string ExtractAssembly(ref string type) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 9
	public void OnChars(string ch) { }

	// RVA: 0x1B07650 Offset: 0x1B06050 VA: 0x181B07650 Slot: 5
	public void OnEndParsing(SmallXmlParser parser) { }
}
