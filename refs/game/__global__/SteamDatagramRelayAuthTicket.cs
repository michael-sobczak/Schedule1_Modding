public struct SteamDatagramRelayAuthTicket // TypeDefIndex: 14765
{
	// Fields
	private SteamNetworkingIdentity m_identityGameserver; // 0x0
	private SteamNetworkingIdentity m_identityAuthorizedClient; // 0x88
	private uint m_unPublicIP; // 0x110
	private RTime32 m_rtimeTicketExpiry; // 0x114
	private SteamDatagramHostedAddress m_routing; // 0x118
	private uint m_nAppID; // 0x128
	private int m_nRestrictToVirtualPort; // 0x12C
	private const int k_nMaxExtraFields = 16;
	private int m_nExtraFields; // 0x130
	private SteamDatagramRelayAuthTicket.ExtraField[] m_vecExtraFields; // 0x138

	// Methods

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void Clear() { }
}
