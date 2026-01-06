internal class CachedNetworkObject : IResettable // TypeDefIndex: 12813
{
	// Fields
	public ushort CollectionId; // 0x10
	public int ObjectId; // 0x14
	public sbyte InitializeOrder; // 0x18
	public int OwnerId; // 0x1C
	public SpawnType SpawnType; // 0x20
	public DespawnType DespawnType; // 0x21
	public byte ComponentIndex; // 0x22
	public int RootObjectId; // 0x24
	public Nullable<int> ParentObjectId; // 0x28
	public Nullable<byte> ParentComponentIndex; // 0x30
	public Nullable<int> PrefabId; // 0x34
	public Nullable<Vector3> LocalPosition; // 0x3C
	public Nullable<Quaternion> LocalRotation; // 0x4C
	public Nullable<Vector3> LocalScale; // 0x60
	public ulong SceneId; // 0x70
	public ArraySegment<byte> RpcLinks; // 0x78
	public ArraySegment<byte> SyncValues; // 0x88
	[CompilerGenerated]
	private CachedNetworkObject.ActionType <Action>k__BackingField; // 0x98
	public NetworkObject NetworkObject; // 0xA0
	[CompilerGenerated]
	private PooledReader <RpcLinkReader>k__BackingField; // 0xA8
	[CompilerGenerated]
	private PooledReader <SyncValuesReader>k__BackingField; // 0xB0

	// Properties
	public bool IsNested { get; }
	public bool IsSceneObject { get; }
	public bool HasParent { get; }
	public bool ParentIsNetworkBehaviour { get; }
	public CachedNetworkObject.ActionType Action { get; set; }
	public PooledReader RpcLinkReader { get; set; }
	public PooledReader SyncValuesReader { get; set; }

	// Methods

	// RVA: 0xD90F00 Offset: 0xD8F900 VA: 0x180D90F00
	public bool get_IsNested() { }

	// RVA: 0xD90F10 Offset: 0xD8F910 VA: 0x180D90F10
	public bool get_IsSceneObject() { }

	// RVA: 0xD90EC0 Offset: 0xD8F8C0 VA: 0x180D90EC0
	public bool get_HasParent() { }

	// RVA: 0xD90F20 Offset: 0xD8F920 VA: 0x180D90F20
	public bool get_ParentIsNetworkBehaviour() { }

	[CompilerGenerated]
	// RVA: 0x4B62D0 Offset: 0x4B4CD0 VA: 0x1804B62D0
	public CachedNetworkObject.ActionType get_Action() { }

	[CompilerGenerated]
	// RVA: 0x4B7090 Offset: 0x4B5A90 VA: 0x1804B7090
	private void set_Action(CachedNetworkObject.ActionType value) { }

	[CompilerGenerated]
	// RVA: 0x4B61A0 Offset: 0x4B4BA0 VA: 0x1804B61A0
	public PooledReader get_RpcLinkReader() { }

	[CompilerGenerated]
	// RVA: 0x4B6D20 Offset: 0x4B5720 VA: 0x1804B6D20
	private void set_RpcLinkReader(PooledReader value) { }

	[CompilerGenerated]
	// RVA: 0x4B6150 Offset: 0x4B4B50 VA: 0x1804B6150
	public PooledReader get_SyncValuesReader() { }

	[CompilerGenerated]
	// RVA: 0x4B6C80 Offset: 0x4B5680 VA: 0x1804B6C80
	private void set_SyncValuesReader(PooledReader value) { }

	// RVA: 0xD90C30 Offset: 0xD8F630 VA: 0x180D90C30
	public void InitializeSpawn(NetworkManager manager, ushort collectionId, int objectId, sbyte initializeOrder, int ownerId, SpawnType objectSpawnType, byte componentIndex, int rootObjectId, Nullable<int> parentObjectId, Nullable<byte> parentComponentIndex, Nullable<int> prefabId, Nullable<Vector3> localPosition, Nullable<Quaternion> localRotation, Nullable<Vector3> localScale, ulong sceneId, string sceneName, string objectName, ArraySegment<byte> rpcLinks, ArraySegment<byte> syncValues) { }

	// RVA: 0xD90BF0 Offset: 0xD8F5F0 VA: 0x180D90BF0
	public void InitializeDespawn(int objectId, DespawnType despawnType) { }

	// RVA: 0xD90DE0 Offset: 0xD8F7E0 VA: 0x180D90DE0 Slot: 4
	public void ResetState() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public void InitializeState() { }

	// RVA: 0xD90B80 Offset: 0xD8F580 VA: 0x180D90B80 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
