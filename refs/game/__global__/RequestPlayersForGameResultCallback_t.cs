public struct RequestPlayersForGameResultCallback_t // TypeDefIndex: 14451
{
	// Fields
	public const int k_iCallback = 5212;
	public EResult m_eResult; // 0x0
	public ulong m_ullSearchID; // 0x8
	public CSteamID m_SteamIDPlayerFound; // 0x10
	public CSteamID m_SteamIDLobby; // 0x18
	public PlayerAcceptState_t m_ePlayerAcceptState; // 0x20
	public int m_nPlayerIndex; // 0x24
	public int m_nTotalPlayersFound; // 0x28
	public int m_nTotalPlayersAcceptedGame; // 0x2C
	public int m_nSuggestedTeamIndex; // 0x30
	public ulong m_ullUniqueGameID; // 0x38
}
