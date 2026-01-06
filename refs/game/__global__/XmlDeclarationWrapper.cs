internal class XmlDeclarationWrapper : XmlNodeWrapper, IXmlDeclaration, IXmlNode // TypeDefIndex: 11411
{
	// Fields
	[Nullable(1)]
	private readonly XmlDeclaration _declaration; // 0x28

	// Properties
	public string Version { get; }
	public string Encoding { get; set; }
	public string Standalone { get; set; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x1DF5BB0 Offset: 0x1DF45B0 VA: 0x181DF5BB0
	public void .ctor(XmlDeclaration declaration) { }

	// RVA: 0x1DF5C20 Offset: 0x1DF4620 VA: 0x181DF5C20 Slot: 16
	public string get_Version() { }

	// RVA: 0x1DF5C00 Offset: 0x1DF4600 VA: 0x181DF5C00 Slot: 17
	public string get_Encoding() { }

	// RVA: 0x1DF5C40 Offset: 0x1DF4640 VA: 0x181DF5C40 Slot: 18
	public void set_Encoding(string value) { }

	// RVA: 0x5303F0 Offset: 0x52EDF0 VA: 0x1805303F0 Slot: 19
	public string get_Standalone() { }

	// RVA: 0x1DF5C60 Offset: 0x1DF4660 VA: 0x181DF5C60 Slot: 20
	public void set_Standalone(string value) { }
}
