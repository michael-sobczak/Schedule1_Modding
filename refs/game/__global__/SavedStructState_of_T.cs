internal sealed class SavedStructState<T> : ISavedState // TypeDefIndex: 7847
{
	// Fields
	private T m_State; // 0x0
	private SavedStructState.TypedRestore<T> m_RestoreAction; // 0x0
	private Action m_StaticDisposeCurrentState; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ref T state, SavedStructState.TypedRestore<T> restoreAction, Action staticDisposeCurrentState) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B1D50 Offset: 0x11B0750 VA: 0x1811B1D50
	|-SavedStructState<__Il2CppFullySharedGenericStructType>..ctor
	|
	|-RVA: 0x11B1E90 Offset: 0x11B0890 VA: 0x1811B1E90
	|-SavedStructState<InputActionState.GlobalState>..ctor
	|
	|-RVA: 0x11B2010 Offset: 0x11B0A10 VA: 0x1811B2010
	|-SavedStructState<InputUser.GlobalState>..ctor
	|
	|-RVA: 0x11B1BC0 Offset: 0x11B05C0 VA: 0x1811B1BC0
	|-SavedStructState<Touch.GlobalState>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void StaticDisposeCurrentState() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B1AF0 Offset: 0x11B04F0 VA: 0x1811B1AF0
	|-SavedStructState<__Il2CppFullySharedGenericStructType>.StaticDisposeCurrentState
	|
	|-RVA: 0x11B1A50 Offset: 0x11B0450 VA: 0x1811B1A50
	|-SavedStructState<InputActionState.GlobalState>.StaticDisposeCurrentState
	|
	|-RVA: 0x11B1AA0 Offset: 0x11B04A0 VA: 0x1811B1AA0
	|-SavedStructState<InputUser.GlobalState>.StaticDisposeCurrentState
	|
	|-RVA: 0x11B1A00 Offset: 0x11B0400 VA: 0x1811B1A00
	|-SavedStructState<Touch.GlobalState>.StaticDisposeCurrentState
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void RestoreSavedState() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B1910 Offset: 0x11B0310 VA: 0x1811B1910
	|-SavedStructState<__Il2CppFullySharedGenericStructType>.RestoreSavedState
	|
	|-RVA: 0x11B1870 Offset: 0x11B0270 VA: 0x1811B1870
	|-SavedStructState<InputActionState.GlobalState>.RestoreSavedState
	|
	|-RVA: 0x11B18C0 Offset: 0x11B02C0 VA: 0x1811B18C0
	|-SavedStructState<InputUser.GlobalState>.RestoreSavedState
	|
	|-RVA: 0x11B1820 Offset: 0x11B0220 VA: 0x1811B1820
	|-SavedStructState<Touch.GlobalState>.RestoreSavedState
	*/
}
