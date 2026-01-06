internal class ClassMap : ObjectMap // TypeDefIndex: 8224
{
	// Fields
	private Hashtable _elements; // 0x10
	private ArrayList _elementMembers; // 0x18
	private Hashtable _attributeMembers; // 0x20
	private XmlTypeMapMemberAttribute[] _attributeMembersArray; // 0x28
	private ArrayList _flatLists; // 0x30
	private ArrayList _allMembers; // 0x38
	private ArrayList _membersWithDefault; // 0x40
	private ArrayList _listMembers; // 0x48
	private XmlTypeMapMemberAnyElement _defaultAnyElement; // 0x50
	private XmlTypeMapMemberAnyAttribute _defaultAnyAttribute; // 0x58
	private XmlTypeMapMemberNamespaces _namespaceDeclarations; // 0x60
	private XmlTypeMapMember _xmlTextCollector; // 0x68
	private XmlTypeMapMember _returnMember; // 0x70
	private bool _ignoreMemberNamespace; // 0x78
	private bool _canBeSimpleType; // 0x79
	private Nullable<bool> _isOrderDependentMap; // 0x7A

	// Properties
	public bool IsOrderDependentMap { get; }
	public XmlTypeMapMemberAnyElement DefaultAnyElementMember { get; }
	public XmlTypeMapMemberAnyAttribute DefaultAnyAttributeMember { get; }
	public XmlTypeMapMemberNamespaces NamespaceDeclarations { get; }
	public ICollection AttributeMembers { get; }
	public ICollection ElementMembers { get; }
	public ArrayList AllMembers { get; }
	public ArrayList FlatLists { get; }
	public ArrayList ListMembers { get; }
	public XmlTypeMapMember XmlTextCollector { get; }
	public XmlTypeMapMember ReturnMember { get; }
	public XmlQualifiedName SimpleContentBaseType { get; }
	public bool HasSimpleContent { get; }

	// Methods

	// RVA: 0x25606A0 Offset: 0x255F0A0 VA: 0x1825606A0
	public void AddMember(XmlTypeMapMember member) { }

	// RVA: 0x2561A00 Offset: 0x2560400 VA: 0x182561A00
	private void RegisterFlatList(XmlTypeMapMemberExpandable member) { }

	// RVA: 0x25613F0 Offset: 0x255FDF0 VA: 0x1825613F0
	public XmlTypeMapMemberAttribute GetAttribute(string name, string ns) { }

	// RVA: 0x2561550 Offset: 0x255FF50 VA: 0x182561550
	public XmlTypeMapElementInfo GetElement(string name, string ns, int minimalOrder) { }

	// RVA: 0x2561800 Offset: 0x2560200 VA: 0x182561800
	public XmlTypeMapElementInfo GetElement(string name, string ns) { }

	// RVA: 0x2561320 Offset: 0x255FD20 VA: 0x182561320
	private string BuildKey(string name, string ns, int explicitOrder) { }

	// RVA: 0x2561ED0 Offset: 0x25608D0 VA: 0x182561ED0
	public bool get_IsOrderDependentMap() { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public XmlTypeMapMemberAnyElement get_DefaultAnyElementMember() { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public XmlTypeMapMemberAnyAttribute get_DefaultAnyAttributeMember() { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public XmlTypeMapMemberNamespaces get_NamespaceDeclarations() { }

	// RVA: 0x2561B60 Offset: 0x2560560 VA: 0x182561B60
	public ICollection get_AttributeMembers() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public ICollection get_ElementMembers() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public ArrayList get_AllMembers() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public ArrayList get_FlatLists() { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public ArrayList get_ListMembers() { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public XmlTypeMapMember get_XmlTextCollector() { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public XmlTypeMapMember get_ReturnMember() { }

	// RVA: 0x2562140 Offset: 0x2560B40 VA: 0x182562140
	public XmlQualifiedName get_SimpleContentBaseType() { }

	// RVA: 0x1E01DB0 Offset: 0x1E007B0 VA: 0x181E01DB0
	public void SetCanBeSimpleType(bool can) { }

	// RVA: 0x2561E70 Offset: 0x2560870 VA: 0x182561E70
	public bool get_HasSimpleContent() { }

	// RVA: 0x2561AC0 Offset: 0x25604C0 VA: 0x182561AC0
	public void .ctor() { }
}
