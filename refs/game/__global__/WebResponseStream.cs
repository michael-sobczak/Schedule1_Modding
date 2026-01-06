internal class WebResponseStream : WebConnectionStream // TypeDefIndex: 10121
{
	// Fields
	private WebReadStream innerStream; // 0x58
	private bool nextReadCalled; // 0x60
	private bool bufferedEntireContent; // 0x61
	private WebCompletionSource pendingRead; // 0x68
	private object locker; // 0x70
	private int nestedRead; // 0x78
	private bool read_eof; // 0x7C
	[CompilerGenerated]
	private readonly WebRequestStream <RequestStream>k__BackingField; // 0x80
	[CompilerGenerated]
	private WebHeaderCollection <Headers>k__BackingField; // 0x88
	[CompilerGenerated]
	private HttpStatusCode <StatusCode>k__BackingField; // 0x90
	[CompilerGenerated]
	private string <StatusDescription>k__BackingField; // 0x98
	[CompilerGenerated]
	private Version <Version>k__BackingField; // 0xA0
	[CompilerGenerated]
	private bool <KeepAlive>k__BackingField; // 0xA8
	[CompilerGenerated]
	private bool <ChunkedRead>k__BackingField; // 0xA9

	// Properties
	public WebRequestStream RequestStream { get; }
	public WebHeaderCollection Headers { get; set; }
	public HttpStatusCode StatusCode { get; set; }
	public string StatusDescription { get; set; }
	public Version Version { get; set; }
	public bool KeepAlive { get; set; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	private bool ChunkedRead { get; set; }
	private bool ExpectContent { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400
	public WebRequestStream get_RequestStream() { }

	[CompilerGenerated]
	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080
	public WebHeaderCollection get_Headers() { }

	[CompilerGenerated]
	// RVA: 0x589030 Offset: 0x587A30 VA: 0x180589030
	private void set_Headers(WebHeaderCollection value) { }

	[CompilerGenerated]
	// RVA: 0x4E2430 Offset: 0x4E0E30 VA: 0x1804E2430
	public HttpStatusCode get_StatusCode() { }

	[CompilerGenerated]
	// RVA: 0x589020 Offset: 0x587A20 VA: 0x180589020
	private void set_StatusCode(HttpStatusCode value) { }

	[CompilerGenerated]
	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	public string get_StatusDescription() { }

	[CompilerGenerated]
	// RVA: 0xAA72B0 Offset: 0xAA5CB0 VA: 0x180AA72B0
	private void set_StatusDescription(string value) { }

	[CompilerGenerated]
	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190
	public Version get_Version() { }

	[CompilerGenerated]
	// RVA: 0x4B6D00 Offset: 0x4B5700 VA: 0x1804B6D00
	private void set_Version(Version value) { }

	[CompilerGenerated]
	// RVA: 0x4D63F0 Offset: 0x4D4DF0 VA: 0x1804D63F0
	public bool get_KeepAlive() { }

	[CompilerGenerated]
	// RVA: 0x4D6660 Offset: 0x4D5060 VA: 0x1804D6660
	private void set_KeepAlive(bool value) { }

	// RVA: 0x25D77C0 Offset: 0x25D61C0 VA: 0x1825D77C0
	public void .ctor(WebRequestStream request) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 10
	public override bool get_CanWrite() { }

	[CompilerGenerated]
	// RVA: 0x1DEF7C0 Offset: 0x1DEE1C0 VA: 0x181DEF7C0
	private bool get_ChunkedRead() { }

	[CompilerGenerated]
	// RVA: 0x1DEF7D0 Offset: 0x1DEE1D0 VA: 0x181DEF7D0
	private void set_ChunkedRead(bool value) { }

	[AsyncStateMachine(typeof(WebResponseStream.<ReadAsync>d__40))]
	// RVA: 0x25D7520 Offset: 0x25D5F20 VA: 0x1825D7520 Slot: 26
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x25D7040 Offset: 0x25D5A40 VA: 0x1825D7040
	private Task<int> ProcessRead(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x25D7680 Offset: 0x25D6080 VA: 0x1825D7680 Slot: 40
	protected override bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, out int result) { }

	// RVA: 0x25D7860 Offset: 0x25D6260 VA: 0x1825D7860
	private bool get_ExpectContent() { }

	// RVA: 0x25D6A80 Offset: 0x25D5480 VA: 0x1825D6A80
	private void Initialize(BufferOffsetSize buffer) { }

	[AsyncStateMachine(typeof(WebResponseStream.<ReadAllAsyncInner>d__47))]
	// RVA: 0x25D72D0 Offset: 0x25D5CD0 VA: 0x1825D72D0
	private Task<byte[]> ReadAllAsyncInner(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebResponseStream.<ReadAllAsync>d__48))]
	// RVA: 0x25D7400 Offset: 0x25D5E00 VA: 0x1825D7400
	internal Task ReadAllAsync(bool resending, CancellationToken cancellationToken) { }

	// RVA: 0x25D7740 Offset: 0x25D6140 VA: 0x1825D7740 Slot: 30
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x25D5E30 Offset: 0x25D4830 VA: 0x1825D5E30 Slot: 41
	protected override void Close_internal(ref bool disposed) { }

	// RVA: 0x25D5ED0 Offset: 0x25D48D0 VA: 0x1825D5ED0
	private WebException GetReadException(WebExceptionStatus status, Exception error, string where) { }

	[AsyncStateMachine(typeof(WebResponseStream.<InitReadAsync>d__52))]
	// RVA: 0x25D6970 Offset: 0x25D5370 VA: 0x1825D6970
	internal Task InitReadAsync(CancellationToken cancellationToken) { }

	// RVA: 0x25D6190 Offset: 0x25D4B90 VA: 0x1825D6190
	private bool GetResponse(BufferOffsetSize buffer, ref int pos, ref ReadState state) { }
}
