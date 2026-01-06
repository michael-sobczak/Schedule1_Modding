internal class WebOperation // TypeDefIndex: 10104
{
	// Fields
	[CompilerGenerated]
	private readonly HttpWebRequest <Request>k__BackingField; // 0x10
	[CompilerGenerated]
	private WebConnection <Connection>k__BackingField; // 0x18
	[CompilerGenerated]
	private ServicePoint <ServicePoint>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly BufferOffsetSize <WriteBuffer>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly bool <IsNtlmChallenge>k__BackingField; // 0x30
	private CancellationTokenSource cts; // 0x38
	private WebCompletionSource<WebRequestStream> requestTask; // 0x40
	private WebCompletionSource<WebRequestStream> requestWrittenTask; // 0x48
	private WebCompletionSource<WebResponseStream> responseTask; // 0x50
	private WebCompletionSource<ValueTuple<bool, WebOperation>> finishedTask; // 0x58
	private WebRequestStream writeStream; // 0x60
	private WebResponseStream responseStream; // 0x68
	private ExceptionDispatchInfo disposedInfo; // 0x70
	private ExceptionDispatchInfo closedInfo; // 0x78
	private WebOperation priorityRequest; // 0x80
	private int requestSent; // 0x88
	private int finished; // 0x8C

	// Properties
	public HttpWebRequest Request { get; }
	public WebConnection Connection { get; set; }
	public ServicePoint ServicePoint { get; set; }
	public BufferOffsetSize WriteBuffer { get; }
	public bool IsNtlmChallenge { get; }
	public bool Aborted { get; }
	public bool Closed { get; }
	public WebRequestStream WriteStream { get; }
	internal WebCompletionSource<ValueTuple<bool, WebOperation>> Finished { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public HttpWebRequest get_Request() { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public WebConnection get_Connection() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	private void set_Connection(WebConnection value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public ServicePoint get_ServicePoint() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_ServicePoint(ServicePoint value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public BufferOffsetSize get_WriteBuffer() { }

	[CompilerGenerated]
	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	public bool get_IsNtlmChallenge() { }

	// RVA: 0x25D3A50 Offset: 0x25D2450 VA: 0x1825D3A50
	public void .ctor(HttpWebRequest request, BufferOffsetSize writeBuffer, bool isNtlmChallenge, CancellationToken cancellationToken) { }

	// RVA: 0x25D3C10 Offset: 0x25D2610 VA: 0x1825D3C10
	public bool get_Aborted() { }

	// RVA: 0x25D3C60 Offset: 0x25D2660 VA: 0x1825D3C60
	public bool get_Closed() { }

	// RVA: 0x25D29E0 Offset: 0x25D13E0 VA: 0x1825D29E0
	public void Abort() { }

	// RVA: 0x25D2B90 Offset: 0x25D1590 VA: 0x1825D2B90
	public void Close() { }

	// RVA: 0x25D33E0 Offset: 0x25D1DE0 VA: 0x1825D33E0
	private void SetCanceled() { }

	// RVA: 0x25D3590 Offset: 0x25D1F90 VA: 0x1825D3590
	private void SetError(Exception error) { }

	// RVA: 0x25D34B0 Offset: 0x25D1EB0 VA: 0x1825D34B0
	private ValueTuple<ExceptionDispatchInfo, bool> SetDisposed(ref ExceptionDispatchInfo field) { }

	// RVA: 0x25D2A40 Offset: 0x25D1440 VA: 0x1825D2A40
	internal ExceptionDispatchInfo CheckDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x25D39B0 Offset: 0x25D23B0 VA: 0x1825D39B0
	internal void ThrowIfDisposed() { }

	// RVA: 0x25D38D0 Offset: 0x25D22D0 VA: 0x1825D38D0
	internal void ThrowIfDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x25D3790 Offset: 0x25D2190 VA: 0x1825D3790
	internal void ThrowIfClosedOrDisposed() { }

	// RVA: 0x25D37F0 Offset: 0x25D21F0 VA: 0x1825D37F0
	internal void ThrowIfClosedOrDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x25D2B20 Offset: 0x25D1520 VA: 0x1825D2B20
	private ExceptionDispatchInfo CheckThrowDisposed(bool throwIt, ref ExceptionDispatchInfo field) { }

	// RVA: 0x25D30A0 Offset: 0x25D1AA0 VA: 0x1825D30A0
	internal void RegisterRequest(ServicePoint servicePoint, WebConnection connection) { }

	// RVA: 0x25D3630 Offset: 0x25D2030 VA: 0x1825D3630
	public void SetPriorityRequest(WebOperation operation) { }

	[AsyncStateMachine(typeof(WebOperation.<GetRequestStream>d__50))]
	// RVA: 0x25D2F50 Offset: 0x25D1950 VA: 0x1825D2F50
	public Task<Stream> GetRequestStream() { }

	// RVA: 0x25D2F00 Offset: 0x25D1900 VA: 0x1825D2F00
	internal Task<WebRequestStream> GetRequestStreamInternal() { }

	// RVA: 0x25D3CC0 Offset: 0x25D26C0 VA: 0x1825D3CC0
	public WebRequestStream get_WriteStream() { }

	// RVA: 0x25D3050 Offset: 0x25D1A50 VA: 0x1825D3050
	public Task<WebResponseStream> GetResponseStream() { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	internal WebCompletionSource<ValueTuple<bool, WebOperation>> get_Finished() { }

	[AsyncStateMachine(typeof(WebOperation.<Run>d__58))]
	// RVA: 0x25D3320 Offset: 0x25D1D20 VA: 0x1825D3320
	internal void Run() { }

	// RVA: 0x25D2BF0 Offset: 0x25D15F0 VA: 0x1825D2BF0
	internal void CompleteRequestWritten(WebRequestStream stream, Exception error) { }

	// RVA: 0x25D2C80 Offset: 0x25D1680 VA: 0x1825D2C80
	internal void Finish(bool ok, Exception error) { }

	[CompilerGenerated]
	// RVA: 0x25D3A10 Offset: 0x25D2410 VA: 0x1825D3A10
	private void <RegisterRequest>b__48_0() { }
}
