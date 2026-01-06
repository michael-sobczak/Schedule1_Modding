public class NavigationUtility // TypeDefIndex: 2216
{
	// Fields
	public const float ROAD_MULTIPLIER = 1;
	public const float OFFROAD_MULTIPLIER = 3;

	// Methods

	// RVA: 0x826670 Offset: 0x825070 VA: 0x180826670
	public static Coroutine CalculatePath(Vector3 startPosition, Vector3 destination, NavigationSettings navSettings, DriveFlags flags, Seeker generalSeeker, Seeker roadSeeker, NavigationUtility.NavigationCalculationCallback callback) { }

	// RVA: 0x825E50 Offset: 0x824850 VA: 0x180825E50
	private static void AdjustExitPoint(PathGroup group) { }

	// RVA: 0x825B00 Offset: 0x824500 VA: 0x180825B00
	private static void AdjustEntryPoint(PathGroup group) { }

	// RVA: 0x826820 Offset: 0x825220 VA: 0x180826820
	private static bool DoesCloseDistanceExist(List<Vector3> vectorList, Vector3 point, float thresholdDistance) { }

	[IteratorStateMachine(typeof(NavigationUtility.<GenerateNavigationGroup>d__9))]
	// RVA: 0x826E50 Offset: 0x825850 VA: 0x180826E50
	private static IEnumerator GenerateNavigationGroup(Vector3 startPoint, Vector3 entryPoint, NodeLink exitLink, Vector3 exitPoint, Vector3 destination, Seeker generalSeeker, Seeker roadSeeker, NavigationUtility.PathGroupEvent callback) { }

	// RVA: 0x826A30 Offset: 0x825430 VA: 0x180826A30
	public static void DrawPath(PathGroup group, float duration = 10) { }

	// RVA: 0x827090 Offset: 0x825A90 VA: 0x180827090
	private static PathSmoothingUtility.SmoothedPath GetSmoothedPath(PathGroup group) { }

	// RVA: 0x827190 Offset: 0x825B90 VA: 0x180827190
	public static Vector3 SampleVehicleGraph(Vector3 destination) { }

	// RVA: 0x826F60 Offset: 0x825960 VA: 0x180826F60
	public static Vector3 GetClosestPointOnFiniteLine(Vector3 point, Vector3 line_start, Vector3 line_end) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
