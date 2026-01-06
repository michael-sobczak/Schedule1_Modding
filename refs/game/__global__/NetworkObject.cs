public class NetworkObject : MonoBehaviour // TypeDefIndex: 12583
{
	// Fields
	[CompilerGenerated]
	[HideInInspector]
	[SerializeField]
	private bool <IsNested>k__BackingField; // 0x20
	[CompilerGenerated]
	private NetworkConnection <PredictedSpawner>k__BackingField; // 0x28
	internal bool ActiveDuringEdit; // 0x30
	[HideInInspector]
	[SerializeField]
	[CompilerGenerated]
	private byte <ComponentIndex>k__BackingField; // 0x31
	[CompilerGenerated]
	private int <ObjectId>k__BackingField; // 0x34
	[CompilerGenerated]
	private bool <IsDeinitializing>k__BackingField; // 0x38
	[CompilerGenerated]
	[SerializeField]
	[HideInInspector]
	private PredictedSpawn <PredictedSpawn>k__BackingField; // 0x40
	[HideInInspector]
	[SerializeField]
	private NetworkBehaviour[] _networkBehaviours; // 0x48
	[CompilerGenerated]
	[SerializeField]
	[HideInInspector]
	private NetworkObject <ParentNetworkObject>k__BackingField; // 0x50
	[CompilerGenerated]
	[SerializeField]
	[HideInInspector]
	private List<NetworkObject> <ChildNetworkObjects>k__BackingField; // 0x58
	[CompilerGenerated]
	private NetworkObject <RuntimeParentNetworkObject>k__BackingField; // 0x60
	[CompilerGenerated]
	private Transform <RuntimeParentTransform>k__BackingField; // 0x68
	[CompilerGenerated]
	private List<NetworkObject> <RuntimeChildNetworkObjects>k__BackingField; // 0x70
	[HideInInspector]
	[SerializeField]
	internal TransformProperties SerializedTransformProperties; // 0x78
	internal NetworkObjectState State; // 0xA0
	[SerializeField]
	[Tooltip("True if the object will always initialize as a networked object. When false the object will not automatically initialize over the network. Using Spawn() on an object will always set that instance as networked.")]
	private bool _isNetworked; // 0xA1
	[SerializeField]
	[Tooltip("True to make this object global, and added to the DontDestroyOnLoad scene. This value may only be set for instantiated objects, and can be changed if done immediately after instantiating.")]
	private bool _isGlobal; // 0xA2
	[Tooltip("Order to initialize this object's callbacks when spawned with other NetworkObjects in the same tick. Default value is 0, negative values will execute callbacks first.")]
	[SerializeField]
	private sbyte _initializeOrder; // 0xA3
	[Tooltip("How to handle this object when it despawns. Scene objects are never destroyed when despawning.")]
	[SerializeField]
	private DespawnType _defaultDespawnType; // 0xA4
	private bool _disabledNetworkBehavioursInitialized; // 0xA5
	public const int UNSET_OBJECTID_VALUE = 65535;
	public const int UNSET_PREFABID_VALUE = 65535;
	[CompilerGenerated]
	private NetworkObject.HostVisibilityUpdatedDelegate OnHostVisibilityUpdated; // 0xA8
	[CompilerGenerated]
	private Action<NetworkObject> OnObserversActive; // 0xB0
	[HideInInspector]
	public NetworkObserver NetworkObserver; // 0xB8
	[HideInInspector]
	public HashSet<NetworkConnection> Observers; // 0xC0
	internal GridEntry HashGridEntry; // 0xC8
	private bool _networkObserverInitiliazed; // 0xD0
	private Renderer[] _renderers; // 0xD8
	private bool _renderersPopulated; // 0xE0
	private bool _lastClientHostVisibility; // 0xE1
	private HashGrid _hashGrid; // 0xE8
	private float _nextHashGridUpdateTime; // 0xF0
	private bool _isStatic; // 0xF4
	private Vector2Int _hashGridPosition; // 0xF8
	[CompilerGenerated]
	private bool <IsClientInitialized>k__BackingField; // 0x100
	[CompilerGenerated]
	private bool <IsServerInitialized>k__BackingField; // 0x101
	private NetworkConnection _owner; // 0x108
	[CompilerGenerated]
	private NetworkManager <NetworkManager>k__BackingField; // 0x110
	[CompilerGenerated]
	private ServerManager <ServerManager>k__BackingField; // 0x118
	[CompilerGenerated]
	private ClientManager <ClientManager>k__BackingField; // 0x120
	[CompilerGenerated]
	private ObserverManager <ObserverManager>k__BackingField; // 0x128
	[CompilerGenerated]
	private TransportManager <TransportManager>k__BackingField; // 0x130
	[CompilerGenerated]
	private TimeManager <TimeManager>k__BackingField; // 0x138
	[CompilerGenerated]
	private SceneManager <SceneManager>k__BackingField; // 0x140
	[CompilerGenerated]
	private PredictionManager <PredictionManager>k__BackingField; // 0x148
	[CompilerGenerated]
	private RollbackManager <RollbackManager>k__BackingField; // 0x150
	[CompilerGenerated]
	[HideInInspector]
	[SerializeField]
	private ushort <PrefabId>k__BackingField; // 0x158
	[CompilerGenerated]
	[SerializeField]
	[HideInInspector]
	private ushort <SpawnableCollectionId>k__BackingField; // 0x15A
	[SerializeField]
	[HideInInspector]
	private uint _scenePathHash; // 0x15C
	[CompilerGenerated]
	[SerializeField]
	[HideInInspector]
	private ulong <SceneId>k__BackingField; // 0x160
	[CompilerGenerated]
	[SerializeField]
	[HideInInspector]
	private ulong <AssetPathHash>k__BackingField; // 0x168
	private List<ushort> _rpcLinkIndexes; // 0x170

	// Properties
	public bool IsNested { get; set; }
	public NetworkConnection PredictedSpawner { get; set; }
	public bool IsSceneObject { get; }
	public byte ComponentIndex { get; set; }
	public int ObjectId { get; set; }
	internal bool IsDeinitializing { get; set; }
	public PredictedSpawn PredictedSpawn { get; set; }
	public NetworkBehaviour[] NetworkBehaviours { get; set; }
	public NetworkObject ParentNetworkObject { get; set; }
	public List<NetworkObject> ChildNetworkObjects { get; set; }
	[HideInInspector]
	public NetworkObject RuntimeParentNetworkObject { get; set; }
	[HideInInspector]
	internal NetworkObject CurrentParentNetworkObject { get; }
	public Transform RuntimeParentTransform { get; set; }
	[HideInInspector]
	public List<NetworkObject> RuntimeChildNetworkObjects { get; set; }
	public bool IsNetworked { get; set; }
	public bool IsGlobal { get; set; }
	internal bool AllowPredictedSpawning { get; }
	internal bool AllowPredictedDespawning { get; }
	internal bool AllowPredictedSyncTypes { get; }
	public bool IsClientInitialized { get; set; }
	[Obsolete("Use IsClientInitialized.")]
	public bool ClientInitialized { get; }
	public bool IsClient { get; }
	public bool IsClientOnly { get; }
	public bool IsServerInitialized { get; set; }
	public bool IsServer { get; }
	public bool IsServerOnly { get; }
	public bool IsHost { get; }
	public bool IsOffline { get; }
	public bool IsOwner { get; }
	public NetworkConnection Owner { get; set; }
	public int OwnerId { get; }
	public bool IsSpawned { get; }
	public NetworkConnection LocalConnection { get; }
	public NetworkManager NetworkManager { get; set; }
	public ServerManager ServerManager { get; set; }
	public ClientManager ClientManager { get; set; }
	public ObserverManager ObserverManager { get; set; }
	public TransportManager TransportManager { get; set; }
	public TimeManager TimeManager { get; set; }
	public SceneManager SceneManager { get; set; }
	public PredictionManager PredictionManager { get; set; }
	public RollbackManager RollbackManager { get; set; }
	public ushort PrefabId { get; set; }
	public ushort SpawnableCollectionId { get; set; }
	internal ulong SceneId { get; set; }
	public ulong AssetPathHash { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void Broadcast<T>(T message, bool requireAuthenticated = True, Channel channel = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF16540 Offset: 0xF14F40 VA: 0x180F16540
	|-NetworkObject.Broadcast<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0xD35830 Offset: 0xD34230 VA: 0x180D35830
	private void InitializeCallbacks(bool asServer, bool invokeSyncTypeCallbacks) { }

	// RVA: 0xD360E0 Offset: 0xD34AE0 VA: 0x180D360E0
	internal void InvokeOnStartSyncTypeCallbacks(bool asServer) { }

	// RVA: 0xD36170 Offset: 0xD34B70 VA: 0x180D36170
	internal void InvokeOnStopSyncTypeCallbacks(bool asServer) { }

	// RVA: 0xD36AD0 Offset: 0xD354D0 VA: 0x180D36AD0
	internal void OnSpawnServer(NetworkConnection conn) { }

	// RVA: 0xD36040 Offset: 0xD34A40 VA: 0x180D36040
	internal void InvokeOnServerDespawn(NetworkConnection conn) { }

	// RVA: 0xD36430 Offset: 0xD34E30 VA: 0x180D36430
	internal void InvokeStopCallbacks(bool asServer) { }

	// RVA: 0xD36200 Offset: 0xD34C00 VA: 0x180D36200
	private void InvokeOwnership(NetworkConnection prevOwner, bool asServer) { }

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsNested() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_IsNested(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public NetworkConnection get_PredictedSpawner() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	private void set_PredictedSpawner(NetworkConnection value) { }

	// RVA: 0xD39670 Offset: 0xD38070 VA: 0x180D39670
	public bool get_IsSceneObject() { }

	[CompilerGenerated]
	// RVA: 0x4CD9C0 Offset: 0x4CC3C0 VA: 0x1804CD9C0
	public byte get_ComponentIndex() { }

	[CompilerGenerated]
	// RVA: 0x50AAE0 Offset: 0x5094E0 VA: 0x18050AAE0
	private void set_ComponentIndex(byte value) { }

	[CompilerGenerated]
	// RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00
	public int get_ObjectId() { }

	[CompilerGenerated]
	// RVA: 0x4E2B40 Offset: 0x4E1540 VA: 0x1804E2B40
	private void set_ObjectId(int value) { }

	[CompilerGenerated]
	// RVA: 0x8D2170 Offset: 0x8D0B70 VA: 0x1808D2170
	internal bool get_IsDeinitializing() { }

	[CompilerGenerated]
	// RVA: 0x91C530 Offset: 0x91AF30 VA: 0x18091C530
	private void set_IsDeinitializing(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public PredictedSpawn get_PredictedSpawn() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	private void set_PredictedSpawn(PredictedSpawn value) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public NetworkBehaviour[] get_NetworkBehaviours() { }

	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	private void set_NetworkBehaviours(NetworkBehaviour[] value) { }

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public NetworkObject get_ParentNetworkObject() { }

	[CompilerGenerated]
	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	private void set_ParentNetworkObject(NetworkObject value) { }

	[CompilerGenerated]
	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public List<NetworkObject> get_ChildNetworkObjects() { }

	[CompilerGenerated]
	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	private void set_ChildNetworkObjects(List<NetworkObject> value) { }

	[CompilerGenerated]
	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public NetworkObject get_RuntimeParentNetworkObject() { }

	[CompilerGenerated]
	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	private void set_RuntimeParentNetworkObject(NetworkObject value) { }

	// RVA: 0xD39450 Offset: 0xD37E50 VA: 0x180D39450
	internal NetworkObject get_CurrentParentNetworkObject() { }

	[CompilerGenerated]
	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public Transform get_RuntimeParentTransform() { }

	[CompilerGenerated]
	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	private void set_RuntimeParentTransform(Transform value) { }

	[CompilerGenerated]
	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public List<NetworkObject> get_RuntimeChildNetworkObjects() { }

	[CompilerGenerated]
	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	private void set_RuntimeChildNetworkObjects(List<NetworkObject> value) { }

	// RVA: 0xC21B60 Offset: 0xC20560 VA: 0x180C21B60
	public bool get_IsNetworked() { }

	// RVA: 0xC21CC0 Offset: 0xC206C0 VA: 0x180C21CC0
	private void set_IsNetworked(bool value) { }

	// RVA: 0xC21CC0 Offset: 0xC206C0 VA: 0x180C21CC0
	public void SetIsNetworked(bool value) { }

	// RVA: 0xD395C0 Offset: 0xD37FC0 VA: 0x180D395C0
	public bool get_IsGlobal() { }

	// RVA: 0xD39AC0 Offset: 0xD384C0 VA: 0x180D39AC0
	private void set_IsGlobal(bool value) { }

	// RVA: 0xD37950 Offset: 0xD36350 VA: 0x180D37950
	public void SetIsGlobal(bool value) { }

	// RVA: 0xD34CE0 Offset: 0xD336E0 VA: 0x180D34CE0
	public sbyte GetInitializeOrder() { }

	// RVA: 0x8B3440 Offset: 0x8B1E40 VA: 0x1808B3440
	public DespawnType GetDefaultDespawnType() { }

	// RVA: 0x8B3530 Offset: 0x8B1F30 VA: 0x1808B3530
	public void SetDefaultDespawnType(DespawnType despawnType) { }

	// RVA: 0xD38000 Offset: 0xD36A00 VA: 0x180D38000 Slot: 3
	public override string ToString() { }

	// RVA: 0xD34770 Offset: 0xD33170 VA: 0x180D34770 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0xD37EE0 Offset: 0xD368E0 VA: 0x180D37EE0 Slot: 5
	protected virtual void Start() { }

	// RVA: 0xD36FC0 Offset: 0xD359C0 VA: 0x180D36FC0
	public void PrintNOBs() { }

	// RVA: 0xD36920 Offset: 0xD35320 VA: 0x180D36920
	private void OnDisable() { }

	// RVA: 0xD366A0 Offset: 0xD350A0 VA: 0x180D366A0
	private void OnDestroy() { }

	// RVA: 0xD35C70 Offset: 0xD34670 VA: 0x180D35C70
	private void InitializeNetworkBehavioursIfDisabled() { }

	// RVA: 0xD37880 Offset: 0xD36280 VA: 0x180D37880
	private void SetChildGlobalState() { }

	// RVA: 0xD377C0 Offset: 0xD361C0 VA: 0x180D377C0
	private void SetChildDespawnedState() { }

	// RVA: 0xD37EE0 Offset: 0xD368E0 VA: 0x180D37EE0
	internal void TryStartDeactivation() { }

	// RVA: 0xD37930 Offset: 0xD36330 VA: 0x180D37930
	internal void SetInitializedStatus(bool isInitialized, bool asServer) { }

	// RVA: 0xD37920 Offset: 0xD36320 VA: 0x180D37920
	private void SetDeinitializedStatus() { }

	// RVA: 0xD36C40 Offset: 0xD35640 VA: 0x180D36C40
	internal void Preinitialize_Internal(NetworkManager networkManager, int objectId, NetworkConnection owner, bool asServer) { }

	// RVA: 0xD37CE0 Offset: 0xD366E0 VA: 0x180D37CE0
	public void SetParent(NetworkBehaviour nb) { }

	// RVA: 0xD37CA0 Offset: 0xD366A0 VA: 0x180D37CA0
	public void SetParent(NetworkObject nob) { }

	// RVA: 0xD38110 Offset: 0xD36B10 VA: 0x180D38110
	public void UnsetParent() { }

	// RVA: 0xD389F0 Offset: 0xD373F0 VA: 0x180D389F0
	private void UpdateParent(NetworkObject nob, NetworkBehaviour nb) { }

	// RVA: 0xD35DB0 Offset: 0xD347B0 VA: 0x180D35DB0
	private bool InvalidParent(NetworkObject nob) { }

	// RVA: -1 Offset: -1
	internal T AddAndSerialize<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF16430 Offset: 0xF14E30 VA: 0x180F16430
	|-NetworkObject.AddAndSerialize<object>
	*/

	// RVA: 0xD38240 Offset: 0xD36C40 VA: 0x180D38240
	internal void UpdateNetworkBehaviours(NetworkObject parentNob, ref byte componentIndex) { }

	// RVA: 0xD35D80 Offset: 0xD34780 VA: 0x180D35D80
	internal void Initialize(bool asServer, bool invokeSyncTypeCallbacks) { }

	// RVA: 0xD34950 Offset: 0xD33350 VA: 0x180D34950
	internal void Deinitialize(bool asServer) { }

	[Obsolete("This is no longer used. Remove any calls to this method.")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void ResetForObjectPool() { }

	// RVA: 0xD37440 Offset: 0xD35E40 VA: 0x180D37440
	public void ResetState() { }

	// RVA: 0xD37430 Offset: 0xD35E30 VA: 0x180D37430
	public void RemoveOwnership() { }

	// RVA: 0xD35820 Offset: 0xD34220 VA: 0x180D35820
	public void GiveOwnership(NetworkConnection newOwner) { }

	// RVA: 0xD35270 Offset: 0xD33C70 VA: 0x180D35270
	internal void GiveOwnership(NetworkConnection newOwner, bool asServer) { }

	// RVA: 0xD35D40 Offset: 0xD34740 VA: 0x180D35D40
	internal void InitializePredictedObject_Server(NetworkManager manager, NetworkConnection predictedSpawner) { }

	// RVA: 0xD36BD0 Offset: 0xD355D0 VA: 0x180D36BD0
	internal void PreinitializePredictedObject_Client(NetworkManager manager, int objectId, NetworkConnection owner, NetworkConnection predictedSpawner) { }

	// RVA: 0x6FE090 Offset: 0x6FCA90 VA: 0x1806FE090
	internal void DeinitializePredictedObject_Client() { }

	// RVA: 0x505FC0 Offset: 0x5049C0 VA: 0x180505FC0
	private void SetOwner(NetworkConnection owner) { }

	// RVA: 0xD350A0 Offset: 0xD33AA0 VA: 0x180D350A0
	internal ChangedTransformProperties GetTransformChanges(TransformProperties stp) { }

	// RVA: 0xD34E90 Offset: 0xD33890 VA: 0x180D34E90
	internal ChangedTransformProperties GetTransformChanges(GameObject prefab) { }

	[CompilerGenerated]
	// RVA: 0xD39130 Offset: 0xD37B30 VA: 0x180D39130
	public void add_OnHostVisibilityUpdated(NetworkObject.HostVisibilityUpdatedDelegate value) { }

	[CompilerGenerated]
	// RVA: 0xD39950 Offset: 0xD38350 VA: 0x180D39950
	public void remove_OnHostVisibilityUpdated(NetworkObject.HostVisibilityUpdatedDelegate value) { }

	[CompilerGenerated]
	// RVA: 0xD391E0 Offset: 0xD37BE0 VA: 0x180D391E0
	public void add_OnObserversActive(Action<NetworkObject> value) { }

	[CompilerGenerated]
	// RVA: 0xD39A00 Offset: 0xD38400 VA: 0x180D39A00
	public void remove_OnObserversActive(Action<NetworkObject> value) { }

	// RVA: 0xD38120 Offset: 0xD36B20 VA: 0x180D38120
	internal void UpdateForNetworkObject(bool force) { }

	// RVA: 0xD38F00 Offset: 0xD37900 VA: 0x180D38F00
	public void UpdateRenderers(bool updateVisibility = True) { }

	// RVA: 0xD37D30 Offset: 0xD36730 VA: 0x180D37D30
	public void SetRenderersVisible(bool visible, bool force = False) { }

	// RVA: 0xD38D50 Offset: 0xD37750 VA: 0x180D38D50
	private void UpdateRenderers_Internal(bool updateVisibility) { }

	// RVA: 0xD38C10 Offset: 0xD37610 VA: 0x180D38C10
	private void UpdateRenderVisibility(bool visible) { }

	// RVA: 0xD34710 Offset: 0xD33110 VA: 0x180D34710
	private void AddDefaultNetworkObserverConditions() { }

	// RVA: 0xD37390 Offset: 0xD35D90 VA: 0x180D37390
	internal bool RemoveObserver(NetworkConnection connection) { }

	// RVA: 0xD370D0 Offset: 0xD35AD0 VA: 0x180D370D0
	internal ObserverStateChange RebuildObservers(NetworkConnection connection, bool timedOnly) { }

	// RVA: 0xD38090 Offset: 0xD36A90 VA: 0x180D38090
	private void TryInvokeOnObserversActive(int startCount) { }

	// RVA: 0xD39330 Offset: 0xD37D30 VA: 0x180D39330
	internal bool get_AllowPredictedSpawning() { }

	// RVA: 0xD392A0 Offset: 0xD37CA0 VA: 0x180D392A0
	internal bool get_AllowPredictedDespawning() { }

	// RVA: 0xD393C0 Offset: 0xD37DC0 VA: 0x180D393C0
	internal bool get_AllowPredictedSyncTypes() { }

	[CompilerGenerated]
	// RVA: 0x523400 Offset: 0x521E00 VA: 0x180523400
	public bool get_IsClientInitialized() { }

	[CompilerGenerated]
	// RVA: 0x6051F0 Offset: 0x603BF0 VA: 0x1806051F0
	private void set_IsClientInitialized(bool value) { }

	// RVA: 0x523400 Offset: 0x521E00 VA: 0x180523400
	public bool get_ClientInitialized() { }

	// RVA: 0xD39530 Offset: 0xD37F30 VA: 0x180D39530
	public bool get_IsClient() { }

	// RVA: 0xD39500 Offset: 0xD37F00 VA: 0x180D39500
	public bool get_IsClientOnly() { }

	[CompilerGenerated]
	// RVA: 0xD39680 Offset: 0xD38080 VA: 0x180D39680
	public bool get_IsServerInitialized() { }

	[CompilerGenerated]
	// RVA: 0xD39AD0 Offset: 0xD384D0 VA: 0x180D39AD0
	private void set_IsServerInitialized(bool value) { }

	// RVA: 0xD396C0 Offset: 0xD380C0 VA: 0x180D396C0
	public bool get_IsServer() { }

	// RVA: 0xD39690 Offset: 0xD38090 VA: 0x180D39690
	public bool get_IsServerOnly() { }

	// RVA: 0xD395D0 Offset: 0xD37FD0 VA: 0x180D395D0
	public bool get_IsHost() { }

	// RVA: 0xD39600 Offset: 0xD38000 VA: 0x180D39600
	public bool get_IsOffline() { }

	// RVA: 0xD39630 Offset: 0xD38030 VA: 0x180D39630
	public bool get_IsOwner() { }

	// RVA: 0xD39880 Offset: 0xD38280 VA: 0x180D39880
	public NetworkConnection get_Owner() { }

	// RVA: 0x505FC0 Offset: 0x5049C0 VA: 0x180505FC0
	private void set_Owner(NetworkConnection value) { }

	// RVA: 0xD39830 Offset: 0xD38230 VA: 0x180D39830
	public int get_OwnerId() { }

	// RVA: 0xD39750 Offset: 0xD38150 VA: 0x180D39750
	public bool get_IsSpawned() { }

	// RVA: 0xD39770 Offset: 0xD38170 VA: 0x180D39770
	public NetworkConnection get_LocalConnection() { }

	[CompilerGenerated]
	// RVA: 0x5231F0 Offset: 0x521BF0 VA: 0x1805231F0
	public NetworkManager get_NetworkManager() { }

	[CompilerGenerated]
	// RVA: 0x8937F0 Offset: 0x8921F0 VA: 0x1808937F0
	private void set_NetworkManager(NetworkManager value) { }

	[CompilerGenerated]
	// RVA: 0x5995D0 Offset: 0x597FD0 VA: 0x1805995D0
	public ServerManager get_ServerManager() { }

	[CompilerGenerated]
	// RVA: 0x599620 Offset: 0x598020 VA: 0x180599620
	private void set_ServerManager(ServerManager value) { }

	[CompilerGenerated]
	// RVA: 0x5995E0 Offset: 0x597FE0 VA: 0x1805995E0
	public ClientManager get_ClientManager() { }

	[CompilerGenerated]
	// RVA: 0x599640 Offset: 0x598040 VA: 0x180599640
	private void set_ClientManager(ClientManager value) { }

	[CompilerGenerated]
	// RVA: 0x5233C0 Offset: 0x521DC0 VA: 0x1805233C0
	public ObserverManager get_ObserverManager() { }

	[CompilerGenerated]
	// RVA: 0x5EB2C0 Offset: 0x5E9CC0 VA: 0x1805EB2C0
	private void set_ObserverManager(ObserverManager value) { }

	[CompilerGenerated]
	// RVA: 0x65D840 Offset: 0x65C240 VA: 0x18065D840
	public TransportManager get_TransportManager() { }

	[CompilerGenerated]
	// RVA: 0x65D8D0 Offset: 0x65C2D0 VA: 0x18065D8D0
	private void set_TransportManager(TransportManager value) { }

	[CompilerGenerated]
	// RVA: 0x65D850 Offset: 0x65C250 VA: 0x18065D850
	public TimeManager get_TimeManager() { }

	[CompilerGenerated]
	// RVA: 0x65D8F0 Offset: 0x65C2F0 VA: 0x18065D8F0
	private void set_TimeManager(TimeManager value) { }

	[CompilerGenerated]
	// RVA: 0x67E910 Offset: 0x67D310 VA: 0x18067E910
	public SceneManager get_SceneManager() { }

	[CompilerGenerated]
	// RVA: 0x6FB0A0 Offset: 0x6F9AA0 VA: 0x1806FB0A0
	private void set_SceneManager(SceneManager value) { }

	[CompilerGenerated]
	// RVA: 0x71DB80 Offset: 0x71C580 VA: 0x18071DB80
	public PredictionManager get_PredictionManager() { }

	[CompilerGenerated]
	// RVA: 0x79A930 Offset: 0x799330 VA: 0x18079A930
	private void set_PredictionManager(PredictionManager value) { }

	[CompilerGenerated]
	// RVA: 0x618010 Offset: 0x616A10 VA: 0x180618010
	public RollbackManager get_RollbackManager() { }

	[CompilerGenerated]
	// RVA: 0x71DC00 Offset: 0x71C600 VA: 0x18071DC00
	private void set_RollbackManager(RollbackManager value) { }

	// RVA: 0xD34CF0 Offset: 0xD336F0 VA: 0x180D34CF0
	public NetworkBehaviour GetNetworkBehaviour(byte componentIndex, bool error) { }

	// RVA: 0xD34BF0 Offset: 0xD335F0 VA: 0x180D34BF0
	public void Despawn(GameObject go, Nullable<DespawnType> despawnType) { }

	// RVA: 0xD34BC0 Offset: 0xD335C0 VA: 0x180D34BC0
	public void Despawn(NetworkObject nob, Nullable<DespawnType> despawnType) { }

	// RVA: 0xD34B80 Offset: 0xD33580 VA: 0x180D34B80
	public void Despawn(Nullable<DespawnType> despawnType) { }

	// RVA: 0xD37DA0 Offset: 0xD367A0 VA: 0x180D37DA0
	public void Spawn(GameObject go, NetworkConnection ownerConnection, Scene scene) { }

	// RVA: 0xD37EA0 Offset: 0xD368A0 VA: 0x180D37EA0
	public void Spawn(NetworkObject nob, NetworkConnection ownerConnection, Scene scene) { }

	// RVA: 0xD37AC0 Offset: 0xD364C0 VA: 0x180D37AC0
	public void SetLocalOwnership(NetworkConnection caller) { }

	// RVA: -1 Offset: -1
	public void RegisterInvokeOnInstance<T>(Action<Component> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF168F0 Offset: 0xF152F0 VA: 0x180F168F0
	|-NetworkObject.RegisterInvokeOnInstance<object>
	*/

	// RVA: -1 Offset: -1
	public void UnregisterInvokeOnInstance<T>(Action<Component> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF16B10 Offset: 0xF15510 VA: 0x180F16B10
	|-NetworkObject.UnregisterInvokeOnInstance<object>
	*/

	// RVA: -1 Offset: -1
	public bool HasInstance<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF16810 Offset: 0xF15210 VA: 0x180F16810
	|-NetworkObject.HasInstance<object>
	*/

	// RVA: -1 Offset: -1
	public T GetInstance<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF16720 Offset: 0xF15120 VA: 0x180F16720
	|-NetworkObject.GetInstance<object>
	*/

	// RVA: -1 Offset: -1
	public void RegisterInstance<T>(T component, bool replace = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF16880 Offset: 0xF15280 VA: 0x180F16880
	|-NetworkObject.RegisterInstance<object>
	*/

	// RVA: -1 Offset: -1
	public bool TryRegisterInstance<T>(T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF169B0 Offset: 0xF153B0 VA: 0x180F169B0
	|-NetworkObject.TryRegisterInstance<object>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetInstance<T>(out T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF16950 Offset: 0xF15350 VA: 0x180F16950
	|-NetworkObject.TryGetInstance<object>
	*/

	// RVA: -1 Offset: -1
	public void UnregisterInstance<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF16A80 Offset: 0xF15480 VA: 0x180F16A80
	|-NetworkObject.UnregisterInstance<object>
	*/

	[CompilerGenerated]
	// RVA: 0xD39930 Offset: 0xD38330 VA: 0x180D39930
	public ushort get_PrefabId() { }

	[CompilerGenerated]
	// RVA: 0xD39AE0 Offset: 0xD384E0 VA: 0x180D39AE0
	internal void set_PrefabId(ushort value) { }

	[CompilerGenerated]
	// RVA: 0xD39940 Offset: 0xD38340 VA: 0x180D39940
	public ushort get_SpawnableCollectionId() { }

	[CompilerGenerated]
	// RVA: 0xD39B00 Offset: 0xD38500 VA: 0x180D39B00
	internal void set_SpawnableCollectionId(ushort value) { }

	[CompilerGenerated]
	// RVA: 0x599600 Offset: 0x598000 VA: 0x180599600
	internal ulong get_SceneId() { }

	[CompilerGenerated]
	// RVA: 0xD39AF0 Offset: 0xD384F0 VA: 0x180D39AF0
	private void set_SceneId(ulong value) { }

	[CompilerGenerated]
	// RVA: 0x599610 Offset: 0x598010 VA: 0x180599610
	public ulong get_AssetPathHash() { }

	[CompilerGenerated]
	// RVA: 0xD377B0 Offset: 0xD361B0 VA: 0x180D377B0
	private void set_AssetPathHash(ulong value) { }

	// RVA: 0xD377B0 Offset: 0xD361B0 VA: 0x180D377B0
	public void SetAssetPathHash(ulong value) { }

	// RVA: 0xD348B0 Offset: 0xD332B0 VA: 0x180D348B0
	internal void ClearRuntimeSceneObject() { }

	// RVA: 0x73B4B0 Offset: 0x739EB0 VA: 0x18073B4B0
	internal void SetRpcLinkIndexes(List<ushort> values) { }

	// RVA: 0xD37350 Offset: 0xD35D50 VA: 0x180D37350
	internal void RemoveClientRpcLinkIndexes() { }

	// RVA: 0xD38F10 Offset: 0xD37910 VA: 0x180D38F10
	internal void WriteDirtySyncTypes() { }

	// RVA: 0xD38FB0 Offset: 0xD379B0 VA: 0x180D38FB0
	public void .ctor() { }
}
