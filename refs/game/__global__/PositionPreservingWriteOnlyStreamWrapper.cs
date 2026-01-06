internal sealed class PositionPreservingWriteOnlyStreamWrapper : Stream // TypeDefIndex: 17655
{
	// Fields
	private readonly Stream _stream; // 0x28
	private long _position; // 0x30

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Position { get; set; }
	public override bool CanTimeout { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }
	public override long Length { get; }

	// Methods

	// RVA: 0x2171450 Offset: 0x216FE50 VA: 0x182171450
	public void .ctor(Stream stream) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x2171510 Offset: 0x216FF10 VA: 0x182171510 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x2171410 Offset: 0x216FE10 VA: 0x182171410 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x21711B0 Offset: 0x216FBB0 VA: 0x1821711B0 Slot: 28
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x2171250 Offset: 0x216FC50 VA: 0x182171250 Slot: 29
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x21713E0 Offset: 0x216FDE0 VA: 0x1821713E0 Slot: 39
	public override void WriteByte(byte value) { }

	// RVA: 0x21713A0 Offset: 0x216FDA0 VA: 0x1821713A0 Slot: 30
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x20128E0 Offset: 0x20112E0 VA: 0x1820128E0 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x2012C50 Offset: 0x2011650 VA: 0x182012C50 Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x2012CF0 Offset: 0x20116F0 VA: 0x182012CF0 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x2012C80 Offset: 0x2011680 VA: 0x182012C80 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x2012D20 Offset: 0x2011720 VA: 0x182012D20 Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x1C01DA0 Offset: 0x1C007A0 VA: 0x181C01DA0 Slot: 22
	public override void Flush() { }

	// RVA: 0x2171280 Offset: 0x216FC80 VA: 0x182171280 Slot: 23
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x21711F0 Offset: 0x216FBF0 VA: 0x1821711F0 Slot: 20
	public override void Close() { }

	// RVA: 0x2171220 Offset: 0x216FC20 VA: 0x182171220 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x21714C0 Offset: 0x216FEC0 VA: 0x1821714C0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x2171300 Offset: 0x216FD00 VA: 0x182171300 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x2171350 Offset: 0x216FD50 VA: 0x182171350 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x21712B0 Offset: 0x216FCB0 VA: 0x1821712B0 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }
}
