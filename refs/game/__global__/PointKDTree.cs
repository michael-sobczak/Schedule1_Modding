public class PointKDTree // TypeDefIndex: 13276
{
	// Fields
	public const int LeafSize = 10;
	public const int LeafArraySize = 21;
	private PointKDTree.Node[] tree; // 0x10
	private int numNodes; // 0x18
	private readonly List<GraphNode> largeList; // 0x20
	private readonly Stack<GraphNode[]> arrayCache; // 0x28
	private static readonly IComparer<GraphNode>[] comparers; // 0x0

	// Methods

	// RVA: 0xB70EE0 Offset: 0xB6F8E0 VA: 0x180B70EE0
	public void .ctor() { }

	// RVA: 0xB6F530 Offset: 0xB6DF30 VA: 0x180B6F530
	public void Add(GraphNode node) { }

	// RVA: 0xB70A50 Offset: 0xB6F450 VA: 0x180B70A50
	public void Rebuild(GraphNode[] nodes, int start, int end) { }

	// RVA: 0xB708B0 Offset: 0xB6F2B0 VA: 0x180B708B0
	private GraphNode[] GetOrCreateList() { }

	// RVA: 0xB70C80 Offset: 0xB6F680 VA: 0x180B70C80
	private int Size(int index) { }

	// RVA: 0xB6FAE0 Offset: 0xB6E4E0 VA: 0x180B6FAE0
	private void CollectAndClear(int index, List<GraphNode> buffer) { }

	// RVA: 0xB70930 Offset: 0xB6F330 VA: 0x180B70930
	private static int MaxAllowedSize(int numNodes, int depth) { }

	// RVA: 0xB709B0 Offset: 0xB6F3B0 VA: 0x180B709B0
	private void Rebalance(int index) { }

	// RVA: 0xB6FCB0 Offset: 0xB6E6B0 VA: 0x180B6FCB0
	private void EnsureSize(int index) { }

	// RVA: 0xB6F560 Offset: 0xB6DF60 VA: 0x180B6F560
	private void Build(int index, List<GraphNode> nodes, int start, int end) { }

	// RVA: 0xB6F200 Offset: 0xB6DC00 VA: 0x180B6F200
	private void Add(GraphNode point, int index, int depth = 0) { }

	// RVA: 0xB70850 Offset: 0xB6F250 VA: 0x180B70850
	public GraphNode GetNearest(Int3 point, NNConstraint constraint) { }

	// RVA: 0xB705D0 Offset: 0xB6EFD0 VA: 0x180B705D0
	private void GetNearestInternal(int index, Int3 point, NNConstraint constraint, ref GraphNode best, ref long bestSqrDist) { }

	// RVA: 0xB70560 Offset: 0xB6EF60 VA: 0x180B70560
	public GraphNode GetNearestConnection(Int3 point, NNConstraint constraint, long maximumSqrConnectionLength) { }

	// RVA: 0xB70000 Offset: 0xB6EA00 VA: 0x180B70000
	private void GetNearestConnectionInternal(int index, Int3 point, NNConstraint constraint, ref GraphNode best, ref long bestSqrDist, long distanceThresholdOffset) { }

	// RVA: 0xB6FFC0 Offset: 0xB6E9C0 VA: 0x180B6FFC0
	public void GetInRange(Int3 point, long sqrRadius, List<GraphNode> buffer) { }

	// RVA: 0xB6FD70 Offset: 0xB6E770 VA: 0x180B6FD70
	private void GetInRangeInternal(int index, Int3 point, long sqrRadius, List<GraphNode> buffer) { }

	// RVA: 0xB70D10 Offset: 0xB6F710 VA: 0x180B70D10
	private static void .cctor() { }
}
