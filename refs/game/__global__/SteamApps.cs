public static class SteamApps // TypeDefIndex: 14320
{
	// Methods

	// RVA: 0xC4F460 Offset: 0xC4DE60 VA: 0x180C4F460
	public static bool BIsSubscribed() { }

	// RVA: 0xC4F320 Offset: 0xC4DD20 VA: 0x180C4F320
	public static bool BIsLowViolence() { }

	// RVA: 0xC4F280 Offset: 0xC4DC80 VA: 0x180C4F280
	public static bool BIsCybercafe() { }

	// RVA: 0xC4F510 Offset: 0xC4DF10 VA: 0x180C4F510
	public static bool BIsVACBanned() { }

	// RVA: 0xC4FA20 Offset: 0xC4E420 VA: 0x180C4FA20
	public static string GetCurrentGameLanguage() { }

	// RVA: 0xC4F750 Offset: 0xC4E150 VA: 0x180C4F750
	public static string GetAvailableGameLanguages() { }

	// RVA: 0xC4F370 Offset: 0xC4DD70 VA: 0x180C4F370
	public static bool BIsSubscribedApp(AppId_t appID) { }

	// RVA: 0xC4F2D0 Offset: 0xC4DCD0 VA: 0x180C4F2D0
	public static bool BIsDlcInstalled(AppId_t appID) { }

	// RVA: 0xC4FB40 Offset: 0xC4E540 VA: 0x180C4FB40
	public static uint GetEarliestPurchaseUnixTime(AppId_t nAppID) { }

	// RVA: 0xC4F410 Offset: 0xC4DE10 VA: 0x180C4F410
	public static bool BIsSubscribedFromFreeWeekend() { }

	// RVA: 0xC4FA70 Offset: 0xC4E470 VA: 0x180C4FA70
	public static int GetDLCCount() { }

	// RVA: 0xC4F100 Offset: 0xC4DB00 VA: 0x180C4F100
	public static bool BGetDLCDataByIndex(int iDLC, out AppId_t pAppID, out bool pbAvailable, out string pchName, int cchNameBufferSize) { }

	// RVA: 0xC4FFC0 Offset: 0xC4E9C0 VA: 0x180C4FFC0
	public static void InstallDLC(AppId_t nAppID) { }

	// RVA: 0xC50260 Offset: 0xC4EC60 VA: 0x180C50260
	public static void UninstallDLC(AppId_t nAppID) { }

	// RVA: 0xC500B0 Offset: 0xC4EAB0 VA: 0x180C500B0
	public static void RequestAppProofOfPurchaseKey(AppId_t nAppID) { }

	// RVA: 0xC4F930 Offset: 0xC4E330 VA: 0x180C4F930
	public static bool GetCurrentBetaName(out string pchName, int cchNameBufferSize) { }

	// RVA: 0xC50010 Offset: 0xC4EA10 VA: 0x180C50010
	public static bool MarkContentCorrupt(bool bMissingFilesOnly) { }

	// RVA: 0xC4FCD0 Offset: 0xC4E6D0 VA: 0x180C4FCD0
	public static uint GetInstalledDepots(AppId_t appID, DepotId_t[] pvecDepots, uint cMaxDepots) { }

	// RVA: 0xC4F5B0 Offset: 0xC4DFB0 VA: 0x180C4F5B0
	public static uint GetAppInstallDir(AppId_t appID, out string pchFolder, uint cchFolderBufferSize) { }

	// RVA: 0xC4F230 Offset: 0xC4DC30 VA: 0x180C4F230
	public static bool BIsAppInstalled(AppId_t appID) { }

	// RVA: 0xC4F6C0 Offset: 0xC4E0C0 VA: 0x180C4F6C0
	public static CSteamID GetAppOwner() { }

	// RVA: 0xC4FE40 Offset: 0xC4E840 VA: 0x180C4FE40
	public static string GetLaunchQueryParam(string pchKey) { }

	// RVA: 0xC4FAC0 Offset: 0xC4E4C0 VA: 0x180C4FAC0
	public static bool GetDlcDownloadProgress(AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal) { }

	// RVA: 0xC4F560 Offset: 0xC4DF60 VA: 0x180C4F560
	public static int GetAppBuildId() { }

	// RVA: 0xC50060 Offset: 0xC4EA60 VA: 0x180C50060
	public static void RequestAllProofOfPurchaseKeys() { }

	// RVA: 0xC4FB90 Offset: 0xC4E590 VA: 0x180C4FB90
	public static SteamAPICall_t GetFileDetails(string pszFileName) { }

	// RVA: 0xC4FD50 Offset: 0xC4E750 VA: 0x180C4FD50
	public static int GetLaunchCommandLine(out string pszCommandLine, int cubCommandLine) { }

	// RVA: 0xC4F3C0 Offset: 0xC4DDC0 VA: 0x180C4F3C0
	public static bool BIsSubscribedFromFamilySharing() { }

	// RVA: 0xC4F4B0 Offset: 0xC4DEB0 VA: 0x180C4F4B0
	public static bool BIsTimedTrial(out uint punSecondsAllowed, out uint punSecondsPlayed) { }

	// RVA: 0xC50210 Offset: 0xC4EC10 VA: 0x180C50210
	public static bool SetDlcContext(AppId_t nAppID) { }

	// RVA: 0xC4FF60 Offset: 0xC4E960 VA: 0x180C4FF60
	public static int GetNumBetas(out int pnAvailable, out int pnPrivate) { }

	// RVA: 0xC4F7A0 Offset: 0xC4E1A0 VA: 0x180C4F7A0
	public static bool GetBetaInfo(int iBetaIndex, out uint punFlags, out uint punBuildID, out string pchBetaName, int cchBetaName, out string pchDescription, int cchDescription) { }

	// RVA: 0xC50100 Offset: 0xC4EB00 VA: 0x180C50100
	public static bool SetActiveBeta(string pchBetaName) { }
}
