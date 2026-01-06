public abstract class NetworkBehaviour : MonoBehaviour // TypeDefIndex: 12581
{
	// Fields
	[CompilerGenerated]
	private bool <OnStartServerCalled>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <OnStartClientCalled>k__BackingField; // 0x21
	private bool _onStartNetworkCalled; // 0x22
	private bool _onStopNetworkCalled; // 0x23
	[HideInInspector]
	[SerializeField]
	private byte _componentIndexCache; // 0x24
	private TransportManager _transportManagerCache; // 0x28
	[SerializeField]
	[HideInInspector]
	private NetworkObject _networkObjectCache; // 0x30
	private bool _initializedOnceServer; // 0x38
	private bool _initializedOnceClient; // 0x39
	internal bool ClientHasReconcileData; // 0x3A
	private uint _lastReplicateTick; // 0x3C
	[CompilerGenerated]
	private bool <IsReconciling>k__BackingField; // 0x40
	private readonly Dictionary<uint, ReplicateRpcDelegate> _replicateRpcDelegates; // 0x48
	private readonly Dictionary<uint, ReconcileRpcDelegate> _reconcileRpcDelegates; // 0x50
	private bool _predictionInitialized; // 0x58
	private Rigidbody _predictionRigidbody; // 0x60
	private Rigidbody2D _predictionRigidbody2d; // 0x68
	private Vector3 _lastMayChangePosition; // 0x70
	private Quaternion _lastMayChangeRotation; // 0x7C
	private Vector3 _lastMayChangeScale; // 0x8C
	private int _remainingResends; // 0x98
	private uint _lastSentReplicateTick; // 0x9C
	private uint _lastReceivedReplicateTick; // 0xA0
	private uint _lastReceivedReconcileTick; // 0xA4
	private uint _lastReconcileTick; // 0xA8
	private Dictionary<uint, RpcLinkType> _rpcLinks; // 0xB0
	private readonly Dictionary<uint, ServerRpcDelegate> _serverRpcDelegates; // 0xB8
	private readonly Dictionary<uint, ClientRpcDelegate> _observersRpcDelegates; // 0xC0
	private readonly Dictionary<uint, ClientRpcDelegate> _targetRpcDelegates; // 0xC8
	private uint _rpcMethodCount; // 0xD0
	private byte _rpcHashSize; // 0xD4
	private Dictionary<uint, NetworkBehaviour.BufferedRpc> _bufferedRpcs; // 0xD8
	private HashSet<NetworkConnection> _networkConnectionCache; // 0xE0
	private const int MAXIMUM_RPC_HEADER_SIZE = 10;
	private NetworkBehaviour.SyncTypeWriter[] _syncTypeWriters; // 0xE8
	private Dictionary<uint, SyncBase> _syncVars; // 0xF0
	internal bool SyncVarDirty; // 0xF8
	private Dictionary<uint, SyncBase> _syncObjects; // 0x100
	internal bool SyncObjectDirty; // 0x108
	private static ReadPermission[] _readPermissions; // 0x0
	private List<SyncVarReadDelegate> _syncVarReadDelegates; // 0x110

	// Properties
	[APIExclude]
	public bool OnStartServerCalled { get; set; }
	[APIExclude]
	public bool OnStartClientCalled { get; set; }
	public bool IsSpawned { get; }
	public byte ComponentIndex { get; set; }
	public NetworkObject NetworkObject { get; }
	public bool IsReconciling { get; set; }
	public bool IsDeinitializing { get; }
	public NetworkManager NetworkManager { get; }
	public ServerManager ServerManager { get; }
	public ClientManager ClientManager { get; }
	public ObserverManager ObserverManager { get; }
	public TransportManager TransportManager { get; }
	public TimeManager TimeManager { get; }
	public SceneManager SceneManager { get; }
	public PredictionManager PredictionManager { get; }
	public RollbackManager RollbackManager { get; }
	public NetworkObserver NetworkObserver { get; }
	public bool IsClientInitialized { get; }
	public bool IsClient { get; }
	public bool IsClientOnly { get; }
	public bool IsServerInitialized { get; }
	public bool IsServer { get; }
	public bool IsServerOnly { get; }
	public bool IsHost { get; }
	public bool IsOffline { get; }
	public bool IsNetworked { get; }
	public HashSet<NetworkConnection> Observers { get; }
	public bool IsOwner { get; }
	public NetworkConnection Owner { get; }
	public int OwnerId { get; }
	public int ObjectId { get; }
	public NetworkConnection LocalConnection { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_OnStartServerCalled() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_OnStartServerCalled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x563D50 Offset: 0x562750 VA: 0x180563D50
	public bool get_OnStartClientCalled() { }

	[CompilerGenerated]
	// RVA: 0x563DA0 Offset: 0x5627A0 VA: 0x180563DA0
	private void set_OnStartClientCalled(bool value) { }

	// RVA: 0xD2EFF0 Offset: 0xD2D9F0 VA: 0x180D2EFF0
	internal void InvokeSyncTypeOnStartCallbacks(bool asServer) { }

	// RVA: 0xD2F240 Offset: 0xD2DC40 VA: 0x180D2F240
	internal void InvokeSyncTypeOnStopCallbacks(bool asServer) { }

	// RVA: 0xD2EFA0 Offset: 0xD2D9A0 VA: 0x180D2EFA0
	internal void InvokeOnNetwork(bool start) { }

	// RVA: 0xD30200 Offset: 0xD2EC00 VA: 0x180D30200
	internal void OnStartNetwork_Internal() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 4
	public virtual void OnStartNetwork() { }

	// RVA: 0xD30260 Offset: 0xD2EC60 VA: 0x180D30260
	internal void OnStopNetwork_Internal() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public virtual void OnStopNetwork() { }

	// RVA: 0xD30220 Offset: 0xD2EC20 VA: 0x180D30220
	internal void OnStartServer_Internal() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 6
	public virtual void OnStartServer() { }

	// RVA: 0xD30280 Offset: 0xD2EC80 VA: 0x180D30280
	internal void OnStopServer_Internal() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 7
	public virtual void OnStopServer() { }

	// RVA: 0xD2F960 Offset: 0xD2E360 VA: 0x180D2F960
	internal void OnOwnershipServer_Internal(NetworkConnection prevOwner) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 8
	public virtual void OnOwnershipServer(NetworkConnection prevOwner) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 9
	public virtual void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 10
	public virtual void OnDespawnServer(NetworkConnection connection) { }

	// RVA: 0xD301E0 Offset: 0xD2EBE0 VA: 0x180D301E0
	internal void OnStartClient_Internal() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 11
	public virtual void OnStartClient() { }

	// RVA: 0xD30240 Offset: 0xD2EC40 VA: 0x180D30240
	internal void OnStopClient_Internal() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 12
	public virtual void OnStopClient() { }

	// RVA: 0xD2F8A0 Offset: 0xD2E2A0 VA: 0x180D2F8A0
	internal void OnOwnershipClient_Internal(NetworkConnection prevOwner) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 13
	public virtual void OnOwnershipClient(NetworkConnection prevOwner) { }

	// RVA: 0xD34300 Offset: 0xD32D00 VA: 0x180D34300
	public bool get_IsSpawned() { }

	// RVA: 0x563D90 Offset: 0x562790 VA: 0x180563D90
	public byte get_ComponentIndex() { }

	// RVA: 0x563E00 Offset: 0x562800 VA: 0x180563E00
	private void set_ComponentIndex(byte value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public NetworkObject get_NetworkObject() { }

	// RVA: 0xD32880 Offset: 0xD31280 VA: 0x180D32880 Slot: 3
	public override string ToString() { }

	// RVA: 0xD30E50 Offset: 0xD2F850 VA: 0x180D30E50
	internal void Preinitialize_Internal(NetworkObject nob, bool asServer) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal void Deinitialize(bool asServer) { }

	// RVA: 0xD32300 Offset: 0xD30D00 VA: 0x180D32300
	internal void SerializeComponents(NetworkObject nob, byte componentIndex) { }

	// RVA: 0xD2E180 Offset: 0xD2CB80 VA: 0x180D2E180
	internal void InitializeIfDisabled() { }

	[APIExclude]
	[CodegenMakePublic]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 14
	public virtual void NetworkInitializeIfDisabled() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 15
	protected virtual void Reset() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 16
	protected virtual void OnValidate() { }

	// RVA: 0xD319B0 Offset: 0xD303B0 VA: 0x180D319B0
	internal void ResetState() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770
	private NetworkObject TryAddNetworkObject() { }

	// RVA: 0xD2D880 Offset: 0xD2C280 VA: 0x180D2D880
	public bool CanLog(LoggingType loggingType) { }

	// RVA: 0x587050 Offset: 0x585A50 VA: 0x180587050
	public uint GetLastReconcileTick() { }

	// RVA: 0xD32330 Offset: 0xD30D30 VA: 0x180D32330
	internal void SetLastReconcileTick(uint value, bool updateGlobals = True) { }

	// RVA: 0xC21BD0 Offset: 0xC205D0 VA: 0x180C21BD0
	public uint GetLastReplicateTick() { }

	// RVA: 0xD32370 Offset: 0xD30D70 VA: 0x180D32370
	private void SetLastReplicateTick(uint value, bool updateGlobals = True) { }

	[CompilerGenerated]
	// RVA: 0x4988A0 Offset: 0x4972A0 VA: 0x1804988A0
	public bool get_IsReconciling() { }

	[CompilerGenerated]
	// RVA: 0x498920 Offset: 0x497320 VA: 0x180498920
	internal void set_IsReconciling(bool value) { }

	[CodegenMakePublic]
	// RVA: 0xD31260 Offset: 0xD2FC60 VA: 0x180D31260
	public void RegisterReplicateRpc(uint hash, ReplicateRpcDelegate del) { }

	[CodegenMakePublic]
	// RVA: 0xD311F0 Offset: 0xD2FBF0 VA: 0x180D311F0
	public void RegisterReconcileRpc(uint hash, ReconcileRpcDelegate del) { }

	// RVA: 0xD2FBC0 Offset: 0xD2E5C0 VA: 0x180D2FBC0
	internal void OnReplicateRpc(Nullable<uint> methodHash, PooledReader reader, NetworkConnection sendingClient, Channel channel) { }

	// RVA: 0xD2F9C0 Offset: 0xD2E3C0 VA: 0x180D2F9C0
	internal void OnReconcileRpc(Nullable<uint> methodHash, PooledReader reader, Channel channel) { }

	// RVA: 0xD2DAF0 Offset: 0xD2C4F0 VA: 0x180D2DAF0
	public void ClearReplicateCache(bool asServer) { }

	// RVA: 0xD2DAA0 Offset: 0xD2C4A0 VA: 0x180D2DAA0
	public void ClearReplicateCache() { }

	[CodegenMakePublic]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 17
	public virtual void ClearReplicateCache_Virtual(bool asServer) { }

	// RVA: 0xD31990 Offset: 0xD30390 VA: 0x180D31990
	private void ResetLastPredictionTicks() { }

	// RVA: -1 Offset: -1
	private void Owner_SendReplicateRpc<T>(uint hash, List<T> replicates, Channel channel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF11A60 Offset: 0xF10460 VA: 0x180F11A60
	|-NetworkBehaviour.Owner_SendReplicateRpc<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xF11CE0 Offset: 0xF106E0 VA: 0x180F11CE0
	|-NetworkBehaviour.Owner_SendReplicateRpc<RigidbodyPrediction.MoveData>
	*/

	// RVA: -1 Offset: -1
	private void Server_SendReconcileRpc<T>(uint hash, T reconcileData, Channel channel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF14C70 Offset: 0xF13670 VA: 0x180F14C70
	|-NetworkBehaviour.Server_SendReconcileRpc<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xF01A80 Offset: 0xF00480 VA: 0x180F01A80
	|-NetworkBehaviour.Server_SendReconcileRpc<RigidbodyPrediction.ReconcileData>
	*/

	// RVA: 0xD30820 Offset: 0xD2F220 VA: 0x180D30820
	protected internal bool PredictedTransformMayChange() { }

	[CodegenMakePublic]
	// RVA: 0xD31830 Offset: 0xD30230 VA: 0x180D31830
	public bool Replicate_ExitEarly_A(bool asServer, bool replaying, bool allowServerControl) { }

	[CodegenMakePublic]
	// RVA: -1 Offset: -1
	public void Replicate_NonOwner<T>(ReplicateUserLogicDelegate<T> del, BasicQueue<T> q, T serverControlData, bool allowServerControl, Channel channel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF13860 Offset: 0xF12260 VA: 0x180F13860
	|-NetworkBehaviour.Replicate_NonOwner<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xF13CC0 Offset: 0xF126C0 VA: 0x180F13CC0
	|-NetworkBehaviour.Replicate_NonOwner<RigidbodyPrediction.MoveData>
	*/

	[CodegenMakePublic]
	// RVA: -1 Offset: -1
	public void Replicate_Owner<T>(ReplicateUserLogicDelegate<T> del, uint methodHash, List<T> replicates, T data, Channel channel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF13F90 Offset: 0xF12990 VA: 0x180F13F90
	|-NetworkBehaviour.Replicate_Owner<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xF145C0 Offset: 0xF12FC0 VA: 0x180F145C0
	|-NetworkBehaviour.Replicate_Owner<RigidbodyPrediction.MoveData>
	*/

	[CodegenMakePublic]
	// RVA: -1 Offset: -1
	public void Replicate_Reader<T>(PooledReader reader, NetworkConnection sender, T[] arrBuffer, BasicQueue<T> replicates, Channel channel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF14990 Offset: 0xF13390 VA: 0x180F14990
	|-NetworkBehaviour.Replicate_Reader<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xF14B00 Offset: 0xF13500 VA: 0x180F14B00
	|-NetworkBehaviour.Replicate_Reader<RigidbodyPrediction.MoveData>
	*/

	// RVA: -1 Offset: -1
	private void Replicate_HandleReceivedReplicate<T>(int receivedReplicatesCount, T[] arrBuffer, BasicQueue<T> replicates, Channel channel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF13290 Offset: 0xF11C90 VA: 0x180F13290
	|-NetworkBehaviour.Replicate_HandleReceivedReplicate<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xF13660 Offset: 0xF12060 VA: 0x180F13660
	|-NetworkBehaviour.Replicate_HandleReceivedReplicate<RigidbodyPrediction.MoveData>
	*/

	[CodegenMakePublic]
	// RVA: 0xD30F50 Offset: 0xD2F950 VA: 0x180D30F50
	public bool Reconcile_ExitEarly_A(bool asServer, out Channel channel) { }

	[CodegenMakePublic]
	// RVA: -1 Offset: -1
	public void Reconcile_Server<T>(uint methodHash, T data, Channel channel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF12E50 Offset: 0xF11850 VA: 0x180F12E50
	|-NetworkBehaviour.Reconcile_Server<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xF13080 Offset: 0xF11A80 VA: 0x180F13080
	|-NetworkBehaviour.Reconcile_Server<RigidbodyPrediction.ReconcileData>
	*/

	[CodegenMakePublic]
	// RVA: -1 Offset: -1
	public void Reconcile_Client<T, T2>(ReconcileUserLogicDelegate<T> reconcileDel, ReplicateUserLogicDelegate<T2> replicateULDel, List<T2> replicates, T data, Channel channel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF11F30 Offset: 0xF10930 VA: 0x180F11F30
	|-NetworkBehaviour.Reconcile_Client<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	|
	|-RVA: 0xF12790 Offset: 0xF11190 VA: 0x180F12790
	|-NetworkBehaviour.Reconcile_Client<RigidbodyPrediction.ReconcileData, RigidbodyPrediction.MoveData>
	*/

	// RVA: -1 Offset: -1
	public void Reconcile_Reader<T>(PooledReader reader, ref T data, Channel channel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF12B70 Offset: 0xF11570 VA: 0x180F12B70
	|-NetworkBehaviour.Reconcile_Reader<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xF12D80 Offset: 0xF11780 VA: 0x180F12D80
	|-NetworkBehaviour.Reconcile_Reader<RigidbodyPrediction.ReconcileData>
	*/

	// RVA: 0xD34180 Offset: 0xD32B80 VA: 0x180D34180
	public bool get_IsDeinitializing() { }

	// RVA: 0xD343F0 Offset: 0xD32DF0 VA: 0x180D343F0
	public NetworkManager get_NetworkManager() { }

	// RVA: 0xD34640 Offset: 0xD33040 VA: 0x180D34640
	public ServerManager get_ServerManager() { }

	// RVA: 0xD340E0 Offset: 0xD32AE0 VA: 0x180D340E0
	public ClientManager get_ClientManager() { }

	// RVA: 0xD34450 Offset: 0xD32E50 VA: 0x180D34450
	public ObserverManager get_ObserverManager() { }

	// RVA: 0xD34680 Offset: 0xD33080 VA: 0x180D34680
	public TransportManager get_TransportManager() { }

	// RVA: 0xD34660 Offset: 0xD33060 VA: 0x180D34660
	public TimeManager get_TimeManager() { }

	// RVA: 0xD34620 Offset: 0xD33020 VA: 0x180D34620
	public SceneManager get_SceneManager() { }

	// RVA: 0xD345E0 Offset: 0xD32FE0 VA: 0x180D345E0
	public PredictionManager get_PredictionManager() { }

	// RVA: 0xD34600 Offset: 0xD33000 VA: 0x180D34600
	public RollbackManager get_RollbackManager() { }

	// RVA: 0xD34410 Offset: 0xD32E10 VA: 0x180D34410
	public NetworkObserver get_NetworkObserver() { }

	// RVA: 0xD34100 Offset: 0xD32B00 VA: 0x180D34100
	public bool get_IsClientInitialized() { }

	// RVA: 0xD34160 Offset: 0xD32B60 VA: 0x180D34160
	public bool get_IsClient() { }

	// RVA: 0xD34120 Offset: 0xD32B20 VA: 0x180D34120
	public bool get_IsClientOnly() { }

	// RVA: 0xD34280 Offset: 0xD32C80 VA: 0x180D34280
	public bool get_IsServerInitialized() { }

	// RVA: 0xD342E0 Offset: 0xD32CE0 VA: 0x180D342E0
	public bool get_IsServer() { }

	// RVA: 0xD342A0 Offset: 0xD32CA0 VA: 0x180D342A0
	public bool get_IsServerOnly() { }

	// RVA: 0xD341A0 Offset: 0xD32BA0 VA: 0x180D341A0
	public bool get_IsHost() { }

	// RVA: 0xD34200 Offset: 0xD32C00 VA: 0x180D34200
	public bool get_IsOffline() { }

	// RVA: 0xD341E0 Offset: 0xD32BE0 VA: 0x180D341E0
	public bool get_IsNetworked() { }

	// RVA: 0xD34470 Offset: 0xD32E70 VA: 0x180D34470
	public HashSet<NetworkConnection> get_Observers() { }

	// RVA: 0xD34240 Offset: 0xD32C40 VA: 0x180D34240
	public bool get_IsOwner() { }

	// RVA: 0xD344F0 Offset: 0xD32EF0 VA: 0x180D344F0
	public NetworkConnection get_Owner() { }

	// RVA: 0xD34490 Offset: 0xD32E90 VA: 0x180D34490
	public int get_OwnerId() { }

	// RVA: 0xD34430 Offset: 0xD32E30 VA: 0x180D34430
	public int get_ObjectId() { }

	// RVA: 0xD34330 Offset: 0xD32D30 VA: 0x180D34330
	public NetworkConnection get_LocalConnection() { }

	// RVA: 0xD307E0 Offset: 0xD2F1E0 VA: 0x180D307E0
	public bool OwnerMatches(NetworkConnection connection) { }

	// RVA: 0xD2DEA0 Offset: 0xD2C8A0 VA: 0x180D2DEA0
	public void Despawn(GameObject go, Nullable<DespawnType> despawnType) { }

	// RVA: 0xD2DFC0 Offset: 0xD2C9C0 VA: 0x180D2DFC0
	public void Despawn(NetworkObject nob, Nullable<DespawnType> despawnType) { }

	// RVA: 0xD2DE40 Offset: 0xD2C840 VA: 0x180D2DE40
	public void Despawn(Nullable<DespawnType> despawnType) { }

	// RVA: 0xD32500 Offset: 0xD30F00 VA: 0x180D32500
	public void Spawn(GameObject go, NetworkConnection ownerConnection, Scene scene) { }

	// RVA: 0xD32620 Offset: 0xD31020 VA: 0x180D32620
	public void Spawn(NetworkObject nob, NetworkConnection ownerConnection, Scene scene) { }

	// RVA: 0xD2F490 Offset: 0xD2DE90 VA: 0x180D2F490
	private bool IsNetworkObjectNull(bool warn) { }

	// RVA: 0xD31800 Offset: 0xD30200 VA: 0x180D31800
	public void RemoveOwnership() { }

	// RVA: 0xD2E130 Offset: 0xD2CB30 VA: 0x180D2E130
	public void GiveOwnership(NetworkConnection newOwner) { }

	// RVA: -1 Offset: -1
	public void RegisterInvokeOnInstance<T>(Action<Component> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF13210 Offset: 0xF11C10 VA: 0x180F13210
	|-NetworkBehaviour.RegisterInvokeOnInstance<object>
	*/

	// RVA: -1 Offset: -1
	public void UnregisterInvokeOnInstance<T>(Action<Component> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF15360 Offset: 0xF13D60 VA: 0x180F15360
	|-NetworkBehaviour.UnregisterInvokeOnInstance<object>
	*/

	// RVA: -1 Offset: -1
	public T GetInstance<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF11940 Offset: 0xF10340 VA: 0x180F11940
	|-NetworkBehaviour.GetInstance<object>
	*/

	// RVA: -1 Offset: -1
	public void RegisterInstance<T>(T component, bool replace = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF13180 Offset: 0xF11B80 VA: 0x180F13180
	|-NetworkBehaviour.RegisterInstance<object>
	*/

	// RVA: -1 Offset: -1
	public bool TryRegisterInstance<T>(T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF14F40 Offset: 0xF13940 VA: 0x180F14F40
	|-NetworkBehaviour.TryRegisterInstance<object>
	*/

	// RVA: -1 Offset: -1
	public void UnregisterInstance<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF152B0 Offset: 0xF13CB0 VA: 0x180F152B0
	|-NetworkBehaviour.UnregisterInstance<object>
	*/

	// RVA: 0xD2EA40 Offset: 0xD2D440 VA: 0x180D2EA40
	private void InitializeRpcLinks() { }

	// RVA: 0xAC9260 Offset: 0xAC7C60 VA: 0x180AC9260
	private int GetEstimatedRpcHeaderLength() { }

	// RVA: 0xD2DB20 Offset: 0xD2C520 VA: 0x180D2DB20
	private PooledWriter CreateLinkedRpc(RpcLinkType link, PooledWriter methodWriter, Channel channel) { }

	// RVA: 0xD31A20 Offset: 0xD30420 VA: 0x180D31A20
	private void ReturnRpcLinks() { }

	// RVA: 0xD337D0 Offset: 0xD321D0 VA: 0x180D337D0
	internal void WriteRpcLinks(Writer writer) { }

	// RVA: 0xD31AC0 Offset: 0xD304C0 VA: 0x180D31AC0
	internal void SendBufferedRpcs(NetworkConnection conn) { }

	[CodegenMakePublic]
	[APIExclude]
	// RVA: 0xD312D0 Offset: 0xD2FCD0 VA: 0x180D312D0
	public void RegisterServerRpc(uint hash, ServerRpcDelegate del) { }

	[APIExclude]
	[CodegenMakePublic]
	// RVA: 0xD30FF0 Offset: 0xD2F9F0 VA: 0x180D30FF0
	public void RegisterObserversRpc(uint hash, ClientRpcDelegate del) { }

	[CodegenMakePublic]
	[APIExclude]
	// RVA: 0xD31600 Offset: 0xD30000 VA: 0x180D31600
	public void RegisterTargetRpc(uint hash, ClientRpcDelegate del) { }

	// RVA: 0xD2E160 Offset: 0xD2CB60 VA: 0x180D2E160
	private void IncreaseRpcMethodCount() { }

	// RVA: 0xD2D930 Offset: 0xD2C330 VA: 0x180D2D930
	public void ClearBuffedRpcs() { }

	// RVA: 0xD30EC0 Offset: 0xD2F8C0 VA: 0x180D30EC0
	private uint ReadRpcHash(PooledReader reader) { }

	// RVA: 0xD2FF10 Offset: 0xD2E910 VA: 0x180D2FF10
	internal void OnServerRpc(PooledReader reader, NetworkConnection sendingClient, Channel channel) { }

	// RVA: 0xD2F630 Offset: 0xD2E030 VA: 0x180D2F630
	internal void OnObserversRpc(Nullable<uint> methodHash, PooledReader reader, Channel channel) { }

	// RVA: 0xD30570 Offset: 0xD2EF70 VA: 0x180D30570
	internal void OnTargetRpc(Nullable<uint> methodHash, PooledReader reader, Channel channel) { }

	[CodegenMakePublic]
	// RVA: 0x580410 Offset: 0x57EE10 VA: 0x180580410
	public void SendServerRpc(uint hash, PooledWriter methodWriter, Channel channel, DataOrderType orderType) { }

	[APIExclude]
	[CodegenMakePublic]
	// RVA: 0xD31D70 Offset: 0xD30770 VA: 0x180D31D70
	public void SendObserversRpc(uint hash, PooledWriter methodWriter, Channel channel, DataOrderType orderType, bool bufferLast, bool excludeServer, bool excludeOwner) { }

	[CodegenMakePublic]
	// RVA: 0xD32010 Offset: 0xD30A10 VA: 0x180D32010
	public void SendTargetRpc(uint hash, PooledWriter methodWriter, Channel channel, DataOrderType orderType, NetworkConnection target, bool excludeServer, bool validateTarget = True) { }

	// RVA: 0xD323F0 Offset: 0xD30DF0 VA: 0x180D323F0
	private void SetNetworkConnectionCache(bool addClientHost, bool addOwner) { }

	// RVA: 0xD2F540 Offset: 0xD2DF40 VA: 0x180D2F540
	private bool IsSpawnedWithWarning() { }

	// RVA: 0xD2DC90 Offset: 0xD2C690 VA: 0x180D2DC90
	private PooledWriter CreateRpc(uint hash, PooledWriter methodWriter, PacketId packetId, Channel channel) { }

	// RVA: 0xD33790 Offset: 0xD32190 VA: 0x180D33790
	private void WriteRpcHash(uint hash, PooledWriter writer) { }

	[CodegenMakePublic]
	// RVA: 0xD31550 Offset: 0xD2FF50 VA: 0x180D31550
	public void RegisterSyncVarRead(SyncVarReadDelegate del) { }

	// RVA: 0xD314D0 Offset: 0xD2FED0 VA: 0x180D314D0
	internal void RegisterSyncType(SyncBase sb, uint index) { }

	// RVA: 0xD2E030 Offset: 0xD2CA30 VA: 0x180D2E030
	internal bool DirtySyncType(bool isSyncObject) { }

	// RVA: 0xD2E1D0 Offset: 0xD2CBD0 VA: 0x180D2E1D0
	private void InitializeOnceSyncTypes(bool asServer) { }

	// RVA: 0xD302B0 Offset: 0xD2ECB0 VA: 0x180D302B0
	internal void OnSyncType(PooledReader reader, int length, bool isSyncObject, bool asServer = False) { }

	// RVA: 0xD32E40 Offset: 0xD31840 VA: 0x180D32E40
	internal bool WriteDirtySyncTypes(bool isSyncObject, bool ignoreInterval = False) { }

	// RVA: 0xD326A0 Offset: 0xD310A0 VA: 0x180D326A0
	internal void SyncTypes_ResetState() { }

	[CodegenMakePublic]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 18
	public virtual void ResetSyncVarFields() { }

	// RVA: 0xD33D00 Offset: 0xD32700 VA: 0x180D33D00
	internal void WriteSyncTypesForSpawn(PooledWriter writer, NetworkConnection conn) { }

	[Obsolete("This method does not function.")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	protected void DirtySyncType(object syncType) { }

	// RVA: 0xD33D90 Offset: 0xD32790 VA: 0x180D33D90
	protected void .ctor() { }

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <Replicate_NonOwner>g__ReplicateData|89_0<T>(T data, ref NetworkBehaviour.<>c__DisplayClass89_0<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF15040 Offset: 0xF13A40 VA: 0x180F15040
	|-NetworkBehaviour.<Replicate_NonOwner>g__ReplicateData|89_0<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xF15220 Offset: 0xF13C20 VA: 0x180F15220
	|-NetworkBehaviour.<Replicate_NonOwner>g__ReplicateData|89_0<RigidbodyPrediction.MoveData>
	*/

	[CompilerGenerated]
	// RVA: 0xD32AB0 Offset: 0xD314B0 VA: 0x180D32AB0
	private bool <InitializeRpcLinks>g__MakeLink|165_0(uint rpcHash, RpcType rpcType, ref NetworkBehaviour.<>c__DisplayClass165_0 ) { }

	[CompilerGenerated]
	// RVA: 0xD32B60 Offset: 0xD31560 VA: 0x180D32B60
	private void <WriteSyncTypesForSpawn>g__WriteSyncType|212_0(Dictionary<uint, SyncBase> collection, ref NetworkBehaviour.<>c__DisplayClass212_0 ) { }
}
