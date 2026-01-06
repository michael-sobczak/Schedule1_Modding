public static class SteamGameServerClient // TypeDefIndex: 14324
{
	// Methods

	// RVA: 0xC55AE0 Offset: 0xC544E0 VA: 0x180C55AE0
	public static HSteamPipe CreateSteamPipe() { }

	// RVA: 0xC55970 Offset: 0xC54370 VA: 0x180C55970
	public static bool BReleaseSteamPipe(HSteamPipe hSteamPipe) { }

	// RVA: 0xC55A10 Offset: 0xC54410 VA: 0x180C55A10
	public static HSteamUser ConnectToGlobalUser(HSteamPipe hSteamPipe) { }

	// RVA: 0xC55A70 Offset: 0xC54470 VA: 0x180C55A70
	public static HSteamUser CreateLocalUser(out HSteamPipe phSteamPipe, EAccountType eAccountType) { }

	// RVA: 0xC57BE0 Offset: 0xC565E0 VA: 0x180C57BE0
	public static void ReleaseUser(HSteamPipe hSteamPipe, HSteamUser hUser) { }

	// RVA: 0xC57840 Offset: 0xC56240 VA: 0x180C57840
	public static IntPtr GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC561C0 Offset: 0xC54BC0 VA: 0x180C561C0
	public static IntPtr GetISteamGameServer(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC57C40 Offset: 0xC56640 VA: 0x180C57C40
	public static void SetLocalIPBinding(ref SteamIPAddress_t unIP, ushort usPort) { }

	// RVA: 0xC55E00 Offset: 0xC54800 VA: 0x180C55E00
	public static IntPtr GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC57980 Offset: 0xC56380 VA: 0x180C57980
	public static IntPtr GetISteamUtils(HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC56A80 Offset: 0xC55480 VA: 0x180C56A80
	public static IntPtr GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC56940 Offset: 0xC55340 VA: 0x180C56940
	public static IntPtr GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC56300 Offset: 0xC54D00 VA: 0x180C56300
	public static IntPtr GetISteamGenericInterface(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC57700 Offset: 0xC56100 VA: 0x180C57700
	public static IntPtr GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC56080 Offset: 0xC54A80 VA: 0x180C56080
	public static IntPtr GetISteamGameServerStats(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC55B80 Offset: 0xC54580 VA: 0x180C55B80
	public static IntPtr GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC56E40 Offset: 0xC55840 VA: 0x180C56E40
	public static IntPtr GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC57340 Offset: 0xC55D40 VA: 0x180C57340
	public static IntPtr GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC57480 Offset: 0xC55E80 VA: 0x180C57480
	public static IntPtr GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC55F40 Offset: 0xC54940 VA: 0x180C55F40
	public static IntPtr GetISteamGameSearch(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC55B30 Offset: 0xC54530 VA: 0x180C55B30
	public static uint GetIPCCallCount() { }

	// RVA: 0xC57CA0 Offset: 0xC566A0 VA: 0x180C57CA0
	public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction) { }

	// RVA: 0xC559C0 Offset: 0xC543C0 VA: 0x180C559C0
	public static bool BShutdownIfAllPipesClosed() { }

	// RVA: 0xC56580 Offset: 0xC54F80 VA: 0x180C56580
	public static IntPtr GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC55CC0 Offset: 0xC546C0 VA: 0x180C55CC0
	public static IntPtr GetISteamController(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC575C0 Offset: 0xC55FC0 VA: 0x180C575C0
	public static IntPtr GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC56D00 Offset: 0xC55700 VA: 0x180C56D00
	public static IntPtr GetISteamMusic(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC56BC0 Offset: 0xC555C0 VA: 0x180C56BC0
	public static IntPtr GetISteamMusicRemote(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC56440 Offset: 0xC54E40 VA: 0x180C56440
	public static IntPtr GetISteamHTMLSurface(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC56800 Offset: 0xC55200 VA: 0x180C56800
	public static IntPtr GetISteamInventory(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC57AA0 Offset: 0xC564A0 VA: 0x180C57AA0
	public static IntPtr GetISteamVideo(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC56F80 Offset: 0xC55980 VA: 0x180C56F80
	public static IntPtr GetISteamParentalSettings(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC566C0 Offset: 0xC550C0 VA: 0x180C566C0
	public static IntPtr GetISteamInput(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC570C0 Offset: 0xC55AC0 VA: 0x180C570C0
	public static IntPtr GetISteamParties(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0xC57200 Offset: 0xC55C00 VA: 0x180C57200
	public static IntPtr GetISteamRemotePlay(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }
}
