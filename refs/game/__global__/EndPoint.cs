public abstract class EndPoint // TypeDefIndex: 9963
{
	// Properties
	public virtual AddressFamily AddressFamily { get; }

	// Methods

	// RVA: 0x26BC050 Offset: 0x26BAA50 VA: 0x1826BC050 Slot: 4
	public virtual AddressFamily get_AddressFamily() { }

	// RVA: 0x26BC020 Offset: 0x26BAA20 VA: 0x1826BC020 Slot: 5
	public virtual SocketAddress Serialize() { }

	// RVA: 0x26BBFF0 Offset: 0x26BA9F0 VA: 0x1826BBFF0 Slot: 6
	public virtual EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
