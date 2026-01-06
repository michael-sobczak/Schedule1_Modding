public struct RemoteStorageEnumerateWorkshopFilesResult_t // TypeDefIndex: 14499
{
	// Fields
	public const int k_iCallback = 1319;
	public EResult m_eResult; // 0x0
	public int m_nResultsReturned; // 0x4
	public int m_nTotalResultCount; // 0x8
	public PublishedFileId_t[] m_rgPublishedFileId; // 0x10
	public float[] m_rgScore; // 0x18
	public AppId_t m_nAppId; // 0x20
	public uint m_unStartIndex; // 0x24
}
