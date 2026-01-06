public sealed class ReplicateUserLogicDelegate<T> : MulticastDelegate // TypeDefIndex: 12606
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A7C90 Offset: 0x11A6690 VA: 0x1811A7C90
	|-ReplicateUserLogicDelegate<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x11A7BE0 Offset: 0x11A65E0 VA: 0x1811A7BE0
	|-ReplicateUserLogicDelegate<RigidbodyPrediction.MoveData>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T data, bool asServer, Channel channel, bool replaying) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD071A0 Offset: 0xD05BA0 VA: 0x180D071A0
	|-ReplicateUserLogicDelegate<__Il2CppFullySharedGenericType>.Invoke
	|
	|-RVA: 0x11A7BA0 Offset: 0x11A65A0 VA: 0x1811A7BA0
	|-ReplicateUserLogicDelegate<RigidbodyPrediction.MoveData>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T data, bool asServer, Channel channel, bool replaying, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A79C0 Offset: 0x11A63C0 VA: 0x1811A79C0
	|-ReplicateUserLogicDelegate<__Il2CppFullySharedGenericType>.BeginInvoke
	|
	|-RVA: 0x11A7AC0 Offset: 0x11A64C0 VA: 0x1811A7AC0
	|-ReplicateUserLogicDelegate<RigidbodyPrediction.MoveData>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00
	|-ReplicateUserLogicDelegate<__Il2CppFullySharedGenericType>.EndInvoke
	|-ReplicateUserLogicDelegate<RigidbodyPrediction.MoveData>.EndInvoke
	*/
}
