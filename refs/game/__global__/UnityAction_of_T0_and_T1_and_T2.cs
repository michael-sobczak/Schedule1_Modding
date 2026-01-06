public sealed class UnityAction<T0, T1, T2> : MulticastDelegate // TypeDefIndex: 11970
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CBFC0 Offset: 0x12CA9C0 VA: 0x1812CBFC0
	|-UnityAction<bool, bool, bool>..ctor
	|
	|-RVA: 0x12CC190 Offset: 0x12CAB90 VA: 0x1812CC190
	|-UnityAction<object, int, int>..ctor
	|
	|-RVA: 0x12CC2C0 Offset: 0x12CACC0 VA: 0x1812CC2C0
	|-UnityAction<float, float, float>..ctor
	|
	|-RVA: 0x12CC070 Offset: 0x12CAA70 VA: 0x1812CC070
	|-UnityAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x566F40 Offset: 0x565940 VA: 0x180566F40
	|-UnityAction<bool, bool, bool>.Invoke
	|-UnityAction<object, int, int>.Invoke
	|-UnityAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	|
	|-RVA: 0x12CBFA0 Offset: 0x12CA9A0 VA: 0x1812CBFA0
	|-UnityAction<float, float, float>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T0 arg0, T1 arg1, T2 arg2, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CBCA0 Offset: 0x12CA6A0 VA: 0x1812CBCA0
	|-UnityAction<bool, bool, bool>.BeginInvoke
	|
	|-RVA: 0x12CBD40 Offset: 0x12CA740 VA: 0x1812CBD40
	|-UnityAction<object, int, int>.BeginInvoke
	|
	|-RVA: 0x12CBF00 Offset: 0x12CA900 VA: 0x1812CBF00
	|-UnityAction<float, float, float>.BeginInvoke
	|
	|-RVA: 0x12CBDE0 Offset: 0x12CA7E0 VA: 0x1812CBDE0
	|-UnityAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00
	|-UnityAction<bool, bool, bool>.EndInvoke
	|-UnityAction<object, int, int>.EndInvoke
	|-UnityAction<float, float, float>.EndInvoke
	|-UnityAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.EndInvoke
	*/
}
