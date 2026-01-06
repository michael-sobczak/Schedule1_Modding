internal class OffsetStream : Stream, IDisposable // TypeDefIndex: 16607
{
	// Fields
	private long _originalPosition; // 0x28
	private Stream _innerStream; // 0x30

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1E34720 Offset: 0x1E33120 VA: 0x181E34720
	public void .ctor(Stream s) { }

	// RVA: 0x7722F0 Offset: 0x770CF0 VA: 0x1807722F0 Slot: 6
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1E34630 Offset: 0x1E33030 VA: 0x181E34630 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1E346E0 Offset: 0x1E330E0 VA: 0x181E346E0 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1C1A320 Offset: 0x1C18D20 VA: 0x181C1A320 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1B5BB80 Offset: 0x1B5A580 VA: 0x181B5BB80 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1E34600 Offset: 0x1E33000 VA: 0x181E34600 Slot: 22
	public override void Flush() { }

	// RVA: 0x1C1A2F0 Offset: 0x1C18CF0 VA: 0x181C1A2F0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1E347B0 Offset: 0x1E331B0 VA: 0x181E347B0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1E347F0 Offset: 0x1E331F0 VA: 0x181E347F0 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1E34660 Offset: 0x1E33060 VA: 0x181E34660 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1E346A0 Offset: 0x1E330A0 VA: 0x181E346A0 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x1E345F0 Offset: 0x1E32FF0 VA: 0x181E345F0 Slot: 20
	public override void Close() { }
}
