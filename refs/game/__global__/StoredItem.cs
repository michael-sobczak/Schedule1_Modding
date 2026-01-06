public class StoredItem : MonoBehaviour // TypeDefIndex: 2406
{
	// Fields
	[CompilerGenerated]
	private StorableItemInstance <item>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <Destroyed>k__BackingField; // 0x28
	[Header("References")]
	public Transform buildPoint; // 0x30
	public List<CoordinateStorageFootprintTilePair> CoordinateFootprintTilePairs; // 0x38
	private int footprintX; // 0x40
	private int footprintY; // 0x44
	[CompilerGenerated]
	private StorageGrid <parentGrid>k__BackingField; // 0x48
	protected List<CoordinatePair> coordinatePairs; // 0x50
	protected float rotation; // 0x58
	public int xSize; // 0x5C
	public int ySize; // 0x60

	// Properties
	public StorableItemInstance item { get; set; }
	public bool Destroyed { get; set; }
	public FootprintTile OriginFootprint { get; }
	public int FootprintX { get; }
	public int FootprintY { get; }
	public StorageGrid parentGrid { get; set; }
	public List<CoordinatePair> CoordinatePairs { get; }
	public float Rotation { get; }
	public int totalArea { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public StorableItemInstance get_item() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	protected void set_item(StorableItemInstance value) { }

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_Destroyed() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	private void set_Destroyed(bool value) { }

	// RVA: 0x88ACB0 Offset: 0x8896B0 VA: 0x18088ACB0
	public FootprintTile get_OriginFootprint() { }

	// RVA: 0x88A9D0 Offset: 0x8893D0 VA: 0x18088A9D0
	public int get_FootprintX() { }

	// RVA: 0x88AB40 Offset: 0x889540 VA: 0x18088AB40
	public int get_FootprintY() { }

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public StorageGrid get_parentGrid() { }

	[CompilerGenerated]
	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	protected void set_parentGrid(StorageGrid value) { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public List<CoordinatePair> get_CoordinatePairs() { }

	// RVA: 0x4B6210 Offset: 0x4B4C10 VA: 0x1804B6210
	public float get_Rotation() { }

	// RVA: 0x88AD10 Offset: 0x889710 VA: 0x18088AD10
	public int get_totalArea() { }

	// RVA: 0x8895E0 Offset: 0x887FE0 VA: 0x1808895E0 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x889CC0 Offset: 0x8886C0 VA: 0x180889CC0 Slot: 5
	public virtual void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation) { }

	// RVA: 0x88A220 Offset: 0x888C20 VA: 0x18088A220
	private void RefreshTransform() { }

	// RVA: 0x8898C0 Offset: 0x8882C0 VA: 0x1808898C0 Slot: 6
	public virtual void Destroy() { }

	// RVA: 0x889760 Offset: 0x888160 VA: 0x180889760
	public void ClearFootprintOccupancy() { }

	// RVA: 0x88A840 Offset: 0x889240 VA: 0x18088A840
	public void SetFootprintTileVisiblity(bool visible) { }

	// RVA: 0x8896B0 Offset: 0x8880B0 VA: 0x1808896B0
	public void CalculateFootprintTileIntersections() { }

	// RVA: 0x889BC0 Offset: 0x8885C0 VA: 0x180889BC0
	public FootprintTile GetTile(Coordinate coord) { }

	// RVA: 0x88A900 Offset: 0x889300 VA: 0x18088A900
	public void .ctor() { }
}
