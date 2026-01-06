public class RecastGraph : NavmeshBase, IUpdatableGraph // TypeDefIndex: 13259
{
	// Fields
	[JsonMember]
	public float characterRadius; // 0x130
	[JsonMember]
	public float contourMaxError; // 0x134
	[JsonMember]
	public float cellSize; // 0x138
	[JsonMember]
	public float walkableHeight; // 0x13C
	[JsonMember]
	public float walkableClimb; // 0x140
	[JsonMember]
	public float maxSlope; // 0x144
	[JsonMember]
	public float maxEdgeLength; // 0x148
	[JsonMember]
	public float minRegionSize; // 0x14C
	[JsonMember]
	public int editorTileSize; // 0x150
	[JsonMember]
	public int tileSizeX; // 0x154
	[JsonMember]
	public int tileSizeZ; // 0x158
	[JsonMember]
	public bool useTiles; // 0x15C
	public bool scanEmptyGraph; // 0x15D
	[JsonMember]
	public RecastGraph.RelevantGraphSurfaceMode relevantGraphSurfaceMode; // 0x160
	[JsonMember]
	public bool rasterizeColliders; // 0x164
	[JsonMember]
	public bool rasterizeMeshes; // 0x165
	[JsonMember]
	public bool rasterizeTerrain; // 0x166
	[JsonMember]
	public bool rasterizeTrees; // 0x167
	[JsonMember]
	public float colliderRasterizeDetail; // 0x168
	[JsonMember]
	public LayerMask mask; // 0x16C
	[JsonMember]
	public List<string> tagMask; // 0x170
	[JsonMember]
	public int terrainSampleSize; // 0x178
	[JsonMember]
	public Vector3 rotation; // 0x17C
	[JsonMember]
	public Vector3 forcedBoundsCenter; // 0x188
	private Voxelize globalVox; // 0x198
	public const int BorderVertexMask = 1;
	public const int BorderVertexOffset = 31;
	private List<NavmeshTile> stagingTiles; // 0x1A0

	// Properties
	protected override bool RecalculateNormals { get; }
	public override float TileWorldSizeX { get; }
	public override float TileWorldSizeZ { get; }
	protected override float MaxTileConnectionEdgeDistance { get; }
	[Obsolete("Obsolete since this is not accurate when the graph is rotated (rotation was not supported when this property was created)")]
	public Bounds forcedBounds { get; }
	private float CellHeight { get; }
	private int CharacterRadiusInVoxels { get; }
	private int TileBorderSizeInVoxels { get; }
	private float TileBorderSizeInWorldUnits { get; }

	// Methods

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 40
	protected override bool get_RecalculateNormals() { }

	// RVA: 0xB5A030 Offset: 0xB58A30 VA: 0x180B5A030 Slot: 37
	public override float get_TileWorldSizeX() { }

	// RVA: 0xB5A050 Offset: 0xB58A50 VA: 0x180B5A050 Slot: 38
	public override float get_TileWorldSizeZ() { }

	// RVA: 0x8D20F0 Offset: 0x8D0AF0 VA: 0x1808D20F0 Slot: 39
	protected override float get_MaxTileConnectionEdgeDistance() { }

	// RVA: 0xB5A070 Offset: 0xB58A70 VA: 0x180B5A070
	public Bounds get_forcedBounds() { }

	[Obsolete("Use node.ClosestPointOnNode instead")]
	// RVA: 0xB57900 Offset: 0xB56300 VA: 0x180B57900
	public Vector3 ClosestPointOnNode(TriangleMeshNode node, Vector3 pos) { }

	[Obsolete("Use node.ContainsPoint instead")]
	// RVA: 0xB57B90 Offset: 0xB56590 VA: 0x180B57B90
	public bool ContainsPoint(TriangleMeshNode node, Vector3 pos) { }

	// RVA: 0xB59890 Offset: 0xB58290 VA: 0x180B59890
	public void SnapForceBoundsToScene() { }

	// RVA: 0xB58A30 Offset: 0xB57430 VA: 0x180B58A30 Slot: 45
	private GraphUpdateThreading Pathfinding.IUpdatableGraph.CanUpdateAsync(GraphUpdateObject o) { }

	// RVA: 0xB58A60 Offset: 0xB57460 VA: 0x180B58A60 Slot: 43
	private void Pathfinding.IUpdatableGraph.UpdateAreaInit(GraphUpdateObject o) { }

	// RVA: 0xB58FD0 Offset: 0xB579D0 VA: 0x180B58FD0 Slot: 42
	private void Pathfinding.IUpdatableGraph.UpdateArea(GraphUpdateObject guo) { }

	// RVA: 0xB58D00 Offset: 0xB57700 VA: 0x180B58D00 Slot: 44
	private void Pathfinding.IUpdatableGraph.UpdateAreaPost(GraphUpdateObject guo) { }

	[IteratorStateMachine(typeof(RecastGraph.<ScanInternal>d__46))]
	// RVA: 0xB59810 Offset: 0xB58210 VA: 0x180B59810 Slot: 20
	protected override IEnumerable<Progress> ScanInternal() { }

	// RVA: 0xB57600 Offset: 0xB56000 VA: 0x180B57600 Slot: 41
	public override GraphTransform CalculateTransform() { }

	// RVA: 0xB587F0 Offset: 0xB571F0 VA: 0x180B587F0
	private void InitializeTileInfo() { }

	// RVA: 0xB593F0 Offset: 0xB57DF0 VA: 0x180B593F0
	private List<RasterizationMesh>[] PutMeshesIntoTileBuckets(List<RasterizationMesh> meshes) { }

	[IteratorStateMachine(typeof(RecastGraph.<ScanAllTiles>d__50))]
	// RVA: 0xB59790 Offset: 0xB58190 VA: 0x180B59790
	protected IEnumerable<Progress> ScanAllTiles() { }

	// RVA: 0xB57970 Offset: 0xB56370 VA: 0x180B57970
	private List<RasterizationMesh> CollectMeshes(Bounds bounds) { }

	// RVA: 0xB59EB0 Offset: 0xB588B0 VA: 0x180B59EB0
	private float get_CellHeight() { }

	// RVA: 0xB59ED0 Offset: 0xB588D0 VA: 0x180B59ED0
	private int get_CharacterRadiusInVoxels() { }

	// RVA: 0xB59F40 Offset: 0xB58940 VA: 0x180B59F40
	private int get_TileBorderSizeInVoxels() { }

	// RVA: 0xB59FB0 Offset: 0xB589B0 VA: 0x180B59FB0
	private float get_TileBorderSizeInWorldUnits() { }

	// RVA: 0xB57420 Offset: 0xB55E20 VA: 0x180B57420
	private Bounds CalculateTileBoundsWithBorder(int x, int z) { }

	// RVA: 0xB57000 Offset: 0xB55A00 VA: 0x180B57000
	protected NavmeshTile BuildTileMesh(Voxelize vox, int x, int z, int threadIndex = 0) { }

	// RVA: 0xB57C00 Offset: 0xB56600 VA: 0x180B57C00
	private NavmeshTile CreateTile(Voxelize vox, VoxelMesh mesh, int x, int z, int threadIndex) { }

	// RVA: 0xB58260 Offset: 0xB56C60 VA: 0x180B58260 Slot: 24
	protected override void DeserializeSettingsCompatibility(GraphSerializationContext ctx) { }

	// RVA: 0xB59D10 Offset: 0xB58710 VA: 0x180B59D10
	public void .ctor() { }
}
