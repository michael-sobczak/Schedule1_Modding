public class PointGraph : NavGraph, IUpdatableGraph // TypeDefIndex: 13253
{
	// Fields
	[JsonMember]
	public Transform root; // 0xD0
	[JsonMember]
	public string searchTag; // 0xD8
	[JsonMember]
	public float maxDistance; // 0xE0
	[JsonMember]
	public Vector3 limits; // 0xE4
	[JsonMember]
	public bool raycast; // 0xF0
	[JsonMember]
	public bool use2DPhysics; // 0xF1
	[JsonMember]
	public bool thickRaycast; // 0xF2
	[JsonMember]
	public float thickRaycastRadius; // 0xF4
	[JsonMember]
	public bool recursive; // 0xF8
	[JsonMember]
	public LayerMask mask; // 0xFC
	[JsonMember]
	public bool optimizeForSparseGraph; // 0x100
	private PointKDTree lookupTree; // 0x108
	private long maximumConnectionLength; // 0x110
	public PointNode[] nodes; // 0x118
	[JsonMember]
	public PointGraph.NodeDistanceMode nearestNodeDistanceMode; // 0x120
	[CompilerGenerated]
	private int <nodeCount>k__BackingField; // 0x124

	// Properties
	public int nodeCount { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x704910 Offset: 0x703310 VA: 0x180704910
	public int get_nodeCount() { }

	[CompilerGenerated]
	// RVA: 0x7049D0 Offset: 0x7033D0 VA: 0x1807049D0
	protected void set_nodeCount(int value) { }

	// RVA: 0x704910 Offset: 0x703310 VA: 0x180704910 Slot: 13
	public override int CountNodes() { }

	// RVA: 0xB54680 Offset: 0xB53080 VA: 0x180B54680 Slot: 14
	public override void GetNodes(Action<GraphNode> action) { }

	// RVA: 0xB54620 Offset: 0xB53020 VA: 0x180B54620 Slot: 16
	public override NNInfoInternal GetNearest(Vector3 position, NNConstraint constraint, GraphNode hint) { }

	// RVA: 0xB54170 Offset: 0xB52B70 VA: 0x180B54170 Slot: 17
	public override NNInfoInternal GetNearestForce(Vector3 position, NNConstraint constraint) { }

	// RVA: 0xB541D0 Offset: 0xB52BD0 VA: 0x180B541D0
	private NNInfoInternal GetNearestInternal(Vector3 position, NNConstraint constraint, bool fastCheck) { }

	// RVA: 0xB53EB0 Offset: 0xB528B0 VA: 0x180B53EB0
	private NNInfoInternal FindClosestConnectionPoint(PointNode node, Vector3 position) { }

	// RVA: 0xB53420 Offset: 0xB51E20 VA: 0x180B53420
	public PointNode AddNode(Int3 position) { }

	// RVA: -1 Offset: -1
	public T AddNode<T>(T node, Int3 position) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF24BB0 Offset: 0xF235B0 VA: 0x180F24BB0
	|-PointGraph.AddNode<object>
	*/

	// RVA: 0xB53670 Offset: 0xB52070 VA: 0x180B53670
	protected static int CountChildren(Transform tr) { }

	// RVA: 0xB530D0 Offset: 0xB51AD0 VA: 0x180B530D0
	protected void AddChildren(ref int c, Transform tr) { }

	// RVA: 0xB55800 Offset: 0xB54200 VA: 0x180B55800
	public void RebuildNodeLookup() { }

	// RVA: 0xB55680 Offset: 0xB54080 VA: 0x180B55680
	public void RebuildConnectionDistanceLookup() { }

	// RVA: 0xB534C0 Offset: 0xB51EC0 VA: 0x180B534C0
	private void AddToLookup(PointNode node) { }

	// RVA: 0xB558C0 Offset: 0xB542C0 VA: 0x180B558C0
	public void RegisterConnectionLength(long sqrLength) { }

	// RVA: 0xB53880 Offset: 0xB52280 VA: 0x180B53880 Slot: 30
	protected virtual PointNode[] CreateNodes(int count) { }

	[IteratorStateMachine(typeof(PointGraph.<ScanInternal>d__35))]
	// RVA: 0xB55990 Offset: 0xB54390 VA: 0x180B55990 Slot: 20
	protected override IEnumerable<Progress> ScanInternal() { }

	// RVA: 0xB53570 Offset: 0xB51F70 VA: 0x180B53570
	public void ConnectNodes() { }

	[IteratorStateMachine(typeof(PointGraph.<ConnectNodesAsync>d__37))]
	// RVA: 0xB534F0 Offset: 0xB51EF0 VA: 0x180B534F0
	private IEnumerable<Progress> ConnectNodesAsync() { }

	// RVA: 0xB54720 Offset: 0xB53120 VA: 0x180B54720 Slot: 31
	public virtual bool IsValidConnection(GraphNode a, GraphNode b, out float dist) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 29
	private GraphUpdateThreading Pathfinding.IUpdatableGraph.CanUpdateAsync(GraphUpdateObject o) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 27
	private void Pathfinding.IUpdatableGraph.UpdateAreaInit(GraphUpdateObject o) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 28
	private void Pathfinding.IUpdatableGraph.UpdateAreaPost(GraphUpdateObject o) { }

	// RVA: 0xB54FE0 Offset: 0xB539E0 VA: 0x180B54FE0 Slot: 26
	private void Pathfinding.IUpdatableGraph.UpdateArea(GraphUpdateObject guo) { }

	// RVA: 0xB55670 Offset: 0xB54070 VA: 0x180B55670 Slot: 23
	protected override void PostDeserialization(GraphSerializationContext ctx) { }

	// RVA: 0xB55940 Offset: 0xB54340 VA: 0x180B55940 Slot: 15
	public override void RelocateNodes(Matrix4x4 deltaMatrix) { }

	// RVA: 0xB53BE0 Offset: 0xB525E0 VA: 0x180B53BE0 Slot: 24
	protected override void DeserializeSettingsCompatibility(GraphSerializationContext ctx) { }

	// RVA: 0xB55A10 Offset: 0xB54410 VA: 0x180B55A10 Slot: 21
	protected override void SerializeExtraInfo(GraphSerializationContext ctx) { }

	// RVA: 0xB539C0 Offset: 0xB523C0 VA: 0x180B539C0 Slot: 22
	protected override void DeserializeExtraInfo(GraphSerializationContext ctx) { }

	// RVA: 0xB55B70 Offset: 0xB54570 VA: 0x180B55B70
	public void .ctor() { }
}
