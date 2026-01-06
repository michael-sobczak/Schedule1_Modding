internal class XDocumentWrapper : XContainerWrapper, IXmlDocument, IXmlNode // TypeDefIndex: 11421
{
	// Properties
	private XDocument Document { get; }
	public override List<IXmlNode> ChildNodes { get; }
	protected override bool HasChildNodes { get; }
	[Nullable(2)]
	public IXmlElement DocumentElement { get; }

	// Methods

	// RVA: 0x1DF4830 Offset: 0x1DF3230 VA: 0x181DF4830
	private XDocument get_Document() { }

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(XDocument document) { }

	// RVA: 0x1DF4590 Offset: 0x1DF2F90 VA: 0x181DF4590 Slot: 16
	public override List<IXmlNode> get_ChildNodes() { }

	// RVA: 0x1DF48A0 Offset: 0x1DF32A0 VA: 0x181DF48A0 Slot: 23
	protected override bool get_HasChildNodes() { }

	// RVA: 0x1DF3FC0 Offset: 0x1DF29C0 VA: 0x181DF3FC0 Slot: 24
	public IXmlNode CreateComment(string text) { }

	// RVA: 0x1DF42D0 Offset: 0x1DF2CD0 VA: 0x181DF42D0 Slot: 25
	public IXmlNode CreateTextNode(string text) { }

	// RVA: 0x1DF3F30 Offset: 0x1DF2930 VA: 0x181DF3F30 Slot: 26
	public IXmlNode CreateCDataSection(string data) { }

	// RVA: 0x1DF4360 Offset: 0x1DF2D60 VA: 0x181DF4360 Slot: 27
	public IXmlNode CreateWhitespace(string text) { }

	// RVA: 0x1DF4240 Offset: 0x1DF2C40 VA: 0x181DF4240 Slot: 28
	public IXmlNode CreateSignificantWhitespace(string text) { }

	// RVA: 0x1DF43F0 Offset: 0x1DF2DF0 VA: 0x181DF43F0 Slot: 29
	public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	[NullableContext(2)]
	// RVA: 0x1DF44C0 Offset: 0x1DF2EC0 VA: 0x181DF44C0 Slot: 30
	public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x1DF41A0 Offset: 0x1DF2BA0 VA: 0x181DF41A0 Slot: 31
	public IXmlNode CreateProcessingInstruction(string target, string data) { }

	// RVA: 0x1DF4050 Offset: 0x1DF2A50 VA: 0x181DF4050 Slot: 32
	public IXmlElement CreateElement(string elementName) { }

	// RVA: 0x1DF40F0 Offset: 0x1DF2AF0 VA: 0x181DF40F0 Slot: 33
	public IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	// RVA: 0x1DF3DC0 Offset: 0x1DF27C0 VA: 0x181DF3DC0 Slot: 34
	public IXmlNode CreateAttribute(string name, string value) { }

	// RVA: 0x1DF3E70 Offset: 0x1DF2870 VA: 0x181DF3E70 Slot: 35
	public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	[NullableContext(2)]
	// RVA: 0x1DF4730 Offset: 0x1DF3130 VA: 0x181DF4730 Slot: 36
	public IXmlElement get_DocumentElement() { }

	// RVA: 0x1DF3D10 Offset: 0x1DF2710 VA: 0x181DF3D10 Slot: 21
	public override IXmlNode AppendChild(IXmlNode newChild) { }
}
