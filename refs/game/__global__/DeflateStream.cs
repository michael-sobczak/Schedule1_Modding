public class DeflateStream : Stream // TypeDefIndex: 16651
{
	// Fields
	internal ZlibBaseStream _baseStream; // 0x28
	internal Stream _innerStream; // 0x30
	private bool _disposed; // 0x38

	// Properties
	public virtual FlushType FlushMode { get; set; }
	public int BufferSize { get; set; }
	public CompressionStrategy Strategy { get; set; }
	public virtual long TotalIn { get; }
	public virtual long TotalOut { get; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1E68320 Offset: 0x1E66D20 VA: 0x181E68320
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x1E68350 Offset: 0x1E66D50 VA: 0x181E68350
	public void .ctor(Stream stream, CompressionMode mode, CompressionLevel level) { }

	// RVA: 0x1E68370 Offset: 0x1E66D70 VA: 0x181E68370
	public void .ctor(Stream stream, CompressionMode mode, bool leaveOpen) { }

	// RVA: 0x1E683A0 Offset: 0x1E66DA0 VA: 0x181E683A0
	public void .ctor(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen) { }

	// RVA: 0x1E685D0 Offset: 0x1E66FD0 VA: 0x181E685D0 Slot: 40
	public virtual FlushType get_FlushMode() { }

	// RVA: 0x1E68880 Offset: 0x1E67280 VA: 0x181E68880 Slot: 41
	public virtual void set_FlushMode(FlushType value) { }

	// RVA: 0x1E68490 Offset: 0x1E66E90 VA: 0x181E68490
	public int get_BufferSize() { }

	// RVA: 0x1E68700 Offset: 0x1E67100 VA: 0x181E68700
	public void set_BufferSize(int value) { }

	// RVA: 0x1E68680 Offset: 0x1E67080 VA: 0x181E68680
	public CompressionStrategy get_Strategy() { }

	// RVA: 0x1E68940 Offset: 0x1E67340 VA: 0x181E68940
	public void set_Strategy(CompressionStrategy value) { }

	// RVA: 0x1E686A0 Offset: 0x1E670A0 VA: 0x181E686A0 Slot: 42
	public virtual long get_TotalIn() { }

	// RVA: 0x1E686D0 Offset: 0x1E670D0 VA: 0x181E686D0 Slot: 43
	public virtual long get_TotalOut() { }

	// RVA: 0x1E67DF0 Offset: 0x1E667F0 VA: 0x181E67DF0 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1E684B0 Offset: 0x1E66EB0 VA: 0x181E684B0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1E68540 Offset: 0x1E66F40 VA: 0x181E68540 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1E67E90 Offset: 0x1E66890 VA: 0x181E67E90 Slot: 22
	public override void Flush() { }

	// RVA: 0x1E685F0 Offset: 0x1E66FF0 VA: 0x181E685F0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1E68630 Offset: 0x1E67030 VA: 0x181E68630 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1E68900 Offset: 0x1E67300 VA: 0x181E68900 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1E67F20 Offset: 0x1E66920 VA: 0x181E67F20 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1E67FB0 Offset: 0x1E669B0 VA: 0x181E67FB0 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1E67FF0 Offset: 0x1E669F0 VA: 0x181E67FF0 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x1E68290 Offset: 0x1E66C90 VA: 0x181E68290 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1E67CA0 Offset: 0x1E666A0 VA: 0x181E67CA0
	public static byte[] CompressString(string s) { }

	// RVA: 0x1E67B50 Offset: 0x1E66550 VA: 0x181E67B50
	public static byte[] CompressBuffer(byte[] b) { }

	// RVA: 0x1E68160 Offset: 0x1E66B60 VA: 0x181E68160
	public static string UncompressString(byte[] compressed) { }

	// RVA: 0x1E68030 Offset: 0x1E66A30 VA: 0x181E68030
	public static byte[] UncompressBuffer(byte[] compressed) { }
}
