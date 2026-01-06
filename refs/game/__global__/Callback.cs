public sealed class Callback.DispatchDelegate<T> : MulticastDelegate // TypeDefIndex: 14704
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0F840 Offset: 0xB0E240 VA: 0x180B0F840
	|-Callback.DispatchDelegate<GameLobbyJoinRequested_t>..ctor
	|-Callback.DispatchDelegate<LobbyCreated_t>..ctor
	|
	|-RVA: 0xFE2F60 Offset: 0xFE1960 VA: 0x180FE2F60
	|-Callback.DispatchDelegate<LobbyChatMsg_t>..ctor
	|-Callback.DispatchDelegate<LobbyEnter_t>..ctor
	|
	|-RVA: 0xFE3220 Offset: 0xFE1C20 VA: 0x180FE3220
	|-Callback.DispatchDelegate<LobbyChatUpdate_t>..ctor
	|
	|-RVA: 0x1630EF0 Offset: 0x162F8F0 VA: 0x181630EF0
	|-Callback.DispatchDelegate<SteamNetConnectionStatusChangedCallback_t>..ctor
	|
	|-RVA: 0x12CB010 Offset: 0x12C9A10 VA: 0x1812CB010
	|-Callback.DispatchDelegate<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T param) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0F810 Offset: 0xB0E210 VA: 0x180B0F810
	|-Callback.DispatchDelegate<GameLobbyJoinRequested_t>.Invoke
	|-Callback.DispatchDelegate<LobbyCreated_t>.Invoke
	|
	|-RVA: 0xFE2D90 Offset: 0xFE1790 VA: 0x180FE2D90
	|-Callback.DispatchDelegate<LobbyChatMsg_t>.Invoke
	|-Callback.DispatchDelegate<LobbyEnter_t>.Invoke
	|
	|-RVA: 0xFE2E80 Offset: 0xFE1880 VA: 0x180FE2E80
	|-Callback.DispatchDelegate<LobbyChatUpdate_t>.Invoke
	|
	|-RVA: 0x1630E40 Offset: 0x162F840 VA: 0x181630E40
	|-Callback.DispatchDelegate<SteamNetConnectionStatusChangedCallback_t>.Invoke
	|
	|-RVA: 0x593430 Offset: 0x591E30 VA: 0x180593430
	|-Callback.DispatchDelegate<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T param, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1630B70 Offset: 0x162F570 VA: 0x181630B70
	|-Callback.DispatchDelegate<GameLobbyJoinRequested_t>.BeginInvoke
	|
	|-RVA: 0x1630AE0 Offset: 0x162F4E0 VA: 0x181630AE0
	|-Callback.DispatchDelegate<LobbyChatMsg_t>.BeginInvoke
	|
	|-RVA: 0x1630C00 Offset: 0x162F600 VA: 0x181630C00
	|-Callback.DispatchDelegate<LobbyChatUpdate_t>.BeginInvoke
	|
	|-RVA: 0x1630D20 Offset: 0x162F720 VA: 0x181630D20
	|-Callback.DispatchDelegate<LobbyCreated_t>.BeginInvoke
	|
	|-RVA: 0x1630C90 Offset: 0x162F690 VA: 0x181630C90
	|-Callback.DispatchDelegate<LobbyEnter_t>.BeginInvoke
	|
	|-RVA: 0x1630DB0 Offset: 0x162F7B0 VA: 0x181630DB0
	|-Callback.DispatchDelegate<SteamNetConnectionStatusChangedCallback_t>.BeginInvoke
	|
	|-RVA: 0x12765D0 Offset: 0x1274FD0 VA: 0x1812765D0
	|-Callback.DispatchDelegate<__Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00
	|-Callback.DispatchDelegate<GameLobbyJoinRequested_t>.EndInvoke
	|-Callback.DispatchDelegate<LobbyChatMsg_t>.EndInvoke
	|-Callback.DispatchDelegate<LobbyChatUpdate_t>.EndInvoke
	|-Callback.DispatchDelegate<LobbyCreated_t>.EndInvoke
	|-Callback.DispatchDelegate<LobbyEnter_t>.EndInvoke
	|-Callback.DispatchDelegate<SteamNetConnectionStatusChangedCallback_t>.EndInvoke
	|-Callback.DispatchDelegate<__Il2CppFullySharedGenericType>.EndInvoke
	*/
}
