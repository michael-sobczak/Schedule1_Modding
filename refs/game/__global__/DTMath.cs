public static class DTMath // TypeDefIndex: 10406
{
	// Methods

	// RVA: 0x48D410 Offset: 0x48BE10 VA: 0x18048D410
	public static Vector3 ParallelTransportFrame(Vector3 up, Vector3 tan0, Vector3 tan1) { }

	// RVA: 0x48CE80 Offset: 0x48B880 VA: 0x18048CE80
	public static Vector3 LeftTan(ref Vector3 tan, ref Vector3 up) { }

	// RVA: 0x48DAD0 Offset: 0x48C4D0 VA: 0x18048DAD0
	public static Vector3 RightTan(ref Vector3 tan, ref Vector3 up) { }

	// RVA: 0x48DA90 Offset: 0x48C490 VA: 0x18048DA90
	public static float Repeat(float t, float length) { }

	// RVA: 0x48CE50 Offset: 0x48B850 VA: 0x18048CE50
	public static double FixNaN(double v) { }

	// RVA: 0x48CD90 Offset: 0x48B790 VA: 0x18048CD90
	public static float FixNaN(float v) { }

	// RVA: 0x48CE00 Offset: 0x48B800 VA: 0x18048CE00
	public static Vector2 FixNaN(Vector2 v) { }

	// RVA: 0x48CDB0 Offset: 0x48B7B0 VA: 0x18048CDB0
	public static Vector3 FixNaN(Vector3 v) { }

	// RVA: 0x48D3E0 Offset: 0x48BDE0 VA: 0x18048D3E0
	public static float MapValue(float min, float max, float value, float vMin = -1, float vMax = 1) { }

	// RVA: 0x48E040 Offset: 0x48CA40 VA: 0x18048E040
	public static float SnapPrecision(float value, int decimals) { }

	// RVA: 0x48E0F0 Offset: 0x48CAF0 VA: 0x18048E0F0
	public static Vector2 SnapPrecision(Vector2 value, int decimals) { }

	// RVA: 0x48E150 Offset: 0x48CB50 VA: 0x18048E150
	public static Vector3 SnapPrecision(Vector3 value, int decimals) { }

	// RVA: 0x48D250 Offset: 0x48BC50 VA: 0x18048D250
	public static float LinePointDistanceSqr(Vector3 l1, Vector3 l2, Vector3 p, out float frag) { }

	// RVA: 0x48D8E0 Offset: 0x48C2E0 VA: 0x18048D8E0
	public static bool RayLineSegmentIntersection(Vector2 r0, Vector2 dir, Vector2 l1, Vector2 l2, out Vector2 hit, out float frag) { }

	// RVA: 0x48DB60 Offset: 0x48C560 VA: 0x18048DB60
	public static bool ShortestIntersectionLine(Vector3 line1A, Vector3 line1B, Vector3 line2A, Vector3 line2B, out Vector3 resultSegmentA, out Vector3 resultSegmentB) { }

	// RVA: 0x48D100 Offset: 0x48BB00 VA: 0x18048D100
	public static bool LineLineIntersection(Vector3 line1A, Vector3 line1B, Vector3 line2A, Vector3 line2B, out Vector3 hitPoint) { }

	// RVA: 0x48CF10 Offset: 0x48B910 VA: 0x18048CF10
	public static bool LineLineIntersect(Vector2 line1A, Vector2 line1B, Vector2 line2A, Vector2 line2B, out Vector2 hitPoint, bool segmentOnly = True) { }

	// RVA: 0x48D6B0 Offset: 0x48C0B0 VA: 0x18048D6B0
	public static bool PointInsideTriangle(Vector3 A, Vector3 B, Vector3 C, Vector3 p, out float ac, out float ab, bool edgesAllowed) { }
}
