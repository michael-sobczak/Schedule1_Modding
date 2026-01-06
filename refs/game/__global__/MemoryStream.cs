public class MemoryStream : Stream // TypeDefIndex: 5051
{
	// Fields
	private byte[] _buffer; // 0x28
	private int _origin; // 0x30
	private int _position; // 0x34
	private int _length; // 0x38
	private int _capacity; // 0x3C
	private bool _expandable; // 0x40
	private bool _writable; // 0x41
	private bool _exposable; // 0x42
	private bool _isOpen; // 0x43
	private Task<int> _lastReadTask; // 0x48

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public virtual int Capacity { get; set; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1C12030 Offset: 0x1C10A30 VA: 0x181C12030
	public void .ctor() { }

	// RVA: 0x1C120D0 Offset: 0x1C10AD0 VA: 0x181C120D0
	public void .ctor(int capacity) { }

	// RVA: 0x1C11F50 Offset: 0x1C10950 VA: 0x181C11F50
	public void .ctor(byte[] buffer) { }

	// RVA: 0x1C11E60 Offset: 0x1C10860 VA: 0x181C11E60
	public void .ctor(byte[] buffer, bool writable) { }

	// RVA: 0x1C11C00 Offset: 0x1C10600 VA: 0x181C11C00
	public void .ctor(byte[] buffer, int index, int count) { }

	// RVA: 0x1C11C30 Offset: 0x1C10630 VA: 0x181C11C30
	public void .ctor(byte[] buffer, int index, int count, bool writable, bool publiclyVisible) { }

	// RVA: 0x1C121F0 Offset: 0x1C10BF0 VA: 0x181C121F0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1C121F0 Offset: 0x1C10BF0 VA: 0x181C121F0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1C12200 Offset: 0x1C10C00 VA: 0x181C12200 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1C0FCC0 Offset: 0x1C0E6C0 VA: 0x181C0FCC0
	private void EnsureNotClosed() { }

	// RVA: 0x1C0FD00 Offset: 0x1C0E700 VA: 0x181C0FD00
	private void EnsureWriteable() { }

	// RVA: 0x1C0FB60 Offset: 0x1C0E560 VA: 0x181C0FB60 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1C0FC00 Offset: 0x1C0E600 VA: 0x181C0FC00
	private bool EnsureCapacity(int value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 22
	public override void Flush() { }

	// RVA: 0x1C0FD50 Offset: 0x1C0E750 VA: 0x181C0FD50 Slot: 23
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1C0FE80 Offset: 0x1C0E880 VA: 0x181C0FE80 Slot: 40
	public virtual byte[] GetBuffer() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	internal byte[] InternalGetBuffer() { }

	// RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00
	internal int InternalGetPosition() { }

	// RVA: 0x1C0FF50 Offset: 0x1C0E950 VA: 0x181C0FF50
	internal int InternalReadInt32() { }

	// RVA: 0x1C0FEF0 Offset: 0x1C0E8F0 VA: 0x181C0FEF0
	internal int InternalEmulateRead(int count) { }

	// RVA: 0x1C12210 Offset: 0x1C10C10 VA: 0x181C12210 Slot: 41
	public virtual int get_Capacity() { }

	// RVA: 0x1C122F0 Offset: 0x1C10CF0 VA: 0x181C122F0 Slot: 42
	public virtual void set_Capacity(int value) { }

	// RVA: 0x1C12250 Offset: 0x1C10C50 VA: 0x181C12250 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1C122A0 Offset: 0x1C10CA0 VA: 0x181C122A0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1C124A0 Offset: 0x1C10EA0 VA: 0x181C124A0 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1C10740 Offset: 0x1C0F140 VA: 0x181C10740 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1C109C0 Offset: 0x1C0F3C0 VA: 0x181C109C0 Slot: 35
	public override int Read(Span<byte> buffer) { }

	// RVA: 0x1C10380 Offset: 0x1C0ED80 VA: 0x181C10380 Slot: 26
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1C10040 Offset: 0x1C0EA40 VA: 0x181C10040 Slot: 27
	public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x1C106C0 Offset: 0x1C0F0C0 VA: 0x181C106C0 Slot: 36
	public override int ReadByte() { }

	// RVA: 0x1C0FA10 Offset: 0x1C0E410 VA: 0x181C0FA10 Slot: 19
	public override void CopyTo(Stream destination, int bufferSize) { }

	// RVA: 0x1C0F7A0 Offset: 0x1C0E1A0 VA: 0x181C0F7A0 Slot: 18
	public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	// RVA: 0x1C10BA0 Offset: 0x1C0F5A0 VA: 0x181C10BA0 Slot: 32
	public override long Seek(long offset, SeekOrigin loc) { }

	// RVA: 0x1C10DF0 Offset: 0x1C0F7F0 VA: 0x181C10DF0 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x1C10F60 Offset: 0x1C0F960 VA: 0x181C10F60 Slot: 43
	public virtual byte[] ToArray() { }

	// RVA: 0x1C118F0 Offset: 0x1C102F0 VA: 0x181C118F0 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1C11680 Offset: 0x1C10080 VA: 0x181C11680 Slot: 38
	public override void Write(ReadOnlySpan<byte> buffer) { }

	// RVA: 0x1C11290 Offset: 0x1C0FC90 VA: 0x181C11290 Slot: 30
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1C11000 Offset: 0x1C0FA00 VA: 0x181C11000 Slot: 31
	public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x1C11560 Offset: 0x1C0FF60 VA: 0x181C11560 Slot: 39
	public override void WriteByte(byte value) { }
}
