public abstract class IPInterfaceProperties // TypeDefIndex: 10127
{
	// Properties
	public abstract UnicastIPAddressInformationCollection UnicastAddresses { get; }
	public abstract GatewayIPAddressInformationCollection GatewayAddresses { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract UnicastIPAddressInformationCollection get_UnicastAddresses();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract GatewayIPAddressInformationCollection get_GatewayAddresses();

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
