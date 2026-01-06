internal sealed class SqlXmlStreamWrapper : Stream // TypeDefIndex: 13031
{
	// Fields
	private Stream _stream; // 0x28
	private long _lPosition; // 0x30
	private bool _isClosed; // 0x38

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x20FEBD0 Offset: 0x20FD5D0 VA: 0x1820FEBD0
	internal void .ctor(Stream stream) { }

	// RVA: 0x20FEC50 Offset: 0x20FD650 VA: 0x1820FEC50 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x20FECA0 Offset: 0x20FD6A0 VA: 0x1820FECA0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x20FECF0 Offset: 0x20FD6F0 VA: 0x1820FECF0 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x20FED40 Offset: 0x20FD740 VA: 0x1820FED40 Slot: 11
	public override long get_Length() { }

	// RVA: 0x20FEE10 Offset: 0x20FD810 VA: 0x1820FEE10 Slot: 12
	public override long get_Position() { }

	// RVA: 0x20FEEC0 Offset: 0x20FD8C0 VA: 0x1820FEEC0 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x20FE200 Offset: 0x20FCC00 VA: 0x1820FE200 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x20FDF80 Offset: 0x20FC980 VA: 0x1820FDF80 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x20FE940 Offset: 0x20FD340 VA: 0x1820FE940 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x20FDDE0 Offset: 0x20FC7E0 VA: 0x1820FDDE0 Slot: 36
	public override int ReadByte() { }

	// RVA: 0x20FE7E0 Offset: 0x20FD1E0 VA: 0x1820FE7E0 Slot: 39
	public override void WriteByte(byte value) { }

	// RVA: 0x20FE4D0 Offset: 0x20FCED0 VA: 0x1820FE4D0 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x20FDD30 Offset: 0x20FC730 VA: 0x1820FDD30 Slot: 22
	public override void Flush() { }

	// RVA: 0x20FDCE0 Offset: 0x20FC6E0 VA: 0x1820FDCE0 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x20FE650 Offset: 0x20FD050 VA: 0x1820FE650
	private void ThrowIfStreamCannotSeek(string method) { }

	// RVA: 0x20FE5C0 Offset: 0x20FCFC0 VA: 0x1820FE5C0
	private void ThrowIfStreamCannotRead(string method) { }

	// RVA: 0x20FE6E0 Offset: 0x20FD0E0 VA: 0x1820FE6E0
	private void ThrowIfStreamCannotWrite(string method) { }

	// RVA: 0x20FE770 Offset: 0x20FD170 VA: 0x1820FE770
	private void ThrowIfStreamClosed(string method) { }

	// RVA: 0x20FDD50 Offset: 0x20FC750 VA: 0x1820FDD50
	private bool IsStreamClosed() { }
}
