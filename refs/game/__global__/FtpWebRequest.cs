public sealed class FtpWebRequest : WebRequest // TypeDefIndex: 9954
{
	// Fields
	private object _syncObject; // 0x38
	private ICredentials _authInfo; // 0x40
	private readonly Uri _uri; // 0x48
	private FtpMethodInfo _methodInfo; // 0x50
	private string _renameTo; // 0x58
	private bool _getRequestStreamStarted; // 0x60
	private bool _getResponseStarted; // 0x61
	private DateTime _startTime; // 0x68
	private int _timeout; // 0x70
	private int _remainingTimeout; // 0x74
	private long _contentLength; // 0x78
	private long _contentOffset; // 0x80
	private X509CertificateCollection _clientCertificates; // 0x88
	private bool _passive; // 0x90
	private bool _binary; // 0x91
	private string _connectionGroupName; // 0x98
	private bool _async; // 0xA0
	private bool _aborted; // 0xA1
	private bool _timedOut; // 0xA2
	private Exception _exception; // 0xA8
	private TimerThread.Queue _timerQueue; // 0xB0
	private TimerThread.Callback _timerCallback; // 0xB8
	private bool _enableSsl; // 0xC0
	private FtpControlStream _connection; // 0xC8
	private Stream _stream; // 0xD0
	private FtpWebRequest.RequestStage _requestStage; // 0xD8
	private bool _onceFailed; // 0xDC
	private WebHeaderCollection _ftpRequestHeaders; // 0xE0
	private FtpWebResponse _ftpWebResponse; // 0xE8
	private int _readWriteTimeout; // 0xF0
	private ContextAwareResult _writeAsyncResult; // 0xF8
	private LazyAsyncResult _readAsyncResult; // 0x100
	private LazyAsyncResult _requestCompleteAsyncResult; // 0x108
	private static readonly NetworkCredential s_defaultFtpNetworkCredential; // 0x0
	private static readonly TimerThread.Queue s_DefaultTimerQueue; // 0x8

	// Properties
	internal FtpMethodInfo MethodInfo { get; }
	public override string Method { get; set; }
	public string RenameTo { get; }
	public override ICredentials Credentials { get; set; }
	public override Uri RequestUri { get; }
	public override int Timeout { get; set; }
	internal int RemainingTimeout { get; }
	public int ReadWriteTimeout { get; }
	public long ContentOffset { get; }
	public override long ContentLength { get; set; }
	public override IWebProxy Proxy { get; set; }
	public override string ConnectionGroupName { set; }
	internal bool Aborted { get; }
	private TimerThread.Queue TimerQueue { get; }
	public override RequestCachePolicy CachePolicy { set; }
	public bool UseBinary { get; }
	public bool UsePassive { get; }
	public X509CertificateCollection ClientCertificates { get; }
	public bool EnableSsl { get; }
	public override WebHeaderCollection Headers { get; }
	public override bool UseDefaultCredentials { get; }
	public override bool PreAuthenticate { set; }
	private bool InUse { get; }

	// Methods

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	internal FtpMethodInfo get_MethodInfo() { }

	// RVA: 0x26C3000 Offset: 0x26C1A00 VA: 0x1826C3000 Slot: 9
	public override string get_Method() { }

	// RVA: 0x26C3340 Offset: 0x26C1D40 VA: 0x1826C3340 Slot: 10
	public override void set_Method(string value) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public string get_RenameTo() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0 Slot: 16
	public override ICredentials get_Credentials() { }

	// RVA: 0x26C31C0 Offset: 0x26C1BC0 VA: 0x1826C31C0 Slot: 17
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80 Slot: 11
	public override Uri get_RequestUri() { }

	// RVA: 0x501290 Offset: 0x4FFC90 VA: 0x180501290 Slot: 22
	public override int get_Timeout() { }

	// RVA: 0x26C3580 Offset: 0x26C1F80 VA: 0x1826C3580 Slot: 23
	public override void set_Timeout(int value) { }

	// RVA: 0xA9F7E0 Offset: 0xA9E1E0 VA: 0x180A9F7E0
	internal int get_RemainingTimeout() { }

	// RVA: 0x1A3A440 Offset: 0x1A38E40 VA: 0x181A3A440
	public int get_ReadWriteTimeout() { }

	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400
	public long get_ContentOffset() { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210 Slot: 14
	public override long get_ContentLength() { }

	// RVA: 0xBBA840 Offset: 0xBB9240 VA: 0x180BBA840 Slot: 15
	public override void set_ContentLength(long value) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 19
	public override IWebProxy get_Proxy() { }

	// RVA: 0x26C3510 Offset: 0x26C1F10 VA: 0x1826C3510 Slot: 20
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x26C3140 Offset: 0x26C1B40 VA: 0x1826C3140 Slot: 12
	public override void set_ConnectionGroupName(string value) { }

	// RVA: 0xC21B60 Offset: 0xC20560 VA: 0x180C21B60
	internal bool get_Aborted() { }

	// RVA: 0x26C2850 Offset: 0x26C1250 VA: 0x1826C2850
	internal void .ctor(Uri uri) { }

	// RVA: 0x26C0C40 Offset: 0x26BF640 VA: 0x1826C0C40 Slot: 24
	public override WebResponse GetResponse() { }

	// RVA: 0x26BF270 Offset: 0x26BDC70 VA: 0x1826BF270 Slot: 25
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x26BFE50 Offset: 0x26BE850 VA: 0x1826BFE50 Slot: 26
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x26BEDF0 Offset: 0x26BD7F0 VA: 0x1826BEDF0 Slot: 27
	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	// RVA: 0x26BFAF0 Offset: 0x26BE4F0 VA: 0x1826BFAF0 Slot: 28
	public override Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	// RVA: 0x26C1750 Offset: 0x26C0150 VA: 0x1826C1750
	private void SubmitRequest(bool isAsync) { }

	// RVA: 0x26C25A0 Offset: 0x26C0FA0 VA: 0x1826C25A0
	private Exception TranslateConnectException(Exception e) { }

	[AsyncStateMachine(typeof(FtpWebRequest.<CreateConnectionAsync>d__86))]
	// RVA: 0x26BF870 Offset: 0x26BE270 VA: 0x1826BF870
	private void CreateConnectionAsync() { }

	// RVA: 0x26BF930 Offset: 0x26BE330 VA: 0x1826BF930
	private FtpControlStream CreateConnection() { }

	// RVA: 0x26C2060 Offset: 0x26C0A60 VA: 0x1826C2060
	private Stream TimedSubmitRequestHelper(bool isAsync) { }

	// RVA: 0x26C24A0 Offset: 0x26C0EA0 VA: 0x1826C24A0
	private void TimerCallback(TimerThread.Timer timer, int timeNoticed, object context) { }

	// RVA: 0x26C3020 Offset: 0x26C1A20 VA: 0x1826C3020
	private TimerThread.Queue get_TimerQueue() { }

	// RVA: 0x26BEB40 Offset: 0x26BD540 VA: 0x1826BEB40
	private bool AttemptedRecovery(Exception e) { }

	// RVA: 0x26C1360 Offset: 0x26BFD60 VA: 0x1826C1360
	private void SetException(Exception exception) { }

	// RVA: 0x26BF850 Offset: 0x26BE250 VA: 0x1826BF850
	private void CheckError() { }

	// RVA: 0x26C1340 Offset: 0x26BFD40 VA: 0x1826C1340
	internal void RequestCallback(object obj) { }

	// RVA: 0x26C1CD0 Offset: 0x26C06D0 VA: 0x1826C1CD0
	private void SyncRequestCallback(object obj) { }

	// RVA: 0x26BE110 Offset: 0x26BCB10 VA: 0x1826BE110
	private void AsyncRequestCallback(object obj) { }

	// RVA: 0x26C0780 Offset: 0x26BF180 VA: 0x1826C0780
	private FtpWebRequest.RequestStage FinishRequestStage(FtpWebRequest.RequestStage stage) { }

	// RVA: 0x26BDD80 Offset: 0x26BC780 VA: 0x1826BDD80 Slot: 31
	public override void Abort() { }

	// RVA: 0x26C30D0 Offset: 0x26C1AD0 VA: 0x1826C30D0 Slot: 8
	public override void set_CachePolicy(RequestCachePolicy value) { }

	// RVA: 0xC3F680 Offset: 0xC3E080 VA: 0x180C3F680
	public bool get_UseBinary() { }

	// RVA: 0x979B00 Offset: 0x978500 VA: 0x180979B00
	public bool get_UsePassive() { }

	// RVA: 0x26C2E00 Offset: 0x26C1800 VA: 0x1826C2E00
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x4E8B60 Offset: 0x4E7560 VA: 0x1804E8B60
	public bool get_EnableSsl() { }

	// RVA: 0x26C2F20 Offset: 0x26C1920 VA: 0x1826C2F20 Slot: 13
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x26C30A0 Offset: 0x26C1AA0 VA: 0x1826C30A0 Slot: 18
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x26C34E0 Offset: 0x26C1EE0 VA: 0x1826C34E0 Slot: 21
	public override void set_PreAuthenticate(bool value) { }

	// RVA: 0x26C2FE0 Offset: 0x26C19E0 VA: 0x1826C2FE0
	private bool get_InUse() { }

	// RVA: 0x26C0130 Offset: 0x26BEB30 VA: 0x1826C0130
	private void EnsureFtpWebResponse(Exception exception) { }

	// RVA: 0x26BFA40 Offset: 0x26BE440 VA: 0x1826BFA40
	internal void DataStreamClosed(CloseExState closeState) { }

	// RVA: 0x26C2680 Offset: 0x26C1080 VA: 0x1826C2680
	private static void .cctor() { }
}
