internal abstract class WebConnectionStream : Stream // TypeDefIndex: 10097
{
	// Fields
	protected bool closed; // 0x28
	private bool disposed; // 0x29
	private object locker; // 0x30
	private int read_timeout; // 0x38
	private int write_timeout; // 0x3C
	[CompilerGenerated]
	private readonly HttpWebRequest <Request>k__BackingField; // 0x40
	[CompilerGenerated]
	private readonly WebConnection <Connection>k__BackingField; // 0x48
	[CompilerGenerated]
	private readonly WebOperation <Operation>k__BackingField; // 0x50

	// Properties
	internal HttpWebRequest Request { get; }
	internal WebConnection Connection { get; }
	internal WebOperation Operation { get; }
	internal ServicePoint ServicePoint { get; }
	public override bool CanTimeout { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x25D1010 Offset: 0x25CFA10 VA: 0x1825D1010
	protected void .ctor(WebConnection cnc, WebOperation operation) { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	internal HttpWebRequest get_Request() { }

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	internal WebConnection get_Connection() { }

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	internal WebOperation get_Operation() { }

	// RVA: 0x25D11B0 Offset: 0x25CFBB0 VA: 0x1825D11B0
	internal ServicePoint get_ServicePoint() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50 Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x25D1220 Offset: 0x25CFC20 VA: 0x1825D1220 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0xC21BD0 Offset: 0xC205D0 VA: 0x180C21BD0 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x25D1290 Offset: 0x25CFC90 VA: 0x1825D1290 Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x25D08F0 Offset: 0x25CF2F0 VA: 0x1825D08F0
	protected Exception GetException(Exception e) { }

	// RVA: -1 Offset: -1 Slot: 40
	protected abstract bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, out int result);

	// RVA: 0x25D0A70 Offset: 0x25CF470 VA: 0x1825D0A70 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x25D01C0 Offset: 0x25CEBC0 VA: 0x1825D01C0 Slot: 24
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback cb, object state) { }

	// RVA: 0x25D0690 Offset: 0x25CF090 VA: 0x1825D0690 Slot: 25
	public override int EndRead(IAsyncResult r) { }

	// RVA: 0x25D0440 Offset: 0x25CEE40 VA: 0x1825D0440 Slot: 28
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback cb, object state) { }

	// RVA: 0x25D0760 Offset: 0x25CF160 VA: 0x1825D0760 Slot: 29
	public override void EndWrite(IAsyncResult r) { }

	// RVA: 0x25D0DD0 Offset: 0x25CF7D0 VA: 0x1825D0DD0 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 22
	public override void Flush() { }

	// RVA: 0x25D0810 Offset: 0x25CF210 VA: 0x1825D0810 Slot: 23
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0xB2DE80 Offset: 0xB2C880 VA: 0x180B2DE80
	internal void InternalClose() { }

	// RVA: -1 Offset: -1 Slot: 41
	protected abstract void Close_internal(ref bool disposed);

	// RVA: 0x25D0670 Offset: 0x25CF070 VA: 0x1825D0670 Slot: 20
	public override void Close() { }

	// RVA: 0x25D0D30 Offset: 0x25CF730 VA: 0x1825D0D30 Slot: 32
	public override long Seek(long a, SeekOrigin b) { }

	// RVA: 0x25D0D80 Offset: 0x25CF780 VA: 0x1825D0D80 Slot: 33
	public override void SetLength(long a) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x25D1110 Offset: 0x25CFB10 VA: 0x1825D1110 Slot: 11
	public override long get_Length() { }

	// RVA: 0x25D1160 Offset: 0x25CFB60 VA: 0x1825D1160 Slot: 12
	public override long get_Position() { }

	// RVA: 0x25D11D0 Offset: 0x25CFBD0 VA: 0x1825D11D0 Slot: 13
	public override void set_Position(long value) { }
}
