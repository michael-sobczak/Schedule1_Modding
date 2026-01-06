public struct RemoteStorageEnumeratePublishedFilesByUserActionResult_t // TypeDefIndex: 14508
{
	// Fields
	public const int k_iCallback = 1328;
	public EResult m_eResult; // 0x0
	public EWorkshopFileAction m_eAction; // 0x4
	public int m_nResultsReturned; // 0x8
	public int m_nTotalResultCount; // 0xC
	public PublishedFileId_t[] m_rgPublishedFileId; // 0x10
	public uint[] m_rgRTimeUpdated; // 0x18
}
