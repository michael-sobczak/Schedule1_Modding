public static class SteamGameServerNetworking // TypeDefIndex: 14327
{
	// Methods

	// RVA: 0xC5DE40 Offset: 0xC5C840 VA: 0x180C5DE40
	public static bool SendP2PPacket(CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel = 0) { }

	// RVA: 0xC5DBA0 Offset: 0xC5C5A0 VA: 0x180C5DBA0
	public static bool IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel = 0) { }

	// RVA: 0xC5DC00 Offset: 0xC5C600 VA: 0x180C5DC00
	public static bool ReadP2PPacket(byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel = 0) { }

	// RVA: 0xC5D4E0 Offset: 0xC5BEE0 VA: 0x180C5D4E0
	public static bool AcceptP2PSessionWithUser(CSteamID steamIDRemote) { }

	// RVA: 0xC5D5E0 Offset: 0xC5BFE0 VA: 0x180C5D5E0
	public static bool CloseP2PSessionWithUser(CSteamID steamIDRemote) { }

	// RVA: 0xC5D580 Offset: 0xC5BF80 VA: 0x180C5D580
	public static bool CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel) { }

	// RVA: 0xC5D980 Offset: 0xC5C380 VA: 0x180C5D980
	public static bool GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState) { }

	// RVA: 0xC5D530 Offset: 0xC5BF30 VA: 0x180C5D530
	public static bool AllowP2PPacketRelay(bool bAllow) { }

	// RVA: 0xC5D6C0 Offset: 0xC5C0C0 VA: 0x180C5D6C0
	public static SNetListenSocket_t CreateListenSocket(int nVirtualP2PPort, SteamIPAddress_t nIP, ushort nPort, bool bAllowUseOfPacketRelay) { }

	// RVA: 0xC5D760 Offset: 0xC5C160 VA: 0x180C5D760
	public static SNetSocket_t CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay) { }

	// RVA: 0xC5D630 Offset: 0xC5C030 VA: 0x180C5D630
	public static SNetSocket_t CreateConnectionSocket(SteamIPAddress_t nIP, ushort nPort, int nTimeoutSec) { }

	// RVA: 0xC5D850 Offset: 0xC5C250 VA: 0x180C5D850
	public static bool DestroySocket(SNetSocket_t hSocket, bool bNotifyRemoteEnd) { }

	// RVA: 0xC5D7F0 Offset: 0xC5C1F0 VA: 0x180C5D7F0
	public static bool DestroyListenSocket(SNetListenSocket_t hSocket, bool bNotifyRemoteEnd) { }

	// RVA: 0xC5DDB0 Offset: 0xC5C7B0 VA: 0x180C5DDB0
	public static bool SendDataOnSocket(SNetSocket_t hSocket, byte[] pubData, uint cubData, bool bReliable) { }

	// RVA: 0xC5DAC0 Offset: 0xC5C4C0 VA: 0x180C5DAC0
	public static bool IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize) { }

	// RVA: 0xC5DC90 Offset: 0xC5C690 VA: 0x180C5DC90
	public static bool RetrieveDataFromSocket(SNetSocket_t hSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize) { }

	// RVA: 0xC5DB20 Offset: 0xC5C520 VA: 0x180C5DB20
	public static bool IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket) { }

	// RVA: 0xC5DD20 Offset: 0xC5C720 VA: 0x180C5DD20
	public static bool RetrieveData(SNetListenSocket_t hListenSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket) { }

	// RVA: 0xC5DA30 Offset: 0xC5C430 VA: 0x180C5DA30
	public static bool GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out SteamIPAddress_t punIPRemote, out ushort punPortRemote) { }

	// RVA: 0xC5D8B0 Offset: 0xC5C2B0 VA: 0x180C5D8B0
	public static bool GetListenSocketInfo(SNetListenSocket_t hListenSocket, out SteamIPAddress_t pnIP, out ushort pnPort) { }

	// RVA: 0xC5D9E0 Offset: 0xC5C3E0 VA: 0x180C5D9E0
	public static ESNetSocketConnectionType GetSocketConnectionType(SNetSocket_t hSocket) { }

	// RVA: 0xC5D930 Offset: 0xC5C330 VA: 0x180C5D930
	public static int GetMaxPacketSize(SNetSocket_t hSocket) { }
}
