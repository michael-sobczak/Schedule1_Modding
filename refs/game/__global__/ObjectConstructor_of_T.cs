public sealed class ObjectConstructor<T> : MulticastDelegate // TypeDefIndex: 11271
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BBD60 Offset: 0x10BA760 VA: 0x1810BBD60
	|-ObjectConstructor<object>..ctor
	|-ObjectConstructor<__Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 13
	public virtual object Invoke(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x593430 Offset: 0x591E30 VA: 0x180593430
	|-ObjectConstructor<object>.Invoke
	|-ObjectConstructor<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(object[] args, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x593400 Offset: 0x591E00 VA: 0x180593400
	|-ObjectConstructor<object>.BeginInvoke
	|-ObjectConstructor<__Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual object EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00
	|-ObjectConstructor<object>.EndInvoke
	|-ObjectConstructor<__Il2CppFullySharedGenericType>.EndInvoke
	*/
}
