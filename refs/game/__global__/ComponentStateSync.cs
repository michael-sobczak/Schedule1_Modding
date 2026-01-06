public sealed class ComponentStateSync.StateChanged<T> : MulticastDelegate // TypeDefIndex: 18102
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E6120 Offset: 0x11E4B20 VA: 0x1811E6120
	|-ComponentStateSync.StateChanged<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T component, bool prevState, bool nextState, bool asServer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD071A0 Offset: 0xD05BA0 VA: 0x180D071A0
	|-ComponentStateSync.StateChanged<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T component, bool prevState, bool nextState, bool asServer, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E6060 Offset: 0x11E4A60 VA: 0x1811E6060
	|-ComponentStateSync.StateChanged<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00
	|-ComponentStateSync.StateChanged<object>.EndInvoke
	*/
}
