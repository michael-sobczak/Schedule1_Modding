internal static class ReflectionUtils // TypeDefIndex: 11198
{
	// Fields
	public static readonly Type[] EmptyTypes; // 0x0

	// Methods

	// RVA: 0x1D72530 Offset: 0x1D70F30 VA: 0x181D72530
	private static void .cctor() { }

	[Extension]
	// RVA: 0x1D71F30 Offset: 0x1D70930 VA: 0x181D71F30
	public static bool IsVirtual(PropertyInfo propertyInfo) { }

	[Extension]
	// RVA: 0x1D6E720 Offset: 0x1D6D120 VA: 0x181D6E720
	public static MethodInfo GetBaseDefinition(PropertyInfo propertyInfo) { }

	// RVA: 0x1D71E90 Offset: 0x1D70890 VA: 0x181D71E90
	public static bool IsPublic(PropertyInfo property) { }

	[NullableContext(2)]
	// RVA: 0x1D70A20 Offset: 0x1D6F420 VA: 0x181D70A20
	public static Type GetObjectType(object v) { }

	// RVA: 0x1D70D30 Offset: 0x1D6F730 VA: 0x181D70D30
	public static string GetTypeName(Type t, TypeNameAssemblyFormatHandling assemblyFormat, ISerializationBinder binder) { }

	// RVA: 0x1D700D0 Offset: 0x1D6EAD0 VA: 0x181D700D0
	private static string GetFullyQualifiedTypeName(Type t, ISerializationBinder binder) { }

	// RVA: 0x1D72020 Offset: 0x1D70A20 VA: 0x181D72020
	private static string RemoveAssemblyDetails(string fullyQualifiedTypeName) { }

	// RVA: 0x1D71070 Offset: 0x1D6FA70 VA: 0x181D71070
	public static bool HasDefaultConstructor(Type t, bool nonPublic) { }

	// RVA: 0x1D6F240 Offset: 0x1D6DC40 VA: 0x181D6F240
	public static ConstructorInfo GetDefaultConstructor(Type t) { }

	// RVA: 0x1D6F0F0 Offset: 0x1D6DAF0 VA: 0x181D6F0F0
	public static ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic) { }

	// RVA: 0x1D71C00 Offset: 0x1D70600 VA: 0x181D71C00
	public static bool IsNullable(Type t) { }

	// RVA: 0x1D71B30 Offset: 0x1D70530 VA: 0x181D71B30
	public static bool IsNullableType(Type t) { }

	// RVA: 0x1D6E130 Offset: 0x1D6CB30 VA: 0x181D6E130
	public static Type EnsureNotNullableType(Type t) { }

	// RVA: 0x1D6E0D0 Offset: 0x1D6CAD0 VA: 0x181D6E0D0
	public static Type EnsureNotByRefType(Type t) { }

	// RVA: 0x1D71900 Offset: 0x1D70300 VA: 0x181D71900
	public static bool IsGenericDefinition(Type type, Type genericInterfaceDefinition) { }

	// RVA: 0x1D713D0 Offset: 0x1D6FDD0 VA: 0x181D713D0
	public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition) { }

	// RVA: 0x1D71140 Offset: 0x1D6FB40 VA: 0x181D71140
	public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, out Type implementingType) { }

	// RVA: 0x1D71770 Offset: 0x1D70170 VA: 0x181D71770
	public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition) { }

	// RVA: 0x1D71550 Offset: 0x1D6FF50 VA: 0x181D71550
	public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition, out Type implementingType) { }

	// RVA: 0x1D71440 Offset: 0x1D6FE40 VA: 0x181D71440
	private static bool InheritsGenericDefinitionInternal(Type type, Type genericClassDefinition, out Type implementingType) { }

	// RVA: 0x1D6EE30 Offset: 0x1D6D830 VA: 0x181D6EE30
	public static Type GetCollectionItemType(Type type) { }

	[NullableContext(2)]
	// RVA: 0x1D6F5C0 Offset: 0x1D6DFC0 VA: 0x181D6F5C0
	public static void GetDictionaryKeyValueTypes(Type dictionaryType, out Type keyType, out Type valueType) { }

	// RVA: 0x1D704D0 Offset: 0x1D6EED0 VA: 0x181D704D0
	public static Type GetMemberUnderlyingType(MemberInfo member) { }

	// RVA: 0x1D717E0 Offset: 0x1D701E0 VA: 0x181D717E0
	public static bool IsByRefLikeType(Type type) { }

	// RVA: 0x1D719A0 Offset: 0x1D703A0 VA: 0x181D719A0
	public static bool IsIndexedProperty(PropertyInfo property) { }

	// RVA: 0x1D70750 Offset: 0x1D6F150 VA: 0x181D70750
	public static object GetMemberValue(MemberInfo member, object target) { }

	// RVA: 0x1D72190 Offset: 0x1D70B90 VA: 0x181D72190
	public static void SetMemberValue(MemberInfo member, object target, object value) { }

	// RVA: 0x1D6DDD0 Offset: 0x1D6C7D0 VA: 0x181D6DDD0
	public static bool CanReadMemberValue(MemberInfo member, bool nonPublic) { }

	// RVA: 0x1D6DF30 Offset: 0x1D6C930 VA: 0x181D6DF30
	public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly) { }

	// RVA: 0x1D6F8A0 Offset: 0x1D6E2A0 VA: 0x181D6F8A0
	public static List<MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr) { }

	// RVA: 0x1D71C80 Offset: 0x1D70680 VA: 0x181D71C80
	private static bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr) { }

	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(object attributeProvider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF31210 Offset: 0xF2FC10 VA: 0x180F31210
	|-ReflectionUtils.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(object attributeProvider, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF310B0 Offset: 0xF2FAB0 VA: 0x180F310B0
	|-ReflectionUtils.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] GetAttributes<T>(object attributeProvider, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF313A0 Offset: 0xF2FDA0 VA: 0x180F313A0
	|-ReflectionUtils.GetAttributes<object>
	*/

	// RVA: 0x1D6E260 Offset: 0x1D6CC60 VA: 0x181D6E260
	public static Attribute[] GetAttributes(object attributeProvider, Type attributeType, bool inherit) { }

	// RVA: 0x1D723B0 Offset: 0x1D70DB0 VA: 0x181D723B0
	public static StructMultiKey<string, string> SplitFullyQualifiedTypeName(string fullyQualifiedTypeName) { }

	// RVA: 0x1D6E190 Offset: 0x1D6CB90 VA: 0x181D6E190
	private static Nullable<int> GetAssemblyDelimiterIndex(string fullyQualifiedTypeName) { }

	// RVA: 0x1D70220 Offset: 0x1D6EC20 VA: 0x181D70220
	public static MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo) { }

	// RVA: 0x1D6FFC0 Offset: 0x1D6E9C0 VA: 0x181D6FFC0
	public static IEnumerable<FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr) { }

	// RVA: 0x1D6E810 Offset: 0x1D6D210 VA: 0x181D6E810
	private static void GetChildPrivateFields(IList<MemberInfo> initialFields, Type type, BindingFlags bindingAttr) { }

	// RVA: 0x1D70A30 Offset: 0x1D6F430 VA: 0x181D70A30
	public static IEnumerable<PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr) { }

	[Extension]
	// RVA: 0x1D72170 Offset: 0x1D70B70 VA: 0x181D72170
	public static BindingFlags RemoveFlag(BindingFlags bindingAttr, BindingFlags flag) { }

	// RVA: 0x1D6EA00 Offset: 0x1D6D400 VA: 0x181D6EA00
	private static void GetChildPrivateProperties(IList<PropertyInfo> initialProperties, Type type, BindingFlags bindingAttr) { }

	// RVA: 0x1D71A10 Offset: 0x1D70410 VA: 0x181D71A10
	public static bool IsMethodOverridden(Type currentType, Type methodDeclaringType, string method) { }

	// RVA: 0x1D6F290 Offset: 0x1D6DC90 VA: 0x181D6F290
	public static object GetDefaultValue(Type type) { }
}
