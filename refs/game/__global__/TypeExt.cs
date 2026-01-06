public static class TypeExt // TypeDefIndex: 10480
{
	// Methods

	// RVA: 0x49F7F0 Offset: 0x49E1F0 VA: 0x18049F7F0
	public static Type[] GetLoadedTypes() { }

	// RVA: 0x49F7C0 Offset: 0x49E1C0 VA: 0x18049F7C0
	public static IEnumerable<Assembly> GetLoadedAssemblies() { }

	[Extension]
	// RVA: -1 Offset: -1
	public static Dictionary<U, Type> GetAllTypesWithAttribute<U>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF62890 Offset: 0xF61290 VA: 0x180F62890
	|-TypeExt.GetAllTypesWithAttribute<object>
	|
	|-RVA: 0xF62530 Offset: 0xF60F30 VA: 0x180F62530
	|-TypeExt.GetAllTypesWithAttribute<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static List<FieldInfo> GetFieldsWithAttribute<T>(Type type, bool includeInherited = False, bool includePrivate = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF62BC0 Offset: 0xF615C0 VA: 0x180F62BC0
	|-TypeExt.GetFieldsWithAttribute<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetCustomAttribute<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEA0FA0 Offset: 0xE9F9A0 VA: 0x180EA0FA0
	|-TypeExt.GetCustomAttribute<object>
	*/

	[Extension]
	// RVA: 0x4A0100 Offset: 0x49EB00 VA: 0x1804A0100
	public static MethodInfo MethodByName(Type type, string name, bool includeInherited = False, bool includePrivate = False) { }

	[Extension]
	// RVA: 0x49EC40 Offset: 0x49D640 VA: 0x18049EC40
	public static FieldInfo FieldByName(Type type, string name, bool includeInherited = False, bool includePrivate = False) { }

	[Extension]
	// RVA: 0x4A0290 Offset: 0x49EC90 VA: 0x1804A0290
	public static PropertyInfo PropertyByName(Type type, string name, bool includeInherited = False, bool includePrivate = False) { }

	[Extension]
	// RVA: 0x49F270 Offset: 0x49DC70 VA: 0x18049F270
	public static FieldInfo[] GetAllFields(Type type, bool includeInherited = False, bool includePrivate = False) { }

	[Extension]
	// RVA: 0x49F400 Offset: 0x49DE00 VA: 0x18049F400
	public static PropertyInfo[] GetAllProperties(Type type, bool includeInherited = False, bool includePrivate = False) { }

	[Extension]
	// RVA: 0x49FF20 Offset: 0x49E920 VA: 0x18049FF20
	public static bool IsFrameworkType(Type type) { }

	[Extension]
	// RVA: 0x49FE40 Offset: 0x49E840 VA: 0x18049FE40
	public static bool IsArrayOrList(Type type) { }

	[Extension]
	// RVA: 0x49F590 Offset: 0x49DF90 VA: 0x18049F590
	public static Type GetEnumerableType(Type t) { }

	// RVA: 0x49EDF0 Offset: 0x49D7F0 VA: 0x18049EDF0
	private static Type FindIEnumerable(Type seqType) { }

	[Extension]
	// RVA: 0x49FB60 Offset: 0x49E560 VA: 0x18049FB60
	private static MethodInfo GetMethodIncludingBaseClasses(Type type, string name, BindingFlags bindingFlags) { }

	[Extension]
	// RVA: 0x49F640 Offset: 0x49E040 VA: 0x18049F640
	private static FieldInfo GetFieldIncludingBaseClasses(Type type, string name, BindingFlags bindingFlags) { }

	[Extension]
	// RVA: 0x49FCD0 Offset: 0x49E6D0 VA: 0x18049FCD0
	private static PropertyInfo GetPropertyIncludingBaseClasses(Type type, string name, BindingFlags bindingFlags) { }

	[Extension]
	// RVA: 0x4A0020 Offset: 0x49EA20 VA: 0x1804A0020
	public static bool Matches(Type type, Type[] types) { }
}
