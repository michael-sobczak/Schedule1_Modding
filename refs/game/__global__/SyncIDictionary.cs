public sealed class SyncIDictionary.SyncDictionaryChanged<TKey, TValue> : MulticastDelegate // TypeDefIndex: 12628
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EE0A0 Offset: 0x11ECAA0 VA: 0x1811EE0A0
	|-SyncIDictionary.SyncDictionaryChanged<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(SyncDictionaryOperation op, TKey key, TValue value, bool asServer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD071A0 Offset: 0xD05BA0 VA: 0x180D071A0
	|-SyncIDictionary.SyncDictionaryChanged<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(SyncDictionaryOperation op, TKey key, TValue value, bool asServer, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EDF70 Offset: 0x11EC970 VA: 0x1811EDF70
	|-SyncIDictionary.SyncDictionaryChanged<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00
	|-SyncIDictionary.SyncDictionaryChanged<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.EndInvoke
	*/
}
