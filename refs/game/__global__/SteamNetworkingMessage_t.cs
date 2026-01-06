public struct SteamNetworkingMessage_t // TypeDefIndex: 14798
{
	// Fields
	public IntPtr m_pData; // 0x0
	public int m_cbSize; // 0x8
	public HSteamNetConnection m_conn; // 0xC
	public SteamNetworkingIdentity m_identityPeer; // 0x10
	public long m_nConnUserData; // 0x98
	public SteamNetworkingMicroseconds m_usecTimeReceived; // 0xA0
	public long m_nMessageNumber; // 0xA8
	public IntPtr m_pfnFreeData; // 0xB0
	internal IntPtr m_pfnRelease; // 0xB8
	public int m_nChannel; // 0xC0
	public int m_nFlags; // 0xC4
	public long m_nUserData; // 0xC8
	public ushort m_idxLane; // 0xD0
	public ushort _pad1__; // 0xD2

	// Methods

	// RVA: 0xCB3E80 Offset: 0xCB2880 VA: 0x180CB3E80
	public void Release() { }

	// RVA: 0xCAF660 Offset: 0xCAE060 VA: 0x180CAF660
	public static void Release(IntPtr pointer) { }

	// RVA: 0xCB3D10 Offset: 0xCB2710 VA: 0x180CB3D10
	public static SteamNetworkingMessage_t FromIntPtr(IntPtr pointer) { }
}
