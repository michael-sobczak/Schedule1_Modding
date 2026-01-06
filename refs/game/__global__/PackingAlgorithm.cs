public class PackingAlgorithm : Singleton<PackingAlgorithm> // TypeDefIndex: 1925
{
	// Fields
	public List<PackingAlgorithm.Rectangle> rectsToPack; // 0x28

	// Methods

	// RVA: 0x79E510 Offset: 0x79CF10 VA: 0x18079E510
	public List<PackingAlgorithm.StoredItemData> PackItems(List<ItemInstance> datas, int gridX, int gridY) { }

	// RVA: 0x79D300 Offset: 0x79BD00 VA: 0x18079D300
	public List<PackingAlgorithm.StoredItemData> AttemptPack(List<PackingAlgorithm.StoredItemData> rects, int gridX, int gridY) { }

	// RVA: 0x79E1A0 Offset: 0x79CBA0 VA: 0x18079E1A0
	private bool DoesCoordinateHaveOccupiedAdjacent(PackingAlgorithm.Coordinate[,] grid, PackingAlgorithm.Coordinate coord, int gridX, int gridY) { }

	// RVA: 0x79E4D0 Offset: 0x79CED0 VA: 0x18079E4D0
	private bool IsCoordinateInBounds(PackingAlgorithm.Coordinate coord, int gridX, int gridY) { }

	// RVA: 0x79E760 Offset: 0x79D160 VA: 0x18079E760
	private void PrintGrid(PackingAlgorithm.Coordinate[,] grid, int gridX, int gridY) { }

	// RVA: 0x79E410 Offset: 0x79CE10 VA: 0x18079E410
	private int GetRegionSize(PackingAlgorithm.Coordinate[,] grid, int gridX, int gridY) { }

	// RVA: 0x79E910 Offset: 0x79D310 VA: 0x18079E910
	private PackingAlgorithm.Coordinate TransformCoordinatePoint(PackingAlgorithm.Coordinate[,] grid, PackingAlgorithm.Coordinate baseCoordinate, PackingAlgorithm.Coordinate offset, int gridX, int gridY) { }

	// RVA: 0x79EA30 Offset: 0x79D430 VA: 0x18079EA30
	public void .ctor() { }
}
