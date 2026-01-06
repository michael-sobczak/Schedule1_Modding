public struct SteamUGCQueryCompleted_t // TypeDefIndex: 14516
{
	// Fields
	public const int k_iCallback = 3401;
	public UGCQueryHandle_t m_handle; // 0x0
	public EResult m_eResult; // 0x8
	public uint m_unNumResultsReturned; // 0xC
	public uint m_unTotalMatchingResults; // 0x10
	public bool m_bCachedData; // 0x14
	private byte[] m_rgchNextCursor_; // 0x18

	// Properties
	public string m_rgchNextCursor { get; set; }

	// Methods

	// RVA: 0xC85B40 Offset: 0xC84540 VA: 0x180C85B40
	public string get_m_rgchNextCursor() { }

	// RVA: 0xC81C20 Offset: 0xC80620 VA: 0x180C81C20
	public void set_m_rgchNextCursor(string value) { }
}
