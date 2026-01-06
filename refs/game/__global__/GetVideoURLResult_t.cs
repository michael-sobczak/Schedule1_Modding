public struct GetVideoURLResult_t // TypeDefIndex: 14571
{
	// Fields
	public const int k_iCallback = 4611;
	public EResult m_eResult; // 0x0
	public AppId_t m_unVideoAppID; // 0x4
	private byte[] m_rgchURL_; // 0x8

	// Properties
	public string m_rgchURL { get; set; }

	// Methods

	// RVA: 0xC81AF0 Offset: 0xC804F0 VA: 0x180C81AF0
	public string get_m_rgchURL() { }

	// RVA: 0xC81C20 Offset: 0xC80620 VA: 0x180C81C20
	public void set_m_rgchURL(string value) { }
}
