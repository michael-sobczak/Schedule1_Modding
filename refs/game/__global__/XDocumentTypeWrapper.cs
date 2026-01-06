internal class XDocumentTypeWrapper : XObjectWrapper, IXmlDocumentType, IXmlNode // TypeDefIndex: 11420
{
	// Fields
	[Nullable(1)]
	private readonly XDocumentType _documentType; // 0x18

	// Properties
	[Nullable(1)]
	public string Name { get; }
	public string System { get; }
	public string Public { get; }
	public string InternalSubset { get; }
	public override string LocalName { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x1CF1F60 Offset: 0x1CF0960 VA: 0x181CF1F60
	public void .ctor(XDocumentType documentType) { }

	[NullableContext(1)]
	// RVA: 0x1DF3CB0 Offset: 0x1DF26B0 VA: 0x181DF3CB0 Slot: 23
	public string get_Name() { }

	// RVA: 0x1DF3CF0 Offset: 0x1DF26F0 VA: 0x181DF3CF0 Slot: 24
	public string get_System() { }

	// RVA: 0x1DF3CD0 Offset: 0x1DF26D0 VA: 0x181DF3CD0 Slot: 25
	public string get_Public() { }

	// RVA: 0x1DF3C60 Offset: 0x1DF2660 VA: 0x181DF3C60 Slot: 26
	public string get_InternalSubset() { }

	// RVA: 0x1DF3C80 Offset: 0x1DF2680 VA: 0x181DF3C80 Slot: 15
	public override string get_LocalName() { }
}
