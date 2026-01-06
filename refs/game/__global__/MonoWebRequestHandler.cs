internal class MonoWebRequestHandler : IMonoHttpClientHandler, IDisposable // TypeDefIndex: 17697
{
	// Fields
	private static long groupCounter; // 0x0
	private bool allowAutoRedirect; // 0x10
	private DecompressionMethods automaticDecompression; // 0x14
	private CookieContainer cookieContainer; // 0x18
	private ICredentials credentials; // 0x20
	private int maxAutomaticRedirections; // 0x28
	private long maxRequestContentBufferSize; // 0x30
	private bool preAuthenticate; // 0x38
	private IWebProxy proxy; // 0x40
	private bool useCookies; // 0x48
	private bool useProxy; // 0x49
	private SslClientAuthenticationOptions sslOptions; // 0x50
	private bool allowPipelining; // 0x58
	private RequestCachePolicy cachePolicy; // 0x60
	private AuthenticationLevel authenticationLevel; // 0x68
	private TimeSpan continueTimeout; // 0x70
	private TokenImpersonationLevel impersonationLevel; // 0x78
	private int maxResponseHeadersLength; // 0x7C
	private int readWriteTimeout; // 0x80
	private RemoteCertificateValidationCallback serverCertificateValidationCallback; // 0x88
	private bool unsafeAuthenticatedConnectionSharing; // 0x90
	private bool sentRequest; // 0x91
	private string connectionGroupName; // 0x98
	private Nullable<TimeSpan> timeout; // 0xA0
	private bool disposed; // 0xB0

	// Properties
	public CookieContainer CookieContainer { get; }
	public long MaxRequestContentBufferSize { get; }
	public SslClientAuthenticationOptions SslOptions { get; set; }

	// Methods

	// RVA: 0x218EC60 Offset: 0x218D660 VA: 0x18218EC60
	public void .ctor() { }

	// RVA: 0x218E730 Offset: 0x218D130 VA: 0x18218E730
	internal void EnsureModifiability() { }

	// RVA: 0x218EE20 Offset: 0x218D820 VA: 0x18218EE20 Slot: 9
	public CookieContainer get_CookieContainer() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0 Slot: 10
	public long get_MaxRequestContentBufferSize() { }

	// RVA: 0x218EE90 Offset: 0x218D890 VA: 0x18218EE90 Slot: 4
	public SslClientAuthenticationOptions get_SslOptions() { }

	// RVA: 0x218EF00 Offset: 0x218D900 VA: 0x18218EF00 Slot: 5
	public void set_SslOptions(SslClientAuthenticationOptions value) { }

	// RVA: 0x218E710 Offset: 0x218D110 VA: 0x18218E710 Slot: 8
	public void Dispose() { }

	// RVA: 0x218E690 Offset: 0x218D090 VA: 0x18218E690 Slot: 11
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x218E7A0 Offset: 0x218D1A0 VA: 0x18218E7A0
	private bool GetConnectionKeepAlive(HttpRequestHeaders headers) { }

	// RVA: 0x218D840 Offset: 0x218C240 VA: 0x18218D840 Slot: 12
	internal virtual HttpWebRequest CreateWebRequest(HttpRequestMessage request) { }

	// RVA: 0x218D400 Offset: 0x218BE00 VA: 0x18218D400
	private HttpResponseMessage CreateResponseMessage(HttpWebResponse wr, HttpRequestMessage requestMessage, CancellationToken cancellationToken) { }

	// RVA: 0x218E910 Offset: 0x218D310 VA: 0x18218E910
	private static bool MethodHasBody(HttpMethod method) { }

	[AsyncStateMachine(typeof(MonoWebRequestHandler.<SendAsync>d__99))]
	// RVA: 0x218EA00 Offset: 0x218D400 VA: 0x18218EA00 Slot: 6
	public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

	// RVA: 0x218EB30 Offset: 0x218D530 VA: 0x18218EB30 Slot: 7
	private void System.Net.Http.IMonoHttpClientHandler.SetWebRequestTimeout(TimeSpan timeout) { }

	[CompilerGenerated]
	// RVA: 0x218EB90 Offset: 0x218D590 VA: 0x18218EB90
	private X509Certificate <CreateWebRequest>b__96_0(string t, X509CertificateCollection lc, X509Certificate rc, string[] ai) { }
}
