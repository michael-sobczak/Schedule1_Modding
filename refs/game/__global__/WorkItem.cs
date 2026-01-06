internal class WorkItem // TypeDefIndex: 16660
{
	// Fields
	public byte[] buffer; // 0x10
	public byte[] compressed; // 0x18
	public int crc; // 0x20
	public int index; // 0x24
	public int ordinal; // 0x28
	public int inputBytesAvailable; // 0x2C
	public int compressedBytesAvailable; // 0x30
	public ZlibCodec compressor; // 0x38

	// Methods

	// RVA: 0x1E76760 Offset: 0x1E75160 VA: 0x181E76760
	public void .ctor(int size, CompressionLevel compressLevel, CompressionStrategy strategy, int ix) { }
}
