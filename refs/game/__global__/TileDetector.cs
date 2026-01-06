public class TileDetector : MonoBehaviour // TypeDefIndex: 666
{
	// Fields
	public float detectionRadius; // 0x20
	public ETileDetectionMode tileDetectionMode; // 0x24
	public List<Tile> intersectedTiles; // 0x28
	public List<Tile> intersectedOutdoorTiles; // 0x30
	public List<Tile> intersectedIndoorTiles; // 0x38
	public List<StorageTile> intersectedStorageTiles; // 0x40
	public List<ProceduralTile> intersectedProceduralTiles; // 0x48

	// Methods

	// RVA: 0xAC9870 Offset: 0xAC8270 VA: 0x180AC9870 Slot: 4
	public virtual void CheckIntersections(bool sort = True) { }

	// RVA: -1 Offset: -1
	public List<T> OrderList<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF61190 Offset: 0xF5FB90 VA: 0x180F61190
	|-TileDetector.OrderList<object>
	*/

	// RVA: 0xACA210 Offset: 0xAC8C10 VA: 0x180ACA210
	public Tile GetClosestTile() { }

	// RVA: 0xAC9F30 Offset: 0xAC8930 VA: 0x180AC9F30
	public ProceduralTile GetClosestProceduralTile() { }

	// RVA: 0xACA4F0 Offset: 0xAC8EF0 VA: 0x180ACA4F0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private float <OrderList>b__8_0<T>(T x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF61230 Offset: 0xF5FC30 VA: 0x180F61230
	|-TileDetector.<OrderList>b__8_0<object>
	*/
}
