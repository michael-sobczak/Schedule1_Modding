public static class Vector2Ex // TypeDefIndex: 18795
{
	// Methods

	[Extension]
	// RVA: 0x453A70 Offset: 0x452470 VA: 0x180453A70
	public static float Cross(Vector2 O, Vector2 A, Vector2 B) { }

	[Extension]
	// RVA: 0x454630 Offset: 0x453030 VA: 0x180454630
	public static float TriangleArea(Vector2 O, Vector2 A, Vector2 B) { }

	[Extension]
	// RVA: 0x4546A0 Offset: 0x4530A0 VA: 0x1804546A0
	public static float TriangleArea(Vector3 O, Vector3 A, Vector3 B) { }

	// RVA: 0x4536C0 Offset: 0x4520C0 VA: 0x1804536C0
	public static Vector2[] ConvexHull(Vector2[] P) { }

	// RVA: 0x454420 Offset: 0x452E20 VA: 0x180454420
	public static Vector2[] ScaleAlongNormals(Vector2[] P, float scaleAmount) { }

	// RVA: 0x453D70 Offset: 0x452770 VA: 0x180453D70
	private static Vector2[] ReduceLeastSignificantVertice(Vector2[] P) { }

	// RVA: 0x454200 Offset: 0x452C00 VA: 0x180454200
	public static Vector2[] ReduceVertices(Vector2[] P, int maxVertices) { }

	// RVA: 0x453AD0 Offset: 0x4524D0 VA: 0x180453AD0
	private static Vector2 GetIntersectionPointCoordinates(Vector2 A1, Vector2 A2, Vector2 B1, Vector2 B2) { }

	// RVA: 0x453CB0 Offset: 0x4526B0 VA: 0x180453CB0
	private static float OutsideBounds(Vector2 P) { }
}
