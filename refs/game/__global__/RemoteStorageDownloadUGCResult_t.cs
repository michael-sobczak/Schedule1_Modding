public struct RemoteStorageDownloadUGCResult_t // TypeDefIndex: 14497
{
	// Fields
	public const int k_iCallback = 1317;
	public EResult m_eResult; // 0x0
	public UGCHandle_t m_hFile; // 0x8
	public AppId_t m_nAppID; // 0x10
	public int m_nSizeInBytes; // 0x14
	private byte[] m_pchFileName_; // 0x18
	public ulong m_ulSteamIDOwner; // 0x20

	// Properties
	public string m_pchFileName { get; set; }

	// Methods

	// RVA: 0xC85B40 Offset: 0xC84540 VA: 0x180C85B40
	public string get_m_pchFileName() { }

	// RVA: 0xCB1140 Offset: 0xCAFB40 VA: 0x180CB1140
	public void set_m_pchFileName(string value) { }
}
