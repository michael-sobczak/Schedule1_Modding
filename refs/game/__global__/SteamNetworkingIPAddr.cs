public struct SteamNetworkingIPAddr : IEquatable<SteamNetworkingIPAddr> // TypeDefIndex: 14797
{
	// Fields
	public byte[] m_ipv6; // 0x0
	public ushort m_port; // 0x8
	public const int k_cchMaxString = 48;

	// Methods

	// RVA: 0xCADA30 Offset: 0xCAC430 VA: 0x180CADA30
	public void Clear() { }

	// RVA: 0xCADFB0 Offset: 0xCAC9B0 VA: 0x180CADFB0
	public bool IsIPv6AllZeros() { }

	// RVA: 0xCAE490 Offset: 0xCACE90 VA: 0x180CAE490
	public void SetIPv6(byte[] ipv6, ushort nPort) { }

	// RVA: 0xCAE2C0 Offset: 0xCACCC0 VA: 0x180CAE2C0
	public void SetIPv4(uint nIP, ushort nPort) { }

	// RVA: 0xCADED0 Offset: 0xCAC8D0 VA: 0x180CADED0
	public bool IsIPv4() { }

	// RVA: 0xCADBE0 Offset: 0xCAC5E0 VA: 0x180CADBE0
	public uint GetIPv4() { }

	// RVA: 0xCAE3B0 Offset: 0xCACDB0 VA: 0x180CAE3B0
	public void SetIPv6LocalHost(ushort nPort = 0) { }

	// RVA: 0xCAE090 Offset: 0xCACA90 VA: 0x180CAE090
	public bool IsLocalHost() { }

	// RVA: 0xCB3190 Offset: 0xCB1B90 VA: 0x180CB3190
	public void ToString(out string buf, bool bWithPort) { }

	// RVA: 0xCB2F80 Offset: 0xCB1980 VA: 0x180CB2F80
	public bool ParseString(string pszStr) { }

	// RVA: 0xCADCC0 Offset: 0xCAC6C0 VA: 0x180CADCC0 Slot: 4
	public bool Equals(SteamNetworkingIPAddr x) { }

	// RVA: 0xCADB00 Offset: 0xCAC500 VA: 0x180CADB00
	public ESteamNetworkingFakeIPType GetFakeIPType() { }

	// RVA: 0xCB2F60 Offset: 0xCB1960 VA: 0x180CB2F60
	public bool IsFakeIP() { }
}
