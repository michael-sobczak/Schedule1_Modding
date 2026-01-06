public static class SteamClient // TypeDefIndex: 14321
{
	// Methods

	// RVA: 0xC50420 Offset: 0xC4EE20 VA: 0x180C50420
	public static HSteamPipe CreateSteamPipe() { }

	// RVA: 0xC502B0 Offset: 0xC4ECB0 VA: 0x180C502B0
	public static bool BReleaseSteamPipe(HSteamPipe hSteamPipe) { }

	// RVA: 0xC50350 Offset: 0xC4ED50 VA: 0x180C50350
	public static HSteamUser ConnectToGlobalUser(HSteamPipe hSteamPipe) { }

	// RVA: 0xC503B0 Offset: 0xC4EDB0 VA: 0x180C503B0
	public static HSteamUser CreateLocalUser(out HSteamPipe phSteamPipe, EAccountType eAccountType) { }

	// RVA: 0xC52520 Offset: 0xC50F20 VA: 0x180C52520
	public static void ReleaseUser(HSteamPipe hSteamPipe, HSteamUser hUser) { }

	// RVA: 0xC52180 Offset: 0xC50B80 VA: 0x180C52180
	public static IntPtr GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC50B00 Offset: 0xC4F500 VA: 0x180C50B00
	public static IntPtr GetISteamGameServer(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC52580 Offset: 0xC50F80 VA: 0x180C52580
	public static void SetLocalIPBinding(ref SteamIPAddress_t unIP, ushort usPort) { }

	// RVA: 0xC50740 Offset: 0xC4F140 VA: 0x180C50740
	public static IntPtr GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC522C0 Offset: 0xC50CC0 VA: 0x180C522C0
	public static IntPtr GetISteamUtils(HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC513C0 Offset: 0xC4FDC0 VA: 0x180C513C0
	public static IntPtr GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC51280 Offset: 0xC4FC80 VA: 0x180C51280
	public static IntPtr GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC50C40 Offset: 0xC4F640 VA: 0x180C50C40
	public static IntPtr GetISteamGenericInterface(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC52040 Offset: 0xC50A40 VA: 0x180C52040
	public static IntPtr GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC509C0 Offset: 0xC4F3C0 VA: 0x180C509C0
	public static IntPtr GetISteamGameServerStats(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC504C0 Offset: 0xC4EEC0 VA: 0x180C504C0
	public static IntPtr GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC51780 Offset: 0xC50180 VA: 0x180C51780
	public static IntPtr GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC51C80 Offset: 0xC50680 VA: 0x180C51C80
	public static IntPtr GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC51DC0 Offset: 0xC507C0 VA: 0x180C51DC0
	public static IntPtr GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC50880 Offset: 0xC4F280 VA: 0x180C50880
	public static IntPtr GetISteamGameSearch(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC50470 Offset: 0xC4EE70 VA: 0x180C50470
	public static uint GetIPCCallCount() { }

	// RVA: 0xC525E0 Offset: 0xC50FE0 VA: 0x180C525E0
	public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction) { }

	// RVA: 0xC50300 Offset: 0xC4ED00 VA: 0x180C50300
	public static bool BShutdownIfAllPipesClosed() { }

	// RVA: 0xC50EC0 Offset: 0xC4F8C0 VA: 0x180C50EC0
	public static IntPtr GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC50600 Offset: 0xC4F000 VA: 0x180C50600
	public static IntPtr GetISteamController(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC51F00 Offset: 0xC50900 VA: 0x180C51F00
	public static IntPtr GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC51640 Offset: 0xC50040 VA: 0x180C51640
	public static IntPtr GetISteamMusic(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC51500 Offset: 0xC4FF00 VA: 0x180C51500
	public static IntPtr GetISteamMusicRemote(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC50D80 Offset: 0xC4F780 VA: 0x180C50D80
	public static IntPtr GetISteamHTMLSurface(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC51140 Offset: 0xC4FB40 VA: 0x180C51140
	public static IntPtr GetISteamInventory(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC523E0 Offset: 0xC50DE0 VA: 0x180C523E0
	public static IntPtr GetISteamVideo(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC518C0 Offset: 0xC502C0 VA: 0x180C518C0
	public static IntPtr GetISteamParentalSettings(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC51000 Offset: 0xC4FA00 VA: 0x180C51000
	public static IntPtr GetISteamInput(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC51A00 Offset: 0xC50400 VA: 0x180C51A00
	public static IntPtr GetISteamParties(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC51B40 Offset: 0xC50540 VA: 0x180C51B40
	public static IntPtr GetISteamRemotePlay(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }
}
