public class RichFunnel : RichPathPart // TypeDefIndex: 13106
{
	// Fields
	private readonly List<Vector3> left; // 0x10
	private readonly List<Vector3> right; // 0x18
	private List<TriangleMeshNode> nodes; // 0x20
	public Vector3 exactStart; // 0x28
	public Vector3 exactEnd; // 0x34
	private NavmeshBase graph; // 0x40
	private int currentNode; // 0x48
	private Vector3 currentPosition; // 0x4C
	private int checkForDestroyedNodesCounter; // 0x58
	private RichPath path; // 0x60
	private int[] triBuffer; // 0x68
	public bool funnelSimplification; // 0x70
	private static Queue<TriangleMeshNode> navmeshClampQueue; // 0x0
	private static List<TriangleMeshNode> navmeshClampList; // 0x8
	private static Dictionary<TriangleMeshNode, TriangleMeshNode> navmeshClampDict; // 0x10

	// Properties
	public TriangleMeshNode CurrentNode { get; }
	public float DistanceToEndOfPath { get; }

	// Methods

	// RVA: 0xAFD380 Offset: 0xAFBD80 VA: 0x180AFD380
	public void .ctor() { }

	// RVA: 0xAFB880 Offset: 0xAFA280 VA: 0x180AFB880
	public RichFunnel Initialize(RichPath path, NavmeshBase graph) { }

	// RVA: 0xAFB9A0 Offset: 0xAFA3A0 VA: 0x180AFB9A0 Slot: 5
	public override void OnEnterPool() { }

	// RVA: 0xAFD4A0 Offset: 0xAFBEA0 VA: 0x180AFD4A0
	public TriangleMeshNode get_CurrentNode() { }

	// RVA: 0xAF9440 Offset: 0xAF7E40 VA: 0x180AF9440
	public void BuildFunnelCorridor(List<GraphNode> nodes, int start, int end) { }

	// RVA: 0xAFBA50 Offset: 0xAFA450 VA: 0x180AFBA50
	private void SimplifyPath(IRaycastableGraph graph, List<GraphNode> nodes, int start, int end, List<GraphNode> result, Vector3 startPoint, Vector3 endPoint) { }

	// RVA: 0xAFC910 Offset: 0xAFB310 VA: 0x180AFC910
	private void UpdateFunnelCorridor(int splitIndex, List<TriangleMeshNode> prefix) { }

	// RVA: 0xAF9BC0 Offset: 0xAF85C0 VA: 0x180AF9BC0
	private bool CheckForDestroyedNodes() { }

	// RVA: 0xAFD510 Offset: 0xAFBF10 VA: 0x180AFD510
	public float get_DistanceToEndOfPath() { }

	// RVA: 0xAFA2C0 Offset: 0xAF8CC0 VA: 0x180AFA2C0
	public Vector3 ClampToNavmesh(Vector3 position) { }

	// RVA: 0xAFCCA0 Offset: 0xAFB6A0 VA: 0x180AFCCA0
	public Vector3 Update(Vector3 position, List<Vector3> buffer, int numCorners, out bool lastCorner, out bool requiresRepath) { }

	// RVA: 0xAF9C70 Offset: 0xAF8670 VA: 0x180AF9C70
	private bool ClampToNavmeshInternal(ref Vector3 position) { }

	// RVA: 0xAFB840 Offset: 0xAFA240 VA: 0x180AFB840
	public void FindWalls(List<Vector3> wallBuffer, float range) { }

	// RVA: 0xAFB090 Offset: 0xAF9A90 VA: 0x180AFB090
	private void FindWalls(int nodeIndex, List<Vector3> wallBuffer, Vector3 position, float range) { }

	// RVA: 0xAFA4C0 Offset: 0xAF8EC0 VA: 0x180AFA4C0
	private bool FindNextCorners(Vector3 origin, int startIndex, List<Vector3> funnelPath, int numCorners, out bool lastCorner) { }

	// RVA: 0xAFD230 Offset: 0xAFBC30 VA: 0x180AFD230
	private static void .cctor() { }
}
