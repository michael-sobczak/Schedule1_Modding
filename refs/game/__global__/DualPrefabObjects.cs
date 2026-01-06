public class DualPrefabObjects : PrefabObjects // TypeDefIndex: 12797
{
	// Fields
	[Tooltip("Prefabs which may be spawned.")]
	[SerializeField]
	private List<DualPrefab> _prefabs; // 0x20

	// Properties
	public IReadOnlyCollection<DualPrefab> Prefabs { get; }

	// Methods

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public IReadOnlyCollection<DualPrefab> get_Prefabs() { }

	// RVA: 0xD7BE10 Offset: 0xD7A810 VA: 0x180D7BE10 Slot: 4
	public override void Clear() { }

	// RVA: 0xD7BE70 Offset: 0xD7A870 VA: 0x180D7BE70 Slot: 5
	public override int GetObjectCount() { }

	// RVA: 0xD7BEB0 Offset: 0xD7A8B0 VA: 0x180D7BEB0 Slot: 6
	public override NetworkObject GetObject(bool asServer, int id) { }

	// RVA: 0xD7C340 Offset: 0xD7AD40 VA: 0x180D7C340 Slot: 7
	public override void RemoveNull() { }

	// RVA: 0xD7B8B0 Offset: 0xD7A2B0 VA: 0x180D7B8B0 Slot: 11
	public override void AddObject(DualPrefab dualPrefab, bool checkForDuplicates = False) { }

	// RVA: 0xD7BBC0 Offset: 0xD7A5C0 VA: 0x180D7BBC0 Slot: 12
	public override void AddObjects(List<DualPrefab> dualPrefabs, bool checkForDuplicates = False) { }

	// RVA: 0xD7B9D0 Offset: 0xD7A3D0 VA: 0x180D7B9D0 Slot: 13
	public override void AddObjects(DualPrefab[] dualPrefabs, bool checkForDuplicates = False) { }

	// RVA: 0xD7BC40 Offset: 0xD7A640 VA: 0x180D7BC40
	private void AddUniqueNetworkObjects(DualPrefab dp) { }

	// RVA: 0xD7C0B0 Offset: 0xD7AAB0 VA: 0x180D7C0B0 Slot: 14
	public override void InitializePrefabRange(int startIndex) { }

	// RVA: 0xD7B960 Offset: 0xD7A360 VA: 0x180D7B960 Slot: 8
	public override void AddObject(NetworkObject networkObject, bool checkForDuplicates = False) { }

	// RVA: 0xD7BB50 Offset: 0xD7A550 VA: 0x180D7BB50 Slot: 9
	public override void AddObjects(List<NetworkObject> networkObjects, bool checkForDuplicates = False) { }

	// RVA: 0xD7BAE0 Offset: 0xD7A4E0 VA: 0x180D7BAE0 Slot: 10
	public override void AddObjects(NetworkObject[] networkObjects, bool checkForDuplicates = False) { }

	// RVA: 0xD7C4C0 Offset: 0xD7AEC0 VA: 0x180D7C4C0
	public void .ctor() { }
}
