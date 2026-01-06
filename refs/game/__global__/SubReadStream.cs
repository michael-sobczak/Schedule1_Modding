internal sealed class SubReadStream : Stream // TypeDefIndex: 17671
{
	// Fields
	private readonly long _startInSuperStream; // 0x28
	private long _positionInSuperStream; // 0x30
	private readonly long _endInSuperStream; // 0x38
	private readonly Stream _superStream; // 0x40
	private bool _canRead; // 0x48
	private bool _isDisposed; // 0x49

	// Properties
	public override long Length { get; }
	public override long Position { get; set; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }

	// Methods

	// RVA: 0x21719C0 Offset: 0x21703C0 VA: 0x1821719C0
	public void .ctor(Stream superStream, long startPosition, long maxLength) { }

	// RVA: 0x2171AA0 Offset: 0x21704A0 VA: 0x182171AA0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x2171AC0 Offset: 0x21704C0 VA: 0x182171AC0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x2171AE0 Offset: 0x21704E0 VA: 0x182171AE0 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x2171A60 Offset: 0x2170460 VA: 0x182171A60 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x21718D0 Offset: 0x21702D0 VA: 0x1821718D0
	private void ThrowIfDisposed() { }

	// RVA: 0x2171850 Offset: 0x2170250 VA: 0x182171850
	private void ThrowIfCantRead() { }

	// RVA: 0x2171650 Offset: 0x2170050 VA: 0x182171650 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x2171790 Offset: 0x2170190 VA: 0x182171790 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x21717F0 Offset: 0x21701F0 VA: 0x1821717F0 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x2171960 Offset: 0x2170360 VA: 0x182171960 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x21715F0 Offset: 0x216FFF0 VA: 0x1821715F0 Slot: 22
	public override void Flush() { }

	// RVA: 0x21715D0 Offset: 0x216FFD0 VA: 0x1821715D0 Slot: 21
	protected override void Dispose(bool disposing) { }
}
