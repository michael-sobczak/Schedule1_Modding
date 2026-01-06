public class Funnel // TypeDefIndex: 13337
{
	// Methods

	// RVA: 0xB82A20 Offset: 0xB81420 VA: 0x180B82A20
	public static List<Funnel.PathPart> SplitIntoParts(Path path) { }

	// RVA: 0xB81E60 Offset: 0xB80860 VA: 0x180B81E60
	public static Funnel.FunnelPortals ConstructFunnelPortals(List<GraphNode> nodes, Funnel.PathPart part) { }

	// RVA: 0xB826A0 Offset: 0xB810A0 VA: 0x180B826A0
	public static void ShrinkPortals(Funnel.FunnelPortals portals, float shrink) { }

	// RVA: 0xB830C0 Offset: 0xB81AC0 VA: 0x180B830C0
	private static bool UnwrapHelper(Vector3 portalStart, Vector3 portalEnd, Vector3 prevPoint, Vector3 nextPoint, ref Quaternion mRot, ref Vector3 mOffset) { }

	// RVA: 0xB83580 Offset: 0xB81F80 VA: 0x180B83580
	public static void Unwrap(Funnel.FunnelPortals funnel, Vector2[] left, Vector2[] right) { }

	// RVA: 0xB82410 Offset: 0xB80E10 VA: 0x180B82410
	private static int FixFunnel(Vector2[] left, Vector2[] right, int numPortals) { }

	// RVA: 0x7BCB30 Offset: 0x7BB530 VA: 0x1807BCB30
	protected static Vector2 ToXZ(Vector3 p) { }

	// RVA: 0xB825F0 Offset: 0xB80FF0 VA: 0x180B825F0
	protected static Vector3 FromXZ(Vector2 p) { }

	// RVA: 0xB82660 Offset: 0xB81060 VA: 0x180B82660
	protected static bool RightOrColinear(Vector2 a, Vector2 b) { }

	// RVA: 0xB82620 Offset: 0xB81020 VA: 0x180B82620
	protected static bool LeftOrColinear(Vector2 a, Vector2 b) { }

	// RVA: 0xB81540 Offset: 0xB7FF40 VA: 0x180B81540
	public static List<Vector3> Calculate(Funnel.FunnelPortals funnel, bool unwrap, bool splitAtEveryPortal) { }

	// RVA: 0xB81030 Offset: 0xB7FA30 VA: 0x180B81030
	private static void Calculate(Vector2[] left, Vector2[] right, int numPortals, int startIndex, List<int> funnelPath, int maxCorners, out bool lastCorner) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
