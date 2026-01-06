public enum ESteamNetConnectionEnd // TypeDefIndex: 14678
{
	// Fields
	public int value__; // 0x0
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Invalid = 0;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_App_Min = 1000;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_App_Generic = 1000;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_App_Max = 1999;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_AppException_Min = 2000;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_AppException_Generic = 2000;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_AppException_Max = 2999;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Local_Min = 3000;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Local_OfflineMode = 3001;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Local_ManyRelayConnectivity = 3002;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Local_HostedServerPrimaryRelay = 3003;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Local_NetworkConfig = 3004;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Local_Rights = 3005;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Local_P2P_ICE_NoPublicAddresses = 3006;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Local_Max = 3999;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Remote_Min = 4000;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Remote_Timeout = 4001;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Remote_BadCrypt = 4002;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Remote_BadCert = 4003;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Remote_BadProtocolVersion = 4006;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Remote_P2P_ICE_NoPublicAddresses = 4007;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Remote_Max = 4999;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Misc_Min = 5000;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Misc_Generic = 5001;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Misc_InternalError = 5002;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Misc_Timeout = 5003;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Misc_SteamConnectivity = 5005;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Misc_NoRelaySessionsToClient = 5006;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Misc_P2P_Rendezvous = 5008;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Misc_P2P_NAT_Firewall = 5009;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Misc_PeerSentNoConnection = 5010;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Misc_Max = 5999;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd__Force32Bit = 2147483647;
}
