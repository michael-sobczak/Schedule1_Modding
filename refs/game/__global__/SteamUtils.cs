public static class SteamUtils // TypeDefIndex: 14356
{
	// Methods

	// RVA: 0xCBBE00 Offset: 0xCBA800 VA: 0x180CBBE00
	public static uint GetSecondsSinceAppActive() { }

	// RVA: 0xCBBEB0 Offset: 0xCBA8B0 VA: 0x180CBBEB0
	public static uint GetSecondsSinceComputerActive() { }

	// RVA: 0xCBB690 Offset: 0xCBA090 VA: 0x180CBB690
	public static EUniverse GetConnectedUniverse() { }

	// RVA: 0xCBBF60 Offset: 0xCBA960 VA: 0x180CBBF60
	public static uint GetServerRealTime() { }

	// RVA: 0xCBBAB0 Offset: 0xCBA4B0 VA: 0x180CBBAB0
	public static string GetIPCountry() { }

	// RVA: 0xCBBD20 Offset: 0xCBA720 VA: 0x180CBBD20
	public static bool GetImageSize(int iImage, out uint pnWidth, out uint pnHeight) { }

	// RVA: 0xCBBC30 Offset: 0xCBA630 VA: 0x180CBBC30
	public static bool GetImageRGBA(int iImage, byte[] pubDest, int nDestBufferSize) { }

	// RVA: 0xCBB740 Offset: 0xCBA140 VA: 0x180CBB740
	public static byte GetCurrentBatteryPower() { }

	// RVA: 0xCBB5B0 Offset: 0xCB9FB0 VA: 0x180CBB5B0
	public static AppId_t GetAppID() { }

	// RVA: 0xCBC830 Offset: 0xCBB230 VA: 0x180CBC830
	public static void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition) { }

	// RVA: 0xCBC190 Offset: 0xCBAB90 VA: 0x180CBC190
	public static bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed) { }

	// RVA: 0xCBB3E0 Offset: 0xCB9DE0 VA: 0x180CBB3E0
	public static ESteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall) { }

	// RVA: 0xCBB4A0 Offset: 0xCB9EA0 VA: 0x180CBB4A0
	public static bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed) { }

	// RVA: 0xCBBA00 Offset: 0xCBA400 VA: 0x180CBBA00
	public static uint GetIPCCallCount() { }

	// RVA: 0xCBC9B0 Offset: 0xCBB3B0 VA: 0x180CBC9B0
	public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction) { }

	// RVA: 0xCBC280 Offset: 0xCBAC80 VA: 0x180CBC280
	public static bool IsOverlayEnabled() { }

	// RVA: 0xCBAD30 Offset: 0xCB9730 VA: 0x180CBAD30
	public static bool BOverlayNeedsPresent() { }

	// RVA: 0xCBADE0 Offset: 0xCB97E0 VA: 0x180CBADE0
	public static SteamAPICall_t CheckFileSignature(string szFileName) { }

	// RVA: 0xCBCB80 Offset: 0xCBB580 VA: 0x180CBCB80
	public static bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText) { }

	// RVA: 0xCBB950 Offset: 0xCBA350 VA: 0x180CBB950
	public static uint GetEnteredGamepadTextLength() { }

	// RVA: 0xCBB7F0 Offset: 0xCBA1F0 VA: 0x180CBB7F0
	public static bool GetEnteredGamepadTextInput(out string pchText, uint cchText) { }

	// RVA: 0xCBC010 Offset: 0xCBAA10 VA: 0x180CBC010
	public static string GetSteamUILanguage() { }

	// RVA: 0xCBC490 Offset: 0xCBAE90 VA: 0x180CBC490
	public static bool IsSteamRunningInVR() { }

	// RVA: 0xCBC760 Offset: 0xCBB160 VA: 0x180CBC760
	public static void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset) { }

	// RVA: 0xCBC3E0 Offset: 0xCBADE0 VA: 0x180CBC3E0
	public static bool IsSteamInBigPictureMode() { }

	// RVA: 0xCBCE70 Offset: 0xCBB870 VA: 0x180CBCE70
	public static void StartVRDashboard() { }

	// RVA: 0xCBC5F0 Offset: 0xCBAFF0 VA: 0x180CBC5F0
	public static bool IsVRHeadsetStreamingEnabled() { }

	// RVA: 0xCBC8F0 Offset: 0xCBB2F0 VA: 0x180CBC8F0
	public static void SetVRHeadsetStreamingEnabled(bool bEnabled) { }

	// RVA: 0xCBC330 Offset: 0xCBAD30 VA: 0x180CBC330
	public static bool IsSteamChinaLauncher() { }

	// RVA: 0xCBC0D0 Offset: 0xCBAAD0 VA: 0x180CBC0D0
	public static bool InitFilterText(uint unFilterOptions = 0) { }

	// RVA: 0xCBB160 Offset: 0xCB9B60 VA: 0x180CBB160
	public static int FilterText(ETextFilteringContext eContext, CSteamID sourceSteamID, string pchInputMessage, out string pchOutFilteredText, uint nByteSizeOutFilteredText) { }

	// RVA: 0xCBBB70 Offset: 0xCBA570 VA: 0x180CBBB70
	public static ESteamIPv6ConnectivityState GetIPv6ConnectivityState(ESteamIPv6ConnectivityProtocol eProtocol) { }

	// RVA: 0xCBC540 Offset: 0xCBAF40 VA: 0x180CBC540
	public static bool IsSteamRunningOnSteamDeck() { }

	// RVA: 0xCBCA80 Offset: 0xCBB480 VA: 0x180CBCA80
	public static bool ShowFloatingGamepadTextInput(EFloatingGamepadTextInputMode eKeyboardMode, int nTextFieldXPosition, int nTextFieldYPosition, int nTextFieldWidth, int nTextFieldHeight) { }

	// RVA: 0xCBC6A0 Offset: 0xCBB0A0 VA: 0x180CBC6A0
	public static void SetGameLauncherMode(bool bLauncherMode) { }

	// RVA: 0xCBB000 Offset: 0xCB9A00 VA: 0x180CBB000
	public static bool DismissFloatingGamepadTextInput() { }

	// RVA: 0xCBB0B0 Offset: 0xCB9AB0 VA: 0x180CBB0B0
	public static bool DismissGamepadTextInput() { }
}
