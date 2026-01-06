public static class EnhancedTouchSupport // TypeDefIndex: 7569
{
	// Fields
	private static int s_Enabled; // 0x0
	private static InputSettings.UpdateMode s_UpdateMode; // 0x4

	// Properties
	public static bool enabled { get; }

	// Methods

	// RVA: 0x2858A90 Offset: 0x2857490 VA: 0x182858A90
	public static bool get_enabled() { }

	// RVA: 0x2858270 Offset: 0x2856C70 VA: 0x182858270
	public static void Enable() { }

	// RVA: 0x28580F0 Offset: 0x2856AF0 VA: 0x1828580F0
	public static void Disable() { }

	// RVA: 0x2858680 Offset: 0x2857080 VA: 0x182858680
	internal static void Reset() { }

	// RVA: 0x2858740 Offset: 0x2857140 VA: 0x182858740
	private static void SetUpState() { }

	// RVA: 0x28588F0 Offset: 0x28572F0 VA: 0x1828588F0
	internal static void TearDownState() { }

	// RVA: 0x28583C0 Offset: 0x2856DC0 VA: 0x1828583C0
	private static void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	// RVA: 0x2858600 Offset: 0x2857000 VA: 0x182858600
	private static void OnSettingsChange() { }

	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	// RVA: 0x2858060 Offset: 0x2856A60 VA: 0x182858060
	internal static void CheckEnabled() { }
}
