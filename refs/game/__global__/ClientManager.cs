public sealed class ClientManager : MonoBehaviour // TypeDefIndex: 12807
{
	// Fields
	private readonly Dictionary<ushort, HashSet<ClientManager.ServerBroadcastDelegate>> _broadcastHandlers; // 0x20
	private Dictionary<ushort, HashSet<ValueTuple<int, ClientManager.ServerBroadcastDelegate>>> _handlerTargets; // 0x28
	[CompilerGenerated]
	private Action OnAuthenticated; // 0x30
	[CompilerGenerated]
	private Action OnClientTimeOut; // 0x38
	[CompilerGenerated]
	private Action<ClientConnectionStateArgs> OnClientConnectionState; // 0x40
	[CompilerGenerated]
	private Action<RemoteConnectionStateArgs> OnRemoteConnectionState; // 0x48
	[CompilerGenerated]
	private Action<ConnectedClientsArgs> OnConnectedClients; // 0x50
	[CompilerGenerated]
	private bool <Started>k__BackingField; // 0x58
	public NetworkConnection Connection; // 0x60
	[CompilerGenerated]
	private ClientObjects <Objects>k__BackingField; // 0x68
	public Dictionary<int, NetworkConnection> Clients; // 0x70
	[CompilerGenerated]
	private NetworkManager <NetworkManager>k__BackingField; // 0x78
	[Tooltip("What platforms to enable remote server timeout.")]
	[SerializeField]
	private RemoteTimeoutType _remoteServerTimeout; // 0x80
	[Tooltip("How long in seconds server must go without sending any packets before the local client disconnects. This is independent of any transport settings.")]
	[Range(1, 1500)]
	[SerializeField]
	private ushort _remoteServerTimeoutDuration; // 0x84
	[Tooltip("True to automatically set the frame rate when the client connects.")]
	[SerializeField]
	private bool _changeFrameRate; // 0x86
	[Tooltip("Maximum frame rate the client may run at. When as host this value runs at whichever is higher between client and server.")]
	[Range(1, 500)]
	[SerializeField]
	private ushort _frameRate; // 0x88
	private float _lastPacketTime; // 0x8C
	private SplitReader _splitReader; // 0x90
	private List<Vector3> _objectsPositionsCache; // 0x98
	private int _nextLodNobIndex; // 0xA0
	[CompilerGenerated]
	private uint <LastPacketLocalTick>k__BackingField; // 0xA4

	// Properties
	public bool Started { get; set; }
	public ClientObjects Objects { get; set; }
	[HideInInspector]
	public NetworkManager NetworkManager { get; set; }
	internal ushort FrameRate { get; }
	public uint LevelOfDetailInterval { get; }
	public uint LastPacketLocalTick { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void RegisterBroadcast<T>(Action<T> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE61170 Offset: 0xE5FB70 VA: 0x180E61170
	|-ClientManager.RegisterBroadcast<ClientConnectionChangeBroadcast>
	|-ClientManager.RegisterBroadcast<ConnectedClientsBroadcast>
	|
	|-RVA: 0xE614B0 Offset: 0xE5FEB0 VA: 0x180E614B0
	|-ClientManager.RegisterBroadcast<EmptyStartScenesBroadcast>
	|-ClientManager.RegisterBroadcast<LoadScenesBroadcast>
	|-ClientManager.RegisterBroadcast<ResponseBroadcast>
	|-ClientManager.RegisterBroadcast<UnloadScenesBroadcast>
	|
	|-RVA: 0xE618D0 Offset: 0xE602D0 VA: 0x180E618D0
	|-ClientManager.RegisterBroadcast<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void UnregisterBroadcast<T>(Action<T> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE61CF0 Offset: 0xE606F0 VA: 0x180E61CF0
	|-ClientManager.UnregisterBroadcast<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	private ClientManager.ServerBroadcastDelegate CreateBroadcastDelegate<T>(Action<T> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE60FF0 Offset: 0xE5F9F0 VA: 0x180E60FF0
	|-ClientManager.CreateBroadcastDelegate<ClientConnectionChangeBroadcast>
	|-ClientManager.CreateBroadcastDelegate<ConnectedClientsBroadcast>
	|-ClientManager.CreateBroadcastDelegate<EmptyStartScenesBroadcast>
	|-ClientManager.CreateBroadcastDelegate<LoadScenesBroadcast>
	|-ClientManager.CreateBroadcastDelegate<ResponseBroadcast>
	|-ClientManager.CreateBroadcastDelegate<UnloadScenesBroadcast>
	|
	|-RVA: 0xE610B0 Offset: 0xE5FAB0 VA: 0x180E610B0
	|-ClientManager.CreateBroadcastDelegate<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0xD75AE0 Offset: 0xD744E0 VA: 0x180D75AE0
	private void ParseBroadcast(PooledReader reader, Channel channel) { }

	// RVA: -1 Offset: -1
	public void Broadcast<T>(T message, Channel channel = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE608C0 Offset: 0xE5F2C0 VA: 0x180E608C0
	|-ClientManager.Broadcast<ClientScenesLoadedBroadcast>
	|
	|-RVA: 0xE60A20 Offset: 0xE5F420 VA: 0x180E60A20
	|-ClientManager.Broadcast<EmptyStartScenesBroadcast>
	|
	|-RVA: 0xE60B80 Offset: 0xE5F580 VA: 0x180E60B80
	|-ClientManager.Broadcast<HostPasswordBroadcast>
	|
	|-RVA: 0xE60E90 Offset: 0xE5F890 VA: 0x180E60E90
	|-ClientManager.Broadcast<PasswordBroadcast>
	|
	|-RVA: 0xE60CE0 Offset: 0xE5F6E0 VA: 0x180E60CE0
	|-ClientManager.Broadcast<__Il2CppFullySharedGenericStructType>
	*/

	[CompilerGenerated]
	// RVA: 0xD775B0 Offset: 0xD75FB0 VA: 0x180D775B0
	public void add_OnAuthenticated(Action value) { }

	[CompilerGenerated]
	// RVA: 0xD779B0 Offset: 0xD763B0 VA: 0x180D779B0
	public void remove_OnAuthenticated(Action value) { }

	[CompilerGenerated]
	// RVA: 0xD77700 Offset: 0xD76100 VA: 0x180D77700
	public void add_OnClientTimeOut(Action value) { }

	[CompilerGenerated]
	// RVA: 0xD77B00 Offset: 0xD76500 VA: 0x180D77B00
	public void remove_OnClientTimeOut(Action value) { }

	[CompilerGenerated]
	// RVA: 0xD77650 Offset: 0xD76050 VA: 0x180D77650
	public void add_OnClientConnectionState(Action<ClientConnectionStateArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD77A50 Offset: 0xD76450 VA: 0x180D77A50
	public void remove_OnClientConnectionState(Action<ClientConnectionStateArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD77850 Offset: 0xD76250 VA: 0x180D77850
	public void add_OnRemoteConnectionState(Action<RemoteConnectionStateArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD77C50 Offset: 0xD76650 VA: 0x180D77C50
	public void remove_OnRemoteConnectionState(Action<RemoteConnectionStateArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD777A0 Offset: 0xD761A0 VA: 0x180D777A0
	public void add_OnConnectedClients(Action<ConnectedClientsArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD77BA0 Offset: 0xD765A0 VA: 0x180D77BA0
	public void remove_OnConnectedClients(Action<ConnectedClientsArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x4D61A0 Offset: 0x4D4BA0 VA: 0x1804D61A0
	public bool get_Started() { }

	[CompilerGenerated]
	// RVA: 0x4D6520 Offset: 0x4D4F20 VA: 0x1804D6520
	private void set_Started(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public ClientObjects get_Objects() { }

	[CompilerGenerated]
	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	private void set_Objects(ClientObjects value) { }

	[CompilerGenerated]
	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public NetworkManager get_NetworkManager() { }

	[CompilerGenerated]
	// RVA: 0x5F4EC0 Offset: 0x5F38C0 VA: 0x1805F4EC0
	private void set_NetworkManager(NetworkManager value) { }

	// RVA: 0xD76810 Offset: 0xD75210 VA: 0x180D76810
	public void SetRemoteServerTimeout(RemoteTimeoutType timeoutType, ushort duration) { }

	// RVA: 0xD77900 Offset: 0xD76300 VA: 0x180D77900
	internal ushort get_FrameRate() { }

	// RVA: 0xD77340 Offset: 0xD75D40 VA: 0x180D77340
	private void UpdateLastPacketDatas() { }

	// RVA: 0xD75710 Offset: 0xD74110 VA: 0x180D75710
	private void OnDestroy() { }

	// RVA: 0xD751B0 Offset: 0xD73BB0 VA: 0x180D751B0
	internal void InitializeOnce_Internal(NetworkManager manager) { }

	// RVA: 0xD75380 Offset: 0xD73D80 VA: 0x180D75380
	private void OnClientConnectionBroadcast(ClientConnectionChangeBroadcast args) { }

	// RVA: 0xD75550 Offset: 0xD73F50 VA: 0x180D75550
	private void OnConnectedClientsBroadcast(ConnectedClientsBroadcast args) { }

	// RVA: 0xD76AA0 Offset: 0xD754A0 VA: 0x180D76AA0
	private void SubscribeToEvents(bool subscribe) { }

	// RVA: 0xD75120 Offset: 0xD73B20 VA: 0x180D75120
	public int GetTransportIndex() { }

	// RVA: 0xD76A60 Offset: 0xD75460 VA: 0x180D76A60
	public bool StopConnection() { }

	// RVA: 0xD76960 Offset: 0xD75360 VA: 0x180D76960
	public bool StartConnection() { }

	// RVA: 0xD76850 Offset: 0xD75250 VA: 0x180D76850
	public bool StartConnection(string address) { }

	// RVA: 0xD769A0 Offset: 0xD753A0 VA: 0x180D769A0
	public bool StartConnection(string address, ushort port) { }

	// RVA: 0xD76EE0 Offset: 0xD758E0 VA: 0x180D76EE0
	private void Transport_OnClientConnectionState(ClientConnectionStateArgs args) { }

	// RVA: 0xD76650 Offset: 0xD75050 VA: 0x180D76650
	private void Transport_OnClientReceivedData(ClientReceivedDataArgs args) { }

	// RVA: 0xD76EA0 Offset: 0xD758A0 VA: 0x180D76EA0
	private void TransportManager_OnIterateIncomingEnd(bool server) { }

	// RVA: 0xD76650 Offset: 0xD75050 VA: 0x180D76650
	private void ParseReceived(ClientReceivedDataArgs args) { }

	// RVA: 0xD75D50 Offset: 0xD74750 VA: 0x180D75D50
	internal void ParseReader(PooledReader reader, Channel channel, bool print = False) { }

	// RVA: 0xD75D00 Offset: 0xD74700 VA: 0x180D75D00
	private void ParsePingPong(PooledReader reader) { }

	// RVA: 0xD757A0 Offset: 0xD741A0 VA: 0x180D757A0
	private void ParseAuthenticated(PooledReader reader) { }

	// RVA: 0xD75010 Offset: 0xD73A10 VA: 0x180D75010
	private void TimeManager_OnPostTick() { }

	// RVA: 0xD75010 Offset: 0xD73A10 VA: 0x180D75010
	private void CheckServerTimeout() { }

	// RVA: 0xD77920 Offset: 0xD76320 VA: 0x180D77920
	public uint get_LevelOfDetailInterval() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal void TrySendLodUpdate(uint localTick, bool forceFullUpdate) { }

	[CompilerGenerated]
	// RVA: 0xBBA760 Offset: 0xBB9160 VA: 0x180BBA760
	public uint get_LastPacketLocalTick() { }

	[CompilerGenerated]
	// RVA: 0xBBA830 Offset: 0xBB9230 VA: 0x180BBA830
	private void set_LastPacketLocalTick(uint value) { }

	// RVA: 0xD77390 Offset: 0xD75D90 VA: 0x180D77390
	public void .ctor() { }
}
