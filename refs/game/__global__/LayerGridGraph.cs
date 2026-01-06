public class LayerGridGraph : GridGraph, IUpdatableGraph // TypeDefIndex: 13234
{
	// Fields
	[JsonMember]
	internal int layerCount; // 0x190
	[JsonMember]
	public float mergeSpanRange; // 0x194
	[JsonMember]
	public float characterHeight; // 0x198
	internal int lastScannedWidth; // 0x19C
	internal int lastScannedDepth; // 0x1A0
	private static readonly LayerGridGraph.HitComparer comparer; // 0x0
	private static LayerGridGraph.HeightSample[] heightSampleBuffer; // 0x8

	// Properties
	public override bool uniformWidthDepthGrid { get; }
	public override int LayerCount { get; }

	// Methods

	// RVA: 0xB3BA20 Offset: 0xB3A420 VA: 0x180B3BA20 Slot: 18
	protected override void OnDestroy() { }

	// RVA: 0xB3D0E0 Offset: 0xB3BAE0 VA: 0x180B3D0E0
	private void RemoveGridGraphFromStatic() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 36
	public override bool get_uniformWidthDepthGrid() { }

	// RVA: 0xB3D920 Offset: 0xB3C320 VA: 0x180B3D920 Slot: 37
	public override int get_LayerCount() { }

	// RVA: 0xB3A770 Offset: 0xB39170 VA: 0x180B3A770 Slot: 13
	public override int CountNodes() { }

	// RVA: 0xB3B970 Offset: 0xB3A370 VA: 0x180B3B970 Slot: 14
	public override void GetNodes(Action<GraphNode> action) { }

	// RVA: 0xB3B650 Offset: 0xB3A050 VA: 0x180B3B650 Slot: 48
	protected override List<GraphNode> GetNodesInRegion(Bounds b, GraphUpdateShape shape) { }

	// RVA: 0xB3B190 Offset: 0xB39B90 VA: 0x180B3B190 Slot: 49
	public override List<GraphNode> GetNodesInRegion(IntRect rect) { }

	// RVA: 0xB3B3E0 Offset: 0xB39DE0 VA: 0x180B3B3E0 Slot: 50
	public override int GetNodesInRegion(IntRect rect, GridNodeBase[] buffer) { }

	// RVA: 0xB341F0 Offset: 0xB32BF0 VA: 0x180B341F0 Slot: 51
	public override GridNodeBase GetNode(int x, int z) { }

	// RVA: 0xB3B110 Offset: 0xB39B10 VA: 0x180B3B110
	public GridNodeBase GetNode(int x, int z, int layer) { }

	// RVA: 0xB3BB10 Offset: 0xB3A510 VA: 0x180B3BB10 Slot: 26
	private void Pathfinding.IUpdatableGraph.UpdateArea(GraphUpdateObject o) { }

	[IteratorStateMachine(typeof(LayerGridGraph.<ScanInternal>d__19))]
	// RVA: 0xB3D600 Offset: 0xB3C000 VA: 0x180B3D600 Slot: 20
	protected override IEnumerable<Progress> ScanInternal() { }

	// RVA: 0xB3D150 Offset: 0xB3BB50 VA: 0x180B3D150
	protected static LayerGridGraph.HeightSample[] SampleHeights(GraphCollision collision, float mergeSpanRange, Vector3 position, out int numHits) { }

	// RVA: 0xB3C880 Offset: 0xB3B280 VA: 0x180B3C880 Slot: 41
	public override void RecalculateCell(int x, int z, bool resetPenalties = True, bool resetTags = True) { }

	// RVA: 0xB39DE0 Offset: 0xB387E0 VA: 0x180B39DE0
	private void AddLayers(int count) { }

	// RVA: 0xB3AA40 Offset: 0xB39440 VA: 0x180B3AA40 Slot: 42
	protected override bool ErosionAnyFalseConnections(GraphNode baseNode) { }

	// RVA: 0xB3A610 Offset: 0xB39010 VA: 0x180B3A610 Slot: 45
	public override void CalculateConnections(GridNodeBase baseNode) { }

	[Obsolete("Use CalculateConnections(x,z,layerIndex) or CalculateConnections(node) instead")]
	// RVA: 0xB3A730 Offset: 0xB39130 VA: 0x180B3A730
	public void CalculateConnections(int x, int z, int layerIndex, LevelGridNode node) { }

	// RVA: 0xB3A6C0 Offset: 0xB390C0 VA: 0x180B3A6C0 Slot: 47
	public override void CalculateConnections(int x, int z) { }

	// RVA: 0xB39FD0 Offset: 0xB389D0 VA: 0x180B39FD0
	public void CalculateConnections(int x, int z, int layerIndex) { }

	// RVA: 0xB3AE60 Offset: 0xB39860 VA: 0x180B3AE60 Slot: 16
	public override NNInfoInternal GetNearest(Vector3 position, NNConstraint constraint, GraphNode hint) { }

	// RVA: 0xB3ABC0 Offset: 0xB395C0 VA: 0x180B3ABC0 Slot: 38
	protected override GridNodeBase GetNearestFromGraphSpace(Vector3 positionGraphSpace) { }

	// RVA: 0xB3ACD0 Offset: 0xB396D0 VA: 0x180B3ACD0
	private GridNodeBase GetNearestNode(Vector3 position, int x, int z, NNConstraint constraint) { }

	[Obsolete("Use node.HasConnectionInDirection instead")]
	// RVA: 0xB3A740 Offset: 0xB39140 VA: 0x180B3A740
	public static bool CheckConnection(LevelGridNode node, int dir) { }

	// RVA: 0xB3D680 Offset: 0xB3C080 VA: 0x180B3D680 Slot: 21
	protected override void SerializeExtraInfo(GraphSerializationContext ctx) { }

	// RVA: 0xB3A7F0 Offset: 0xB391F0 VA: 0x180B3A7F0 Slot: 22
	protected override void DeserializeExtraInfo(GraphSerializationContext ctx) { }

	// RVA: 0xB3C5D0 Offset: 0xB3AFD0 VA: 0x180B3C5D0 Slot: 23
	protected override void PostDeserialization(GraphSerializationContext ctx) { }

	// RVA: 0xB3D8C0 Offset: 0xB3C2C0 VA: 0x180B3D8C0
	public void .ctor() { }

	// RVA: 0xB3D800 Offset: 0xB3C200 VA: 0x180B3D800
	private static void .cctor() { }
}
