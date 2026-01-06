internal sealed class CheckSumAndSizeWriteStream : Stream // TypeDefIndex: 17672
{
	// Fields
	private readonly Stream _baseStream; // 0x28
	private readonly Stream _baseBaseStream; // 0x30
	private long _position; // 0x38
	private uint _checksum; // 0x40
	private readonly bool _leaveOpenOnClose; // 0x44
	private bool _canWrite; // 0x45
	private bool _isDisposed; // 0x46
	private bool _everWritten; // 0x47
	private long _initialPosition; // 0x48
	private readonly ZipArchiveEntry _zipArchiveEntry; // 0x50
	private readonly EventHandler _onClose; // 0x58
	private readonly Action<long, long, uint, Stream, ZipArchiveEntry, EventHandler> _saveCrcAndSizes; // 0x60

	// Properties
	public override long Length { get; }
	public override long Position { get; set; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }

	// Methods

	// RVA: 0x2168A50 Offset: 0x2167450 VA: 0x182168A50
	public void .ctor(Stream baseStream, Stream baseBaseStream, bool leaveOpenOnClose, ZipArchiveEntry entry, EventHandler onClose, Action<long, long, uint, Stream, ZipArchiveEntry, EventHandler> saveCrcAndSizes) { }

	// RVA: 0x2168B30 Offset: 0x2167530 VA: 0x182168B30 Slot: 11
	public override long get_Length() { }

	// RVA: 0x2168B90 Offset: 0x2167590 VA: 0x182168B90 Slot: 12
	public override long get_Position() { }

	// RVA: 0x2168BB0 Offset: 0x21675B0 VA: 0x182168BB0 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x495E70 Offset: 0x494870 VA: 0x180495E70 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x2168720 Offset: 0x2167120 VA: 0x182168720
	private void ThrowIfDisposed() { }

	// RVA: 0x2168600 Offset: 0x2167000 VA: 0x182168600 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x2168660 Offset: 0x2167060 VA: 0x182168660 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x21686C0 Offset: 0x21670C0 VA: 0x1821686C0 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x21687B0 Offset: 0x21671B0 VA: 0x1821687B0 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x21685C0 Offset: 0x2166FC0 VA: 0x1821685C0 Slot: 22
	public override void Flush() { }

	// RVA: 0x21684C0 Offset: 0x2166EC0 VA: 0x1821684C0 Slot: 21
	protected override void Dispose(bool disposing) { }
}
