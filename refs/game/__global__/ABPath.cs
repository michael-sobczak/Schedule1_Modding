public class ABPath : Path // TypeDefIndex: 13312
{
	// Fields
	public GraphNode startNode; // 0xD0
	public GraphNode endNode; // 0xD8
	public Vector3 originalStartPoint; // 0xE0
	public Vector3 originalEndPoint; // 0xEC
	public Vector3 startPoint; // 0xF8
	public Vector3 endPoint; // 0x104
	public Int3 startIntPoint; // 0x110
	public bool calculatePartial; // 0x11C
	protected PathNode partialBestTarget; // 0x120
	protected int[] endNodeCosts; // 0x128
	private GridNode gridSpecialCaseNode; // 0x130
	private static readonly NNConstraint NNConstraintNone; // 0x0

	// Properties
	protected virtual bool hasEndPoint { get; }

	// Methods

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 28
	protected virtual bool get_hasEndPoint() { }

	// RVA: 0xB64130 Offset: 0xB62B30 VA: 0x180B64130
	public void .ctor() { }

	// RVA: 0xB61F00 Offset: 0xB60900 VA: 0x180B61F00
	public static ABPath Construct(Vector3 start, Vector3 end, OnPathDelegate callback) { }

	// RVA: 0xB63EE0 Offset: 0xB628E0 VA: 0x180B63EE0
	protected void Setup(Vector3 start, Vector3 end, OnPathDelegate callbackDelegate) { }

	// RVA: 0xB62930 Offset: 0xB61330 VA: 0x180B62930
	public static ABPath FakePath(List<Vector3> vectorPath, List<GraphNode> nodePath) { }

	// RVA: 0xB63FE0 Offset: 0xB629E0 VA: 0x180B63FE0
	protected void UpdateStartEnd(Vector3 start, Vector3 end) { }

	// RVA: 0xB62D80 Offset: 0xB61780 VA: 0x180B62D80 Slot: 18
	public override uint GetConnectionSpecialCost(GraphNode a, GraphNode b, uint currentCost) { }

	// RVA: 0xB63A40 Offset: 0xB62440 VA: 0x180B63A40 Slot: 20
	protected override void Reset() { }

	// RVA: 0xB623D0 Offset: 0xB60DD0 VA: 0x180B623D0 Slot: 29
	protected virtual bool EndPointGridGraphSpecialCase(GraphNode closestWalkableEndNode) { }

	// RVA: 0xB63BF0 Offset: 0xB625F0 VA: 0x180B63BF0
	private void SetFlagOnSurroundingGridNodes(GridNode gridNode, int flag, bool flagState) { }

	// RVA: 0xB63620 Offset: 0xB62020 VA: 0x180B63620 Slot: 24
	protected override void Prepare() { }

	// RVA: 0xB61D20 Offset: 0xB60720 VA: 0x180B61D20 Slot: 30
	protected virtual void CompletePathIfStartIsValidTarget() { }

	// RVA: 0xB633D0 Offset: 0xB61DD0 VA: 0x180B633D0 Slot: 26
	protected override void Initialize() { }

	// RVA: 0xB61B20 Offset: 0xB60520 VA: 0x180B61B20 Slot: 25
	protected override void Cleanup() { }

	// RVA: 0xB61C60 Offset: 0xB60660 VA: 0x180B61C60
	private void CompletePartial(PathNode node) { }

	// RVA: 0xB61DC0 Offset: 0xB607C0 VA: 0x180B61DC0
	private void CompleteWith(GraphNode node) { }

	// RVA: 0xB61890 Offset: 0xB60290 VA: 0x180B61890 Slot: 27
	protected override void CalculateStep(long targetTick) { }

	// RVA: 0xB62060 Offset: 0xB60A60 VA: 0x180B62060 Slot: 22
	protected override string DebugString(PathLog logMode) { }

	[Obsolete]
	// RVA: 0xB630D0 Offset: 0xB61AD0 VA: 0x180B630D0
	public Vector3 GetMovementVector(Vector3 point) { }

	// RVA: 0xB640D0 Offset: 0xB62AD0 VA: 0x180B640D0
	private static void .cctor() { }
}
