internal class AndroidReflection // TypeDefIndex: 18337
{
	// Fields
	private static readonly GlobalJavaObjectRef s_ReflectionHelperClass; // 0x0
	private static readonly IntPtr s_ReflectionHelperGetConstructorID; // 0x8
	private static readonly IntPtr s_ReflectionHelperGetMethodID; // 0x10
	private static readonly IntPtr s_ReflectionHelperGetFieldID; // 0x18
	private static readonly IntPtr s_ReflectionHelperGetFieldSignature; // 0x20
	private static readonly IntPtr s_ReflectionHelperNewProxyInstance; // 0x28
	private static readonly IntPtr s_ReflectionHelperCeateInvocationError; // 0x30
	private static readonly IntPtr s_FieldGetDeclaringClass; // 0x38

	// Methods

	// RVA: 0x1D95C40 Offset: 0x1D94640 VA: 0x181D95C40
	public static bool IsPrimitive(Type t) { }

	// RVA: 0x2C6D020 Offset: 0x2C6BA20 VA: 0x182C6D020
	public static bool IsAssignableFrom(Type t, Type from) { }

	// RVA: 0x2C6CF60 Offset: 0x2C6B960 VA: 0x182C6CF60
	private static IntPtr GetStaticMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x2C6CC80 Offset: 0x2C6B680 VA: 0x182C6CC80
	private static IntPtr GetMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x2C6CAD0 Offset: 0x2C6B4D0 VA: 0x182C6CAD0
	public static IntPtr GetConstructorMember(IntPtr jclass, string signature) { }

	// RVA: 0x2C6CD40 Offset: 0x2C6B740 VA: 0x182C6CD40
	public static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x2C6D050 Offset: 0x2C6BA50 VA: 0x182C6D050
	public static IntPtr NewProxyInstance(IntPtr player, IntPtr delegateHandle, IntPtr interfaze) { }

	// RVA: 0x2C6C990 Offset: 0x2C6B390 VA: 0x182C6C990
	internal static IntPtr CreateInvocationError(Exception ex, bool methodNotFound) { }

	// RVA: 0x2C6D190 Offset: 0x2C6BB90 VA: 0x182C6D190
	private static void .cctor() { }
}
