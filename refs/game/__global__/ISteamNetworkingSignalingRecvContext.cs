public struct ISteamNetworkingSignalingRecvContext // TypeDefIndex: 14788
{
	// Methods

	// RVA: 0xC84980 Offset: 0xC83380 VA: 0x180C84980
	public IntPtr OnConnectRequest(HSteamNetConnection hConn, ref SteamNetworkingIdentity identityPeer, int nLocalVirtualPort) { }

	// RVA: 0xC84A20 Offset: 0xC83420 VA: 0x180C84A20
	public void SendRejectionSignal(ref SteamNetworkingIdentity identityPeer, IntPtr pMsg, int cbMsg) { }
}
