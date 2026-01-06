public class ZipOutputStream : Stream // TypeDefIndex: 16629
{
	// Fields
	private EncryptionAlgorithm _encryption; // 0x28
	private ZipEntryTimestamp _timestamp; // 0x2C
	internal string _password; // 0x30
	private string _comment; // 0x38
	private Stream _outputStream; // 0x40
	private ZipEntry _currentEntry; // 0x48
	internal Zip64Option _zip64; // 0x50
	private Dictionary<string, ZipEntry> _entriesWritten; // 0x58
	private int _entryCount; // 0x60
	private ZipOption _alternateEncodingUsage; // 0x64
	private Encoding _alternateEncoding; // 0x68
	private bool _leaveUnderlyingStreamOpen; // 0x70
	private bool _disposed; // 0x71
	private bool _exceptionPending; // 0x72
	private bool _anyEntriesUsedZip64; // 0x73
	private bool _directoryNeededZip64; // 0x74
	private CountingStream _outputCounter; // 0x78
	private Stream _encryptor; // 0x80
	private Stream _deflater; // 0x88
	private CrcCalculatorStream _entryOutputStream; // 0x90
	private bool _needToWriteEntryHeader; // 0x98
	private string _name; // 0xA0
	private bool _DontIgnoreCase; // 0xA8
	internal ParallelDeflateOutputStream ParallelDeflater; // 0xB0
	private long _ParallelDeflateThreshold; // 0xB8
	private int _maxBufferPairs; // 0xC0
	[CompilerGenerated]
	private int <CodecBufferSize>k__BackingField; // 0xC4
	[CompilerGenerated]
	private CompressionStrategy <Strategy>k__BackingField; // 0xC8
	[CompilerGenerated]
	private CompressionLevel <CompressionLevel>k__BackingField; // 0xCC
	[CompilerGenerated]
	private CompressionMethod <CompressionMethod>k__BackingField; // 0xD0

	// Properties
	public string Password { set; }
	public EncryptionAlgorithm Encryption { get; set; }
	public int CodecBufferSize { get; set; }
	public CompressionStrategy Strategy { get; set; }
	public ZipEntryTimestamp Timestamp { get; set; }
	public CompressionLevel CompressionLevel { get; set; }
	public CompressionMethod CompressionMethod { get; set; }
	public string Comment { get; set; }
	public Zip64Option EnableZip64 { get; set; }
	public bool OutputUsedZip64 { get; }
	public bool IgnoreCase { get; set; }
	[Obsolete("Beginning with v1.9.1.6 of DotNetZip, this property is obsolete. It will be removed in a future version of the library. Use AlternateEncoding and AlternateEncodingUsage instead.")]
	public bool UseUnicodeAsNecessary { get; set; }
	[Obsolete("use AlternateEncoding and AlternateEncodingUsage instead.")]
	public Encoding ProvisionalAlternateEncoding { get; set; }
	public Encoding AlternateEncoding { get; set; }
	public ZipOption AlternateEncodingUsage { get; set; }
	public static Encoding DefaultEncoding { get; }
	public long ParallelDeflateThreshold { get; set; }
	public int ParallelDeflateMaxBufferPairs { get; set; }
	internal Stream OutputStream { get; }
	internal string Name { get; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1E59000 Offset: 0x1E57A00 VA: 0x181E59000
	public void .ctor(Stream stream) { }

	// RVA: 0x1E590A0 Offset: 0x1E57AA0 VA: 0x181E590A0
	public void .ctor(string fileName) { }

	// RVA: 0x1E58F60 Offset: 0x1E57960 VA: 0x181E58F60
	public void .ctor(Stream stream, bool leaveOpen) { }

	// RVA: 0x1E58C00 Offset: 0x1E57600 VA: 0x181E58C00
	private void _Init(Stream stream, bool leaveOpen, string name) { }

	// RVA: 0x1E58840 Offset: 0x1E57240 VA: 0x181E58840 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E59520 Offset: 0x1E57F20 VA: 0x181E59520
	public void set_Password(string value) { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public EncryptionAlgorithm get_Encryption() { }

	// RVA: 0x1E59340 Offset: 0x1E57D40 VA: 0x181E59340
	public void set_Encryption(EncryptionAlgorithm value) { }

	[CompilerGenerated]
	// RVA: 0x526FE0 Offset: 0x5259E0 VA: 0x180526FE0
	public int get_CodecBufferSize() { }

	[CompilerGenerated]
	// RVA: 0x1A3AED0 Offset: 0x1A398D0 VA: 0x181A3AED0
	public void set_CodecBufferSize(int value) { }

	[CompilerGenerated]
	// RVA: 0x4F2350 Offset: 0x4F0D50 VA: 0x1804F2350
	public CompressionStrategy get_Strategy() { }

	[CompilerGenerated]
	// RVA: 0x4F2500 Offset: 0x4F0F00 VA: 0x1804F2500
	public void set_Strategy(CompressionStrategy value) { }

	// RVA: 0x65E590 Offset: 0x65CF90 VA: 0x18065E590
	public ZipEntryTimestamp get_Timestamp() { }

	// RVA: 0x1E59620 Offset: 0x1E58020 VA: 0x181E59620
	public void set_Timestamp(ZipEntryTimestamp value) { }

	[CompilerGenerated]
	// RVA: 0x6A37B0 Offset: 0x6A21B0 VA: 0x1806A37B0
	public CompressionLevel get_CompressionLevel() { }

	[CompilerGenerated]
	// RVA: 0x1A3AF40 Offset: 0x1A39940 VA: 0x181A3AF40
	public void set_CompressionLevel(CompressionLevel value) { }

	[CompilerGenerated]
	// RVA: 0x1A3AE30 Offset: 0x1A39830 VA: 0x181A3AE30
	public CompressionMethod get_CompressionMethod() { }

	[CompilerGenerated]
	// RVA: 0x1A3AF20 Offset: 0x1A39920 VA: 0x181A3AF20
	public void set_CompressionMethod(CompressionMethod value) { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public string get_Comment() { }

	// RVA: 0x1E59250 Offset: 0x1E57C50 VA: 0x181E59250
	public void set_Comment(string value) { }

	// RVA: 0x4B61B0 Offset: 0x4B4BB0 VA: 0x1804B61B0
	public Zip64Option get_EnableZip64() { }

	// RVA: 0x1E592D0 Offset: 0x1E57CD0 VA: 0x181E592D0
	public void set_EnableZip64(Zip64Option value) { }

	// RVA: 0x1E591B0 Offset: 0x1E57BB0 VA: 0x181E591B0
	public bool get_OutputUsedZip64() { }

	// RVA: 0x1E59160 Offset: 0x1E57B60 VA: 0x181E59160
	public bool get_IgnoreCase() { }

	// RVA: 0x1E59400 Offset: 0x1E57E00 VA: 0x181E59400
	public void set_IgnoreCase(bool value) { }

	// RVA: 0x1E59210 Offset: 0x1E57C10 VA: 0x181E59210
	public bool get_UseUnicodeAsNecessary() { }

	// RVA: 0x1E59690 Offset: 0x1E58090 VA: 0x181E59690
	public void set_UseUnicodeAsNecessary(bool value) { }

	// RVA: 0x1E59200 Offset: 0x1E57C00 VA: 0x181E59200
	public Encoding get_ProvisionalAlternateEncoding() { }

	// RVA: 0x1E595F0 Offset: 0x1E57FF0 VA: 0x181E595F0
	public void set_ProvisionalAlternateEncoding(Encoding value) { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public Encoding get_AlternateEncoding() { }

	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	public void set_AlternateEncoding(Encoding value) { }

	// RVA: 0x4B5430 Offset: 0x4B3E30 VA: 0x1804B5430
	public ZipOption get_AlternateEncodingUsage() { }

	// RVA: 0xC27360 Offset: 0xC25D60 VA: 0x180C27360
	public void set_AlternateEncodingUsage(ZipOption value) { }

	// RVA: 0x1E59150 Offset: 0x1E57B50 VA: 0x181E59150
	public static Encoding get_DefaultEncoding() { }

	// RVA: 0x1E594A0 Offset: 0x1E57EA0 VA: 0x181E594A0
	public void set_ParallelDeflateThreshold(long value) { }

	// RVA: 0x4B6160 Offset: 0x4B4B60 VA: 0x1804B6160
	public long get_ParallelDeflateThreshold() { }

	// RVA: 0x505900 Offset: 0x504300 VA: 0x180505900
	public int get_ParallelDeflateMaxBufferPairs() { }

	// RVA: 0x1E59410 Offset: 0x1E57E10 VA: 0x181E59410
	public void set_ParallelDeflateMaxBufferPairs(int value) { }

	// RVA: 0x1E58290 Offset: 0x1E56C90 VA: 0x181E58290
	private void InsureUniqueEntry(ZipEntry ze1) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	internal Stream get_OutputStream() { }

	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190
	internal string get_Name() { }

	// RVA: 0x1E58070 Offset: 0x1E56A70 VA: 0x181E58070
	public bool ContainsEntry(string name) { }

	// RVA: 0x1E588C0 Offset: 0x1E572C0 VA: 0x181E588C0 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1E58370 Offset: 0x1E56D70 VA: 0x181E58370
	public ZipEntry PutNextEntry(string entryName) { }

	// RVA: 0x1E58DE0 Offset: 0x1E577E0 VA: 0x181E58DE0
	private void _InitiateCurrentEntry(bool finishing) { }

	// RVA: 0x1E58AA0 Offset: 0x1E574A0 VA: 0x181E58AA0
	private void _FinishCurrentEntry() { }

	// RVA: 0x1E58100 Offset: 0x1E56B00 VA: 0x181E58100 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1E59170 Offset: 0x1E57B70 VA: 0x181E59170 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1E591D0 Offset: 0x1E57BD0 VA: 0x181E591D0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1E595B0 Offset: 0x1E57FB0 VA: 0x181E595B0 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 22
	public override void Flush() { }

	// RVA: 0x1E58760 Offset: 0x1E57160 VA: 0x181E58760 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1E587B0 Offset: 0x1E571B0 VA: 0x181E587B0 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1E58800 Offset: 0x1E57200 VA: 0x181E58800 Slot: 33
	public override void SetLength(long value) { }
}
