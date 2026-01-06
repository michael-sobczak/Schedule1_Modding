internal class XmlDocumentTypeWrapper : XmlNodeWrapper, IXmlDocumentType, IXmlNode // TypeDefIndex: 11412
{
	// Fields
	[Nullable(1)]
	private readonly XmlDocumentType _documentType; // 0x28

	// Properties
	[Nullable(1)]
	public string Name { get; }
	public string System { get; }
	public string Public { get; }
	public string InternalSubset { get; }
	public override string LocalName { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x1DF5BB0 Offset: 0x1DF45B0 VA: 0x181DF5BB0
	public void .ctor(XmlDocumentType documentType) { }

	[NullableContext(1)]
	// RVA: 0x1DF5CB0 Offset: 0x1DF46B0 VA: 0x181DF5CB0 Slot: 16
	public string get_Name() { }

	// RVA: 0x5303F0 Offset: 0x52EDF0 VA: 0x1805303F0 Slot: 17
	public string get_System() { }

	// RVA: 0x1DF5C00 Offset: 0x1DF4600 VA: 0x181DF5C00 Slot: 18
	public string get_Public() { }

	// RVA: 0x530380 Offset: 0x52ED80 VA: 0x180530380 Slot: 19
	public string get_InternalSubset() { }

	// RVA: 0x1DF5C80 Offset: 0x1DF4680 VA: 0x181DF5C80 Slot: 14
	public override string get_LocalName() { }
}
