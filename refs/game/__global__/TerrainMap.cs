public class TerrainMap // TypeDefIndex: 19005
{
	// Fields
	private Vector3 m_patchSize; // 0x10
	private TerrainMapStatusCode m_errorCode; // 0x1C
	private Dictionary<TerrainTileCoord, Terrain> m_terrainTiles; // 0x20

	// Properties
	public Dictionary<TerrainTileCoord, Terrain> terrainTiles { get; }

	// Methods

	// RVA: 0x2D45AF0 Offset: 0x2D444F0 VA: 0x182D45AF0
	public Terrain GetTerrain(int tileX, int tileZ) { }

	// RVA: 0x2D457B0 Offset: 0x2D441B0 VA: 0x182D457B0
	public static TerrainMap CreateFromPlacement(Terrain originTerrain, Predicate<Terrain> filter, bool fullValidation = True) { }

	// RVA: 0x2D45420 Offset: 0x2D43E20 VA: 0x182D45420
	public static TerrainMap CreateFromPlacement(Vector2 gridOrigin, Vector2 gridSize, Predicate<Terrain> filter, bool fullValidation = True) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public Dictionary<TerrainTileCoord, Terrain> get_terrainTiles() { }

	// RVA: 0x2D46460 Offset: 0x2D44E60 VA: 0x182D46460
	public void .ctor() { }

	// RVA: 0x2D45240 Offset: 0x2D43C40 VA: 0x182D45240
	private void AddTerrainInternal(int x, int z, Terrain terrain) { }

	// RVA: 0x2D45B70 Offset: 0x2D44570 VA: 0x182D45B70
	private bool TryToAddTerrain(int tileX, int tileZ, Terrain terrain) { }

	// RVA: 0x2D45C80 Offset: 0x2D44680 VA: 0x182D45C80
	private void ValidateTerrain(int tileX, int tileZ) { }

	// RVA: 0x2D46320 Offset: 0x2D44D20 VA: 0x182D46320
	private TerrainMapStatusCode Validate() { }
}
