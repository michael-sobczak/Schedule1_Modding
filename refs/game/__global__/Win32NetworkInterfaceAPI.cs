internal class Win32NetworkInterfaceAPI : NetworkInterfaceFactory // TypeDefIndex: 10148
{
	// Methods

	// RVA: 0x25D8680 Offset: 0x25D7080 VA: 0x1825D8680
	private static extern int GetAdaptersAddresses(uint family, uint flags, IntPtr reserved, IntPtr info, ref int size) { }

	// RVA: 0x25D81D0 Offset: 0x25D6BD0 VA: 0x1825D81D0
	private static Win32_IP_ADAPTER_ADDRESSES[] GetAdaptersAddresses() { }

	// RVA: 0x25D8740 Offset: 0x25D7140 VA: 0x1825D8740 Slot: 4
	public override NetworkInterface[] GetAllNetworkInterfaces() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
