public enum DisconnectReason // TypeDefIndex: 12362
{
	// Fields
	public int value__; // 0x0
	public const DisconnectReason ConnectionFailed = 0;
	public const DisconnectReason Timeout = 1;
	public const DisconnectReason HostUnreachable = 2;
	public const DisconnectReason NetworkUnreachable = 3;
	public const DisconnectReason RemoteConnectionClose = 4;
	public const DisconnectReason DisconnectPeerCalled = 5;
	public const DisconnectReason ConnectionRejected = 6;
	public const DisconnectReason InvalidProtocol = 7;
	public const DisconnectReason UnknownHost = 8;
	public const DisconnectReason Reconnect = 9;
	public const DisconnectReason PeerToPeerConnection = 10;
	public const DisconnectReason PeerNotFound = 11;
}
