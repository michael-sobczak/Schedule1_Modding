public class ParallelBZip2OutputStream : Stream // TypeDefIndex: 16644
{
	// Fields
	private static readonly int BufferPairsPerCore; // 0x0
	private int _maxWorkers; // 0x28
	private bool firstWriteDone; // 0x2C
	private int lastFilled; // 0x30
	private int lastWritten; // 0x34
	private int latestCompressed; // 0x38
	private int currentlyFilling; // 0x3C
	private Exception pendingException; // 0x40
	private bool handlingException; // 0x48
	private bool emitting; // 0x49
	private Queue<int> toWrite; // 0x50
	private Queue<int> toFill; // 0x58
	private List<WorkItem> pool; // 0x60
	private object latestLock; // 0x68
	private object eLock; // 0x70
	private object outputLock; // 0x78
	private AutoResetEvent newlyCompressedBlob; // 0x80
	private long totalBytesWrittenIn; // 0x88
	private long totalBytesWrittenOut; // 0x90
	private bool leaveOpen; // 0x98
	private uint combinedCRC; // 0x9C
	private Stream output; // 0xA0
	private BitWriter bw; // 0xA8
	private int blockSize100k; // 0xB0
	private ParallelBZip2OutputStream.TraceBits desiredTrace; // 0xB4

	// Properties
	public int MaxWorkers { get; set; }
	public int BlockSize { get; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public long BytesWrittenOut { get; }

	// Methods

	// RVA: 0x1E6E740 Offset: 0x1E6D140 VA: 0x181E6E740
	public void .ctor(Stream output) { }

	// RVA: 0x1E6E7C0 Offset: 0x1E6D1C0 VA: 0x181E6E7C0
	public void .ctor(Stream output, int blockSize) { }

	// RVA: 0x1E6E7E0 Offset: 0x1E6D1E0 VA: 0x181E6E7E0
	public void .ctor(Stream output, bool leaveOpen) { }

	// RVA: 0x1E6E870 Offset: 0x1E6D270 VA: 0x181E6E870
	public void .ctor(Stream output, int blockSize, bool leaveOpen) { }

	// RVA: 0x1E6E700 Offset: 0x1E6D100 VA: 0x181E6E700
	private static void .cctor() { }

	// RVA: 0x1E6DCB0 Offset: 0x1E6C6B0 VA: 0x181E6DCB0
	private void InitializePoolOfWorkItems() { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public int get_MaxWorkers() { }

	// RVA: 0x1E6ED80 Offset: 0x1E6D780 VA: 0x181E6ED80
	public void set_MaxWorkers(int value) { }

	// RVA: 0x1E6CF00 Offset: 0x1E6B900 VA: 0x181E6CF00 Slot: 20
	public override void Close() { }

	// RVA: 0x1E6DA00 Offset: 0x1E6C400 VA: 0x181E6DA00
	private void FlushOutput(bool lastInput) { }

	// RVA: 0x1E6DBE0 Offset: 0x1E6C5E0 VA: 0x181E6DBE0 Slot: 22
	public override void Flush() { }

	// RVA: 0x1E6D260 Offset: 0x1E6BC60 VA: 0x181E6D260
	private void EmitHeader() { }

	// RVA: 0x1E6D8B0 Offset: 0x1E6C2B0 VA: 0x181E6D8B0
	private void EmitTrailer() { }

	// RVA: 0xBBA740 Offset: 0xBB9140 VA: 0x180BBA740
	public int get_BlockSize() { }

	// RVA: 0x1E6E230 Offset: 0x1E6CC30 VA: 0x181E6E230 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1E6D320 Offset: 0x1E6BD20 VA: 0x181E6D320
	private void EmitPendingBuffers(bool doAll, bool mustWait) { }

	// RVA: 0x1E6D010 Offset: 0x1E6BA10 VA: 0x181E6D010
	private void CompressOne(object wi) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1E6ECC0 Offset: 0x1E6D6C0 VA: 0x181E6ECC0 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1E6ED40 Offset: 0x1E6D740 VA: 0x181E6ED40 Slot: 11
	public override long get_Length() { }

	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1E6EE00 Offset: 0x1E6D800 VA: 0x181E6EE00 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	public long get_BytesWrittenOut() { }

	// RVA: 0x1E6E080 Offset: 0x1E6CA80 VA: 0x181E6E080 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1E6E0C0 Offset: 0x1E6CAC0 VA: 0x181E6E0C0 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x1E6E040 Offset: 0x1E6CA40 VA: 0x181E6E040 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	[Conditional("Trace")]
	// RVA: 0x1E6E100 Offset: 0x1E6CB00 VA: 0x181E6E100
	private void TraceOutput(ParallelBZip2OutputStream.TraceBits bits, string format, object[] varParams) { }
}
