public abstract class XPathNavigator : XPathItem, ICloneable, IXPathNavigable, IXmlNamespaceResolver // TypeDefIndex: 8135
{
	// Fields
	internal static readonly XPathNavigatorKeyComparer comparer; // 0x0
	internal static readonly char[] NodeTypeLetter; // 0x8
	internal static readonly char[] UniqueIdTbl; // 0x10
	internal static readonly int[] ContentKindMasks; // 0x18

	// Properties
	public override XmlSchemaType XmlType { get; }
	public override object TypedValue { get; }
	public override Type ValueType { get; }
	public override bool ValueAsBoolean { get; }
	public override DateTime ValueAsDateTime { get; }
	public override double ValueAsDouble { get; }
	public override int ValueAsInt { get; }
	public override long ValueAsLong { get; }
	public abstract XmlNameTable NameTable { get; }
	public abstract XPathNodeType NodeType { get; }
	public abstract string LocalName { get; }
	public abstract string Name { get; }
	public abstract string NamespaceURI { get; }
	public abstract string Prefix { get; }
	public abstract string BaseURI { get; }
	public virtual string XmlLang { get; }
	public virtual object UnderlyingObject { get; }
	public virtual IXmlSchemaInfo SchemaInfo { get; }

	// Methods

	// RVA: 0x618750 Offset: 0x617150 VA: 0x180618750 Slot: 3
	public override string ToString() { }

	// RVA: 0x2530040 Offset: 0x252EA40 VA: 0x182530040 Slot: 4
	public override XmlSchemaType get_XmlType() { }

	// RVA: 0x252F2C0 Offset: 0x252DCC0 VA: 0x18252F2C0 Slot: 6
	public override object get_TypedValue() { }

	// RVA: 0x252FE60 Offset: 0x252E860 VA: 0x18252FE60 Slot: 7
	public override Type get_ValueType() { }

	// RVA: 0x252F4B0 Offset: 0x252DEB0 VA: 0x18252F4B0 Slot: 8
	public override bool get_ValueAsBoolean() { }

	// RVA: 0x252F6A0 Offset: 0x252E0A0 VA: 0x18252F6A0 Slot: 9
	public override DateTime get_ValueAsDateTime() { }

	// RVA: 0x252F890 Offset: 0x252E290 VA: 0x18252F890 Slot: 10
	public override double get_ValueAsDouble() { }

	// RVA: 0x252FA80 Offset: 0x252E480 VA: 0x18252FA80 Slot: 11
	public override int get_ValueAsInt() { }

	// RVA: 0x252FC70 Offset: 0x252E670 VA: 0x18252FC70 Slot: 12
	public override long get_ValueAsLong() { }

	// RVA: 0x252EEA0 Offset: 0x252D8A0 VA: 0x18252EEA0 Slot: 14
	public override object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xB298E0 Offset: 0xB282E0 VA: 0x180B298E0 Slot: 15
	private object System.ICloneable.Clone() { }

	// RVA: 0xB298E0 Offset: 0xB282E0 VA: 0x180B298E0 Slot: 20
	public virtual XPathNavigator CreateNavigator() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract XmlNameTable get_NameTable();

	// RVA: 0x252DAA0 Offset: 0x252C4A0 VA: 0x18252DAA0 Slot: 22
	public virtual string LookupNamespace(string prefix) { }

	// RVA: 0x252DC70 Offset: 0x252C670 VA: 0x18252DC70 Slot: 23
	public virtual string LookupPrefix(string namespaceURI) { }

	// RVA: 0x252D7E0 Offset: 0x252C1E0 VA: 0x18252D7E0 Slot: 24
	public virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract XPathNavigator Clone();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract XPathNodeType get_NodeType();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract string get_LocalName();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract string get_NamespaceURI();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract string get_Prefix();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract string get_BaseURI();

	// RVA: 0x252FF60 Offset: 0x252E960 VA: 0x18252FF60 Slot: 32
	public virtual string get_XmlLang() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 33
	public virtual object get_UnderlyingObject() { }

	// RVA: 0x252DEC0 Offset: 0x252C8C0 VA: 0x18252DEC0 Slot: 34
	public virtual bool MoveToAttribute(string localName, string namespaceURI) { }

	// RVA: -1 Offset: -1 Slot: 35
	public abstract bool MoveToFirstAttribute();

	// RVA: -1 Offset: -1 Slot: 36
	public abstract bool MoveToNextAttribute();

	// RVA: 0x252E640 Offset: 0x252D040 VA: 0x18252E640 Slot: 37
	public virtual bool MoveToNamespace(string name) { }

