public struct UserAchievementIconFetched_t // TypeDefIndex: 14558
{
	// Fields
	public const int k_iCallback = 1109;
	public CGameID m_nGameID; // 0x0
	private byte[] m_rgchAchievementName_; // 0x8
	public bool m_bAchieved; // 0x10
	public int m_nIconHandle; // 0x14

	// Properties
	public string m_rgchAchievementName { get; set; }

	// Methods

	// RVA: 0xC81AF0 Offset: 0xC804F0 VA: 0x180C81AF0
	public string get_m_rgchAchievementName() { }

	// RVA: 0xC81B70 Offset: 0xC80570 VA: 0x180C81B70
	public void set_m_rgchAchievementName(string value) { }
}
