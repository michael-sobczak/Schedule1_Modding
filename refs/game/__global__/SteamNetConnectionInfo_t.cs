public struct SteamNetConnectionInfo_t // TypeDefIndex: 14698
{
	// Fields
	public SteamNetworkingIdentity m_identityRemote; // 0x0
	public long m_nUserData; // 0x88
	public HSteamListenSocket m_hListenSocket; // 0x90
	public SteamNetworkingIPAddr m_addrRemote; // 0x98
	public ushort m__pad1; // 0xA8
	public SteamNetworkingPOPID m_idPOPRemote; // 0xAC
	public SteamNetworkingPOPID m_idPOPRelay; // 0xB0
	public ESteamNetworkingConnectionState m_eState; // 0xB4
	public int m_eEndReason; // 0xB8
	private byte[] m_szEndDebug_; // 0xC0
	private byte[] m_szConnectionDescription_; // 0xC8
	public int m_nFlags; // 0xD0
	public uint[] reserved; // 0xD8

	// Properties
	public string m_szEndDebug { get; set; }
	public string m_szConnectionDescription { get; set; }

	// Methods

	// RVA: 0xCB2EE0 Offset: 0xCB18E0 VA: 0x180CB2EE0
	public string get_m_szEndDebug() { }

	// RVA: 0xC81B70 Offset: 0xC80570 VA: 0x180C81B70
	public void set_m_szEndDebug(string value) { }

	// RVA: 0xCB2E60 Offset: 0xCB1860 VA: 0x180CB2E60
	public string get_m_szConnectionDescription() { }

	// RVA: 0xC81B70 Offset: 0xC80570 VA: 0x180C81B70
	public void set_m_szConnectionDescription(string value) { }
}
