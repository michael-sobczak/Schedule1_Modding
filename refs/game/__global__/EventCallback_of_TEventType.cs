public sealed class EventCallback<TEventType> : MulticastDelegate // TypeDefIndex: 6524
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x593440 Offset: 0x591E40 VA: 0x180593440
	|-EventCallback<object>..ctor
	|
	|-RVA: 0x12CB010 Offset: 0x12C9A10 VA: 0x1812CB010
	|-EventCallback<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(TEventType evt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x593430 Offset: 0x591E30 VA: 0x180593430
	|-EventCallback<object>.Invoke
	|-EventCallback<__Il2CppFullySharedGenericType>.Invoke
	*/
}
