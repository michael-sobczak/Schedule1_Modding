internal class WebRequestStream : WebConnectionStream // TypeDefIndex: 10115
{
	// Fields
	private static byte[] crlf; // 0x0
	private MemoryStream writeBuffer; // 0x58
	private bool requestWritten; // 0x60
	private bool allowBuffering; // 0x61
	private bool sendChunked; // 0x62
	private WebCompletionSource pendingWrite; // 0x68
	private long totalWritten; // 0x70
	private byte[] headers; // 0x78
	private bool headersSent; // 0x80
	private int completeRequestWritten; // 0x84
	private int chunkTrailerWritten; // 0x88
	[CompilerGenerated]
	private readonly Stream <InnerStream>k__BackingField; // 0x90
	[CompilerGenerated]
	private readonly bool <KeepAlive>k__BackingField; // 0x98

	// Properties
	internal Stream InnerStream { get; }
	public bool KeepAlive { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	internal bool HasWriteBuffer { get; }
	internal int WriteBufferLength { get; }

	// Methods

	// RVA: 0x25D5C10 Offset: 0x25D4610 VA: 0x1825D5C10
	public void .ctor(WebConnection connection, WebOperation operation, Stream stream, WebConnectionTunnel tunnel) { }

	[CompilerGenerated]
	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	internal Stream get_InnerStream() { }

	[CompilerGenerated]
	// RVA: 0x614460 Offset: 0x612E60 VA: 0x180614460
	public bool get_KeepAlive() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x25D5DA0 Offset: 0x25D47A0 VA: 0x1825D5DA0
	internal bool get_HasWriteBuffer() { }

	// RVA: 0x25D5DD0 Offset: 0x25D47D0 VA: 0x1825D5DD0
	internal int get_WriteBufferLength() { }

	// RVA: 0x25D4E00 Offset: 0x25D3800 VA: 0x1825D4E00
	internal BufferOffsetSize GetWriteBuffer() { }

	[AsyncStateMachine(typeof(WebRequestStream.<FinishWriting>d__31))]
	// RVA: 0x25D4D00 Offset: 0x25D3700 VA: 0x1825D4D00
	private Task FinishWriting(CancellationToken cancellationToken) { }

	// RVA: 0x25D54A0 Offset: 0x25D3EA0 VA: 0x1825D54A0 Slot: 30
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebRequestStream.<WriteAsyncInner>d__33))]
	// RVA: 0x25D5360 Offset: 0x25D3D60 VA: 0x1825D5360
	private Task WriteAsyncInner(byte[] buffer, int offset, int size, WebCompletionSource completion, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebRequestStream.<ProcessWrite>d__34))]
	// RVA: 0x25D5030 Offset: 0x25D3A30 VA: 0x1825D5030
	private Task ProcessWrite(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x25D49B0 Offset: 0x25D33B0 VA: 0x1825D49B0
	private void CheckWriteOverflow(long contentLength, long totalWritten, long size) { }

	[AsyncStateMachine(typeof(WebRequestStream.<Initialize>d__36))]
	// RVA: 0x25D4F20 Offset: 0x25D3920 VA: 0x1825D4F20
	internal Task Initialize(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebRequestStream.<SetHeadersAsync>d__37))]
	// RVA: 0x25D5200 Offset: 0x25D3C00 VA: 0x1825D5200
	private Task SetHeadersAsync(bool setInternalLength, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebRequestStream.<WriteRequestAsync>d__38))]
	// RVA: 0x25D5A70 Offset: 0x25D4470 VA: 0x1825D5A70
	internal Task WriteRequestAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebRequestStream.<WriteChunkTrailer_inner>d__39))]
	// RVA: 0x25D5880 Offset: 0x25D4280 VA: 0x1825D5880
	private Task WriteChunkTrailer_inner(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebRequestStream.<WriteChunkTrailer>d__40))]
	// RVA: 0x25D5980 Offset: 0x25D4380 VA: 0x1825D5980
	private Task WriteChunkTrailer() { }

	// RVA: 0x5506F0 Offset: 0x54F0F0 VA: 0x1805506F0
	internal void KillBuffer() { }

	// RVA: 0x25D5170 Offset: 0x25D3B70 VA: 0x1825D5170 Slot: 26
	public override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x25D5320 Offset: 0x25D3D20 VA: 0x1825D5320 Slot: 40
	protected override bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, out int result) { }

	// RVA: 0x25D4A60 Offset: 0x25D3460 VA: 0x1825D4A60 Slot: 41
	protected override void Close_internal(ref bool disposed) { }

	// RVA: 0x25D5B80 Offset: 0x25D4580 VA: 0x1825D5B80
	private static void .cctor() { }
}
