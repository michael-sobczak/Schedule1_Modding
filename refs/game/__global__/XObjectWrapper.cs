internal class XObjectWrapper : IXmlNode // TypeDefIndex: 11426
{
	// Fields
	private readonly XObject _xmlObject; // 0x10

	// Properties
	public object WrappedNode { get; }
	public virtual XmlNodeType NodeType { get; }
	public virtual string LocalName { get; }
	[Nullable(1)]
	public virtual List<IXmlNode> ChildNodes { get; }
	[Nullable(1)]
	public virtual List<IXmlNode> Attributes { get; }
	public virtual IXmlNode ParentNode { get; }
	public virtual string Value { get; set; }
	public virtual string NamespaceUri { get; }

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(XObject xmlObject) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 13
	public object get_WrappedNode() { }

	// RVA: 0x1DF56C0 Offset: 0x1DF40C0 VA: 0x181DF56C0 Slot: 14
	public virtual XmlNodeType get_NodeType() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 15
	public virtual string get_LocalName() { }

	[NullableContext(1)]
	// RVA: 0x1DF5670 Offset: 0x1DF4070 VA: 0x181DF5670 Slot: 16
	public virtual List<IXmlNode> get_ChildNodes() { }

	[NullableContext(1)]
	// RVA: 0x1DF5620 Offset: 0x1DF4020 VA: 0x181DF5620 Slot: 17
	public virtual List<IXmlNode> get_Attributes() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 18
	public virtual IXmlNode get_ParentNode() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 19
	public virtual string get_Value() { }

	// RVA: 0x1DF56E0 Offset: 0x1DF40E0 VA: 0x181DF56E0 Slot: 20
	public virtual void set_Value(string value) { }

	[NullableContext(1)]
	// RVA: 0x1DF55E0 Offset: 0x1DF3FE0 VA: 0x181DF55E0 Slot: 21
	public virtual IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 22
	public virtual string get_NamespaceUri() { }
}
