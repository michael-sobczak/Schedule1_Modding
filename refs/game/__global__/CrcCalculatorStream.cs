public class CrcCalculatorStream : Stream, IDisposable // TypeDefIndex: 16680
{
	// Fields
	private static readonly long UnsetLengthLimit; // 0x0
	internal Stream _innerStream; // 0x28
	private CRC32 _Crc32; // 0x30
	private long _lengthLimit; // 0x38
	private bool _leaveOpen; // 0x40

	// Properties
	public long TotalBytesSlurped { get; }
	public int Crc { get; }
	public bool LeaveOpen { get; set; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1E706B0 Offset: 0x1E6F0B0 VA: 0x181E706B0
	public void .ctor(Stream stream) { }

	// RVA: 0x1E707B0 Offset: 0x1E6F1B0 VA: 0x181E707B0
	public void .ctor(Stream stream, bool leaveOpen) { }

	// RVA: 0x1E70840 Offset: 0x1E6F240 VA: 0x181E70840
	public void .ctor(Stream stream, long length) { }

	// RVA: 0x1E70730 Offset: 0x1E6F130 VA: 0x181E70730
	public void .ctor(Stream stream, long length, bool leaveOpen) { }

	// RVA: 0x1E70990 Offset: 0x1E6F390 VA: 0x181E70990
	public void .ctor(Stream stream, long length, bool leaveOpen, CRC32 crc32) { }

	// RVA: 0x1E708C0 Offset: 0x1E6F2C0 VA: 0x181E708C0
	private void .ctor(bool leaveOpen, long length, Stream stream, CRC32 crc32) { }

	// RVA: 0x1E70670 Offset: 0x1E6F070 VA: 0x181E70670
	private static void .cctor() { }

	// RVA: 0x7722F0 Offset: 0x770CF0 VA: 0x1807722F0 Slot: 6
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1E70B70 Offset: 0x1E6F570 VA: 0x181E70B70
	public long get_TotalBytesSlurped() { }

	// RVA: 0x1E70AB0 Offset: 0x1E6F4B0 VA: 0x181E70AB0
	public int get_Crc() { }

	// RVA: 0x4988A0 Offset: 0x4972A0 VA: 0x1804988A0
	public bool get_LeaveOpen() { }

	// RVA: 0x498920 Offset: 0x497320 VA: 0x180498920
	public void set_LeaveOpen(bool value) { }

	// RVA: 0x1E70440 Offset: 0x1E6EE40 VA: 0x181E70440 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1E705E0 Offset: 0x1E6EFE0 VA: 0x181E705E0 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1E30810 Offset: 0x1E2F210 VA: 0x181E30810 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1E30840 Offset: 0x1E2F240 VA: 0x181E30840 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1C01DA0 Offset: 0x1C007A0 VA: 0x181C01DA0 Slot: 22
	public override void Flush() { }

	// RVA: 0x1E70AD0 Offset: 0x1E6F4D0 VA: 0x181E70AD0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1E70B70 Offset: 0x1E6F570 VA: 0x181E70B70 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1E70B90 Offset: 0x1E6F590 VA: 0x181E70B90 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1E70560 Offset: 0x1E6EF60 VA: 0x181E70560 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1E705A0 Offset: 0x1E6EFA0 VA: 0x181E705A0 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x1E703F0 Offset: 0x1E6EDF0 VA: 0x181E703F0 Slot: 20
	public override void Close() { }
}
