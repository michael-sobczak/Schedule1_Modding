public struct HTTPRequestCompleted_t // TypeDefIndex: 14424
{
	// Fields
	public const int k_iCallback = 2101;
	public HTTPRequestHandle m_hRequest; // 0x0
	public ulong m_ulContextValue; // 0x8
	public bool m_bRequestSuccessful; // 0x10
	public EHTTPStatusCode m_eStatusCode; // 0x14
	public uint m_unBodySize; // 0x18
}
