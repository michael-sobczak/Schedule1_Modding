public abstract class Stream : MarshalByRefObject, IDisposable // TypeDefIndex: 5098
{
	// Fields
	public static readonly Stream Null; // 0x0
	private Stream.ReadWriteTask _activeReadWriteTask; // 0x18
	private SemaphoreSlim _asyncActiveSemaphore; // 0x20

	// Properties
	public abstract bool CanRead { get; }
	public abstract bool CanSeek { get; }
	public virtual bool CanTimeout { get; }
	public abstract bool CanWrite { get; }
	public abstract long Length { get; }
	public abstract long Position { get; set; }
	public virtual int ReadTimeout { get; set; }
	public virtual int WriteTimeout { get; set; }

	// Methods

	// RVA: 0x1C3B510 Offset: 0x1C39F10 VA: 0x181C3B510
	internal SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_CanRead();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_CanSeek();

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 9
	public virtual bool get_CanTimeout() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool get_CanWrite();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract long get_Length();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract long get_Position();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void set_Position(long value);

	// RVA: 0x1C3CDD0 Offset: 0x1C3B7D0 VA: 0x181C3CDD0 Slot: 14
	public virtual int get_ReadTimeout() { }

	// RVA: 0x1C3CE70 Offset: 0x1C3B870 VA: 0x181C3CE70 Slot: 15
	public virtual void set_ReadTimeout(int value) { }

	// RVA: 0x1C3CE20 Offset: 0x1C3B820 VA: 0x181C3CE20 Slot: 16
	public virtual int get_WriteTimeout() { }

	// RVA: 0x1C3CEC0 Offset: 0x1C3B8C0 VA: 0x181C3CEC0 Slot: 17
	public virtual void set_WriteTimeout(int value) { }

	// RVA: 0x1C3AE10 Offset: 0x1C39810 VA: 0x181C3AE10
	public Task CopyToAsync(Stream destination) { }

	// RVA: 0x1C3AEA0 Offset: 0x1C398A0 VA: 0x181C3AEA0
	public Task CopyToAsync(Stream destination, int bufferSize) { }

	// RVA: 0x1C3ACD0 Offset: 0x1C396D0 VA: 0x181C3ACD0 Slot: 18
	public virtual Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(Stream.<CopyToAsyncInternal>d__28))]
	// RVA: 0x1C3AB90 Offset: 0x1C39590 VA: 0x181C3AB90
	private Task CopyToAsyncInternal(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	// RVA: 0x1C3B090 Offset: 0x1C39A90 VA: 0x181C3B090
	public void CopyTo(Stream destination) { }

	// RVA: 0x1C3AF30 Offset: 0x1C39930 VA: 0x181C3AF30 Slot: 19
	public virtual void CopyTo(Stream destination, int bufferSize) { }

	// RVA: 0x1C3B970 Offset: 0x1C3A370 VA: 0x181C3B970
	private int GetCopyBufferSize() { }

	// RVA: 0x1C3AB20 Offset: 0x1C39520 VA: 0x181C3AB20 Slot: 20
	public virtual void Close() { }

	// RVA: 0x7722F0 Offset: 0x770CF0 VA: 0x1807722F0 Slot: 6
	public void Dispose() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 21
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void Flush();

	// RVA: 0x1C3B760 Offset: 0x1C3A160 VA: 0x181C3B760 Slot: 23
	public virtual Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1C3A450 Offset: 0x1C38E50 VA: 0x181C3A450 Slot: 24
	public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1C3A210 Offset: 0x1C38C10 VA: 0x181C3A210
	internal IAsyncResult BeginReadInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously, bool apm) { }

	// RVA: 0x1C3B0D0 Offset: 0x1C39AD0 VA: 0x181C3B0D0 Slot: 25
	public virtual int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1C3BEE0 Offset: 0x1C3A8E0 VA: 0x181C3BEE0
	public Task<int> ReadAsync(byte[] buffer, int offset, int count) { }

	// RVA: 0x1C3BA50 Offset: 0x1C3A450 VA: 0x181C3BA50 Slot: 26
	public virtual Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1C3BB30 Offset: 0x1C3A530 VA: 0x181C3BB30 Slot: 27
	public virtual ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x1C39D70 Offset: 0x1C38770 VA: 0x181C39D70
	private Task<int> BeginEndReadAsync(byte[] buffer, int offset, int count) { }

	// RVA: 0x1C3A6D0 Offset: 0x1C390D0 VA: 0x181C3A6D0 Slot: 28
	public virtual IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1C3A490 Offset: 0x1C38E90 VA: 0x181C3A490
	internal IAsyncResult BeginWriteInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously, bool apm) { }

	// RVA: 0x1C3C230 Offset: 0x1C3AC30 VA: 0x181C3C230
	private void RunReadWriteTaskWhenReady(Task asyncWaiter, Stream.ReadWriteTask readWriteTask) { }

	// RVA: 0x1C3C400 Offset: 0x1C3AE00 VA: 0x181C3C400
	private void RunReadWriteTask(Stream.ReadWriteTask readWriteTask) { }

	// RVA: 0x1C3B620 Offset: 0x1C3A020 VA: 0x181C3B620
	private void FinishTrackingAsyncOperation() { }

	// RVA: 0x1C3B2F0 Offset: 0x1C39CF0 VA: 0x181C3B2F0 Slot: 29
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1C3C9D0 Offset: 0x1C3B3D0 VA: 0x181C3C9D0
	public Task WriteAsync(byte[] buffer, int offset, int count) { }

	// RVA: 0x1C3CA70 Offset: 0x1C3B470 VA: 0x181C3CA70 Slot: 30
	public virtual Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1C3C660 Offset: 0x1C3B060 VA: 0x181C3C660 Slot: 31
	public virtual ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(Stream.<FinishWriteAsync>d__57))]
	// RVA: 0x1C3B660 Offset: 0x1C3A060 VA: 0x181C3B660
	private Task FinishWriteAsync(Task writeTask, byte[] localBuffer) { }

	// RVA: 0x1C39FC0 Offset: 0x1C389C0 VA: 0x181C39FC0
	private Task BeginEndWriteAsync(byte[] buffer, int offset, int count) { }

	// RVA: -1 Offset: -1 Slot: 32
	public abstract long Seek(long offset, SeekOrigin origin);

	// RVA: -1 Offset: -1 Slot: 33
	public abstract void SetLength(long value);

	// RVA: -1 Offset: -1 Slot: 34
	public abstract int Read(byte[] buffer, int offset, int count);

	// RVA: 0x1C3C020 Offset: 0x1C3AA20 VA: 0x181C3C020 Slot: 35
	public virtual int Read(Span<byte> buffer) { }

	// RVA: 0x1C3BF80 Offset: 0x1C3A980 VA: 0x181C3BF80 Slot: 36
	public virtual int ReadByte() { }

	// RVA: -1 Offset: -1 Slot: 37
	public abstract void Write(byte[] buffer, int offset, int count);

	// RVA: 0x1C3CBD0 Offset: 0x1C3B5D0 VA: 0x181C3CBD0 Slot: 38
	public virtual void Write(ReadOnlySpan<byte> buffer) { }

	// RVA: 0x1C3CB40 Offset: 0x1C3B540 VA: 0x181C3CB40 Slot: 39
	public virtual void WriteByte(byte value) { }

	// RVA: 0x1C3A710 Offset: 0x1C39110 VA: 0x181C3A710
	internal IAsyncResult BlockingBeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1C3A910 Offset: 0x1C39310 VA: 0x181C3A910
	internal static int BlockingEndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1C3A810 Offset: 0x1C39210 VA: 0x181C3A810
	internal IAsyncResult BlockingBeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1C3AA20 Offset: 0x1C39420 VA: 0x181C3AA20
	internal static void BlockingEndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	private bool HasOverriddenBeginEndRead() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	private bool HasOverriddenBeginEndWrite() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x1C3CD20 Offset: 0x1C3B720 VA: 0x181C3CD20
	private static void .cctor() { }

	[AsyncStateMachine(typeof(Stream.<<ReadAsync>g__FinishReadAsync|44_0>d))]
	[CompilerGenerated]
	// RVA: 0x1C3C4D0 Offset: 0x1C3AED0 VA: 0x181C3C4D0
	internal static ValueTask<int> <ReadAsync>g__FinishReadAsync|44_0(Task<int> readTask, byte[] localBuffer, Memory<byte> localDestination) { }
}
