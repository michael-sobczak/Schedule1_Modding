public static class SteamNetworking // TypeDefIndex: 14344
{
	// Methods

	// RVA: 0xC722F0 Offset: 0xC70CF0 VA: 0x180C722F0
	public static bool SendP2PPacket(CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel = 0) { }

	// RVA: 0xC72050 Offset: 0xC70A50 VA: 0x180C72050
	public static bool IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel = 0) { }

	// RVA: 0xC720B0 Offset: 0xC70AB0 VA: 0x180C720B0
	public static bool ReadP2PPacket(byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel = 0) { }

	// RVA: 0xC71990 Offset: 0xC70390 VA: 0x180C71990
	public static bool AcceptP2PSessionWithUser(CSteamID steamIDRemote) { }

	// RVA: 0xC71A90 Offset: 0xC70490 VA: 0x180C71A90
	public static bool CloseP2PSessionWithUser(CSteamID steamIDRemote) { }

	// RVA: 0xC71A30 Offset: 0xC70430 VA: 0x180C71A30
	public static bool CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel) { }

	// RVA: 0xC71E30 Offset: 0xC70830 VA: 0x180C71E30
	public static bool GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState) { }

	// RVA: 0xC719E0 Offset: 0xC703E0 VA: 0x180C719E0
	public static bool AllowP2PPacketRelay(bool bAllow) { }

	// RVA: 0xC71B70 Offset: 0xC70570 VA: 0x180C71B70
	public static SNetListenSocket_t CreateListenSocket(int nVirtualP2PPort, SteamIPAddress_t nIP, ushort nPort, bool bAllowUseOfPacketRelay) { }

	// RVA: 0xC71C10 Offset: 0xC70610 VA: 0x180C71C10
	public static SNetSocket_t CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay) { }

	// RVA: 0xC71AE0 Offset: 0xC704E0 VA: 0x180C71AE0
	public static SNetSocket_t CreateConnectionSocket(SteamIPAddress_t nIP, ushort nPort, int nTimeoutSec) { }

	// RVA: 0xC71D00 Offset: 0xC70700 VA: 0x180C71D00
	public static bool DestroySocket(SNetSocket_t hSocket, bool bNotifyRemoteEnd) { }

	// RVA: 0xC71CA0 Offset: 0xC706A0 VA: 0x180C71CA0
	public static bool DestroyListenSocket(SNetListenSocket_t hSocket, bool bNotifyRemoteEnd) { }

	// RVA: 0xC72260 Offset: 0xC70C60 VA: 0x180C72260
	public static bool SendDataOnSocket(SNetSocket_t hSocket, byte[] pubData, uint cubData, bool bReliable) { }

	// RVA: 0xC71F70 Offset: 0xC70970 VA: 0x180C71F70
	public static bool IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize) { }

	// RVA: 0xC72140 Offset: 0xC70B40 VA: 0x180C72140
	public static bool RetrieveDataFromSocket(SNetSocket_t hSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize) { }

	// RVA: 0xC71FD0 Offset: 0xC709D0 VA: 0x180C71FD0
	public static bool IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket) { }

	// RVA: 0xC721D0 Offset: 0xC70BD0 VA: 0x180C721D0
	public static bool RetrieveData(SNetListenSocket_t hListenSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket) { }

	// RVA: 0xC71EE0 Offset: 0xC708E0 VA: 0x180C71EE0
	public static bool GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out SteamIPAddress_t punIPRemote, out ushort punPortRemote) { }

	// RVA: 0xC71D60 Offset: 0xC70760 VA: 0x180C71D60
	public static bool GetListenSocketInfo(SNetListenSocket_t hListenSocket, out SteamIPAddress_t pnIP, out ushort pnPort) { }

	// RVA: 0xC71E90 Offset: 0xC70890 VA: 0x180C71E90
	public static ESNetSocketConnectionType GetSocketConnectionType(SNetSocket_t hSocket) { }

	// RVA: 0xC71DE0 Offset: 0xC707E0 VA: 0x180C71DE0
	public static int GetMaxPacketSize(SNetSocket_t hSocket) { }
}
