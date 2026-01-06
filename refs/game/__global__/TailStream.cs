internal sealed class TailStream : Stream // TypeDefIndex: 4208
{
	// Fields
	private byte[] _Buffer; // 0x28
	private int _BufferSize; // 0x30
	private int _BufferIndex; // 0x34
	private bool _BufferFull; // 0x38

	// Properties
	public byte[] Buffer { get; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1AF08B0 Offset: 0x1AEF2B0 VA: 0x181AF08B0
	public void .ctor(int bufferSize) { }

	// RVA: 0x7722F0 Offset: 0x770CF0 VA: 0x1807722F0
	public void Clear() { }

	// RVA: 0x1AF0550 Offset: 0x1AEEF50 VA: 0x181AF0550 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1AF0940 Offset: 0x1AEF340 VA: 0x181AF0940
	public byte[] get_Buffer() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x5E0740 Offset: 0x5DF140 VA: 0x1805E0740 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1AF09C0 Offset: 0x1AEF3C0 VA: 0x181AF09C0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1AF0A20 Offset: 0x1AEF420 VA: 0x181AF0A20 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1AF0A80 Offset: 0x1AEF480 VA: 0x181AF0A80 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 22
	public override void Flush() { }

	// RVA: 0x1AF0660 Offset: 0x1AEF060 VA: 0x181AF0660 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1AF06C0 Offset: 0x1AEF0C0 VA: 0x181AF06C0 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x1AF0600 Offset: 0x1AEF000 VA: 0x181AF0600 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1AF0720 Offset: 0x1AEF120 VA: 0x181AF0720 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }
}
