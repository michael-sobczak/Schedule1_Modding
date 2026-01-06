public static class FormatterServices // TypeDefIndex: 4431
{
	// Fields
	internal static ConcurrentDictionary<MemberHolder, MemberInfo[]> m_MemberInfoTable; // 0x0
	private static bool unsafeTypeForwardersIsEnabled; // 0x8
	private static bool unsafeTypeForwardersIsEnabledInitialized; // 0x9
	private static readonly Type[] advancedTypes; // 0x10
	private static Binder s_binder; // 0x18

	// Methods

	// RVA: 0x1B313C0 Offset: 0x1B2FDC0 VA: 0x181B313C0
	private static void .cctor() { }

	// RVA: 0x1B2FE40 Offset: 0x1B2E840 VA: 0x181B2FE40
	private static MemberInfo[] GetSerializableMembers(RuntimeType type) { }

	// RVA: 0x1B2ED40 Offset: 0x1B2D740 VA: 0x181B2ED40
	private static bool CheckSerializable(RuntimeType type) { }

	// RVA: 0x1B30540 Offset: 0x1B2EF40 VA: 0x181B30540
	private static MemberInfo[] InternalGetSerializableMembers(RuntimeType type) { }

	// RVA: 0x1B2F9F0 Offset: 0x1B2E3F0 VA: 0x181B2F9F0
	private static bool GetParentTypes(RuntimeType parentType, out RuntimeType[] parentTypes, out int parentTypeCount) { }

	// RVA: 0x1B30000 Offset: 0x1B2EA00 VA: 0x181B30000
	public static MemberInfo[] GetSerializableMembers(Type type, StreamingContext context) { }

	// RVA: 0x1B30370 Offset: 0x1B2ED70 VA: 0x181B30370
	public static object GetUninitializedObject(Type type) { }

	// RVA: 0x1B23560 Offset: 0x1B21F60 VA: 0x181B23560
	private static object nativeGetUninitializedObject(RuntimeType type) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	private static bool GetEnableUnsafeTypeForwarders() { }

	// RVA: 0x1B312F0 Offset: 0x1B2FCF0 VA: 0x181B312F0
	internal static bool UnsafeTypeForwardersIsEnabled() { }

	// RVA: 0x1B310C0 Offset: 0x1B2FAC0 VA: 0x181B310C0
	internal static void SerializationSetValue(MemberInfo fi, object target, object value) { }

	// RVA: 0x1B30D20 Offset: 0x1B2F720 VA: 0x181B30D20
	public static object PopulateObjectMembers(object obj, MemberInfo[] members, object[] data) { }

	// RVA: 0x1B2F5B0 Offset: 0x1B2DFB0 VA: 0x181B2F5B0
	public static object[] GetObjectData(object obj, MemberInfo[] members) { }

	// RVA: 0x1B302C0 Offset: 0x1B2ECC0 VA: 0x181B302C0
	public static Type GetTypeFromAssembly(Assembly assem, string name) { }

	// RVA: 0x1B30D10 Offset: 0x1B2F710 VA: 0x181B30D10
	internal static Assembly LoadAssemblyFromString(string assemblyName) { }

	// RVA: 0x1B30CB0 Offset: 0x1B2F6B0 VA: 0x181B30CB0
	internal static Assembly LoadAssemblyFromStringNoThrow(string assemblyName) { }

	// RVA: 0x1B2ED70 Offset: 0x1B2D770 VA: 0x181B2ED70
	internal static string GetClrAssemblyName(Type type, out bool hasTypeForwardedFrom) { }

	// RVA: 0x1B2F530 Offset: 0x1B2DF30 VA: 0x181B2F530
	internal static string GetClrTypeFullName(Type type) { }

	// RVA: 0x1B2EF10 Offset: 0x1B2D910 VA: 0x181B2EF10
	private static string GetClrTypeFullNameForArray(Type type) { }

	// RVA: 0x1B2F140 Offset: 0x1B2DB40 VA: 0x181B2F140
	private static string GetClrTypeFullNameForNonArrayTypes(Type type) { }
}
