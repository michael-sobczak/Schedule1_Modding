internal class XmlRegisteredNonCachedStream : Stream // TypeDefIndex: 8100
{
	// Fields
	protected Stream stream; // 0x28
	private XmlDownloadManager downloadManager; // 0x30
	private string host; // 0x38

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x253D650 Offset: 0x253C050 VA: 0x18253D650
	internal void .ctor(Stream stream, XmlDownloadManager downloadManager, string host) { }

	// RVA: 0x253D500 Offset: 0x253BF00 VA: 0x18253D500 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x253D3B0 Offset: 0x253BDB0 VA: 0x18253D3B0 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x253D330 Offset: 0x253BD30 VA: 0x18253D330 Slot: 24
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x253D370 Offset: 0x253BD70 VA: 0x18253D370 Slot: 28
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x253D4D0 Offset: 0x253BED0 VA: 0x18253D4D0 Slot: 25
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x2171250 Offset: 0x216FC50 VA: 0x182171250 Slot: 29
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1C01DA0 Offset: 0x1C007A0 VA: 0x181C01DA0 Slot: 22
	public override void Flush() { }

	// RVA: 0x253D5C0 Offset: 0x253BFC0 VA: 0x18253D5C0 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x253D590 Offset: 0x253BF90 VA: 0x18253D590 Slot: 36
	public override int ReadByte() { }

	// RVA: 0x1E306A0 Offset: 0x1E2F0A0 VA: 0x181E306A0 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1E306D0 Offset: 0x1E2F0D0 VA: 0x181E306D0 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x253D620 Offset: 0x253C020 VA: 0x18253D620 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x253D5F0 Offset: 0x253BFF0 VA: 0x18253D5F0 Slot: 39
	public override void WriteByte(byte value) { }

	// RVA: 0x1E30810 Offset: 0x1E2F210 VA: 0x181E30810 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1DF5CB0 Offset: 0x1DF46B0 VA: 0x181DF5CB0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1E30840 Offset: 0x1E2F240 VA: 0x181E30840 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1E30880 Offset: 0x1E2F280 VA: 0x181E30880 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1E308B0 Offset: 0x1E2F2B0 VA: 0x181E308B0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x253D6F0 Offset: 0x253C0F0 VA: 0x18253D6F0 Slot: 13
	public override void set_Position(long value) { }
}
