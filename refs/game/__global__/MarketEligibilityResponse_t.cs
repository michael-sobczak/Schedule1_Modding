public struct MarketEligibilityResponse_t // TypeDefIndex: 14547
{
	// Fields
	public const int k_iCallback = 166;
	public bool m_bAllowed; // 0x0
	public EMarketNotAllowedReasonFlags m_eNotAllowedReason; // 0x4
	public RTime32 m_rtAllowedAtTime; // 0x8
	public int m_cdaySteamGuardRequiredDays; // 0xC
	public int m_cdayNewDeviceCooldown; // 0x10
}
