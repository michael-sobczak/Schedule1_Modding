public struct GSClientDeny_t // TypeDefIndex: 14389
{
	// Fields
	public const int k_iCallback = 202;
	public CSteamID m_SteamID; // 0x0
	public EDenyReason m_eDenyReason; // 0x8
	private byte[] m_rgchOptionalText_; // 0x10

	// Properties
	public string m_rgchOptionalText { get; set; }

	// Methods

	// RVA: 0xC7BC10 Offset: 0xC7A610 VA: 0x180C7BC10
	public string get_m_rgchOptionalText() { }

	// RVA: 0xC81B70 Offset: 0xC80570 VA: 0x180C81B70
	public void set_m_rgchOptionalText(string value) { }
}
