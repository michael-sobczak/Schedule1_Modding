public class HttpWebRequest : WebRequest, ISerializable // TypeDefIndex: 10067
{
	// Fields
	private Uri requestUri; // 0x38
	private Uri actualUri; // 0x40
	private bool hostChanged; // 0x48
	private bool allowAutoRedirect; // 0x49
	private bool allowBuffering; // 0x4A
	private X509CertificateCollection certificates; // 0x50
	private string connectionGroup; // 0x58
	private bool haveContentLength; // 0x60
	private long contentLength; // 0x68
	private HttpContinueDelegate continueDelegate; // 0x70
	private CookieContainer cookieContainer; // 0x78
	private ICredentials credentials; // 0x80
	private bool haveResponse; // 0x88
	private bool requestSent; // 0x89
	private WebHeaderCollection webHeaders; // 0x90
	private bool keepAlive; // 0x98
	private int maxAutoRedirect; // 0x9C
	private string mediaType; // 0xA0
	private string method; // 0xA8
	private string initialMethod; // 0xB0
	private bool pipelined; // 0xB8
	private bool preAuthenticate; // 0xB9
	private bool usedPreAuth; // 0xBA
	private Version version; // 0xC0
	private bool force_version; // 0xC8
	private Version actualVersion; // 0xD0
	private IWebProxy proxy; // 0xD8
	private bool sendChunked; // 0xE0
	private ServicePoint servicePoint; // 0xE8
	private int timeout; // 0xF0
	private int continueTimeout; // 0xF4
	private WebRequestStream writeStream; // 0xF8
	private HttpWebResponse webResponse; // 0x100
	private WebCompletionSource responseTask; // 0x108
	private WebOperation currentOperation; // 0x110
	private int aborted; // 0x118
	private bool gotRequestStream; // 0x11C
	private int redirects; // 0x120
	private bool expectContinue; // 0x124
	private bool getResponseCalled; // 0x125
	private object locker; // 0x128
	private bool finished_reading; // 0x130
	private DecompressionMethods auto_decomp; // 0x134
	private static int defaultMaxResponseHeadersLength; // 0x0
	private static int defaultMaximumErrorResponseLength; // 0x4
	private static RequestCachePolicy defaultCachePolicy; // 0x8
	private int readWriteTimeout; // 0x138
	private MobileTlsProvider tlsProvider; // 0x140
	private MonoTlsSettings tlsSettings; // 0x148
	private ServerCertValidationCallback certValidationCallback; // 0x150
	private bool hostHasPort; // 0x158
	private Uri hostUri; // 0x160
	private HttpWebRequest.AuthorizationState auth_state; // 0x168
	private HttpWebRequest.AuthorizationState proxy_auth_state; // 0x178
	internal Func<Stream, Task> ResendContentFactory; // 0x188
	[CompilerGenerated]
	private bool <ThrowOnError>k__BackingField; // 0x190
	private bool unsafe_auth_blah; // 0x191

	// Properties
	public Uri Address { get; }
	public virtual bool AllowAutoRedirect { set; }
	public virtual bool AllowWriteStreamBuffering { get; set; }
	public DecompressionMethods AutomaticDecompression { get; set; }
	internal bool InternalAllowBuffering { get; }
	private bool MethodWithBuffer { get; }
	internal MobileTlsProvider TlsProvider { get; }
	internal MonoTlsSettings TlsSettings { get; }
	public X509CertificateCollection ClientCertificates { get; }
	public override string ConnectionGroupName { set; }
	public override long ContentLength { get; set; }
	internal long InternalContentLength { set; }
	internal bool ThrowOnError { get; set; }
	public virtual CookieContainer CookieContainer { set; }
	public override ICredentials Credentials { get; set; }
	[MonoTODO]
	public static int DefaultMaximumErrorResponseLength { get; }
	public override WebHeaderCollection Headers { get; }
	public string Host { get; set; }
	public bool KeepAlive { get; set; }
	public int MaximumAutomaticRedirections { set; }
	[MonoTODO("Use this")]
	public static int DefaultMaximumResponseHeadersLength { get; }
	public int ReadWriteTimeout { get; }
	public override string Method { get; set; }
	public override bool PreAuthenticate { set; }
	public Version ProtocolVersion { get; set; }
	public override IWebProxy Proxy { get; set; }
	public override Uri RequestUri { get; }
	public bool SendChunked { get; set; }
	public ServicePoint ServicePoint { get; }
	internal ServicePoint ServicePointNoLock { get; }
	public override int Timeout { get; set; }
	public string TransferEncoding { get; }
	public override bool UseDefaultCredentials { get; }
	public bool UnsafeAuthenticatedConnectionSharing { get; }
	internal bool ExpectContinue { get; set; }
	internal Uri AuthUri { get; }
	internal bool ProxyQuery { get; }
	internal ServerCertValidationCallback ServerCertValidationCallback { get; }
	public RemoteCertificateValidationCallback ServerCertificateValidationCallback { get; set; }
	internal bool FinishedReading { set; }
	internal bool Aborted { get; }

	// Methods

	// RVA: 0x25B77C0 Offset: 0x25B61C0 VA: 0x1825B77C0
	private static void .cctor() { }

	// RVA: 0x25B7900 Offset: 0x25B6300 VA: 0x1825B7900
	public void .ctor(Uri uri) { }

	// RVA: 0x25B7870 Offset: 0x25B6270 VA: 0x1825B7870
	internal void .ctor(Uri uri, MobileTlsProvider tlsProvider, MonoTlsSettings settings) { }

	[Obsolete("Serialization is obsoleted for this type.  http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x25B7BB0 Offset: 0x25B65B0 VA: 0x1825B7BB0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x25B7220 Offset: 0x25B5C20 VA: 0x1825B7220
	private void ResetAuthorization() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public Uri get_Address() { }

	// RVA: 0x4D6510 Offset: 0x4D4F10 VA: 0x1804D6510 Slot: 32
	public virtual void set_AllowAutoRedirect(bool value) { }

	// RVA: 0x24CF6C0 Offset: 0x24CE0C0 VA: 0x1824CF6C0 Slot: 33
	public virtual bool get_AllowWriteStreamBuffering() { }

	// RVA: 0x25B81F0 Offset: 0x25B6BF0 VA: 0x1825B81F0 Slot: 34
	public virtual void set_AllowWriteStreamBuffering(bool value) { }

	// RVA: 0x512ED0 Offset: 0x5118D0 VA: 0x180512ED0
	public DecompressionMethods get_AutomaticDecompression() { }

	// RVA: 0x25B8200 Offset: 0x25B6C00 VA: 0x1825B8200
	public void set_AutomaticDecompression(DecompressionMethods value) { }

	// RVA: 0x25B7FB0 Offset: 0x25B69B0 VA: 0x1825B7FB0
	internal bool get_InternalAllowBuffering() { }

	// RVA: 0x25B7FC0 Offset: 0x25B69C0 VA: 0x1825B7FC0
	private bool get_MethodWithBuffer() { }

	// RVA: 0x67E910 Offset: 0x67D310 VA: 0x18067E910
	internal MobileTlsProvider get_TlsProvider() { }

	// RVA: 0x71DB80 Offset: 0x71C580 VA: 0x18071DB80
	internal MonoTlsSettings get_TlsSettings() { }

	// RVA: 0x25B7D90 Offset: 0x25B6790 VA: 0x1825B7D90
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0 Slot: 12
	public override void set_ConnectionGroupName(string value) { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0 Slot: 14
	public override long get_ContentLength() { }

	// RVA: 0x25B8270 Offset: 0x25B6C70 VA: 0x1825B8270 Slot: 15
	public override void set_ContentLength(long value) { }

	// RVA: 0xDA2C90 Offset: 0xDA1690 VA: 0x180DA2C90
	internal void set_InternalContentLength(long value) { }

	[CompilerGenerated]
	// RVA: 0x25B8100 Offset: 0x25B6B00 VA: 0x1825B8100
	internal bool get_ThrowOnError() { }

	[CompilerGenerated]
	// RVA: 0x25B8C30 Offset: 0x25B7630 VA: 0x1825B8C30
	internal void set_ThrowOnError(bool value) { }

	// RVA: 0x5F4EC0 Offset: 0x5F38C0 VA: 0x1805F4EC0 Slot: 35
	public virtual void set_CookieContainer(CookieContainer value) { }

	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400 Slot: 16
	public override ICredentials get_Credentials() { }

	// RVA: 0x6EA770 Offset: 0x6E9170 VA: 0x1806EA770 Slot: 17
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x25B7E00 Offset: 0x25B6800 VA: 0x1825B7E00
	public static int get_DefaultMaximumErrorResponseLength() { }

	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480 Slot: 13
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x25B7EA0 Offset: 0x25B68A0 VA: 0x1825B7EA0
	public string get_Host() { }

	// RVA: 0x25B8350 Offset: 0x25B6D50 VA: 0x1825B8350
	public void set_Host(string value) { }

	// RVA: 0x25B75E0 Offset: 0x25B5FE0 VA: 0x1825B75E0
	private bool TryGetHostUri(string hostName, out Uri hostUri) { }

	// RVA: 0x614460 Offset: 0x612E60 VA: 0x180614460
	public bool get_KeepAlive() { }

	// RVA: 0x614500 Offset: 0x612F00 VA: 0x180614500
	public void set_KeepAlive(bool value) { }

	// RVA: 0x25B85E0 Offset: 0x25B6FE0 VA: 0x1825B85E0
	public void set_MaximumAutomaticRedirections(int value) { }

	// RVA: 0x25B7E50 Offset: 0x25B6850 VA: 0x1825B7E50
	public static int get_DefaultMaximumResponseHeadersLength() { }

	// RVA: 0x858810 Offset: 0x857210 VA: 0x180858810
	public int get_ReadWriteTimeout() { }

	// RVA: 0x4B61A0 Offset: 0x4B4BA0 VA: 0x1804B61A0 Slot: 9
	public override string get_Method() { }

	// RVA: 0x25B8670 Offset: 0x25B7070 VA: 0x1825B8670 Slot: 10
	public override void set_Method(string value) { }

	// RVA: 0x5016F0 Offset: 0x5000F0 VA: 0x1805016F0 Slot: 21
	public override void set_PreAuthenticate(bool value) { }

	// RVA: 0x4B6140 Offset: 0x4B4B40 VA: 0x1804B6140
	public Version get_ProtocolVersion() { }

	// RVA: 0x25B8920 Offset: 0x25B7320 VA: 0x1825B8920
	public void set_ProtocolVersion(Version value) { }

	// RVA: 0x4E8C90 Offset: 0x4E7690 VA: 0x1804E8C90 Slot: 19
	public override IWebProxy get_Proxy() { }

	// RVA: 0x25B8A40 Offset: 0x25B7440 VA: 0x1825B8A40 Slot: 20
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0 Slot: 11
	public override Uri get_RequestUri() { }

	// RVA: 0x510890 Offset: 0x50F290 VA: 0x180510890
	public bool get_SendChunked() { }

	// RVA: 0x25B8AE0 Offset: 0x25B74E0 VA: 0x1825B8AE0
	public void set_SendChunked(bool value) { }

	// RVA: 0x25B80F0 Offset: 0x25B6AF0 VA: 0x1825B80F0
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x4E8CB0 Offset: 0x4E76B0 VA: 0x1804E8CB0
	internal ServicePoint get_ServicePointNoLock() { }

	// RVA: 0x1A3A440 Offset: 0x1A38E40 VA: 0x181A3A440 Slot: 22
	public override int get_Timeout() { }

	// RVA: 0x25B8C40 Offset: 0x25B7640 VA: 0x1825B8C40 Slot: 23
	public override void set_Timeout(int value) { }

	// RVA: 0x25B8110 Offset: 0x25B6B10 VA: 0x1825B8110
	public string get_TransferEncoding() { }

	// RVA: 0x25B8170 Offset: 0x25B6B70 VA: 0x1825B8170 Slot: 18
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x25B8160 Offset: 0x25B6B60 VA: 0x1825B8160
	public bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x523200 Offset: 0x521C00 VA: 0x180523200
	internal bool get_ExpectContinue() { }

	// RVA: 0x25B8340 Offset: 0x25B6D40 VA: 0x1825B8340
	internal void set_ExpectContinue(bool value) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	internal Uri get_AuthUri() { }

	// RVA: 0x25B80A0 Offset: 0x25B6AA0 VA: 0x1825B80A0
	internal bool get_ProxyQuery() { }

	// RVA: 0x618010 Offset: 0x616A10 VA: 0x180618010
	internal ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0x25B80D0 Offset: 0x25B6AD0 VA: 0x1825B80D0
	public RemoteCertificateValidationCallback get_ServerCertificateValidationCallback() { }

	// RVA: 0x25B8B50 Offset: 0x25B7550 VA: 0x1825B8B50
	public void set_ServerCertificateValidationCallback(RemoteCertificateValidationCallback value) { }

	// RVA: 0x25B6220 Offset: 0x25B4C20 VA: 0x1825B6220
	internal ServicePoint GetServicePoint() { }

	// RVA: 0x25B7330 Offset: 0x25B5D30 VA: 0x1825B7330
	private WebOperation SendRequest(bool redirecting, BufferOffsetSize writeBuffer, CancellationToken cancellationToken) { }

	// RVA: 0x25B6810 Offset: 0x25B5210 VA: 0x1825B6810
	private Task<Stream> MyGetRequestStreamAsync(CancellationToken cancellationToken) { }

	// RVA: 0x25B43C0 Offset: 0x25B2DC0 VA: 0x1825B43C0 Slot: 27
	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	// RVA: 0x25B4E50 Offset: 0x25B3850 VA: 0x1825B4E50 Slot: 28
	public override Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	// RVA: 0x25B5DA0 Offset: 0x25B47A0 VA: 0x1825B5DA0 Slot: 29
	public override Task<Stream> GetRequestStreamAsync() { }

	// RVA: -1 Offset: -1
	internal static Task<T> RunWithTimeout<T>(Func<CancellationToken, Task<T>> func, int timeout, Action abort, Func<bool> aborted, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEC6050 Offset: 0xEC4A50 VA: 0x180EC6050
	|-HttpWebRequest.RunWithTimeout<int>
	|
	|-RVA: 0xEC5F20 Offset: 0xEC4920 VA: 0x180EC5F20
	|-HttpWebRequest.RunWithTimeout<__Il2CppFullySharedGenericType>
	*/

	[AsyncStateMachine(typeof(HttpWebRequest.<RunWithTimeoutWorker>d__241<T>))]
	// RVA: -1 Offset: -1
	private static Task<T> RunWithTimeoutWorker<T>(Task<T> workerTask, int timeout, Action abort, Func<bool> aborted, CancellationTokenSource cts) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEC5B00 Offset: 0xEC4500 VA: 0x180EC5B00
	|-HttpWebRequest.RunWithTimeoutWorker<int>
	|
	|-RVA: 0xEC5C50 Offset: 0xEC4650 VA: 0x180EC5C50
	|-HttpWebRequest.RunWithTimeoutWorker<object>
	|
	|-RVA: 0xEC5980 Offset: 0xEC4380 VA: 0x180EC5980
	|-HttpWebRequest.RunWithTimeoutWorker<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private Task<T> RunWithTimeout<T>(Func<CancellationToken, Task<T>> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEC6240 Offset: 0xEC4C40 VA: 0x180EC6240
	|-HttpWebRequest.RunWithTimeout<object>
	|
	|-RVA: 0xEC5DA0 Offset: 0xEC47A0 VA: 0x180EC5DA0
	|-HttpWebRequest.RunWithTimeout<__Il2CppFullySharedGenericType>
	*/

	[AsyncStateMachine(typeof(HttpWebRequest.<MyGetResponseAsync>d__243))]
	// RVA: 0x25B6BF0 Offset: 0x25B55F0 VA: 0x1825B6BF0
	private Task<HttpWebResponse> MyGetResponseAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(HttpWebRequest.<GetResponseFromData>d__244))]
	// RVA: 0x25B5E30 Offset: 0x25B4830 VA: 0x1825B5E30
	private Task<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>> GetResponseFromData(WebResponseStream stream, CancellationToken cancellationToken) { }

	// RVA: 0x25B4FF0 Offset: 0x25B39F0 VA: 0x1825B4FF0
	internal static Exception FlattenException(Exception e) { }

	// RVA: 0x25B6580 Offset: 0x25B4F80 VA: 0x1825B6580
	private WebException GetWebException(Exception e) { }

	// RVA: 0x25B6330 Offset: 0x25B4D30 VA: 0x1825B6330
	private static WebException GetWebException(Exception e, bool aborted) { }

	// RVA: 0x25B4C00 Offset: 0x25B3600 VA: 0x1825B4C00
	internal static WebException CreateRequestAbortedException() { }

	// RVA: 0x25B4470 Offset: 0x25B2E70 VA: 0x1825B4470 Slot: 25
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x25B4F20 Offset: 0x25B3920 VA: 0x1825B4F20 Slot: 26
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x25B5F80 Offset: 0x25B4980 VA: 0x1825B5F80 Slot: 24
	public override WebResponse GetResponse() { }

	// RVA: 0xABD820 Offset: 0xABC220 VA: 0x180ABD820
	internal void set_FinishedReading(bool value) { }

	// RVA: 0x25B7D60 Offset: 0x25B6760 VA: 0x1825B7D60
	internal bool get_Aborted() { }

	// RVA: 0x25B42F0 Offset: 0x25B2CF0 VA: 0x1825B42F0 Slot: 31
	public override void Abort() { }

	// RVA: 0x25B75A0 Offset: 0x25B5FA0 VA: 0x1825B75A0 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x25B5960 Offset: 0x25B4360 VA: 0x1825B5960 Slot: 7
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x25B4B90 Offset: 0x25B3590 VA: 0x1825B4B90
	private void CheckRequestStarted() { }

	// RVA: 0x25B4CA0 Offset: 0x25B36A0 VA: 0x1825B4CA0
	internal void DoContinueDelegate(int statusCode, WebHeaderCollection headers) { }

	// RVA: 0x25B72B0 Offset: 0x25B5CB0 VA: 0x1825B72B0
	private void RewriteRedirectToGet() { }

	// RVA: 0x25B6D00 Offset: 0x25B5700 VA: 0x1825B6D00
	private bool Redirect(HttpStatusCode code, WebResponse response) { }

	// RVA: 0x25B50B0 Offset: 0x25B3AB0 VA: 0x1825B50B0
	private string GetHeaders() { }

	// RVA: 0x25B4CC0 Offset: 0x25B36C0 VA: 0x1825B4CC0
	private void DoPreAuthenticate() { }

	// RVA: 0x25B59A0 Offset: 0x25B43A0 VA: 0x1825B59A0
	internal byte[] GetRequestHeaders() { }

	// RVA: 0x25B6600 Offset: 0x25B5000 VA: 0x1825B6600
	private ValueTuple<WebOperation, bool> HandleNtlmAuth(WebResponseStream stream, HttpWebResponse response, BufferOffsetSize writeBuffer, CancellationToken cancellationToken) { }

	// RVA: 0x25B4640 Offset: 0x25B3040 VA: 0x1825B4640
	private bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0x25B6020 Offset: 0x25B4A20 VA: 0x1825B6020
	private ValueTuple<Task<BufferOffsetSize>, WebException> GetRewriteHandler(HttpWebResponse response, bool redirect) { }

	// RVA: 0x25B4670 Offset: 0x25B3070 VA: 0x1825B4670
	private ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException> CheckFinalStatus(HttpWebResponse response) { }

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private bool <RunWithTimeout>b__242_0<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEC64A0 Offset: 0xEC4EA0 VA: 0x180EC64A0
	|-HttpWebRequest.<RunWithTimeout>b__242_0<object>
	|-HttpWebRequest.<RunWithTimeout>b__242_0<__Il2CppFullySharedGenericType>
	*/

	[AsyncStateMachine(typeof(HttpWebRequest.<<GetRewriteHandler>b__271_0>d))]
	[CompilerGenerated]
	// RVA: 0x25B76B0 Offset: 0x25B60B0 VA: 0x1825B76B0
	private Task<BufferOffsetSize> <GetRewriteHandler>b__271_0() { }

	[EditorBrowsable(1)]
	[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", True)]
	// RVA: 0x25B78D0 Offset: 0x25B62D0 VA: 0x1825B78D0
	public void .ctor() { }
}
