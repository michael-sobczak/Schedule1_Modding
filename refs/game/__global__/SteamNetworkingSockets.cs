public static class SteamNetworkingSockets // TypeDefIndex: 14346
{
	// Methods

	// RVA: 0xC6F8B0 Offset: 0xC6E2B0 VA: 0x180C6F8B0
	public static HSteamListenSocket CreateListenSocketIP(ref SteamNetworkingIPAddr localAddress, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0xC6F480 Offset: 0xC6DE80 VA: 0x180C6F480
	public static HSteamNetConnection ConnectByIPAddress(ref SteamNetworkingIPAddr address, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0xC6FA20 Offset: 0xC6E420 VA: 0x180C6FA20
	public static HSteamListenSocket CreateListenSocketP2P(int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0xC6F610 Offset: 0xC6E010 VA: 0x180C6F610
	public static HSteamNetConnection ConnectP2P(ref SteamNetworkingIdentity identityRemote, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0xC6F1C0 Offset: 0xC6DBC0 VA: 0x180C6F1C0
	public static EResult AcceptConnection(HSteamNetConnection hConn) { }

	// RVA: 0xC6F260 Offset: 0xC6DC60 VA: 0x180C6F260
	public static bool CloseConnection(HSteamNetConnection hPeer, int nReason, string pszDebug, bool bEnableLinger) { }

	// RVA: 0xC6F3A0 Offset: 0xC6DDA0 VA: 0x180C6F3A0
	public static bool CloseListenSocket(HSteamListenSocket hSocket) { }

	// RVA: 0xC70B00 Offset: 0xC6F500 VA: 0x180C70B00
	public static bool SetConnectionUserData(HSteamNetConnection hPeer, long nUserData) { }

	// RVA: 0xC70000 Offset: 0xC6EA00 VA: 0x180C70000
	public static long GetConnectionUserData(HSteamNetConnection hPeer) { }

	// RVA: 0xC70990 Offset: 0xC6F390 VA: 0x180C70990
	public static void SetConnectionName(HSteamNetConnection hPeer, string pszName) { }

	// RVA: 0xC6FE60 Offset: 0xC6E860 VA: 0x180C6FE60
	public static bool GetConnectionName(HSteamNetConnection hPeer, out string pszName, int nMaxLen) { }

	// RVA: 0xC70800 Offset: 0xC6F200 VA: 0x180C70800
	public static EResult SendMessageToConnection(HSteamNetConnection hConn, IntPtr pData, uint cbData, int nSendFlags, out long pOutMessageNumber) { }

	// RVA: 0xC70890 Offset: 0xC6F290 VA: 0x180C70890
	public static void SendMessages(int nMessages, IntPtr[] pMessages, long[] pOutMessageNumberOrResult) { }

	// RVA: 0xC6FCD0 Offset: 0xC6E6D0 VA: 0x180C6FCD0
	public static EResult FlushMessagesOnConnection(HSteamNetConnection hConn) { }

	// RVA: 0xC704B0 Offset: 0xC6EEB0 VA: 0x180C704B0
	public static int ReceiveMessagesOnConnection(HSteamNetConnection hConn, IntPtr[] ppOutMessages, int nMaxMessages) { }

	// RVA: 0xC6FE00 Offset: 0xC6E800 VA: 0x180C6FE00
	public static bool GetConnectionInfo(HSteamNetConnection hConn, out SteamNetConnectionInfo_t pInfo) { }

	// RVA: 0xC6FF70 Offset: 0xC6E970 VA: 0x180C6FF70
	public static EResult GetConnectionRealTimeStatus(HSteamNetConnection hConn, ref SteamNetConnectionRealTimeStatus_t pStatus, int nLanes, ref SteamNetConnectionRealTimeLaneStatus_t pLanes) { }

	// RVA: 0xC70050 Offset: 0xC6EA50 VA: 0x180C70050
	public static int GetDetailedConnectionStatus(HSteamNetConnection hConn, out string pszBuf, int cbBuf) { }

	// RVA: 0xC703A0 Offset: 0xC6EDA0 VA: 0x180C703A0
	public static bool GetListenSocketAddress(HSteamListenSocket hSocket, out SteamNetworkingIPAddr address) { }

	// RVA: 0xC6FB60 Offset: 0xC6E560 VA: 0x180C6FB60
	public static bool CreateSocketPair(out HSteamNetConnection pOutConnection1, out HSteamNetConnection pOutConnection2, bool bUseNetworkLoopback, ref SteamNetworkingIdentity pIdentity1, ref SteamNetworkingIdentity pIdentity2) { }

	// RVA: 0xC6F3F0 Offset: 0xC6DDF0 VA: 0x180C6F3F0
	public static EResult ConfigureConnectionLanes(HSteamNetConnection hConn, int nNumLanes, int[] pLanePriorities, ushort[] pLaneWeights) { }

	// RVA: 0xC70340 Offset: 0xC6ED40 VA: 0x180C70340
	public static bool GetIdentity(out SteamNetworkingIdentity pIdentity) { }

	// RVA: 0xC70460 Offset: 0xC6EE60 VA: 0x180C70460
	public static ESteamNetworkingAvailability InitAuthentication() { }

	// RVA: 0xC6FD20 Offset: 0xC6E720 VA: 0x180C6FD20
	public static ESteamNetworkingAvailability GetAuthenticationStatus(out SteamNetAuthenticationStatus_t pDetails) { }

	// RVA: 0xC6FAD0 Offset: 0xC6E4D0 VA: 0x180C6FAD0
	public static HSteamNetPollGroup CreatePollGroup() { }

	// RVA: 0xC6FC00 Offset: 0xC6E600 VA: 0x180C6FC00
	public static bool DestroyPollGroup(HSteamNetPollGroup hPollGroup) { }

	// RVA: 0xC70AA0 Offset: 0xC6F4A0 VA: 0x180C70AA0
	public static bool SetConnectionPollGroup(HSteamNetConnection hConn, HSteamNetPollGroup hPollGroup) { }

	// RVA: 0xC70580 Offset: 0xC6EF80 VA: 0x180C70580
	public static int ReceiveMessagesOnPollGroup(HSteamNetPollGroup hPollGroup, IntPtr[] ppOutMessages, int nMaxMessages) { }

	// RVA: 0xC706D0 Offset: 0xC6F0D0 VA: 0x180C706D0
	public static bool ReceivedRelayAuthTicket(IntPtr pvTicket, int cbTicket, out SteamDatagramRelayAuthTicket pOutParsedTicket) { }

	// RVA: 0xC6FC50 Offset: 0xC6E650 VA: 0x180C6FC50
	public static int FindRelayAuthTicketForServer(ref SteamNetworkingIdentity identityGameServer, int nRemoteVirtualPort, out SteamDatagramRelayAuthTicket pOutParsedTicket) { }

	// RVA: 0xC6F6E0 Offset: 0xC6E0E0 VA: 0x180C6F6E0
	public static HSteamNetConnection ConnectToHostedDedicatedServer(ref SteamNetworkingIdentity identityTarget, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0xC702F0 Offset: 0xC6ECF0 VA: 0x180C702F0
	public static ushort GetHostedDedicatedServerPort() { }

	// RVA: 0xC702A0 Offset: 0xC6ECA0 VA: 0x180C702A0
	public static SteamNetworkingPOPID GetHostedDedicatedServerPOPID() { }

	// RVA: 0xC70240 Offset: 0xC6EC40 VA: 0x180C70240
	public static EResult GetHostedDedicatedServerAddress(out SteamDatagramHostedAddress pRouting) { }

	// RVA: 0xC6F800 Offset: 0xC6E200 VA: 0x180C6F800
	public static HSteamListenSocket CreateHostedDedicatedServerListenSocket(int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0xC701C0 Offset: 0xC6EBC0 VA: 0x180C701C0
	public static EResult GetGameCoordinatorServerLogin(IntPtr pLoginInfo, out int pcbSignedBlob, IntPtr pBlob) { }

	// RVA: 0xC6F540 Offset: 0xC6DF40 VA: 0x180C6F540
	public static HSteamNetConnection ConnectP2PCustomSignaling(out ISteamNetworkingConnectionSignaling pSignaling, ref SteamNetworkingIdentity pPeerIdentity, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0xC70650 Offset: 0xC6F050 VA: 0x180C70650
	public static bool ReceivedP2PCustomSignal(IntPtr pMsg, int cbMsg, out ISteamNetworkingSignalingRecvContext pContext) { }

	// RVA: 0xC6FD80 Offset: 0xC6E780 VA: 0x180C6FD80
	public static bool GetCertificateRequest(out int pcbBlob, IntPtr pBlob, out SteamNetworkingErrMsg errMsg) { }

	// RVA: 0xC70910 Offset: 0xC6F310 VA: 0x180C70910
	public static bool SetCertificate(IntPtr pCertificate, int cbCertificate, out SteamNetworkingErrMsg errMsg) { }

	// RVA: 0xC70750 Offset: 0xC6F150 VA: 0x180C70750
	public static void ResetIdentity(ref SteamNetworkingIdentity pIdentity) { }

	// RVA: 0xC707B0 Offset: 0xC6F1B0 VA: 0x180C707B0
	public static void RunCallbacks() { }

	// RVA: 0xC6F210 Offset: 0xC6DC10 VA: 0x180C6F210
	public static bool BeginAsyncRequestFakeIP(int nNumPorts) { }

	// RVA: 0xC70160 Offset: 0xC6EB60 VA: 0x180C70160
	public static void GetFakeIP(int idxFirstPort, out SteamNetworkingFakeIPResult_t pInfo) { }

	// RVA: 0xC6F970 Offset: 0xC6E370 VA: 0x180C6F970
	public static HSteamListenSocket CreateListenSocketP2PFakeIP(int idxFakePort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0xC70400 Offset: 0xC6EE00 VA: 0x180C70400
	public static EResult GetRemoteFakeIPForConnection(HSteamNetConnection hConn, out SteamNetworkingIPAddr pOutAddr) { }

	// RVA: 0xC6F7B0 Offset: 0xC6E1B0 VA: 0x180C6F7B0
	public static IntPtr CreateFakeUDPPort(int idxFakeServerPort) { }
}
