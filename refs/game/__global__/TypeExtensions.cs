internal static class TypeExtensions // TypeDefIndex: 15656
{
	// Fields
	private static readonly CacheDict<MethodBase, ParameterInfo[]> s_paramInfoCache; // 0x0

	// Methods

	[Extension]
	// RVA: 0x2007B90 Offset: 0x2006590 VA: 0x182007B90
	public static MethodInfo GetAnyStaticMethodValidated(Type type, string name, Type[] types) { }

	[Extension]
	// RVA: 0x2007F80 Offset: 0x2006980 VA: 0x182007F80
	private static bool MatchesArgumentTypes(MethodInfo mi, Type[] argTypes) { }

	[Extension]
	// RVA: 0x2007E80 Offset: 0x2006880 VA: 0x182007E80
	public static Type GetReturnType(MethodBase mi) { }

	[Extension]
	// RVA: 0x2007F30 Offset: 0x2006930 VA: 0x182007F30
	public static TypeCode GetTypeCode(Type type) { }

	[Extension]
	// RVA: 0x2007D60 Offset: 0x2006760 VA: 0x182007D60
	internal static ParameterInfo[] GetParametersCached(MethodBase method) { }

	// RVA: 0x20080F0 Offset: 0x2006AF0 VA: 0x1820080F0
	private static void .cctor() { }
}
