public static class PathUtility // TypeDefIndex: 2221
{
	// Methods

	// RVA: 0x827B70 Offset: 0x826570 VA: 0x180827B70
	public static Vector3 GetAverageAheadPoint(PathSmoothingUtility.SmoothedPath path, Vector3 referencePoint, int sampleCount, float stepSize) { }

	// RVA: 0x827AC0 Offset: 0x8264C0 VA: 0x180827AC0
	public static Vector3 GetAheadPoint(PathSmoothingUtility.SmoothedPath path, Vector3 referencePoint, float distance) { }

	// RVA: 0x827A70 Offset: 0x826470 VA: 0x180827A70
	public static Vector3 GetAheadPoint(PathSmoothingUtility.SmoothedPath path, Vector3 referencePoint, float distance, int startPointIndex, float pointLerp) { }

	// RVA: 0x8283F0 Offset: 0x826DF0 VA: 0x1808283F0
	public static Vector3 GetPointAheadOfPathPoint(PathSmoothingUtility.SmoothedPath path, int startPointIndex, float pointLerp, float distanceAhead) { }

	// RVA: 0x827380 Offset: 0x825D80 VA: 0x180827380
	public static float CalculateAngleChangeOverPath(PathSmoothingUtility.SmoothedPath path, int startPointIndex, float pointLerp, float distanceAhead) { }

	// RVA: 0x827750 Offset: 0x826150 VA: 0x180827750
	public static float CalculateCTE(Vector3 flatCarPos, Transform vehicleTransform, Vector3 wp_from, Vector3 wp_to, PathSmoothingUtility.SmoothedPath path) { }

	// RVA: 0x827EB0 Offset: 0x8268B0 VA: 0x180827EB0
	public static Vector3 GetClosestPointOnPath(PathSmoothingUtility.SmoothedPath path, Vector3 point, out int startPointIndex, out int endPointIndex, out float pointLerp) { }

	// RVA: 0x827910 Offset: 0x826310 VA: 0x180827910
	public static Vector3 GetAheadPointDirection(PathSmoothingUtility.SmoothedPath path, Vector3 referencePoint, float distanceAhead) { }

	// RVA: 0x827D30 Offset: 0x826730 VA: 0x180827D30
	private static Vector3 GetClosestPointOnLine(Vector3 point, Vector3 line_start, Vector3 line_end, bool clamp = True) { }
}
