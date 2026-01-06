public struct ServerReceivedDataArgs // TypeDefIndex: 12535
{
	// Fields
	public ArraySegment<byte> Data; // 0x0
	public Channel Channel; // 0x10
	public int ConnectionId; // 0x14
	public int TransportIndex; // 0x18
	public Action FinalizeMethod; // 0x20

	// Methods

	// RVA: 0xD1AE40 Offset: 0xD19840 VA: 0x180D1AE40
	public void .ctor(ArraySegment<byte> data, Channel channel, int connectionId, int transportIndex) { }

	// RVA: 0xD1AEA0 Offset: 0xD198A0 VA: 0x180D1AEA0
	public void .ctor(ArraySegment<byte> data, Channel channel, int connectionId, int transportIndex, Action finalizeMethod) { }
}
