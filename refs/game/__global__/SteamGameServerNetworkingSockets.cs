public static class SteamGameServerNetworkingSockets // TypeDefIndex: 14329
{
	// Methods

	// RVA: 0xC5B4A0 Offset: 0xC59EA0 VA: 0x180C5B4A0
	public static HSteamListenSocket CreateListenSocketIP(ref SteamNetworkingIPAddr localAddress, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0xC5B0A0 Offset: 0xC59AA0 VA: 0x180C5B0A0
	public static HSteamNetConnection ConnectByIPAddress(ref SteamNetworkingIPAddr address, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0xC5B600 Offset: 0xC5A000 VA: 0x180C5B600
	public static HSteamListenSocket CreateListenSocketP2P(int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0xC5B220 Offset: 0xC59C20 VA: 0x180C5B220
	public static HSteamNetConnection ConnectP2P(ref SteamNetworkingIdentity identityRemote, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0xC5ADE0 Offset: 0xC597E0 VA: 0x180C5ADE0
	public static EResult AcceptConnection(HSteamNetConnection hConn) { }

	// RVA: 0xC5AE80 Offset: 0xC59880 VA: 0x180C5AE80
	public static bool CloseConnection(HSteamNetConnection hPeer, int nReason, string pszDebug, bool bEnableLinger) { }

	// RVA: 0xC5AFC0 Offset: 0xC599C0 VA: 0x180C5AFC0
	public static bool CloseListenSocket(HSteamListenSocket hSocket) { }

	// RVA: 0xC5C6A0 Offset: 0xC5B0A0 VA: 0x180C5C6A0
	public static bool SetConnectionUserData(HSteamNetConnection hPeer, long nUserData) { }

	// RVA: 0xC5BBD0 Offset: 0xC5A5D0 VA: 0x180C5BBD0
	public static long GetConnectionUserData(HSteamNetConnection hPeer) { }

	// RVA: 0xC5C530 Offset: 0xC5AF30 VA: 0x180C5C530
	public static void SetConnectionName(HSteamNetConnection hPeer, string pszName) { }

	// RVA: 0xC5BA30 Offset: 0xC5A430 VA: 0x180C5BA30
	public static bool GetConnectionName(HSteamNetConnection hPeer, out string pszName, int nMaxLen) { }

	// RVA: 0xC5C3A0 Offset: 0xC5ADA0 VA: 0x180C5C3A0
	public static EResult SendMessageToConnection(HSteamNetConnection hConn, IntPtr pData, uint cbData, int nSendFlags, out long pOutMessageNumber) { }

	// RVA: 0xC5C430 Offset: 0xC5AE30 VA: 0x180C5C430
	public static void SendMessages(int nMessages, IntPtr[] pMessages, long[] pOutMessageNumberOrResult) { }

	// RVA: 0xC5B8B0 Offset: 0xC5A2B0 VA: 0x180C5B8B0
	public static EResult FlushMessagesOnConnection(HSteamNetConnection hConn) { }

	// RVA: 0xC5C060 Offset: 0xC5AA60 VA: 0x180C5C060
	public static int ReceiveMessagesOnConnection(HSteamNetConnection hConn, IntPtr[] ppOutMessages, int nMaxMessages) { }

	// RVA: 0xC5B9D0 Offset: 0xC5A3D0 VA: 0x180C5B9D0
	public static bool GetConnectionInfo(HSteamNetConnection hConn, out SteamNetConnectionInfo_t pInfo) { }

	// RVA: 0xC5BB40 Offset: 0xC5A540 VA: 0x180C5BB40
	public static EResult GetConnectionRealTimeStatus(HSteamNetConnection hConn, ref SteamNetConnectionRealTimeStatus_t pStatus, int nLanes, ref SteamNetConnectionRealTimeLaneStatus_t pLanes) { }

	// RVA: 0xC5BC20 Offset: 0xC5A620 VA: 0x180C5BC20
	public static int GetDetailedConnectionStatus(HSteamNetConnection hConn, out string pszBuf, int cbBuf) { }

	// RVA: 0xC5BF50 Offset: 0xC5A950 VA: 0x180C5BF50
	public static bool GetListenSocketAddress(HSteamListenSocket hSocket, out SteamNetworkingIPAddr address) { }

	// RVA: 0xC5B740 Offset: 0xC5A140 VA: 0x180C5B740
	public static bool CreateSocketPair(out HSteamNetConnection pOutConnection1, out HSteamNetConnection pOutConnection2, bool bUseNetworkLoopback, ref SteamNetworkingIdentity pIdentity1, ref SteamNetworkingIdentity pIdentity2) { }

	// RVA: 0xC5B010 Offset: 0xC59A10 VA: 0x180C5B010
	public static EResult ConfigureConnectionLanes(HSteamNetConnection hConn, int nNumLanes, int[] pLanePriorities, ushort[] pLaneWeights) { }

	// RVA: 0xC5BF00 Offset: 0xC5A900 VA: 0x180C5BF00
	public static bool GetIdentity(out SteamNetworkingIdentity pIdentity) { }

	// RVA: 0xC5C010 Offset: 0xC5AA10 VA: 0x180C5C010
	public static ESteamNetworkingAvailability InitAuthentication() { }

	// RVA: 0xC5B900 Offset: 0xC5A300 VA: 0x180C5B900
	public static ESteamNetworkingAvailability GetAuthenticationStatus(out SteamNetAuthenticationStatus_t pDetails) { }

	// RVA: 0xC5B6B0 Offset: 0xC5A0B0 VA: 0x180C5B6B0
	public static HSteamNetPollGroup CreatePollGroup() { }

	// RVA: 0xC5B7E0 Offset: 0xC5A1E0 VA: 0x180C5B7E0
	public static bool DestroyPollGroup(HSteamNetPollGroup hPollGroup) { }

	// RVA: 0xC5C640 Offset: 0xC5B040 VA: 0x180C5C640
	public static bool SetConnectionPollGroup(HSteamNetConnection hConn, HSteamNetPollGroup hPollGroup) { }

	// RVA: 0xC5C130 Offset: 0xC5AB30 VA: 0x180C5C130
	public static int ReceiveMessagesOnPollGroup(HSteamNetPollGroup hPollGroup, IntPtr[] ppOutMessages, int nMaxMessages) { }

	// RVA: 0xC5C280 Offset: 0xC5AC80 VA: 0x180C5C280
	public static bool ReceivedRelayAuthTicket(IntPtr pvTicket, int cbTicket, out SteamDatagramRelayAuthTicket pOutParsedTicket) { }

	// RVA: 0xC5B830 Offset: 0xC5A230 VA: 0x180C5B830
	public static int FindRelayAuthTicketForServer(ref SteamNetworkingIdentity identityGameServer, int nRemoteVirtualPort, out SteamDatagramRelayAuthTicket pOutParsedTicket) { }

	// RVA: 0xC5B2E0 Offset: 0xC59CE0 VA: 0x180C5B2E0
	public static HSteamNetConnection ConnectToHostedDedicatedServer(ref SteamNetworkingIdentity identityTarget, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0xC5BEB0 Offset: 0xC5A8B0 VA: 0x180C5BEB0
	public static ushort GetHostedDedicatedServerPort() { }

	// RVA: 0xC5BE60 Offset: 0xC5A860 VA: 0x180C5BE60
	public static SteamNetworkingPOPID GetHostedDedicatedServerPOPID() { }

	// RVA: 0xC5BE10 Offset: 0xC5A810 VA: 0x180C5BE10
	public static EResult GetHostedDedicatedServerAddress(out SteamDatagramHostedAddress pRouting) { }

	// RVA: 0xC5B3F0 Offset: 0xC59DF0 VA: 0x180C5B3F0
	public static HSteamListenSocket CreateHostedDedicatedServerListenSocket(int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0xC5BD90 Offset: 0xC5A790 VA: 0x180C5BD90
	public static EResult GetGameCoordinatorServerLogin(IntPtr pLoginInfo, out int pcbSignedBlob, IntPtr pBlob) { }

	// RVA: 0xC5B150 Offset: 0xC59B50 VA: 0x180C5B150
	public static HSteamNetConnection ConnectP2PCustomSignaling(out ISteamNetworkingConnectionSignaling pSignaling, ref SteamNetworkingIdentity pPeerIdentity, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0xC5C200 Offset: 0xC5AC00 VA: 0x180C5C200
	public static bool ReceivedP2PCustomSignal(IntPtr pMsg, int cbMsg, out ISteamNetworkingSignalingRecvContext pContext) { }

	// RVA: 0xC5B950 Offset: 0xC5A350 VA: 0x180C5B950
	public static bool GetCertificateRequest(out int pcbBlob, IntPtr pBlob, out SteamNetworkingErrMsg errMsg) { }

	// RVA: 0xC5C4B0 Offset: 0xC5AEB0 VA: 0x180C5C4B0
	public static bool SetCertificate(IntPtr pCertificate, int cbCertificate, out SteamNetworkingErrMsg errMsg) { }

	// RVA: 0xC5C300 Offset: 0xC5AD00 VA: 0x180C5C300
	public static void ResetIdentity(ref SteamNetworkingIdentity pIdentity) { }

	// RVA: 0xC5C350 Offset: 0xC5AD50 VA: 0x180C5C350
	public static void RunCallbacks() { }

	// RVA: 0xC5AE30 Offset: 0xC59830 VA: 0x180C5AE30
	public static bool BeginAsyncRequestFakeIP(int nNumPorts) { }

	// RVA: 0xC5BD30 Offset: 0xC5A730 VA: 0x180C5BD30
	public static void GetFakeIP(int idxFirstPort, out SteamNetworkingFakeIPResult_t pInfo) { }

	// RVA: 0xC5B550 Offset: 0xC59F50 VA: 0x180C5B550
	public static HSteamListenSocket CreateListenSocketP2PFakeIP(int idxFakePort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0xC5BFB0 Offset: 0xC5A9B0 VA: 0x180C5BFB0
	public static EResult GetRemoteFakeIPForConnection(HSteamNetConnection hConn, out SteamNetworkingIPAddr pOutAddr) { }

	// RVA: 0xC5B3A0 Offset: 0xC59DA0 VA: 0x180C5B3A0
	public static IntPtr CreateFakeUDPPort(int idxFakeServerPort) { }
}
