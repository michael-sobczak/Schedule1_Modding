public class IPEndPoint : EndPoint // TypeDefIndex: 9936
{
	// Fields
	public const int MinPort = 0;
	public const int MaxPort = 65535;
	private IPAddress _address; // 0x10
	private int _port; // 0x18
	internal const int AnyPort = 0;
	internal static IPEndPoint Any; // 0x0
	internal static IPEndPoint IPv6Any; // 0x8

	// Properties
	public override AddressFamily AddressFamily { get; }
	public IPAddress Address { get; set; }
	public int Port { get; set; }

	// Methods

	// RVA: 0x26AAC10 Offset: 0x26A9610 VA: 0x1826AAC10 Slot: 4
	public override AddressFamily get_AddressFamily() { }

	// RVA: 0x26AAB20 Offset: 0x26A9520 VA: 0x1826AAB20
	public void .ctor(IPAddress address, int port) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public IPAddress get_Address() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Address(IPAddress value) { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public int get_Port() { }

	// RVA: 0x26AAC40 Offset: 0x26A9640 VA: 0x1826AAC40
	public void set_Port(int value) { }

	// RVA: 0x26AA890 Offset: 0x26A9290 VA: 0x1826AA890 Slot: 3
	public override string ToString() { }

	// RVA: 0x26AA820 Offset: 0x26A9220 VA: 0x1826AA820 Slot: 5
	public override SocketAddress Serialize() { }

	// RVA: 0x26AA4D0 Offset: 0x26A8ED0 VA: 0x1826AA4D0 Slot: 6
	public override EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x26AA730 Offset: 0x26A9130 VA: 0x1826AA730 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x26AA7E0 Offset: 0x26A91E0 VA: 0x1826AA7E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x26AA950 Offset: 0x26A9350 VA: 0x1826AA950
	private static void .cctor() { }
}
