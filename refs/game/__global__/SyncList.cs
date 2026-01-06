public sealed class SyncList.SyncListChanged<T> : MulticastDelegate // TypeDefIndex: 12641
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F9230 Offset: 0x11F7C30 VA: 0x1811F9230
	|-SyncList.SyncListChanged<int>..ctor
	|
	|-RVA: 0x11F9180 Offset: 0x11F7B80 VA: 0x1811F9180
	|-SyncList.SyncListChanged<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(SyncListOperation op, int index, T oldItem, T newItem, bool asServer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F9160 Offset: 0x11F7B60 VA: 0x1811F9160
	|-SyncList.SyncListChanged<int>.Invoke
	|-SyncList.SyncListChanged<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(SyncListOperation op, int index, T oldItem, T newItem, bool asServer, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F8F20 Offset: 0x11F7920 VA: 0x1811F8F20
	|-SyncList.SyncListChanged<int>.BeginInvoke
	|
	|-RVA: 0x11F9010 Offset: 0x11F7A10 VA: 0x1811F9010
	|-SyncList.SyncListChanged<__Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00
	|-SyncList.SyncListChanged<int>.EndInvoke
	|-SyncList.SyncListChanged<__Il2CppFullySharedGenericType>.EndInvoke
	*/
}
