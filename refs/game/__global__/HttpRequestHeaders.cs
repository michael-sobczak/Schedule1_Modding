public sealed class HttpRequestHeaders : HttpHeaders // TypeDefIndex: 17737
{
	// Fields
	private Nullable<bool> expectContinue; // 0x20

	// Properties
	public HttpHeaderValueCollection<MediaTypeWithQualityHeaderValue> Accept { get; }
	public AuthenticationHeaderValue Authorization { set; }
	public HttpHeaderValueCollection<string> Connection { get; }
	public Nullable<bool> ConnectionClose { get; }
	public Nullable<bool> ExpectContinue { get; }
	public string Host { get; }
	public HttpHeaderValueCollection<TransferCodingHeaderValue> TransferEncoding { get; }
	public Nullable<bool> TransferEncodingChunked { get; }

	// Methods

	// RVA: 0x2189630 Offset: 0x2188030 VA: 0x182189630
	internal void .ctor() { }

	// RVA: 0x2189680 Offset: 0x2188080 VA: 0x182189680
	public HttpHeaderValueCollection<MediaTypeWithQualityHeaderValue> get_Accept() { }

	// RVA: 0x2189D50 Offset: 0x2188750 VA: 0x182189D50
	public void set_Authorization(AuthenticationHeaderValue value) { }

	// RVA: 0x21898C0 Offset: 0x21882C0 VA: 0x1821898C0
	public HttpHeaderValueCollection<string> get_Connection() { }

	// RVA: 0x21896D0 Offset: 0x21880D0 VA: 0x1821896D0
	public Nullable<bool> get_ConnectionClose() { }

	// RVA: 0x2189910 Offset: 0x2188310 VA: 0x182189910
	public Nullable<bool> get_ExpectContinue() { }

	// RVA: 0x2189AE0 Offset: 0x21884E0 VA: 0x182189AE0
	public string get_Host() { }

	// RVA: 0x2189D00 Offset: 0x2188700 VA: 0x182189D00
	public HttpHeaderValueCollection<TransferCodingHeaderValue> get_TransferEncoding() { }

	// RVA: 0x2189B30 Offset: 0x2188530 VA: 0x182189B30
	public Nullable<bool> get_TransferEncodingChunked() { }

	// RVA: 0x2189420 Offset: 0x2187E20 VA: 0x182189420
	internal void AddHeaders(HttpRequestHeaders headers) { }
}
