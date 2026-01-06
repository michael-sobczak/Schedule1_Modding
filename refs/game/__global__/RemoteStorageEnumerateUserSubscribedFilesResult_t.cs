public struct RemoteStorageEnumerateUserSubscribedFilesResult_t // TypeDefIndex: 14494
{
	// Fields
	public const int k_iCallback = 1314;
	public EResult m_eResult; // 0x0
	public int m_nResultsReturned; // 0x4
	public int m_nTotalResultCount; // 0x8
	public PublishedFileId_t[] m_rgPublishedFileId; // 0x10
	public uint[] m_rgRTimeSubscribed; // 0x18
}
