public class SinglePrefabObjects : PrefabObjects // TypeDefIndex: 12799
{
	// Fields
	[SerializeField]
	[Tooltip("Prefabs which may be spawned.")]
	private List<NetworkObject> _prefabs; // 0x20

	// Properties
	public IReadOnlyList<NetworkObject> Prefabs { get; }

	// Methods

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public IReadOnlyList<NetworkObject> get_Prefabs() { }

	// RVA: 0xD8B370 Offset: 0xD89D70 VA: 0x180D8B370 Slot: 4
	public override void Clear() { }

	// RVA: 0xD8B3D0 Offset: 0xD89DD0 VA: 0x180D8B3D0 Slot: 5
	public override int GetObjectCount() { }

	// RVA: 0xD8B410 Offset: 0xD89E10 VA: 0x180D8B410 Slot: 6
	public override NetworkObject GetObject(bool asServer, int id) { }

	// RVA: 0xD8B740 Offset: 0xD8A140 VA: 0x180D8B740 Slot: 7
	public override void RemoveNull() { }

	// RVA: 0xD8AEB0 Offset: 0xD898B0 VA: 0x180D8AEB0 Slot: 8
	public override void AddObject(NetworkObject networkObject, bool checkForDuplicates = False) { }

	// RVA: 0xD8AFF0 Offset: 0xD899F0 VA: 0x180D8AFF0 Slot: 9
	public override void AddObjects(List<NetworkObject> networkObjects, bool checkForDuplicates = False) { }

	// RVA: 0xD8AF70 Offset: 0xD89970 VA: 0x180D8AF70 Slot: 10
	public override void AddObjects(NetworkObject[] networkObjects, bool checkForDuplicates = False) { }

	// RVA: 0xD8B2F0 Offset: 0xD89CF0 VA: 0x180D8B2F0
	private void AddUniqueNetworkObject(NetworkObject nob) { }

	// RVA: 0xD8B5B0 Offset: 0xD89FB0 VA: 0x180D8B5B0 Slot: 14
	public override void InitializePrefabRange(int startIndex) { }

	// RVA: 0xD8AE40 Offset: 0xD89840 VA: 0x180D8AE40 Slot: 11
	public override void AddObject(DualPrefab dualPrefab, bool checkForDuplicates = False) { }

	// RVA: 0xD8B210 Offset: 0xD89C10 VA: 0x180D8B210 Slot: 12
	public override void AddObjects(List<DualPrefab> dualPrefab, bool checkForDuplicates = False) { }

	// RVA: 0xD8B280 Offset: 0xD89C80 VA: 0x180D8B280 Slot: 13
	public override void AddObjects(DualPrefab[] dualPrefab, bool checkForDuplicates = False) { }

	// RVA: 0xD7B830 Offset: 0xD7A230 VA: 0x180D7B830
	public void .ctor() { }
}
