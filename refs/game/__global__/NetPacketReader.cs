public sealed class NetPacketReader : NetDataReader // TypeDefIndex: 12405
{
	// Fields
	private NetPacket _packet; // 0x28
	private readonly NetManager _manager; // 0x30
	private readonly NetEvent _evt; // 0x38

	// Methods

	// RVA: 0xD007E0 Offset: 0xCFF1E0 VA: 0x180D007E0
	internal void .ctor(NetManager manager, NetEvent evt) { }

	// RVA: 0xD00770 Offset: 0xCFF170 VA: 0x180D00770
	internal void SetSource(NetPacket packet, int headerSize) { }

	// RVA: 0xD006C0 Offset: 0xCFF0C0 VA: 0x180D006C0
	internal void Recycle_Internal() { }

	// RVA: 0xD00740 Offset: 0xCFF140 VA: 0x180D00740
	public void Recycle() { }
}
