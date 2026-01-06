public struct PooledPacket // TypeDefIndex: 12422
{
	// Fields
	internal readonly NetPacket _packet; // 0x0
	internal readonly byte _channelNumber; // 0x8
	public readonly int MaxUserDataSize; // 0xC
	public readonly int UserDataOffset; // 0x10

	// Properties
	public byte[] Data { get; }

	// Methods

	// RVA: 0xD07690 Offset: 0xD06090 VA: 0x180D07690
	public byte[] get_Data() { }

	// RVA: 0xD07630 Offset: 0xD06030 VA: 0x180D07630
	internal void .ctor(NetPacket packet, int maxDataSize, byte channelNumber) { }
}
