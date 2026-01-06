public abstract class XmlNode : ICloneable, IEnumerable, IXPathNavigable // TypeDefIndex: 8059
{
	// Fields
	internal XmlNode parentNode; // 0x10

	// Properties
	public abstract string Name { get; }
	public virtual string Value { get; set; }
	public abstract XmlNodeType NodeType { get; }
	public virtual XmlNode ParentNode { get; }
	public virtual XmlNodeList ChildNodes { get; }
	public virtual XmlNode PreviousSibling { get; }
	public virtual XmlNode NextSibling { get; }
	public virtual XmlAttributeCollection Attributes { get; }
	public virtual XmlDocument OwnerDocument { get; }
	public virtual XmlNode FirstChild { get; }
	public virtual XmlNode LastChild { get; }
	internal virtual bool IsContainer { get; }
	internal virtual XmlLinkedNode LastNode { get; set; }
	public virtual bool HasChildNodes { get; }
	public virtual string NamespaceURI { get; }
	public virtual string Prefix { get; set; }
	public abstract string LocalName { get; }
	public virtual bool IsReadOnly { get; }
	public virtual string InnerText { get; set; }
	public virtual string InnerXml { set; }
	public virtual IXmlSchemaInfo SchemaInfo { get; }
	public virtual string BaseURI { get; }
	internal XmlDocument Document { get; }
	internal virtual XmlSpace XmlSpace { get; }
	internal virtual string XmlLang { get; }
	internal virtual XPathNodeType XPNodeType { get; }
	internal virtual string XPLocalName { get; }
	internal virtual bool IsText { get; }
	public virtual XmlNode PreviousText { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	// RVA: 0x251EE70 Offset: 0x251D870 VA: 0x18251EE70
	internal void .ctor(XmlDocument doc) { }

	// RVA: 0x251CD00 Offset: 0x251B700 VA: 0x18251CD00 Slot: 7
	public virtual XPathNavigator CreateNavigator() { }

	// RVA: 0x251EBC0 Offset: 0x251D5C0 VA: 0x18251EBC0
	public XmlNode SelectSingleNode(string xpath) { }

	// RVA: 0x251EB20 Offset: 0x251D520 VA: 0x18251EB20
	public XmlNodeList SelectNodes(string xpath) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_Name();

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 9
	public virtual string get_Value() { }

	// RVA: 0x251FA50 Offset: 0x251E450 VA: 0x18251FA50 Slot: 10
	public virtual void set_Value(string value) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract XmlNodeType get_NodeType();

	// RVA: 0x251F4A0 Offset: 0x251DEA0 VA: 0x18251F4A0 Slot: 12
	public virtual XmlNode get_ParentNode() { }

	// RVA: 0x251F010 Offset: 0x251DA10 VA: 0x18251F010 Slot: 13
	public virtual XmlNodeList get_ChildNodes() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 14
	public virtual XmlNode get_PreviousSibling() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 15
	public virtual XmlNode get_NextSibling() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 16
	public virtual XmlAttributeCollection get_Attributes() { }

	// RVA: 0x251F3E0 Offset: 0x251DDE0 VA: 0x18251F3E0 Slot: 17
	public virtual XmlDocument get_OwnerDocument() { }

	// RVA: 0x251F110 Offset: 0x251DB10 VA: 0x18251F110 Slot: 18
	public virtual XmlNode get_FirstChild() { }

	// RVA: 0x251F380 Offset: 0x251DD80 VA: 0x18251F380 Slot: 19
	public virtual XmlNode get_LastChild() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 20
	internal virtual bool get_IsContainer() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 21
	internal virtual XmlLinkedNode get_LastNode() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 22
	internal virtual void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x251C1E0 Offset: 0x251ABE0 VA: 0x18251C1E0
	internal bool AncestorNode(XmlNode node) { }

	// RVA: 0x251E500 Offset: 0x251CF00 VA: 0x18251E500
	internal bool IsConnected() { }

	// RVA: 0x251DD20 Offset: 0x251C720 VA: 0x18251DD20 Slot: 23
	public virtual XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x251D560 Offset: 0x251BF60 VA: 0x18251D560 Slot: 24
	public virtual XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x251E670 Offset: 0x251D070 VA: 0x18251E670 Slot: 25
	public virtual XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x251E5A0 Offset: 0x251CFA0 VA: 0x18251E5A0 Slot: 26
	public virtual XmlNode PrependChild(XmlNode newChild) { }

	// RVA: 0x251C590 Offset: 0x251AF90 VA: 0x18251C590 Slot: 27
	public virtual XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x251C260 Offset: 0x251AC60 VA: 0x18251C260 Slot: 28
	internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 29
	internal virtual bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 30
	internal virtual bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 31
	internal virtual bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x251F140 Offset: 0x251DB40 VA: 0x18251F140 Slot: 32
	public virtual bool get_HasChildNodes() { }

	// RVA: -1 Offset: -1 Slot: 33
	public abstract XmlNode CloneNode(bool deep);

	// RVA: 0x251CC40 Offset: 0x251B640 VA: 0x18251CC40 Slot: 34
	internal virtual void CopyChildren(XmlDocument doc, XmlNode container, bool deep) { }

	// RVA: 0x251F3A0 Offset: 0x251DDA0 VA: 0x18251F3A0 Slot: 35
	public virtual string get_NamespaceURI() { }

	// RVA: 0x251F5A0 Offset: 0x251DFA0 VA: 0x18251F5A0 Slot: 36
	public virtual string get_Prefix() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 37
	public virtual void set_Prefix(string value) { }

	// RVA: -1 Offset: -1 Slot: 38
	public abstract string get_LocalName();

	// RVA: 0x251F2A0 Offset: 0x251DCA0 VA: 0x18251F2A0 Slot: 39
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x251D490 Offset: 0x251BE90 VA: 0x18251D490
	internal static bool HasReadOnlyParent(XmlNode n) { }

	// RVA: 0x251EE00 Offset: 0x251D800 VA: 0x18251EE00 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x251EDA0 Offset: 0x251D7A0 VA: 0x18251EDA0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x251CE50 Offset: 0x251B850 VA: 0x18251CE50
	public IEnumerator GetEnumerator() { }

	// RVA: 0x251C460 Offset: 0x251AE60 VA: 0x18251C460
	private void AppendChildText(StringBuilder builder) { }

	// RVA: 0x251F170 Offset: 0x251DB70 VA: 0x18251F170 Slot: 40
	public virtual string get_InnerText() { }

	// RVA: 0x251F8E0 Offset: 0x251E2E0 VA: 0x18251F8E0 Slot: 41
	public virtual void set_InnerText(string value) { }

	// RVA: 0x251F9F0 Offset: 0x251E3F0 VA: 0x18251F9F0 Slot: 42
	public virtual void set_InnerXml(string value) { }

	// RVA: 0x251F5E0 Offset: 0x251DFE0 VA: 0x18251F5E0 Slot: 43
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x251EF00 Offset: 0x251D900 VA: 0x18251EF00 Slot: 44
	public virtual string get_BaseURI() { }

	// RVA: -1 Offset: -1 Slot: 45
	public abstract void WriteTo(XmlWriter w);

	// RVA: -1 Offset: -1 Slot: 46
	public abstract void WriteContentTo(XmlWriter w);

	// RVA: 0x251E5F0 Offset: 0x251CFF0 VA: 0x18251E5F0 Slot: 47
	public virtual void RemoveAll() { }

	// RVA: 0x251F070 Offset: 0x251DA70 VA: 0x18251F070
	internal XmlDocument get_Document() { }

	// RVA: 0x251D430 Offset: 0x251BE30 VA: 0x18251D430 Slot: 48
	public virtual string GetPrefixOfNamespace(string namespaceURI) { }

	// RVA: 0x251CFF0 Offset: 0x251B9F0 VA: 0x18251CFF0
	internal string GetPrefixOfNamespaceStrict(string namespaceURI) { }

	// RVA: 0x251EC80 Offset: 0x251D680 VA: 0x18251EC80 Slot: 49
	internal virtual void SetParent(XmlNode node) { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0 Slot: 50
	internal virtual void SetParentForLoad(XmlNode node) { }

	// RVA: 0x251ECC0 Offset: 0x251D6C0 VA: 0x18251ECC0
	internal static void SplitName(string name, out string prefix, out string localName) { }

	// RVA: 0x251CDC0 Offset: 0x251B7C0 VA: 0x18251CDC0 Slot: 51
	internal virtual XmlNode FindChild(XmlNodeType type) { }

	// RVA: 0x251CEB0 Offset: 0x251B8B0 VA: 0x18251CEB0 Slot: 52
	internal virtual XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x251CBF0 Offset: 0x251B5F0 VA: 0x18251CBF0 Slot: 53
	internal virtual void BeforeEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x251C190 Offset: 0x251AB90 VA: 0x18251C190 Slot: 54
	internal virtual void AfterEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x251F760 Offset: 0x251E160 VA: 0x18251F760 Slot: 55
	internal virtual XmlSpace get_XmlSpace() { }

	// RVA: 0x251F670 Offset: 0x251E070 VA: 0x18251F670 Slot: 56
	internal virtual string get_XmlLang() { }

	// RVA: 0xB0B490 Offset: 0xB09E90 VA: 0x180B0B490 Slot: 57
	internal virtual XPathNodeType get_XPNodeType() { }

	// RVA: 0x251F630 Offset: 0x251E030 VA: 0x18251F630 Slot: 58
	internal virtual string get_XPLocalName() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 59
	internal virtual bool get_IsText() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 60
	public virtual XmlNode get_PreviousText() { }

	// RVA: 0x251E570 Offset: 0x251CF70 VA: 0x18251E570
	internal static void NestTextNodes(XmlNode prevNode, XmlNode nextNode) { }

	// RVA: 0x251EE20 Offset: 0x251D820 VA: 0x18251EE20
	internal static void UnnestTextNodes(XmlNode prevNode, XmlNode nextNode) { }
}
