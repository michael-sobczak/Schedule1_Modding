public class FileStream : Stream // TypeDefIndex: 5106
{
	// Fields
	private static byte[] buf_recycle; // 0x0
	private static readonly object buf_recycle_lock; // 0x8
	private byte[] buf; // 0x28
	private string name; // 0x30
	private SafeFileHandle safeHandle; // 0x38
	private bool isExposed; // 0x40
	private long append_startpos; // 0x48
	private FileAccess access; // 0x50
	private bool owner; // 0x54
	private bool async; // 0x55
	private bool canseek; // 0x56
	private bool anonymous; // 0x57
	private bool buf_dirty; // 0x58
	private int buf_size; // 0x5C
	private int buf_length; // 0x60
	private int buf_offset; // 0x64
	private long buf_start; // 0x68

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public virtual string Name { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public virtual SafeFileHandle SafeFileHandle { get; }

	// Methods

	// RVA: 0x1C2D160 Offset: 0x1C2BB60 VA: 0x181C2D160
	internal void .ctor(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper) { }

	// RVA: 0x1C2DD70 Offset: 0x1C2C770 VA: 0x181C2DD70
	public void .ctor(string path, FileMode mode) { }

	// RVA: 0x1C2D310 Offset: 0x1C2BD10 VA: 0x181C2D310
	public void .ctor(string path, FileMode mode, FileAccess access) { }

	// RVA: 0x1C2DEC0 Offset: 0x1C2C8C0 VA: 0x181C2DEC0
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share) { }

	// RVA: 0x1C2D120 Offset: 0x1C2BB20 VA: 0x181C2D120
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize) { }

	// RVA: 0x1C2DEF0 Offset: 0x1C2C8F0 VA: 0x181C2DEF0
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync) { }

	// RVA: 0x1C2DF40 Offset: 0x1C2C940 VA: 0x181C2DF40
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options) { }

	// RVA: 0x1C2DE00 Offset: 0x1C2C800 VA: 0x181C2DE00
	public void .ctor(SafeFileHandle handle, FileAccess access) { }

	// RVA: 0x1C2DCA0 Offset: 0x1C2C6A0 VA: 0x181C2DCA0
	public void .ctor(SafeFileHandle handle, FileAccess access, int bufferSize, bool isAsync) { }

	// RVA: 0x1C2DDB0 Offset: 0x1C2C7B0 VA: 0x181C2DDB0
	internal void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool isAsync, bool anonymous) { }

	// RVA: 0x1C2D350 Offset: 0x1C2BD50 VA: 0x181C2D350
	internal void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool anonymous, FileOptions options) { }

	// RVA: 0x1C2B6C0 Offset: 0x1C2A0C0 VA: 0x181C2B6C0
	private void Init(SafeFileHandle safeHandle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper) { }

	// RVA: 0x1C2DF80 Offset: 0x1C2C980 VA: 0x181C2DF80 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1C2DFB0 Offset: 0x1C2C9B0 VA: 0x181C2DFB0 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1C2DFA0 Offset: 0x1C2C9A0 VA: 0x181C2DFA0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0 Slot: 40
	public virtual string get_Name() { }

	// RVA: 0x1C2DFD0 Offset: 0x1C2C9D0 VA: 0x181C2DFD0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1C2E180 Offset: 0x1C2CB80 VA: 0x181C2E180 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1C2E380 Offset: 0x1C2CD80 VA: 0x181C2E380 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1C2E340 Offset: 0x1C2CD40 VA: 0x181C2E340 Slot: 41
	public virtual SafeFileHandle get_SafeFileHandle() { }

	// RVA: 0x1C2AD60 Offset: 0x1C29760 VA: 0x181C2AD60
	private void ExposeHandle() { }

	// RVA: 0x1C2BB10 Offset: 0x1C2A510 VA: 0x181C2BB10 Slot: 36
	public override int ReadByte() { }

	// RVA: 0x1C2C9B0 Offset: 0x1C2B3B0 VA: 0x181C2C9B0 Slot: 39
	public override void WriteByte(byte value) { }

	// RVA: 0x1C2BF40 Offset: 0x1C2A940 VA: 0x181C2BF40 Slot: 34
	public override int Read([In] [Out] byte[] array, int offset, int count) { }

	// RVA: 0x1C2BDC0 Offset: 0x1C2A7C0 VA: 0x181C2BDC0
	private int ReadInternal(byte[] dest, int offset, int count) { }

	// RVA: 0x1C29D30 Offset: 0x1C28730 VA: 0x181C29D30 Slot: 24
	public override IAsyncResult BeginRead(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject) { }

	// RVA: 0x1C2A980 Offset: 0x1C29380 VA: 0x181C2A980 Slot: 25
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1C2CDD0 Offset: 0x1C2B7D0 VA: 0x181C2CDD0 Slot: 37
	public override void Write(byte[] array, int offset, int count) { }

	// RVA: 0x1C2CB20 Offset: 0x1C2B520 VA: 0x181C2CB20
	private void WriteInternal(byte[] src, int offset, int count) { }

	// RVA: 0x1C2A140 Offset: 0x1C28B40 VA: 0x181C2A140 Slot: 28
	public override IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject) { }

	// RVA: 0x1C2AB80 Offset: 0x1C29580 VA: 0x181C2AB80 Slot: 29
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1C2C330 Offset: 0x1C2AD30 VA: 0x181C2C330 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1C2C640 Offset: 0x1C2B040 VA: 0x181C2C640 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x1C2B200 Offset: 0x1C29C00 VA: 0x181C2B200 Slot: 22
	public override void Flush() { }

	// RVA: 0x1B20CA0 Offset: 0x1B1F6A0 VA: 0x181B20CA0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1C2A660 Offset: 0x1C29060 VA: 0x181C2A660 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1C2AD90 Offset: 0x1C29790 VA: 0x181C2AD90 Slot: 23
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1C2BA30 Offset: 0x1C2A430 VA: 0x181C2BA30 Slot: 26
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1C2C8E0 Offset: 0x1C2B2E0 VA: 0x181C2C8E0 Slot: 30
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1C2BE90 Offset: 0x1C2A890 VA: 0x181C2BE90
	private int ReadSegment(byte[] dest, int dest_offset, int count) { }

	// RVA: 0x1C2CD60 Offset: 0x1C2B760 VA: 0x181C2CD60
	private int WriteSegment(byte[] src, int src_offset, int count) { }

	// RVA: 0x1C2B010 Offset: 0x1C29A10 VA: 0x181C2B010
	private void FlushBuffer() { }

	// RVA: 0x1C2B000 Offset: 0x1C29A00 VA: 0x181C2B000
	private void FlushBufferIfDirty() { }

	// RVA: 0x1C2C2F0 Offset: 0x1C2ACF0 VA: 0x181C2C2F0
	private void RefillBuffer() { }

	// RVA: 0x1C2BC80 Offset: 0x1C2A680 VA: 0x181C2BC80
	private int ReadData(SafeHandle safeHandle, byte[] buf, int offset, int count) { }

	// RVA: 0x1C2B420 Offset: 0x1C29E20 VA: 0x181C2B420
	private void InitBuffer(int size, bool isZeroSize) { }

	// RVA: 0x1C2B360 Offset: 0x1C29D60 VA: 0x181C2B360
	private string GetSecureFileName(string filename) { }

	// RVA: 0x1C2B280 Offset: 0x1C29C80 VA: 0x181C2B280
	private string GetSecureFileName(string filename, bool full) { }

	// RVA: 0x1C2D0A0 Offset: 0x1C2BAA0 VA: 0x181C2D0A0
	private static void .cctor() { }
}
