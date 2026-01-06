public static class SteamNetworkingMessages // TypeDefIndex: 14345
{
	// Methods

	// RVA: 0xC6F130 Offset: 0xC6DB30 VA: 0x180C6F130
	public static EResult SendMessageToUser(ref SteamNetworkingIdentity identityRemote, IntPtr pubData, uint cubData, int nSendFlags, int nRemoteChannel) { }

	// RVA: 0xC6F060 Offset: 0xC6DA60 VA: 0x180C6F060
	public static int ReceiveMessagesOnChannel(int nLocalChannel, IntPtr[] ppOutMessages, int nMaxMessages) { }

	// RVA: 0xC6EEC0 Offset: 0xC6D8C0 VA: 0x180C6EEC0
	public static bool AcceptSessionWithUser(ref SteamNetworkingIdentity identityRemote) { }

	// RVA: 0xC6EF80 Offset: 0xC6D980 VA: 0x180C6EF80
	public static bool CloseSessionWithUser(ref SteamNetworkingIdentity identityRemote) { }

	// RVA: 0xC6EF20 Offset: 0xC6D920 VA: 0x180C6EF20
	public static bool CloseChannelWithUser(ref SteamNetworkingIdentity identityRemote, int nLocalChannel) { }

	// RVA: 0xC6EFE0 Offset: 0xC6D9E0 VA: 0x180C6EFE0
	public static ESteamNetworkingConnectionState GetSessionConnectionInfo(ref SteamNetworkingIdentity identityRemote, out SteamNetConnectionInfo_t pConnectionInfo, out SteamNetConnectionRealTimeStatus_t pQuickStatus) { }
}
