public static class SteamUserStats // TypeDefIndex: 14355
{
	// Methods

	// RVA: 0xCB7F50 Offset: 0xCB6950 VA: 0x180CB7F50
	public static bool RequestCurrentStats() { }

	// RVA: 0xCB7330 Offset: 0xCB5D30 VA: 0x180CB7330
	public static bool GetStat(string pchName, out int pData) { }

	// RVA: 0xCB7140 Offset: 0xCB5B40 VA: 0x180CB7140
	public static bool GetStat(string pchName, out float pData) { }

	// RVA: 0xCB85A0 Offset: 0xCB6FA0 VA: 0x180CB85A0
	public static bool SetStat(string pchName, int nData) { }

	// RVA: 0xCB8790 Offset: 0xCB7190 VA: 0x180CB8790
	public static bool SetStat(string pchName, float fData) { }

	// RVA: 0xCB8A30 Offset: 0xCB7430 VA: 0x180CB8A30
	public static bool UpdateAvgRateStat(string pchName, float flCountThisSession, double dSessionLength) { }

	// RVA: 0xCB5E80 Offset: 0xCB4880 VA: 0x180CB5E80
	public static bool GetAchievement(string pchName, out bool pbAchieved) { }

	// RVA: 0xCB83B0 Offset: 0xCB6DB0 VA: 0x180CB83B0
	public static bool SetAchievement(string pchName) { }

	// RVA: 0xCB4870 Offset: 0xCB3270 VA: 0x180CB4870
	public static bool ClearAchievement(string pchName) { }

	// RVA: 0xCB52F0 Offset: 0xCB3CF0 VA: 0x180CB52F0
	public static bool GetAchievementAndUnlockTime(string pchName, out bool pbAchieved, out uint punUnlockTime) { }

	// RVA: 0xCB8980 Offset: 0xCB7380 VA: 0x180CB8980
	public static bool StoreStats() { }

	// RVA: 0xCB57D0 Offset: 0xCB41D0 VA: 0x180CB57D0
	public static int GetAchievementIcon(string pchName) { }

	// RVA: 0xCB5500 Offset: 0xCB3F00 VA: 0x180CB5500
	public static string GetAchievementDisplayAttribute(string pchName, string pchKey) { }

	// RVA: 0xCB7D50 Offset: 0xCB6750 VA: 0x180CB7D50
	public static bool IndicateAchievementProgress(string pchName, uint nCurProgress, uint nMaxProgress) { }

	// RVA: 0xCB6FA0 Offset: 0xCB59A0 VA: 0x180CB6FA0
	public static uint GetNumAchievements() { }

	// RVA: 0xCB59C0 Offset: 0xCB43C0 VA: 0x180CB59C0
	public static string GetAchievementName(uint iAchievement) { }

	// RVA: 0xCB81F0 Offset: 0xCB6BF0 VA: 0x180CB81F0
	public static SteamAPICall_t RequestUserStats(CSteamID steamIDUser) { }

