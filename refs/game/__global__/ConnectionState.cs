public enum ConnectionState // TypeDefIndex: 12413
{
	// Fields
	public byte value__; // 0x0
	public const ConnectionState Outgoing = 2;
	public const ConnectionState Connected = 4;
	public const ConnectionState ShutdownRequested = 8;
	public const ConnectionState Disconnected = 16;
	public const ConnectionState EndPointChange = 32;
	public const ConnectionState Any = 46;
}
