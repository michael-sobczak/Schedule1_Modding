public sealed class SavedStructState.TypedRestore<T> : MulticastDelegate // TypeDefIndex: 7846
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12C7EF0 Offset: 0x12C68F0 VA: 0x1812C7EF0
	|-SavedStructState.TypedRestore<__Il2CppFullySharedGenericStructType>..ctor
	|-SavedStructState.TypedRestore<InputActionState.GlobalState>..ctor
	|-SavedStructState.TypedRestore<InputUser.GlobalState>..ctor
	|-SavedStructState.TypedRestore<Touch.GlobalState>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(ref T state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x593430 Offset: 0x591E30 VA: 0x180593430
	|-SavedStructState.TypedRestore<__Il2CppFullySharedGenericStructType>.Invoke
	|-SavedStructState.TypedRestore<InputActionState.GlobalState>.Invoke
	|-SavedStructState.TypedRestore<InputUser.GlobalState>.Invoke
	|-SavedStructState.TypedRestore<Touch.GlobalState>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref T state, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12C7D10 Offset: 0x12C6710 VA: 0x1812C7D10
	|-SavedStructState.TypedRestore<__Il2CppFullySharedGenericStructType>.BeginInvoke
	|
	|-RVA: 0x12C7E40 Offset: 0x12C6840 VA: 0x1812C7E40
	|-SavedStructState.TypedRestore<InputActionState.GlobalState>.BeginInvoke
	|
	|-RVA: 0x12C7DB0 Offset: 0x12C67B0 VA: 0x1812C7DB0
	|-SavedStructState.TypedRestore<InputUser.GlobalState>.BeginInvoke
	|
	|-RVA: 0x12C7C80 Offset: 0x12C6680 VA: 0x1812C7C80
	|-SavedStructState.TypedRestore<Touch.GlobalState>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(ref T state, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12C7ED0 Offset: 0x12C68D0 VA: 0x1812C7ED0
	|-SavedStructState.TypedRestore<__Il2CppFullySharedGenericStructType>.EndInvoke
	|-SavedStructState.TypedRestore<InputActionState.GlobalState>.EndInvoke
	|-SavedStructState.TypedRestore<InputUser.GlobalState>.EndInvoke
	|-SavedStructState.TypedRestore<Touch.GlobalState>.EndInvoke
	*/
}
