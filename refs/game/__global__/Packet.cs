internal struct Packet // TypeDefIndex: 12546
{
	// Fields
	public readonly int ConnectionId; // 0x0
	public readonly byte[] Data; // 0x8
	public readonly int Length; // 0x10
	public readonly byte Channel; // 0x14

	// Methods

	// RVA: 0xD165E0 Offset: 0xD14FE0 VA: 0x180D165E0
	public void .ctor(int connectionId, byte[] data, int length, byte channel) { }

	// RVA: 0xD164A0 Offset: 0xD14EA0 VA: 0x180D164A0
	public void .ctor(int sender, ArraySegment<byte> segment, byte channel, int mtu) { }

	// RVA: 0xD16440 Offset: 0xD14E40 VA: 0x180D16440
	public ArraySegment<byte> GetArraySegment() { }

	// RVA: 0xD16340 Offset: 0xD14D40 VA: 0x180D16340
	public void Dispose() { }
}
