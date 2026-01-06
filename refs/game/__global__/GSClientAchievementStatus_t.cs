public struct GSClientAchievementStatus_t // TypeDefIndex: 14391
{
	// Fields
	public const int k_iCallback = 206;
	public ulong m_SteamID; // 0x0
	private byte[] m_pchAchievement_; // 0x8
	public bool m_bUnlocked; // 0x10

	// Properties
	public string m_pchAchievement { get; set; }

	// Methods

	// RVA: 0xC81AF0 Offset: 0xC804F0 VA: 0x180C81AF0
	public string get_m_pchAchievement() { }

	// RVA: 0xC81B70 Offset: 0xC80570 VA: 0x180C81B70
	public void set_m_pchAchievement(string value) { }
}
