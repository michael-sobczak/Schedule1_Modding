public class NetworkConnection : IEquatable<NetworkConnection> // TypeDefIndex: 12829
{
	// Fields
	private List<PacketBundle> _toClientBundles; // 0x10
	private bool _serverDirtied; // 0x18
	[CompilerGenerated]
	private Action<NetworkConnection, bool> OnLoadedStartScenes; // 0x20
	[CompilerGenerated]
	private Action<NetworkObject> OnObjectAdded; // 0x28
	[CompilerGenerated]
	private Action<NetworkObject> OnObjectRemoved; // 0x30
	[CompilerGenerated]
	private NetworkManager <NetworkManager>k__BackingField; // 0x38
	private bool _loadedStartScenesAsServer; // 0x40
	private bool _loadedStartScenesAsClient; // 0x41
	internal Queue<int> PredictedObjectIds; // 0x48
	[CompilerGenerated]
	private int <TransportIndex>k__BackingField; // 0x50
	[CompilerGenerated]
	private bool <Authenticated>k__BackingField; // 0x54
	public int ClientId; // 0x58
	public HashSet<NetworkObject> Objects; // 0x60
	[CompilerGenerated]
	private NetworkObject <FirstObject>k__BackingField; // 0x68
	[CompilerGenerated]
	private HashSet<Scene> <Scenes>k__BackingField; // 0x70
	[CompilerGenerated]
	private bool <Disconnecting>k__BackingField; // 0x78
	[CompilerGenerated]
	private uint <DisconnectingTick>k__BackingField; // 0x7C
	public object CustomData; // 0x80
	internal uint ServerConnectionTick; // 0x88
	public EstimatedTick PacketTick; // 0x8C
	public EstimatedTick LocalTick; // 0x98
	public const int UNSET_CLIENTID_VALUE = -1;
	public Dictionary<NetworkObject, NetworkConnection.LevelOfDetailData> LevelOfDetails; // 0xA8
	internal int AllowedForcedLodUpdates; // 0xB0
	internal uint LastLevelOfDetailUpdate; // 0xB4
	internal int LevelOfDetailInfractions; // 0xB8
	internal GridEntry HashGridEntry; // 0xC0
	private HashGrid _hashGrid; // 0xC8
	private float _nextHashGridUpdateTime; // 0xD0
	private Vector2Int _hashGridPosition; // 0xD4
	private uint _lastPingTick; // 0xDC
	private uint _requiredPingTicks; // 0xE0
	private const byte EXCESSIVE_PING_LIMIT = 10;
	private MovingAverage _replicateQueueAverage; // 0xE8
	private uint _lastAverageQueueAddTick; // 0xF0
	[CompilerGenerated]
	private uint <LocalReplicateTick>k__BackingField; // 0xF4

	// Properties
	public NetworkManager NetworkManager { get; set; }
	public int TransportIndex { get; set; }
	public bool Authenticated { get; set; }
	public bool IsActive { get; }
	public bool IsValid { get; }
	public NetworkObject FirstObject { get; set; }
	public HashSet<Scene> Scenes { get; set; }
	public bool Disconnecting { get; set; }
	internal uint DisconnectingTick { get; set; }
	[Obsolete("Use LocalTick instead.")]
	public uint Tick { get; }
	public uint LocalReplicateTick { get; set; }
	public bool IsHost { get; }
	public bool IsLocalClient { get; }

	// Methods

	// RVA: 0xD9C8E0 Offset: 0xD9B2E0 VA: 0x180D9C8E0
	private void InitializeBuffer() { }

	// RVA: -1 Offset: -1
	public void Broadcast<T>(T message, bool requireAuthenticated = True, Channel channel = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF15460 Offset: 0xF13E60 VA: 0x180F15460
	|-NetworkConnection.Broadcast<ConnectedClientsBroadcast>
	|
	|-RVA: 0xF15530 Offset: 0xF13F30 VA: 0x180F15530
	|-NetworkConnection.Broadcast<EmptyStartScenesBroadcast>
	|
	|-RVA: 0xF15750 Offset: 0xF14150 VA: 0x180F15750
	|-NetworkConnection.Broadcast<LoadScenesBroadcast>
	|
	|-RVA: 0xF15820 Offset: 0xF14220 VA: 0x180F15820
	|-NetworkConnection.Broadcast<UnloadScenesBroadcast>
	|
	|-RVA: 0xF15600 Offset: 0xF14000 VA: 0x180F15600
	|-NetworkConnection.Broadcast<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0xD9D430 Offset: 0xD9BE30 VA: 0x180D9D430
	internal void SendToClient(byte channel, ArraySegment<byte> segment, bool forceNewBuffer = False, DataOrderType orderType = 0) { }

	// RVA: 0xD9C830 Offset: 0xD9B230 VA: 0x180D9C830
	internal bool GetPacketBundle(int channel, out PacketBundle packetBundle) { }

	// RVA: 0xD9D590 Offset: 0xD9BF90 VA: 0x180D9D590
	private void ServerDirty() { }

	// RVA: 0x4C55E0 Offset: 0x4C3FE0 VA: 0x1804C55E0
	internal void ResetServerDirty() { }

	[CompilerGenerated]
	// RVA: 0xD9E300 Offset: 0xD9CD00 VA: 0x180D9E300
	public void add_OnLoadedStartScenes(Action<NetworkConnection, bool> value) { }

	[CompilerGenerated]
	// RVA: 0xD9E9B0 Offset: 0xD9D3B0 VA: 0x180D9E9B0
	public void remove_OnLoadedStartScenes(Action<NetworkConnection, bool> value) { }

	[CompilerGenerated]
	// RVA: 0xD9E3B0 Offset: 0xD9CDB0 VA: 0x180D9E3B0
	public void add_OnObjectAdded(Action<NetworkObject> value) { }

	[CompilerGenerated]
	// RVA: 0xD9EA60 Offset: 0xD9D460 VA: 0x180D9EA60
	public void remove_OnObjectAdded(Action<NetworkObject> value) { }

	[CompilerGenerated]
	// RVA: 0xD9E460 Offset: 0xD9CE60 VA: 0x180D9E460
	public void add_OnObjectRemoved(Action<NetworkObject> value) { }

	[CompilerGenerated]
	// RVA: 0xD9EB10 Offset: 0xD9D510 VA: 0x180D9EB10
	public void remove_OnObjectRemoved(Action<NetworkObject> value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public NetworkManager get_NetworkManager() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	private void set_NetworkManager(NetworkManager value) { }

	// RVA: 0xD9CDF0 Offset: 0xD9B7F0 VA: 0x180D9CDF0
	public bool LoadedStartScenes() { }

	// RVA: 0xD9CDE0 Offset: 0xD9B7E0 VA: 0x180D9CDE0
	public bool LoadedStartScenes(bool asServer) { }

	[CompilerGenerated]
	// RVA: 0x4B61B0 Offset: 0x4B4BB0 VA: 0x1804B61B0
	public int get_TransportIndex() { }

	[CompilerGenerated]
	// RVA: 0x4E28A0 Offset: 0x4E12A0 VA: 0x1804E28A0
	internal void set_TransportIndex(int value) { }

	[CompilerGenerated]
	// RVA: 0x4E2420 Offset: 0x4E0E20 VA: 0x1804E2420
	public bool get_Authenticated() { }

	[CompilerGenerated]
	// RVA: 0x4E2920 Offset: 0x4E1320 VA: 0x1804E2920
	private void set_Authenticated(bool value) { }

	// RVA: 0xD9E510 Offset: 0xD9CF10 VA: 0x180D9E510
	public bool get_IsActive() { }

	// RVA: 0xD9E750 Offset: 0xD9D150 VA: 0x180D9E750
	public bool get_IsValid() { }

	[CompilerGenerated]
	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public NetworkObject get_FirstObject() { }

	[CompilerGenerated]
	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	private void set_FirstObject(NetworkObject value) { }

	// RVA: 0xD9D900 Offset: 0xD9C300 VA: 0x180D9D900
	public void SetFirstObject(NetworkObject nob) { }

	[CompilerGenerated]
	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public HashSet<Scene> get_Scenes() { }

	[CompilerGenerated]
	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	private void set_Scenes(HashSet<Scene> value) { }

	[CompilerGenerated]
	// RVA: 0x4E23F0 Offset: 0x4E0DF0 VA: 0x1804E23F0
	public bool get_Disconnecting() { }

	[CompilerGenerated]
	// RVA: 0x4E28E0 Offset: 0x4E12E0 VA: 0x1804E28E0
	private void set_Disconnecting(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6A4D90 Offset: 0x6A3790 VA: 0x1806A4D90
	internal uint get_DisconnectingTick() { }

	[CompilerGenerated]
	// RVA: 0xD9EBC0 Offset: 0xD9D5C0 VA: 0x180D9EBC0
	private void set_DisconnectingTick(uint value) { }

	// RVA: 0xD9E770 Offset: 0xD9D170 VA: 0x180D9E770
	public uint get_Tick() { }

	// RVA: 0xD9C6C0 Offset: 0xD9B0C0 VA: 0x180D9C6C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xD9C690 Offset: 0xD9B090 VA: 0x180D9C690 Slot: 4
	public bool Equals(NetworkConnection nc) { }

	// RVA: 0x4C3B30 Offset: 0x4C2530 VA: 0x1804C3B30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xD9E860 Offset: 0xD9D260 VA: 0x180D9E860
	public static bool op_Equality(NetworkConnection a, NetworkConnection b) { }

	// RVA: 0xD9E900 Offset: 0xD9D300 VA: 0x180D9E900
	public static bool op_Inequality(NetworkConnection a, NetworkConnection b) { }

	[APIExclude]
	// RVA: 0xD9DD80 Offset: 0xD9C780 VA: 0x180D9DD80
	public void .ctor() { }

	[APIExclude]
	// RVA: 0xD9DFC0 Offset: 0xD9C9C0 VA: 0x180D9DFC0
	public void .ctor(NetworkManager manager, int clientId, int transportIndex, bool asServer) { }

	// RVA: 0xD9C680 Offset: 0xD9B080 VA: 0x180D9C680
	internal void Dispose() { }

	// RVA: 0xD9DAC0 Offset: 0xD9C4C0 VA: 0x180D9DAC0 Slot: 3
	public override string ToString() { }

	// RVA: 0xD9CB00 Offset: 0xD9B500 VA: 0x180D9CB00
	private void Initialize(NetworkManager nm, int clientId, int transportIndex, bool asServer) { }

	// RVA: 0xD9C1A0 Offset: 0xD9ABA0 VA: 0x180D9C1A0
	internal void Deinitialize() { }

	// RVA: 0xD9D5D0 Offset: 0xD9BFD0 VA: 0x180D9D5D0
	internal void SetDisconnecting(bool value) { }

	// RVA: 0xD9C490 Offset: 0xD9AE90 VA: 0x180D9C490
	public void Disconnect(bool immediately) { }

	// RVA: 0xD9DA70 Offset: 0xD9C470 VA: 0x180D9DA70
	internal bool SetLoadedStartScenes(bool asServer) { }

	// RVA: 0xD9C190 Offset: 0xD9AB90 VA: 0x180D9C190
	internal void ConnectionAuthenticated() { }

	// RVA: 0xD9BF60 Offset: 0xD9A960 VA: 0x180D9BF60
	internal void AddObject(NetworkObject nob) { }

	// RVA: 0xD9D190 Offset: 0xD9BB90 VA: 0x180D9D190
	internal void RemoveObject(NetworkObject nob) { }

	// RVA: 0xD9C130 Offset: 0xD9AB30 VA: 0x180D9C130
	private void ClearObjects() { }

	// RVA: 0xD9D630 Offset: 0xD9C030 VA: 0x180D9D630
	private void SetFirstObject() { }

	// RVA: 0xD9C000 Offset: 0xD9AA00 VA: 0x180D9C000
	internal bool AddToScene(Scene scene) { }

	// RVA: 0xD9D130 Offset: 0xD9BB30 VA: 0x180D9D130
	internal bool RemoveFromScene(Scene scene) { }

	// RVA: 0xD9CC30 Offset: 0xD9B630 VA: 0x180D9CC30
	internal bool IsLateForLevelOfDetail(uint expectedInterval) { }

	// RVA: 0xD9D2C0 Offset: 0xD9BCC0 VA: 0x180D9D2C0
	private void ResetStates_Lod() { }

	// RVA: 0xD9CE00 Offset: 0xD9B800 VA: 0x180D9CE00
	private void Observers_FirstObjectChanged() { }

	// RVA: 0xD9CF90 Offset: 0xD9B990 VA: 0x180D9CF90
	private void Observers_Initialize(NetworkManager nm) { }

	// RVA: 0xD9DBC0 Offset: 0xD9C5C0 VA: 0x180D9DBC0
	internal void UpdateHashGridPositions(bool force) { }

	// RVA: 0xD9CFF0 Offset: 0xD9B9F0 VA: 0x180D9CFF0
	private void Observers_Reset() { }

	// RVA: 0xD9CA30 Offset: 0xD9B430 VA: 0x180D9CA30
	private void InitializePing() { }

	// RVA: 0xD9D2B0 Offset: 0xD9BCB0 VA: 0x180D9D2B0
	private void ResetPingPong() { }

	// RVA: 0xD9C060 Offset: 0xD9AA60 VA: 0x180D9C060
	internal bool CanPingPong() { }

	// RVA: 0xD9D070 Offset: 0xD9BA70 VA: 0x180D9D070
	internal void Prediction_Initialize(NetworkManager manager, bool asServer) { }

	// RVA: 0xD9BF00 Offset: 0xD9A900 VA: 0x180D9BF00
	internal void AddAverageQueueCount(ushort value, uint tick) { }

	// RVA: 0xD9C800 Offset: 0xD9B200 VA: 0x180D9C800
	internal ushort GetAndResetAverageQueueCount() { }

	[CompilerGenerated]
	// RVA: 0xD9E760 Offset: 0xD9D160 VA: 0x180D9E760
	public uint get_LocalReplicateTick() { }

	[CompilerGenerated]
	// RVA: 0xD9EBD0 Offset: 0xD9D5D0 VA: 0x180D9EBD0
	internal void set_LocalReplicateTick(uint value) { }

	// RVA: 0x9F93E0 Offset: 0x9F7DE0 VA: 0x1809F93E0
	private void Prediction_Reset() { }

	// RVA: 0xD9E530 Offset: 0xD9CF30 VA: 0x180D9E530
	public bool get_IsHost() { }

	// RVA: 0xD9E650 Offset: 0xD9D050 VA: 0x180D9E650
	public bool get_IsLocalClient() { }

	// RVA: 0xD9C740 Offset: 0xD9B140 VA: 0x180D9C740
	public string GetAddress() { }

	// RVA: 0xD9CD90 Offset: 0xD9B790 VA: 0x180D9CD90
	public void Kick(KickReason kickReason, LoggingType loggingType = 3, string log = "") { }

	// RVA: 0xD9CD40 Offset: 0xD9B740 VA: 0x180D9CD40
	public void Kick(Reader reader, KickReason kickReason, LoggingType loggingType = 3, string log = "") { }
}
