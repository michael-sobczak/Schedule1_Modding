internal sealed class DeflateManagedStream : Stream // TypeDefIndex: 17638
{
	// Fields
	private Stream _stream; // 0x28
	private CompressionMode _mode; // 0x30
	private bool _leaveOpen; // 0x34
	private InflaterManaged _inflater; // 0x38
	private DeflaterManaged _deflater; // 0x40
	private byte[] _buffer; // 0x48
	private int _asyncOperations; // 0x50
	private IFileFormatWriter _formatWriter; // 0x58
	private bool _wroteHeader; // 0x60
	private bool _wroteBytes; // 0x61

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x216B320 Offset: 0x2169D20 VA: 0x18216B320
	internal void .ctor(Stream stream, ZipArchiveEntry.CompressionMethodValues method) { }

	// RVA: 0x2169DE0 Offset: 0x21687E0 VA: 0x182169DE0
	internal void InitializeInflater(Stream stream, bool leaveOpen, IFileFormatReader reader, ZipArchiveEntry.CompressionMethodValues method = 8) { }

	// RVA: 0x216B480 Offset: 0x2169E80 VA: 0x18216B480 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x216B4B0 Offset: 0x2169EB0 VA: 0x18216B4B0 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x216B4E0 Offset: 0x2169EE0 VA: 0x18216B4E0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x216B530 Offset: 0x2169F30 VA: 0x18216B530 Slot: 12
	public override long get_Position() { }

	// RVA: 0x216B580 Offset: 0x2169F80 VA: 0x18216B580 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x2169CD0 Offset: 0x21686D0 VA: 0x182169CD0 Slot: 22
	public override void Flush() { }

	// RVA: 0x2169CF0 Offset: 0x21686F0 VA: 0x182169CF0 Slot: 23
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x216AA30 Offset: 0x2169430 VA: 0x18216AA30 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x216AA80 Offset: 0x2169480 VA: 0x18216AA80 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x216A880 Offset: 0x2169280 VA: 0x18216A880 Slot: 34
	public override int Read(byte[] array, int offset, int count) { }

	// RVA: 0x216ABE0 Offset: 0x21695E0 VA: 0x18216ABE0
	private void ValidateParameters(byte[] array, int offset, int count) { }

	// RVA: 0x2169CD0 Offset: 0x21686D0 VA: 0x182169CD0
	private void EnsureNotDisposed() { }

	// RVA: 0x216AB70 Offset: 0x2169570 VA: 0x18216AB70
	private static void ThrowStreamClosedException() { }

	// RVA: 0x2169CB0 Offset: 0x21686B0 VA: 0x182169CB0
	private void EnsureDecompressionMode() { }

	// RVA: 0x216AAD0 Offset: 0x21694D0 VA: 0x18216AAD0
	private static void ThrowCannotReadFromDeflateManagedStreamException() { }

	// RVA: 0x2169C90 Offset: 0x2168690 VA: 0x182169C90
	private void EnsureCompressionMode() { }

	// RVA: 0x216AB20 Offset: 0x2169520 VA: 0x18216AB20
	private static void ThrowCannotWriteToDeflateManagedStreamException() { }

	// RVA: 0x21696F0 Offset: 0x21680F0 VA: 0x1821696F0 Slot: 24
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x2169B60 Offset: 0x2168560 VA: 0x182169B60 Slot: 25
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x216A370 Offset: 0x2168D70 VA: 0x18216A370 Slot: 26
	public override Task<int> ReadAsync(byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(DeflateManagedStream.<ReadAsyncCore>d__40))]
	// RVA: 0x216A200 Offset: 0x2168C00 VA: 0x18216A200
	private Task<int> ReadAsyncCore(Task<int> readTask, byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x216B170 Offset: 0x2169B70 VA: 0x18216B170 Slot: 37
	public override void Write(byte[] array, int offset, int count) { }

	// RVA: 0x216B0E0 Offset: 0x2169AE0 VA: 0x18216B0E0
	private void WriteDeflaterOutput() { }

	// RVA: 0x2169A80 Offset: 0x2168480 VA: 0x182169A80
	private void DoMaintenance(byte[] array, int offset, int count) { }

	// RVA: 0x216A0A0 Offset: 0x2168AA0 VA: 0x18216A0A0
	private void PurgeBuffers(bool disposing) { }

	// RVA: 0x2169850 Offset: 0x2168250 VA: 0x182169850 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x216AE80 Offset: 0x2169880 VA: 0x18216AE80 Slot: 30
	public override Task WriteAsync(byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(DeflateManagedStream.<WriteAsyncCore>d__47))]
	// RVA: 0x216AD40 Offset: 0x2169740 VA: 0x18216AD40
	private Task WriteAsyncCore(byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x21697A0 Offset: 0x21681A0 VA: 0x1821697A0 Slot: 28
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x2169BA0 Offset: 0x21685A0 VA: 0x182169BA0 Slot: 29
	public override void EndWrite(IAsyncResult asyncResult) { }

	[DebuggerHidden]
	[CompilerGenerated]
	// RVA: 0x216ABD0 Offset: 0x21695D0 VA: 0x18216ABD0
	private Task <>n__0(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }
}
