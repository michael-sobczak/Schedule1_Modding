internal sealed class NetConnectAcceptPacket // TypeDefIndex: 12380
{
	// Fields
	public const int Size = 15;
	public readonly long ConnectionTime; // 0x10
	public readonly byte ConnectionNumber; // 0x18
	public readonly int PeerId; // 0x1C
	public readonly bool PeerNetworkChanged; // 0x20

	// Methods

	// RVA: 0xCF5210 Offset: 0xCF3C10 VA: 0x180CF5210
	private void .ctor(long connectionTime, byte connectionNumber, int peerId, bool peerNetworkChanged) { }

	// RVA: 0xCF4F20 Offset: 0xCF3920 VA: 0x180CF4F20
	public static NetConnectAcceptPacket FromData(NetPacket packet) { }

	// RVA: 0xCF5120 Offset: 0xCF3B20 VA: 0x180CF5120
	public static NetPacket Make(long connectTime, byte connectNum, int localPeerId) { }

	// RVA: 0xCF5020 Offset: 0xCF3A20 VA: 0x180CF5020
	public static NetPacket MakeNetworkChanged(NetPeer peer) { }
}
