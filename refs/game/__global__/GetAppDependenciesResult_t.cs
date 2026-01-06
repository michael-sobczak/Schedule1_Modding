public struct GetAppDependenciesResult_t // TypeDefIndex: 14531
{
	// Fields
	public const int k_iCallback = 3416;
	public EResult m_eResult; // 0x0
	public PublishedFileId_t m_nPublishedFileId; // 0x8
	public AppId_t[] m_rgAppIDs; // 0x10
	public uint m_nNumAppDependencies; // 0x18
	public uint m_nTotalNumAppDependencies; // 0x1C
}
