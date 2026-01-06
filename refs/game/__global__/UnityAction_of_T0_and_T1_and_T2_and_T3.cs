public sealed class UnityAction<T0, T1, T2, T3> : MulticastDelegate // TypeDefIndex: 11972
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CC530 Offset: 0x12CAF30 VA: 0x1812CC530
	|-UnityAction<object, object, object, object>..ctor
	|
	|-RVA: 0x12CC660 Offset: 0x12CB060 VA: 0x1812CC660
	|-UnityAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC84DF0 Offset: 0xC837F0 VA: 0x180C84DF0
	|-UnityAction<object, object, object, object>.Invoke
	|-UnityAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CC370 Offset: 0x12CAD70 VA: 0x1812CC370
	|-UnityAction<object, object, object, object>.BeginInvoke
	|
	|-RVA: 0x12CC3C0 Offset: 0x12CADC0 VA: 0x1812CC3C0
	|-UnityAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00
	|-UnityAction<object, object, object, object>.EndInvoke
	|-UnityAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.EndInvoke
	*/
}
