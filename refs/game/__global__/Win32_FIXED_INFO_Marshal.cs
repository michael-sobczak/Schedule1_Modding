internal struct Win32_FIXED_INFO_Marshal // TypeDefIndex: 10156
{
	// Fields
	[FixedBuffer(typeof(byte), 132)]
	public Win32_FIXED_INFO_Marshal.<HostName>e__FixedBuffer HostName; // 0x0
	[FixedBuffer(typeof(byte), 132)]
	public Win32_FIXED_INFO_Marshal.<DomainName>e__FixedBuffer DomainName; // 0x84
	public IntPtr CurrentDnsServer; // 0x108
	public Win32_IP_ADDR_STRING DnsServerList; // 0x110
	public NetBiosNodeType NodeType; // 0x130
	[FixedBuffer(typeof(byte), 260)]
	public Win32_FIXED_INFO_Marshal.<ScopeId>e__FixedBuffer ScopeId; // 0x134
	public uint EnableRouting; // 0x238
	public uint EnableProxy; // 0x23C
	public uint EnableDns; // 0x240
}
