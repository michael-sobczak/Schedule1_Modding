internal struct Win32_IP_ADAPTER_ADDRESSES // TypeDefIndex: 10158
{
	// Fields
	public AlignmentUnion Alignment; // 0x0
	public IntPtr Next; // 0x8
	public string AdapterName; // 0x10
	public IntPtr FirstUnicastAddress; // 0x18
	public IntPtr FirstAnycastAddress; // 0x20
	public IntPtr FirstMulticastAddress; // 0x28
	public IntPtr FirstDnsServerAddress; // 0x30
	public string DnsSuffix; // 0x38
	public string Description; // 0x40
	public string FriendlyName; // 0x48
	public byte[] PhysicalAddress; // 0x50
	public uint PhysicalAddressLength; // 0x58
	public uint Flags; // 0x5C
	public uint Mtu; // 0x60
	public NetworkInterfaceType IfType; // 0x64
	public OperationalStatus OperStatus; // 0x68
	public int Ipv6IfIndex; // 0x6C
	public uint[] ZoneIndices; // 0x70
	public IntPtr FirstPrefix; // 0x78
	public ulong TransmitLinkSpeed; // 0x80
	public ulong ReceiveLinkSpeed; // 0x88
	public IntPtr FirstWinsServerAddress; // 0x90
	public IntPtr FirstGatewayAddress; // 0x98
	public uint Ipv4Metric; // 0xA0
	public uint Ipv6Metric; // 0xA4
	public ulong Luid; // 0xA8
	public Win32_SOCKET_ADDRESS Dhcpv4Server; // 0xB0
	public uint CompartmentId; // 0xC0
	public ulong NetworkGuid; // 0xC8
	public int ConnectionType; // 0xD0
	public int TunnelType; // 0xD4
	public Win32_SOCKET_ADDRESS Dhcpv6Server; // 0xD8
	public byte[] Dhcpv6ClientDuid; // 0xE8
	public ulong Dhcpv6ClientDuidLength; // 0xF0
	public ulong Dhcpv6Iaid; // 0xF8
	public IntPtr FirstDnsSuffix; // 0x100
}
