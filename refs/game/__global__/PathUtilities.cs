public static class PathUtilities // TypeDefIndex: 13341
{
	// Fields
	private static Queue<GraphNode> BFSQueue; // 0x0
	private static Dictionary<GraphNode, int> BFSMap; // 0x8

	// Methods

	// RVA: 0xB8C310 Offset: 0xB8AD10 VA: 0x180B8C310
	public static bool IsPathPossible(GraphNode node1, GraphNode node2) { }

	// RVA: 0xB8C090 Offset: 0xB8AA90 VA: 0x180B8C090
	public static bool IsPathPossible(List<GraphNode> nodes) { }

	// RVA: 0xB8C190 Offset: 0xB8AB90 VA: 0x180B8C190
	public static bool IsPathPossible(List<GraphNode> nodes, int tagMask) { }

	// RVA: 0xB8B960 Offset: 0xB8A360 VA: 0x180B8B960
	public static List<GraphNode> GetReachableNodes(GraphNode seed, int tagMask = -1, Func<GraphNode, bool> filter) { }

	// RVA: 0xB8A550 Offset: 0xB88F50 VA: 0x180B8A550
	public static List<GraphNode> BFS(GraphNode seed, int depth, int tagMask = -1, Func<GraphNode, bool> filter) { }

	// RVA: 0xB8BBE0 Offset: 0xB8A5E0 VA: 0x180B8BBE0
	public static List<Vector3> GetSpiralPoints(int count, float clearance) { }

	// RVA: 0xB8C000 Offset: 0xB8AA00 VA: 0x180B8C000
	private static Vector3 InvoluteOfCircle(float a, float t) { }

	// RVA: 0xB8A900 Offset: 0xB89300 VA: 0x180B8A900
	public static void GetPointsAroundPointWorld(Vector3 p, IRaycastableGraph g, List<Vector3> previousPoints, float radius, float clearanceRadius) { }

	// RVA: 0xB8AB20 Offset: 0xB89520 VA: 0x180B8AB20
	public static void GetPointsAroundPoint(Vector3 center, IRaycastableGraph g, List<Vector3> previousPoints, float radius, float clearanceRadius) { }

	// RVA: 0xB8B2A0 Offset: 0xB89CA0 VA: 0x180B8B2A0
	public static List<Vector3> GetPointsOnNodes(List<GraphNode> nodes, int count, float clearanceRadius = 0) { }
}
