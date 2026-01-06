internal class HttpResponse // TypeDefIndex: 17801
{
	// Fields
	public ReadOnlyHttpRequest Request; // 0x10
	public Dictionary<string, string> Headers; // 0x18
	public byte[] Data; // 0x20
	public long StatusCode; // 0x28
	public string ErrorMessage; // 0x30
	public bool IsHttpError; // 0x38
	public bool IsNetworkError; // 0x39

	// Methods

	// RVA: 0x2B9F170 Offset: 0x2B9DB70 VA: 0x182B9F170
	public HttpResponse SetRequest(HttpRequest request) { }

	// RVA: 0x2B9F140 Offset: 0x2B9DB40 VA: 0x182B9F140
	public HttpResponse SetRequest(ReadOnlyHttpRequest request) { }

	// RVA: 0x2B9F0B0 Offset: 0x2B9DAB0 VA: 0x182B9F0B0
	public HttpResponse SetHeader(string key, string value) { }

	// RVA: 0x286ACA0 Offset: 0x28696A0 VA: 0x18286ACA0
	public HttpResponse SetHeaders(Dictionary<string, string> headers) { }

	// RVA: 0x2B9F040 Offset: 0x2B9DA40 VA: 0x182B9F040
	public HttpResponse SetData(byte[] data) { }

	// RVA: 0x2B9F1B0 Offset: 0x2B9DBB0 VA: 0x182B9F1B0
	public HttpResponse SetStatusCode(long statusCode) { }

	// RVA: 0x2B9F090 Offset: 0x2B9DA90 VA: 0x182B9F090
	public HttpResponse SetErrorMessage(string errorMessage) { }

	// RVA: 0x2B9F120 Offset: 0x2B9DB20 VA: 0x182B9F120
	public HttpResponse SetIsHttpError(bool isHttpError) { }

	// RVA: 0x2B9F130 Offset: 0x2B9DB30 VA: 0x182B9F130
	public HttpResponse SetIsNetworkError(bool isNetworkError) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
