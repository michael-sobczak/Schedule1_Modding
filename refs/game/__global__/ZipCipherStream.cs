internal class ZipCipherStream : Stream // TypeDefIndex: 16613
{
	// Fields
	private ZipCrypto _cipher; // 0x28
	private Stream _s; // 0x30
	private CryptoMode _mode; // 0x38

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1E37D30 Offset: 0x1E36730 VA: 0x181E37D30
	public void .ctor(Stream s, ZipCrypto cipher, CryptoMode mode) { }

	// RVA: 0x1E37930 Offset: 0x1E36330 VA: 0x181E37930 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1E37B70 Offset: 0x1E36570 VA: 0x181E37B70 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0xAEE2C0 Offset: 0xAECCC0 VA: 0x180AEE2C0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1E37DD0 Offset: 0x1E367D0 VA: 0x181E37DD0 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 22
	public override void Flush() { }

	// RVA: 0x1E37DE0 Offset: 0x1E367E0 VA: 0x181E37DE0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1E37E20 Offset: 0x1E36820 VA: 0x181E37E20 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1E37E60 Offset: 0x1E36860 VA: 0x181E37E60 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1E37AF0 Offset: 0x1E364F0 VA: 0x181E37AF0 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1E37B30 Offset: 0x1E36530 VA: 0x181E37B30 Slot: 33
	public override void SetLength(long value) { }
}
