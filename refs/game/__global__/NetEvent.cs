internal sealed class NetEvent // TypeDefIndex: 12407
{
	// Fields
	public NetEvent Next; // 0x10
	public NetEvent.EType Type; // 0x18
	public NetPeer Peer; // 0x20
	public IPEndPoint RemoteEndPoint; // 0x28
	public object UserData; // 0x30
	public int Latency; // 0x38
	public SocketError ErrorCode; // 0x3C
	public DisconnectReason DisconnectReason; // 0x40
	public ConnectionRequest ConnectionRequest; // 0x48
	public DeliveryMethod DeliveryMethod; // 0x50
	public byte ChannelNumber; // 0x51
	public readonly NetPacketReader DataReader; // 0x58

	// Methods

	// RVA: 0xCF77A0 Offset: 0xCF61A0 VA: 0x180CF77A0
	public void .ctor(NetManager manager) { }
}
