internal static class SecurityUtils // TypeDefIndex: 9495
{
	// Methods

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private static void DemandReflectionAccess(Type type) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private static void DemandGrantSet(Assembly assembly) { }

	// RVA: 0x260AA10 Offset: 0x2609410 VA: 0x18260AA10
	private static bool HasReflectionPermission(Type type) { }

	// RVA: 0x260AE60 Offset: 0x2609860 VA: 0x18260AE60
	internal static object SecureCreateInstance(Type type) { }

	// RVA: 0x260AE70 Offset: 0x2609870 VA: 0x18260AE70
	internal static object SecureCreateInstance(Type type, object[] args, bool allowNonPublic) { }

	// RVA: 0x260AF90 Offset: 0x2609990 VA: 0x18260AF90
	internal static object SecureCreateInstance(Type type, object[] args) { }

	// RVA: 0x260AB60 Offset: 0x2609560 VA: 0x18260AB60
	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic) { }

	// RVA: 0x260ACE0 Offset: 0x26096E0 VA: 0x18260ACE0
	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic, BindingFlags extraFlags) { }

	// RVA: 0x260A960 Offset: 0x2609360 VA: 0x18260A960
	private static bool GenericArgumentsAreVisible(MethodInfo method) { }

	// RVA: 0x260AA30 Offset: 0x2609430 VA: 0x18260AA30
	internal static object MethodInfoInvoke(MethodInfo method, object target, object[] args) { }
}
