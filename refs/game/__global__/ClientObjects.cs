public class ClientObjects : ManagedObjects // TypeDefIndex: 12808
{
	// Fields
	internal List<NetworkObject> LocalClientSpawned; // 0x30
	private ClientObjectCache _objectCache; // 0x38
	private Dictionary<ushort, RpcLink> _rpcLinks; // 0x40

	// Methods

	// RVA: 0xD7AEF0 Offset: 0xD798F0 VA: 0x180D7AEF0
	internal void .ctor(NetworkManager networkManager) { }

	// RVA: 0xD795C0 Offset: 0xD77FC0 VA: 0x180D795C0
	internal void OnServerConnectionState(ServerConnectionStateArgs args) { }

	// RVA: 0xD79390 Offset: 0xD77D90 VA: 0x180D79390
	internal void OnClientConnectionState(ClientConnectionStateArgs args) { }

	[APIExclude]
	// RVA: 0xD7AAD0 Offset: 0xD794D0 VA: 0x180D7AAD0 Slot: 6
	protected internal override void SceneManager_sceneLoaded(Scene s, LoadSceneMode arg1) { }

	// RVA: 0xD77D00 Offset: 0xD76700 VA: 0x180D77D00 Slot: 12
	internal override void AddToSpawned(NetworkObject nob, bool asServer) { }

	// RVA: 0xD7A930 Offset: 0xD79330 VA: 0x180D7A930 Slot: 8
	protected override void RemoveFromSpawned(NetworkObject nob, bool unexpectedlyDestroyed, bool asServer) { }

	// RVA: 0xD7A040 Offset: 0xD78A40 VA: 0x180D7A040
	internal void PredictedSpawn(NetworkObject networkObject, NetworkConnection ownerConnection) { }

	// RVA: 0xD7ABE0 Offset: 0xD795E0 VA: 0x180D7ABE0
	public void WriteSpawn(NetworkObject nob, Writer writer) { }

	// RVA: 0xD79F10 Offset: 0xD78910 VA: 0x180D79F10
	internal void PredictedDespawn(NetworkObject networkObject) { }

	// RVA: 0xD7AB90 Offset: 0xD79590 VA: 0x180D7AB90
	public void WriteDepawn(NetworkObject nob, Writer writer) { }

	// RVA: 0xD7A6E0 Offset: 0xD790E0 VA: 0x180D7A6E0
	internal void RegisterAndDespawnSceneObjects() { }

	// RVA: 0xD7A510 Offset: 0xD78F10 VA: 0x180D7A510
	private void RegisterAndDespawnSceneObjects(Scene s) { }

	// RVA: 0xD792E0 Offset: 0xD77CE0 VA: 0x180D792E0 Slot: 7
	internal override void NetworkObjectUnexpectedlyDestroyed(NetworkObject nob, bool asServer) { }

	// RVA: 0xD79770 Offset: 0xD78170 VA: 0x180D79770
	internal void ParseOwnershipChange(PooledReader reader) { }

	// RVA: 0xD79CB0 Offset: 0xD786B0 VA: 0x180D79CB0
	internal void ParseSyncType(PooledReader reader, bool isSyncObject, Channel channel) { }

	// RVA: 0xD79860 Offset: 0xD78260 VA: 0x180D79860
	internal void ParsePredictedSpawnResult(Reader reader) { }

	// RVA: 0xD79980 Offset: 0xD78380 VA: 0x180D79980
	internal void ParseReconcileRpc(PooledReader reader, Channel channel) { }

	// RVA: 0xD79660 Offset: 0xD78060 VA: 0x180D79660
	internal void ParseObserversRpc(PooledReader reader, Channel channel) { }

	// RVA: 0xD79E00 Offset: 0xD78800 VA: 0x180D79E00
	internal void ParseTargetRpc(PooledReader reader, Channel channel) { }

	// RVA: 0xD78120 Offset: 0xD76B20 VA: 0x180D78120
	internal void CacheSpawn(PooledReader reader) { }

	// RVA: 0xD78090 Offset: 0xD76A90 VA: 0x180D78090
	internal void CacheDespawn(PooledReader reader) { }

	// RVA: 0xD792C0 Offset: 0xD77CC0 VA: 0x180D792C0
	internal void IterateObjectCache() { }

	// RVA: 0xD79000 Offset: 0xD77A00 VA: 0x180D79000
	internal NetworkObject GetNestedNetworkObject(CachedNetworkObject cnob) { }

	// RVA: 0xD77E10 Offset: 0xD76810 VA: 0x180D77E10
	internal void ApplyRpcLinks(NetworkObject nob, Reader reader) { }

	// RVA: 0xD788F0 Offset: 0xD772F0 VA: 0x180D788F0
	internal NetworkObject GetInstantiatedNetworkObject(CachedNetworkObject cnob) { }

	// RVA: 0xD79230 Offset: 0xD77C30 VA: 0x180D79230
	internal NetworkObject GetSpawnedNetworkObject(CachedNetworkObject cnob) { }

	// RVA: 0xD7A2C0 Offset: 0xD78CC0 VA: 0x180D7A2C0
	private void ReadSceneObject(PooledReader reader, out ulong sceneId) { }

	// RVA: 0xD7A2F0 Offset: 0xD78CF0 VA: 0x180D7A2F0
	private void ReadSpawnedObject(PooledReader reader, out Nullable<int> parentObjectId, out Nullable<byte> parentComponentIndex, out Nullable<int> prefabId) { }

	// RVA: 0xD79A90 Offset: 0xD78490 VA: 0x180D79A90
	internal void ParseRpcLink(PooledReader reader, ushort index, Channel channel) { }

	// RVA: 0xD7AB20 Offset: 0xD79520 VA: 0x180D7AB20
	internal void SetRpcLink(ushort linkIndex, RpcLink link) { }

	// RVA: 0xD7AA20 Offset: 0xD79420 VA: 0x180D7AA20
	internal void RemoveLinkIndexes(List<ushort> values) { }
}
