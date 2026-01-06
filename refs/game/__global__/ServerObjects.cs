public class ServerObjects : ManagedObjects // TypeDefIndex: 12748
{
	// Fields
	[CompilerGenerated]
	private Action<NetworkConnection> OnPreDestroyClientObjects; // 0x30
	internal Dictionary<int, uint> RecentlyDespawnedIds; // 0x38
	private Queue<int> _objectIdCache; // 0x40
	private List<NetworkBehaviour> _dirtySyncVarBehaviours; // 0x48
	private List<NetworkBehaviour> _dirtySyncObjectBehaviours; // 0x50
	private Dictionary<int, NetworkObject> _pendingDestroy; // 0x58
	private List<ValueTuple<int, Scene>> _loadedScenes; // 0x60
	private List<NetworkObject> _spawnCache; // 0x68
	private bool _scenesLoading; // 0x70
	private List<NetworkObject> _observerChangedObjectsCache; // 0x78
	private List<NetworkObject> _timedNetworkObservers; // 0x80
	private int _nextTimedObserversIndex; // 0x88
	private PooledWriter _writer; // 0x90

	// Properties
	private uint _cleanRecentlyDespawnedMaxTicks { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xD70120 Offset: 0xD6EB20 VA: 0x180D70120
	public void add_OnPreDestroyClientObjects(Action<NetworkConnection> value) { }

	[CompilerGenerated]
	// RVA: 0xD70260 Offset: 0xD6EC60 VA: 0x180D70260
	public void remove_OnPreDestroyClientObjects(Action<NetworkConnection> value) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	internal Queue<int> GetObjectIdCache() { }

	// RVA: 0xD701D0 Offset: 0xD6EBD0 VA: 0x180D701D0
	private uint get__cleanRecentlyDespawnedMaxTicks() { }

	// RVA: 0xD6FD30 Offset: 0xD6E730 VA: 0x180D6FD30
	internal void .ctor(NetworkManager networkManager) { }

	// RVA: 0xD6F110 Offset: 0xD6DB10 VA: 0x180D6F110
	private void TimeManager_OnUpdate() { }

	// RVA: 0xD6FD00 Offset: 0xD6E700 VA: 0x180D6FD00
	internal void WriteDirtySyncTypes() { }

	// RVA: 0xD6DCD0 Offset: 0xD6C6D0 VA: 0x180D6DCD0
	internal void SetDirtySyncType(NetworkBehaviour nb, bool isSyncObject) { }

	// RVA: 0xD6AAF0 Offset: 0xD694F0 VA: 0x180D6AAF0
	internal void OnServerConnectionState(ServerConnectionStateArgs args) { }

	// RVA: 0xD69E10 Offset: 0xD68810 VA: 0x180D69E10
	internal void ClientDisconnected(NetworkConnection connection) { }

	// RVA: 0xD697E0 Offset: 0xD681E0 VA: 0x180D697E0
	private void BuildObjectIdCache() { }

	// RVA: 0xD69A10 Offset: 0xD68410 VA: 0x180D69A10
	private void CacheObjectId(NetworkObject nob) { }

	// RVA: 0xD699B0 Offset: 0xD683B0 VA: 0x180D699B0
	internal void CacheObjectId(int id) { }

	// RVA: 0xD6A880 Offset: 0xD69280 VA: 0x180D6A880 Slot: 4
	protected internal override int GetNextNetworkObjectId(bool errorCheck = True) { }

	// RVA: 0xD6DBA0 Offset: 0xD6C5A0 VA: 0x180D6DBA0
	private void SceneManager_OnLoadStart(SceneLoadStartEventArgs obj) { }

	// RVA: 0xD6DB90 Offset: 0xD6C590 VA: 0x180D6DB90
	private void SceneManager_OnActiveSceneSet() { }

	// RVA: 0xD6A960 Offset: 0xD69360 VA: 0x180D6A960
	internal void IterateLoadedScenes(bool ignoreFrameRestriction) { }

	// RVA: 0xD6DBB0 Offset: 0xD6C5B0 VA: 0x180D6DBB0 Slot: 6
	protected internal override void SceneManager_sceneLoaded(Scene s, LoadSceneMode arg1) { }

	// RVA: 0xD6DD40 Offset: 0xD6C740 VA: 0x180D6DD40
	protected internal void SetupSceneObjects() { }

	// RVA: 0xD6DE20 Offset: 0xD6C820 VA: 0x180D6DE20
	private void SetupSceneObjects(Scene s) { }

	// RVA: 0xD6E290 Offset: 0xD6CC90 VA: 0x180D6E290
	private void SetupWithoutSynchronization(NetworkObject nob, NetworkConnection ownerConnection, Nullable<int> objectId) { }

	// RVA: 0xD6EA10 Offset: 0xD6D410 VA: 0x180D6EA10
	internal void Spawn(NetworkObject networkObject, NetworkConnection ownerConnection, Scene scene) { }

	// RVA: 0xD6E3E0 Offset: 0xD6CDE0 VA: 0x180D6E3E0
	private void SpawnWithoutChecks(NetworkObject networkObject, NetworkConnection ownerConnection, Nullable<int> objectId) { }

	// RVA: 0xD6B1C0 Offset: 0xD69BC0 VA: 0x180D6B1C0
	internal void ReadPredictedSpawn(PooledReader reader, NetworkConnection conn) { }

	// RVA: 0xD69A80 Offset: 0xD68480 VA: 0x180D69A80
	private void CleanRecentlyDespawned() { }

	// RVA: 0xD6D2D0 Offset: 0xD6BCD0 VA: 0x180D6D2D0
	public bool RecentlyDespawned(int objectId, uint ticks) { }

	// RVA: 0xD69780 Offset: 0xD68180 VA: 0x180D69780
	internal void AddToPending(NetworkObject nob) { }

	// RVA: 0xD6D5A0 Offset: 0xD6BFA0 VA: 0x180D6D5A0
	internal bool RemoveFromPending(int objectId) { }

	// RVA: 0xD6A810 Offset: 0xD69210 VA: 0x180D6A810
	internal NetworkObject GetFromPending(int objectId) { }

	// RVA: 0xD6A480 Offset: 0xD68E80 VA: 0x180D6A480
	internal void DestroyPending() { }

	// RVA: 0xD6A0F0 Offset: 0xD68AF0 VA: 0x180D6A0F0 Slot: 9
	internal override void Despawn(NetworkObject networkObject, DespawnType despawnType, bool asServer) { }

	// RVA: 0xD6AA90 Offset: 0xD69490 VA: 0x180D6AA90 Slot: 7
	internal override void NetworkObjectUnexpectedlyDestroyed(NetworkObject nob, bool asServer) { }

	// RVA: 0xD6A650 Offset: 0xD69050 VA: 0x180D6A650
	private void FinalizeDespawn(NetworkObject nob, DespawnType despawnType) { }

	// RVA: 0xD6F910 Offset: 0xD6E310 VA: 0x180D6F910
	private void WriteDespawnAndSend(NetworkObject nob, DespawnType despawnType) { }

	// RVA: 0xD6B030 Offset: 0xD69A30 VA: 0x180D6B030
	internal void ReadPredictedDespawn(Reader reader, NetworkConnection conn) { }

	// RVA: 0xD6AAE0 Offset: 0xD694E0 VA: 0x180D6AAE0
	private void Observers_OnUpdate() { }

	// RVA: 0xD6F5C0 Offset: 0xD6DFC0 VA: 0x180D6F5C0
	private void UpdateTimedObservers() { }

	// RVA: 0xD696D0 Offset: 0xD680D0 VA: 0x180D696D0
	public void AddTimedNetworkObserver(NetworkObject networkObject) { }

	// RVA: 0xD6D600 Offset: 0xD6C000 VA: 0x180D6D600
	public void RemoveTimedNetworkObserver(NetworkObject networkObject) { }

	// RVA: 0xD6D660 Offset: 0xD6C060 VA: 0x180D6D660
	private List<NetworkConnection> RetrieveAuthenticatedConnections() { }

	// RVA: 0xD6D820 Offset: 0xD6C220 VA: 0x180D6D820
	private List<NetworkObject> RetrieveOrderedSpawnedObjects() { }

	// RVA: 0xD6ADE0 Offset: 0xD697E0 VA: 0x180D6ADE0
	private void OrderRootByInitializationOrder(NetworkObject nob, List<NetworkObject> cache, ref bool initializationOrderChanged) { }

	// RVA: 0xD6AD20 Offset: 0xD69720 VA: 0x180D6AD20
	private void OrderNestedByInitializationOrder(List<NetworkObject> cache) { }

	// RVA: 0xD6D380 Offset: 0xD6BD80 VA: 0x180D6D380
	private void RemoveFromObserversWithoutSynchronization(NetworkConnection connection) { }

	// RVA: 0xD6C280 Offset: 0xD6AC80 VA: 0x180D6C280
	public void RebuildObservers(bool timedOnly = False) { }

	// RVA: 0xD6C470 Offset: 0xD6AE70 VA: 0x180D6C470
	public void RebuildObservers(NetworkObject nob, bool timedOnly = False) { }

	// RVA: 0xD6C370 Offset: 0xD6AD70 VA: 0x180D6C370
	public void RebuildObservers(NetworkConnection connection, bool timedOnly = False) { }

	[Obsolete("Use RebuildObservers IList variant instead.")]
	// RVA: 0xD6BAD0 Offset: 0xD6A4D0 VA: 0x180D6BAD0
	public void RebuildObservers(IEnumerable<NetworkObject> nobs, bool timedOnly = False) { }

	[Obsolete("Use RebuildObservers IList variant instead.")]
	// RVA: 0xD6BCE0 Offset: 0xD6A6E0 VA: 0x180D6BCE0
	public void RebuildObservers(IEnumerable<NetworkConnection> connections, bool timedOnly = False) { }

	[Obsolete("Use RebuildObservers IList variant instead.")]
	// RVA: 0xD6C1C0 Offset: 0xD6ABC0 VA: 0x180D6C1C0
	public void RebuildObservers(IEnumerable<NetworkObject> nobs, NetworkConnection conn, bool timedOnly = False) { }

	[Obsolete("Use RebuildObservers IList variant instead.")]
	// RVA: 0xD6BD90 Offset: 0xD6A790 VA: 0x180D6BD90
	public void RebuildObservers(NetworkObject networkObject, IEnumerable<NetworkConnection> connections, bool timedOnly = False) { }

	[Obsolete("Use RebuildObservers IList variant instead.")]
	// RVA: 0xD6C570 Offset: 0xD6AF70 VA: 0x180D6C570
	public void RebuildObservers(IEnumerable<NetworkObject> nobs, IEnumerable<NetworkConnection> conns, bool timedOnly = False) { }

	// RVA: 0xD6BB80 Offset: 0xD6A580 VA: 0x180D6BB80
	public void RebuildObservers(IList<NetworkObject> nobs, bool timedOnly = False) { }

	// RVA: 0xD6BC30 Offset: 0xD6A630 VA: 0x180D6BC30
	public void RebuildObservers(IList<NetworkConnection> connections, bool timedOnly = False) { }

	// RVA: 0xD6D210 Offset: 0xD6BC10 VA: 0x180D6D210
	public void RebuildObservers(IList<NetworkObject> nobs, NetworkConnection conn, bool timedOnly = False) { }

	// RVA: 0xD6CAA0 Offset: 0xD6B4A0 VA: 0x180D6CAA0
	public void RebuildObservers(NetworkObject networkObject, IList<NetworkConnection> connections, bool timedOnly = False) { }

	// RVA: 0xD6CB60 Offset: 0xD6B560 VA: 0x180D6CB60
	public void RebuildObservers(IList<NetworkObject> nobs, IList<NetworkConnection> conns, bool timedOnly = False) { }

	// RVA: 0xD6BE50 Offset: 0xD6A850 VA: 0x180D6BE50
	public void RebuildObservers(NetworkObject nob, NetworkConnection conn, bool timedOnly = False) { }

	// RVA: 0xD6CF10 Offset: 0xD6B910 VA: 0x180D6CF10
	internal void RebuildObservers(NetworkObject nob, NetworkConnection conn, List<NetworkObject> addedNobs, bool timedOnly = False) { }

	// RVA: 0xD6AF10 Offset: 0xD69910 VA: 0x180D6AF10
	internal void ParseServerRpc(PooledReader reader, NetworkConnection conn, Channel channel) { }

	[CompilerGenerated]
	// RVA: 0xD6F500 Offset: 0xD6DF00 VA: 0x180D6F500
	internal static void <WriteDirtySyncTypes>g__IterateCollection|16_0(List<NetworkBehaviour> collection, bool isSyncObject) { }

	[CompilerGenerated]
	// RVA: 0xD6F310 Offset: 0xD6DD10 VA: 0x180D6F310
	private void <ReadPredictedSpawn>g__WriteResponse|33_0(bool success, ref ServerObjects.<>c__DisplayClass33_0 ) { }

	[CompilerGenerated]
	// RVA: 0xD6F1A0 Offset: 0xD6DBA0 VA: 0x180D6F1A0
	internal static void <OrderNestedByInitializationOrder>g__AddChildNetworkObjects|56_0(NetworkObject n, ref int index, ref ServerObjects.<>c__DisplayClass56_0 ) { }
}
