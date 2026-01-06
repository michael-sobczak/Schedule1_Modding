public class GridGraph : NavGraph, IUpdatableGraph, ITransformedGraph, IRaycastableGraph // TypeDefIndex: 13228
{
	// Fields
	[JsonMember]
	public InspectorGridMode inspectorGridMode; // 0xD0
	[JsonMember]
	public InspectorGridHexagonNodeSize inspectorHexagonSizeMode; // 0xD4
	public int width; // 0xD8
	public int depth; // 0xDC
	[JsonMember]
	public float aspectRatio; // 0xE0
	[JsonMember]
	public float isometricAngle; // 0xE4
	public static readonly float StandardIsometricAngle; // 0x0
	public static readonly float StandardDimetricAngle; // 0x4
	[JsonMember]
	public bool uniformEdgeCosts; // 0xE8
	[JsonMember]
	public Vector3 rotation; // 0xEC
	[JsonMember]
	public Vector3 center; // 0xF8
	[JsonMember]
	public Vector2 unclampedSize; // 0x104
	[JsonMember]
	public float nodeSize; // 0x10C
	[JsonMember]
	public GraphCollision collision; // 0x110
	[JsonMember]
	public float maxClimb; // 0x118
	[JsonMember]
	public float maxSlope; // 0x11C
	[JsonMember]
	public int erodeIterations; // 0x120
	[JsonMember]
	public bool erosionUseTags; // 0x124
	[JsonMember]
	public int erosionFirstTag; // 0x128
	[JsonMember]
	public NumNeighbours neighbours; // 0x12C
	[JsonMember]
	public bool cutCorners; // 0x130
	[JsonMember]
	public float penaltyPositionOffset; // 0x134
	[JsonMember]
	public bool penaltyPosition; // 0x138
	[JsonMember]
	public float penaltyPositionFactor; // 0x13C
	[JsonMember]
	public bool penaltyAngle; // 0x140
	[JsonMember]
	public float penaltyAngleFactor; // 0x144
	[JsonMember]
	public float penaltyAnglePower; // 0x148
	[JsonMember]
	public bool useJumpPointSearch; // 0x14C
	[JsonMember]
	public bool showMeshOutline; // 0x14D
	[JsonMember]
	public bool showNodeConnections; // 0x14E
	[JsonMember]
	public bool showMeshSurface; // 0x14F
	[JsonMember]
	public GridGraph.TextureData textureData; // 0x150
	[CompilerGenerated]
	private Vector2 <size>k__BackingField; // 0x158
	public readonly int[] neighbourOffsets; // 0x160
	public readonly uint[] neighbourCosts; // 0x168
	public readonly int[] neighbourXOffsets; // 0x170
	public readonly int[] neighbourZOffsets; // 0x178
	internal static readonly int[] hexagonNeighbourIndices; // 0x8
	public const int getNearestForceOverlap = 2;
	public GridNodeBase[] nodes; // 0x180
	[CompilerGenerated]
	private GraphTransform <transform>k__BackingField; // 0x188
	private const int FixedPrecisionScale = 1024;

	// Properties
	public virtual bool uniformWidthDepthGrid { get; }
	public virtual int LayerCount { get; }
	protected bool useRaycastNormal { get; }
	public Vector2 size { get; set; }
	public GraphTransform transform { get; set; }
	public bool is2D { get; set; }
	public int Width { get; set; }
	public int Depth { get; set; }

	// Methods

	// RVA: 0xB36D30 Offset: 0xB35730 VA: 0x180B36D30 Slot: 18
	protected override void OnDestroy() { }

	// RVA: 0xB32760 Offset: 0xB31160 VA: 0x180B32760 Slot: 19
	protected override void DestroyAllNodes() { }

	// RVA: 0xB389D0 Offset: 0xB373D0 VA: 0x180B389D0
	private void RemoveGridGraphFromStatic() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 36
	public virtual bool get_uniformWidthDepthGrid() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 37
	public virtual int get_LayerCount() { }

	// RVA: 0xB31470 Offset: 0xB2FE70 VA: 0x180B31470 Slot: 13
	public override int CountNodes() { }

	// RVA: 0xB34A70 Offset: 0xB33470 VA: 0x180B34A70 Slot: 14
	public override void GetNodes(Action<GraphNode> action) { }

	// RVA: 0xB39B60 Offset: 0xB38560 VA: 0x180B39B60
	protected bool get_useRaycastNormal() { }

	[CompilerGenerated]
	// RVA: 0xB39B40 Offset: 0xB38540 VA: 0x180B39B40
	public Vector2 get_size() { }

	[CompilerGenerated]
	// RVA: 0xB39DC0 Offset: 0xB387C0 VA: 0x180B39DC0
	protected void set_size(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x73B380 Offset: 0x739D80 VA: 0x18073B380 Slot: 30
	public GraphTransform get_transform() { }

	[CompilerGenerated]
	// RVA: 0x73B4F0 Offset: 0x739EF0 VA: 0x18073B4F0
	private void set_transform(GraphTransform value) { }

	// RVA: 0xB399E0 Offset: 0xB383E0 VA: 0x180B399E0
	public bool get_is2D() { }

	// RVA: 0xB39BF0 Offset: 0xB385F0 VA: 0x180B39BF0
	public void set_is2D(bool value) { }

	// RVA: 0xB396C0 Offset: 0xB380C0 VA: 0x180B396C0
	public void .ctor() { }

	// RVA: 0xB38980 Offset: 0xB37380 VA: 0x180B38980 Slot: 15
	public override void RelocateNodes(Matrix4x4 deltaMatrix) { }

	// RVA: 0xB387A0 Offset: 0xB371A0 VA: 0x180B387A0
	public void RelocateNodes(Vector3 center, Quaternion rotation, float nodeSize, float aspectRatio = 1, float isometricAngle = 0) { }

	// RVA: 0xB34DF0 Offset: 0xB337F0 VA: 0x180B34DF0
	public Int3 GraphPointToWorld(int x, int z, float height) { }

	// RVA: 0xB31290 Offset: 0xB2FC90 VA: 0x180B31290
	public static float ConvertHexagonSizeToNodeSize(InspectorGridHexagonNodeSize mode, float value) { }

	// RVA: 0xB31380 Offset: 0xB2FD80 VA: 0x180B31380
	public static float ConvertNodeSizeToHexagonSize(InspectorGridHexagonNodeSize mode, float value) { }

	// RVA: 0x516290 Offset: 0x514C90 VA: 0x180516290
	public int get_Width() { }

	// RVA: 0xB39BE0 Offset: 0xB385E0 VA: 0x180B39BE0
	public void set_Width(int value) { }

	// RVA: 0x510B10 Offset: 0x50F510 VA: 0x180510B10
	public int get_Depth() { }

	// RVA: 0xB39BD0 Offset: 0xB385D0 VA: 0x180B39BD0
	public void set_Depth(int value) { }

	// RVA: 0xB33230 Offset: 0xB31C30 VA: 0x180B33230
	public uint GetConnectionCost(int dir) { }

	[Obsolete("Use GridNode.HasConnectionInDirection instead")]
	// RVA: 0xB33E00 Offset: 0xB32800 VA: 0x180B33E00
	public GridNode GetNodeConnection(GridNode node, int dir) { }

	[Obsolete("Use GridNode.HasConnectionInDirection instead")]
	// RVA: 0xB34E90 Offset: 0xB33890 VA: 0x180B34E90
	public bool HasNodeConnection(GridNode node, int dir) { }

	[Obsolete("Use GridNode.SetConnectionInternal instead")]
	// RVA: 0xB38D80 Offset: 0xB37780 VA: 0x180B38D80
	public void SetNodeConnection(GridNode node, int dir, bool value) { }

	[Obsolete("Use GridNode.HasConnectionInDirection instead")]
	// RVA: 0xB34050 Offset: 0xB32A50 VA: 0x180B34050
	private GridNode GetNodeConnection(int index, int x, int z, int dir) { }

	[Obsolete("Use GridNode.SetConnectionInternal instead")]
	// RVA: 0xB38E70 Offset: 0xB37870 VA: 0x180B38E70
	public void SetNodeConnection(int index, int x, int z, int dir, bool value) { }

	[Obsolete("Use GridNode.HasConnectionInDirection instead")]
	// RVA: 0xB34FC0 Offset: 0xB339C0 VA: 0x180B34FC0
	public bool HasNodeConnection(int index, int x, int z, int dir) { }

	// RVA: 0xB38C50 Offset: 0xB37650 VA: 0x180B38C50
	public void SetGridShape(InspectorGridMode shape) { }

	// RVA: 0xB38BD0 Offset: 0xB375D0 VA: 0x180B38BD0
	public void SetDimensions(int width, int depth, float nodeSize) { }

	[Obsolete("Use SetDimensions instead")]
	// RVA: 0xB39570 Offset: 0xB37F70 VA: 0x180B39570
	public void UpdateSizeFromWidthDepth() { }

	[Obsolete("This method has been renamed to UpdateTransform")]
	// RVA: 0xB331D0 Offset: 0xB31BD0 VA: 0x180B331D0
	public void GenerateMatrix() { }

	// RVA: 0xB331D0 Offset: 0xB31BD0 VA: 0x180B331D0
	public void UpdateTransform() { }

	// RVA: 0xB304B0 Offset: 0xB2EEB0 VA: 0x180B304B0
	public GraphTransform CalculateTransform() { }

	// RVA: 0xB301C0 Offset: 0xB2EBC0 VA: 0x180B301C0
	private void CalculateDimensions(out int width, out int depth, out float nodeSize) { }

	// RVA: 0xB33B30 Offset: 0xB32530 VA: 0x180B33B30 Slot: 16
	public override NNInfoInternal GetNearest(Vector3 position, NNConstraint constraint, GraphNode hint) { }

	// RVA: 0xB33A80 Offset: 0xB32480 VA: 0x180B33A80 Slot: 38
	protected virtual GridNodeBase GetNearestFromGraphSpace(Vector3 positionGraphSpace) { }

	// RVA: 0xB33260 Offset: 0xB31C60 VA: 0x180B33260 Slot: 17
	public override NNInfoInternal GetNearestForce(Vector3 position, NNConstraint constraint) { }

	// RVA: 0xB38F30 Offset: 0xB37930 VA: 0x180B38F30 Slot: 39
	public virtual void SetUpOffsetsAndCosts() { }

	[IteratorStateMachine(typeof(GridGraph.<ScanInternal>d__92))]
	// RVA: 0xB38A50 Offset: 0xB37450 VA: 0x180B38A50 Slot: 20
	protected override IEnumerable<Progress> ScanInternal() { }

	[Obsolete("Use RecalculateCell instead which works both for grid graphs and layered grid graphs")]
	// RVA: 0xB39540 Offset: 0xB37F40 VA: 0x180B39540 Slot: 40
	public virtual void UpdateNodePositionCollision(GridNode node, int x, int z, bool resetPenalty = True) { }

	// RVA: 0xB382F0 Offset: 0xB36CF0 VA: 0x180B382F0 Slot: 41
	public virtual void RecalculateCell(int x, int z, bool resetPenalties = True, bool resetTags = True) { }

	// RVA: 0xB33050 Offset: 0xB31A50 VA: 0x180B33050 Slot: 42
	protected virtual bool ErosionAnyFalseConnections(GraphNode baseNode) { }

	// RVA: 0xB32B40 Offset: 0xB31540 VA: 0x180B32B40
	private void ErodeNode(GraphNode node) { }

	// RVA: 0xB32880 Offset: 0xB31280 VA: 0x180B32880
	private void ErodeNodeWithTagsInit(GraphNode node) { }

	// RVA: 0xB32900 Offset: 0xB31300 VA: 0x180B32900
	private void ErodeNodeWithTags(GraphNode node, int iteration) { }

	// RVA: 0xB32BA0 Offset: 0xB315A0 VA: 0x180B32BA0 Slot: 43
	public virtual void ErodeWalkableArea() { }

	// RVA: 0xB32BD0 Offset: 0xB315D0 VA: 0x180B32BD0
	public void ErodeWalkableArea(int xmin, int zmin, int xmax, int zmax) { }

	// RVA: 0xB35090 Offset: 0xB33A90 VA: 0x180B35090 Slot: 44
	public virtual bool IsValidConnection(GridNodeBase node1, GridNodeBase node2) { }

	// RVA: 0xB2FA30 Offset: 0xB2E430 VA: 0x180B2FA30
	public void CalculateConnectionsForCellAndNeighbours(int x, int z) { }

	[Obsolete("Use the instance function instead")]
	// RVA: 0xB2FB40 Offset: 0xB2E540 VA: 0x180B2FB40
	public static void CalculateConnections(GridNode node) { }

	// RVA: 0xB2FBF0 Offset: 0xB2E5F0 VA: 0x180B2FBF0 Slot: 45
	public virtual void CalculateConnections(GridNodeBase node) { }

	[Obsolete("Use CalculateConnections(x,z) or CalculateConnections(node) instead")]
	// RVA: 0xB2FB20 Offset: 0xB2E520 VA: 0x180B2FB20 Slot: 46
	public virtual void CalculateConnections(int x, int z, GridNode node) { }

	// RVA: 0xB2FC40 Offset: 0xB2E640 VA: 0x180B2FC40 Slot: 47
	public virtual void CalculateConnections(int x, int z) { }

	// RVA: 0xB36DC0 Offset: 0xB357C0 VA: 0x180B36DC0 Slot: 25
	public override void OnDrawGizmos(RetainedGizmos gizmos, bool drawNodes) { }

	// RVA: 0xB31490 Offset: 0xB2FE90 VA: 0x180B31490
	private void CreateNavmeshSurfaceVisualization(GridNodeBase[] nodes, int nodeCount, GraphGizmoHelper helper) { }

	// RVA: 0xB34B10 Offset: 0xB33510 VA: 0x180B34B10
	public IntRect GetRectFromBounds(Bounds bounds) { }

	[Obsolete("This method has been renamed to GetNodesInRegion", True)]
	// RVA: 0xB34290 Offset: 0xB32C90 VA: 0x180B34290
	public List<GraphNode> GetNodesInArea(Bounds bounds) { }

	[Obsolete("This method has been renamed to GetNodesInRegion", True)]
	// RVA: 0xB342D0 Offset: 0xB32CD0 VA: 0x180B342D0
	public List<GraphNode> GetNodesInArea(GraphUpdateShape shape) { }

	[Obsolete("This method has been renamed to GetNodesInRegion", True)]
	// RVA: 0xB34250 Offset: 0xB32C50 VA: 0x180B34250
	public List<GraphNode> GetNodesInArea(Bounds bounds, GraphUpdateShape shape) { }

	// RVA: 0xB34290 Offset: 0xB32C90 VA: 0x180B34290
	public List<GraphNode> GetNodesInRegion(Bounds bounds) { }

	// RVA: 0xB342D0 Offset: 0xB32CD0 VA: 0x180B342D0
	public List<GraphNode> GetNodesInRegion(GraphUpdateShape shape) { }

	// RVA: 0xB34340 Offset: 0xB32D40 VA: 0x180B34340 Slot: 48
	protected virtual List<GraphNode> GetNodesInRegion(Bounds bounds, GraphUpdateShape shape) { }

	// RVA: 0xB34600 Offset: 0xB33000 VA: 0x180B34600 Slot: 49
	public virtual List<GraphNode> GetNodesInRegion(IntRect rect) { }

	// RVA: 0xB34850 Offset: 0xB33250 VA: 0x180B34850 Slot: 50
	public virtual int GetNodesInRegion(IntRect rect, GridNodeBase[] buffer) { }

	// RVA: 0xB341F0 Offset: 0xB32BF0 VA: 0x180B341F0 Slot: 51
	public virtual GridNodeBase GetNode(int x, int z) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 29
	private GraphUpdateThreading Pathfinding.IUpdatableGraph.CanUpdateAsync(GraphUpdateObject o) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 27
	private void Pathfinding.IUpdatableGraph.UpdateAreaInit(GraphUpdateObject o) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 28
	private void Pathfinding.IUpdatableGraph.UpdateAreaPost(GraphUpdateObject o) { }

	// RVA: 0xB2F5E0 Offset: 0xB2DFE0 VA: 0x180B2F5E0
	protected void CalculateAffectedRegions(GraphUpdateObject o, out IntRect originalRect, out IntRect affectRect, out IntRect physicsRect, out bool willChangeWalkability, out int erosion) { }

	// RVA: 0xB37880 Offset: 0xB36280 VA: 0x180B37880 Slot: 26
	private void Pathfinding.IUpdatableGraph.UpdateArea(GraphUpdateObject o) { }

	// RVA: 0xB36120 Offset: 0xB34B20 VA: 0x180B36120 Slot: 31
	public bool Linecast(Vector3 from, Vector3 to) { }

	[Obsolete("The hint parameter is deprecated")]
	// RVA: 0xB36120 Offset: 0xB34B20 VA: 0x180B36120 Slot: 32
	public bool Linecast(Vector3 from, Vector3 to, GraphNode hint) { }

	[Obsolete("The hint parameter is deprecated")]
	// RVA: 0xB360C0 Offset: 0xB34AC0 VA: 0x180B360C0 Slot: 33
	public bool Linecast(Vector3 from, Vector3 to, GraphNode hint, out GraphHitInfo hit) { }

	// RVA: 0xB321C0 Offset: 0xB30BC0 VA: 0x180B321C0
	protected static long CrossMagnitude(Int2 a, Int2 b) { }

	// RVA: 0xB30CF0 Offset: 0xB2F6F0 VA: 0x180B30CF0
	protected bool ClipLineSegmentToBounds(Vector3 a, Vector3 b, out Vector3 outA, out Vector3 outB) { }

	[Obsolete("The hint parameter is deprecated")]
	// RVA: 0xB362C0 Offset: 0xB34CC0 VA: 0x180B362C0 Slot: 34
	public bool Linecast(Vector3 from, Vector3 to, GraphNode hint, out GraphHitInfo hit, List<GraphNode> trace) { }

	// RVA: 0xB36320 Offset: 0xB34D20 VA: 0x180B36320 Slot: 35
	public bool Linecast(Vector3 from, Vector3 to, out GraphHitInfo hit, List<GraphNode> trace, Func<GraphNode, bool> filter) { }

	[Obsolete("Use Linecast instead")]
	// RVA: 0xB39410 Offset: 0xB37E10 VA: 0x180B39410
	public bool SnappedLinecast(Vector3 from, Vector3 to, GraphNode hint, out GraphHitInfo hit) { }

	// RVA: 0xB352F0 Offset: 0xB33CF0 VA: 0x180B352F0
	public bool Linecast(GridNodeBase fromNode, GridNodeBase toNode, Func<GraphNode, bool> filter) { }

	// RVA: 0xB36960 Offset: 0xB35360 VA: 0x180B36960
	public bool Linecast(Vector3 from, Vector3 to, out GridHitInfo hit, List<GraphNode> trace, Func<GraphNode, bool> filter) { }

	// RVA: 0xB36190 Offset: 0xB34B90 VA: 0x180B36190
	public bool Linecast(GridNodeBase fromNode, Vector2 normalizedFromPoint, GridNodeBase toNode, Vector2 normalizedToPoint, out GridHitInfo hit, List<GraphNode> trace, Func<GraphNode, bool> filter, bool continuePastEnd = False) { }

	// RVA: 0xB35350 Offset: 0xB33D50 VA: 0x180B35350
	public bool Linecast(GridNodeBase fromNode, Int2 fixedNormalizedFromPoint, GridNodeBase toNode, Int2 fixedNormalizedToPoint, out GridHitInfo hit, List<GraphNode> trace, Func<GraphNode, bool> filter, bool continuePastEnd = False) { }

	// RVA: 0xB30B10 Offset: 0xB2F510 VA: 0x180B30B10
	public bool CheckConnection(GridNode node, int dir) { }

	// RVA: 0xB38AD0 Offset: 0xB374D0 VA: 0x180B38AD0 Slot: 21
	protected override void SerializeExtraInfo(GraphSerializationContext ctx) { }

	// RVA: 0xB321F0 Offset: 0xB30BF0 VA: 0x180B321F0 Slot: 22
	protected override void DeserializeExtraInfo(GraphSerializationContext ctx) { }

	// RVA: 0xB323D0 Offset: 0xB30DD0 VA: 0x180B323D0 Slot: 24
	protected override void DeserializeSettingsCompatibility(GraphSerializationContext ctx) { }

	// RVA: 0xB380C0 Offset: 0xB36AC0 VA: 0x180B380C0 Slot: 23
	protected override void PostDeserialization(GraphSerializationContext ctx) { }

	// RVA: 0xB395A0 Offset: 0xB37FA0 VA: 0x180B395A0
	private static void .cctor() { }
}
