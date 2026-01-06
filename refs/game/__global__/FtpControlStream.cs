internal class FtpControlStream : CommandStream // TypeDefIndex: 9946
{
	// Fields
	private Socket _dataSocket; // 0x88
	private IPEndPoint _passiveEndPoint; // 0x90
	private TlsStream _tlsStream; // 0x98
	private StringBuilder _bannerMessage; // 0xA0
	private StringBuilder _welcomeMessage; // 0xA8
	private StringBuilder _exitMessage; // 0xB0
	private WeakReference _credentials; // 0xB8
	private string _currentTypeSetting; // 0xC0
	private long _contentLength; // 0xC8
	private DateTime _lastModified; // 0xD0
	private bool _dataHandshakeStarted; // 0xD8
	private string _loginDirectory; // 0xE0
	private string _establishedServerDirectory; // 0xE8
	private string _requestedServerDirectory; // 0xF0
	private Uri _responseUri; // 0xF8
	private FtpLoginState _loginState; // 0x100
	internal FtpStatusCode StatusCode; // 0x104
	internal string StatusLine; // 0x108
	private static readonly AsyncCallback s_acceptCallbackDelegate; // 0x0
	private static readonly AsyncCallback s_connectCallbackDelegate; // 0x8
	private static readonly AsyncCallback s_SSLHandshakeCallback; // 0x10

	// Properties
	internal NetworkCredential Credentials { get; set; }
	internal long ContentLength { get; }
	internal DateTime LastModified { get; }
	internal Uri ResponseUri { get; }
	internal string BannerMessage { get; }
	internal string WelcomeMessage { get; }
	internal string ExitMessage { get; }

	// Methods

	// RVA: 0x26A4D20 Offset: 0x26A3720 VA: 0x1826A4D20
	internal NetworkCredential get_Credentials() { }

	// RVA: 0x26A4E40 Offset: 0x26A3840 VA: 0x1826A4E40
	internal void set_Credentials(NetworkCredential value) { }

	// RVA: 0x26A4BD0 Offset: 0x26A35D0 VA: 0x1826A4BD0
	internal void .ctor(TcpClient client) { }

	// RVA: 0x269FC30 Offset: 0x269E630 VA: 0x18269FC30
	internal void AbortConnect() { }

	// RVA: 0x269FC50 Offset: 0x269E650 VA: 0x18269FC50
	private static void AcceptCallback(IAsyncResult asyncResult) { }

	// RVA: 0x26A1710 Offset: 0x26A0110 VA: 0x1826A1710
	private static void ConnectCallback(IAsyncResult asyncResult) { }

	// RVA: 0x26A44D0 Offset: 0x26A2ED0 VA: 0x1826A44D0
	private static void SSLHandshakeCallback(IAsyncResult asyncResult) { }

	// RVA: 0x26A4180 Offset: 0x26A2B80 VA: 0x1826A4180
	private CommandStream.PipelineInstruction QueueOrCreateFtpDataStream(ref Stream stream) { }

	// RVA: 0x26A1610 Offset: 0x26A0010 VA: 0x1826A1610 Slot: 41
	protected override void ClearState() { }

	// RVA: 0x26A2D20 Offset: 0x26A1720 VA: 0x1826A2D20 Slot: 43
	protected override CommandStream.PipelineInstruction PipelineCallback(CommandStream.PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream) { }

	// RVA: 0x269FF00 Offset: 0x269E900 VA: 0x18269FF00 Slot: 42
	protected override CommandStream.PipelineEntry[] BuildCommandsList(WebRequest req) { }

	// RVA: 0x26A39E0 Offset: 0x26A23E0 VA: 0x1826A39E0
	private CommandStream.PipelineInstruction QueueOrCreateDataConection(CommandStream.PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream, out bool isSocketReady) { }

	// RVA: 0x26A2410 Offset: 0x26A0E10 VA: 0x1826A2410
	private static void GetPathInfo(FtpControlStream.GetPathOption pathOption, Uri uri, out string path, out string directory, out string filename) { }

	// RVA: 0x26A1C00 Offset: 0x26A0600 VA: 0x1826A1C00
	private string FormatAddress(IPAddress address, int Port) { }

	// RVA: 0x26A1AE0 Offset: 0x26A04E0 VA: 0x1826A1AE0
	private string FormatAddressV6(IPAddress address, int port) { }

	// RVA: 0x4B6170 Offset: 0x4B4B70 VA: 0x1804B6170
	internal long get_ContentLength() { }

	// RVA: 0x4B6180 Offset: 0x4B4B80 VA: 0x1804B6180
	internal DateTime get_LastModified() { }

	// RVA: 0x605170 Offset: 0x603B70 VA: 0x180605170
	internal Uri get_ResponseUri() { }

	// RVA: 0x26A4CF0 Offset: 0x26A36F0 VA: 0x1826A4CF0
	internal string get_BannerMessage() { }

	// RVA: 0x26A4E10 Offset: 0x26A3810 VA: 0x1826A4E10
	internal string get_WelcomeMessage() { }

	// RVA: 0x26A4DE0 Offset: 0x26A37E0 VA: 0x1826A4DE0
	internal string get_ExitMessage() { }

	// RVA: 0x26A1F30 Offset: 0x26A0930 VA: 0x1826A1F30
	private long GetContentLengthFrom213Response(string responseString) { }

	// RVA: 0x26A2060 Offset: 0x26A0A60 VA: 0x1826A2060
	private DateTime GetLastModifiedFrom213Response(string str) { }

	// RVA: 0x26A46E0 Offset: 0x26A30E0 VA: 0x1826A46E0
	private void TryUpdateResponseUri(string str, FtpWebRequest request) { }

	// RVA: 0x26A45F0 Offset: 0x26A2FF0 VA: 0x1826A45F0
	private void TryUpdateContentLength(string str) { }

	// RVA: 0x26A2370 Offset: 0x26A0D70 VA: 0x1826A2370
	private string GetLoginDirectory(string str) { }

	// RVA: 0x26A28B0 Offset: 0x26A12B0 VA: 0x1826A28B0
	private int GetPortV4(string responseString) { }

	// RVA: 0x26A2A90 Offset: 0x26A1490 VA: 0x1826A2A90
	private int GetPortV6(string responseString) { }

	// RVA: 0x26A18B0 Offset: 0x26A02B0 VA: 0x1826A18B0
	private void CreateFtpListenerSocket(FtpWebRequest request) { }

	// RVA: 0x26A25F0 Offset: 0x26A0FF0 VA: 0x1826A25F0
	private string GetPortCommandLine(FtpWebRequest request) { }

	// RVA: 0x26A1E20 Offset: 0x26A0820 VA: 0x1826A1E20
	private string FormatFtpCommand(string command, string parameter) { }

	// RVA: 0x26A1820 Offset: 0x26A0220 VA: 0x1826A1820
	protected Socket CreateFtpDataSocket(FtpWebRequest request, Socket templateSocket) { }

	// RVA: 0x26A1210 Offset: 0x269FC10 VA: 0x1826A1210 Slot: 44
	protected override bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength) { }

	// RVA: 0x26A2C80 Offset: 0x26A1680 VA: 0x1826A2C80
	private TriState IsFtpDataStreamWriteable() { }

	// RVA: 0x26A4A90 Offset: 0x26A3490 VA: 0x1826A4A90
	private static void .cctor() { }
}
