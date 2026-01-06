public class UnmanagedMemoryStream : Stream // TypeDefIndex: 5074
{
	// Fields
	private SafeBuffer _buffer; // 0x28
	private byte* _mem; // 0x30
	private long _length; // 0x38
	private long _capacity; // 0x40
	private long _position; // 0x48
	private long _offset; // 0x50
	private FileAccess _access; // 0x58
	internal bool _isOpen; // 0x5C
	private Task<int> _lastReadTask; // 0x60

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public long Capacity { get; }
	public override long Position { get; set; }
	[CLSCompliant(False)]
	public byte* PositionPointer { get; }

	// Methods

	// RVA: 0x1C23160 Offset: 0x1C21B60 VA: 0x181C23160
	protected void .ctor() { }

	[CLSCompliant(False)]
	// RVA: 0x1C230D0 Offset: 0x1C21AD0 VA: 0x181C230D0
	public void .ctor(byte* pointer, long length) { }

	[CLSCompliant(False)]
	// RVA: 0x1C23040 Offset: 0x1C21A40 VA: 0x181C23040
	public void .ctor(byte* pointer, long length, long capacity, FileAccess access) { }

	[CLSCompliant(False)]
	// RVA: 0x1C20E90 Offset: 0x1C1F890 VA: 0x181C20E90
	protected void Initialize(byte* pointer, long length, long capacity, FileAccess access) { }

	// RVA: 0x1C231C0 Offset: 0x1C21BC0 VA: 0x181C231C0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x4CD980 Offset: 0x4CC380 VA: 0x1804CD980 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1C231D0 Offset: 0x1C21BD0 VA: 0x181C231D0 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1C20C60 Offset: 0x1C1F660 VA: 0x181C20C60 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1C20C80 Offset: 0x1C1F680 VA: 0x181C20C80
	private void EnsureNotClosed() { }

	// RVA: 0x1C20CC0 Offset: 0x1C1F6C0 VA: 0x181C20CC0
	private void EnsureReadable() { }

	// RVA: 0x1C20D10 Offset: 0x1C1F710 VA: 0x181C20D10
	private void EnsureWriteable() { }

	// RVA: 0x1C20C80 Offset: 0x1C1F680 VA: 0x181C20C80 Slot: 22
	public override void Flush() { }

	// RVA: 0x1C20D60 Offset: 0x1C1F760 VA: 0x181C20D60 Slot: 23
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1C23230 Offset: 0x1C21C30 VA: 0x181C23230 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1C231F0 Offset: 0x1C21BF0 VA: 0x181C231F0
	public long get_Capacity() { }

	// RVA: 0x1C23370 Offset: 0x1C21D70 VA: 0x181C23370 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1C233D0 Offset: 0x1C21DD0 VA: 0x181C233D0 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1C23280 Offset: 0x1C21C80 VA: 0x181C23280
	public byte* get_PositionPointer() { }

	// RVA: 0x1C21C10 Offset: 0x1C20610 VA: 0x181C21C10 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1C21B50 Offset: 0x1C20550 VA: 0x181C21B50 Slot: 35
	public override int Read(Span<byte> buffer) { }

	// RVA: 0x1C218C0 Offset: 0x1C202C0 VA: 0x181C218C0
	internal int ReadCore(Span<byte> buffer) { }

	// RVA: 0x1C21420 Offset: 0x1C1FE20 VA: 0x181C21420 Slot: 26
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1C21120 Offset: 0x1C1FB20 VA: 0x181C21120 Slot: 27
	public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x1C21730 Offset: 0x1C20130 VA: 0x181C21730 Slot: 36
	public override int ReadByte() { }

	// RVA: 0x1C21E30 Offset: 0x1C20830 VA: 0x181C21E30 Slot: 32
	public override long Seek(long offset, SeekOrigin loc) { }

	// RVA: 0x1C22010 Offset: 0x1C20A10 VA: 0x181C22010 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x1C22D30 Offset: 0x1C21730 VA: 0x181C22D30 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1C22F80 Offset: 0x1C21980 VA: 0x181C22F80 Slot: 38
	public override void Write(ReadOnlySpan<byte> buffer) { }

	// RVA: 0x1C22990 Offset: 0x1C21390 VA: 0x181C22990
	internal void WriteCore(ReadOnlySpan<byte> buffer) { }

	// RVA: 0x1C22200 Offset: 0x1C20C00 VA: 0x181C22200 Slot: 30
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1C22490 Offset: 0x1C20E90 VA: 0x181C22490 Slot: 31
	public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x1C226F0 Offset: 0x1C210F0 VA: 0x181C226F0 Slot: 39
	public override void WriteByte(byte value) { }
}
