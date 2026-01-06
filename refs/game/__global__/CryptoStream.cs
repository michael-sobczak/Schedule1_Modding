public class CryptoStream : Stream, IDisposable // TypeDefIndex: 4177
{
	// Fields
	private readonly Stream _stream; // 0x28
	private readonly ICryptoTransform _transform; // 0x30
	private readonly CryptoStreamMode _transformMode; // 0x38
	private byte[] _inputBuffer; // 0x40
	private int _inputBufferIndex; // 0x48
	private int _inputBlockSize; // 0x4C
	private byte[] _outputBuffer; // 0x50
	private int _outputBufferIndex; // 0x58
	private int _outputBlockSize; // 0x5C
	private bool _canRead; // 0x60
	private bool _canWrite; // 0x61
	private bool _finalBlockTransformed; // 0x62
	private SemaphoreSlim _lazyAsyncActiveSemaphore; // 0x68
	private readonly bool _leaveOpen; // 0x70

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public bool HasFlushedFinalBlock { get; }
	private SemaphoreSlim AsyncActiveSemaphore { get; }

	// Methods

	// RVA: 0x1ACC0F0 Offset: 0x1ACAAF0 VA: 0x181ACC0F0
	public void .ctor(Stream stream, ICryptoTransform transform, CryptoStreamMode mode) { }

	// RVA: 0x1ACBDF0 Offset: 0x1ACA7F0 VA: 0x181ACBDF0
	public void .ctor(Stream stream, ICryptoTransform transform, CryptoStreamMode mode, bool leaveOpen) { }

	// RVA: 0x4C1D90 Offset: 0x4C0790 VA: 0x1804C1D90 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x848340 Offset: 0x846D40 VA: 0x180848340 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1ACC220 Offset: 0x1ACAC20 VA: 0x181ACC220 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1ACC270 Offset: 0x1ACAC70 VA: 0x181ACC270 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1ACC2C0 Offset: 0x1ACACC0 VA: 0x181ACC2C0 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0xD7FDD0 Offset: 0xD7E7D0 VA: 0x180D7FDD0
	public bool get_HasFlushedFinalBlock() { }

	// RVA: 0x1ACAFA0 Offset: 0x1AC99A0 VA: 0x181ACAFA0
	public void FlushFinalBlock() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 22
	public override void Flush() { }

	// RVA: 0x1ACAE20 Offset: 0x1AC9820 VA: 0x181ACAE20 Slot: 23
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1ACB7C0 Offset: 0x1ACA1C0 VA: 0x181ACB7C0 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1ACB810 Offset: 0x1ACA210 VA: 0x181ACB810 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x1ACB500 Offset: 0x1AC9F00 VA: 0x181ACB500 Slot: 26
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1ACA880 Offset: 0x1AC9280 VA: 0x181ACA880 Slot: 24
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1ACADD0 Offset: 0x1AC97D0 VA: 0x181ACADD0 Slot: 25
	public override int EndRead(IAsyncResult asyncResult) { }

	[AsyncStateMachine(typeof(CryptoStream.<ReadAsyncInternal>d__37))]
	// RVA: 0x1ACB3B0 Offset: 0x1AC9DB0 VA: 0x181ACB3B0
	private Task<int> ReadAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1ACB660 Offset: 0x1ACA060 VA: 0x181ACB660 Slot: 36
	public override int ReadByte() { }

	// RVA: 0x1ACBC40 Offset: 0x1ACA640 VA: 0x181ACBC40 Slot: 39
	public override void WriteByte(byte value) { }

	// RVA: 0x1ACB6E0 Offset: 0x1ACA0E0 VA: 0x181ACB6E0 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1ACA9E0 Offset: 0x1AC93E0 VA: 0x181ACA9E0
	private void CheckReadArguments(byte[] buffer, int offset, int count) { }

	[AsyncStateMachine(typeof(CryptoStream.<ReadAsyncCore>d__42))]
	// RVA: 0x1ACB250 Offset: 0x1AC9C50 VA: 0x181ACB250
	private Task<int> ReadAsyncCore(byte[] buffer, int offset, int count, CancellationToken cancellationToken, bool useAsync) { }

	// RVA: 0x1ACBAE0 Offset: 0x1ACA4E0 VA: 0x181ACBAE0 Slot: 30
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1ACA930 Offset: 0x1AC9330 VA: 0x181ACA930 Slot: 28
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1ACAE10 Offset: 0x1AC9810 VA: 0x181ACAE10 Slot: 29
	public override void EndWrite(IAsyncResult asyncResult) { }

	[AsyncStateMachine(typeof(CryptoStream.<WriteAsyncInternal>d__46))]
	// RVA: 0x1ACB9A0 Offset: 0x1ACA3A0 VA: 0x181ACB9A0
	private Task WriteAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1ACBC90 Offset: 0x1ACA690 VA: 0x181ACBC90 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1ACAB90 Offset: 0x1AC9590 VA: 0x181ACAB90
	private void CheckWriteArguments(byte[] buffer, int offset, int count) { }

	[AsyncStateMachine(typeof(CryptoStream.<WriteAsyncCore>d__49))]
	// RVA: 0x1ACB860 Offset: 0x1ACA260 VA: 0x181ACB860
	private Task WriteAsyncCore(byte[] buffer, int offset, int count, CancellationToken cancellationToken, bool useAsync) { }

	// RVA: 0x7722F0 Offset: 0x770CF0 VA: 0x1807722F0
	public void Clear() { }

	// RVA: 0x1ACAD40 Offset: 0x1AC9740 VA: 0x181ACAD40 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1ACB190 Offset: 0x1AC9B90 VA: 0x181ACB190
	private void InitializeBuffer() { }

	// RVA: 0x1ACC110 Offset: 0x1ACAB10 VA: 0x181ACC110
	private SemaphoreSlim get_AsyncActiveSemaphore() { }
}
