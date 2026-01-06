public class ProceduralTile : MonoBehaviour // TypeDefIndex: 660
{
	// Fields
	[Header("Settings")]
	public ProceduralTile.EProceduralTileType TileType; // 0x20
	[Header("References")]
	public BuildableItem ParentBuildableItem; // 0x28
	public FootprintTile MatchedFootprintTile; // 0x30
	[Header("Occupants")]
	public List<ProceduralGridItem> Occupants; // 0x38
	public List<FootprintTile> OccupantTiles; // 0x40

	// Methods

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0xAB9060 Offset: 0xAB7A60 VA: 0x180AB9060
	public void AddOccupant(FootprintTile footprint, ProceduralGridItem item) { }

	// RVA: 0xAB9190 Offset: 0xAB7B90 VA: 0x180AB9190
	public void RemoveOccupant(FootprintTile footprint, ProceduralGridItem item) { }

	// RVA: 0xAB9270 Offset: 0xAB7C70 VA: 0x180AB9270
	public void .ctor() { }
}
