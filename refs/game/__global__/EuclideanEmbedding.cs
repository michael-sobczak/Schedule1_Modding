public class EuclideanEmbedding // TypeDefIndex: 13268
{
	// Fields
	public HeuristicOptimizationMode mode; // 0x10
	public int seed; // 0x14
	public Transform pivotPointRoot; // 0x18
	public int spreadOutCount; // 0x20
	public bool dirty; // 0x24
	private uint[] costs; // 0x28
	private int maxNodeIndex; // 0x30
	private int pivotCount; // 0x34
	private GraphNode[] pivots; // 0x38
	private const uint ra = 12820163;
	private const uint rc = 1140671485;
	private uint rval; // 0x40
	private object lockObj; // 0x48

	// Methods

	// RVA: 0xB4DE70 Offset: 0xB4C870 VA: 0x180B4DE70
	private uint GetRandom() { }

	// RVA: 0xB4D850 Offset: 0xB4C250 VA: 0x180B4D850
	private void EnsureCapacity(int index) { }

	// RVA: 0xB4DD30 Offset: 0xB4C730 VA: 0x180B4DD30
	public uint GetHeuristic(int nodeIndex1, int nodeIndex2) { }

	// RVA: 0xB4DA00 Offset: 0xB4C400 VA: 0x180B4DA00
	private void GetClosestWalkableNodesToChildrenRecursively(Transform tr, List<GraphNode> nodes) { }

	// RVA: 0xB4E1A0 Offset: 0xB4CBA0 VA: 0x180B4E1A0
	private void PickNRandomNodes(int count, List<GraphNode> buffer) { }

	// RVA: 0xB4E010 Offset: 0xB4CA10 VA: 0x180B4E010
	private GraphNode PickAnyWalkableNode() { }

	// RVA: 0xB4E6B0 Offset: 0xB4D0B0 VA: 0x180B4E6B0
	public void RecalculatePivots() { }

	// RVA: 0xB4E330 Offset: 0xB4CD30 VA: 0x180B4E330
	public void RecalculateCosts() { }

	// RVA: 0xB4D2A0 Offset: 0xB4BCA0 VA: 0x180B4D2A0
	private void ApplyGridGraphEndpointSpecialCase() { }

	// RVA: 0xB4DE80 Offset: 0xB4C880 VA: 0x180B4DE80
	public void OnDrawGizmos() { }

	// RVA: 0xB4ED50 Offset: 0xB4D750 VA: 0x180B4ED50
	public void .ctor() { }
}
