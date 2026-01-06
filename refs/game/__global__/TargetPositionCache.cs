internal class TargetPositionCache // TypeDefIndex: 16189
{
	// Fields
	public static bool UseCache; // 0x0
	public const float CacheStepSize = 0.016666668;
	private static TargetPositionCache.Mode m_CacheMode; // 0x4
	public static float CurrentTime; // 0x8
	public static int CurrentFrame; // 0xC
	public static bool IsCameraCut; // 0x10
	private static Dictionary<Transform, TargetPositionCache.CacheEntry> m_Cache; // 0x18
	private static TargetPositionCache.TimeRange m_CacheTimeRange; // 0x20
	private const float kWraparoundSlush = 0.1;

	// Properties
	public static TargetPositionCache.Mode CacheMode { get; set; }
	public static bool IsRecording { get; }
	public static bool CurrentPlaybackTimeValid { get; }
	public static bool IsEmpty { get; }
	public static TargetPositionCache.TimeRange CacheTimeRange { get; }
	public static bool HasCurrentTime { get; }

	// Methods

	// RVA: 0xC26A60 Offset: 0xC25460 VA: 0x180C26A60
	public static TargetPositionCache.Mode get_CacheMode() { }

	// RVA: 0xC26C60 Offset: 0xC25660 VA: 0x180C26C60
	public static void set_CacheMode(TargetPositionCache.Mode value) { }

	// RVA: 0xC26C10 Offset: 0xC25610 VA: 0x180C26C10
	public static bool get_IsRecording() { }

	// RVA: 0xC26AF0 Offset: 0xC254F0 VA: 0x180C26AF0
	public static bool get_CurrentPlaybackTimeValid() { }

	// RVA: 0xC26BD0 Offset: 0xC255D0 VA: 0x180C26BD0
	public static bool get_IsEmpty() { }

	// RVA: 0xC26AA0 Offset: 0xC254A0 VA: 0x180C26AA0
	public static TargetPositionCache.TimeRange get_CacheTimeRange() { }

	// RVA: 0xC26B80 Offset: 0xC25580 VA: 0x180C26B80
	public static bool get_HasCurrentTime() { }

	// RVA: 0xC26160 Offset: 0xC24B60 VA: 0x180C26160
	public static void ClearCache() { }

	// RVA: 0xC26280 Offset: 0xC24C80 VA: 0x180C26280
	private static void CreatePlaybackCurves() { }

	// RVA: 0xC263F0 Offset: 0xC24DF0 VA: 0x180C263F0
	public static Vector3 GetTargetPosition(Transform target) { }

	// RVA: 0xC26710 Offset: 0xC25110 VA: 0x180C26710
	public static Quaternion GetTargetRotation(Transform target) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
