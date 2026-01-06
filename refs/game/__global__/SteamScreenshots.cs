public static class SteamScreenshots // TypeDefIndex: 14351
{
	// Methods

	// RVA: 0xC76A80 Offset: 0xC75480 VA: 0x180C76A80
	public static ScreenshotHandle WriteScreenshot(byte[] pubRGB, uint cubRGB, int nWidth, int nHeight) { }

	// RVA: 0xC763D0 Offset: 0xC74DD0 VA: 0x180C763D0
	public static ScreenshotHandle AddScreenshotToLibrary(string pchFilename, string pchThumbnailFilename, int nWidth, int nHeight) { }

	// RVA: 0xC76A30 Offset: 0xC75430 VA: 0x180C76A30
	public static void TriggerScreenshot() { }

	// RVA: 0xC767B0 Offset: 0xC751B0 VA: 0x180C767B0
	public static void HookScreenshots(bool bHook) { }

	// RVA: 0xC76850 Offset: 0xC75250 VA: 0x180C76850
	public static bool SetLocation(ScreenshotHandle hScreenshot, string pchLocation) { }

	// RVA: 0xC769D0 Offset: 0xC753D0 VA: 0x180C769D0
	public static bool TagUser(ScreenshotHandle hScreenshot, CSteamID steamID) { }

	// RVA: 0xC76970 Offset: 0xC75370 VA: 0x180C76970
	public static bool TagPublishedFile(ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID) { }

	// RVA: 0xC76800 Offset: 0xC75200 VA: 0x180C76800
	public static bool IsScreenshotsHooked() { }

	// RVA: 0xC765C0 Offset: 0xC74FC0 VA: 0x180C765C0
	public static ScreenshotHandle AddVRScreenshotToLibrary(EVRScreenshotType eType, string pchFilename, string pchVRFilename) { }
}
