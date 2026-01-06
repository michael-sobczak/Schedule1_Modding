public class UnityEvent<T0, T1, T2, T3> : UnityEventBase // TypeDefIndex: 11973
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CFF00 Offset: 0x12CE900 VA: 0x1812CFF00
	|-UnityEvent<object, object, object, object>..ctor
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void AddListener(UnityAction<T0, T1, T2, T3> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D3C60 Offset: 0x12D2660 VA: 0x1812D3C60
	|-UnityEvent<object, object, object, object>.AddListener
	|
	|-RVA: 0x12CD010 Offset: 0x12CBA10 VA: 0x1812CD010
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddListener
	*/

	// RVA: -1 Offset: -1
	public void RemoveListener(UnityAction<T0, T1, T2, T3> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CFEB0 Offset: 0x12CE8B0 VA: 0x1812CFEB0
	|-UnityEvent<object, object, object, object>.RemoveListener
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveListener
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D3D20 Offset: 0x12D2720 VA: 0x1812D3D20
	|-UnityEvent<object, object, object, object>.FindMethod_Impl
	|
	|-RVA: 0x12D3F60 Offset: 0x12D2960 VA: 0x1812D3F60
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D4220 Offset: 0x12D2C20 VA: 0x1812D4220
	|-UnityEvent<object, object, object, object>.GetDelegate
	|
	|-RVA: 0x12D41A0 Offset: 0x12D2BA0 VA: 0x1812D41A0
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	private static BaseInvokableCall GetDelegate(UnityAction<T0, T1, T2, T3> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D42A0 Offset: 0x12D2CA0 VA: 0x1812D42A0
	|-UnityEvent<object, object, object, object>.GetDelegate
	|
	|-RVA: 0x12D4330 Offset: 0x12D2D30 VA: 0x1812D4330
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D4B00 Offset: 0x12D3500 VA: 0x1812D4B00
	|-UnityEvent<object, object, object, object>.Invoke
	|
	|-RVA: 0x12D43F0 Offset: 0x12D2DF0 VA: 0x1812D43F0
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}
