public static class SteamGameServerStats // TypeDefIndex: 14331
{
	// Methods

	// RVA: 0xC5E380 Offset: 0xC5CD80 VA: 0x180C5E380
	public static SteamAPICall_t RequestUserStats(CSteamID steamIDUser) { }

	// RVA: 0xC5E120 Offset: 0xC5CB20 VA: 0x180C5E120
	public static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData) { }

	// RVA: 0xC5E250 Offset: 0xC5CC50 VA: 0x180C5E250
	public static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData) { }

	// RVA: 0xC5DFF0 Offset: 0xC5C9F0 VA: 0x180C5DFF0
	public static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved) { }

	// RVA: 0xC5E530 Offset: 0xC5CF30 VA: 0x180C5E530
	public static bool SetUserStat(CSteamID steamIDUser, string pchName, int nData) { }

	// RVA: 0xC5E660 Offset: 0xC5D060 VA: 0x180C5E660
	public static bool SetUserStat(CSteamID steamIDUser, string pchName, float fData) { }

	// RVA: 0xC5E820 Offset: 0xC5D220 VA: 0x180C5E820
	public static bool UpdateUserAvgRateStat(CSteamID steamIDUser, string pchName, float flCountThisSession, double dSessionLength) { }

	// RVA: 0xC5E410 Offset: 0xC5CE10 VA: 0x180C5E410
	public static bool SetUserAchievement(CSteamID steamIDUser, string pchName) { }

	// RVA: 0xC5DED0 Offset: 0xC5C8D0 VA: 0x180C5DED0
	public static bool ClearUserAchievement(CSteamID steamIDUser, string pchName) { }

	// RVA: 0xC5E790 Offset: 0xC5D190 VA: 0x180C5E790
	public static SteamAPICall_t StoreUserStats(CSteamID steamIDUser) { }
}
