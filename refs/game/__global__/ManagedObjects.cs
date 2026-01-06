public abstract class ManagedObjects // TypeDefIndex: 12793
{
	// Fields
	public Dictionary<int, NetworkObject> Spawned; // 0x10
	[CompilerGenerated]
	private NetworkManager <NetworkManager>k__BackingField; // 0x18
	protected Dictionary<ulong, NetworkObject> SceneObjects_Internal; // 0x20
	private HashGrid _hashGrid; // 0x28

	// Properties
	protected NetworkManager NetworkManager { get; set; }
	public IReadOnlyDictionary<ulong, NetworkObject> SceneObjects { get; }

	// Methods

	// RVA: 0xD7D9B0 Offset: 0xD7C3B0 VA: 0x180D7D9B0 Slot: 4
	protected internal virtual int GetNextNetworkObjectId(bool errorCheck = True) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	protected NetworkManager get_NetworkManager() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	private void set_NetworkManager(NetworkManager value) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public IReadOnlyDictionary<ulong, NetworkObject> get_SceneObjects() { }

	// RVA: 0xD7DDC0 Offset: 0xD7C7C0 VA: 0x180D7DDC0 Slot: 5
	protected virtual void Initialize(NetworkManager manager) { }

	// RVA: 0xD7E650 Offset: 0xD7D050 VA: 0x180D7E650
	internal void SubscribeToSceneLoaded(bool subscribe) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 6
	protected internal virtual void SceneManager_sceneLoaded(Scene s, LoadSceneMode arg1) { }

	// RVA: 0xD7DE30 Offset: 0xD7C830 VA: 0x180D7DE30 Slot: 7
	internal virtual void NetworkObjectUnexpectedlyDestroyed(NetworkObject nob, bool asServer) { }

	// RVA: 0xD7E390 Offset: 0xD7CD90 VA: 0x180D7E390 Slot: 8
	protected virtual void RemoveFromSpawned(NetworkObject nob, bool unexpectedlyDestroyed, bool asServer) { }

	// RVA: 0xD7D4C0 Offset: 0xD7BEC0 VA: 0x180D7D4C0 Slot: 9
	internal virtual void Despawn(NetworkObject nob, DespawnType despawnType, bool asServer) { }

	// RVA: 0xD7E900 Offset: 0xD7D300 VA: 0x180D7E900
	protected void UpdateNetworkBehavioursForSceneObject(NetworkObject nob, bool asServer) { }

	// RVA: 0xD7DCE0 Offset: 0xD7C6E0 VA: 0x180D7DCE0
	public static void InitializePrefab(NetworkObject prefab, int index, Nullable<ushort> collectionId) { }

	// RVA: 0xD7D190 Offset: 0xD7BB90 VA: 0x180D7D190 Slot: 10
	internal virtual void DespawnWithoutSynchronization(bool asServer) { }

	// RVA: 0xD7D360 Offset: 0xD7BD60 VA: 0x180D7D360 Slot: 11
	internal virtual void DespawnWithoutSynchronization(NetworkObject nob, bool asServer, DespawnType despawnType, bool removeFromSpawned) { }

	// RVA: 0xD7CA60 Offset: 0xD7B460 VA: 0x180D7CA60 Slot: 12
	internal virtual void AddToSpawned(NetworkObject nob, bool asServer) { }

	// RVA: 0xD7CA00 Offset: 0xD7B400 VA: 0x180D7CA00
	protected internal void AddToSceneObjects(NetworkObject nob) { }

	// RVA: 0xD7E330 Offset: 0xD7CD30 VA: 0x180D7E330
	protected internal void RemoveFromSceneObjects(NetworkObject nob) { }

	// RVA: 0xD7E2D0 Offset: 0xD7CCD0 VA: 0x180D7E2D0
	protected internal void RemoveFromSceneObjects(ulong sceneId) { }

	// RVA: 0xD7DAC0 Offset: 0xD7C4C0 VA: 0x180D7DAC0
	protected internal NetworkObject GetSpawnedNetworkObject(int objectId) { }

	// RVA: 0xD7E450 Offset: 0xD7CE50 VA: 0x180D7E450
	protected internal void SkipDataLength(ushort packetId, PooledReader reader, int dataLength, int rpcLinkObjectId = -1) { }

	// RVA: 0xD7DED0 Offset: 0xD7C8D0 VA: 0x180D7DED0
	internal void ParseReplicateRpc(PooledReader reader, NetworkConnection conn, Channel channel) { }

	// RVA: 0xD7DFF0 Offset: 0xD7C9F0 VA: 0x180D7DFF0
	protected void ReadTransformProperties(Reader reader, out Nullable<Vector3> localPosition, out Nullable<Quaternion> localRotation, out Nullable<Vector3> localScale) { }

	// RVA: 0xD7ECF0 Offset: 0xD7D6F0 VA: 0x180D7ECF0
	internal void WriteSpawn_Server(NetworkObject nob, NetworkConnection connection, Writer writer) { }

	// RVA: 0xD7E9B0 Offset: 0xD7D3B0 VA: 0x180D7E9B0
	protected void WriteChangedTransformProperties(NetworkObject nob, bool sceneObject, bool nested, Writer headerWriter) { }

	// RVA: 0xD7EC80 Offset: 0xD7D680 VA: 0x180D7EC80
	protected void WriteDespawn(NetworkObject nob, DespawnType despawnType, Writer everyoneWriter) { }

	// RVA: 0xD7DB80 Offset: 0xD7C580 VA: 0x180D7DB80
	internal void GetTransformProperties(Nullable<Vector3> readPos, Nullable<Quaternion> readRot, Nullable<Vector3> readScale, Transform defaultTransform, out Vector3 pos, out Quaternion rot, out Vector3 scale) { }

	// RVA: 0xD7D9C0 Offset: 0xD7C3C0 VA: 0x180D7D9C0
	internal NetworkObject GetSceneNetworkObject(ulong sceneId) { }

	// RVA: 0xD7CE20 Offset: 0xD7B820 VA: 0x180D7CE20
	protected bool CanPredictedSpawn(NetworkObject nob, NetworkConnection spawner, NetworkConnection owner, bool asServer, Reader reader) { }

	// RVA: 0xD7CAC0 Offset: 0xD7B4C0 VA: 0x180D7CAC0
	protected bool CanPredictedDespawn(NetworkObject nob, NetworkConnection despawner, bool asServer, Reader reader) { }

	// RVA: 0xD7F470 Offset: 0xD7DE70 VA: 0x180D7F470
	protected void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xD7E740 Offset: 0xD7D140 VA: 0x180D7E740
	private bool <WriteSpawn_Server>g__ParentIsSpawned|28_0(NetworkObject pNob, ref ManagedObjects.<>c__DisplayClass28_0 , ref ManagedObjects.<>c__DisplayClass28_1 ) { }
}
