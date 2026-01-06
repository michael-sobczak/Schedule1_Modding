internal class Win32UnicastIPAddressInformation : UnicastIPAddressInformation // TypeDefIndex: 10166
{
	// Fields
	private Win32_IP_ADAPTER_UNICAST_ADDRESS info; // 0x10
	private IPAddress ipv4Mask; // 0x50

	// Properties
	public override IPAddress Address { get; }

	// Methods

	// RVA: 0x25F67E0 Offset: 0x25F51E0 VA: 0x1825F67E0
	public void .ctor(Win32_IP_ADAPTER_UNICAST_ADDRESS info) { }

	// RVA: 0x25F6930 Offset: 0x25F5330 VA: 0x1825F6930 Slot: 4
	public override IPAddress get_Address() { }

	// RVA: 0x25F6700 Offset: 0x25F5100 VA: 0x1825F6700
	private static IPAddress PrefixLengthToSubnetMask(byte prefixLength, AddressFamily family) { }
}
