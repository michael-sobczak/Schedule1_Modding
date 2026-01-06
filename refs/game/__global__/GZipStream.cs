public class GZipStream : Stream // TypeDefIndex: 16652
{
	// Fields
	public Nullable<DateTime> LastModified; // 0x28
	private int _headerByteCount; // 0x38
	internal ZlibBaseStream _baseStream; // 0x40
	private bool _disposed; // 0x48
	private bool _firstReadDone; // 0x49
	private string _FileName; // 0x50
	private string _Comment; // 0x58
	private int _Crc32; // 0x60
	internal static readonly DateTime _unixEpoch; // 0x0
	internal static readonly Encoding iso8859dash1; // 0x8

	// Properties
	public string Comment { get; set; }
	public string FileName { get; set; }
	public int Crc32 { get; }
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

	// RVA: 0x1E698F0 Offset: 0x1E682F0 VA: 0x181E698F0
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x1E697C0 Offset: 0x1E681C0 VA: 0x181E697C0
	public void .ctor(Stream stream, CompressionMode mode, CompressionLevel level) { }

	// RVA: 0x1E697E0 Offset: 0x1E681E0 VA: 0x181E697E0
	public void .ctor(Stream stream, CompressionMode mode, bool leaveOpen) { }

	// RVA: 0x1E69810 Offset: 0x1E68210 VA: 0x181E69810
	public void .ctor(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen) { }

	// RVA: 0x1E69700 Offset: 0x1E68100 VA: 0x181E69700
	private static void .cctor() { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public string get_Comment() { }

	// RVA: 0x1E69D00 Offset: 0x1E68700 VA: 0x181E69D00
	public void set_Comment(string value) { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public string get_FileName() { }

	// RVA: 0x1E69D70 Offset: 0x1E68770 VA: 0x181E69D70
	public void set_FileName(string value) { }

	// RVA: 0x4E2410 Offset: 0x4E0E10 VA: 0x1804E2410
	public int get_Crc32() { }

	// RVA: 0x1E69A60 Offset: 0x1E68460 VA: 0x181E69A60 Slot: 40
	public virtual FlushType get_FlushMode() { }

	// RVA: 0x1E69F40 Offset: 0x1E68940 VA: 0x181E69F40 Slot: 41
	public virtual void set_FlushMode(FlushType value) { }

	// RVA: 0x1E69920 Offset: 0x1E68320 VA: 0x181E69920
	public int get_BufferSize() { }

	// RVA: 0x1E69B80 Offset: 0x1E68580 VA: 0x181E69B80
	public void set_BufferSize(int value) { }

	// RVA: 0x1E69B20 Offset: 0x1E68520 VA: 0x181E69B20 Slot: 42
	public virtual long get_TotalIn() { }

	// RVA: 0x1E69B50 Offset: 0x1E68550 VA: 0x181E69B50 Slot: 43
	public virtual long get_TotalOut() { }

	// RVA: 0x1E68C60 Offset: 0x1E67660 VA: 0x181E68C60 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1E69940 Offset: 0x1E68340 VA: 0x181E69940 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1E699D0 Offset: 0x1E683D0 VA: 0x181E699D0 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1E69120 Offset: 0x1E67B20 VA: 0x181E69120 Slot: 22
	public override void Flush() { }

	// RVA: 0x1E69A80 Offset: 0x1E68480 VA: 0x181E69A80 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1E69AC0 Offset: 0x1E684C0 VA: 0x181E69AC0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1E69FC0 Offset: 0x1E689C0 VA: 0x181E69FC0 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1E691B0 Offset: 0x1E67BB0 VA: 0x181E691B0 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1E692F0 Offset: 0x1E67CF0 VA: 0x181E692F0 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1E69330 Offset: 0x1E67D30 VA: 0x181E69330 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x1E695D0 Offset: 0x1E67FD0 VA: 0x181E695D0 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1E68D20 Offset: 0x1E67720 VA: 0x181E68D20
	private int EmitHeader() { }

	// RVA: 0x1E68B10 Offset: 0x1E67510 VA: 0x181E68B10
	public static byte[] CompressString(string s) { }

	// RVA: 0x1E689C0 Offset: 0x1E673C0 VA: 0x181E689C0
	public static byte[] CompressBuffer(byte[] b) { }

	// RVA: 0x1E694A0 Offset: 0x1E67EA0 VA: 0x181E694A0
	public static string UncompressString(byte[] compressed) { }

	// RVA: 0x1E69370 Offset: 0x1E67D70 VA: 0x181E69370
	public static byte[] UncompressBuffer(byte[] compressed) { }
}
