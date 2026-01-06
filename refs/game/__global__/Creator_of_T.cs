internal sealed class Creator<T> : MulticastDelegate // TypeDefIndex: 11185
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E6250 Offset: 0x11E4C50 VA: 0x1811E6250
	|-Creator<__Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 13
	public virtual T Invoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x593430 Offset: 0x591E30 VA: 0x180593430
	|-Creator<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x454BD0 Offset: 0x4535D0 VA: 0x180454BD0
	|-Creator<__Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual T EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105F5C0 Offset: 0x105DFC0 VA: 0x18105F5C0
	|-Creator<__Il2CppFullySharedGenericType>.EndInvoke
	*/
}
