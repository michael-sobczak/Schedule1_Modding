public struct SteamRelayNetworkStatus_t // TypeDefIndex: 14484
{
	// Fields
	public const int k_iCallback = 1281;
	public ESteamNetworkingAvailability m_eAvail; // 0x0
	public int m_bPingMeasurementInProgress; // 0x4
	public ESteamNetworkingAvailability m_eAvailNetworkConfig; // 0x8
	public ESteamNetworkingAvailability m_eAvailAnyRelay; // 0xC
	private byte[] m_debugMsg_; // 0x10

	// Properties
	public string m_debugMsg { get; set; }

	// Methods

	// RVA: 0xC7BC10 Offset: 0xC7A610 VA: 0x180C7BC10
	public string get_m_debugMsg() { }

	// RVA: 0xC81C20 Offset: 0xC80620 VA: 0x180C81C20
	public void set_m_debugMsg(string value) { }
}
