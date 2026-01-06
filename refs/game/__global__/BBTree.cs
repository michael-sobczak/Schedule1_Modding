public class BBTree : IAstarPooledObject // TypeDefIndex: 13261
{
	// Fields
	private BBTree.BBTreeBox[] tree; // 0x10
	private TriangleMeshNode[] nodeLookup; // 0x18
	private int count; // 0x20
	private int leafNodes; // 0x24
	private const int MaximumLeafSize = 4;

	// Properties
	public Rect Size { get; }

	// Methods

	// RVA: 0xB4D1D0 Offset: 0xB4BBD0 VA: 0x180B4D1D0
	public Rect get_Size() { }

	// RVA: 0xB4A220 Offset: 0xB48C20 VA: 0x180B4A220
	public void Clear() { }

	// RVA: 0xB4B450 Offset: 0xB49E50 VA: 0x180B4B450 Slot: 4
	private void Pathfinding.Util.IAstarPooledObject.OnEnterPool() { }

	// RVA: 0xB4ABA0 Offset: 0xB495A0 VA: 0x180B4ABA0
	private void EnsureCapacity(int c) { }

	// RVA: 0xB4AC70 Offset: 0xB49670 VA: 0x180B4AC70
	private void EnsureNodeCapacity(int c) { }

	// RVA: 0xB4AD40 Offset: 0xB49740 VA: 0x180B4AD40
	private int GetBox(IntRect rect) { }

	// RVA: 0xB4C0B0 Offset: 0xB4AAB0 VA: 0x180B4C0B0
	public void RebuildFrom(TriangleMeshNode[] nodes) { }

	// RVA: 0xB4CF30 Offset: 0xB4B930 VA: 0x180B4CF30
	private static int SplitByX(TriangleMeshNode[] nodes, int[] permutation, int from, int to, int divider) { }

	// RVA: 0xB4D000 Offset: 0xB4BA00 VA: 0x180B4D000
	private static int SplitByZ(TriangleMeshNode[] nodes, int[] permutation, int from, int to, int divider) { }

	// RVA: 0xB4B960 Offset: 0xB4A360 VA: 0x180B4B960
	private int RebuildFromInternal(TriangleMeshNode[] nodes, int[] permutation, IntRect[] nodeBounds, int from, int to, bool odd) { }

	// RVA: 0xB4AEE0 Offset: 0xB498E0 VA: 0x180B4AEE0
	private static IntRect NodeBounds(int[] permutation, IntRect[] nodeBounds, int from, int to) { }

	[Conditional("ASTARDEBUG")]
	// RVA: 0xB4A990 Offset: 0xB49390 VA: 0x180B4A990
	private static void DrawDebugRect(IntRect rect) { }

	[Conditional("ASTARDEBUG")]
	// RVA: 0xB4A3E0 Offset: 0xB48DE0 VA: 0x180B4A3E0
	private static void DrawDebugNode(TriangleMeshNode node, float yoffset, Color color) { }

	// RVA: 0xB4B5B0 Offset: 0xB49FB0 VA: 0x180B4B5B0
	public NNInfoInternal QueryClosest(Vector3 p, NNConstraint constraint, out float distance) { }

	// RVA: 0xB4B460 Offset: 0xB49E60 VA: 0x180B4B460
	public NNInfoInternal QueryClosestXZ(Vector3 p, NNConstraint constraint, ref float distance, NNInfoInternal previous) { }

	// RVA: 0xB4C570 Offset: 0xB4AF70 VA: 0x180B4C570
	private void SearchBoxClosestXZ(int boxi, Vector3 p, ref float closestSqrDist, NNConstraint constraint, ref NNInfoInternal nnInfo) { }

	// RVA: 0xB4B730 Offset: 0xB4A130 VA: 0x180B4B730
	public NNInfoInternal QueryClosest(Vector3 p, NNConstraint constraint, ref float distance, NNInfoInternal previous) { }

	// RVA: 0xB4C940 Offset: 0xB4B340 VA: 0x180B4C940
	private void SearchBoxClosest(int boxi, Vector3 p, ref float closestSqrDist, NNConstraint constraint, ref NNInfoInternal nnInfo) { }

	// RVA: 0xB4ADD0 Offset: 0xB497D0 VA: 0x180B4ADD0
	private void GetOrderedChildren(ref int first, ref int second, out float firstDist, out float secondDist, Vector3 p) { }

	// RVA: 0xB4B880 Offset: 0xB4A280 VA: 0x180B4B880
	public TriangleMeshNode QueryInside(Vector3 p, NNConstraint constraint) { }

	// RVA: 0xB4CC80 Offset: 0xB4B680 VA: 0x180B4CC80
	private TriangleMeshNode SearchBoxInside(int boxi, Vector3 p, NNConstraint constraint) { }

	// RVA: 0xB4B130 Offset: 0xB49B30 VA: 0x180B4B130
	public void OnDrawGizmos() { }

	// RVA: 0xB4B180 Offset: 0xB49B80 VA: 0x180B4B180
	private void OnDrawGizmos(int boxi, int depth) { }

	// RVA: 0xB4B070 Offset: 0xB49A70 VA: 0x180B4B070
	private static bool NodeIntersectsCircle(TriangleMeshNode node, Vector3 p, float radius) { }

	// RVA: 0xB4C440 Offset: 0xB4AE40 VA: 0x180B4C440
	private static bool RectIntersectsCircle(IntRect r, Vector3 p, float radius) { }

	// RVA: 0xB4D0D0 Offset: 0xB4BAD0 VA: 0x180B4D0D0
	private static float SquaredRectPointDistance(IntRect r, Vector3 p) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
