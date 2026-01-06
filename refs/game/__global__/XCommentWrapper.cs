internal class XCommentWrapper : XObjectWrapper // TypeDefIndex: 11423
{
	// Properties
	[Nullable(1)]
	private XComment Text { get; }
	public override string Value { get; set; }
	public override IXmlNode ParentNode { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x1DF3100 Offset: 0x1DF1B00 VA: 0x181DF3100
	private XComment get_Text() { }

	[NullableContext(1)]
	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(XComment text) { }

	// RVA: 0x1DF3170 Offset: 0x1DF1B70 VA: 0x181DF3170 Slot: 19
	public override string get_Value() { }

	// RVA: 0x1DF31F0 Offset: 0x1DF1BF0 VA: 0x181DF31F0 Slot: 20
	public override void set_Value(string value) { }

	// RVA: 0x1DF3050 Offset: 0x1DF1A50 VA: 0x181DF3050 Slot: 18
	public override IXmlNode get_ParentNode() { }
}
