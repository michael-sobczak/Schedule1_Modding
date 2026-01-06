public class ParallelDeflateOutputStream : Stream // TypeDefIndex: 16662
{
	// Fields
	private static readonly int IO_BUFFER_SIZE_DEFAULT; // 0x0
	private static readonly int BufferPairsPerCore; // 0x4
	private List<WorkItem> _pool; // 0x28
	private bool _leaveOpen; // 0x30
	private bool emitting; // 0x31
	private Stream _outStream; // 0x38
	private int _maxBufferPairs; // 0x40
	private int _bufferSize; // 0x44
	private AutoResetEvent _newlyCompressedBlob; // 0x48
	private object _outputLock; // 0x50
	private bool _isClosed; // 0x58
	private bool _firstWriteDone; // 0x59
	private int _currentlyFilling; // 0x5C
	private int _lastFilled; // 0x60
	private int _lastWritten; // 0x64
	private int _latestCompressed; // 0x68
	private int _Crc32; // 0x6C
	private CRC32 _runningCrc; // 0x70
	private object _latestLock; // 0x78
	private Queue<int> _toWrite; // 0x80
	private Queue<int> _toFill; // 0x88
	private long _totalBytesProcessed; // 0x90
	private CompressionLevel _compressLevel; // 0x98
	private Exception _pendingException; // 0xA0
	private bool _handlingException; // 0xA8
	private object _eLock; // 0xB0
	private ParallelDeflateOutputStream.TraceBits _DesiredTrace; // 0xB8
	[CompilerGenerated]
	private CompressionStrategy <Strategy>k__BackingField; // 0xBC

	// Properties
	public CompressionStrategy Strategy { get; set; }
	public int MaxBufferPairs { get; set; }
	public int BufferSize { get; set; }
	public int Crc32 { get; }
	public long BytesProcessed { get; }
	public override bool CanSeek { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1E74DA0 Offset: 0x1E737A0 VA: 0x181E74DA0
	public void .ctor(Stream stream) { }

	// RVA: 0x1E74F50 Offset: 0x1E73950 VA: 0x181E74F50
	public void .ctor(Stream stream, CompressionLevel level) { }

	// RVA: 0x1E74D70 Offset: 0x1E73770 VA: 0x181E74D70
	public void .ctor(Stream stream, bool leaveOpen) { }

	// RVA: 0x1E74F70 Offset: 0x1E73970 VA: 0x181E74F70
	public void .ctor(Stream stream, CompressionLevel level, bool leaveOpen) { }

	// RVA: 0x1E74DD0 Offset: 0x1E737D0 VA: 0x181E74DD0
	public void .ctor(Stream stream, CompressionLevel level, CompressionStrategy strategy, bool leaveOpen) { }

	// RVA: 0x1E74D20 Offset: 0x1E73720 VA: 0x181E74D20
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x4E8B70 Offset: 0x4E7570 VA: 0x1804E8B70
	public CompressionStrategy get_Strategy() { }

	[CompilerGenerated]
	// RVA: 0x4E8E00 Offset: 0x4E7800 VA: 0x1804E8E00
	private void set_Strategy(CompressionStrategy value) { }

	// RVA: 0x4B5E40 Offset: 0x4B4840 VA: 0x1804B5E40
	public int get_MaxBufferPairs() { }

	// RVA: 0x1E750D0 Offset: 0x1E73AD0 VA: 0x181E750D0
	public void set_MaxBufferPairs(int value) { }

	// RVA: 0x594500 Offset: 0x592F00 VA: 0x180594500
	public int get_BufferSize() { }

	// RVA: 0x1E75040 Offset: 0x1E73A40 VA: 0x181E75040
	public void set_BufferSize(int value) { }

	// RVA: 0xA9F7F0 Offset: 0xA9E1F0 VA: 0x180A9F7F0
	public int get_Crc32() { }

	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	public long get_BytesProcessed() { }

	// RVA: 0x1E74900 Offset: 0x1E73300 VA: 0x181E74900
	private void _InitializePoolOfWorkItems() { }

	// RVA: 0x1E73EF0 Offset: 0x1E728F0 VA: 0x181E73EF0 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1E74600 Offset: 0x1E73000 VA: 0x181E74600
	private void _FlushFinish() { }

	// RVA: 0x1E74810 Offset: 0x1E73210 VA: 0x181E74810
	private void _Flush(bool lastInput) { }

	// RVA: 0x1E73A50 Offset: 0x1E72450 VA: 0x181E73A50 Slot: 22
	public override void Flush() { }

	// RVA: 0x1E733B0 Offset: 0x1E71DB0 VA: 0x181E733B0 Slot: 20
	public override void Close() { }

	// RVA: 0x1E73610 Offset: 0x1E72010 VA: 0x181E73610 Slot: 40
	public void Dispose() { }

	// RVA: 0x1AF9390 Offset: 0x1AF7D90 VA: 0x181AF9390 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1E73B20 Offset: 0x1E72520 VA: 0x181E73B20
	public void Reset(Stream stream) { }

	// RVA: 0x1E73660 Offset: 0x1E72060 VA: 0x181E73660
	private void EmitPendingBuffers(bool doAll, bool mustWait) { }

	// RVA: 0x1E741D0 Offset: 0x1E72BD0 VA: 0x181E741D0
	private void _DeflateOne(object wi) { }

	// RVA: 0x1E73470 Offset: 0x1E71E70 VA: 0x181E73470
	private bool DeflateOneSegment(WorkItem workitem) { }

	[Conditional("Trace")]
	// RVA: 0x1E73DC0 Offset: 0x1E727C0 VA: 0x181E73DC0
	private void TraceOutput(ParallelDeflateOutputStream.TraceBits bits, string format, object[] varParams) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1E74FA0 Offset: 0x1E739A0 VA: 0x181E74FA0 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1E74FD0 Offset: 0x1E739D0 VA: 0x181E74FD0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1E75010 Offset: 0x1E73A10 VA: 0x181E75010 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1E75150 Offset: 0x1E73B50 VA: 0x181E75150 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1E73AE0 Offset: 0x1E724E0 VA: 0x181E73AE0 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1E73D40 Offset: 0x1E72740 VA: 0x181E73D40 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1E73D80 Offset: 0x1E72780 VA: 0x181E73D80 Slot: 33
	public override void SetLength(long value) { }
}