	// RVA: 0xCB7B50 Offset: 0xCB6550 VA: 0x180CB7B50
	public static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData) { }

	// RVA: 0xCB7950 Offset: 0xCB6350 VA: 0x180CB7950
	public static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData) { }

	// RVA: 0xCB7740 Offset: 0xCB6140 VA: 0x180CB7740
	public static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved) { }

	// RVA: 0xCB7520 Offset: 0xCB5F20 VA: 0x180CB7520
	public static bool GetUserAchievementAndUnlockTime(CSteamID steamIDUser, string pchName, out bool pbAchieved, out uint punUnlockTime) { }

	// RVA: 0xCB82F0 Offset: 0xCB6CF0 VA: 0x180CB82F0
	public static bool ResetAllStats(bool bAchievementsToo) { }

	// RVA: 0xCB4ED0 Offset: 0xCB38D0 VA: 0x180CB4ED0
	public static SteamAPICall_t FindOrCreateLeaderboard(string pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType) { }

	// RVA: 0xCB4CB0 Offset: 0xCB36B0 VA: 0x180CB4CB0
	public static SteamAPICall_t FindLeaderboard(string pchLeaderboardName) { }

	// RVA: 0xCB6AE0 Offset: 0xCB54E0 VA: 0x180CB6AE0
	public static string GetLeaderboardName(SteamLeaderboard_t hSteamLeaderboard) { }

	// RVA: 0xCB6A20 Offset: 0xCB5420 VA: 0x180CB6A20
	public static int GetLeaderboardEntryCount(SteamLeaderboard_t hSteamLeaderboard) { }

	// RVA: 0xCB6BB0 Offset: 0xCB55B0 VA: 0x180CB6BB0
	public static ELeaderboardSortMethod GetLeaderboardSortMethod(SteamLeaderboard_t hSteamLeaderboard) { }

	// RVA: 0xCB6960 Offset: 0xCB5360 VA: 0x180CB6960
	public static ELeaderboardDisplayType GetLeaderboardDisplayType(SteamLeaderboard_t hSteamLeaderboard) { }

	// RVA: 0xCB4B80 Offset: 0xCB3580 VA: 0x180CB4B80
	public static SteamAPICall_t DownloadLeaderboardEntries(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd) { }

	// RVA: 0xCB4A60 Offset: 0xCB3460 VA: 0x180CB4A60
	public static SteamAPICall_t DownloadLeaderboardEntriesForUsers(SteamLeaderboard_t hSteamLeaderboard, CSteamID[] prgUsers, int cUsers) { }

	// RVA: 0xCB6090 Offset: 0xCB4A90 VA: 0x180CB6090
	public static bool GetDownloadedLeaderboardEntry(SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, int[] pDetails, int cDetailsMax) { }

	// RVA: 0xCB8C30 Offset: 0xCB7630 VA: 0x180CB8C30
	public static SteamAPICall_t UploadLeaderboardScore(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, int[] pScoreDetails, int cScoreDetailsCount) { }

	// RVA: 0xCB4760 Offset: 0xCB3160 VA: 0x180CB4760
	public static SteamAPICall_t AttachLeaderboardUGC(SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC) { }

	// RVA: 0xCB7050 Offset: 0xCB5A50 VA: 0x180CB7050
	public static SteamAPICall_t GetNumberOfCurrentPlayers() { }

	// RVA: 0xCB8000 Offset: 0xCB6A00 VA: 0x180CB8000
	public static SteamAPICall_t RequestGlobalAchievementPercentages() { }

	// RVA: 0xCB6C70 Offset: 0xCB5670 VA: 0x180CB6C70
	public static int GetMostAchievedAchievementInfo(out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved) { }

	// RVA: 0xCB6E00 Offset: 0xCB5800 VA: 0x180CB6E00
	public static int GetNextMostAchievedAchievementInfo(int iIteratorPrevious, out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved) { }

	// RVA: 0xCB5100 Offset: 0xCB3B00 VA: 0x180CB5100
	public static bool GetAchievementAchievedPercent(string pchName, out float pflPercent) { }

	// RVA: 0xCB80F0 Offset: 0xCB6AF0 VA: 0x180CB80F0
	public static SteamAPICall_t RequestGlobalStats(int nHistoryDays) { }

	// RVA: 0xCB6770 Offset: 0xCB5170 VA: 0x180CB6770
	public static bool GetGlobalStat(string pchStatName, out long pData) { }

	// RVA: 0xCB6580 Offset: 0xCB4F80 VA: 0x180CB6580
	public static bool GetGlobalStat(string pchStatName, out double pData) { }

	// RVA: 0xCB61A0 Offset: 0xCB4BA0 VA: 0x180CB61A0
	public static int GetGlobalStatHistory(string pchStatName, long[] pData, uint cubData) { }

	// RVA: 0xCB6390 Offset: 0xCB4D90 VA: 0x180CB6390
	public static int GetGlobalStatHistory(string pchStatName, double[] pData, uint cubData) { }

	// RVA: 0xCB5C80 Offset: 0xCB4680 VA: 0x180CB5C80
	public static bool GetAchievementProgressLimits(string pchName, out int pnMinProgress, out int pnMaxProgress) { }

	// RVA: 0xCB5A80 Offset: 0xCB4480 VA: 0x180CB5A80
	public static bool GetAchievementProgressLimits(string pchName, out float pfMinProgress, out float pfMaxProgress) { }
}
