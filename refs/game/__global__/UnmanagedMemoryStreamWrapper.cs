internal sealed class UnmanagedMemoryStreamWrapper : MemoryStream // TypeDefIndex: 5075
{
	// Fields
	private UnmanagedMemoryStream _unmanagedStream; // 0x50

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override int Capacity { get; set; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1C209E0 Offset: 0x1C1F3E0 VA: 0x181C209E0
	internal void .ctor(UnmanagedMemoryStream stream) { }

	// RVA: 0x1C20AA0 Offset: 0x1C1F4A0 VA: 0x181C20AA0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1C20AD0 Offset: 0x1C1F4D0 VA: 0x181C20AD0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1C20B00 Offset: 0x1C1F500 VA: 0x181C20B00 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1C20540 Offset: 0x1C1EF40 VA: 0x181C20540 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1C20600 Offset: 0x1C1F000 VA: 0x181C20600 Slot: 22
	public override void Flush() { }

	// RVA: 0x1C20630 Offset: 0x1C1F030 VA: 0x181C20630 Slot: 40
	public override byte[] GetBuffer() { }

	// RVA: 0x1C20B30 Offset: 0x1C1F530 VA: 0x181C20B30 Slot: 41
	public override int get_Capacity() { }

	// RVA: 0x1C20BE0 Offset: 0x1C1F5E0 VA: 0x181C20BE0 Slot: 42
	public override void set_Capacity(int value) { }

	// RVA: 0x1C20B80 Offset: 0x1C1F580 VA: 0x181C20B80 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1C20BB0 Offset: 0x1C1F5B0 VA: 0x181C20BB0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1C20C30 Offset: 0x1C1F630 VA: 0x181C20C30 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1C20780 Offset: 0x1C1F180 VA: 0x181C20780 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1C20740 Offset: 0x1C1F140 VA: 0x181C20740 Slot: 35
	public override int Read(Span<byte> buffer) { }

	// RVA: 0x1C20710 Offset: 0x1C1F110 VA: 0x181C20710 Slot: 36
	public override int ReadByte() { }

	// RVA: 0x1C207B0 Offset: 0x1C1F1B0 VA: 0x181C207B0 Slot: 32
	public override long Seek(long offset, SeekOrigin loc) { }

	// RVA: 0x1C207E0 Offset: 0x1C1F1E0 VA: 0x181C207E0 Slot: 43
	public override byte[] ToArray() { }

	// RVA: 0x1C209B0 Offset: 0x1C1F3B0 VA: 0x181C209B0 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1C20970 Offset: 0x1C1F370 VA: 0x181C20970 Slot: 38
	public override void Write(ReadOnlySpan<byte> buffer) { }

	// RVA: 0x1C20940 Offset: 0x1C1F340 VA: 0x181C20940 Slot: 39
	public override void WriteByte(byte value) { }

	// RVA: 0x1C10DF0 Offset: 0x1C0F7F0 VA: 0x181C10DF0 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x1C20240 Offset: 0x1C1EC40 VA: 0x181C20240 Slot: 18
	public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	// RVA: 0x1C205D0 Offset: 0x1C1EFD0 VA: 0x181C205D0 Slot: 23
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1C206E0 Offset: 0x1C1F0E0 VA: 0x181C206E0 Slot: 26
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1C20680 Offset: 0x1C1F080 VA: 0x181C20680 Slot: 27
	public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x1C208B0 Offset: 0x1C1F2B0 VA: 0x181C208B0 Slot: 30
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1C208E0 Offset: 0x1C1F2E0 VA: 0x181C208E0 Slot: 31
	public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken) { }
}
