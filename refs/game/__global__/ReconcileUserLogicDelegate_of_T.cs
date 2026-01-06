public sealed class ReconcileUserLogicDelegate<T> : MulticastDelegate // TypeDefIndex: 12607
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A0EC0 Offset: 0x119F8C0 VA: 0x1811A0EC0
	|-ReconcileUserLogicDelegate<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x11A0FE0 Offset: 0x119F9E0 VA: 0x1811A0FE0
	|-ReconcileUserLogicDelegate<RigidbodyPrediction.ReconcileData>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T data, bool asServer, Channel channel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x566F40 Offset: 0x565940 VA: 0x180566F40
	|-ReconcileUserLogicDelegate<__Il2CppFullySharedGenericType>.Invoke
	|
	|-RVA: 0x11A0E70 Offset: 0x119F870 VA: 0x1811A0E70
	|-ReconcileUserLogicDelegate<RigidbodyPrediction.ReconcileData>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T data, bool asServer, Channel channel, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A0D90 Offset: 0x119F790 VA: 0x1811A0D90
	|-ReconcileUserLogicDelegate<__Il2CppFullySharedGenericType>.BeginInvoke
	|
	|-RVA: 0x11A0CD0 Offset: 0x119F6D0 VA: 0x1811A0CD0
	|-ReconcileUserLogicDelegate<RigidbodyPrediction.ReconcileData>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00
	|-ReconcileUserLogicDelegate<__Il2CppFullySharedGenericType>.EndInvoke
	|-ReconcileUserLogicDelegate<RigidbodyPrediction.ReconcileData>.EndInvoke
	*/
}
