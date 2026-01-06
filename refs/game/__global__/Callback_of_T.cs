public sealed class Callback<T> : Callback, IDisposable // TypeDefIndex: 14705
{
	// Fields
	[CompilerGenerated]
	private Callback.DispatchDelegate<T> m_Func; // 0x0
	private bool m_bGameServer; // 0x0
	private bool m_bIsRegistered; // 0x0
	private bool m_bDisposed; // 0x0

	// Properties
	public override bool IsGameServer { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void add_m_Func(Callback.DispatchDelegate<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1436CC0 Offset: 0x14356C0 VA: 0x181436CC0
	|-Callback<GameLobbyJoinRequested_t>.add_m_Func
	|-Callback<LobbyChatMsg_t>.add_m_Func
	|-Callback<LobbyChatUpdate_t>.add_m_Func
	|-Callback<LobbyCreated_t>.add_m_Func
	|-Callback<LobbyEnter_t>.add_m_Func
	|-Callback<SteamNetConnectionStatusChangedCallback_t>.add_m_Func
	|-Callback<__Il2CppFullySharedGenericType>.add_m_Func
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void remove_m_Func(Callback.DispatchDelegate<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1436D90 Offset: 0x1435790 VA: 0x181436D90
	|-Callback<GameLobbyJoinRequested_t>.remove_m_Func
	|-Callback<LobbyChatMsg_t>.remove_m_Func
	|-Callback<LobbyChatUpdate_t>.remove_m_Func
	|-Callback<LobbyCreated_t>.remove_m_Func
	|-Callback<LobbyEnter_t>.remove_m_Func
	|-Callback<SteamNetConnectionStatusChangedCallback_t>.remove_m_Func
	|-Callback<__Il2CppFullySharedGenericType>.remove_m_Func
	*/

	// RVA: -1 Offset: -1
	public static Callback<T> Create(Callback.DispatchDelegate<T> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1439D90 Offset: 0x1438790 VA: 0x181439D90
	|-Callback<GameLobbyJoinRequested_t>.Create
	|
	|-RVA: 0x1439ED0 Offset: 0x14388D0 VA: 0x181439ED0
	|-Callback<LobbyChatMsg_t>.Create
	|
	|-RVA: 0x1439F70 Offset: 0x1438970 VA: 0x181439F70
	|-Callback<LobbyChatUpdate_t>.Create
	|
	|-RVA: 0x1439C50 Offset: 0x1438650 VA: 0x181439C50
	|-Callback<LobbyCreated_t>.Create
	|
	|-RVA: 0x1439CF0 Offset: 0x14386F0 VA: 0x181439CF0
	|-Callback<LobbyEnter_t>.Create
	|
	|-RVA: 0x1439E30 Offset: 0x1438830 VA: 0x181439E30
	|-Callback<SteamNetConnectionStatusChangedCallback_t>.Create
	|
	|-RVA: 0x1439B90 Offset: 0x1438590 VA: 0x181439B90
	|-Callback<__Il2CppFullySharedGenericType>.Create
	*/

	// RVA: -1 Offset: -1
	public static Callback<T> CreateGameServer(Callback.DispatchDelegate<T> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1439710 Offset: 0x1438110 VA: 0x181439710
	|-Callback<GameLobbyJoinRequested_t>.CreateGameServer
	|
	|-RVA: 0x14398F0 Offset: 0x14382F0 VA: 0x1814398F0
	|-Callback<LobbyChatMsg_t>.CreateGameServer
	|
	|-RVA: 0x14397B0 Offset: 0x14381B0 VA: 0x1814397B0
	|-Callback<LobbyChatUpdate_t>.CreateGameServer
	|
	|-RVA: 0x1439850 Offset: 0x1438250 VA: 0x181439850
	|-Callback<LobbyCreated_t>.CreateGameServer
	|
	|-RVA: 0x1439990 Offset: 0x1438390 VA: 0x181439990
	|-Callback<LobbyEnter_t>.CreateGameServer
	|
	|-RVA: 0x1439AF0 Offset: 0x14384F0 VA: 0x181439AF0
	|-Callback<SteamNetConnectionStatusChangedCallback_t>.CreateGameServer
	|
	|-RVA: 0x1439A30 Offset: 0x1438430 VA: 0x181439A30
	|-Callback<__Il2CppFullySharedGenericType>.CreateGameServer
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Callback.DispatchDelegate<T> func, bool bGameServer = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x143C1A0 Offset: 0x143ABA0 VA: 0x18143C1A0
	|-Callback<GameLobbyJoinRequested_t>..ctor
	|
	|-RVA: 0x143C400 Offset: 0x143AE00 VA: 0x18143C400
	|-Callback<LobbyChatMsg_t>..ctor
	|
	|-RVA: 0x143C6C0 Offset: 0x143B0C0 VA: 0x18143C6C0
	|-Callback<LobbyChatUpdate_t>..ctor
	|
	|-RVA: 0x143C7F0 Offset: 0x143B1F0 VA: 0x18143C7F0
	|-Callback<LobbyCreated_t>..ctor
	|
	|-RVA: 0x143C2D0 Offset: 0x143ACD0 VA: 0x18143C2D0
	|-Callback<LobbyEnter_t>..ctor
	|
	|-RVA: 0x143C530 Offset: 0x143AF30 VA: 0x18143C530
	|-Callback<SteamNetConnectionStatusChangedCallback_t>..ctor
	|
	|-RVA: 0x143C660 Offset: 0x143B060 VA: 0x18143C660
	|-Callback<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x143A850 Offset: 0x1439250 VA: 0x18143A850
	|-Callback<GameLobbyJoinRequested_t>.Finalize
	|
	|-RVA: 0x143A9D0 Offset: 0x14393D0 VA: 0x18143A9D0
	|-Callback<LobbyChatMsg_t>.Finalize
	|
	|-RVA: 0x143A450 Offset: 0x1438E50 VA: 0x18143A450
	|-Callback<LobbyChatUpdate_t>.Finalize
	|
	|-RVA: 0x143A750 Offset: 0x1439150 VA: 0x18143A750
	|-Callback<LobbyCreated_t>.Finalize
	|
	|-RVA: 0x143A650 Offset: 0x1439050 VA: 0x18143A650
	|-Callback<LobbyEnter_t>.Finalize
	|
	|-RVA: 0x143A550 Offset: 0x1438F50 VA: 0x18143A550
	|-Callback<SteamNetConnectionStatusChangedCallback_t>.Finalize
	|
	|-RVA: 0x143A950 Offset: 0x1439350 VA: 0x18143A950
	|-Callback<__Il2CppFullySharedGenericType>.Finalize
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x143A1F0 Offset: 0x1438BF0 VA: 0x18143A1F0
	|-Callback<GameLobbyJoinRequested_t>.Dispose
	|
	|-RVA: 0x143A150 Offset: 0x1438B50 VA: 0x18143A150
	|-Callback<LobbyChatMsg_t>.Dispose
	|
	|-RVA: 0x143A3B0 Offset: 0x1438DB0 VA: 0x18143A3B0
	|-Callback<LobbyChatUpdate_t>.Dispose
	|
	|-RVA: 0x143A290 Offset: 0x1438C90 VA: 0x18143A290
	|-Callback<LobbyCreated_t>.Dispose
	|
	|-RVA: 0x143A010 Offset: 0x1438A10 VA: 0x18143A010
	|-Callback<LobbyEnter_t>.Dispose
	|
	|-RVA: 0x143A0B0 Offset: 0x1438AB0 VA: 0x18143A0B0
	|-Callback<SteamNetConnectionStatusChangedCallback_t>.Dispose
	|
	|-RVA: 0x143A330 Offset: 0x1438D30 VA: 0x18143A330
	|-Callback<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1
	public void Register(Callback.DispatchDelegate<T> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x143BD40 Offset: 0x143A740 VA: 0x18143BD40
	|-Callback<GameLobbyJoinRequested_t>.Register
	|
	|-RVA: 0x143BB20 Offset: 0x143A520 VA: 0x18143BB20
	|-Callback<LobbyChatMsg_t>.Register
	|
	|-RVA: 0x143BE50 Offset: 0x143A850 VA: 0x18143BE50
	|-Callback<LobbyChatUpdate_t>.Register
	|
	|-RVA: 0x143BC30 Offset: 0x143A630 VA: 0x18143BC30
	|-Callback<LobbyCreated_t>.Register
	|
	|-RVA: 0x143B930 Offset: 0x143A330 VA: 0x18143B930
	|-Callback<LobbyEnter_t>.Register
	|
	|-RVA: 0x143B820 Offset: 0x143A220 VA: 0x18143B820
	|-Callback<SteamNetConnectionStatusChangedCallback_t>.Register
	|
	|-RVA: 0x143BA40 Offset: 0x143A440 VA: 0x18143BA40
	|-Callback<__Il2CppFullySharedGenericType>.Register
	*/

	// RVA: -1 Offset: -1
	public void Unregister() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x143BFC0 Offset: 0x143A9C0 VA: 0x18143BFC0
	|-Callback<GameLobbyJoinRequested_t>.Unregister
	|
	|-RVA: 0x143C0B0 Offset: 0x143AAB0 VA: 0x18143C0B0
	|-Callback<LobbyChatMsg_t>.Unregister
	|
	|-RVA: 0x143C010 Offset: 0x143AA10 VA: 0x18143C010
	|-Callback<LobbyChatUpdate_t>.Unregister
	|
	|-RVA: 0x143BF70 Offset: 0x143A970 VA: 0x18143BF70
	|-Callback<LobbyCreated_t>.Unregister
	|
	|-RVA: 0x143C060 Offset: 0x143AA60 VA: 0x18143C060
	|-Callback<LobbyEnter_t>.Unregister
	|
	|-RVA: 0x143C100 Offset: 0x143AB00 VA: 0x18143C100
	|-Callback<SteamNetConnectionStatusChangedCallback_t>.Unregister
	|
	|-RVA: 0x143C150 Offset: 0x143AB50 VA: 0x18143C150
	|-Callback<__Il2CppFullySharedGenericType>.Unregister
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override bool get_IsGameServer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4971B0 Offset: 0x495BB0 VA: 0x1804971B0
	|-Callback<GameLobbyJoinRequested_t>.get_IsGameServer
	|-Callback<LobbyChatMsg_t>.get_IsGameServer
	|-Callback<LobbyChatUpdate_t>.get_IsGameServer
	|-Callback<LobbyCreated_t>.get_IsGameServer
	|-Callback<LobbyEnter_t>.get_IsGameServer
	|-Callback<SteamNetConnectionStatusChangedCallback_t>.get_IsGameServer
	|-Callback<__Il2CppFullySharedGenericType>.get_IsGameServer
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal override Type GetCallbackType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x143AC50 Offset: 0x1439650 VA: 0x18143AC50
	|-Callback<GameLobbyJoinRequested_t>.GetCallbackType
	|
	|-RVA: 0x143ABF0 Offset: 0x14395F0 VA: 0x18143ABF0
	|-Callback<LobbyChatMsg_t>.GetCallbackType
	|
	|-RVA: 0x143ACB0 Offset: 0x14396B0 VA: 0x18143ACB0
	|-Callback<LobbyChatUpdate_t>.GetCallbackType
	|
	|-RVA: 0x143AB90 Offset: 0x1439590 VA: 0x18143AB90
	|-Callback<LobbyCreated_t>.GetCallbackType
	|
	|-RVA: 0x143AD10 Offset: 0x1439710 VA: 0x18143AD10
	|-Callback<LobbyEnter_t>.GetCallbackType
	|
	|-RVA: 0x143AAD0 Offset: 0x14394D0 VA: 0x18143AAD0
	|-Callback<SteamNetConnectionStatusChangedCallback_t>.GetCallbackType
	|
	|-RVA: 0x143AB30 Offset: 0x1439530 VA: 0x18143AB30
	|-Callback<__Il2CppFullySharedGenericType>.GetCallbackType
	*/

	// RVA: -1 Offset: -1 Slot: 6
	internal override void OnRunCallback(IntPtr pvParam) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x143B3E0 Offset: 0x1439DE0 VA: 0x18143B3E0
	|-Callback<GameLobbyJoinRequested_t>.OnRunCallback
	|
	|-RVA: 0x143B540 Offset: 0x1439F40 VA: 0x18143B540
	|-Callback<LobbyChatMsg_t>.OnRunCallback
	|
	|-RVA: 0x143B6B0 Offset: 0x143A0B0 VA: 0x18143B6B0
	|-Callback<LobbyChatUpdate_t>.OnRunCallback
	|
	|-RVA: 0x143AD70 Offset: 0x1439770 VA: 0x18143AD70
	|-Callback<LobbyCreated_t>.OnRunCallback
	|
	|-RVA: 0x143B270 Offset: 0x1439C70 VA: 0x18143B270
	|-Callback<LobbyEnter_t>.OnRunCallback
	|
	|-RVA: 0x143AED0 Offset: 0x14398D0 VA: 0x18143AED0
	|-Callback<SteamNetConnectionStatusChangedCallback_t>.OnRunCallback
	|
	|-RVA: 0x143B0C0 Offset: 0x1439AC0 VA: 0x18143B0C0
	|-Callback<__Il2CppFullySharedGenericType>.OnRunCallback
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override void SetUnregistered() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x143BF60 Offset: 0x143A960 VA: 0x18143BF60
	|-Callback<GameLobbyJoinRequested_t>.SetUnregistered
	|-Callback<LobbyChatMsg_t>.SetUnregistered
	|-Callback<LobbyChatUpdate_t>.SetUnregistered
	|-Callback<LobbyCreated_t>.SetUnregistered
	|-Callback<LobbyEnter_t>.SetUnregistered
	|-Callback<SteamNetConnectionStatusChangedCallback_t>.SetUnregistered
	|-Callback<__Il2CppFullySharedGenericType>.SetUnregistered
	*/
}
