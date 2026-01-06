internal class ClientObjectCache // TypeDefIndex: 12811
{
	// Fields
	internal Dictionary<int, NetworkObject> IteratedSpawningObjects; // 0x10
	internal HashSet<int> ReadSpawningObjects; // 0x18
	private List<CachedNetworkObject> _cachedObjects; // 0x20
	private HashSet<NetworkObject> _iteratedSpawns; // 0x28
	private HashSet<int> _conflictingDespawns; // 0x30
	private ClientObjects _clientObjects; // 0x38
	private NetworkManager _networkManager; // 0x40
	private bool _loggedSameTickWarning; // 0x48
	private bool _initializeOrderChanged; // 0x49

	// Methods

	// RVA: 0xD92810 Offset: 0xD91210 VA: 0x180D92810
	public void .ctor(ClientObjects cobs, NetworkManager networkManager) { }

	// RVA: 0xD91390 Offset: 0xD8FD90 VA: 0x180D91390
	public NetworkObject GetInCached(int objectId, ClientObjectCache.CacheSearchType searchType) { }

	// RVA: 0xD91080 Offset: 0xD8FA80 VA: 0x180D91080
	public void AddSpawn(NetworkManager manager, ushort collectionId, int objectId, sbyte initializeOrder, int ownerId, SpawnType ost, byte componentIndex, int rootObjectId, Nullable<int> parentObjectId, Nullable<byte> parentComponentIndex, Nullable<int> prefabId, Nullable<Vector3> localPosition, Nullable<Quaternion> localRotation, Nullable<Vector3> localScale, ulong sceneId, string sceneName, string objectName, ArraySegment<byte> rpcLinks, ArraySegment<byte> syncValues) { }

	// RVA: 0xD90F80 Offset: 0xD8F980 VA: 0x180D90F80
	public void AddDespawn(int objectId, DespawnType despawnType) { }

	// RVA: 0xD91580 Offset: 0xD8FF80 VA: 0x180D91580
	public void Iterate() { }

	// RVA: 0xD91530 Offset: 0xD8FF30 VA: 0x180D91530
	private void IterateDespawn(CachedNetworkObject cnob) { }

	// RVA: 0xD91460 Offset: 0xD8FE60 VA: 0x180D91460
	internal NetworkObject GetSpawnedObject(int objectId) { }

	// RVA: 0xD91D10 Offset: 0xD90710 VA: 0x180D91D10
	public void Reset() { }

	[CompilerGenerated]
	// RVA: 0xD91ED0 Offset: 0xD908D0 VA: 0x180D91ED0
	private void <Iterate>g__ProcessObject|14_0(CachedNetworkObject cnob, bool spawn, int index, ref ClientObjectCache.<>c__DisplayClass14_0 ) { }
}
