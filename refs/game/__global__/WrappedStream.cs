internal sealed class WrappedStream : Stream // TypeDefIndex: 17670
{
	// Fields
	private readonly Stream _baseStream; // 0x28
	private readonly bool _closeBaseStream; // 0x30
	private readonly Action<ZipArchiveEntry> _onClosed; // 0x38
	private readonly ZipArchiveEntry _zipArchiveEntry; // 0x40
	private bool _isDisposed; // 0x48

	// Properties
	public override long Length { get; }
	public override long Position { get; set; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }

	// Methods

	// RVA: 0x21730A0 Offset: 0x2171AA0 VA: 0x1821730A0
	internal void .ctor(Stream baseStream, bool closeBaseStream) { }

	// RVA: 0x2172FF0 Offset: 0x21719F0 VA: 0x182172FF0
	private void .ctor(Stream baseStream, bool closeBaseStream, ZipArchiveEntry entry, Action<ZipArchiveEntry> onClosed) { }

	// RVA: 0x2172FC0 Offset: 0x21719C0 VA: 0x182172FC0
	internal void .ctor(Stream baseStream, ZipArchiveEntry entry, Action<ZipArchiveEntry> onClosed) { }

	// RVA: 0x2173180 Offset: 0x2171B80 VA: 0x182173180 Slot: 11
	public override long get_Length() { }

	// RVA: 0x21731C0 Offset: 0x2171BC0 VA: 0x1821731C0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x2173200 Offset: 0x2171C00 VA: 0x182173200 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x21730C0 Offset: 0x2171AC0 VA: 0x1821730C0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x2173100 Offset: 0x2171B00 VA: 0x182173100 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x2173140 Offset: 0x2171B40 VA: 0x182173140 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x2172EB0 Offset: 0x21718B0 VA: 0x182172EB0
	private void ThrowIfDisposed() { }

	// RVA: 0x2172D30 Offset: 0x2171730 VA: 0x182172D30
	private void ThrowIfCantRead() { }

	// RVA: 0x2172E30 Offset: 0x2171830 VA: 0x182172E30
	private void ThrowIfCantWrite() { }

	// RVA: 0x2172DB0 Offset: 0x21717B0 VA: 0x182172DB0
	private void ThrowIfCantSeek() { }

	// RVA: 0x2172B90 Offset: 0x2171590 VA: 0x182172B90 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x2172C60 Offset: 0x2171660 VA: 0x182172C60 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x2172CD0 Offset: 0x21716D0 VA: 0x182172CD0 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x2172F40 Offset: 0x2171940 VA: 0x182172F40 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x2172B40 Offset: 0x2171540 VA: 0x182172B40 Slot: 22
	public override void Flush() { }

	// RVA: 0x2172AD0 Offset: 0x21714D0 VA: 0x182172AD0 Slot: 21
	protected override void Dispose(bool disposing) { }
}
