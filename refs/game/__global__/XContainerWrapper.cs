internal class XContainerWrapper : XObjectWrapper // TypeDefIndex: 11425
{
	// Fields
	[Nullable(new[] { 2, 1 })]
	private List<IXmlNode> _childNodes; // 0x18

	// Properties
	private XContainer Container { get; }
	public override List<IXmlNode> ChildNodes { get; }
	protected virtual bool HasChildNodes { get; }
	[Nullable(2)]
	public override IXmlNode ParentNode { get; }

	// Methods

	// RVA: 0x1DF39C0 Offset: 0x1DF23C0 VA: 0x181DF39C0
	private XContainer get_Container() { }

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(XContainer container) { }

	// RVA: 0x1DF3690 Offset: 0x1DF2090 VA: 0x181DF3690 Slot: 16
	public override List<IXmlNode> get_ChildNodes() { }

	// RVA: 0x1DF3A30 Offset: 0x1DF2430 VA: 0x181DF3A30 Slot: 23
	protected virtual bool get_HasChildNodes() { }

	[NullableContext(2)]
	// RVA: 0x1DF3AB0 Offset: 0x1DF24B0 VA: 0x181DF3AB0 Slot: 18
	public override IXmlNode get_ParentNode() { }

	// RVA: 0x1DF33A0 Offset: 0x1DF1DA0 VA: 0x181DF33A0
	internal static IXmlNode WrapNode(XObject node) { }

	// RVA: 0x1DF32B0 Offset: 0x1DF1CB0 VA: 0x181DF32B0 Slot: 21
	public override IXmlNode AppendChild(IXmlNode newChild) { }
}
