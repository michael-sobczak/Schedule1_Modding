public class FtpWebResponse : WebResponse, IDisposable // TypeDefIndex: 9957
{
	// Fields
	internal Stream _responseStream; // 0x20
	private long _contentLength; // 0x28
	private Uri _responseUri; // 0x30
	private FtpStatusCode _statusCode; // 0x38
	private string _statusLine; // 0x40
	private WebHeaderCollection _ftpRequestHeaders; // 0x48
	private DateTime _lastModified; // 0x50
	private string _bannerMessage; // 0x58
	private string _welcomeMessage; // 0x60
	private string _exitMessage; // 0x68

	// Properties
	public override WebHeaderCollection Headers { get; }
	public override Uri ResponseUri { get; }
	public FtpStatusCode StatusCode { get; }

	// Methods

	// RVA: 0x26C3950 Offset: 0x26C2350 VA: 0x1826C3950
	internal void .ctor(Stream responseStream, long contentLength, Uri responseUri, FtpStatusCode statusCode, string statusLine, DateTime lastModified, string bannerMessage, string welcomeMessage, string exitMessage) { }

	// RVA: 0x26C3910 Offset: 0x26C2310 VA: 0x1826C3910
	internal void UpdateStatus(FtpStatusCode statusCode, string statusLine, string exitMessage) { }

	// RVA: 0x26C3760 Offset: 0x26C2160 VA: 0x1826C3760 Slot: 12
	public override Stream GetResponseStream() { }

	// RVA: 0x26C3870 Offset: 0x26C2270 VA: 0x1826C3870
	internal void SetResponseStream(Stream stream) { }

	// RVA: 0x26C3670 Offset: 0x26C2070 VA: 0x1826C3670 Slot: 9
	public override void Close() { }

	// RVA: 0x26C3AB0 Offset: 0x26C24B0 VA: 0x1826C3AB0 Slot: 14
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0 Slot: 13
	public override Uri get_ResponseUri() { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	public FtpStatusCode get_StatusCode() { }
}
