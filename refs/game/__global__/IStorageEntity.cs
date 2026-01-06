public interface IStorageEntity // TypeDefIndex: 2386
{
	// Properties
	public abstract Transform storedItemContainer { get; }
	public abstract Dictionary<StoredItem, Employee> reservedItems { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Transform get_storedItemContainer();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Dictionary<StoredItem, Employee> get_reservedItems();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract List<StoredItem> GetStoredItems();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract List<StorageGrid> GetStorageGrids();

	// RVA: 0x8719E0 Offset: 0x8703E0 VA: 0x1808719E0 Slot: 4
	public virtual List<StoredItem> GetStoredItemsByID(string ID) { }

	// RVA: 0x871E00 Offset: 0x870800 VA: 0x180871E00 Slot: 5
	public virtual void ReserveItem(StoredItem item, Employee employee) { }

	// RVA: 0x8716A0 Offset: 0x8700A0 VA: 0x1808716A0 Slot: 6
	public virtual void DereserveItem(StoredItem item) { }

	// RVA: 0x871D80 Offset: 0x870780 VA: 0x180871D80 Slot: 7
	public virtual bool IsItemReserved(StoredItem item) { }

	// RVA: 0x872280 Offset: 0x870C80 VA: 0x180872280 Slot: 8
	public virtual Employee WhoIsReserving(StoredItem item) { }

	// RVA: 0x871750 Offset: 0x870150 VA: 0x180871750 Slot: 9
	public virtual List<StoredItem> GetNonReservedItemsByPrefabID(string prefabID, Employee whosAskin) { }

	[IteratorStateMachine(typeof(IStorageEntity.<ClearReserve>d__12))]
	// RVA: 0x871610 Offset: 0x870010 VA: 0x180871610 Slot: 10
	public virtual IEnumerator ClearReserve(StoredItem item) { }

	// RVA: 0x8720C0 Offset: 0x870AC0 VA: 0x1808720C0 Slot: 11
	public virtual bool TryFitItem(int sizeX, int sizeY, out StorageGrid grid, out Coordinate originCoordinate, out float rotation) { }

	// RVA: 0x871B90 Offset: 0x870590 VA: 0x180871B90 Slot: 12
	public virtual int HowManyCanFit(int sizeX, int sizeY, int limit = 2147483647) { }
}
