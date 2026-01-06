public abstract class NavmeshBase : NavGraph, INavmesh, INavmeshHolder, ITransformedGraph, IRaycastableGraph // TypeDefIndex: 13240
{
	// Fields
	public const int VertexIndexMask = 4095;
	public const int TileIndexMask = 524287;
	public const int TileIndexOffset = 12;
	[JsonMember]
	public Vector3 forcedBoundsSize; // 0xD0
	[JsonMember]
	public bool showMeshOutline; // 0xDC
	[JsonMember]
	public bool showNodeConnections; // 0xDD
	[JsonMember]
	public bool showMeshSurface; // 0xDE
	public int tileXCount; // 0xE0
	public int tileZCount; // 0xE4
	protected NavmeshTile[] tiles; // 0xE8
	[JsonMember]
	public bool nearestSearchOnlyXZ; // 0xF0
	[JsonMember]
	public bool enableNavmeshCutting; // 0xF1
	internal readonly NavmeshUpdates.NavmeshUpdateSettings navmeshUpdateData; // 0xF8
	private bool batchTileUpdate; // 0x100
	private List<int> batchUpdatedTiles; // 0x108
	private List<MeshNode> batchNodesToDestroy; // 0x110
	public GraphTransform transform; // 0x118
	public Action<NavmeshTile[]> OnRecalculatedTiles; // 0x120
	private static readonly NNConstraint NNConstraintDistanceXZ; // 0x0
	private Dictionary<int, int> nodeRecyclingHashBuffer; // 0x128
	private static readonly NNConstraint NNConstraintNoneXZ; // 0x8
	private static readonly byte[] LinecastShapeEdgeLookup; // 0x10

	// Properties
	public abstract float TileWorldSizeX { get; }
	public abstract float TileWorldSizeZ { get; }
	protected abstract float MaxTileConnectionEdgeDistance { get; }
	private GraphTransform Pathfinding.ITransformedGraph.transform { get; }
	protected abstract bool RecalculateNormals { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 37
	public abstract float get_TileWorldSizeX();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract float get_TileWorldSizeZ();

	// RVA: -1 Offset: -1 Slot: 39
	protected abstract float get_MaxTileConnectionEdgeDistance();

	// RVA: 0x5995D0 Offset: 0x597FD0 VA: 0x1805995D0 Slot: 31
	private GraphTransform Pathfinding.ITransformedGraph.get_transform() { }

	// RVA: -1 Offset: -1 Slot: 40
	protected abstract bool get_RecalculateNormals();

	// RVA: -1 Offset: -1 Slot: 41
	public abstract GraphTransform CalculateTransform();

	// RVA: 0xB43460 Offset: 0xB41E60 VA: 0x180B43460
	public NavmeshTile GetTile(int x, int z) { }

	// RVA: 0xB43DE0 Offset: 0xB427E0 VA: 0x180B43DE0 Slot: 27
	public Int3 GetVertex(int index) { }

	// RVA: 0xB43D70 Offset: 0xB42770 VA: 0x180B43D70 Slot: 28
	public Int3 GetVertexInGraphSpace(int index) { }

	// RVA: 0xB43450 Offset: 0xB41E50 VA: 0x180B43450
	public static int GetTileIndex(int index) { }

	// RVA: 0xB43D60 Offset: 0xB42760 VA: 0x180B43D60 Slot: 29
	public int GetVertexArrayIndex(int index) { }

	// RVA: 0xB43360 Offset: 0xB41D60 VA: 0x180B43360 Slot: 30
	public void GetTileCoordinates(int tileIndex, out int x, out int z) { }

	// RVA: 0x4E8CB0 Offset: 0x4E76B0 VA: 0x1804E8CB0
	public NavmeshTile[] GetTiles() { }

	// RVA: 0xB43280 Offset: 0xB41C80 VA: 0x180B43280
	public Bounds GetTileBounds(IntRect rect) { }

	// RVA: 0xB431E0 Offset: 0xB41BE0 VA: 0x180B431E0
	public Bounds GetTileBounds(int x, int z, int width = 1, int depth = 1) { }

	// RVA: 0xB42FC0 Offset: 0xB419C0 VA: 0x180B42FC0
	public Bounds GetTileBoundsInGraphSpace(IntRect rect) { }

	// RVA: 0xB43060 Offset: 0xB41A60 VA: 0x180B43060
	public Bounds GetTileBoundsInGraphSpace(int x, int z, int width = 1, int depth = 1) { }

	// RVA: 0xB43380 Offset: 0xB41D80 VA: 0x180B43380
	public Int2 GetTileCoordinates(Vector3 position) { }

	// RVA: 0xB45200 Offset: 0xB43C00 VA: 0x180B45200 Slot: 18
	protected override void OnDestroy() { }

	// RVA: 0xB46710 Offset: 0xB45110 VA: 0x180B46710 Slot: 15
	public override void RelocateNodes(Matrix4x4 deltaMatrix) { }

	// RVA: 0xB468D0 Offset: 0xB452D0 VA: 0x180B468D0
	public void RelocateNodes(GraphTransform newTransform) { }

	// RVA: 0xB450A0 Offset: 0xB43AA0 VA: 0x180B450A0
	protected NavmeshTile NewEmptyTile(int x, int z) { }

	// RVA: 0xB42EB0 Offset: 0xB418B0 VA: 0x180B42EB0 Slot: 14
	public override void GetNodes(Action<GraphNode> action) { }

	// RVA: 0xB43A20 Offset: 0xB42420 VA: 0x180B43A20
	public IntRect GetTouchingTiles(Bounds bounds, float margin = 0) { }

	// RVA: 0xB434A0 Offset: 0xB41EA0 VA: 0x180B434A0
	public IntRect GetTouchingTilesInGraphSpace(Rect rect) { }

	// RVA: 0xB43700 Offset: 0xB42100 VA: 0x180B43700
	public IntRect GetTouchingTilesRound(Bounds bounds) { }

	// RVA: 0xB3F610 Offset: 0xB3E010 VA: 0x180B3F610
	protected void ConnectTileWithNeighbours(NavmeshTile tile, bool onlyUnflagged = False) { }

	// RVA: 0xB46A20 Offset: 0xB45420 VA: 0x180B46A20
	protected void RemoveConnectionsFromTile(NavmeshTile tile) { }

	// RVA: 0xB46BD0 Offset: 0xB455D0 VA: 0x180B46BD0
	protected void RemoveConnectionsFromTo(NavmeshTile a, NavmeshTile b) { }

	// RVA: 0xB42DC0 Offset: 0xB417C0 VA: 0x180B42DC0 Slot: 16
	public override NNInfoInternal GetNearest(Vector3 position, NNConstraint constraint, GraphNode hint) { }

	// RVA: 0xB428E0 Offset: 0xB412E0 VA: 0x180B428E0 Slot: 17
	public override NNInfoInternal GetNearestForce(Vector3 position, NNConstraint constraint) { }

	// RVA: 0xB459E0 Offset: 0xB443E0 VA: 0x180B459E0
	public GraphNode PointOnNavmesh(Vector3 position, NNConstraint constraint) { }

	// RVA: 0xB427E0 Offset: 0xB411E0 VA: 0x180B427E0
	protected void FillWithEmptyTiles() { }

	// RVA: 0xB40F80 Offset: 0xB3F980 VA: 0x180B40F80
	protected static void CreateNodeConnections(TriangleMeshNode[] nodes) { }

	// RVA: 0xB3F770 Offset: 0xB3E170 VA: 0x180B3F770
	protected void ConnectTiles(NavmeshTile tile1, NavmeshTile tile2) { }

	// RVA: 0xB47D90 Offset: 0xB46790 VA: 0x180B47D90
	public void StartBatchTileUpdate() { }

	// RVA: 0xB421F0 Offset: 0xB40BF0 VA: 0x180B421F0
	private void DestroyNodes(List<MeshNode> nodes) { }

	// RVA: 0xB47E00 Offset: 0xB46800 VA: 0x180B47E00
	private void TryConnect(int tileIdx1, int tileIdx2) { }

	// RVA: 0xB423D0 Offset: 0xB40DD0 VA: 0x180B423D0
	public void EndBatchTileUpdate() { }

	// RVA: 0xB3F460 Offset: 0xB3DE60 VA: 0x180B3F460
	protected void ClearTile(int x, int z) { }

	// RVA: 0xB460A0 Offset: 0xB44AA0 VA: 0x180B460A0
	private void PrepareNodeRecycling(int x, int z, Int3[] verts, int[] tris, TriangleMeshNode[] recycledNodeBuffer) { }

	// RVA: 0xB46D70 Offset: 0xB45770 VA: 0x180B46D70
	public void ReplaceTile(int x, int z, Int3[] verts, int[] tris) { }

	// RVA: 0xB414D0 Offset: 0xB3FED0 VA: 0x180B414D0
	protected void CreateNodes(TriangleMeshNode[] buffer, int[] tris, int tileIndex, uint graphIndex) { }

	// RVA: 0xB48220 Offset: 0xB46C20 VA: 0x180B48220
	public void .ctor() { }

	// RVA: 0xB44EF0 Offset: 0xB438F0 VA: 0x180B44EF0 Slot: 32
	public bool Linecast(Vector3 origin, Vector3 end) { }

	// RVA: 0xB44000 Offset: 0xB42A00 VA: 0x180B44000 Slot: 34
	public bool Linecast(Vector3 origin, Vector3 end, GraphNode hint, out GraphHitInfo hit) { }

	// RVA: 0xB43E50 Offset: 0xB42850 VA: 0x180B43E50 Slot: 33
	public bool Linecast(Vector3 origin, Vector3 end, GraphNode hint) { }

	// RVA: 0xB44FD0 Offset: 0xB439D0 VA: 0x180B44FD0 Slot: 35
	public bool Linecast(Vector3 origin, Vector3 end, GraphNode hint, out GraphHitInfo hit, List<GraphNode> trace) { }

	// RVA: 0xB43F30 Offset: 0xB42930 VA: 0x180B43F30 Slot: 36
	public bool Linecast(Vector3 origin, Vector3 end, out GraphHitInfo hit, List<GraphNode> trace, Func<GraphNode, bool> filter) { }

	// RVA: 0xB440C0 Offset: 0xB42AC0 VA: 0x180B440C0
	public static bool Linecast(NavmeshBase graph, Vector3 origin, Vector3 end, GraphNode hint, out GraphHitInfo hit) { }

	// RVA: 0xB47E90 Offset: 0xB46890 VA: 0x180B47E90
	private static void .cctor() { }

	// RVA: 0xB44180 Offset: 0xB42B80 VA: 0x180B44180
	public static bool Linecast(NavmeshBase graph, Vector3 origin, Vector3 end, GraphNode hint, out GraphHitInfo hit, List<GraphNode> trace, Func<GraphNode, bool> filter) { }

	// RVA: 0xB45310 Offset: 0xB43D10 VA: 0x180B45310 Slot: 25
	public override void OnDrawGizmos(RetainedGizmos gizmos, bool drawNodes) { }

	// RVA: 0xB40A90 Offset: 0xB3F490 VA: 0x180B40A90
	private void CreateNavmeshSurfaceVisualization(NavmeshTile[] tiles, int startTile, int endTile, GraphGizmoHelper helper) { }

	// RVA: 0xB405A0 Offset: 0xB3EFA0 VA: 0x180B405A0
	private static void CreateNavmeshOutlineVisualization(NavmeshTile[] tiles, int startTile, int endTile, GraphGizmoHelper helper) { }

	// RVA: 0xB479E0 Offset: 0xB463E0 VA: 0x180B479E0 Slot: 21
	protected override void SerializeExtraInfo(GraphSerializationContext ctx) { }

	// RVA: 0xB41890 Offset: 0xB40290 VA: 0x180B41890 Slot: 22
	protected override void DeserializeExtraInfo(GraphSerializationContext ctx) { }

	// RVA: 0xB45AE0 Offset: 0xB444E0 VA: 0x180B45AE0 Slot: 23
	protected override void PostDeserialization(GraphSerializationContext ctx) { }
}
