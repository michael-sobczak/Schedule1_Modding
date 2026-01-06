internal class Win32IPInterfaceProperties2 : IPInterfaceProperties // TypeDefIndex: 10146
{
	// Fields
	private readonly Win32_IP_ADAPTER_ADDRESSES addr; // 0x10
	private readonly Win32_MIB_IFROW mib4; // 0x118
	private readonly Win32_MIB_IFROW mib6; // 0x188

	// Properties
	public override GatewayIPAddressInformationCollection GatewayAddresses { get; }
	public override UnicastIPAddressInformationCollection UnicastAddresses { get; }

	// Methods

	// RVA: 0x25D7B80 Offset: 0x25D6580 VA: 0x1825D7B80
	public void .ctor(Win32_IP_ADAPTER_ADDRESSES addr, Win32_MIB_IFROW mib4, Win32_MIB_IFROW mib6) { }

	// RVA: 0x25D7CE0 Offset: 0x25D66E0 VA: 0x1825D7CE0 Slot: 5
	public override GatewayIPAddressInformationCollection get_GatewayAddresses() { }

	// RVA: 0x25D7F20 Offset: 0x25D6920 VA: 0x1825D7F20 Slot: 4
	public override UnicastIPAddressInformationCollection get_UnicastAddresses() { }

	// RVA: 0x25D7960 Offset: 0x25D6360 VA: 0x1825D7960
	private static UnicastIPAddressInformationCollection Win32FromUnicast(IntPtr ptr) { }
}
