public struct SteamNetConnectionStatusChangedCallback_t // TypeDefIndex: 14482
{
	// Fields
	public const int k_iCallback = 1221;
	public HSteamNetConnection m_hConn; // 0x0
	public SteamNetConnectionInfo_t m_info; // 0x8
	public ESteamNetworkingConnectionState m_eOldState; // 0xE8
}
