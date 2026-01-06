public class BZip2OutputStream : Stream // TypeDefIndex: 16640
{
	// Fields
	private int totalBytesWrittenIn; // 0x28
	private bool leaveOpen; // 0x2C
	private BZip2Compressor compressor; // 0x30
	private uint combinedCRC; // 0x38
	private Stream output; // 0x40
	private BitWriter bw; // 0x48
	private int blockSize100k; // 0x50
	private BZip2OutputStream.TraceBits desiredTrace; // 0x54

	// Properties
	public int BlockSize { get; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1E60510 Offset: 0x1E5EF10 VA: 0x181E60510
	public void .ctor(Stream output) { }

	// RVA: 0x1E604F0 Offset: 0x1E5EEF0 VA: 0x181E604F0
	public void .ctor(Stream output, int blockSize) { }

	// RVA: 0x1E60590 Offset: 0x1E5EF90 VA: 0x181E60590
	public void .ctor(Stream output, bool leaveOpen) { }

	// RVA: 0x1E60620 Offset: 0x1E5F020 VA: 0x181E60620
	public void .ctor(Stream output, int blockSize, bool leaveOpen) { }

	// RVA: 0x1E5FB80 Offset: 0x1E5E580 VA: 0x181E5FB80 Slot: 20
	public override void Close() { }

	// RVA: 0x1E5FFC0 Offset: 0x1E5E9C0 VA: 0x181E5FFC0 Slot: 22
	public override void Flush() { }

	// RVA: 0x1E5FBD0 Offset: 0x1E5E5D0 VA: 0x181E5FBD0
	private void EmitHeader() { }

	// RVA: 0x1E5FC90 Offset: 0x1E5E690 VA: 0x181E5FC90
	private void EmitTrailer() { }

	// RVA: 0x1E5FDC0 Offset: 0x1E5E7C0 VA: 0x181E5FDC0
	private void Finish() { }

	// RVA: 0x4B61B0 Offset: 0x4B4BB0 VA: 0x1804B61B0
	public int get_BlockSize() { }

	// RVA: 0x1E601D0 Offset: 0x1E5EBD0 VA: 0x181E601D0 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1E60A00 Offset: 0x1E5F400 VA: 0x181E60A00 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1E60A80 Offset: 0x1E5F480 VA: 0x181E60A80 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1E60AC0 Offset: 0x1E5F4C0 VA: 0x181E60AC0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1E60AD0 Offset: 0x1E5F4D0 VA: 0x181E60AD0 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1E60060 Offset: 0x1E5EA60 VA: 0x181E60060 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1E600A0 Offset: 0x1E5EAA0 VA: 0x181E600A0 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x1E60020 Offset: 0x1E5EA20 VA: 0x181E60020 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	[Conditional("Trace")]
	// RVA: 0x1E600E0 Offset: 0x1E5EAE0 VA: 0x181E600E0
	private void TraceOutput(BZip2OutputStream.TraceBits bits, string format, object[] varParams) { }
}
