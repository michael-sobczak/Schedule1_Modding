internal class XTextWrapper : XObjectWrapper // TypeDefIndex: 11422
{
	// Properties
	[Nullable(1)]
	private XText Text { get; }
	public override string Value { get; set; }
	public override IXmlNode ParentNode { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x1DF5A00 Offset: 0x1DF4400 VA: 0x181DF5A00
	private XText get_Text() { }

	[NullableContext(1)]
	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(XText text) { }

	// RVA: 0x1DF5A70 Offset: 0x1DF4470 VA: 0x181DF5A70 Slot: 19
	public override string get_Value() { }

	// RVA: 0x1DF5AF0 Offset: 0x1DF44F0 VA: 0x181DF5AF0 Slot: 20
	public override void set_Value(string value) { }

	// RVA: 0x1DF5950 Offset: 0x1DF4350 VA: 0x181DF5950 Slot: 18
	public override IXmlNode get_ParentNode() { }
}
