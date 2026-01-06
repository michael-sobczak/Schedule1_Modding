public abstract class PrefabObjects : ScriptableObject // TypeDefIndex: 12798
{
	// Fields
	[CompilerGenerated]
	private ushort <CollectionId>k__BackingField; // 0x18

	// Properties
	public ushort CollectionId { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xCC6380 Offset: 0xCC4D80 VA: 0x180CC6380
	public ushort get_CollectionId() { }

	[CompilerGenerated]
	// RVA: 0xCC63F0 Offset: 0xCC4DF0 VA: 0x180CC63F0
	private void set_CollectionId(ushort value) { }

	// RVA: 0xCC63F0 Offset: 0xCC4DF0 VA: 0x180CC63F0
	internal void SetCollectionId(ushort id) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Clear();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int GetObjectCount();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract NetworkObject GetObject(bool asServer, int id);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void RemoveNull();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void AddObject(NetworkObject networkObject, bool checkForDuplicates = False);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void AddObjects(List<NetworkObject> networkObjects, bool checkForDuplicates = False);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void AddObjects(NetworkObject[] networkObjects, bool checkForDuplicates = False);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void AddObject(DualPrefab dualPrefab, bool checkForDuplicates = False);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void AddObjects(List<DualPrefab> dualPrefab, bool checkForDuplicates = False);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void AddObjects(DualPrefab[] dualPrefab, bool checkForDuplicates = False);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void InitializePrefabRange(int startIndex);

	// RVA: 0x6CAB30 Offset: 0x6C9530 VA: 0x1806CAB30
	protected void .ctor() { }
}
