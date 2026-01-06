public sealed class ServerManager : MonoBehaviour // TypeDefIndex: 12752
{
	// Fields
	private readonly Dictionary<ushort, HashSet<ServerManager.ClientBroadcastDelegate>> _broadcastHandlers; // 0x20
	private Dictionary<ushort, HashSet<ValueTuple<int, ServerManager.ClientBroadcastDelegate>>> _handlerTargets; // 0x28
	private HashSet<NetworkConnection> _connectionsWithoutExclusions; // 0x30
	[CompilerGenerated]
	private Action<ServerConnectionStateArgs> OnServerConnectionState; // 0x38
	[CompilerGenerated]
	private Action<NetworkConnection, bool> OnAuthenticationResult; // 0x40
	[CompilerGenerated]
	private Action<NetworkConnection, RemoteConnectionStateArgs> OnRemoteConnectionState; // 0x48
	[CompilerGenerated]
	private bool <Started>k__BackingField; // 0x50
	[CompilerGenerated]
	private ServerObjects <Objects>k__BackingField; // 0x58
	[HideInInspector]
	public Dictionary<int, NetworkConnection> Clients; // 0x60
	[CompilerGenerated]
	private NetworkManager <NetworkManager>k__BackingField; // 0x68
	[Tooltip("Authenticator for this ServerManager. May be null if not using authentication.")]
	[SerializeField]
	private Authenticator _authenticator; // 0x70
	[Tooltip("What platforms to enable remote client timeout.")]
	[SerializeField]
	private RemoteTimeoutType _remoteClientTimeout; // 0x78
	[Tooltip("How long in seconds a client must go without sending any packets before getting disconnected. This is independent of any transport settings.")]
	[Range(1, 1500)]
	[SerializeField]
	private ushort _remoteClientTimeoutDuration; // 0x7C
	[Range(0, 60)]
	[SerializeField]
	[Tooltip("Default send rate for SyncTypes. A value of 0f will send changed values every tick.")]
	private float _syncTypeRate; // 0x80
	[Tooltip("How to pack object spawns.")]
	[SerializeField]
	internal TransformPackingData SpawnPacking; // 0x88
	[SerializeField]
	[Tooltip("True to automatically set the frame rate when the client connects.")]
	private bool _changeFrameRate; // 0x90
	[Range(1, 500)]
	[SerializeField]
	[Tooltip("Maximum frame rate the server may run at. When as host this value runs at whichever is higher between client and server.")]
	private ushort _frameRate; // 0x92
	[SerializeField]
	[Tooltip("True to share the Ids of clients and the objects they own with other clients. No sensitive information is shared.")]
	private bool _shareIds; // 0x94
	[Tooltip("True to automatically start the server connection when running as headless.")]
	[SerializeField]
	private bool _startOnHeadless; // 0x95
	[Tooltip("True to kick clients which send data larger than the MTU.")]
	[SerializeField]
	private bool _limitClientMTU; // 0x96
	private int _nextClientTimeoutCheckIndex; // 0x98
	private float _nextTimeoutCheckTime; // 0x9C
	private SplitReader _splitReader; // 0xA0
	public const ushort MAXIMUM_REMOTE_CLIENT_TIMEOUT_DURATION = 1500;
	private uint _cachedLevelOfDetailInterval; // 0xA8
	private bool _cachedUseLod; // 0xAC
	[CompilerGenerated]
	private Action<NetworkConnection, int, KickReason> OnClientKick; // 0xB0
	internal Dictionary<ushort, RpcLink> RpcLinks; // 0xB8
	private Queue<ushort> _availableRpcLinkIndexes; // 0xC0

	// Properties
	public bool Started { get; set; }
	public ServerObjects Objects { get; set; }
	[HideInInspector]
	public NetworkManager NetworkManager { get; set; }
	[Obsolete("Use GetAuthenticator and SetAuthenticator.")]
	public Authenticator Authenticator { get; set; }
	internal ushort FrameRate { get; }
	internal bool ShareIds { get; }
	internal bool LimitClientMTU { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void RegisterBroadcast<T>(Action<NetworkConnection, T> handler, bool requireAuthentication = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF4CAA0 Offset: 0xF4B4A0 VA: 0x180F4CAA0
	|-ServerManager.RegisterBroadcast<ClientScenesLoadedBroadcast>
	|-ServerManager.RegisterBroadcast<EmptyStartScenesBroadcast>
	|-ServerManager.RegisterBroadcast<HostPasswordBroadcast>
	|-ServerManager.RegisterBroadcast<PasswordBroadcast>
	|
	|-RVA: 0xF4CDB0 Offset: 0xF4B7B0 VA: 0x180F4CDB0
	|-ServerManager.RegisterBroadcast<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void UnregisterBroadcast<T>(Action<NetworkConnection, T> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF4D050 Offset: 0xF4BA50 VA: 0x180F4D050
	|-ServerManager.UnregisterBroadcast<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	private ServerManager.ClientBroadcastDelegate CreateBroadcastDelegate<T>(Action<NetworkConnection, T> handler, bool requireAuthentication) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF4C900 Offset: 0xF4B300 VA: 0x180F4C900
	|-ServerManager.CreateBroadcastDelegate<ClientScenesLoadedBroadcast>
	|-ServerManager.CreateBroadcastDelegate<EmptyStartScenesBroadcast>
	|-ServerManager.CreateBroadcastDelegate<HostPasswordBroadcast>
	|-ServerManager.CreateBroadcastDelegate<PasswordBroadcast>
	|
	|-RVA: 0xF4C9D0 Offset: 0xF4B3D0 VA: 0x180F4C9D0
	|-ServerManager.CreateBroadcastDelegate<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0xD65810 Offset: 0xD64210 VA: 0x180D65810
	private void ParseBroadcast(PooledReader reader, NetworkConnection conn, Channel channel) { }

	// RVA: -1 Offset: -1
	public void Broadcast<T>(NetworkConnection connection, T message, bool requireAuthenticated = True, Channel channel = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF4AE70 Offset: 0xF49870 VA: 0x180F4AE70
	|-ServerManager.Broadcast<ClientConnectionChangeBroadcast>
	|
	|-RVA: 0xF4B030 Offset: 0xF49A30 VA: 0x180F4B030
	|-ServerManager.Broadcast<ConnectedClientsBroadcast>
	|
	|-RVA: 0xF4B1F0 Offset: 0xF49BF0 VA: 0x180F4B1F0
	|-ServerManager.Broadcast<EmptyStartScenesBroadcast>
	|
	|-RVA: 0xF4C0B0 Offset: 0xF4AAB0 VA: 0x180F4C0B0
	|-ServerManager.Broadcast<LoadScenesBroadcast>
	|
	|-RVA: 0xF4C270 Offset: 0xF4AC70 VA: 0x180F4C270
	|-ServerManager.Broadcast<ResponseBroadcast>
	|
	|-RVA: 0xF4C430 Offset: 0xF4AE30 VA: 0x180F4C430
	|-ServerManager.Broadcast<UnloadScenesBroadcast>
	|
	|-RVA: 0xF4B840 Offset: 0xF4A240 VA: 0x180F4B840
	|-ServerManager.Broadcast<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void Broadcast<T>(HashSet<NetworkConnection> connections, T message, bool requireAuthenticated = True, Channel channel = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF4B510 Offset: 0xF49F10 VA: 0x180F4B510
	|-ServerManager.Broadcast<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void BroadcastExcept<T>(HashSet<NetworkConnection> connections, NetworkConnection excludedConnection, T message, bool requireAuthenticated = True, Channel channel = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF4A2B0 Offset: 0xF48CB0 VA: 0x180F4A2B0
	|-ServerManager.BroadcastExcept<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void BroadcastExcept<T>(HashSet<NetworkConnection> connections, HashSet<NetworkConnection> excludedConnections, T message, bool requireAuthenticated = True, Channel channel = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF4A7A0 Offset: 0xF491A0 VA: 0x180F4A7A0
	|-ServerManager.BroadcastExcept<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void BroadcastExcept<T>(NetworkConnection excludedConnection, T message, bool requireAuthenticated = True, Channel channel = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF4A430 Offset: 0xF48E30 VA: 0x180F4A430
	|-ServerManager.BroadcastExcept<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void BroadcastExcept<T>(HashSet<NetworkConnection> excludedConnections, T message, bool requireAuthenticated = True, Channel channel = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF4AA20 Offset: 0xF49420 VA: 0x180F4AA20
	|-ServerManager.BroadcastExcept<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void Broadcast<T>(NetworkObject networkObject, T message, bool requireAuthenticated = True, Channel channel = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF4B3B0 Offset: 0xF49DB0 VA: 0x180F4B3B0
	|-ServerManager.Broadcast<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void Broadcast<T>(T message, bool requireAuthenticated = True, Channel channel = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF4BDA0 Offset: 0xF4A7A0 VA: 0x180F4BDA0
	|-ServerManager.Broadcast<LoadScenesBroadcast>
	|
	|-RVA: 0xF4C5F0 Offset: 0xF4AFF0 VA: 0x180F4C5F0
	|-ServerManager.Broadcast<UnloadScenesBroadcast>
	|
	|-RVA: 0xF4BA50 Offset: 0xF4A450 VA: 0x180F4BA50
	|-ServerManager.Broadcast<__Il2CppFullySharedGenericStructType>
	*/

	[CompilerGenerated]
	// RVA: 0xD69330 Offset: 0xD67D30 VA: 0x180D69330
	public void add_OnServerConnectionState(Action<ServerConnectionStateArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD69620 Offset: 0xD68020 VA: 0x180D69620
	public void remove_OnServerConnectionState(Action<ServerConnectionStateArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD69110 Offset: 0xD67B10 VA: 0x180D69110
	public void add_OnAuthenticationResult(Action<NetworkConnection, bool> value) { }

	[CompilerGenerated]
	// RVA: 0xD69400 Offset: 0xD67E00 VA: 0x180D69400
	public void remove_OnAuthenticationResult(Action<NetworkConnection, bool> value) { }

	[CompilerGenerated]
	// RVA: 0xD69280 Offset: 0xD67C80 VA: 0x180D69280
	public void add_OnRemoteConnectionState(Action<NetworkConnection, RemoteConnectionStateArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD69570 Offset: 0xD67F70 VA: 0x180D69570
	public void remove_OnRemoteConnectionState(Action<NetworkConnection, RemoteConnectionStateArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x49CAE0 Offset: 0x49B4E0 VA: 0x18049CAE0
	public bool get_Started() { }

	[CompilerGenerated]
	// RVA: 0x49CCF0 Offset: 0x49B6F0 VA: 0x18049CCF0
	private void set_Started(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public ServerObjects get_Objects() { }

	[CompilerGenerated]
	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	private void set_Objects(ServerObjects value) { }

	[CompilerGenerated]
	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public NetworkManager get_NetworkManager() { }

	[CompilerGenerated]
	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	private void set_NetworkManager(NetworkManager value) { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public Authenticator get_Authenticator() { }

	// RVA: 0xD679A0 Offset: 0xD663A0 VA: 0x180D679A0
	public void set_Authenticator(Authenticator value) { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public Authenticator GetAuthenticator() { }

	// RVA: 0xD679A0 Offset: 0xD663A0 VA: 0x180D679A0
	public void SetAuthenticator(Authenticator value) { }

	// RVA: 0xD679D0 Offset: 0xD663D0 VA: 0x180D679D0
	public void SetRemoteClientTimeout(RemoteTimeoutType timeoutType, ushort duration) { }

	// RVA: 0x6A5300 Offset: 0x6A3D00 VA: 0x1806A5300
	internal float GetSynctypeRate() { }

	// RVA: 0xD693E0 Offset: 0xD67DE0 VA: 0x180D693E0
	internal ushort get_FrameRate() { }

	// RVA: 0x4B62E0 Offset: 0x4B4CE0 VA: 0x1804B62E0
	internal bool get_ShareIds() { }

	// RVA: 0x4B62F0 Offset: 0x4B4CF0 VA: 0x1804B62F0
	public bool GetStartOnHeadless() { }

	// RVA: 0x4B70B0 Offset: 0x4B5AB0 VA: 0x1804B70B0
	public void SetStartOnHeadless(bool value) { }

	// RVA: 0x4B5BE0 Offset: 0x4B45E0 VA: 0x1804B5BE0
	internal bool get_LimitClientMTU() { }

	// RVA: 0xD65560 Offset: 0xD63F60 VA: 0x180D65560
	private void OnDestroy() { }

	// RVA: 0xD64ED0 Offset: 0xD638D0 VA: 0x180D64ED0
	internal void InitializeOnce_Internal(NetworkManager manager) { }

	// RVA: 0xD64DB0 Offset: 0xD637B0 VA: 0x180D64DB0
	private void InitializeAuthenticator() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal void StartForHeadless() { }

	// RVA: 0xD67C50 Offset: 0xD66650 VA: 0x180D67C50
	public bool StopConnection(bool sendDisconnectMessage) { }

	// RVA: 0xD67880 Offset: 0xD66280 VA: 0x180D67880
	internal void SendDisconnectMessages(int[] connectionIds) { }

	// RVA: 0xD67650 Offset: 0xD66050 VA: 0x180D67650
	private void SendDisconnectMessages(List<NetworkConnection> conns, bool iterate) { }

	// RVA: 0xD67BB0 Offset: 0xD665B0 VA: 0x180D67BB0
	public bool StartConnection() { }

	// RVA: 0xD67BF0 Offset: 0xD665F0 VA: 0x180D67BF0
	public bool StartConnection(ushort port) { }

	// RVA: 0xD64750 Offset: 0xD63150 VA: 0x180D64750
	private void CheckClientTimeout() { }

	// RVA: 0xD681F0 Offset: 0xD66BF0 VA: 0x180D681F0
	private void TimeManager_OnPostTick() { }

	// RVA: 0xD64B50 Offset: 0xD63550 VA: 0x180D64B50
	private void ClientManager_OnClientConnectionState(ClientConnectionStateArgs obj) { }

	// RVA: 0xD67090 Offset: 0xD65A90 VA: 0x180D67090
	private void SceneManager_OnClientLoadedStartScenes(NetworkConnection conn, bool asServer) { }

	// RVA: 0xD67E60 Offset: 0xD66860 VA: 0x180D67E60
	private void SubscribeToTransport(bool subscribe) { }

	// RVA: 0xD68D10 Offset: 0xD67710 VA: 0x180D68D10
	private void _authenticator_OnAuthenticationResult(NetworkConnection conn, bool authenticated) { }

	// RVA: 0xD686B0 Offset: 0xD670B0 VA: 0x180D686B0
	private void Transport_OnServerConnectionState(ServerConnectionStateArgs args) { }

	// RVA: 0xD68200 Offset: 0xD66C00 VA: 0x180D68200
	private void Transport_OnRemoteConnectionState(RemoteConnectionStateArgs args) { }

	// RVA: 0xD67330 Offset: 0xD65D30 VA: 0x180D67330
	private void SendAuthenticated(NetworkConnection conn) { }

	// RVA: 0xD68C30 Offset: 0xD67630 VA: 0x180D68C30
	private void Transport_OnServerReceivedData(ServerReceivedDataArgs args) { }

	// RVA: 0xD65C90 Offset: 0xD64690 VA: 0x180D65C90
	private void ParseReceived(ServerReceivedDataArgs args) { }

	// RVA: 0xD65C10 Offset: 0xD64610 VA: 0x180D65C10
	private void ParsePingPong(PooledReader reader, NetworkConnection conn) { }

	// RVA: 0xD64AC0 Offset: 0xD634C0 VA: 0x180D64AC0
	private void ClientAuthenticated(NetworkConnection connection) { }

	// RVA: 0xD642D0 Offset: 0xD62CD0 VA: 0x180D642D0
	private void BroadcastClientConnectionChange(bool connected, NetworkConnection conn) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void ParseNetworkLODUpdate(PooledReader reader, NetworkConnection conn) { }

	[CompilerGenerated]
	// RVA: 0xD691C0 Offset: 0xD67BC0 VA: 0x180D691C0
	public void add_OnClientKick(Action<NetworkConnection, int, KickReason> value) { }

	[CompilerGenerated]
	// RVA: 0xD694B0 Offset: 0xD67EB0 VA: 0x180D694B0
	public void remove_OnClientKick(Action<NetworkConnection, int, KickReason> value) { }

	// RVA: 0xD65580 Offset: 0xD63F80 VA: 0x180D65580
	public bool OneServerStarted() { }

	// RVA: 0xD64030 Offset: 0xD62A30 VA: 0x180D64030
	public bool AnyServerStarted(Nullable<int> excludedIndex) { }

	// RVA: 0xD67AB0 Offset: 0xD664B0 VA: 0x180D67AB0
	public void Spawn(GameObject go, NetworkConnection ownerConnection, Scene scene) { }

	// RVA: 0xD67A80 Offset: 0xD66480 VA: 0x180D67A80
	public void Spawn(NetworkObject nob, NetworkConnection ownerConnection, Scene scene) { }

	// RVA: 0xD64C30 Offset: 0xD63630 VA: 0x180D64C30
	public void Despawn(GameObject go, Nullable<DespawnType> despawnType) { }

	// RVA: 0xD64B80 Offset: 0xD63580 VA: 0x180D64B80
	public void Despawn(NetworkObject networkObject, Nullable<DespawnType> despawnType) { }

	// RVA: 0xD652D0 Offset: 0xD63CD0 VA: 0x180D652D0
	public void Kick(NetworkConnection conn, KickReason kickReason, LoggingType loggingType = 3, string log = "") { }

	// RVA: 0xD654A0 Offset: 0xD63EA0 VA: 0x180D654A0
	public void Kick(int clientId, KickReason kickReason, LoggingType loggingType = 3, string log = "") { }

	// RVA: 0xD653A0 Offset: 0xD63DA0 VA: 0x180D653A0
	public void Kick(NetworkConnection conn, Reader reader, KickReason kickReason, LoggingType loggingType = 3, string log = "") { }

	// RVA: 0xD65220 Offset: 0xD63C20 VA: 0x180D65220
	private void InitializeRpcLinks() { }

	// RVA: 0xD64D20 Offset: 0xD63720 VA: 0x180D64D20
	internal bool GetRpcLink(out ushort value) { }

	// RVA: 0xD67A00 Offset: 0xD66400 VA: 0x180D67A00
	internal void SetRpcLink(ushort linkIndex, RpcLink data) { }

	// RVA: 0xD67D10 Offset: 0xD66710 VA: 0x180D67D10
	internal void StoreRpcLinks(Dictionary<uint, RpcLinkType> links) { }

	// RVA: 0xD68DC0 Offset: 0xD677C0 VA: 0x180D68DC0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xD68C70 Offset: 0xD67670 VA: 0x180D68C70
	private void <ParseReceived>g__ExceededMTUKick|86_0(ref ServerManager.<>c__DisplayClass86_0 ) { }
}
