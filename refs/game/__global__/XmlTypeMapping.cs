public class XmlTypeMapping : XmlMapping // TypeDefIndex: 8222
{
	// Fields
	private string xmlType; // 0x48
	private string xmlTypeNamespace; // 0x50
	private TypeData type; // 0x58
	private XmlTypeMapping baseMap; // 0x60
	private bool multiReferenceType; // 0x68
	private bool includeInSchema; // 0x69
	private bool isNullable; // 0x6A
	private bool isAny; // 0x6B
	private ArrayList _derivedTypes; // 0x70

	// Properties
	public string TypeFullName { get; }
	internal TypeData TypeData { get; }
	internal string XmlType { get; set; }
	internal string XmlTypeNamespace { get; set; }
	internal bool HasXmlTypeNamespace { get; }
	internal ArrayList DerivedTypes { get; }
	internal bool MultiReferenceType { get; }
	internal XmlTypeMapping BaseMap { get; set; }
	internal bool IncludeInSchema { set; }
	internal bool IsNullable { get; set; }
	internal bool IsAny { get; set; }

	// Methods

	// RVA: 0x2575880 Offset: 0x2574280 VA: 0x182575880
	internal void .ctor(string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace) { }

	// RVA: 0x2575960 Offset: 0x2574360 VA: 0x182575960
	public string get_TypeFullName() { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	internal TypeData get_TypeData() { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	internal string get_XmlType() { }

	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	internal void set_XmlType(string value) { }

	// RVA: 0x2575980 Offset: 0x2574380 VA: 0x182575980
	internal string get_XmlTypeNamespace() { }

	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	internal void set_XmlTypeNamespace(string value) { }

	// RVA: 0x2575950 Offset: 0x2574350 VA: 0x182575950
	internal bool get_HasXmlTypeNamespace() { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	internal ArrayList get_DerivedTypes() { }

	// RVA: 0xCE3DC0 Offset: 0xCE27C0 VA: 0x180CE3DC0
	internal bool get_MultiReferenceType() { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	internal XmlTypeMapping get_BaseMap() { }

	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	internal void set_BaseMap(XmlTypeMapping value) { }

	// RVA: 0xCE3DF0 Offset: 0xCE27F0 VA: 0x180CE3DF0
	internal void set_IncludeInSchema(bool value) { }

	// RVA: 0xCE3DD0 Offset: 0xCE27D0 VA: 0x180CE3DD0
	internal bool get_IsNullable() { }

	// RVA: 0xCE3E30 Offset: 0xCE2830 VA: 0x180CE3E30
	internal void set_IsNullable(bool value) { }

	// RVA: 0xCE3D80 Offset: 0xCE2780 VA: 0x180CE3D80
	internal bool get_IsAny() { }

	// RVA: 0xCE3DE0 Offset: 0xCE27E0 VA: 0x180CE3DE0
	internal void set_IsAny(bool value) { }

	// RVA: 0x2575650 Offset: 0x2574050 VA: 0x182575650
	internal XmlTypeMapping GetRealTypeMap(Type objectType) { }

	// RVA: 0x2575410 Offset: 0x2573E10 VA: 0x182575410
	internal XmlTypeMapping GetRealElementMap(string name, string ens) { }

	// RVA: 0x25757F0 Offset: 0x25741F0 VA: 0x1825757F0
	internal void UpdateRoot(XmlQualifiedName qname) { }
}
