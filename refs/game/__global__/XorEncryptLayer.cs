public class XorEncryptLayer : PacketLayerBase // TypeDefIndex: 12481
{
	// Fields
	private byte[] _byteKey; // 0x18

	// Methods

	// RVA: 0xD236B0 Offset: 0xD220B0 VA: 0x180D236B0
	public void .ctor() { }

	// RVA: 0xD236D0 Offset: 0xD220D0 VA: 0x180D236D0
	public void .ctor(byte[] key) { }

	// RVA: 0xD23780 Offset: 0xD22180 VA: 0x180D23780
	public void .ctor(string key) { }

	// RVA: 0xD235B0 Offset: 0xD21FB0 VA: 0x180D235B0
	public void SetKey(string key) { }

	// RVA: 0xD23610 Offset: 0xD22010 VA: 0x180D23610
	public void SetKey(byte[] key) { }

	// RVA: 0xD23510 Offset: 0xD21F10 VA: 0x180D23510 Slot: 4
	public override void ProcessInboundPacket(ref IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length) { }

	// RVA: 0xD23510 Offset: 0xD21F10 VA: 0x180D23510 Slot: 5
	public override void ProcessOutBoundPacket(ref IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length) { }
}
