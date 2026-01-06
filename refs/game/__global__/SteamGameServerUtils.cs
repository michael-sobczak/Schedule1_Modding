public static class SteamGameServerUtils // TypeDefIndex: 14333
{
	// Methods

	// RVA: 0xC639A0 Offset: 0xC623A0 VA: 0x180C639A0
	public static uint GetSecondsSinceAppActive() { }

	// RVA: 0xC639F0 Offset: 0xC623F0 VA: 0x180C639F0
	public static uint GetSecondsSinceComputerActive() { }

	// RVA: 0xC635D0 Offset: 0xC61FD0 VA: 0x180C635D0
	public static EUniverse GetConnectedUniverse() { }

	// RVA: 0xC63A40 Offset: 0xC62440 VA: 0x180C63A40
	public static uint GetServerRealTime() { }

	// RVA: 0xC63800 Offset: 0xC62200 VA: 0x180C63800
	public static string GetIPCountry() { }

	// RVA: 0xC63920 Offset: 0xC62320 VA: 0x180C63920
	public static bool GetImageSize(int iImage, out uint pnWidth, out uint pnHeight) { }

	// RVA: 0xC638A0 Offset: 0xC622A0 VA: 0x180C638A0
	public static bool GetImageRGBA(int iImage, byte[] pubDest, int nDestBufferSize) { }

	// RVA: 0xC63620 Offset: 0xC62020 VA: 0x180C63620
	public static byte GetCurrentBatteryPower() { }

	// RVA: 0xC63540 Offset: 0xC61F40 VA: 0x180C63540
	public static AppId_t GetAppID() { }

	// RVA: 0xC63E20 Offset: 0xC62820 VA: 0x180C63E20
	public static void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition) { }

	// RVA: 0xC63B30 Offset: 0xC62530 VA: 0x180C63B30
	public static bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed) { }

	// RVA: 0xC63460 Offset: 0xC61E60 VA: 0x180C63460
	public static ESteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall) { }

	// RVA: 0xC634B0 Offset: 0xC61EB0 VA: 0x180C634B0
	public static bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed) { }

	// RVA: 0xC637B0 Offset: 0xC621B0 VA: 0x180C637B0
	public static uint GetIPCCallCount() { }

	// RVA: 0xC63EC0 Offset: 0xC628C0 VA: 0x180C63EC0
	public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction) { }

	// RVA: 0xC63B90 Offset: 0xC62590 VA: 0x180C63B90
	public static bool IsOverlayEnabled() { }

	// RVA: 0xC63070 Offset: 0xC61A70 VA: 0x180C63070
	public static bool BOverlayNeedsPresent() { }

	// RVA: 0xC630C0 Offset: 0xC61AC0 VA: 0x180C630C0
	public static SteamAPICall_t CheckFileSignature(string szFileName) { }

	// RVA: 0xC63FA0 Offset: 0xC629A0 VA: 0x180C63FA0
	public static bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText) { }

	// RVA: 0xC63760 Offset: 0xC62160 VA: 0x180C63760
	public static uint GetEnteredGamepadTextLength() { }

	// RVA: 0xC63670 Offset: 0xC62070 VA: 0x180C63670
	public static bool GetEnteredGamepadTextInput(out string pchText, uint cchText) { }

	// RVA: 0xC63A90 Offset: 0xC62490 VA: 0x180C63A90
	public static string GetSteamUILanguage() { }

	// RVA: 0xC63C80 Offset: 0xC62680 VA: 0x180C63C80
	public static bool IsSteamRunningInVR() { }

	// RVA: 0xC63DC0 Offset: 0xC627C0 VA: 0x180C63DC0
	public static void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset) { }

	// RVA: 0xC63C30 Offset: 0xC62630 VA: 0x180C63C30
	public static bool IsSteamInBigPictureMode() { }

	// RVA: 0xC64180 Offset: 0xC62B80 VA: 0x180C64180
	public static void StartVRDashboard() { }

	// RVA: 0xC63D20 Offset: 0xC62720 VA: 0x180C63D20
	public static bool IsVRHeadsetStreamingEnabled() { }

	// RVA: 0xC63E70 Offset: 0xC62870 VA: 0x180C63E70
	public static void SetVRHeadsetStreamingEnabled(bool bEnabled) { }

	// RVA: 0xC63BE0 Offset: 0xC625E0 VA: 0x180C63BE0
	public static bool IsSteamChinaLauncher() { }

	// RVA: 0xC63AE0 Offset: 0xC624E0 VA: 0x180C63AE0
	public static bool InitFilterText(uint unFilterOptions = 0) { }

	// RVA: 0xC632A0 Offset: 0xC61CA0 VA: 0x180C632A0
	public static int FilterText(ETextFilteringContext eContext, CSteamID sourceSteamID, string pchInputMessage, out string pchOutFilteredText, uint nByteSizeOutFilteredText) { }

	// RVA: 0xC63850 Offset: 0xC62250 VA: 0x180C63850
	public static ESteamIPv6ConnectivityState GetIPv6ConnectivityState(ESteamIPv6ConnectivityProtocol eProtocol) { }

	// RVA: 0xC63CD0 Offset: 0xC626D0 VA: 0x180C63CD0
	public static bool IsSteamRunningOnSteamDeck() { }

	// RVA: 0xC63F10 Offset: 0xC62910 VA: 0x180C63F10
	public static bool ShowFloatingGamepadTextInput(EFloatingGamepadTextInputMode eKeyboardMode, int nTextFieldXPosition, int nTextFieldYPosition, int nTextFieldWidth, int nTextFieldHeight) { }

	// RVA: 0xC63D70 Offset: 0xC62770 VA: 0x180C63D70
	public static void SetGameLauncherMode(bool bLauncherMode) { }

	// RVA: 0xC63200 Offset: 0xC61C00 VA: 0x180C63200
	public static bool DismissFloatingGamepadTextInput() { }

	// RVA: 0xC63250 Offset: 0xC61C50 VA: 0x180C63250
	public static bool DismissGamepadTextInput() { }
}
