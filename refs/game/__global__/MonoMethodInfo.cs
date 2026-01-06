internal struct MonoMethodInfo // TypeDefIndex: 4757
{
	// Fields
	private Type parent; // 0x0
	private Type ret; // 0x8
	internal MethodAttributes attrs; // 0x10
	internal MethodImplAttributes iattrs; // 0x14
	private CallingConventions callconv; // 0x18

	// Methods

	// RVA: 0x1B8E450 Offset: 0x1B8CE50 VA: 0x181B8E450
	private static void get_method_info(IntPtr handle, out MonoMethodInfo info) { }

	// RVA: 0x1B8E250 Offset: 0x1B8CC50 VA: 0x181B8E250
	private static int get_method_attributes(IntPtr handle) { }

	// RVA: 0x1B8E2F0 Offset: 0x1B8CCF0 VA: 0x181B8E2F0
	internal static MonoMethodInfo GetMethodInfo(IntPtr handle) { }

	// RVA: 0x1B8E290 Offset: 0x1B8CC90 VA: 0x181B8E290
	internal static Type GetDeclaringType(IntPtr handle) { }

	// RVA: 0x1B8E420 Offset: 0x1B8CE20 VA: 0x181B8E420
	internal static Type GetReturnType(IntPtr handle) { }

	// RVA: 0x1B8E250 Offset: 0x1B8CC50 VA: 0x181B8E250
	internal static MethodAttributes GetAttributes(IntPtr handle) { }

	// RVA: 0x1B8E260 Offset: 0x1B8CC60 VA: 0x181B8E260
	internal static CallingConventions GetCallingConvention(IntPtr handle) { }

	// RVA: 0x1B8E2C0 Offset: 0x1B8CCC0 VA: 0x181B8E2C0
	internal static MethodImplAttributes GetMethodImplementationFlags(IntPtr handle) { }

	// RVA: 0x1B8E320 Offset: 0x1B8CD20 VA: 0x181B8E320
	private static ParameterInfo[] get_parameter_info(IntPtr handle, MemberInfo member) { }

	// RVA: 0x1B8E320 Offset: 0x1B8CD20 VA: 0x181B8E320
	internal static ParameterInfo[] GetParametersInfo(IntPtr handle, MemberInfo member) { }

	// RVA: 0x1B1FC20 Offset: 0x1B1E620 VA: 0x181B1FC20
	private static MarshalAsAttribute get_retval_marshal(IntPtr handle) { }

	// RVA: 0x1B8E330 Offset: 0x1B8CD30 VA: 0x181B8E330
	internal static ParameterInfo GetReturnParameterInfo(RuntimeMethodInfo method) { }
}
