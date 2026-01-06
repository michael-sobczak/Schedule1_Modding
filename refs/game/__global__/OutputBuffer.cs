internal sealed class OutputBuffer // TypeDefIndex: 17653
{
	// Fields
	private byte[] _byteBuffer; // 0x10
	private int _pos; // 0x18
	private uint _bitBuf; // 0x1C
	private int _bitCount; // 0x20

	// Properties
	internal int BytesWritten { get; }
	internal int FreeBytes { get; }
	internal int BitsInBuffer { get; }

	// Methods

	// RVA: 0x21709D0 Offset: 0x216F3D0 VA: 0x1821709D0
	internal void UpdateBuffer(byte[] output) { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	internal int get_BytesWritten() { }

	// RVA: 0x2170C50 Offset: 0x216F650 VA: 0x182170C50
	internal int get_FreeBytes() { }

	// RVA: 0x2170BE0 Offset: 0x216F5E0 VA: 0x182170BE0
	internal void WriteUInt16(ushort value) { }

	// RVA: 0x2170A00 Offset: 0x216F400 VA: 0x182170A00
	internal void WriteBits(int n, uint bits) { }

	// RVA: 0x2170920 Offset: 0x216F320 VA: 0x182170920
	internal void FlushBits() { }

	// RVA: 0x2170B30 Offset: 0x216F530 VA: 0x182170B30
	internal void WriteBytes(byte[] byteArray, int offset, int count) { }

	// RVA: 0x2170AB0 Offset: 0x216F4B0 VA: 0x182170AB0
	private void WriteBytesUnaligned(byte[] byteArray, int offset, int count) { }

	// RVA: 0x2170A90 Offset: 0x216F490 VA: 0x182170A90
	private void WriteByteUnaligned(byte b) { }

	// RVA: 0x2170C40 Offset: 0x216F640 VA: 0x182170C40
	internal int get_BitsInBuffer() { }

	// RVA: 0x2170900 Offset: 0x216F300 VA: 0x182170900
	internal OutputBuffer.BufferState DumpState() { }

	// RVA: 0x21709B0 Offset: 0x216F3B0 VA: 0x1821709B0
	internal void RestoreState(OutputBuffer.BufferState state) { }
}
