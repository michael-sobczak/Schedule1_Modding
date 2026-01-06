internal sealed class Win32NetworkInterface2 : NetworkInterface // TypeDefIndex: 10149
{
	// Fields
	private Win32_IP_ADAPTER_ADDRESSES addr; // 0x10
	private Win32_MIB_IFROW mib4; // 0x118
	private Win32_MIB_IFROW mib6; // 0x188
	private Win32IPv4InterfaceStatistics ip4stats; // 0x1F8
	private IPInterfaceProperties ip_if_props; // 0x200

	// Properties
	public override NetworkInterfaceType NetworkInterfaceType { get; }
	public override OperationalStatus OperationalStatus { get; }

	// Methods

	// RVA: 0x25F59C0 Offset: 0x25F43C0 VA: 0x1825F59C0
	private static extern int GetIfEntry(ref Win32_MIB_IFROW row) { }

	// RVA: 0x25F5B00 Offset: 0x25F4500 VA: 0x1825F5B00
	internal void .ctor(Win32_IP_ADAPTER_ADDRESSES addr) { }

	// RVA: 0x2031380 Offset: 0x202FD80 VA: 0x182031380 Slot: 4
	public override IPInterfaceProperties GetIPProperties() { }

	// RVA: 0xA9F7E0 Offset: 0xA9E1E0 VA: 0x180A9F7E0 Slot: 6
	public override NetworkInterfaceType get_NetworkInterfaceType() { }

	// RVA: 0x553640 Offset: 0x552040 VA: 0x180553640 Slot: 5
	public override OperationalStatus get_OperationalStatus() { }
}
