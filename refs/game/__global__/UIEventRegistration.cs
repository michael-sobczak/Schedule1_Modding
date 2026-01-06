internal static class UIEventRegistration // TypeDefIndex: 6931
{
	// Fields
	private static List<IUIElementsUtility> s_Utilities; // 0x0

	// Methods

	// RVA: 0x2DEAB70 Offset: 0x2DE9570 VA: 0x182DEAB70
	private static void .cctor() { }

	// RVA: 0x2DEA830 Offset: 0x2DE9230 VA: 0x182DEA830
	internal static void RegisterUIElementSystem(IUIElementsUtility utility) { }

	// RVA: 0x2DEAA10 Offset: 0x2DE9410 VA: 0x182DEAA10
	private static void TakeCapture() { }

	// RVA: 0x2DEA8B0 Offset: 0x2DE92B0 VA: 0x182DEA8B0
	private static void ReleaseCapture() { }

	// RVA: 0x2DEA280 Offset: 0x2DE8C80 VA: 0x182DEA280
	private static bool EndContainerGUIFromException(Exception exception) { }

	// RVA: 0x2DEA620 Offset: 0x2DE9020 VA: 0x182DEA620
	private static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr) { }

	// RVA: 0x2DEA120 Offset: 0x2DE8B20 VA: 0x182DEA120
	private static void CleanupRoots() { }

	// RVA: 0x2DEA4C0 Offset: 0x2DE8EC0 VA: 0x182DEA4C0
	internal static void MakeCurrentIMGUIContainerDirty() { }
}
