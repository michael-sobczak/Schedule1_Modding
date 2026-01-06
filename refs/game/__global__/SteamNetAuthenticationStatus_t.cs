public struct SteamNetAuthenticationStatus_t // TypeDefIndex: 14483
{
	// Fields
	public const int k_iCallback = 1222;
	public ESteamNetworkingAvailability m_eAvail; // 0x0
	private byte[] m_debugMsg_; // 0x8

	// Properties
	public string m_debugMsg { get; set; }

	// Methods

	// RVA: 0xC81AF0 Offset: 0xC804F0 VA: 0x180C81AF0
	public string get_m_debugMsg() { }

	// RVA: 0xC81C20 Offset: 0xC80620 VA: 0x180C81C20
	public void set_m_debugMsg(string value) { }
}
