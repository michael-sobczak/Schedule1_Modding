public static class NetConstants // TypeDefIndex: 12398
{
	// Fields
	public const int DefaultWindowSize = 64;
	public const int SocketBufferSize = 1048576;
	public const int SocketTTL = 255;
	public const int HeaderSize = 1;
	public const int ChanneledHeaderSize = 4;
	public const int FragmentHeaderSize = 6;
	public const int FragmentedHeaderTotalSize = 10;
	public const ushort MaxSequence = 32768;
	public const ushort HalfMaxSequence = 16384;
	internal const int ProtocolId = 13;
	internal const int MaxUdpHeaderSize = 68;
	internal const int ChannelTypeCount = 4;
	internal static readonly int[] PossibleMtu; // 0x0
	public static readonly int MaxPacketSize; // 0x8
	public static readonly int MaxUnreliableDataSize; // 0xC
	public const byte MaxConnectionNumber = 4;

	// Methods

	// RVA: 0xCF56D0 Offset: 0xCF40D0 VA: 0x180CF56D0
	private static void .cctor() { }
}
