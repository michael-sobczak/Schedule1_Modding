public struct SteamNetConnectionRealTimeStatus_t // TypeDefIndex: 14699
{
	// Fields
	public ESteamNetworkingConnectionState m_eState; // 0x0
	public int m_nPing; // 0x4
	public float m_flConnectionQualityLocal; // 0x8
	public float m_flConnectionQualityRemote; // 0xC
	public float m_flOutPacketsPerSec; // 0x10
	public float m_flOutBytesPerSec; // 0x14
	public float m_flInPacketsPerSec; // 0x18
	public float m_flInBytesPerSec; // 0x1C
	public int m_nSendRateBytesPerSecond; // 0x20
	public int m_cbPendingUnreliable; // 0x24
	public int m_cbPendingReliable; // 0x28
	public int m_cbSentUnackedReliable; // 0x2C
	public SteamNetworkingMicroseconds m_usecQueueTime; // 0x30
	public uint[] reserved; // 0x38
}
