public class CountingStream : Stream // TypeDefIndex: 16609
{
	// Fields
	private Stream _s; // 0x28
	private long _bytesWritten; // 0x30
	private long _bytesRead; // 0x38
	private long _initialOffset; // 0x40

	// Properties
	public Stream WrappedStream { get; }
	public long BytesWritten { get; }
	public long BytesRead { get; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public long ComputedPosition { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1E30750 Offset: 0x1E2F150 VA: 0x181E30750
	public void .ctor(Stream stream) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public Stream get_WrappedStream() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public long get_BytesWritten() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public long get_BytesRead() { }

	// RVA: 0x1E30570 Offset: 0x1E2EF70 VA: 0x181E30570
	public void Adjust(long delta) { }

	// RVA: 0x1E30660 Offset: 0x1E2F060 VA: 0x181E30660 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1E30700 Offset: 0x1E2F100 VA: 0x181E30700 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1E30810 Offset: 0x1E2F210 VA: 0x181E30810 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1DF5CB0 Offset: 0x1DF46B0 VA: 0x181DF5CB0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1E30840 Offset: 0x1E2F240 VA: 0x181E30840 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1C01DA0 Offset: 0x1C007A0 VA: 0x181C01DA0 Slot: 22
	public override void Flush() { }

	// RVA: 0x1E30880 Offset: 0x1E2F280 VA: 0x181E30880 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1E30870 Offset: 0x1E2F270 VA: 0x181E30870
	public long get_ComputedPosition() { }

	// RVA: 0x1E308B0 Offset: 0x1E2F2B0 VA: 0x181E308B0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1E308E0 Offset: 0x1E2F2E0 VA: 0x181E308E0 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1E306A0 Offset: 0x1E2F0A0 VA: 0x181E306A0 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1E306D0 Offset: 0x1E2F0D0 VA: 0x181E306D0 Slot: 33
	public override void SetLength(long value) { }
}
