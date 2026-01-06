public static class SteamGameServer // TypeDefIndex: 14323
{
	// Methods

	// RVA: 0xC65570 Offset: 0xC63F70 VA: 0x180C65570
	public static void SetProduct(string pszProduct) { }

	// RVA: 0xC64F40 Offset: 0xC63940 VA: 0x180C64F40
	public static void SetGameDescription(string pszGameDescription) { }

	// RVA: 0xC65420 Offset: 0xC63E20 VA: 0x180C65420
	public static void SetModDir(string pszModDir) { }

	// RVA: 0xC64DF0 Offset: 0xC637F0 VA: 0x180C64DF0
	public static void SetDedicatedServer(bool bDedicated) { }

	// RVA: 0xC64B10 Offset: 0xC63510 VA: 0x180C64B10
	public static void LogOn(string pszToken) { }

	// RVA: 0xC64AC0 Offset: 0xC634C0 VA: 0x180C64AC0
	public static void LogOnAnonymous() { }

	// RVA: 0xC64A70 Offset: 0xC63470 VA: 0x180C64A70
	public static void LogOff() { }

	// RVA: 0xC64260 Offset: 0xC62C60 VA: 0x180C64260
	public static bool BLoggedOn() { }

	// RVA: 0xC642B0 Offset: 0xC62CB0 VA: 0x180C642B0
	public static bool BSecure() { }

	// RVA: 0xC64950 Offset: 0xC63350 VA: 0x180C64950
	public static CSteamID GetSteamID() { }

	// RVA: 0xC65A20 Offset: 0xC64420 VA: 0x180C65A20
	public static bool WasRestartRequested() { }

	// RVA: 0xC653D0 Offset: 0xC63DD0 VA: 0x180C653D0
	public static void SetMaxPlayerCount(int cPlayersMax) { }

	// RVA: 0xC64DA0 Offset: 0xC637A0 VA: 0x180C64DA0
	public static void SetBotPlayerCount(int cBotplayers) { }

	// RVA: 0xC65770 Offset: 0xC64170 VA: 0x180C65770
	public static void SetServerName(string pszServerName) { }

	// RVA: 0xC652D0 Offset: 0xC63CD0 VA: 0x180C652D0
	public static void SetMapName(string pszMapName) { }

	// RVA: 0xC65520 Offset: 0xC63F20 VA: 0x180C65520
	public static void SetPasswordProtected(bool bPasswordProtected) { }

	// RVA: 0xC65870 Offset: 0xC64270 VA: 0x180C65870
	public static void SetSpectatorPort(ushort unSpectatorPort) { }

	// RVA: 0xC658C0 Offset: 0xC642C0 VA: 0x180C658C0
	public static void SetSpectatorServerName(string pszSpectatorServerName) { }

	// RVA: 0xC64500 Offset: 0xC62F00 VA: 0x180C64500
	public static void ClearAllKeyValues() { }

	// RVA: 0xC65140 Offset: 0xC63B40 VA: 0x180C65140
	public static void SetKeyValue(string pKey, string pValue) { }

	// RVA: 0xC65040 Offset: 0xC63A40 VA: 0x180C65040
	public static void SetGameTags(string pchGameTags) { }

	// RVA: 0xC64E40 Offset: 0xC63840 VA: 0x180C64E40
	public static void SetGameData(string pchGameData) { }

	// RVA: 0xC65670 Offset: 0xC64070 VA: 0x180C65670
	public static void SetRegion(string pszRegion) { }

	// RVA: 0xC64D50 Offset: 0xC63750 VA: 0x180C64D50
	public static void SetAdvertiseServerActive(bool bActive) { }

	// RVA: 0xC646C0 Offset: 0xC630C0 VA: 0x180C646C0
	public static HAuthTicket GetAuthSessionTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket, ref SteamNetworkingIdentity pSnid) { }

	// RVA: 0xC64430 Offset: 0xC62E30 VA: 0x180C64430
	public static EBeginAuthSessionResult BeginAuthSession(byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID) { }

	// RVA: 0xC64670 Offset: 0xC63070 VA: 0x180C64670
	public static void EndAuthSession(CSteamID steamID) { }

	// RVA: 0xC644B0 Offset: 0xC62EB0 VA: 0x180C644B0
	public static void CancelAuthTicket(HAuthTicket hAuthTicket) { }

	// RVA: 0xC659C0 Offset: 0xC643C0 VA: 0x180C659C0
	public static EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, AppId_t appID) { }

	// RVA: 0xC64C10 Offset: 0xC63610 VA: 0x180C64C10
	public static bool RequestUserGroupStatus(CSteamID steamIDUser, CSteamID steamIDGroup) { }

	// RVA: 0xC64780 Offset: 0xC63180 VA: 0x180C64780
	public static void GetGameplayStats() { }

	// RVA: 0xC648C0 Offset: 0xC632C0 VA: 0x180C648C0
	public static SteamAPICall_t GetServerReputation() { }

	// RVA: 0xC64860 Offset: 0xC63260 VA: 0x180C64860
	public static SteamIPAddress_t GetPublicIP() { }

	// RVA: 0xC649E0 Offset: 0xC633E0 VA: 0x180C649E0
	public static bool HandleIncomingPacket(byte[] pData, int cbData, uint srcIP, ushort srcPort) { }

	// RVA: 0xC647D0 Offset: 0xC631D0 VA: 0x180C647D0
	public static int GetNextOutgoingPacket(byte[] pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort) { }

	// RVA: 0xC641D0 Offset: 0xC62BD0 VA: 0x180C641D0
	public static SteamAPICall_t AssociateWithClan(CSteamID steamIDClan) { }

	// RVA: 0xC64550 Offset: 0xC62F50 VA: 0x180C64550
	public static SteamAPICall_t ComputeNewPlayerCompatibility(CSteamID steamIDNewPlayer) { }

	// RVA: 0xC64C70 Offset: 0xC63670 VA: 0x180C64C70
	public static bool SendUserConnectAndAuthenticate_DEPRECATED(uint unIPClient, byte[] pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser) { }

	// RVA: 0xC645E0 Offset: 0xC62FE0 VA: 0x180C645E0
	public static CSteamID CreateUnauthenticatedUserConnection() { }

	// RVA: 0xC64D00 Offset: 0xC63700 VA: 0x180C64D00
	public static void SendUserDisconnect_DEPRECATED(CSteamID steamIDUser) { }

	// RVA: 0xC64300 Offset: 0xC62D00 VA: 0x180C64300
	public static bool BUpdateUserData(CSteamID steamIDUser, string pchPlayerName, uint uScore) { }
}
