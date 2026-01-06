internal abstract class ReflectionDelegateFactory // TypeDefIndex: 11187
{
	// Methods

	// RVA: -1 Offset: -1
	public Func<T, object> CreateGet<T>(MemberInfo memberInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF30140 Offset: 0xF2EB40 VA: 0x180F30140
	|-ReflectionDelegateFactory.CreateGet<object>
	|-ReflectionDelegateFactory.CreateGet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Action<T, object> CreateSet<T>(MemberInfo memberInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF30340 Offset: 0xF2ED40 VA: 0x180F30340
	|-ReflectionDelegateFactory.CreateSet<object>
	|-ReflectionDelegateFactory.CreateSet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract MethodCall<T, object> CreateMethodCall<T>(MethodBase method);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateMethodCall<__Il2CppFullySharedGenericType>
	|-ReflectionDelegateFactory.CreateMethodCall<object>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Func<T> CreateDefaultConstructor<T>(Type type);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateDefaultConstructor<__Il2CppFullySharedGenericType>
	|-ReflectionDelegateFactory.CreateDefaultConstructor<object>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Func<T, object> CreateGet<T>(PropertyInfo propertyInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateGet<__Il2CppFullySharedGenericType>
	|-ReflectionDelegateFactory.CreateGet<object>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public abstract Func<T, object> CreateGet<T>(FieldInfo fieldInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateGet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Action<T, object> CreateSet<T>(FieldInfo fieldInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateSet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Action<T, object> CreateSet<T>(PropertyInfo propertyInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateSet<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
