internal static class Geom // TypeDefIndex: 10784
{
	// Methods

	// RVA: 0x532270 Offset: 0x530C70 VA: 0x180532270
	public static bool IsWindingInside(WindingRule rule, int n) { }

	// RVA: 0x5324D0 Offset: 0x530ED0 VA: 0x1805324D0
	public static bool VertCCW(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w) { }

	// RVA: 0x532530 Offset: 0x530F30 VA: 0x180532530
	public static bool VertEq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs) { }

	// RVA: 0x532610 Offset: 0x531010 VA: 0x180532610
	public static bool VertLeq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs) { }

	// RVA: 0x531750 Offset: 0x530150 VA: 0x180531750
	public static float EdgeEval(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w) { }

	// RVA: 0x5321A0 Offset: 0x530BA0 VA: 0x1805321A0
	public static float EdgeSign(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w) { }

	// RVA: 0x532410 Offset: 0x530E10 VA: 0x180532410
	public static bool TransLeq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs) { }

	// RVA: 0x532360 Offset: 0x530D60 VA: 0x180532360
	public static float TransEval(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w) { }

	// RVA: 0x532460 Offset: 0x530E60 VA: 0x180532460
	public static float TransSign(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w) { }

	// RVA: 0x531800 Offset: 0x530200 VA: 0x180531800
	public static bool EdgeGoesLeft(MeshUtils.Edge e) { }

	// RVA: 0x531870 Offset: 0x530270 VA: 0x180531870
	public static bool EdgeGoesRight(MeshUtils.Edge e) { }

	// RVA: 0x532570 Offset: 0x530F70 VA: 0x180532570
	public static float VertL1dist(MeshUtils.Vertex u, MeshUtils.Vertex v) { }

	// RVA: 0x531710 Offset: 0x530110 VA: 0x180531710
	public static void AddWinding(MeshUtils.Edge eDst, MeshUtils.Edge eSrc) { }

	// RVA: 0x532210 Offset: 0x530C10 VA: 0x180532210
	public static float Interpolate(float a, float x, float b, float y) { }

	// RVA: 0x532320 Offset: 0x530D20 VA: 0x180532320
	private static void Swap(ref MeshUtils.Vertex a, ref MeshUtils.Vertex b) { }

	// RVA: 0x5318E0 Offset: 0x5302E0 VA: 0x1805318E0
	public static void EdgeIntersect(MeshUtils.Vertex o1, MeshUtils.Vertex d1, MeshUtils.Vertex o2, MeshUtils.Vertex d2, MeshUtils.Vertex v) { }
}
