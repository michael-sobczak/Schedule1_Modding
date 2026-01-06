public sealed class NetworkManager : MonoBehaviour // TypeDefIndex: 12723
{
	// Fields
	[CompilerGenerated]
	private bool <Initialized>k__BackingField; // 0x20
	private static List<NetworkManager> _instances; // 0x0
	[CompilerGenerated]
	private PredictionManager <PredictionManager>k__BackingField; // 0x28
	[CompilerGenerated]
	private ServerManager <ServerManager>k__BackingField; // 0x30
	[CompilerGenerated]
	private ClientManager <ClientManager>k__BackingField; // 0x38
	[CompilerGenerated]
	private TransportManager <TransportManager>k__BackingField; // 0x40
	[CompilerGenerated]
	private TimeManager <TimeManager>k__BackingField; // 0x48
	[CompilerGenerated]
	private SceneManager <SceneManager>k__BackingField; // 0x50
	[CompilerGenerated]
	private ObserverManager <ObserverManager>k__BackingField; // 0x58
	[CompilerGenerated]
	private DebugManager <DebugManager>k__BackingField; // 0x60
	[CompilerGenerated]
	private StatisticsManager <StatisticsManager>k__BackingField; // 0x68
	[CompilerGenerated]
	private static NetworkConnection <EmptyConnection>k__BackingField; // 0x8
	public static bool FastEnterPlayMode; // 0x10
	internal static ushort StartingRpcLinkIndex; // 0x12
	[SerializeField]
	[Tooltip("True to refresh the DefaultPrefabObjects collection whenever the editor enters play mode. This is an attempt to alleviate the DefaultPrefabObjects scriptable object not refreshing when using multiple editor applications such as ParrelSync.")]
	private bool _refreshDefaultPrefabs; // 0x70
	[SerializeField]
	[Tooltip("True to have your application run while in the background.")]
	private bool _runInBackground; // 0x71
	[Tooltip("True to make this instance DontDestroyOnLoad. This is typical if you only want one NetworkManager.")]
	[SerializeField]
	private bool _dontDestroyOnLoad; // 0x72
	[SerializeField]
	[Tooltip("Object pool to use for this NetworkManager. Value may be null.")]
	private ObjectPool _objectPool; // 0x78
	[SerializeField]
	[Tooltip("How to persist when other NetworkManagers are introduced.")]
	private NetworkManager.PersistenceType _persistence; // 0x80
	private bool _canPersist; // 0x84
	internal const ushort MAXIMUM_FRAMERATE = 500;
	[SerializeField]
	[Tooltip("Logging configuration to use. When empty default logging settings will be used.")]
	private LoggingConfiguration _logging; // 0x88
	private const string ERROR_LOGGING_PREFIX = "Error - ";
	private const string WARNING_LOGGING_PREFIX = "Warning - ";
	private const string COMMON_LOGGING_PREFIX = "Log - ";
	[CompilerGenerated]
	private RollbackManager <RollbackManager>k__BackingField; // 0x90
	[Tooltip("Collection to use for spawnable objects.")]
	[SerializeField]
	private PrefabObjects _spawnablePrefabs; // 0x98
	private Dictionary<ushort, PrefabObjects> _runtimeSpawnablePrefabs; // 0xA0
	private Dictionary<string, List<Action<Component>>> _pendingInvokes; // 0xA8
	private Dictionary<string, Component> _registeredComponents; // 0xB0

	// Properties
	public bool Initialized { get; set; }
	public static IReadOnlyCollection<NetworkManager> Instances { get; }
	public bool IsServer { get; }
	public bool IsServerOnly { get; }
	public bool IsClient { get; }
	public bool IsClientOnly { get; }
	public bool IsHost { get; }
	public bool IsOffline { get; }
	internal PredictionManager PredictionManager { get; set; }
	public ServerManager ServerManager { get; set; }
	public ClientManager ClientManager { get; set; }
	public TransportManager TransportManager { get; set; }
	public TimeManager TimeManager { get; set; }
	public SceneManager SceneManager { get; set; }
	public ObserverManager ObserverManager { get; set; }
	[Obsolete("Use ServerManager.GetAuthenticator or ServerManager.SetAuthenticator instead.")]
	public Authenticator Authenticator { get; }
	public DebugManager DebugManager { get; set; }
	public StatisticsManager StatisticsManager { get; set; }
	[APIExclude]
	public static NetworkConnection EmptyConnection { get; set; }
	public ObjectPool ObjectPool { get; }
	public RollbackManager RollbackManager { get; set; }
	public PrefabObjects SpawnablePrefabs { get; set; }
	public IReadOnlyDictionary<ushort, PrefabObjects> RuntimeSpawnablePrefabs { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_Initialized() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_Initialized(bool value) { }

	// RVA: 0xD629E0 Offset: 0xD613E0 VA: 0x180D629E0
	public static IReadOnlyCollection<NetworkManager> get_Instances() { }

	// RVA: 0xD62CE0 Offset: 0xD616E0 VA: 0x180D62CE0
	public bool get_IsServer() { }

	// RVA: 0xD62C90 Offset: 0xD61690 VA: 0x180D62C90
	public bool get_IsServerOnly() { }

	// RVA: 0xD62BB0 Offset: 0xD615B0 VA: 0x180D62BB0
	public bool get_IsClient() { }

	// RVA: 0xD62B60 Offset: 0xD61560 VA: 0x180D62B60
	public bool get_IsClientOnly() { }

	// RVA: 0xD62BF0 Offset: 0xD615F0 VA: 0x180D62BF0
	public bool get_IsHost() { }

	// RVA: 0xD62C40 Offset: 0xD61640 VA: 0x180D62C40
	public bool get_IsOffline() { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	internal PredictionManager get_PredictionManager() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	private void set_PredictionManager(PredictionManager value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public ServerManager get_ServerManager() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	private void set_ServerManager(ServerManager value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public ClientManager get_ClientManager() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	private void set_ClientManager(ClientManager value) { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public TransportManager get_TransportManager() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	private void set_TransportManager(TransportManager value) { }

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public TimeManager get_TimeManager() { }

	[CompilerGenerated]
	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	private void set_TimeManager(TimeManager value) { }

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public SceneManager get_SceneManager() { }

	[CompilerGenerated]
	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	private void set_SceneManager(SceneManager value) { }

	[CompilerGenerated]
	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public ObserverManager get_ObserverManager() { }

	[CompilerGenerated]
	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	private void set_ObserverManager(ObserverManager value) { }

	// RVA: 0xD62970 Offset: 0xD61370 VA: 0x180D62970
	public Authenticator get_Authenticator() { }

	[CompilerGenerated]
	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public DebugManager get_DebugManager() { }

	[CompilerGenerated]
	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	private void set_DebugManager(DebugManager value) { }

	[CompilerGenerated]
	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public StatisticsManager get_StatisticsManager() { }

	[CompilerGenerated]
	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	private void set_StatisticsManager(StatisticsManager value) { }

	[CompilerGenerated]
	// RVA: 0xD62990 Offset: 0xD61390 VA: 0x180D62990
	public static NetworkConnection get_EmptyConnection() { }

	[CompilerGenerated]
	// RVA: 0xD62D00 Offset: 0xD61700 VA: 0x180D62D00
	private static void set_EmptyConnection(NetworkConnection value) { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public ObjectPool get_ObjectPool() { }

	// RVA: 0xD600F0 Offset: 0xD5EAF0 VA: 0x180D600F0
	private void Awake() { }

	// RVA: 0xD61F20 Offset: 0xD60920 VA: 0x180D61F20
	private void Start() { }

	// RVA: 0xD61C00 Offset: 0xD60600 VA: 0x180D61C00
	private void OnDestroy() { }

	// RVA: 0xD617E0 Offset: 0xD601E0 VA: 0x180D617E0
	private void InitializeComponents() { }

	// RVA: 0xD62410 Offset: 0xD60E10 VA: 0x180D62410
	internal void UpdateFramerate() { }

	// RVA: 0xD61ED0 Offset: 0xD608D0 VA: 0x180D61ED0
	private void TimeManager_OnLateUpdate() { }

	// RVA: 0xD60840 Offset: 0xD5F240 VA: 0x180D60840
	private bool CanInitialize() { }

	// RVA: 0xD62530 Offset: 0xD60F30 VA: 0x180D62530
	private bool ValidateSpawnablePrefabs(bool print) { }

	// RVA: 0xD61E70 Offset: 0xD60870 VA: 0x180D61E70
	private void SetDontDestroyOnLoad() { }

	// RVA: 0xD61ED0 Offset: 0xD608D0 VA: 0x180D61ED0
	private void SetRunInBackground() { }

	// RVA: -1 Offset: -1
	private T GetOrCreateComponent<T>(T presetValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF15AF0 Offset: 0xF144F0 VA: 0x180F15AF0
	|-NetworkManager.GetOrCreateComponent<object>
	*/

	// RVA: 0xD60D20 Offset: 0xD5F720 VA: 0x180D60D20
	internal void ClearClientsCollection(Dictionary<int, NetworkConnection> clients, int transportIndex = -1) { }

	// RVA: 0xD61400 Offset: 0xD5FE00 VA: 0x180D61400
	public NetworkObject GetPooledInstantiated(NetworkObject prefab, bool asServer) { }

	// RVA: 0xD61500 Offset: 0xD5FF00 VA: 0x180D61500
	public NetworkObject GetPooledInstantiated(NetworkObject prefab, Vector3 position, Quaternion rotation, bool asServer) { }

	[Obsolete("Use GetPooledInstantiated(NetworkObject,bool).")]
	// RVA: 0xD61080 Offset: 0xD5FA80 VA: 0x180D61080
	public NetworkObject GetPooledInstantiated(NetworkObject prefab, ushort collectionId, bool asServer) { }

	// RVA: 0xD610C0 Offset: 0xD5FAC0 VA: 0x180D610C0
	public NetworkObject GetPooledInstantiated(GameObject prefab, bool asServer) { }

	[Obsolete("Use GetPooledInstantiated(GameObject, bool).")]
	// RVA: 0xD61590 Offset: 0xD5FF90 VA: 0x180D61590
	public NetworkObject GetPooledInstantiated(GameObject prefab, ushort collectionId, bool asServer) { }

	// RVA: 0xD611D0 Offset: 0xD5FBD0 VA: 0x180D611D0
	public NetworkObject GetPooledInstantiated(GameObject prefab, Vector3 position, Quaternion rotation, bool asServer) { }

	[Obsolete("Use GetPooledInstantiated(int, ushort, bool).")]
	// RVA: 0xD61320 Offset: 0xD5FD20 VA: 0x180D61320
	public NetworkObject GetPooledInstantiated(int prefabId, bool asServer) { }

	// RVA: 0xD61360 Offset: 0xD5FD60 VA: 0x180D61360
	public NetworkObject GetPooledInstantiated(int prefabId, ushort collectionId, bool asServer) { }

	// RVA: 0xD61390 Offset: 0xD5FD90 VA: 0x180D61390
	public NetworkObject GetPooledInstantiated(int prefabId, ushort collectionId, Vector3 position, Quaternion rotation, bool asServer) { }

	[Obsolete("Use StorePooledInstantiated(NetworkObject, bool)")]
	// RVA: 0xD620D0 Offset: 0xD60AD0 VA: 0x180D620D0
	public void StorePooledInstantiated(NetworkObject instantiated, int prefabId, bool asServer) { }

	// RVA: 0xD62270 Offset: 0xD60C70 VA: 0x180D62270
	public void StorePooledInstantiated(NetworkObject instantiated, bool asServer) { }

	// RVA: 0xD60810 Offset: 0xD5F210 VA: 0x180D60810
	public void CacheObjects(NetworkObject prefab, int count, bool asServer) { }

	// RVA: 0xD619F0 Offset: 0xD603F0 VA: 0x180D619F0
	private void InitializeLogging() { }

	[APIExclude]
	// RVA: 0xD61F40 Offset: 0xD60940 VA: 0x180D61F40
	public static bool StaticCanLog(LoggingType loggingType) { }

	// RVA: 0xD60CF0 Offset: 0xD5F6F0 VA: 0x180D60CF0
	public bool CanLog(LoggingType loggingType) { }

	[APIExclude]
	// RVA: 0xD62080 Offset: 0xD60A80 VA: 0x180D62080
	public static void StaticLog(string value) { }

	// RVA: 0xD61BD0 Offset: 0xD605D0 VA: 0x180D61BD0
	public void Log(string value) { }

	// RVA: 0xD61B30 Offset: 0xD60530 VA: 0x180D61B30
	public void Log(LoggingType loggingType, string value) { }

	[APIExclude]
	// RVA: 0xD62030 Offset: 0xD60A30 VA: 0x180D62030
	public static void StaticLogWarning(string value) { }

	// RVA: 0xD61B00 Offset: 0xD60500 VA: 0x180D61B00
	public void LogWarning(string value) { }

	[APIExclude]
	// RVA: 0xD61FE0 Offset: 0xD609E0 VA: 0x180D61FE0
	public static void StaticLogError(string value) { }

	// RVA: 0xD61AD0 Offset: 0xD604D0 VA: 0x180D61AD0
	public void LogError(string value) { }

	[CompilerGenerated]
	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	public RollbackManager get_RollbackManager() { }

	[CompilerGenerated]
	// RVA: 0x614510 Offset: 0x612F10 VA: 0x180614510
	private void set_RollbackManager(RollbackManager value) { }

	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	public PrefabObjects get_SpawnablePrefabs() { }

	// RVA: 0xAA72B0 Offset: 0xAA5CB0 VA: 0x180AA72B0
	public void set_SpawnablePrefabs(PrefabObjects value) { }

	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190
	public IReadOnlyDictionary<ushort, PrefabObjects> get_RuntimeSpawnablePrefabs() { }

	// RVA: -1 Offset: -1
	public PrefabObjects GetPrefabObjects<T>(ushort spawnableCollectionId, bool createIfMissing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF15BF0 Offset: 0xF145F0 VA: 0x180F15BF0
	|-NetworkManager.GetPrefabObjects<object>
	*/

	// RVA: 0xD61E10 Offset: 0xD60810 VA: 0x180D61E10
	public bool RemoveSpawnableCollection(ushort spawnableCollectionId) { }

	// RVA: 0xD616A0 Offset: 0xD600A0 VA: 0x180D616A0
	public int GetPrefabIndex(GameObject prefab, bool asServer) { }

	// RVA: 0xD617A0 Offset: 0xD601A0 VA: 0x180D617A0
	public NetworkObject GetPrefab(int prefabId, bool asServer) { }

	// RVA: -1 Offset: -1
	public void RegisterInvokeOnInstance<T>(Action<Component> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF15F50 Offset: 0xF14950 VA: 0x180F15F50
	|-NetworkManager.RegisterInvokeOnInstance<object>
	*/

	// RVA: -1 Offset: -1
	public void UnregisterInvokeOnInstance<T>(Action<Component> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF16370 Offset: 0xF14D70 VA: 0x180F16370
	|-NetworkManager.UnregisterInvokeOnInstance<object>
	*/

	// RVA: -1 Offset: -1
	public bool HasInstance<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF15D10 Offset: 0xF14710 VA: 0x180F15D10
	|-NetworkManager.HasInstance<object>
	*/

	// RVA: -1 Offset: -1
	public T GetInstance<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF15A30 Offset: 0xF14430 VA: 0x180F15A30
	|-NetworkManager.GetInstance<object>
	*/

	[Obsolete("Use GetInstance() or TryGetInstance(T).")]
	// RVA: -1 Offset: -1
	public T GetInstance<T>(bool warn = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF15970 Offset: 0xF14370 VA: 0x180F15970
	|-NetworkManager.GetInstance<object>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetInstance<T>(out T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF16110 Offset: 0xF14B10 VA: 0x180F16110
	|-NetworkManager.TryGetInstance<object>
	*/

	// RVA: -1 Offset: -1
	public void RegisterInstance<T>(T component, bool replace = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF15D60 Offset: 0xF14760 VA: 0x180F15D60
	|-NetworkManager.RegisterInstance<object>
	*/

	// RVA: -1 Offset: -1
	public bool TryRegisterInstance<T>(T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF16250 Offset: 0xF14C50 VA: 0x180F16250
	|-NetworkManager.TryRegisterInstance<object>
	*/

	// RVA: -1 Offset: -1
	public void UnregisterInstance<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF16300 Offset: 0xF14D00 VA: 0x180F16300
	|-NetworkManager.UnregisterInstance<object>
	*/

	// RVA: 0xD61C80 Offset: 0xD60680 VA: 0x180D61C80
	private void RemoveNullPendingDelegates() { }

	// RVA: -1 Offset: -1
	private string GetInstanceName<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF158F0 Offset: 0xF142F0 VA: 0x180F158F0
	|-NetworkManager.GetInstanceName<object>
	|-NetworkManager.GetInstanceName<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0xD62850 Offset: 0xD61250 VA: 0x180D62850
	public void .ctor() { }

	// RVA: 0xD62760 Offset: 0xD61160 VA: 0x180D62760
	private static void .cctor() { }
}
