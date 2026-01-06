public struct P2PSessionState_t // TypeDefIndex: 14692
{
	// Fields
	public byte m_bConnectionActive; // 0x0
	public byte m_bConnecting; // 0x1
	public byte m_eP2PSessionError; // 0x2
	public byte m_bUsingRelay; // 0x3
	public int m_nBytesQueuedForSend; // 0x4
	public int m_nPacketsQueuedForSend; // 0x8
	public uint m_nRemoteIP; // 0xC
	public ushort m_nRemotePort; // 0x10
}
