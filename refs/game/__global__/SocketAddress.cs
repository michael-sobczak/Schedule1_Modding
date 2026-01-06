public class SocketAddress // TypeDefIndex: 9981
{
	// Fields
	internal int m_Size; // 0x10
	internal byte[] m_Buffer; // 0x18
	private bool m_changed; // 0x20
	private int m_hash; // 0x24

	// Properties
	public AddressFamily Family { get; }
	public int Size { get; }
	public byte Item { get; }

	// Methods

	// RVA: 0x26C9620 Offset: 0x26C8020 VA: 0x1826C9620
	public AddressFamily get_Family() { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public int get_Size() { }

	// RVA: 0x26C9660 Offset: 0x26C8060 VA: 0x1826C9660
	public byte get_Item(int offset) { }

	// RVA: 0x26C91F0 Offset: 0x26C7BF0 VA: 0x1826C91F0
	public void .ctor(AddressFamily family, int size) { }

	// RVA: 0x26C9310 Offset: 0x26C7D10 VA: 0x1826C9310
	internal void .ctor(IPAddress ipAddress) { }

	// RVA: 0x26C9190 Offset: 0x26C7B90 VA: 0x1826C9190
	internal void .ctor(IPAddress ipaddress, int port) { }

	// RVA: 0x26C8C10 Offset: 0x26C7610 VA: 0x1826C8C10
	internal IPAddress GetIPAddress() { }

	// RVA: 0x26C8E70 Offset: 0x26C7870 VA: 0x1826C8E70
	internal IPEndPoint GetIPEndPoint() { }

	// RVA: 0x26C8990 Offset: 0x26C7390 VA: 0x1826C8990 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x26C8AD0 Offset: 0x26C74D0 VA: 0x1826C8AD0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x26C8F10 Offset: 0x26C7910 VA: 0x1826C8F10 Slot: 3
	public override string ToString() { }
}
