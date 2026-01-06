public static class SteamFriends // TypeDefIndex: 14322
{
	// Methods

	// RVA: 0xC53FB0 Offset: 0xC529B0 VA: 0x180C53FB0
	public static string GetPersonaName() { }

	// RVA: 0xC54D10 Offset: 0xC53710 VA: 0x180C54D10
	public static SteamAPICall_t SetPersonaName(string pchPersonaName) { }

	// RVA: 0xC54000 Offset: 0xC52A00 VA: 0x180C54000
	public static EPersonaState GetPersonaState() { }

	// RVA: 0xC53690 Offset: 0xC52090 VA: 0x180C53690
	public static int GetFriendCount(EFriendFlags iFriendFlags) { }

	// RVA: 0xC534C0 Offset: 0xC51EC0 VA: 0x180C534C0
	public static CSteamID GetFriendByIndex(int iFriend, EFriendFlags iFriendFlags) { }

	// RVA: 0xC53A20 Offset: 0xC52420 VA: 0x180C53A20
	public static EFriendRelationship GetFriendRelationship(CSteamID steamIDFriend) { }

	// RVA: 0xC539D0 Offset: 0xC523D0 VA: 0x180C539D0
	public static EPersonaState GetFriendPersonaState(CSteamID steamIDFriend) { }

	// RVA: 0xC53970 Offset: 0xC52370 VA: 0x180C53970
	public static string GetFriendPersonaName(CSteamID steamIDFriend) { }

	// RVA: 0xC53780 Offset: 0xC52180 VA: 0x180C53780
	public static bool GetFriendGamePlayed(CSteamID steamIDFriend, out FriendGameInfo_t pFriendGameInfo) { }

	// RVA: 0xC53900 Offset: 0xC52300 VA: 0x180C53900
	public static string GetFriendPersonaNameHistory(CSteamID steamIDFriend, int iPersonaName) { }

	// RVA: 0xC53C60 Offset: 0xC52660 VA: 0x180C53C60
	public static int GetFriendSteamLevel(CSteamID steamIDFriend) { }

	// RVA: 0xC54050 Offset: 0xC52A50 VA: 0x180C54050
	public static string GetPlayerNickname(CSteamID steamIDPlayer) { }

	// RVA: 0xC53CB0 Offset: 0xC526B0 VA: 0x180C53CB0
	public static int GetFriendsGroupCount() { }

	// RVA: 0xC53D00 Offset: 0xC52700 VA: 0x180C53D00
	public static FriendsGroupID_t GetFriendsGroupIDByIndex(int iFG) { }

	// RVA: 0xC53E60 Offset: 0xC52860 VA: 0x180C53E60
	public static string GetFriendsGroupName(FriendsGroupID_t friendsGroupID) { }

	// RVA: 0xC53D90 Offset: 0xC52790 VA: 0x180C53D90
	public static int GetFriendsGroupMembersCount(FriendsGroupID_t friendsGroupID) { }

	// RVA: 0xC53DE0 Offset: 0xC527E0 VA: 0x180C53DE0
	public static void GetFriendsGroupMembersList(FriendsGroupID_t friendsGroupID, CSteamID[] pOutSteamIDMembers, int nMembersCount) { }

	// RVA: 0xC54250 Offset: 0xC52C50 VA: 0x180C54250
	public static bool HasFriend(CSteamID steamIDFriend, EFriendFlags iFriendFlags) { }

	// RVA: 0xC530C0 Offset: 0xC51AC0 VA: 0x180C530C0
	public static int GetClanCount() { }

	// RVA: 0xC52EB0 Offset: 0xC518B0 VA: 0x180C52EB0
	public static CSteamID GetClanByIndex(int iClan) { }

	// RVA: 0xC53110 Offset: 0xC51B10 VA: 0x180C53110
	public static string GetClanName(CSteamID steamIDClan) { }

	// RVA: 0xC532F0 Offset: 0xC51CF0 VA: 0x180C532F0
	public static string GetClanTag(CSteamID steamIDClan) { }

	// RVA: 0xC52E20 Offset: 0xC51820 VA: 0x180C52E20
	public static bool GetClanActivityCounts(CSteamID steamIDClan, out int pnOnline, out int pnInGame, out int pnChatting) { }

	// RVA: 0xC52C50 Offset: 0xC51650 VA: 0x180C52C50
	public static SteamAPICall_t DownloadClanActivityCounts(CSteamID[] psteamIDClans, int cClansToRequest) { }

	// RVA: 0xC53640 Offset: 0xC52040 VA: 0x180C53640
	public static int GetFriendCountFromSource(CSteamID steamIDSource) { }

	// RVA: 0xC536E0 Offset: 0xC520E0 VA: 0x180C536E0
	public static CSteamID GetFriendFromSourceByIndex(CSteamID steamIDSource, int iFriend) { }

	// RVA: 0xC545B0 Offset: 0xC52FB0 VA: 0x180C545B0
	public static bool IsUserInSource(CSteamID steamIDUser, CSteamID steamIDSource) { }

	// RVA: 0xC54C60 Offset: 0xC53660 VA: 0x180C54C60
	public static void SetInGameVoiceSpeaking(CSteamID steamIDUser, bool bSpeaking) { }

	// RVA: 0xC52A50 Offset: 0xC51450 VA: 0x180C52A50
	public static void ActivateGameOverlay(string pchDialog) { }

	// RVA: 0xC52830 Offset: 0xC51230 VA: 0x180C52830
	public static void ActivateGameOverlayToUser(string pchDialog, CSteamID steamID) { }

	// RVA: 0xC52940 Offset: 0xC51340 VA: 0x180C52940
	public static void ActivateGameOverlayToWebPage(string pchURL, EActivateGameOverlayToWebPageMode eMode = 0) { }

	// RVA: 0xC527D0 Offset: 0xC511D0 VA: 0x180C527D0
	public static void ActivateGameOverlayToStore(AppId_t nAppID, EOverlayToStoreFlag eFlag) { }

	// RVA: 0xC54E50 Offset: 0xC53850 VA: 0x180C54E50
	public static void SetPlayedWith(CSteamID steamIDUserPlayedWith) { }

	// RVA: 0xC52730 Offset: 0xC51130 VA: 0x180C52730
	public static void ActivateGameOverlayInviteDialog(CSteamID steamIDLobby) { }

	// RVA: 0xC541B0 Offset: 0xC52BB0 VA: 0x180C541B0
	public static int GetSmallFriendAvatar(CSteamID steamIDFriend) { }

	// RVA: 0xC53F10 Offset: 0xC52910 VA: 0x180C53F10
	public static int GetMediumFriendAvatar(CSteamID steamIDFriend) { }

	// RVA: 0xC53EC0 Offset: 0xC528C0 VA: 0x180C53EC0
	public static int GetLargeFriendAvatar(CSteamID steamIDFriend) { }

	// RVA: 0xC54AE0 Offset: 0xC534E0 VA: 0x180C54AE0
	public static bool RequestUserInformation(CSteamID steamIDUser, bool bRequireNameOnly) { }

	// RVA: 0xC54970 Offset: 0xC53370 VA: 0x180C54970
	public static SteamAPICall_t RequestClanOfficerList(CSteamID steamIDClan) { }

	// RVA: 0xC53260 Offset: 0xC51C60 VA: 0x180C53260
	public static CSteamID GetClanOwner(CSteamID steamIDClan) { }

	// RVA: 0xC53210 Offset: 0xC51C10 VA: 0x180C53210
	public static int GetClanOfficerCount(CSteamID steamIDClan) { }

	// RVA: 0xC53170 Offset: 0xC51B70 VA: 0x180C53170
	public static CSteamID GetClanOfficerByIndex(CSteamID steamIDClan, int iOfficer) { }

	// RVA: 0xC54200 Offset: 0xC52C00 VA: 0x180C54200
	public static uint GetUserRestrictions() { }

	// RVA: 0xC54EA0 Offset: 0xC538A0 VA: 0x180C54EA0
	public static bool SetRichPresence(string pchKey, string pchValue) { }

	// RVA: 0xC52BB0 Offset: 0xC515B0 VA: 0x180C52BB0
	public static void ClearRichPresence() { }

	// RVA: 0xC53B30 Offset: 0xC52530 VA: 0x180C53B30
	public static string GetFriendRichPresence(CSteamID steamIDFriend, string pchKey) { }

	// RVA: 0xC53AE0 Offset: 0xC524E0 VA: 0x180C53AE0
	public static int GetFriendRichPresenceKeyCount(CSteamID steamIDFriend) { }

	// RVA: 0xC53A70 Offset: 0xC52470 VA: 0x180C53A70
	public static string GetFriendRichPresenceKeyByIndex(CSteamID steamIDFriend, int iKey) { }

	// RVA: 0xC54A90 Offset: 0xC53490 VA: 0x180C54A90
	public static void RequestFriendRichPresence(CSteamID steamIDFriend) { }

	// RVA: 0xC542B0 Offset: 0xC52CB0 VA: 0x180C542B0
	public static bool InviteUserToGame(CSteamID steamIDFriend, string pchConnectString) { }

	// RVA: 0xC53350 Offset: 0xC51D50 VA: 0x180C53350
	public static int GetCoplayFriendCount() { }

	// RVA: 0xC533A0 Offset: 0xC51DA0 VA: 0x180C533A0
	public static CSteamID GetCoplayFriend(int iCoplayFriend) { }

	// RVA: 0xC535F0 Offset: 0xC51FF0 VA: 0x180C535F0
	public static int GetFriendCoplayTime(CSteamID steamIDFriend) { }

	// RVA: 0xC53560 Offset: 0xC51F60 VA: 0x180C53560
	public static AppId_t GetFriendCoplayGame(CSteamID steamIDFriend) { }

	// RVA: 0xC54610 Offset: 0xC53010 VA: 0x180C54610
	public static SteamAPICall_t JoinClanChatRoom(CSteamID steamIDClan) { }

	// RVA: 0xC546A0 Offset: 0xC530A0 VA: 0x180C546A0
	public static bool LeaveClanChatRoom(CSteamID steamIDClan) { }

	// RVA: 0xC52F40 Offset: 0xC51940 VA: 0x180C52F40
	public static int GetClanChatMemberCount(CSteamID steamIDClan) { }

	// RVA: 0xC52D80 Offset: 0xC51780 VA: 0x180C52D80
	public static CSteamID GetChatMemberByIndex(CSteamID steamIDClan, int iUser) { }

	// RVA: 0xC54B40 Offset: 0xC53540 VA: 0x180C54B40
	public static bool SendClanChatMessage(CSteamID steamIDClanChat, string pchText) { }

	// RVA: 0xC52F90 Offset: 0xC51990 VA: 0x180C52F90
	public static int GetClanChatMessage(CSteamID steamIDClanChat, int iMessage, out string prgchText, int cchTextMax, out EChatEntryType peChatEntryType, out CSteamID psteamidChatter) { }

	// RVA: 0xC543D0 Offset: 0xC52DD0 VA: 0x180C543D0
	public static bool IsClanChatAdmin(CSteamID steamIDClanChat, CSteamID steamIDUser) { }

	// RVA: 0xC54430 Offset: 0xC52E30 VA: 0x180C54430
	public static bool IsClanChatWindowOpenInSteam(CSteamID steamIDClanChat) { }

	// RVA: 0xC546F0 Offset: 0xC530F0 VA: 0x180C546F0
	public static bool OpenClanChatWindowInSteam(CSteamID steamIDClanChat) { }

	// RVA: 0xC52C00 Offset: 0xC51600 VA: 0x180C52C00
	public static bool CloseClanChatWindowInSteam(CSteamID steamIDClanChat) { }

	// RVA: 0xC54CC0 Offset: 0xC536C0 VA: 0x180C54CC0
	public static bool SetListenForFriendsMessages(bool bInterceptEnabled) { }

	// RVA: 0xC54850 Offset: 0xC53250 VA: 0x180C54850
	public static bool ReplyToFriendMessage(CSteamID steamIDFriend, string pchMsgToSend) { }

	// RVA: 0xC537E0 Offset: 0xC521E0 VA: 0x180C537E0
	public static int GetFriendMessage(CSteamID steamIDFriend, int iMessageID, out string pvData, int cubData, out EChatEntryType peChatEntryType) { }

	// RVA: 0xC53430 Offset: 0xC51E30 VA: 0x180C53430
	public static SteamAPICall_t GetFollowerCount(CSteamID steamID) { }

	// RVA: 0xC54520 Offset: 0xC52F20 VA: 0x180C54520
	public static SteamAPICall_t IsFollowing(CSteamID steamID) { }

	// RVA: 0xC52CF0 Offset: 0xC516F0 VA: 0x180C52CF0
	public static SteamAPICall_t EnumerateFollowingList(uint unStartIndex) { }

	// RVA: 0xC544D0 Offset: 0xC52ED0 VA: 0x180C544D0
	public static bool IsClanPublic(CSteamID steamIDClan) { }

	// RVA: 0xC54480 Offset: 0xC52E80 VA: 0x180C54480
	public static bool IsClanOfficialGameGroup(CSteamID steamIDClan) { }

	// RVA: 0xC53F60 Offset: 0xC52960 VA: 0x180C53F60
	public static int GetNumChatsWithUnreadPriorityMessages() { }

	// RVA: 0xC52780 Offset: 0xC51180 VA: 0x180C52780
	public static void ActivateGameOverlayRemotePlayTogetherInviteDialog(CSteamID steamIDLobby) { }

	// RVA: 0xC54740 Offset: 0xC53140 VA: 0x180C54740
	public static bool RegisterProtocolInOverlayBrowser(string pchProtocol) { }

	// RVA: 0xC52630 Offset: 0xC51030 VA: 0x180C52630
	public static void ActivateGameOverlayInviteDialogConnectString(string pchConnectString) { }

	// RVA: 0xC54A00 Offset: 0xC53400 VA: 0x180C54A00
	public static SteamAPICall_t RequestEquippedProfileItems(CSteamID steamID) { }

	// RVA: 0xC52B50 Offset: 0xC51550 VA: 0x180C52B50
	public static bool BHasEquippedProfileItem(CSteamID steamID, ECommunityProfileItemType itemType) { }

	// RVA: 0xC540B0 Offset: 0xC52AB0 VA: 0x180C540B0
	public static string GetProfileItemPropertyString(CSteamID steamID, ECommunityProfileItemType itemType, ECommunityProfileItemProperty prop) { }

	// RVA: 0xC54130 Offset: 0xC52B30 VA: 0x180C54130
	public static uint GetProfileItemPropertyUint(CSteamID steamID, ECommunityProfileItemType itemType, ECommunityProfileItemProperty prop) { }
}