	// RVA: -1 Offset: -1 Slot: 38
	public abstract bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope);

	// RVA: -1 Offset: -1 Slot: 39
	public abstract bool MoveToNextNamespace(XPathNamespaceScope namespaceScope);

	// RVA: 0x252E180 Offset: 0x252CB80 VA: 0x18252E180
	public bool MoveToFirstNamespace() { }

	// RVA: 0x252E6F0 Offset: 0x252D0F0 VA: 0x18252E6F0
	public bool MoveToNextNamespace() { }

	// RVA: -1 Offset: -1 Slot: 40
	public abstract bool MoveToNext();

	// RVA: -1 Offset: -1 Slot: 41
	public abstract bool MoveToFirstChild();

	// RVA: -1 Offset: -1 Slot: 42
	public abstract bool MoveToParent();

	// RVA: 0x252EA60 Offset: 0x252D460 VA: 0x18252EA60 Slot: 43
	public virtual void MoveToRoot() { }

	// RVA: -1 Offset: -1 Slot: 44
	public abstract bool MoveTo(XPathNavigator other);

	// RVA: -1 Offset: -1 Slot: 45
	public abstract bool MoveToId(string id);

	// RVA: 0x252DFA0 Offset: 0x252C9A0 VA: 0x18252DFA0 Slot: 46
	public virtual bool MoveToChild(string localName, string namespaceURI) { }

	// RVA: 0x252E0A0 Offset: 0x252CAA0 VA: 0x18252E0A0 Slot: 47
	public virtual bool MoveToChild(XPathNodeType type) { }

	// RVA: 0x252E400 Offset: 0x252CE00 VA: 0x18252E400 Slot: 48
	public virtual bool MoveToFollowing(string localName, string namespaceURI, XPathNavigator end) { }

	// RVA: 0x252E1A0 Offset: 0x252CBA0 VA: 0x18252E1A0 Slot: 49
	public virtual bool MoveToFollowing(XPathNodeType type, XPathNavigator end) { }

	// RVA: 0x252E840 Offset: 0x252D240 VA: 0x18252E840 Slot: 50
	public virtual bool MoveToNext(string localName, string namespaceURI) { }

	// RVA: 0x252E710 Offset: 0x252D110 VA: 0x18252E710 Slot: 51
	public virtual bool MoveToNext(XPathNodeType type) { }

	// RVA: -1 Offset: -1 Slot: 52
	public abstract bool IsSamePosition(XPathNavigator other);

	// RVA: 0x252D9F0 Offset: 0x252C3F0 VA: 0x18252D9F0 Slot: 53
	public virtual bool IsDescendant(XPathNavigator nav) { }

	// RVA: 0x252D010 Offset: 0x252BA10 VA: 0x18252D010 Slot: 54
	public virtual XmlNodeOrder ComparePosition(XPathNavigator nav) { }

	// RVA: 0x252F280 Offset: 0x252DC80 VA: 0x18252F280 Slot: 55
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x252ED00 Offset: 0x252D700 VA: 0x18252ED00 Slot: 56
	public virtual XPathNodeIterator Select(string xpath) { }

	// RVA: 0x252EDE0 Offset: 0x252D7E0 VA: 0x18252EDE0 Slot: 57
	public virtual XPathNodeIterator Select(XPathExpression expr) { }

	// RVA: 0x252D4E0 Offset: 0x252BEE0 VA: 0x18252D4E0 Slot: 58
	public virtual object Evaluate(XPathExpression expr) { }

	// RVA: 0x252D500 Offset: 0x252BF00 VA: 0x18252D500 Slot: 59
	public virtual object Evaluate(XPathExpression expr, XPathNodeIterator context) { }

	// RVA: 0x252EB30 Offset: 0x252D530 VA: 0x18252EB30 Slot: 60
	public virtual XPathNodeIterator SelectChildren(XPathNodeType type) { }

	// RVA: 0x252EA90 Offset: 0x252D490 VA: 0x18252EA90 Slot: 61
	public virtual XPathNodeIterator SelectChildren(string name, string namespaceURI) { }

	// RVA: 0x252EBB0 Offset: 0x252D5B0 VA: 0x18252EBB0 Slot: 62
	public virtual XPathNodeIterator SelectDescendants(XPathNodeType type, bool matchSelf) { }

	// RVA: 0x252EC50 Offset: 0x252D650 VA: 0x18252EC50 Slot: 63
	public virtual XPathNodeIterator SelectDescendants(string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x252E930 Offset: 0x252D330 VA: 0x18252E930
	internal bool MoveToNonDescendant() { }

	// RVA: 0x252D760 Offset: 0x252C160 VA: 0x18252D760
	private static int GetDepth(XPathNavigator nav) { }

	// RVA: 0x252D360 Offset: 0x252BD60 VA: 0x18252D360
	private XmlNodeOrder CompareSiblings(XPathNavigator n1, XPathNavigator n2) { }

	// RVA: 0x252D6F0 Offset: 0x252C0F0 VA: 0x18252D6F0
	internal static int GetContentKindMask(XPathNodeType type) { }

	// RVA: 0x252D7C0 Offset: 0x252C1C0 VA: 0x18252D7C0
	internal static int GetKindMask(XPathNodeType type) { }

	// RVA: 0x252DA90 Offset: 0x252C490 VA: 0x18252DA90
	internal static bool IsText(XPathNodeType type) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x252F0D0 Offset: 0x252DAD0 VA: 0x18252F0D0
	private static void .cctor() { }
}
