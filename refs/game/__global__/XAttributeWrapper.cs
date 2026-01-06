internal class XAttributeWrapper : XObjectWrapper // TypeDefIndex: 11427
{
	// Properties
	[Nullable(1)]
	private XAttribute Attribute { get; }
	public override string Value { get; set; }
	public override string LocalName { get; }
	public override string NamespaceUri { get; }
	public override IXmlNode ParentNode { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x1DF2CF0 Offset: 0x1DF16F0 VA: 0x181DF2CF0
	private XAttribute get_Attribute() { }

	[NullableContext(1)]
	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(XAttribute attribute) { }

	// RVA: 0x1DF2F10 Offset: 0x1DF1910 VA: 0x181DF2F10 Slot: 19
	public override string get_Value() { }

	// RVA: 0x1DF2F90 Offset: 0x1DF1990 VA: 0x181DF2F90 Slot: 20
	public override void set_Value(string value) { }

	// RVA: 0x1DF2D60 Offset: 0x1DF1760 VA: 0x181DF2D60 Slot: 15
	public override string get_LocalName() { }

	// RVA: 0x1DF2DE0 Offset: 0x1DF17E0 VA: 0x181DF2DE0 Slot: 22
	public override string get_NamespaceUri() { }

	// RVA: 0x1DF2E60 Offset: 0x1DF1860 VA: 0x181DF2E60 Slot: 18
	public override IXmlNode get_ParentNode() { }
}
