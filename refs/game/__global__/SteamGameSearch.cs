public static class SteamGameSearch // TypeDefIndex: 14340
{
	// Methods

	// RVA: 0xC55090 Offset: 0xC53A90 VA: 0x180C55090
	public static EGameSearchErrorCode_t AddGameSearchParams(string pchKeyToFind, string pchValuesToFind) { }

	// RVA: 0xC555B0 Offset: 0xC53FB0 VA: 0x180C555B0
	public static EGameSearchErrorCode_t SearchForGameWithLobby(CSteamID steamIDLobby, int nPlayerMin, int nPlayerMax) { }

	// RVA: 0xC55550 Offset: 0xC53F50 VA: 0x180C55550
	public static EGameSearchErrorCode_t SearchForGameSolo(int nPlayerMin, int nPlayerMax) { }

	// RVA: 0xC55040 Offset: 0xC53A40 VA: 0x180C55040
	public static EGameSearchErrorCode_t AcceptGame() { }

	// RVA: 0xC55280 Offset: 0xC53C80 VA: 0x180C55280
	public static EGameSearchErrorCode_t DeclineGame() { }

	// RVA: 0xC55440 Offset: 0xC53E40 VA: 0x180C55440
	public static EGameSearchErrorCode_t RetrieveConnectionDetails(CSteamID steamIDHost, out string pchConnectionDetails, int cubConnectionDetails) { }

	// RVA: 0xC552D0 Offset: 0xC53CD0 VA: 0x180C552D0
	public static EGameSearchErrorCode_t EndGameSearch() { }

	// RVA: 0xC55750 Offset: 0xC54150 VA: 0x180C55750
	public static EGameSearchErrorCode_t SetGameHostParams(string pchKey, string pchValue) { }

	// RVA: 0xC55630 Offset: 0xC54030 VA: 0x180C55630
	public static EGameSearchErrorCode_t SetConnectionDetails(string pchConnectionDetails, int cubConnectionDetails) { }

	// RVA: 0xC553C0 Offset: 0xC53DC0 VA: 0x180C553C0
	public static EGameSearchErrorCode_t RequestPlayersForGame(int nPlayerMin, int nPlayerMax, int nMaxTeamSize) { }

	// RVA: 0xC55370 Offset: 0xC53D70 VA: 0x180C55370
	public static EGameSearchErrorCode_t HostConfirmGameStart(ulong ullUniqueGameID) { }

	// RVA: 0xC55230 Offset: 0xC53C30 VA: 0x180C55230
	public static EGameSearchErrorCode_t CancelRequestPlayersForGame() { }

	// RVA: 0xC558F0 Offset: 0xC542F0 VA: 0x180C558F0
	public static EGameSearchErrorCode_t SubmitPlayerResult(ulong ullUniqueGameID, CSteamID steamIDPlayer, EPlayerResult_t EPlayerResult) { }

	// RVA: 0xC55320 Offset: 0xC53D20 VA: 0x180C55320
	public static EGameSearchErrorCode_t EndGame(ulong ullUniqueGameID) { }
}
