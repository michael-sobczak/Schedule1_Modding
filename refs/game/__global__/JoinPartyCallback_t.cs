public struct JoinPartyCallback_t // TypeDefIndex: 14455
{
	// Fields
	public const int k_iCallback = 5301;
	public EResult m_eResult; // 0x0
	public PartyBeaconID_t m_ulBeaconID; // 0x8
	public CSteamID m_SteamIDBeaconOwner; // 0x10
	private byte[] m_rgchConnectString_; // 0x18

	// Properties
	public string m_rgchConnectString { get; set; }

	// Methods

	// RVA: 0xC85B40 Offset: 0xC84540 VA: 0x180C85B40
	public string get_m_rgchConnectString() { }

	// RVA: 0xC81C20 Offset: 0xC80620 VA: 0x180C81C20
	public void set_m_rgchConnectString(string value) { }
}
