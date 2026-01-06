internal class XmlDocumentWrapper : XmlNodeWrapper, IXmlDocument, IXmlNode // TypeDefIndex: 11409
{
	// Fields
	private readonly XmlDocument _document; // 0x28

	// Properties
	[Nullable(2)]
	public IXmlElement DocumentElement { get; }

	// Methods

	// RVA: 0x1DF5BB0 Offset: 0x1DF45B0 VA: 0x181DF5BB0
	public void .ctor(XmlDocument document) { }

	// RVA: 0x1DF5EE0 Offset: 0x1DF48E0 VA: 0x181DF5EE0 Slot: 16
	public IXmlNode CreateComment(string data) { }

	// RVA: 0x1DF61D0 Offset: 0x1DF4BD0 VA: 0x181DF61D0 Slot: 17
	public IXmlNode CreateTextNode(string text) { }

	// RVA: 0x1DF5E50 Offset: 0x1DF4850 VA: 0x181DF5E50 Slot: 18
	public IXmlNode CreateCDataSection(string data) { }

	// RVA: 0x1DF6260 Offset: 0x1DF4C60 VA: 0x181DF6260 Slot: 19
	public IXmlNode CreateWhitespace(string text) { }

	// RVA: 0x1DF6140 Offset: 0x1DF4B40 VA: 0x181DF6140 Slot: 20
	public IXmlNode CreateSignificantWhitespace(string text) { }

	// RVA: 0x1DF62F0 Offset: 0x1DF4CF0 VA: 0x181DF62F0 Slot: 21
	public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	[NullableContext(2)]
	// RVA: 0x1DF63C0 Offset: 0x1DF4DC0 VA: 0x181DF63C0 Slot: 22
	public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x1DF60A0 Offset: 0x1DF4AA0 VA: 0x181DF60A0 Slot: 23
	public IXmlNode CreateProcessingInstruction(string target, string data) { }

	// RVA: 0x1DF5F70 Offset: 0x1DF4970 VA: 0x181DF5F70 Slot: 24
	public IXmlElement CreateElement(string elementName) { }

	// RVA: 0x1DF6000 Offset: 0x1DF4A00 VA: 0x181DF6000 Slot: 25
	public IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	// RVA: 0x1DF5CE0 Offset: 0x1DF46E0 VA: 0x181DF5CE0 Slot: 26
	public IXmlNode CreateAttribute(string name, string value) { }

	// RVA: 0x1DF5D90 Offset: 0x1DF4790 VA: 0x181DF5D90 Slot: 27
	public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	[NullableContext(2)]
	// RVA: 0x1DF6490 Offset: 0x1DF4E90 VA: 0x181DF6490 Slot: 28
	public IXmlElement get_DocumentElement() { }
}
