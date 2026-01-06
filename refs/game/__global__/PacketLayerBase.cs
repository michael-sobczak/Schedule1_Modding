public abstract class PacketLayerBase // TypeDefIndex: 12480
{
	// Fields
	public readonly int ExtraPacketSizeForLayer; // 0x10

	// Methods

	// RVA: 0x445F80 Offset: 0x444980 VA: 0x180445F80
	protected void .ctor(int extraPacketSizeForLayer) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void ProcessInboundPacket(ref IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void ProcessOutBoundPacket(ref IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length);
}
