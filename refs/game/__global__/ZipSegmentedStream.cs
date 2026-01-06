internal class ZipSegmentedStream : Stream // TypeDefIndex: 16632
{
	// Fields
	private ZipSegmentedStream.RwMode rwMode; // 0x28
	private bool _exceptionPending; // 0x2C
	private string _baseName; // 0x30
	private string _baseDir; // 0x38
	private string _currentName; // 0x40
	private string _currentTempName; // 0x48
	private uint _currentDiskNumber; // 0x50
	private uint _maxDiskNumber; // 0x54
	private int _maxSegmentSize; // 0x58
	private Stream _innerStream; // 0x60
	[CompilerGenerated]
	private bool <ContiguousWrite>k__BackingField; // 0x68

	// Properties
	public bool ContiguousWrite { get; set; }
	public uint CurrentSegment { get; set; }
	public string CurrentName { get; }
	public string CurrentTempName { get; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1E5BBA0 Offset: 0x1E5A5A0 VA: 0x181E5BBA0
	private void .ctor() { }

	// RVA: 0x1E5AB20 Offset: 0x1E59520 VA: 0x181E5AB20
	public static ZipSegmentedStream ForReading(string name, uint initialDiskNumber, uint maxDiskNumber) { }

	// RVA: 0x1E5AD90 Offset: 0x1E59790 VA: 0x181E5AD90
	public static ZipSegmentedStream ForWriting(string name, int maxSegmentSize) { }

	// RVA: 0x1E5AC60 Offset: 0x1E59660 VA: 0x181E5AC60
	public static Stream ForUpdate(string name, uint diskNumber) { }

	[CompilerGenerated]
	// RVA: 0xCE3DC0 Offset: 0xCE27C0 VA: 0x180CE3DC0
	public bool get_ContiguousWrite() { }

	[CompilerGenerated]
	// RVA: 0xCE3E20 Offset: 0xCE2820 VA: 0x180CE3E20
	public void set_ContiguousWrite(bool value) { }

	// RVA: 0x4B61B0 Offset: 0x4B4BB0 VA: 0x1804B61B0
	public uint get_CurrentSegment() { }

	// RVA: 0x1E5BD70 Offset: 0x1E5A770 VA: 0x181E5BD70
	private void set_CurrentSegment(uint value) { }

	// RVA: 0x1E5BCD0 Offset: 0x1E5A6D0 VA: 0x181E5BCD0
	public string get_CurrentName() { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public string get_CurrentTempName() { }

	// RVA: 0x1E5B870 Offset: 0x1E5A270 VA: 0x181E5B870
	private string _NameForSegment(uint diskNumber) { }

	// RVA: 0x1E5AA20 Offset: 0x1E59420 VA: 0x181E5AA20
	public uint ComputeSegment(int length) { }

	// RVA: 0x1E5B1A0 Offset: 0x1E59BA0 VA: 0x181E5B1A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E5B990 Offset: 0x1E5A390 VA: 0x181E5B990
	private void _SetReadStream() { }

	// RVA: 0x1E5AEF0 Offset: 0x1E598F0 VA: 0x181E5AEF0 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1E5BA10 Offset: 0x1E5A410 VA: 0x181E5BA10
	private void _SetWriteStream(uint increment) { }

	// RVA: 0x1E5B6A0 Offset: 0x1E5A0A0 VA: 0x181E5B6A0 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1E5B3F0 Offset: 0x1E59DF0 VA: 0x181E5B3F0
	public long TruncateBackward(uint diskNumber, long offset) { }

	// RVA: 0x1E5BBF0 Offset: 0x1E5A5F0 VA: 0x181E5BBF0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1E5BC40 Offset: 0x1E5A640 VA: 0x181E5BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1E5BC80 Offset: 0x1E5A680 VA: 0x181E5BC80 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1E5AAF0 Offset: 0x1E594F0 VA: 0x181E5AAF0 Slot: 22
	public override void Flush() { }

	// RVA: 0x1E5BD10 Offset: 0x1E5A710 VA: 0x181E5BD10 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1E5BD40 Offset: 0x1E5A740 VA: 0x181E5BD40 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1E5BD90 Offset: 0x1E5A790 VA: 0x181E5BD90 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1E5B0F0 Offset: 0x1E59AF0 VA: 0x181E5B0F0 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1E5B120 Offset: 0x1E59B20 VA: 0x181E5B120 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x1E5AA70 Offset: 0x1E59470 VA: 0x181E5AA70 Slot: 21
	protected override void Dispose(bool disposing) { }
}
