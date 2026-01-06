internal sealed class NetConnectRequestPacket // TypeDefIndex: 12379
{
	// Fields
	public const int HeaderSize = 18;
	public readonly long ConnectionTime; // 0x10
	public byte ConnectionNumber; // 0x18
	public readonly byte[] TargetAddress; // 0x20
	public readonly NetDataReader Data; // 0x28
	public readonly int PeerId; // 0x30

	// Methods

	// RVA: 0xCF5660 Offset: 0xCF4060 VA: 0x180CF5660
	private void .ctor(long connectionTime, byte connectionNumber, int localId, byte[] targetAddress, NetDataReader data) { }

	// RVA: 0xCF5450 Offset: 0xCF3E50 VA: 0x180CF5450
	public static int GetProtocolId(NetPacket packet) { }

	// RVA: 0xCF5260 Offset: 0xCF3C60 VA: 0x180CF5260
	public static NetConnectRequestPacket FromData(NetPacket packet) { }

	// RVA: 0xCF5480 Offset: 0xCF3E80 VA: 0x180CF5480
	public static NetPacket Make(NetDataWriter connectData, SocketAddress addressBytes, long connectTime, int localId) { }
}
