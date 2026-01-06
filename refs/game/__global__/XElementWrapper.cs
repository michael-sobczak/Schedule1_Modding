internal class XElementWrapper : XContainerWrapper, IXmlElement, IXmlNode // TypeDefIndex: 11428
{
	// Fields
	[Nullable(new[] { 2, 1 })]
	private List<IXmlNode> _attributes; // 0x20

	// Properties
	private XElement Element { get; }
	public override List<IXmlNode> Attributes { get; }
	[Nullable(2)]
	public override string Value { get; set; }
	[Nullable(2)]
	public override string LocalName { get; }
	[Nullable(2)]
	public override string NamespaceUri { get; }
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x1DF52B0 Offset: 0x1DF3CB0 VA: 0x181DF52B0
	private XElement get_Element() { }

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(XElement element) { }

	// RVA: 0x1DF4D50 Offset: 0x1DF3750 VA: 0x181DF4D50 Slot: 24
	public void SetAttributeNode(IXmlNode attribute) { }

	// RVA: 0x1DF4E50 Offset: 0x1DF3850 VA: 0x181DF4E50 Slot: 17
	public override List<IXmlNode> get_Attributes() { }

	// RVA: 0x1DF4A20 Offset: 0x1DF3420 VA: 0x181DF4A20
	private bool HasImplicitNamespaceAttribute(string namespaceUri) { }

	// RVA: 0x1DF4940 Offset: 0x1DF3340 VA: 0x181DF4940 Slot: 21
	public override IXmlNode AppendChild(IXmlNode newChild) { }

	[NullableContext(2)]
	// RVA: 0x1DF54A0 Offset: 0x1DF3EA0 VA: 0x181DF54A0 Slot: 19
	public override string get_Value() { }

	[NullableContext(2)]
	// RVA: 0x1DF5520 Offset: 0x1DF3F20 VA: 0x181DF5520 Slot: 20
	public override void set_Value(string value) { }

	[NullableContext(2)]
	// RVA: 0x1DF53A0 Offset: 0x1DF3DA0 VA: 0x181DF53A0 Slot: 15
	public override string get_LocalName() { }

	[NullableContext(2)]
	// RVA: 0x1DF5420 Offset: 0x1DF3E20 VA: 0x181DF5420 Slot: 22
	public override string get_NamespaceUri() { }

	// RVA: 0x1DF4980 Offset: 0x1DF3380 VA: 0x181DF4980 Slot: 25
	public string GetPrefixOfNamespace(string namespaceUri) { }

	// RVA: 0x1DF5320 Offset: 0x1DF3D20 VA: 0x181DF5320 Slot: 26
	public bool get_IsEmpty() { }
}
