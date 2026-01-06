internal class ZlibBaseStream : Stream // TypeDefIndex: 16675
{
	// Fields
	protected internal ZlibCodec _z; // 0x28
	protected internal ZlibBaseStream.StreamMode _streamMode; // 0x30
	protected internal FlushType _flushMode; // 0x34
	protected internal ZlibStreamFlavor _flavor; // 0x38
	protected internal CompressionMode _compressionMode; // 0x3C
	protected internal CompressionLevel _level; // 0x40
	protected internal bool _leaveOpen; // 0x44
	protected internal byte[] _workingBuffer; // 0x48
	protected internal int _bufferSize; // 0x50
	protected internal byte[] _buf1; // 0x58
	protected internal Stream _stream; // 0x60
	protected internal CompressionStrategy Strategy; // 0x68
	private CRC32 crc; // 0x70
	protected internal string _GzipFileName; // 0x78
	protected internal string _GzipComment; // 0x80
	protected internal DateTime _GzipMtime; // 0x88
	protected internal int _gzipHeaderByteCount; // 0x90
	private bool nomoreinput; // 0x94

	// Properties
	internal int Crc32 { get; }
	protected internal bool _wantCompress { get; }
	private ZlibCodec z { get; }
	private byte[] workingBuffer { get; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1E78010 Offset: 0x1E76A10 VA: 0x181E78010
	public void .ctor(Stream stream, CompressionMode compressionMode, CompressionLevel level, ZlibStreamFlavor flavor, bool leaveOpen) { }

	// RVA: 0x1E78AF0 Offset: 0x1E774F0 VA: 0x181E78AF0
	internal int get_Crc32() { }

	// RVA: 0x1E78B50 Offset: 0x1E77550 VA: 0x181E78B50
	protected internal bool get__wantCompress() { }

	// RVA: 0x1E78BC0 Offset: 0x1E775C0 VA: 0x181E78BC0
	private ZlibCodec get_z() { }

	// RVA: 0x1E78B60 Offset: 0x1E77560 VA: 0x181E78B60
	private byte[] get_workingBuffer() { }

	// RVA: 0x1E778D0 Offset: 0x1E762D0 VA: 0x181E778D0 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1E78230 Offset: 0x1E76C30 VA: 0x181E78230
	private void finish() { }

	// RVA: 0x1E78130 Offset: 0x1E76B30 VA: 0x181E78130
	private void end() { }

	// RVA: 0x1E768A0 Offset: 0x1E752A0 VA: 0x181E768A0 Slot: 20
	public override void Close() { }

	// RVA: 0x1E5AAF0 Offset: 0x1E594F0 VA: 0x181E5AAF0 Slot: 22
	public override void Flush() { }

	// RVA: 0x1E773A0 Offset: 0x1E75DA0 VA: 0x181E773A0 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1E773E0 Offset: 0x1E75DE0 VA: 0x181E773E0 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x1E76AD0 Offset: 0x1E754D0 VA: 0x181E76AD0
	private string ReadZeroTerminatedString() { }

	// RVA: 0x1E77C80 Offset: 0x1E76680 VA: 0x181E77C80
	private int _ReadAndValidateGzipHeader() { }

	// RVA: 0x1E76CE0 Offset: 0x1E756E0 VA: 0x181E76CE0 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1E78A60 Offset: 0x1E77460 VA: 0x181E78A60 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1E78A90 Offset: 0x1E77490 VA: 0x181E78A90 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1E78AC0 Offset: 0x1E774C0 VA: 0x181E78AC0 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1E5BD10 Offset: 0x1E5A710 VA: 0x181E5BD10 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1E78B10 Offset: 0x1E77510 VA: 0x181E78B10 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1E78CB0 Offset: 0x1E776B0 VA: 0x181E78CB0 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1E769D0 Offset: 0x1E753D0 VA: 0x181E769D0
	public static void CompressString(string s, Stream compressor) { }

	// RVA: 0x1E76900 Offset: 0x1E75300 VA: 0x181E76900
	public static void CompressBuffer(byte[] b, Stream compressor) { }

	// RVA: 0x1E77630 Offset: 0x1E76030 VA: 0x181E77630
	public static string UncompressString(byte[] compressed, Stream decompressor) { }

	// RVA: 0x1E77410 Offset: 0x1E75E10 VA: 0x181E77410
	public static byte[] UncompressBuffer(byte[] compressed, Stream decompressor) { }
}
