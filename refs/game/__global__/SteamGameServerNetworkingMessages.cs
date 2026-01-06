public static class SteamGameServerNetworkingMessages // TypeDefIndex: 14328
{
	// Methods

	// RVA: 0xC5AD50 Offset: 0xC59750 VA: 0x180C5AD50
	public static EResult SendMessageToUser(ref SteamNetworkingIdentity identityRemote, IntPtr pubData, uint cubData, int nSendFlags, int nRemoteChannel) { }

	// RVA: 0xC5AC80 Offset: 0xC59680 VA: 0x180C5AC80
	public static int ReceiveMessagesOnChannel(int nLocalChannel, IntPtr[] ppOutMessages, int nMaxMessages) { }

	// RVA: 0xC5AB00 Offset: 0xC59500 VA: 0x180C5AB00
	public static bool AcceptSessionWithUser(ref SteamNetworkingIdentity identityRemote) { }

	// RVA: 0xC5ABB0 Offset: 0xC595B0 VA: 0x180C5ABB0
	public static bool CloseSessionWithUser(ref SteamNetworkingIdentity identityRemote) { }

	// RVA: 0xC5AB50 Offset: 0xC59550 VA: 0x180C5AB50
	public static bool CloseChannelWithUser(ref SteamNetworkingIdentity identityRemote, int nLocalChannel) { }

	// RVA: 0xC5AC00 Offset: 0xC59600 VA: 0x180C5AC00
	public static ESteamNetworkingConnectionState GetSessionConnectionInfo(ref SteamNetworkingIdentity identityRemote, out SteamNetConnectionInfo_t pConnectionInfo, out SteamNetConnectionRealTimeStatus_t pQuickStatus) { }
}
