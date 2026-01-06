internal class XmlNodeWrapper : IXmlNode // TypeDefIndex: 11413
{
	// Fields
	[Nullable(1)]
	private readonly XmlNode _node; // 0x10
	[Nullable(new[] { 2, 1 })]
	private List<IXmlNode> _childNodes; // 0x18
	[Nullable(new[] { 2, 1 })]
	private List<IXmlNode> _attributes; // 0x20

	// Properties
	public object WrappedNode { get; }
	public XmlNodeType NodeType { get; }
	public virtual string LocalName { get; }
	[Nullable(1)]
	public List<IXmlNode> ChildNodes { get; }
	protected virtual bool HasChildNodes { get; }
	[Nullable(1)]
	public List<IXmlNode> Attributes { get; }
	private bool HasAttributes { get; }
	public IXmlNode ParentNode { get; }
	public string Value { get; set; }
	public string NamespaceUri { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(XmlNode node) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 13
	public object get_WrappedNode() { }

	// RVA: 0x1B56640 Offset: 0x1B55040 VA: 0x181B56640 Slot: 4
	public XmlNodeType get_NodeType() { }

	// RVA: 0x1DFDAB0 Offset: 0x1DFC4B0 VA: 0x181DFDAB0 Slot: 14
	public virtual string get_LocalName() { }

	[NullableContext(1)]
	// RVA: 0x1DFD5F0 Offset: 0x1DFBFF0 VA: 0x181DFD5F0 Slot: 6
	public List<IXmlNode> get_ChildNodes() { }

	// RVA: 0x1DFDA80 Offset: 0x1DFC480 VA: 0x181DFDA80 Slot: 15
	protected virtual bool get_HasChildNodes() { }

	[NullableContext(1)]
	// RVA: 0x1DFCFB0 Offset: 0x1DFB9B0 VA: 0x181DFCFB0
	internal static IXmlNode WrapNode(XmlNode node) { }

	[NullableContext(1)]
	// RVA: 0x1DFD1A0 Offset: 0x1DFBBA0 VA: 0x181DFD1A0 Slot: 7
	public List<IXmlNode> get_Attributes() { }

	// RVA: 0x1DFD9C0 Offset: 0x1DFC3C0 VA: 0x181DFD9C0
	private bool get_HasAttributes() { }

	// RVA: 0x1DFDAE0 Offset: 0x1DFC4E0 VA: 0x181DFDAE0 Slot: 8
	public IXmlNode get_ParentNode() { }

	// RVA: 0x1B56580 Offset: 0x1B54F80 VA: 0x181B56580 Slot: 9
	public string get_Value() { }

	// RVA: 0x1DFDB90 Offset: 0x1DFC590 VA: 0x181DFDB90 Slot: 10
	public void set_Value(string value) { }

	[NullableContext(1)]
	// RVA: 0x1DFCEF0 Offset: 0x1DFB8F0 VA: 0x181DFCEF0 Slot: 11
	public IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0x1BFEC60 Offset: 0x1BFD660 VA: 0x181BFEC60 Slot: 12
	public string get_NamespaceUri() { }
}
