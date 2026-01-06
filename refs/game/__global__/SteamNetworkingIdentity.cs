public struct SteamNetworkingIdentity : IEquatable<SteamNetworkingIdentity> // TypeDefIndex: 14796
{
	// Fields
	public ESteamNetworkingIdentityType m_eType; // 0x0
	private int m_cbSize; // 0x4
	private uint m_reserved0; // 0x8
	private uint m_reserved1; // 0xC
	private uint m_reserved2; // 0x10
	private uint m_reserved3; // 0x14
	private uint m_reserved4; // 0x18
	private uint m_reserved5; // 0x1C
	private uint m_reserved6; // 0x20
	private uint m_reserved7; // 0x24
	private uint m_reserved8; // 0x28
	private uint m_reserved9; // 0x2C
	private uint m_reserved10; // 0x30
	private uint m_reserved11; // 0x34
	private uint m_reserved12; // 0x38
	private uint m_reserved13; // 0x3C
	private uint m_reserved14; // 0x40
	private uint m_reserved15; // 0x44
	private uint m_reserved16; // 0x48
	private uint m_reserved17; // 0x4C
	private uint m_reserved18; // 0x50
	private uint m_reserved19; // 0x54
	private uint m_reserved20; // 0x58
	private uint m_reserved21; // 0x5C
	private uint m_reserved22; // 0x60
	private uint m_reserved23; // 0x64
	private uint m_reserved24; // 0x68
	private uint m_reserved25; // 0x6C
	private uint m_reserved26; // 0x70
	private uint m_reserved27; // 0x74
	private uint m_reserved28; // 0x78
	private uint m_reserved29; // 0x7C
	private uint m_reserved30; // 0x80
	private uint m_reserved31; // 0x84
	public const int k_cchMaxString = 128;
	public const int k_cchMaxGenericString = 32;
	public const int k_cchMaxXboxPairwiseID = 33;
	public const int k_cbMaxGenericBytes = 32;

	// Methods

	// RVA: 0xCAE680 Offset: 0xCAD080 VA: 0x180CAE680
	public void Clear() { }

	// RVA: 0xCAED20 Offset: 0xCAD720 VA: 0x180CAED20
	public bool IsInvalid() { }

	// RVA: 0xCB39A0 Offset: 0xCB23A0 VA: 0x180CB39A0
	public void SetSteamID(CSteamID steamID) { }

	// RVA: 0xCB3400 Offset: 0xCB1E00 VA: 0x180CB3400
	public CSteamID GetSteamID() { }

	// RVA: 0xCAF3C0 Offset: 0xCADDC0 VA: 0x180CAF3C0
	public void SetSteamID64(ulong steamID) { }

	// RVA: 0xCAEA90 Offset: 0xCAD490 VA: 0x180CAEA90
	public ulong GetSteamID64() { }

	// RVA: 0xCB3A60 Offset: 0xCB2460 VA: 0x180CB3A60
	public bool SetXboxPairwiseID(string pszString) { }

	// RVA: 0xCB34B0 Offset: 0xCB1EB0 VA: 0x180CB34B0
	public string GetXboxPairwiseID() { }

	// RVA: 0xCAF2A0 Offset: 0xCADCA0 VA: 0x180CAF2A0
	public void SetPSNID(ulong id) { }

	// RVA: 0xCAE990 Offset: 0xCAD390 VA: 0x180CAE990
	public ulong GetPSNID() { }

	// RVA: 0xCAF330 Offset: 0xCADD30 VA: 0x180CAF330
	public void SetStadiaID(ulong id) { }

	// RVA: 0xCAEA10 Offset: 0xCAD410 VA: 0x180CAEA10
	public ulong GetStadiaID() { }

	// RVA: 0xCB38C0 Offset: 0xCB22C0 VA: 0x180CB38C0
	public void SetIPAddr(SteamNetworkingIPAddr addr) { }

	// RVA: 0xCB33C0 Offset: 0xCB1DC0 VA: 0x180CB33C0
	public SteamNetworkingIPAddr GetIPAddr() { }

	// RVA: 0xCAF180 Offset: 0xCADB80 VA: 0x180CAF180
	public void SetIPv4Addr(uint nIPv4, ushort nPort) { }

	// RVA: 0xCAE910 Offset: 0xCAD310 VA: 0x180CAE910
	public uint GetIPv4() { }

	// RVA: 0xCAE700 Offset: 0xCAD100 VA: 0x180CAE700
	public ESteamNetworkingFakeIPType GetFakeIPType() { }

	// RVA: 0xCB3540 Offset: 0xCB1F40 VA: 0x180CB3540
	public bool IsFakeIP() { }

	// RVA: 0xCAF220 Offset: 0xCADC20 VA: 0x180CAF220
	public void SetLocalHost() { }

	// RVA: 0xCAEDA0 Offset: 0xCAD7A0 VA: 0x180CAEDA0
	public bool IsLocalHost() { }

	// RVA: 0xCB3710 Offset: 0xCB2110 VA: 0x180CB3710
	public bool SetGenericString(string pszString) { }

	// RVA: 0xCB3330 Offset: 0xCB1D30 VA: 0x180CB3330
	public string GetGenericString() { }

	// RVA: 0xCAEF00 Offset: 0xCAD900 VA: 0x180CAEF00
	public bool SetGenericBytes(byte[] data, uint cbLen) { }

	// RVA: 0xCB32F0 Offset: 0xCB1CF0 VA: 0x180CB32F0
	public byte[] GetGenericBytes(out int cbLen) { }

	// RVA: 0xCAEC10 Offset: 0xCAD610 VA: 0x180CAEC10 Slot: 4
	public bool Equals(SteamNetworkingIdentity x) { }

	// RVA: 0xCB3C10 Offset: 0xCB2610 VA: 0x180CB3C10
	public void ToString(out string buf) { }

	// RVA: 0xCB3560 Offset: 0xCB1F60 VA: 0x180CB3560
	public bool ParseString(string pszStr) { }
}
