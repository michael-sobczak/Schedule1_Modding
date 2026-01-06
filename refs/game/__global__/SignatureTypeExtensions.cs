internal static class SignatureTypeExtensions // TypeDefIndex: 4729
{
	// Methods

	[Extension]
	// RVA: 0x1B99C20 Offset: 0x1B98620 VA: 0x181B99C20
	public static bool MatchesParameterTypeExactly(Type pattern, ParameterInfo parameter) { }

	[Extension]
	// RVA: 0x1B99800 Offset: 0x1B98200 VA: 0x181B99800
	internal static bool MatchesExactly(SignatureType pattern, Type actual) { }

	[Extension]
	// RVA: 0x1B99DE0 Offset: 0x1B987E0 VA: 0x181B99DE0
	internal static Type TryResolveAgainstGenericMethod(SignatureType signatureType, MethodInfo genericMethod) { }

	[Extension]
	// RVA: 0x1B99E20 Offset: 0x1B98820 VA: 0x181B99E20
	private static Type TryResolve(SignatureType signatureType, Type[] genericMethodParameters) { }

	[Extension]
	// RVA: 0x1B99D20 Offset: 0x1B98720 VA: 0x181B99D20
	private static Type TryMakeArrayType(Type type) { }

	[Extension]
	// RVA: 0x1B99CF0 Offset: 0x1B986F0 VA: 0x181B99CF0
	private static Type TryMakeArrayType(Type type, int rank) { }

	[Extension]
	// RVA: 0x1B99D50 Offset: 0x1B98750 VA: 0x181B99D50
	private static Type TryMakeByRefType(Type type) { }

	[Extension]
	// RVA: 0x1B99DB0 Offset: 0x1B987B0 VA: 0x181B99DB0
	private static Type TryMakePointerType(Type type) { }

	[Extension]
	// RVA: 0x1B99D80 Offset: 0x1B98780 VA: 0x181B99D80
	private static Type TryMakeGenericType(Type type, Type[] instantiation) { }
}
