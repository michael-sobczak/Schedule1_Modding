internal static class PointerDeviceState // TypeDefIndex: 6617
{
	// Fields
	private static PointerDeviceState.PointerLocation[] s_PlayerPointerLocations; // 0x0
	private static int[] s_PressedButtons; // 0x8
	private static readonly IPanel[] s_PlayerPanelWithSoftPointerCapture; // 0x10

	// Methods

	// RVA: 0x2EB1860 Offset: 0x2EB0260 VA: 0x182EB1860
	internal static void RemovePanelData(IPanel panel) { }

	// RVA: 0x2EB1A80 Offset: 0x2EB0480 VA: 0x182EB1A80
	public static void SavePointerPosition(int pointerId, Vector2 position, IPanel panel, ContextType contextType) { }

	// RVA: 0x2EB1640 Offset: 0x2EB0040 VA: 0x182EB1640
	public static void PressButton(int pointerId, int buttonId) { }

	// RVA: 0x2EB1790 Offset: 0x2EB0190 VA: 0x182EB1790
	public static void ReleaseButton(int pointerId, int buttonId) { }

	// RVA: 0x2EB1710 Offset: 0x2EB0110 VA: 0x182EB1710
	public static void ReleaseAllButtons(int pointerId) { }

	// RVA: 0x2EB1410 Offset: 0x2EAFE10 VA: 0x182EB1410
	public static Vector2 GetPointerPosition(int pointerId, ContextType contextType) { }

	// RVA: 0x2EB1320 Offset: 0x2EAFD20 VA: 0x182EB1320
	public static IPanel GetPanel(int pointerId, ContextType contextType) { }

	// RVA: 0x2EB15A0 Offset: 0x2EAFFA0 VA: 0x182EB15A0
	private static bool HasFlagFast(PointerDeviceState.LocationFlag flagSet, PointerDeviceState.LocationFlag flag) { }

	// RVA: 0x2EB15B0 Offset: 0x2EAFFB0 VA: 0x182EB15B0
	public static bool HasLocationFlag(int pointerId, ContextType contextType, PointerDeviceState.LocationFlag flag) { }

	// RVA: 0x2EB14A0 Offset: 0x2EAFEA0 VA: 0x182EB14A0
	public static int GetPressedButtons(int pointerId) { }

	// RVA: 0x2EB1510 Offset: 0x2EAFF10 VA: 0x182EB1510
	internal static bool HasAdditionalPressedButtons(int pointerId, int exceptButtonId) { }

	// RVA: 0x2EB1B30 Offset: 0x2EB0530 VA: 0x182EB1B30
	internal static void SetPlayerPanelWithSoftPointerCapture(int pointerId, IPanel panel) { }

	// RVA: 0x2EB13A0 Offset: 0x2EAFDA0 VA: 0x182EB13A0
	internal static IPanel GetPlayerPanelWithSoftPointerCapture(int pointerId) { }

	// RVA: 0x2EB1BF0 Offset: 0x2EB05F0 VA: 0x182EB1BF0
	private static void .cctor() { }
}
