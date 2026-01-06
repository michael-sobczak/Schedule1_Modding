internal enum PacketProperty // TypeDefIndex: 12411
{
	// Fields
	public byte value__; // 0x0
	public const PacketProperty Unreliable = 0;
	public const PacketProperty Channeled = 1;
	public const PacketProperty Ack = 2;
	public const PacketProperty Ping = 3;
	public const PacketProperty Pong = 4;
	public const PacketProperty ConnectRequest = 5;
	public const PacketProperty ConnectAccept = 6;
	public const PacketProperty Disconnect = 7;
	public const PacketProperty UnconnectedMessage = 8;
	public const PacketProperty MtuCheck = 9;
	public const PacketProperty MtuOk = 10;
	public const PacketProperty Broadcast = 11;
	public const PacketProperty Merged = 12;
	public const PacketProperty ShutdownOk = 13;
	public const PacketProperty PeerNotFound = 14;
	public const PacketProperty InvalidProtocol = 15;
	public const PacketProperty NatMessage = 16;
	public const PacketProperty Empty = 17;
}
