public static class SteamMatchmakingServers // TypeDefIndex: 14339
{
	// Methods

	// RVA: 0xC6BFD0 Offset: 0xC6A9D0 VA: 0x180C6BFD0
	public static HServerListRequest RequestInternetServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse) { }

	// RVA: 0xC6C0E0 Offset: 0xC6AAE0 VA: 0x180C6C0E0
	public static HServerListRequest RequestLANServerList(AppId_t iApp, ISteamMatchmakingServerListResponse pRequestServersResponse) { }

	// RVA: 0xC6BDB0 Offset: 0xC6A7B0 VA: 0x180C6BDB0
	public static HServerListRequest RequestFriendsServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse) { }

	// RVA: 0xC6BCA0 Offset: 0xC6A6A0 VA: 0x180C6BCA0
	public static HServerListRequest RequestFavoritesServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse) { }

	// RVA: 0xC6BEC0 Offset: 0xC6A8C0 VA: 0x180C6BEC0
	public static HServerListRequest RequestHistoryServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse) { }

	// RVA: 0xC6C190 Offset: 0xC6AB90 VA: 0x180C6C190
	public static HServerListRequest RequestSpectatorServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse) { }

	// RVA: 0xC6BC50 Offset: 0xC6A650 VA: 0x180C6BC50
	public static void ReleaseRequest(HServerListRequest hServerListRequest) { }

	// RVA: 0xC6B880 Offset: 0xC6A280 VA: 0x180C6B880
	public static gameserveritem_t GetServerDetails(HServerListRequest hRequest, int iServer) { }

	// RVA: 0xC6B790 Offset: 0xC6A190 VA: 0x180C6B790
	public static void CancelQuery(HServerListRequest hRequest) { }

	// RVA: 0xC6BBA0 Offset: 0xC6A5A0 VA: 0x180C6BBA0
	public static void RefreshQuery(HServerListRequest hRequest) { }

	// RVA: 0xC6B9B0 Offset: 0xC6A3B0 VA: 0x180C6B9B0
	public static bool IsRefreshing(HServerListRequest hRequest) { }

	// RVA: 0xC6B830 Offset: 0xC6A230 VA: 0x180C6B830
	public static int GetServerCount(HServerListRequest hRequest) { }

	// RVA: 0xC6BBF0 Offset: 0xC6A5F0 VA: 0x180C6BBF0
	public static void RefreshServer(HServerListRequest hRequest, int iServer) { }

	// RVA: 0xC6BA00 Offset: 0xC6A400 VA: 0x180C6BA00
	public static HServerQuery PingServer(uint unIP, ushort usPort, ISteamMatchmakingPingResponse pRequestServersResponse) { }

	// RVA: 0xC6BAD0 Offset: 0xC6A4D0 VA: 0x180C6BAD0
	public static HServerQuery PlayerDetails(uint unIP, ushort usPort, ISteamMatchmakingPlayersResponse pRequestServersResponse) { }

	// RVA: 0xC6C2A0 Offset: 0xC6ACA0 VA: 0x180C6C2A0
	public static HServerQuery ServerRules(uint unIP, ushort usPort, ISteamMatchmakingRulesResponse pRequestServersResponse) { }

	// RVA: 0xC6B7E0 Offset: 0xC6A1E0 VA: 0x180C6B7E0
	public static void CancelServerQuery(HServerQuery hServerQuery) { }
}
