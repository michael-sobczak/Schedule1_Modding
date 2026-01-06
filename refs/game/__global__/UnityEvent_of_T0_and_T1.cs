public class UnityEvent<T0, T1> : UnityEventBase // TypeDefIndex: 11969
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
	|-UnityEvent<Color, int>..ctor
	|-UnityEvent<Int32Enum, float>..ctor
	|-UnityEvent<object, int>..ctor
	|-UnityEvent<object, object>..ctor
	|-UnityEvent<float, float>..ctor
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void AddListener(UnityAction<T0, T1> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CFF30 Offset: 0x12CE930 VA: 0x1812CFF30
	|-UnityEvent<Color, int>.AddListener
	|-UnityEvent<Int32Enum, float>.AddListener
	|-UnityEvent<object, int>.AddListener
	|-UnityEvent<object, object>.AddListener
	|-UnityEvent<float, float>.AddListener
	|
	|-RVA: 0x12CD010 Offset: 0x12CBA10 VA: 0x1812CD010
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddListener
	*/

	// RVA: -1 Offset: -1
	public void RemoveListener(UnityAction<T0, T1> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CFEB0 Offset: 0x12CE8B0 VA: 0x1812CFEB0
	|-UnityEvent<Color, int>.RemoveListener
	|-UnityEvent<Int32Enum, float>.RemoveListener
	|-UnityEvent<object, int>.RemoveListener
	|-UnityEvent<object, object>.RemoveListener
	|-UnityEvent<float, float>.RemoveListener
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveListener
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D0160 Offset: 0x12CEB60 VA: 0x1812D0160
	|-UnityEvent<Color, int>.FindMethod_Impl
	|
	|-RVA: 0x12D0720 Offset: 0x12CF120 VA: 0x1812D0720
	|-UnityEvent<Int32Enum, float>.FindMethod_Impl
	|
	|-RVA: 0x12D05B0 Offset: 0x12CEFB0 VA: 0x1812D05B0
	|-UnityEvent<object, int>.FindMethod_Impl
	|
	|-RVA: 0x12CFFF0 Offset: 0x12CE9F0 VA: 0x1812CFFF0
	|-UnityEvent<object, object>.FindMethod_Impl
	|
	|-RVA: 0x12D0440 Offset: 0x12CEE40 VA: 0x1812D0440
	|-UnityEvent<float, float>.FindMethod_Impl
	|
	|-RVA: 0x12D02D0 Offset: 0x12CECD0 VA: 0x1812D02D0
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D0890 Offset: 0x12CF290 VA: 0x1812D0890
	|-UnityEvent<Color, int>.GetDelegate
	|
	|-RVA: 0x12D0BA0 Offset: 0x12CF5A0 VA: 0x1812D0BA0
	|-UnityEvent<Int32Enum, float>.GetDelegate
	|
	|-RVA: 0x12D09A0 Offset: 0x12CF3A0 VA: 0x1812D09A0
	|-UnityEvent<object, int>.GetDelegate
	|
	|-RVA: 0x12D0B20 Offset: 0x12CF520 VA: 0x1812D0B20
	|-UnityEvent<object, object>.GetDelegate
	|
	|-RVA: 0x12D0A20 Offset: 0x12CF420 VA: 0x1812D0A20
	|-UnityEvent<float, float>.GetDelegate
	|
	|-RVA: 0x12D0AA0 Offset: 0x12CF4A0 VA: 0x1812D0AA0
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	private static BaseInvokableCall GetDelegate(UnityAction<T0, T1> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D0910 Offset: 0x12CF310 VA: 0x1812D0910
	|-UnityEvent<Color, int>.GetDelegate
	|-UnityEvent<Int32Enum, float>.GetDelegate
	|-UnityEvent<object, int>.GetDelegate
	|-UnityEvent<object, object>.GetDelegate
	|-UnityEvent<float, float>.GetDelegate
	|
	|-RVA: 0x12D0C20 Offset: 0x12CF620 VA: 0x1812D0C20
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D19F0 Offset: 0x12D03F0 VA: 0x1812D19F0
	|-UnityEvent<Color, int>.Invoke
	|
	|-RVA: 0x12D0CE0 Offset: 0x12CF6E0 VA: 0x1812D0CE0
	|-UnityEvent<Int32Enum, float>.Invoke
	|
	|-RVA: 0x12D1000 Offset: 0x12CFA00 VA: 0x1812D1000
	|-UnityEvent<object, int>.Invoke
	|
	|-RVA: 0x12D1740 Offset: 0x12D0140 VA: 0x1812D1740
	|-UnityEvent<object, object>.Invoke
	|
	|-RVA: 0x12D1D00 Offset: 0x12D0700 VA: 0x1812D1D00
	|-UnityEvent<float, float>.Invoke
	|
	|-RVA: 0x12D12D0 Offset: 0x12CFCD0 VA: 0x1812D12D0
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}
