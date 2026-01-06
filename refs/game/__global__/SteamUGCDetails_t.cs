public struct SteamUGCDetails_t // TypeDefIndex: 14694
{
	// Fields
	public PublishedFileId_t m_nPublishedFileId; // 0x0
	public EResult m_eResult; // 0x8
	public EWorkshopFileType m_eFileType; // 0xC
	public AppId_t m_nCreatorAppID; // 0x10
	public AppId_t m_nConsumerAppID; // 0x14
	private byte[] m_rgchTitle_; // 0x18
	private byte[] m_rgchDescription_; // 0x20
	public ulong m_ulSteamIDOwner; // 0x28
	public uint m_rtimeCreated; // 0x30
	public uint m_rtimeUpdated; // 0x34
	public uint m_rtimeAddedToUserList; // 0x38
	public ERemoteStoragePublishedFileVisibility m_eVisibility; // 0x3C
	public bool m_bBanned; // 0x40
	public bool m_bAcceptedForUse; // 0x41
	public bool m_bTagsTruncated; // 0x42
	private byte[] m_rgchTags_; // 0x48
	public UGCHandle_t m_hFile; // 0x50
	public UGCHandle_t m_hPreviewFile; // 0x58
	private byte[] m_pchFileName_; // 0x60
	public int m_nFileSize; // 0x68
	public int m_nPreviewFileSize; // 0x6C
	private byte[] m_rgchURL_; // 0x70
	public uint m_unVotesUp; // 0x78
	public uint m_unVotesDown; // 0x7C
	public float m_flScore; // 0x80
	public uint m_unNumChildren; // 0x84
	public ulong m_ulTotalFilesSize; // 0x88

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

	// RVA: 0xCB46E0 Offset: 0xCB30E0 VA: 0x180CB46E0
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
