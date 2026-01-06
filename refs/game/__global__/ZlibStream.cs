public class ZlibStream : Stream // TypeDefIndex: 16678
{
	// Fields
	internal ZlibBaseStream _baseStream; // 0x28
	private bool _disposed; // 0x30

	// Properties
	public virtual FlushType FlushMode { get; set; }
	public int BufferSize { get; set; }
	public virtual long TotalIn { get; }
	public virtual long TotalOut { get; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1E7A4C0 Offset: 0x1E78EC0 VA: 0x181E7A4C0
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x1E7A310 Offset: 0x1E78D10 VA: 0x181E7A310
	public void .ctor(Stream stream, CompressionMode mode, CompressionLevel level) { }

	// RVA: 0x1E7A330 Offset: 0x1E78D30 VA: 0x181E7A330
	public void .ctor(Stream stream, CompressionMode mode, bool leaveOpen) { }

	// RVA: 0x1E7A360 Offset: 0x1E78D60 VA: 0x181E7A360
	public void .ctor(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen) { }

	// RVA: 0x1E685D0 Offset: 0x1E66FD0 VA: 0x181E685D0 Slot: 40
	public virtual FlushType get_FlushMode() { }

	// RVA: 0x1E7A7D0 Offset: 0x1E791D0 VA: 0x181E7A7D0 Slot: 41
	public virtual void set_FlushMode(FlushType value) { }

	// RVA: 0x1E68490 Offset: 0x1E66E90 VA: 0x181E68490
	public int get_BufferSize() { }

	// RVA: 0x1E7A650 Offset: 0x1E79050 VA: 0x181E7A650
	public void set_BufferSize(int value) { }

	// RVA: 0x1E686A0 Offset: 0x1E670A0 VA: 0x181E686A0 Slot: 42
	public virtual long get_TotalIn() { }

	// RVA: 0x1E686D0 Offset: 0x1E670D0 VA: 0x181E686D0 Slot: 43
	public virtual long get_TotalOut() { }

	// RVA: 0x1E79DE0 Offset: 0x1E787E0 VA: 0x181E79DE0 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1E7A4F0 Offset: 0x1E78EF0 VA: 0x181E7A4F0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1E7A580 Offset: 0x1E78F80 VA: 0x181E7A580 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1E79E80 Offset: 0x1E78880 VA: 0x181E79E80 Slot: 22
	public override void Flush() { }

	// RVA: 0x1E7A610 Offset: 0x1E79010 VA: 0x181E7A610 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1E68630 Offset: 0x1E67030 VA: 0x181E68630 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1E7A850 Offset: 0x1E79250 VA: 0x181E7A850 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1E79F10 Offset: 0x1E78910 VA: 0x181E79F10 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1E79FA0 Offset: 0x1E789A0 VA: 0x181E79FA0 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1E79FE0 Offset: 0x1E789E0 VA: 0x181E79FE0 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x1E7A280 Offset: 0x1E78C80 VA: 0x181E7A280 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1E79C90 Offset: 0x1E78690 VA: 0x181E79C90
	public static byte[] CompressString(string s) { }

	// RVA: 0x1E79B40 Offset: 0x1E78540 VA: 0x181E79B40
	public static byte[] CompressBuffer(byte[] b) { }

	// RVA: 0x1E7A150 Offset: 0x1E78B50 VA: 0x181E7A150
	public static string UncompressString(byte[] compressed) { }

	// RVA: 0x1E7A020 Offset: 0x1E78A20 VA: 0x181E7A020
	public static byte[] UncompressBuffer(byte[] compressed) { }
}
