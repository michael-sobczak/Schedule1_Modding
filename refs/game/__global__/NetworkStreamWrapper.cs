internal class NetworkStreamWrapper : Stream // TypeDefIndex: 9958
{
	// Fields
	private TcpClient _client; // 0x28
	private NetworkStream _networkStream; // 0x30

	// Properties
	protected bool UsingSecureStream { get; }
	internal IPAddress ServerAddress { get; }
	internal Socket Socket { get; }
	internal NetworkStream NetworkStream { get; set; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override bool CanTimeout { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x26C8790 Offset: 0x26C7190 VA: 0x1826C8790
	internal void .ctor(TcpClient client) { }

	// RVA: 0x26C88D0 Offset: 0x26C72D0 VA: 0x1826C88D0
	protected bool get_UsingSecureStream() { }

	// RVA: 0x26C8820 Offset: 0x26C7220 VA: 0x1826C8820
	internal IPAddress get_ServerAddress() { }

	// RVA: 0x26C88B0 Offset: 0x26C72B0 VA: 0x1826C88B0
	internal Socket get_Socket() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	internal NetworkStream get_NetworkStream() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	internal void set_NetworkStream(NetworkStream value) { }

	// RVA: 0x1C1A320 Offset: 0x1C18D20 VA: 0x181C1A320 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1B5BB80 Offset: 0x1B5A580 VA: 0x181B5BB80 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1C19E50 Offset: 0x1C18850 VA: 0x181C19E50 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x26BD1B0 Offset: 0x26BBBB0 VA: 0x1826BD1B0 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x26BD1E0 Offset: 0x26BBBE0 VA: 0x1826BD1E0 Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x1B5B9D0 Offset: 0x1B5A3D0 VA: 0x181B5B9D0 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x26BD210 Offset: 0x26BBC10 VA: 0x1826BD210 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x1B5BBB0 Offset: 0x1B5A5B0 VA: 0x181B5BBB0 Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x1C1A2F0 Offset: 0x1C18CF0 VA: 0x181C1A2F0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1C1A350 Offset: 0x1C18D50 VA: 0x181C1A350 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1C1A230 Offset: 0x1C18C30 VA: 0x181C1A230 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x26C8700 Offset: 0x26C7100 VA: 0x1826C8700 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1E34630 Offset: 0x1E33030 VA: 0x181E34630 Slot: 34
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x26C8760 Offset: 0x26C7160 VA: 0x1826C8760 Slot: 37
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x26C85F0 Offset: 0x26C6FF0 VA: 0x1826C85F0 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x26C8570 Offset: 0x26C6F70 VA: 0x1826C8570
	internal void CloseSocket() { }

	// RVA: 0x26C85B0 Offset: 0x26C6FB0 VA: 0x1826C85B0
	public void Close(int timeout) { }

	// RVA: 0x26C84F0 Offset: 0x26C6EF0 VA: 0x1826C84F0 Slot: 24
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x26C86A0 Offset: 0x26C70A0 VA: 0x1826C86A0 Slot: 25
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x25A9150 Offset: 0x25A7B50 VA: 0x1825A9150 Slot: 26
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x26C8530 Offset: 0x26C6F30 VA: 0x1826C8530 Slot: 28
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x26C86D0 Offset: 0x26C70D0 VA: 0x1826C86D0 Slot: 29
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x26C8730 Offset: 0x26C7130 VA: 0x1826C8730 Slot: 30
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1E34600 Offset: 0x1E33000 VA: 0x181E34600 Slot: 22
	public override void Flush() { }

	// RVA: 0x1B5D770 Offset: 0x1B5C170 VA: 0x181B5D770 Slot: 23
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x26BCBF0 Offset: 0x26BB5F0 VA: 0x1826BCBF0 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x26BCC20 Offset: 0x26BB620 VA: 0x1826BCC20
	internal void SetSocketTimeoutOption(int timeout) { }
}
