public abstract class NetworkInterface // TypeDefIndex: 10130
{
	// Properties
	public virtual OperationalStatus OperationalStatus { get; }
	public virtual NetworkInterfaceType NetworkInterfaceType { get; }

	// Methods

	// RVA: 0x25C15D0 Offset: 0x25BFFD0 VA: 0x1825C15D0
	public static NetworkInterface[] GetAllNetworkInterfaces() { }

	// RVA: 0x25C1610 Offset: 0x25C0010 VA: 0x1825C1610 Slot: 4
	public virtual IPInterfaceProperties GetIPProperties() { }

	// RVA: 0x25C1690 Offset: 0x25C0090 VA: 0x1825C1690 Slot: 5
	public virtual OperationalStatus get_OperationalStatus() { }

	// RVA: 0x25C1650 Offset: 0x25C0050 VA: 0x1825C1650 Slot: 6
	public virtual NetworkInterfaceType get_NetworkInterfaceType() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
