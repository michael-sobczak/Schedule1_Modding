public class DefaultObjectPool : ObjectPool // TypeDefIndex: 12487
{
	// Fields
	private List<Dictionary<int, Stack<NetworkObject>>> _cache; // 0x28
	[Tooltip("True if to use object pooling.")]
	[SerializeField]
	private bool _enabled; // 0x30
	private Dictionary<int, Transform> _objectParents; // 0x38
	private const string OBJECTS_PARENT_NAME = "DefaultObjectPool Parent";

	// Properties
	public IReadOnlyCollection<Dictionary<int, Stack<NetworkObject>>> Cache { get; }

	// Methods

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public IReadOnlyCollection<Dictionary<int, Stack<NetworkObject>>> get_Cache() { }

	// RVA: 0xD0D960 Offset: 0xD0C360 VA: 0x180D0D960 Slot: 5
	public override NetworkObject RetrieveObject(int prefabId, bool asServer) { }

	// RVA: 0xD0D4B0 Offset: 0xD0BEB0 VA: 0x180D0D4B0 Slot: 7
	public override NetworkObject RetrieveObject(int prefabId, ushort collectionId, Vector3 position, Quaternion rotation, bool asServer) { }

	// RVA: 0xD0D770 Offset: 0xD0C170 VA: 0x180D0D770 Slot: 6
	public override NetworkObject RetrieveObject(int prefabId, ushort collectionId, bool asServer) { }

	// RVA: 0xD0D990 Offset: 0xD0C390 VA: 0x180D0D990 Slot: 8
	public override void StoreObject(NetworkObject instantiated, bool asServer) { }

	// RVA: 0xD0C210 Offset: 0xD0AC10 VA: 0x180D0C210 Slot: 9
	public override void CacheObjects(NetworkObject prefab, int count, bool asServer) { }

	// RVA: 0xD0C630 Offset: 0xD0B030 VA: 0x180D0C630
	public void ClearPool() { }

	// RVA: 0xD0C3E0 Offset: 0xD0ADE0 VA: 0x180D0C3E0
	public void ClearPool(int collectionId) { }

	// RVA: 0xD0C6A0 Offset: 0xD0B0A0 VA: 0x180D0C6A0
	private Transform GetObjectStoreParent(NetworkObject nob) { }

	// RVA: 0xD0CAC0 Offset: 0xD0B4C0 VA: 0x180D0CAC0
	internal void ObjectsDestroyed(DefaultObjectPoolContainer container) { }

	// RVA: 0xD0C8C0 Offset: 0xD0B2C0 VA: 0x180D0C8C0
	private Stack<NetworkObject> GetOrCreateCache(int collectionId, int prefabId) { }

	// RVA: 0xD0DAC0 Offset: 0xD0C4C0 VA: 0x180D0DAC0
	public void .ctor() { }
}
