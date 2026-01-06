internal static class TypeHelpers // TypeDefIndex: 7853
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static TObject As<TObject>(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF62CD0 Offset: 0xF616D0 VA: 0x180F62CD0
	|-TypeHelpers.As<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x2795AF0 Offset: 0x27944F0 VA: 0x182795AF0
	public static bool IsInt(TypeCode type) { }

	// RVA: 0x2795930 Offset: 0x2794330 VA: 0x182795930
	public static Type GetValueType(MemberInfo member) { }

	[Extension]
	// RVA: 0x2795460 Offset: 0x2793E60 VA: 0x182795460
	public static string GetNiceTypeName(Type type) { }

	// RVA: 0x2795000 Offset: 0x2793A00 VA: 0x182795000
	public static Type GetGenericTypeArgumentFromHierarchy(Type type, Type genericTypeDefinition, int argumentIndex) { }
}
