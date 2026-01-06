public class HttpWebResponse : WebResponse, ISerializable, IDisposable // TypeDefIndex: 10068
{
	// Fields
	private Uri uri; // 0x20
	private WebHeaderCollection webHeaders; // 0x28
	private CookieCollection cookieCollection; // 0x30
	private string method; // 0x38
	private Version version; // 0x40
	private HttpStatusCode statusCode; // 0x48
	private string statusDescription; // 0x50
	private long contentLength; // 0x58
	private string contentType; // 0x60
	private CookieContainer cookie_container; // 0x68
	private bool disposed; // 0x70
	private Stream stream; // 0x78

	// Properties
	public override WebHeaderCollection Headers { get; }
	public override Uri ResponseUri { get; }
	public virtual HttpStatusCode StatusCode { get; }
	public virtual string StatusDescription { get; }

	// Methods

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }

	// RVA: 0x25B9150 Offset: 0x25B7B50 VA: 0x1825B9150
	internal void .ctor(Uri uri, string method, HttpStatusCode status, WebHeaderCollection headers) { }

	// RVA: 0x25B9640 Offset: 0x25B8040 VA: 0x1825B9640
	internal void .ctor(Uri uri, string method, WebResponseStream stream, CookieContainer container) { }

	[Obsolete("Serialization is obsoleted for this type", False)]
	// RVA: 0x25B9240 Offset: 0x25B7C40 VA: 0x1825B9240
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0 Slot: 14
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x25B9900 Offset: 0x25B8300 VA: 0x1825B9900 Slot: 13
	public override Uri get_ResponseUri() { }

	// RVA: 0x4B61C0 Offset: 0x4B4BC0 VA: 0x1804B61C0 Slot: 15
	public virtual HttpStatusCode get_StatusCode() { }

	// RVA: 0x25B9920 Offset: 0x25B8320 VA: 0x1825B9920 Slot: 16
	public virtual string get_StatusDescription() { }

	// RVA: 0x25B9090 Offset: 0x25B7A90 VA: 0x1825B9090 Slot: 12
	public override Stream GetResponseStream() { }

	// RVA: 0x25B2710 Offset: 0x25B1110 VA: 0x1825B2710 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x25B8F20 Offset: 0x25B7920 VA: 0x1825B8F20 Slot: 8
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x25B8D40 Offset: 0x25B7740 VA: 0x1825B8D40 Slot: 9
	public override void Close() { }

	// RVA: 0x25B9130 Offset: 0x25B7B30 VA: 0x1825B9130 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x25B8D80 Offset: 0x25B7780 VA: 0x1825B8D80 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x25B8CB0 Offset: 0x25B76B0 VA: 0x1825B8CB0
	private void CheckDisposed() { }

	// RVA: 0x25B8D90 Offset: 0x25B7790 VA: 0x1825B8D90
	private void FillCookies() { }
}
