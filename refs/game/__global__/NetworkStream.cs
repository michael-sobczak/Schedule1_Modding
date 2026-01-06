public class NetworkStream : Stream // TypeDefIndex: 10179
{
	// Fields
	private readonly Socket _streamSocket; // 0x28
	private readonly bool _ownsSocket; // 0x30
	private bool _readable; // 0x31
	private bool _writeable; // 0x32
	private int _closeTimeout; // 0x34
	private bool _cleanedUp; // 0x38
	private int _currentReadTimeout; // 0x3C
	private int _currentWriteTimeout; // 0x40

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override bool CanTimeout { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }
	public override long Length { get; }
	public override long Position { get; set; }
	internal Socket InternalSocket { get; }

	// Methods

	// RVA: 0x25E0AA0 Offset: 0x25DF4A0 VA: 0x1825E0AA0
	public void .ctor(Socket socket) { }

	// RVA: 0x25E0AC0 Offset: 0x25DF4C0 VA: 0x1825E0AC0
	public void .ctor(Socket socket, bool ownsSocket) { }

	// RVA: 0x25E0AF0 Offset: 0x25DF4F0 VA: 0x1825E0AF0
	public void .ctor(Socket socket, FileAccess access, bool ownsSocket) { }

	// RVA: 0x4CD9C0 Offset: 0x4CC3C0 VA: 0x1804CD9C0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x231C2D0 Offset: 0x231ACD0 VA: 0x18231C2D0 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x25E0E30 Offset: 0x25DF830 VA: 0x1825E0E30 Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x25E0FA0 Offset: 0x25DF9A0 VA: 0x1825E0FA0 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x25E0EC0 Offset: 0x25DF8C0 VA: 0x1825E0EC0 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x25E1040 Offset: 0x25DFA40 VA: 0x1825E1040 Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x25E0D90 Offset: 0x25DF790 VA: 0x1825E0D90 Slot: 11
	public override long get_Length() { }

	// RVA: 0x25E0DE0 Offset: 0x25DF7E0 VA: 0x1825E0DE0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x25E0F50 Offset: 0x25DF950 VA: 0x1825E0F50 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x25DFA70 Offset: 0x25DE470 VA: 0x1825DFA70 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x25DF680 Offset: 0x25DE080 VA: 0x1825DF680 Slot: 34
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x25DF340 Offset: 0x25DDD40 VA: 0x1825DF340 Slot: 35
	public override int Read(Span<byte> destination) { }

	// RVA: 0x25DF2C0 Offset: 0x25DDCC0 VA: 0x1825DF2C0 Slot: 36
	public override int ReadByte() { }

	// RVA: 0x25E0710 Offset: 0x25DF110 VA: 0x1825E0710 Slot: 37
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x25E0450 Offset: 0x25DEE50 VA: 0x1825E0450 Slot: 38
	public override void Write(ReadOnlySpan<byte> source) { }

	// RVA: 0x25E03E0 Offset: 0x25DEDE0 VA: 0x1825E03E0 Slot: 39
	public override void WriteByte(byte value) { }

	// RVA: 0x25DE540 Offset: 0x25DCF40 VA: 0x1825DE540
	public void Close(int timeout) { }

	// RVA: 0x25DE5B0 Offset: 0x25DCFB0 VA: 0x1825DE5B0 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1B20CA0 Offset: 0x1B1F6A0 VA: 0x181B20CA0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x25DDE00 Offset: 0x25DC800 VA: 0x1825DDE00 Slot: 24
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x25DE6A0 Offset: 0x25DD0A0 VA: 0x1825DE6A0 Slot: 25
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x25DE1A0 Offset: 0x25DCBA0 VA: 0x1825DE1A0 Slot: 28
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x25DE8E0 Offset: 0x25DD2E0 VA: 0x1825DE8E0 Slot: 29
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x25DEBC0 Offset: 0x25DD5C0 VA: 0x1825DEBC0 Slot: 26
	public override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x25DF000 Offset: 0x25DDA00 VA: 0x1825DF000 Slot: 27
	public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x25DFCE0 Offset: 0x25DE6E0 VA: 0x1825DFCE0 Slot: 30
	public override Task WriteAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x25E0120 Offset: 0x25DEB20 VA: 0x1825E0120 Slot: 31
	public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 22
	public override void Flush() { }

	// RVA: 0x25DEB30 Offset: 0x25DD530 VA: 0x1825DEB30 Slot: 23
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x25DFAC0 Offset: 0x25DE4C0 VA: 0x1825DFAC0 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x25DFB10 Offset: 0x25DE510 VA: 0x1825DFB10
	internal void SetSocketTimeoutOption(SocketShutdown mode, int timeout, bool silent) { }

	// RVA: 0x25E0CF0 Offset: 0x25DF6F0 VA: 0x1825E0CF0
	internal Socket get_InternalSocket() { }
}
