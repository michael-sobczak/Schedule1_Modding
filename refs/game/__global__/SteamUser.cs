public static class SteamUser // TypeDefIndex: 14354
{
	// Methods

	// RVA: 0xCB9D80 Offset: 0xCB8780 VA: 0x180CB9D80
	public static HSteamUser GetHSteamUser() { }

	// RVA: 0xCB91D0 Offset: 0xCB7BD0 VA: 0x180CB91D0
	public static bool BLoggedOn() { }

	// RVA: 0xCB9FE0 Offset: 0xCB89E0 VA: 0x180CB9FE0
	public static CSteamID GetSteamID() { }

	// RVA: 0xCBA400 Offset: 0xCB8E00 VA: 0x180CBA400
	public static int InitiateGameConnection_DEPRECATED(byte[] pAuthBlob, int cbMaxAuthBlob, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure) { }

	// RVA: 0xCBA9B0 Offset: 0xCB93B0 VA: 0x180CBA9B0
	public static void TerminateGameConnection_DEPRECATED(uint unIPServer, ushort usPortServer) { }

	// RVA: 0xCBAA80 Offset: 0xCB9480 VA: 0x180CBAA80
	public static void TrackAppUsageEvent(CGameID gameID, int eAppUsageEvent, string pchExtraInfo = "") { }

	// RVA: 0xCBA0D0 Offset: 0xCB8AD0 VA: 0x180CBA0D0
	public static bool GetUserDataFolder(out string pchBuffer, int cubBuffer) { }

	// RVA: 0xCBA850 Offset: 0xCB9250 VA: 0x180CBA850
	public static void StartVoiceRecording() { }

	// RVA: 0xCBA900 Offset: 0xCB9300 VA: 0x180CBA900
	public static void StopVoiceRecording() { }

	// RVA: 0xCB9A10 Offset: 0xCB8410 VA: 0x180CB9A10
	public static EVoiceResult GetAvailableVoice(out uint pcbCompressed) { }

	// RVA: 0xCBA2E0 Offset: 0xCB8CE0 VA: 0x180CBA2E0
	public static EVoiceResult GetVoice(bool bWantCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten) { }

	// RVA: 0xCB94F0 Offset: 0xCB7EF0 VA: 0x180CB94F0
	public static EVoiceResult DecompressVoice(byte[] pCompressed, uint cbCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, uint nDesiredSampleRate) { }

	// RVA: 0xCBA230 Offset: 0xCB8C30 VA: 0x180CBA230
	public static uint GetVoiceOptimalSampleRate() { }

	// RVA: 0xCB96D0 Offset: 0xCB80D0 VA: 0x180CB96D0
	public static HAuthTicket GetAuthSessionTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket, ref SteamNetworkingIdentity pSteamNetworkingIdentity) { }

	// RVA: 0xCB9800 Offset: 0xCB8200 VA: 0x180CB9800
	public static HAuthTicket GetAuthTicketForWebApi(string pchIdentity) { }

	// RVA: 0xCB9340 Offset: 0xCB7D40 VA: 0x180CB9340
	public static EBeginAuthSessionResult BeginAuthSession(byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID) { }

	// RVA: 0xCB9610 Offset: 0xCB8010 VA: 0x180CB9610
	public static void EndAuthSession(CSteamID steamID) { }

	// RVA: 0xCB9430 Offset: 0xCB7E30 VA: 0x180CB9430
	public static void CancelAuthTicket(HAuthTicket hAuthTicket) { }

	// RVA: 0xCBAC60 Offset: 0xCB9660 VA: 0x180CBAC60
	public static EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, AppId_t appID) { }

	// RVA: 0xCB8E60 Offset: 0xCB7860 VA: 0x180CB8E60
	public static bool BIsBehindNAT() { }

	// RVA: 0xCB8D80 Offset: 0xCB7780 VA: 0x180CB8D80
	public static void AdvertiseGame(CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer) { }

	// RVA: 0xCBA520 Offset: 0xCB8F20 VA: 0x180CBA520
	public static SteamAPICall_t RequestEncryptedAppTicket(byte[] pDataToInclude, int cbDataToInclude) { }

	// RVA: 0xCB9BC0 Offset: 0xCB85C0 VA: 0x180CB9BC0
	public static bool GetEncryptedAppTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket) { }

	// RVA: 0xCB9CB0 Offset: 0xCB86B0 VA: 0x180CB9CB0
	public static int GetGameBadgeLevel(int nSeries, bool bFoil) { }

	// RVA: 0xCB9F30 Offset: 0xCB8930 VA: 0x180CB9F30
	public static int GetPlayerSteamLevel() { }

	// RVA: 0xCBA630 Offset: 0xCB9030 VA: 0x180CBA630
	public static SteamAPICall_t RequestStoreAuthURL(string pchRedirectURL) { }

	// RVA: 0xCB9070 Offset: 0xCB7A70 VA: 0x180CB9070
	public static bool BIsPhoneVerified() { }

	// RVA: 0xCB9120 Offset: 0xCB7B20 VA: 0x180CB9120
	public static bool BIsTwoFactorEnabled() { }

	// RVA: 0xCB8F10 Offset: 0xCB7910 VA: 0x180CB8F10
	public static bool BIsPhoneIdentifying() { }

	// RVA: 0xCB8FC0 Offset: 0xCB79C0 VA: 0x180CB8FC0
	public static bool BIsPhoneRequiringVerification() { }

	// RVA: 0xCB9E40 Offset: 0xCB8840 VA: 0x180CB9E40
	public static SteamAPICall_t GetMarketEligibility() { }

	// RVA: 0xCB9AD0 Offset: 0xCB84D0 VA: 0x180CB9AD0
	public static SteamAPICall_t GetDurationControl() { }

	// RVA: 0xCB9280 Offset: 0xCB7C80 VA: 0x180CB9280
	public static bool BSetDurationControlOnlineState(EDurationControlOnlineState eNewState) { }
}
