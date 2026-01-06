internal sealed class TypeLimiter // TypeDefIndex: 12873
{
	// Fields
	[Nullable(2)]
	[ThreadStatic]
	private static TypeLimiter.Scope s_activeScope; // 0x80000000
	private TypeLimiter.Scope m_instanceScope; // 0x10

	// Properties
	private static bool IsTypeLimitingDisabled { get; }

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	private void .ctor(TypeLimiter.Scope scope) { }

	// RVA: 0x207FBC0 Offset: 0x207E5C0 VA: 0x18207FBC0
	private static bool get_IsTypeLimitingDisabled() { }

	[NullableContext(2)]
	// RVA: 0x207F330 Offset: 0x207DD30 VA: 0x18207F330
	public static TypeLimiter Capture() { }

	[NullableContext(2)]
	// RVA: 0x207F3B0 Offset: 0x207DDB0 VA: 0x18207F3B0
	public static void EnsureTypeIsAllowed(Type type, TypeLimiter capturedLimiter) { }

	// RVA: 0x207F5B0 Offset: 0x207DFB0 VA: 0x18207F5B0
	public static IDisposable EnterRestrictedScope(DataSet dataSet) { }

	// RVA: 0x207F7F0 Offset: 0x207E1F0 VA: 0x18207F7F0
	public static IDisposable EnterRestrictedScope(DataTable dataTable) { }

	// RVA: 0x207FA60 Offset: 0x207E460 VA: 0x18207FA60
	private static IEnumerable<Type> GetPreviouslyDeclaredDataTypes(DataTable dataTable) { }

	// RVA: 0x207F900 Offset: 0x207E300 VA: 0x18207F900
	private static IEnumerable<Type> GetPreviouslyDeclaredDataTypes(DataSet dataSet) { }
}
