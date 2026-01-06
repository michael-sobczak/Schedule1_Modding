public static class SplineHelpers // TypeDefIndex: 16266
{
	// Methods

	// RVA: 0xC4AEB0 Offset: 0xC498B0 VA: 0x180C4AEB0
	public static Vector3 Bezier3(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3) { }

	// RVA: 0xC4B120 Offset: 0xC49B20 VA: 0x180C4B120
	public static Vector3 BezierTangent3(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3) { }

	// RVA: 0xC4B450 Offset: 0xC49E50 VA: 0x180C4B450
	public static void BezierTangentWeights3(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, out Vector3 w0, out Vector3 w1, out Vector3 w2) { }

	// RVA: 0xC4AE10 Offset: 0xC49810 VA: 0x180C4AE10
	public static float Bezier1(float t, float p0, float p1, float p2, float p3) { }

	// RVA: 0xC4B040 Offset: 0xC49A40 VA: 0x180C4B040
	public static float BezierTangent1(float t, float p0, float p1, float p2, float p3) { }

	// RVA: 0xC4B9A0 Offset: 0xC4A3A0 VA: 0x180C4B9A0
	public static void ComputeSmoothControlPoints(ref Vector4[] knot, ref Vector4[] ctrl1, ref Vector4[] ctrl2) { }

	// RVA: 0xC4B650 Offset: 0xC4A050 VA: 0x180C4B650
	public static void ComputeSmoothControlPointsLooped(ref Vector4[] knot, ref Vector4[] ctrl1, ref Vector4[] ctrl2) { }
}
