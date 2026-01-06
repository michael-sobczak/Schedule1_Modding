public struct GameServerChangeRequested_t // TypeDefIndex: 14366
{
	// Fields
	public const int k_iCallback = 332;
	private byte[] m_rgchServer_; // 0x0
	private byte[] m_rgchPassword_; // 0x8

	// Properties
	public string m_rgchServer { get; set; }
	public string m_rgchPassword { get; set; }

	// Methods

	// RVA: 0xC81CD0 Offset: 0xC806D0 VA: 0x180C81CD0
	public string get_m_rgchServer() { }

	// RVA: 0xC81D50 Offset: 0xC80750 VA: 0x180C81D50
	public void set_m_rgchServer(string value) { }

	// RVA: 0xC81AF0 Offset: 0xC804F0 VA: 0x180C81AF0
	public string get_m_rgchPassword() { }

	// RVA: 0xC81D50 Offset: 0xC80750 VA: 0x180C81D50
	public void set_m_rgchPassword(string value) { }
}
