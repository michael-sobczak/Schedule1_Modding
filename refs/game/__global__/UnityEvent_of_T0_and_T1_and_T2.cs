public class UnityEvent<T0, T1, T2> : UnityEventBase // TypeDefIndex: 11971
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
	|-UnityEvent<bool, bool, bool>..ctor
	|-UnityEvent<object, int, int>..ctor
	|-UnityEvent<float, float, float>..ctor
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void AddListener(UnityAction<T0, T1, T2> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D2020 Offset: 0x12D0A20 VA: 0x1812D2020
	|-UnityEvent<bool, bool, bool>.AddListener
	|-UnityEvent<object, int, int>.AddListener
	|-UnityEvent<float, float, float>.AddListener
	|
	|-RVA: 0x12CD010 Offset: 0x12CBA10 VA: 0x1812CD010
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddListener
	*/

	// RVA: -1 Offset: -1
	public void RemoveListener(UnityAction<T0, T1, T2> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CFEB0 Offset: 0x12CE8B0 VA: 0x1812CFEB0
	|-UnityEvent<bool, bool, bool>.RemoveListener
	|-UnityEvent<object, int, int>.RemoveListener
	|-UnityEvent<float, float, float>.RemoveListener
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveListener
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D2480 Offset: 0x12D0E80 VA: 0x1812D2480
	|-UnityEvent<bool, bool, bool>.FindMethod_Impl
	|
	|-RVA: 0x12D22B0 Offset: 0x12D0CB0 VA: 0x1812D22B0
	|-UnityEvent<object, int, int>.FindMethod_Impl
	|
	|-RVA: 0x12D2650 Offset: 0x12D1050 VA: 0x1812D2650
	|-UnityEvent<float, float, float>.FindMethod_Impl
	|
	|-RVA: 0x12D20E0 Offset: 0x12D0AE0 VA: 0x1812D20E0
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D2AF0 Offset: 0x12D14F0 VA: 0x1812D2AF0
	|-UnityEvent<bool, bool, bool>.GetDelegate
	|
	|-RVA: 0x12D2820 Offset: 0x12D1220 VA: 0x1812D2820
	|-UnityEvent<object, int, int>.GetDelegate
	|
	|-RVA: 0x12D2930 Offset: 0x12D1330 VA: 0x1812D2930
	|-UnityEvent<float, float, float>.GetDelegate
	|
	|-RVA: 0x12D29B0 Offset: 0x12D13B0 VA: 0x1812D29B0
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	private static BaseInvokableCall GetDelegate(UnityAction<T0, T1, T2> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D28A0 Offset: 0x12D12A0 VA: 0x1812D28A0
	|-UnityEvent<bool, bool, bool>.GetDelegate
	|-UnityEvent<object, int, int>.GetDelegate
	|-UnityEvent<float, float, float>.GetDelegate
	|
	|-RVA: 0x12D2A30 Offset: 0x12D1430 VA: 0x1812D2A30
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D38A0 Offset: 0x12D22A0 VA: 0x1812D38A0
	|-UnityEvent<bool, bool, bool>.Invoke
	|
	|-RVA: 0x12D2B70 Offset: 0x12D1570 VA: 0x1812D2B70
	|-UnityEvent<object, int, int>.Invoke
	|
	|-RVA: 0x12D2EF0 Offset: 0x12D18F0 VA: 0x1812D2EF0
	|-UnityEvent<float, float, float>.Invoke
	|
	|-RVA: 0x12D32D0 Offset: 0x12D1CD0 VA: 0x1812D32D0
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}
