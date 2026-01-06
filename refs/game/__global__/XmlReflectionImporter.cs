public class XmlReflectionImporter // TypeDefIndex: 8184
{
	// Fields
	private string initialDefaultNamespace; // 0x10
	private XmlAttributeOverrides attributeOverrides; // 0x18
	private ArrayList includedTypes; // 0x20
	private ReflectionHelper helper; // 0x28
	private int arrayChoiceCount; // 0x30
	private ArrayList relatedMaps; // 0x38
	private bool allowPrivateTypes; // 0x40
	private static readonly string errSimple; // 0x0
	private static readonly string errSimple2; // 0x8

	// Methods

	// RVA: 0x254B630 Offset: 0x254A030 VA: 0x18254B630
	public void .ctor(XmlAttributeOverrides attributeOverrides, string defaultNamespace) { }

	// RVA: 0x254A9B0 Offset: 0x25493B0 VA: 0x18254A9B0
	public XmlTypeMapping ImportTypeMapping(Type type) { }

	// RVA: 0x254A9D0 Offset: 0x25493D0 VA: 0x18254A9D0
	public XmlTypeMapping ImportTypeMapping(Type type, string defaultNamespace) { }

	// RVA: 0x254A9F0 Offset: 0x25493F0 VA: 0x18254A9F0
	public XmlTypeMapping ImportTypeMapping(Type type, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x254A3F0 Offset: 0x2548DF0 VA: 0x18254A3F0
	private XmlTypeMapping ImportTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x2544E20 Offset: 0x2543820 VA: 0x182544E20
	private XmlTypeMapping CreateTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultXmlType, string defaultNamespace) { }

	// RVA: 0x2546860 Offset: 0x2545260 VA: 0x182546860
	private XmlTypeMapping ImportClassMapping(Type type, XmlRootAttribute root, string defaultNamespace, bool isBaseType = False) { }

	// RVA: 0x2546900 Offset: 0x2545300 VA: 0x182546900
	private XmlTypeMapping ImportClassMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, bool isBaseType = False) { }

	// RVA: 0x254B440 Offset: 0x2549E40 VA: 0x18254B440
	private void RegisterDerivedMap(XmlTypeMapping map, XmlTypeMapping derivedMap) { }

	// RVA: 0x25461D0 Offset: 0x2544BD0 VA: 0x1825461D0
	private string GetTypeNamespace(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x2549150 Offset: 0x2547B50 VA: 0x182549150
	private XmlTypeMapping ImportListMapping(Type type, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

	// RVA: 0x25491E0 Offset: 0x2547BE0 VA: 0x1825491E0
	private XmlTypeMapping ImportListMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

	// RVA: 0x254ABD0 Offset: 0x25495D0 VA: 0x18254ABD0
	private XmlTypeMapping ImportXmlNodeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x2549F80 Offset: 0x2548980 VA: 0x182549F80
	private XmlTypeMapping ImportPrimitiveMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x2548A10 Offset: 0x2547410 VA: 0x182548A10
	private XmlTypeMapping ImportEnumMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x254AEC0 Offset: 0x25498C0 VA: 0x18254AEC0
	private XmlTypeMapping ImportXmlSerializableMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x2549010 Offset: 0x2547A10 VA: 0x182549010
	private void ImportIncludedTypes(Type type, string defaultNamespace) { }

	// RVA: 0x25454F0 Offset: 0x2543EF0 VA: 0x1825454F0
	private List<XmlReflectionMember> GetReflectionMembers(Type type) { }

	// RVA: 0x25440B0 Offset: 0x2542AB0 VA: 0x1825440B0
	private XmlTypeMapMember CreateMapMember(Type declaringType, XmlReflectionMember rmember, string defaultNamespace) { }

	// RVA: 0x2547A40 Offset: 0x2546440 VA: 0x182547A40
	private XmlTypeMapElementInfoList ImportElementInfo(Type cls, string defaultName, string defaultNamespace, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts) { }

	// RVA: 0x2546330 Offset: 0x2544D30 VA: 0x182546330
	private XmlTypeMapElementInfoList ImportAnyElementInfo(string defaultNamespace, XmlReflectionMember rmember, XmlTypeMapMemberElement member, XmlAttributes atts) { }

	// RVA: 0x254A060 Offset: 0x2548A60 VA: 0x18254A060
	private void ImportTextElementInfo(XmlTypeMapElementInfoList list, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts, string defaultNamespace) { }

	// RVA: 0x2544070 Offset: 0x2542A70 VA: 0x182544070
	private bool CanBeNull(TypeData type) { }

	// RVA: 0x254AFF0 Offset: 0x25499F0 VA: 0x18254AFF0
	public void IncludeType(Type type) { }

	// RVA: 0x2545320 Offset: 0x2543D20 VA: 0x182545320
	private object GetDefaultValue(TypeData typeData, object defaultValue) { }

	// RVA: 0x254B580 Offset: 0x2549F80 VA: 0x18254B580
	private static void .cctor() { }
}
