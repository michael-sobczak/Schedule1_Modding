public class StorageGrid : MonoBehaviour // TypeDefIndex: 2399
{
	// Fields
	public static float gridSize; // 0x0
	public List<StorageTile> storageTiles; // 0x20
	[HideInInspector]
	public List<StorageTile> freeTiles; // 0x28
	[HideInInspector]
	public List<CoordinateStorageTilePair> coordinateStorageTilePairs; // 0x30
	protected Dictionary<Coordinate, StorageTile> coordinateToTile; // 0x38

	// Methods

	// RVA: 0x8861F0 Offset: 0x884BF0 VA: 0x1808861F0 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x886B60 Offset: 0x885560 VA: 0x180886B60
	private void ProcessCoordinateTilePairs() { }

	// RVA: 0x886C90 Offset: 0x885690 VA: 0x180886C90
	public void RegisterTile(StorageTile tile) { }

	// RVA: 0x886250 Offset: 0x884C50 VA: 0x180886250
	public void DeregisterTile(StorageTile tile) { }

	// RVA: 0x886840 Offset: 0x885240 VA: 0x180886840
	public bool IsItemPositionValid(StorageTile primaryTile, FootprintTile primaryFootprintTile, StoredItem item) { }

	// RVA: 0x886480 Offset: 0x884E80 VA: 0x180886480
	public Coordinate GetMatchedCoordinate(FootprintTile tileToMatch) { }

	// RVA: 0x886770 Offset: 0x885170 VA: 0x180886770
	public bool IsGridPositionValid(Coordinate gridCoord, FootprintTile tile) { }

	// RVA: 0x8865D0 Offset: 0x884FD0 VA: 0x1808865D0
	public StorageTile GetTile(Coordinate coord) { }

	// RVA: 0x886710 Offset: 0x885110 VA: 0x180886710
	public int GetUserEndCapacity() { }

	// RVA: 0x8863D0 Offset: 0x884DD0 VA: 0x1808863D0
	public int GetActualY() { }

	// RVA: 0x886370 Offset: 0x884D70 VA: 0x180886370
	public int GetActualX() { }

	// RVA: 0x8866D0 Offset: 0x8850D0 VA: 0x1808866D0
	public int GetTotalFootprintSize() { }

	// RVA: 0x886E60 Offset: 0x885860 VA: 0x180886E60
	public bool TryFitItem(int sizeX, int sizeY, List<Coordinate> lockedCoordinates, out Coordinate originCoordinate, out float rotation) { }

	// RVA: 0x8873B0 Offset: 0x885DB0 VA: 0x1808873B0
	public void .ctor() { }

	// RVA: 0x887370 Offset: 0x885D70 VA: 0x180887370
	private static void .cctor() { }
}
