public class PathSmoothingUtility : MonoBehaviour // TypeDefIndex: 1179
{
	// Fields
	public const float MinControlPointDistance = 0.5;
	private static CurvySpline spline; // 0x0

	// Methods

	// RVA: 0x608440 Offset: 0x606E40 VA: 0x180608440
	private void Awake() { }

	// RVA: 0x608580 Offset: 0x606F80 VA: 0x180608580
	public static PathSmoothingUtility.SmoothedPath CalculateSmoothedPath(List<Vector3> controlPoints, float maxCPDistance = 5) { }

	// RVA: 0x608900 Offset: 0x607300 VA: 0x180608900
	public static void DrawPath(PathSmoothingUtility.SmoothedPath path, Color col, float duration) { }

	// RVA: 0x608A60 Offset: 0x607460 VA: 0x180608A60
	private static List<Vector3> InsertIntermediatePoints(List<Vector3> points, float maxDistance) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
