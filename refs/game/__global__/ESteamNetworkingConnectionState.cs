public enum ESteamNetworkingConnectionState // TypeDefIndex: 14677
{
	// Fields
	public int value__; // 0x0
	public const ESteamNetworkingConnectionState k_ESteamNetworkingConnectionState_None = 0;
	public const ESteamNetworkingConnectionState k_ESteamNetworkingConnectionState_Connecting = 1;
	public const ESteamNetworkingConnectionState k_ESteamNetworkingConnectionState_FindingRoute = 2;
	public const ESteamNetworkingConnectionState k_ESteamNetworkingConnectionState_Connected = 3;
	public const ESteamNetworkingConnectionState k_ESteamNetworkingConnectionState_ClosedByPeer = 4;
	public const ESteamNetworkingConnectionState k_ESteamNetworkingConnectionState_ProblemDetectedLocally = 5;
	public const ESteamNetworkingConnectionState k_ESteamNetworkingConnectionState_FinWait = -1;
	public const ESteamNetworkingConnectionState k_ESteamNetworkingConnectionState_Linger = -2;
	public const ESteamNetworkingConnectionState k_ESteamNetworkingConnectionState_Dead = -3;
	public const ESteamNetworkingConnectionState k_ESteamNetworkingConnectionState__Force32Bit = 2147483647;
}
