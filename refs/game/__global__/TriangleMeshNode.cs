public class TriangleMeshNode : MeshNode // TypeDefIndex: 13249
{
	// Fields
	public int v0; // 0x30
	public int v1; // 0x34
	public int v2; // 0x38
	protected static INavmeshHolder[] _navmeshHolders; // 0x0
	protected static readonly object lockObject; // 0x8

	// Methods

	// RVA: 0xB502E0 Offset: 0xB4ECE0 VA: 0x180B502E0
	public void .ctor(AstarPath astar) { }

	// RVA: 0xB5ABB0 Offset: 0xB595B0 VA: 0x180B5ABB0
	public static INavmeshHolder GetNavmeshHolder(uint graphIndex) { }

	// RVA: 0xB5C160 Offset: 0xB5AB60 VA: 0x180B5C160
	public static void SetNavmeshHolder(int graphIndex, INavmeshHolder graph) { }

	// RVA: 0xB5C5F0 Offset: 0xB5AFF0 VA: 0x180B5C5F0
	public void UpdatePositionFromVertices() { }

	// RVA: 0xB5B6C0 Offset: 0xB5A0C0 VA: 0x180B5B6C0
	public int GetVertexIndex(int i) { }

	// RVA: 0xB5B430 Offset: 0xB59E30 VA: 0x180B5B430
	public int GetVertexArrayIndex(int i) { }

	// RVA: 0xB5B990 Offset: 0xB5A390 VA: 0x180B5B990
	public void GetVertices(out Int3 v0, out Int3 v1, out Int3 v2) { }

	// RVA: 0xB5B800 Offset: 0xB5A200 VA: 0x180B5B800
	public void GetVerticesInGraphSpace(out Int3 v0, out Int3 v1, out Int3 v2) { }

	// RVA: 0xB5B6E0 Offset: 0xB5A0E0 VA: 0x180B5B6E0 Slot: 22
	public override Int3 GetVertex(int i) { }

	// RVA: 0xB5B5A0 Offset: 0xB59FA0 VA: 0x180B5B5A0
	public Int3 GetVertexInGraphSpace(int i) { }

	// RVA: 0x583670 Offset: 0x582070 VA: 0x180583670 Slot: 23
	public override int GetVertexCount() { }

	// RVA: 0xB5A720 Offset: 0xB59120 VA: 0x180B5A720 Slot: 16
	public override Vector3 ClosestPointOnNode(Vector3 p) { }

	// RVA: 0xB5A0D0 Offset: 0xB58AD0 VA: 0x180B5A0D0
	internal Int3 ClosestPointOnNodeXZInGraphSpace(Vector3 p) { }

	// RVA: 0xB5A590 Offset: 0xB58F90 VA: 0x180B5A590 Slot: 24
	public override Vector3 ClosestPointOnNodeXZ(Vector3 p) { }

	// RVA: 0xB5A9B0 Offset: 0xB593B0 VA: 0x180B5A9B0 Slot: 26
	public override bool ContainsPoint(Vector3 p) { }

	// RVA: 0xB5A8B0 Offset: 0xB592B0 VA: 0x180B5A8B0 Slot: 27
	public override bool ContainsPointInGraphSpace(Int3 p) { }

	// RVA: 0xB5C6E0 Offset: 0xB5B0E0 VA: 0x180B5C6E0 Slot: 4
	public override void UpdateRecursiveG(Path path, PathNode pathNode, PathHandler handler) { }

	// RVA: 0xB5BB10 Offset: 0xB5A510 VA: 0x180B5BB10 Slot: 13
	public override void Open(Path path, PathNode pathNode, PathHandler handler, bool useLoose = False) { }

	// RVA: 0xB5C390 Offset: 0xB5AD90 VA: 0x180B5C390
	public int SharedEdge(GraphNode other) { }

	// RVA: 0xB5AC20 Offset: 0xB59620 VA: 0x180B5AC20 Slot: 12
	public override bool GetPortal(GraphNode toNode, List<Vector3> left, List<Vector3> right, bool backwards) { }

	// RVA: 0xB5AC60 Offset: 0xB59660 VA: 0x180B5AC60
	public bool GetPortal(GraphNode toNode, List<Vector3> left, List<Vector3> right, bool backwards, out int aIndex, out int bIndex) { }

	// RVA: 0xB5C400 Offset: 0xB5AE00 VA: 0x180B5C400 Slot: 14
	public override float SurfaceArea() { }

	// RVA: 0xB5BD90 Offset: 0xB5A790 VA: 0x180B5BD90 Slot: 15
	public override Vector3 RandomPointOnSurface() { }

	// RVA: 0xB5C0D0 Offset: 0xB5AAD0 VA: 0x180B5C0D0 Slot: 18
	public override void SerializeNode(GraphSerializationContext ctx) { }

	// RVA: 0xB5AB20 Offset: 0xB59520 VA: 0x180B5AB20 Slot: 19
	public override void DeserializeNode(GraphSerializationContext ctx) { }

	// RVA: 0xB5C7F0 Offset: 0xB5B1F0 VA: 0x180B5C7F0
	private static void .cctor() { }
}
