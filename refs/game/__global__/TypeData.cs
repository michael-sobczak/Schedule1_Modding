internal class TypeData // TypeDefIndex: 8158
{
	// Fields
	private Type type; // 0x10
	private string elementName; // 0x18
	private SchemaTypes sType; // 0x20
	private Type listItemType; // 0x28
	private string typeName; // 0x30
	private string fullTypeName; // 0x38
	private TypeData listItemTypeData; // 0x40
	private TypeData mappedType; // 0x48
	private XmlSchemaPatternFacet facet; // 0x50
	private MethodInfo typeConvertor; // 0x58
	private bool hasPublicConstructor; // 0x60
	private bool nullableOverride; // 0x61
	private static string[] keywords; // 0x0

	// Properties
	public string TypeName { get; }
	public string XmlType { get; }
	public Type Type { get; }
	public string FullTypeName { get; }
	public SchemaTypes SchemaType { get; }
	public bool IsListType { get; }
	public bool IsComplexType { get; }
	public bool IsValueType { get; }
	public bool IsNullable { get; set; }
	public TypeData ListItemTypeData { get; }
	public Type ListItemType { get; }
	public bool IsXsdType { get; }
	public bool HasPublicConstructor { get; }

	// Methods

	// RVA: 0x2523D70 Offset: 0x2522770 VA: 0x182523D70
	public void .ctor(Type type, string elementName, bool isPrimitive) { }

	// RVA: 0x2523810 Offset: 0x2522210 VA: 0x182523810
	public void .ctor(Type type, string elementName, bool isPrimitive, TypeData mappedType, XmlSchemaPatternFacet facet) { }

	// RVA: 0x2522820 Offset: 0x2521220 VA: 0x182522820
	private void LookupTypeConvertor() { }

	// RVA: 0x25222C0 Offset: 0x2520CC0 VA: 0x1825222C0
	internal void ConvertForAssignment(ref object value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_TypeName() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_XmlType() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Type get_Type() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public string get_FullTypeName() { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public SchemaTypes get_SchemaType() { }

	// RVA: 0x2523DC0 Offset: 0x25227C0 VA: 0x182523DC0
	public bool get_IsListType() { }

	// RVA: 0x2523D90 Offset: 0x2522790 VA: 0x182523D90
	public bool get_IsComplexType() { }

	// RVA: 0x2523F60 Offset: 0x2522960 VA: 0x182523F60
	public bool get_IsValueType() { }

	// RVA: 0x2523DD0 Offset: 0x25227D0 VA: 0x182523DD0
	public bool get_IsNullable() { }

	// RVA: 0x848350 Offset: 0x846D50 VA: 0x180848350
	public void set_IsNullable(bool value) { }

	// RVA: 0x2524000 Offset: 0x2522A00 VA: 0x182524000
	public TypeData get_ListItemTypeData() { }

	// RVA: 0x2524100 Offset: 0x2522B00 VA: 0x182524100
	public Type get_ListItemType() { }

	// RVA: 0x23A5EC0 Offset: 0x23A48C0 VA: 0x1823A5EC0
	public bool get_IsXsdType() { }

	// RVA: 0x4C1D90 Offset: 0x4C0790 VA: 0x1804C1D90
	public bool get_HasPublicConstructor() { }

	// RVA: 0x25226C0 Offset: 0x25210C0 VA: 0x1825226C0
	public static PropertyInfo GetIndexerProperty(Type collectionType) { }

	// RVA: 0x25223B0 Offset: 0x2520DB0 VA: 0x1825223B0
	private static InvalidOperationException CreateMissingAddMethodException(Type type, string inheritFrom, Type argumentType) { }

	// RVA: 0x25224C0 Offset: 0x2520EC0 VA: 0x1825224C0
	internal static Type GetGenericListItemType(Type type) { }

	// RVA: 0x25228D0 Offset: 0x25212D0 VA: 0x1825228D0
	private static void .cctor() { }
}
