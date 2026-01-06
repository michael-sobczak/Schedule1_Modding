public struct SteamNetConnectionRealTimeLaneStatus_t // TypeDefIndex: 14700
{
	// Fields
	public int m_cbPendingUnreliable; // 0x0
	public int m_cbPendingReliable; // 0x4
	public int m_cbSentUnackedReliable; // 0x8
	public int _reservePad1; // 0xC
	public SteamNetworkingMicroseconds m_usecQueueTime; // 0x10
	public uint[] reserved; // 0x18
}
