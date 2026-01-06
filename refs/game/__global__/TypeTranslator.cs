internal class TypeTranslator // TypeDefIndex: 8160
{
	// Fields
	private static Hashtable nameCache; // 0x0
	private static Hashtable primitiveTypes; // 0x8
	private static Hashtable primitiveArrayTypes; // 0x10
	private static Hashtable nullableTypes; // 0x18

	// Methods

	// RVA: 0x2525E10 Offset: 0x2524810 VA: 0x182525E10
	private static void .cctor() { }

	// RVA: 0x2525C30 Offset: 0x2524630 VA: 0x182525C30
	public static TypeData GetTypeData(Type type) { }

	// RVA: 0x2525160 Offset: 0x2523B60 VA: 0x182525160
	public static TypeData GetTypeData(Type runtimeType, string xmlDataType, bool underlyingEnumType = False) { }

	// RVA: 0x2525110 Offset: 0x2523B10 VA: 0x182525110
	public static TypeData GetPrimitiveTypeData(string typeName) { }

	// RVA: 0x2524ED0 Offset: 0x25238D0 VA: 0x182524ED0
	public static TypeData GetPrimitiveTypeData(string typeName, bool nullable) { }

	// RVA: 0x2524D00 Offset: 0x2523700 VA: 0x182524D00
	public static TypeData FindPrimitiveTypeData(string typeName) { }

	// RVA: 0x2524DD0 Offset: 0x25237D0 VA: 0x182524DD0
	public static string GetArrayName(string elemName) { }

	// RVA: 0x2525C80 Offset: 0x2524680 VA: 0x182525C80
	public static void ParseArrayType(string arrayType, out string type, out string ns, out string dimensions) { }
}
