public class HttpClient : HttpMessageInvoker // TypeDefIndex: 17702
{
	// Fields
	private static readonly TimeSpan TimeoutDefault; // 0x0
	private Uri base_address; // 0x20
	private CancellationTokenSource cts; // 0x28
	private bool disposed; // 0x30
	private HttpRequestHeaders headers; // 0x38
	private long buffer_size; // 0x40
	private TimeSpan timeout; // 0x48

	// Properties
	public Uri BaseAddress { get; set; }
	public HttpRequestHeaders DefaultRequestHeaders { get; }
	public long MaxResponseContentBufferSize { get; }

	// Methods

	// RVA: 0x2184480 Offset: 0x2182E80 VA: 0x182184480
	public void .ctor() { }

	// RVA: 0x2184360 Offset: 0x2182D60 VA: 0x182184360
	public void .ctor(HttpMessageHandler handler, bool disposeHandler) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public Uri get_BaseAddress() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_BaseAddress(Uri value) { }

	// RVA: 0x21845C0 Offset: 0x2182FC0 VA: 0x1821845C0
	public HttpRequestHeaders get_DefaultRequestHeaders() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public long get_MaxResponseContentBufferSize() { }

	// RVA: 0x2183980 Offset: 0x2182380 VA: 0x182183980 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2183860 Offset: 0x2182260 VA: 0x182183860
	public Task<HttpResponseMessage> DeleteAsync(string requestUri) { }

	// RVA: 0x2183A00 Offset: 0x2182400 VA: 0x182183A00
	public Task<HttpResponseMessage> GetAsync(string requestUri) { }

	// RVA: 0x2183B30 Offset: 0x2182530 VA: 0x182183B30
	public Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content) { }

	// RVA: 0x2183DD0 Offset: 0x21827D0 VA: 0x182183DD0
	public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request) { }

	// RVA: 0x21842A0 Offset: 0x2182CA0 VA: 0x1821842A0 Slot: 6
	public override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

	// RVA: 0x2183E40 Offset: 0x2182840 VA: 0x182183E40
	public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(HttpClient.<SendAsyncWorker>d__47))]
	// RVA: 0x2183C80 Offset: 0x2182680 VA: 0x182183C80
	private Task<HttpResponseMessage> SendAsyncWorker(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken) { }

	// RVA: 0x21842F0 Offset: 0x2182CF0 VA: 0x1821842F0
	private static void .cctor() { }

	[DebuggerHidden]
	[CompilerGenerated]
	// RVA: 0x21842C0 Offset: 0x2182CC0 VA: 0x1821842C0
	private Task<HttpResponseMessage> <>n__0(HttpRequestMessage request, CancellationToken cancellationToken) { }
}
