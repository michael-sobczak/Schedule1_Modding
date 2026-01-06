public sealed class EventCallback<TEventType, TCallbackArgs> : MulticastDelegate // TypeDefIndex: 6525
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AD500 Offset: 0x17ABF00 VA: 0x1817AD500
	|-EventCallback<object, object>..ctor
	|
	|-RVA: 0x17AD3E0 Offset: 0x17ABDE0 VA: 0x1817AD3E0
	|-EventCallback<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(TEventType evt, TCallbackArgs userArgs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5554B0 Offset: 0x553EB0 VA: 0x1805554B0
	|-EventCallback<object, object>.Invoke
	|-EventCallback<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}
