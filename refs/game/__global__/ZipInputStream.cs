public class ZipInputStream : Stream // TypeDefIndex: 16628
{
	// Fields
	private Stream _inputStream; // 0x28
	private Encoding _provisionalAlternateEncoding; // 0x30
	private ZipEntry _currentEntry; // 0x38
	private bool _firstEntry; // 0x40
	private bool _needSetup; // 0x41
	private ZipContainer _container; // 0x48
	private CrcCalculatorStream _crcStream; // 0x50
	private long _LeftToRead; // 0x58
	internal string _Password; // 0x60
	private long _endOfEntry; // 0x68
	private string _name; // 0x70
	private bool _leaveUnderlyingStreamOpen; // 0x78
	private bool _closed; // 0x79
	private bool _findRequired; // 0x7A
	private bool _exceptionPending; // 0x7B
	[CompilerGenerated]
	private int <CodecBufferSize>k__BackingField; // 0x7C

	// Properties
	public Encoding ProvisionalAlternateEncoding { get; set; }
	public int CodecBufferSize { get; set; }
	public string Password { set; }
	internal Stream ReadStream { get; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1E57F60 Offset: 0x1E56960 VA: 0x181E57F60
	public void .ctor(Stream stream) { }

	// RVA: 0x1E57ED0 Offset: 0x1E568D0 VA: 0x181E57ED0
	public void .ctor(string fileName) { }

	// RVA: 0x1E57E50 Offset: 0x1E56850 VA: 0x181E57E50
	public void .ctor(Stream stream, bool leaveOpen) { }

	// RVA: 0x1E57D00 Offset: 0x1E56700 VA: 0x181E57D00
	private void _Init(Stream stream, bool leaveOpen, string name) { }

	// RVA: 0x1E57C30 Offset: 0x1E56630 VA: 0x181E57C30 Slot: 3
	public override string ToString() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public Encoding get_ProvisionalAlternateEncoding() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_ProvisionalAlternateEncoding(Encoding value) { }

	[CompilerGenerated]
	// RVA: 0x6A4D90 Offset: 0x6A3790 VA: 0x1806A4D90
	public int get_CodecBufferSize() { }

	[CompilerGenerated]
	// RVA: 0xD9EBC0 Offset: 0xD9D5C0 VA: 0x180D9EBC0
	public void set_CodecBufferSize(int value) { }

	// RVA: 0x1E57FD0 Offset: 0x1E569D0 VA: 0x181E57FD0
	public void set_Password(string value) { }

	// RVA: 0x1E57BD0 Offset: 0x1E565D0 VA: 0x181E57BD0
	private void SetupStream() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	internal Stream get_ReadStream() { }

	// RVA: 0x1E579D0 Offset: 0x1E563D0 VA: 0x181E579D0 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1E57880 Offset: 0x1E56280 VA: 0x181E57880
	public ZipEntry GetNextEntry() { }

	// RVA: 0x1E577F0 Offset: 0x1E561F0 VA: 0x181E577F0 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1DF5CB0 Offset: 0x1DF46B0 VA: 0x181DF5CB0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1E30880 Offset: 0x1E2F280 VA: 0x181E30880 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1E308B0 Offset: 0x1E2F2B0 VA: 0x181E308B0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1E58050 Offset: 0x1E56A50 VA: 0x181E58050 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1E57830 Offset: 0x1E56230 VA: 0x181E57830 Slot: 22
	public override void Flush() { }

	// RVA: 0x1E57CB0 Offset: 0x1E566B0 VA: 0x181E57CB0 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1E57B60 Offset: 0x1E56560 VA: 0x181E57B60 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1E57B90 Offset: 0x1E56590 VA: 0x181E57B90 Slot: 33
	public override void SetLength(long value) { }
}
