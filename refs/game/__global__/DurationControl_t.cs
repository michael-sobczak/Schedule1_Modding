public struct DurationControl_t // TypeDefIndex: 14548
{
	// Fields
	public const int k_iCallback = 167;
	public EResult m_eResult; // 0x0
	public AppId_t m_appid; // 0x4
	public bool m_bApplicable; // 0x8
	public int m_csecsLast5h; // 0xC
	public EDurationControlProgress m_progress; // 0x10
	public EDurationControlNotification m_notification; // 0x14
	public int m_csecsToday; // 0x18
	public int m_csecsRemaining; // 0x1C
}
