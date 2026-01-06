internal class FtpDataStream : Stream, ICloseEx // TypeDefIndex: 9947
{
	// Fields
	private FtpWebRequest _request; // 0x28
	private NetworkStream _networkStream; // 0x30
	private bool _writeable; // 0x38
	private bool _readable; // 0x39
	private bool _isFullyRead; // 0x3A
	private bool _closing; // 0x3B

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public override bool CanTimeout { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }

	// Methods

	// RVA: 0x26BD0A0 Offset: 0x26BBAA0 VA: 0x1826BD0A0
	internal void .ctor(NetworkStream networkStream, FtpWebRequest request, TriState writeOnly) { }

	// RVA: 0x26BC770 Offset: 0x26BB170 VA: 0x1826BC770 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x26BCC80 Offset: 0x26BB680 VA: 0x1826BCC80 Slot: 40
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x26BC720 Offset: 0x26BB120 VA: 0x1826BC720
	private void CheckError() { }

	// RVA: 0x8D2180 Offset: 0x8D0B80 VA: 0x1808D2180 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1B5BB80 Offset: 0x1B5A580 VA: 0x181B5BB80 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x8D2170 Offset: 0x8D0B70 VA: 0x1808D2170 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1C1A2F0 Offset: 0x1C18CF0 VA: 0x181C1A2F0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1C1A350 Offset: 0x1C18D50 VA: 0x181C1A350 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1C1A230 Offset: 0x1C18C30 VA: 0x181C1A230 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x26BCB50 Offset: 0x26BB550 VA: 0x1826BCB50 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x26BCA80 Offset: 0x26BB480 VA: 0x1826BCA80 Slot: 34
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x26BD000 Offset: 0x26BBA00 VA: 0x1826BD000 Slot: 37
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x26BC350 Offset: 0x26BAD50 VA: 0x1826BC350
	private void AsyncReadCallback(IAsyncResult ar) { }

	// RVA: 0x26BC4E0 Offset: 0x26BAEE0 VA: 0x1826BC4E0 Slot: 24
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x26BC830 Offset: 0x26BB230 VA: 0x1826BC830 Slot: 25
	public override int EndRead(IAsyncResult ar) { }

	// RVA: 0x26BC660 Offset: 0x26BB060 VA: 0x1826BC660 Slot: 28
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x26BC9D0 Offset: 0x26BB3D0 VA: 0x1826BC9D0 Slot: 29
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1E34600 Offset: 0x1E33000 VA: 0x181E34600 Slot: 22
	public override void Flush() { }

	// RVA: 0x26BCBF0 Offset: 0x26BB5F0 VA: 0x1826BCBF0 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x26BD1B0 Offset: 0x26BBBB0 VA: 0x1826BD1B0 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x26BD1E0 Offset: 0x26BBBE0 VA: 0x1826BD1E0 Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x1B5B9D0 Offset: 0x1B5A3D0 VA: 0x181B5B9D0 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x26BD210 Offset: 0x26BBC10 VA: 0x1826BD210 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x1B5BBB0 Offset: 0x1B5A5B0 VA: 0x181B5BBB0 Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x26BCC20 Offset: 0x26BB620 VA: 0x1826BCC20
	internal void SetSocketTimeoutOption(int timeout) { }
}
