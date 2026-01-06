public static class CurvyUtility // TypeDefIndex: 10566
{
	// Methods

	// RVA: 0x4D0610 Offset: 0x4CF010 VA: 0x1804D0610
	public static float ClampTF(float tf, CurvyClamping clamping) { }

	// RVA: 0x4D0500 Offset: 0x4CEF00 VA: 0x1804D0500
	public static float ClampTF(float tf, ref int dir, CurvyClamping clamping) { }

	// RVA: 0x4D0700 Offset: 0x4CF100 VA: 0x1804D0700
	public static float ClampValue(float tf, CurvyClamping clamping, float minTF, float maxTF) { }

	// RVA: 0x4D0360 Offset: 0x4CED60 VA: 0x1804D0360
	public static float ClampDistance(float distance, CurvyClamping clamping, float length) { }

	// RVA: 0x4D01D0 Offset: 0x4CEBD0 VA: 0x1804D01D0
	public static float ClampDistance(float distance, CurvyClamping clamping, float length, float min, float max) { }

	// RVA: 0x4D0400 Offset: 0x4CEE00 VA: 0x1804D0400
	public static float ClampDistance(float distance, ref int dir, CurvyClamping clamping, float length) { }

	// RVA: 0x4D0010 Offset: 0x4CEA10 VA: 0x1804D0010
	public static float ClampDistance(float distance, ref int dir, CurvyClamping clamping, float length, float min, float max) { }

	// RVA: 0x4D08E0 Offset: 0x4CF2E0 VA: 0x1804D08E0
	public static Material GetDefaultMaterial() { }

	[Extension]
	// RVA: 0x4CFEE0 Offset: 0x4CE8E0 VA: 0x1804CFEE0
	public static bool Approximately(float x, float y) { }

	// RVA: 0x4D0EA0 Offset: 0x4CF8A0 VA: 0x1804D0EA0
	public static int InterpolationSearch(float[] array, float x) { }

	// RVA: 0x4D0CA0 Offset: 0x4CF6A0 VA: 0x1804D0CA0
	public static int InterpolationSearch(float[] array, int elementsCount, float x) { }

	[Extension]
	// RVA: 0x4D0ED0 Offset: 0x4CF8D0 VA: 0x1804D0ED0
	public static Mesh SplineToMesh(CurvySpline spline) { }

	// RVA: 0x4D0A50 Offset: 0x4CF450 VA: 0x1804D0A50
	public static void GetNearestPointIndex(Vector3 point, Vector3[] points, int pointsCount, out int index, out float fragement) { }
}
