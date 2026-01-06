public class AstarProfiler // TypeDefIndex: 13333
{
	// Fields
	private static readonly Dictionary<string, AstarProfiler.ProfilePoint> profiles; // 0x0
	private static DateTime startTime; // 0x8
	public static AstarProfiler.ProfilePoint[] fastProfiles; // 0x10
	public static string[] fastProfileNames; // 0x18

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	private void .ctor() { }

	[Conditional("ProfileAstar")]
	// RVA: 0xB7BA70 Offset: 0xB7A470 VA: 0x180B7BA70
	public static void InitializeFastProfile(string[] profileNames) { }

	[Conditional("ProfileAstar")]
	// RVA: 0xB7CE10 Offset: 0xB7B810 VA: 0x180B7CE10
	public static void StartFastProfile(int tag) { }

	[Conditional("ProfileAstar")]
	// RVA: 0xB7B840 Offset: 0xB7A240 VA: 0x180B7B840
	public static void EndFastProfile(int tag) { }

	[Conditional("ASTAR_UNITY_PRO_PROFILER")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public static void EndProfile() { }

	[Conditional("ProfileAstar")]
	// RVA: 0xB7CEA0 Offset: 0xB7B8A0 VA: 0x180B7CEA0
	public static void StartProfile(string tag) { }

	[Conditional("ProfileAstar")]
	// RVA: 0xB7B8D0 Offset: 0xB7A2D0 VA: 0x180B7B8D0
	public static void EndProfile(string tag) { }

	[Conditional("ProfileAstar")]
	// RVA: 0xB7CBE0 Offset: 0xB7B5E0 VA: 0x180B7CBE0
	public static void Reset() { }

	[Conditional("ProfileAstar")]
	// RVA: 0xB7BD90 Offset: 0xB7A790 VA: 0x180B7BD90
	public static void PrintFastResults() { }

	[Conditional("ProfileAstar")]
	// RVA: 0xB7C380 Offset: 0xB7AD80 VA: 0x180B7C380
	public static void PrintResults() { }

	// RVA: 0xB7D060 Offset: 0xB7BA60 VA: 0x180B7D060
	private static void .cctor() { }
}
