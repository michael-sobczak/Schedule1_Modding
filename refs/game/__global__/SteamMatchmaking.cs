public static class SteamMatchmaking // TypeDefIndex: 14338
{
	// Methods

	// RVA: 0xC6CB00 Offset: 0xC6B500 VA: 0x180C6CB00
	public static int GetFavoriteGameCount() { }

	// RVA: 0xC6CB50 Offset: 0xC6B550 VA: 0x180C6CB50
	public static bool GetFavoriteGame(int iGame, out AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer) { }

	// RVA: 0xC6C370 Offset: 0xC6AD70 VA: 0x180C6C370
	public static int AddFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer) { }

	// RVA: 0xC6D520 Offset: 0xC6BF20 VA: 0x180C6D520
	public static bool RemoveFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags) { }

	// RVA: 0xC6D600 Offset: 0xC6C000 VA: 0x180C6D600
	public static SteamAPICall_t RequestLobbyList() { }

	// RVA: 0xC6C780 Offset: 0xC6B180 VA: 0x180C6C780
	public static void AddRequestLobbyListStringFilter(string pchKeyToMatch, string pchValueToMatch, ELobbyComparison eComparisonType) { }

	// RVA: 0xC6C610 Offset: 0xC6B010 VA: 0x180C6C610
	public static void AddRequestLobbyListNumericalFilter(string pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType) { }

	// RVA: 0xC6C500 Offset: 0xC6AF00 VA: 0x180C6C500
	public static void AddRequestLobbyListNearValueFilter(string pchKeyToMatch, int nValueToBeCloseTo) { }

	// RVA: 0xC6C4B0 Offset: 0xC6AEB0 VA: 0x180C6C4B0
	public static void AddRequestLobbyListFilterSlotsAvailable(int nSlotsAvailable) { }

	// RVA: 0xC6C460 Offset: 0xC6AE60 VA: 0x180C6C460
	public static void AddRequestLobbyListDistanceFilter(ELobbyDistanceFilter eLobbyDistanceFilter) { }

	// RVA: 0xC6C730 Offset: 0xC6B130 VA: 0x180C6C730
	public static void AddRequestLobbyListResultCountFilter(int cMaxResults) { }

	// RVA: 0xC6C410 Offset: 0xC6AE10 VA: 0x180C6C410
	public static void AddRequestLobbyListCompatibleMembersFilter(CSteamID steamIDLobby) { }

	// RVA: 0xC6CC00 Offset: 0xC6B600 VA: 0x180C6CC00
	public static CSteamID GetLobbyByIndex(int iLobby) { }

	// RVA: 0xC6C940 Offset: 0xC6B340 VA: 0x180C6C940
	public static SteamAPICall_t CreateLobby(ELobbyType eLobbyType, int cMaxMembers) { }

	// RVA: 0xC6D440 Offset: 0xC6BE40 VA: 0x180C6D440
	public static SteamAPICall_t JoinLobby(CSteamID steamIDLobby) { }

	// RVA: 0xC6D4D0 Offset: 0xC6BED0 VA: 0x180C6D4D0
	public static void LeaveLobby(CSteamID steamIDLobby) { }

	// RVA: 0xC6D3E0 Offset: 0xC6BDE0 VA: 0x180C6D3E0
	public static bool InviteUserToLobby(CSteamID steamIDLobby, CSteamID steamIDInvitee) { }

	// RVA: 0xC6D390 Offset: 0xC6BD90 VA: 0x180C6D390
	public static int GetNumLobbyMembers(CSteamID steamIDLobby) { }

	// RVA: 0xC6D0C0 Offset: 0xC6BAC0 VA: 0x180C6D0C0
	public static CSteamID GetLobbyMemberByIndex(CSteamID steamIDLobby, int iMember) { }

	// RVA: 0xC6CF00 Offset: 0xC6B900 VA: 0x180C6CF00
	public static string GetLobbyData(CSteamID steamIDLobby, string pchKey) { }

	// RVA: 0xC6D770 Offset: 0xC6C170 VA: 0x180C6D770
	public static bool SetLobbyData(CSteamID steamIDLobby, string pchKey, string pchValue) { }

	// RVA: 0xC6CEB0 Offset: 0xC6B8B0 VA: 0x180C6CEB0
	public static int GetLobbyDataCount(CSteamID steamIDLobby) { }

	// RVA: 0xC6CD30 Offset: 0xC6B730 VA: 0x180C6CD30
	public static bool GetLobbyDataByIndex(CSteamID steamIDLobby, int iLobbyData, out string pchKey, int cchKeyBufferSize, out string pchValue, int cchValueBufferSize) { }

	// RVA: 0xC6C9E0 Offset: 0xC6B3E0 VA: 0x180C6C9E0
	public static bool DeleteLobbyData(CSteamID steamIDLobby, string pchKey) { }

	// RVA: 0xC6D160 Offset: 0xC6BB60 VA: 0x180C6D160
	public static string GetLobbyMemberData(CSteamID steamIDLobby, CSteamID steamIDUser, string pchKey) { }

	// RVA: 0xC6DA30 Offset: 0xC6C430 VA: 0x180C6DA30
	public static void SetLobbyMemberData(CSteamID steamIDLobby, string pchKey, string pchValue) { }

	// RVA: 0xC6D690 Offset: 0xC6C090 VA: 0x180C6D690
	public static bool SendLobbyChatMsg(CSteamID steamIDLobby, byte[] pvMsgBody, int cubMsgBody) { }

	// RVA: 0xC6CC90 Offset: 0xC6B690 VA: 0x180C6CC90
	public static int GetLobbyChatEntry(CSteamID steamIDLobby, int iChatID, out CSteamID pSteamIDUser, byte[] pvData, int cubData, out EChatEntryType peChatEntryType) { }

	// RVA: 0xC6D5B0 Offset: 0xC6BFB0 VA: 0x180C6D5B0
	public static bool RequestLobbyData(CSteamID steamIDLobby) { }

	// RVA: 0xC6D940 Offset: 0xC6C340 VA: 0x180C6D940
	public static void SetLobbyGameServer(CSteamID steamIDLobby, uint unGameServerIP, ushort unGameServerPort, CSteamID steamIDGameServer) { }

	// RVA: 0xC6D030 Offset: 0xC6BA30 VA: 0x180C6D030
	public static bool GetLobbyGameServer(CSteamID steamIDLobby, out uint punGameServerIP, out ushort punGameServerPort, out CSteamID psteamIDGameServer) { }

	// RVA: 0xC6DBF0 Offset: 0xC6C5F0 VA: 0x180C6DBF0
	public static bool SetLobbyMemberLimit(CSteamID steamIDLobby, int cMaxMembers) { }

	// RVA: 0xC6D2B0 Offset: 0xC6BCB0 VA: 0x180C6D2B0
	public static int GetLobbyMemberLimit(CSteamID steamIDLobby) { }

	// RVA: 0xC6DCB0 Offset: 0xC6C6B0 VA: 0x180C6DCB0
	public static bool SetLobbyType(CSteamID steamIDLobby, ELobbyType eLobbyType) { }

	// RVA: 0xC6D9D0 Offset: 0xC6C3D0 VA: 0x180C6D9D0
	public static bool SetLobbyJoinable(CSteamID steamIDLobby, bool bLobbyJoinable) { }

	// RVA: 0xC6D300 Offset: 0xC6BD00 VA: 0x180C6D300
	public static CSteamID GetLobbyOwner(CSteamID steamIDLobby) { }

	// RVA: 0xC6DC50 Offset: 0xC6C650 VA: 0x180C6DC50
	public static bool SetLobbyOwner(CSteamID steamIDLobby, CSteamID steamIDNewOwner) { }

	// RVA: 0xC6D710 Offset: 0xC6C110 VA: 0x180C6D710
	public static bool SetLinkedLobby(CSteamID steamIDLobby, CSteamID steamIDLobbyDependent) { }
}
