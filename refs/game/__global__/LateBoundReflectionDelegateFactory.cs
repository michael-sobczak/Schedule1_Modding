internal class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory // TypeDefIndex: 11182
{
	// Fields
	private static readonly LateBoundReflectionDelegateFactory _instance; // 0x0

	// Properties
	internal static ReflectionDelegateFactory Instance { get; }

	// Methods

	// RVA: 0x1D6BFE0 Offset: 0x1D6A9E0 VA: 0x181D6BFE0
	internal static ReflectionDelegateFactory get_Instance() { }

	// RVA: 0x1D6BDD0 Offset: 0x1D6A7D0 VA: 0x181D6BDD0 Slot: 5
	public override ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method) { }

	// RVA: -1 Offset: -1 Slot: 4
	public override MethodCall<T, object> CreateMethodCall<T>(MethodBase method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE9B30 Offset: 0xEE8530 VA: 0x180EE9B30
	|-LateBoundReflectionDelegateFactory.CreateMethodCall<object>
	|
	|-RVA: 0xEE9970 Offset: 0xEE8370 VA: 0x180EE9970
	|-LateBoundReflectionDelegateFactory.CreateMethodCall<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override Func<T> CreateDefaultConstructor<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE9390 Offset: 0xEE7D90 VA: 0x180EE9390
	|-LateBoundReflectionDelegateFactory.CreateDefaultConstructor<object>
	|
	|-RVA: 0xEE9160 Offset: 0xEE7B60 VA: 0x180EE9160
	|-LateBoundReflectionDelegateFactory.CreateDefaultConstructor<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override Func<T, object> CreateGet<T>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE9790 Offset: 0xEE8190 VA: 0x180EE9790
	|-LateBoundReflectionDelegateFactory.CreateGet<object>
	|
	|-RVA: 0xEE96A0 Offset: 0xEE80A0 VA: 0x180EE96A0
	|-LateBoundReflectionDelegateFactory.CreateGet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override Func<T, object> CreateGet<T>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE9880 Offset: 0xEE8280 VA: 0x180EE9880
	|-LateBoundReflectionDelegateFactory.CreateGet<object>
	|
	|-RVA: 0xEE95B0 Offset: 0xEE7FB0 VA: 0x180EE95B0
	|-LateBoundReflectionDelegateFactory.CreateGet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override Action<T, object> CreateSet<T>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE9DE0 Offset: 0xEE87E0 VA: 0x180EE9DE0
	|-LateBoundReflectionDelegateFactory.CreateSet<object>
	|
	|-RVA: 0xEE95B0 Offset: 0xEE7FB0 VA: 0x180EE95B0
	|-LateBoundReflectionDelegateFactory.CreateSet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override Action<T, object> CreateSet<T>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE9CF0 Offset: 0xEE86F0 VA: 0x180EE9CF0
	|-LateBoundReflectionDelegateFactory.CreateSet<object>
	|
	|-RVA: 0xEE96A0 Offset: 0xEE80A0 VA: 0x180EE96A0
	|-LateBoundReflectionDelegateFactory.CreateSet<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x1D6BF70 Offset: 0x1D6A970 VA: 0x181D6BF70
	private static void .cctor() { }
}
