public struct RemoteStorageGetPublishedFileDetailsResult_t // TypeDefIndex: 14498
{
	// Fields
	public const int k_iCallback = 1318;
	public EResult m_eResult; // 0x0
	public PublishedFileId_t m_nPublishedFileId; // 0x8
	public AppId_t m_nCreatorAppID; // 0x10
	public AppId_t m_nConsumerAppID; // 0x14
	private byte[] m_rgchTitle_; // 0x18
	private byte[] m_rgchDescription_; // 0x20
	public UGCHandle_t m_hFile; // 0x28
	public UGCHandle_t m_hPreviewFile; // 0x30
	public ulong m_ulSteamIDOwner; // 0x38
	public uint m_rtimeCreated; // 0x40
	public uint m_rtimeUpdated; // 0x44
	public ERemoteStoragePublishedFileVisibility m_eVisibility; // 0x48
	public bool m_bBanned; // 0x4C
	private byte[] m_rgchTags_; // 0x50
	public bool m_bTagsTruncated; // 0x58
	private byte[] m_pchFileName_; // 0x60
	public int m_nFileSize; // 0x68
	public int m_nPreviewFileSize; // 0x6C
	private byte[] m_rgchURL_; // 0x70
	public EWorkshopFileType m_eFileType; // 0x78
	public bool m_bAcceptedForUse; // 0x7C

	// Properties
	public string m_rgchTitle { get; set; }
	public string m_rgchDescription { get; set; }
	public string m_rgchTags { get; set; }
	public string m_pchFileName { get; set; }
	public string m_rgchURL { get; set; }

	// Methods

	// RVA: 0xC85B40 Offset: 0xC84540 VA: 0x180C85B40
	public string get_m_rgchTitle() { }

	// RVA: 0xCB1550 Offset: 0xCAFF50 VA: 0x180CB1550
	public void set_m_rgchTitle(string value) { }

	// RVA: 0xCB1270 Offset: 0xCAFC70 VA: 0x180CB1270
	public string get_m_rgchDescription() { }

	// RVA: 0xCB13F0 Offset: 0xCAFDF0 VA: 0x180CB13F0
	public void set_m_rgchDescription(string value) { }

	// RVA: 0xCB12F0 Offset: 0xCAFCF0 VA: 0x180CB12F0
	public string get_m_rgchTags() { }

	// RVA: 0xCB14A0 Offset: 0xCAFEA0 VA: 0x180CB14A0
	public void set_m_rgchTags(string value) { }

	// RVA: 0xCB11F0 Offset: 0xCAFBF0 VA: 0x180CB11F0
	public string get_m_pchFileName() { }

	// RVA: 0xCB1140 Offset: 0xCAFB40 VA: 0x180CB1140
	public void set_m_pchFileName(string value) { }

	// RVA: 0xCB1370 Offset: 0xCAFD70 VA: 0x180CB1370
	public string get_m_rgchURL() { }

	// RVA: 0xC81C20 Offset: 0xC80620 VA: 0x180C81C20
	public void set_m_rgchURL(string value) { }
}
