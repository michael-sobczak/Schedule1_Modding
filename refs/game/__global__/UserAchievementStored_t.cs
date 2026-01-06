public struct UserAchievementStored_t // TypeDefIndex: 14552
{
	// Fields
	public const int k_iCallback = 1103;
	public ulong m_nGameID; // 0x0
	public bool m_bGroupAchievement; // 0x8
	private byte[] m_rgchAchievementName_; // 0x10
	public uint m_nCurProgress; // 0x18
	public uint m_nMaxProgress; // 0x1C

	// Properties
	public string m_rgchAchievementName { get; set; }

	// Methods

	// RVA: 0xC7BC10 Offset: 0xC7A610 VA: 0x180C7BC10
	public string get_m_rgchAchievementName() { }

	// RVA: 0xC81B70 Offset: 0xC80570 VA: 0x180C81B70
	public void set_m_rgchAchievementName(string value) { }
}
