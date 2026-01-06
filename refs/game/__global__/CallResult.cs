public sealed class CallResult.APIDispatchDelegate<T> : MulticastDelegate // TypeDefIndex: 14707
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFE2C10 Offset: 0xFE1610 VA: 0x180FE2C10
	|-CallResult.APIDispatchDelegate<EncryptedAppTicketResponse_t>..ctor
	|
	|-RVA: 0xFE2AF0 Offset: 0xFE14F0 VA: 0x180FE2AF0
	|-CallResult.APIDispatchDelegate<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T param, bool bIOFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5554B0 Offset: 0x553EB0 VA: 0x1805554B0
	|-CallResult.APIDispatchDelegate<EncryptedAppTicketResponse_t>.Invoke
	|-CallResult.APIDispatchDelegate<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T param, bool bIOFailure, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFE2A50 Offset: 0xFE1450 VA: 0x180FE2A50
	|-CallResult.APIDispatchDelegate<EncryptedAppTicketResponse_t>.BeginInvoke
	|
	|-RVA: 0xFE2990 Offset: 0xFE1390 VA: 0x180FE2990
	|-CallResult.APIDispatchDelegate<__Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00
	|-CallResult.APIDispatchDelegate<EncryptedAppTicketResponse_t>.EndInvoke
	|-CallResult.APIDispatchDelegate<__Il2CppFullySharedGenericType>.EndInvoke
	*/
}
