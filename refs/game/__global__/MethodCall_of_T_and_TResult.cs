internal sealed class MethodCall<T, TResult> : MulticastDelegate // TypeDefIndex: 11184
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105F670 Offset: 0x105E070 VA: 0x18105F670
	|-MethodCall<object, object>..ctor
	|
	|-RVA: 0x105F7A0 Offset: 0x105E1A0 VA: 0x18105F7A0
	|-MethodCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T target, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5554B0 Offset: 0x553EB0 VA: 0x1805554B0
	|-MethodCall<object, object>.Invoke
	|
	|-RVA: 0x566F40 Offset: 0x565940 VA: 0x180566F40
	|-MethodCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T target, object[] args, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65BAF0 Offset: 0x65A4F0 VA: 0x18065BAF0
	|-MethodCall<object, object>.BeginInvoke
	|
	|-RVA: 0x105F520 Offset: 0x105DF20 VA: 0x18105F520
	|-MethodCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00
	|-MethodCall<object, object>.EndInvoke
	|
	|-RVA: 0x105F5C0 Offset: 0x105DFC0 VA: 0x18105F5C0
	|-MethodCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.EndInvoke
	*/
}
