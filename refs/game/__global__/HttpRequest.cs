internal class HttpRequest // TypeDefIndex: 17799
{
	// Fields
	public string Method; // 0x10
	public string Url; // 0x18
	public Dictionary<string, string> Headers; // 0x20
	public byte[] Body; // 0x28
	public HttpOptions Options; // 0x30

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x1CD3000 Offset: 0x1CD1A00 VA: 0x181CD3000
	public void .ctor(string method, string url, Dictionary<string, string> headers, byte[] body) { }

	// RVA: 0x286AD00 Offset: 0x2869700 VA: 0x18286AD00
	public HttpRequest SetMethod(string method) { }

	// RVA: 0x286ACA0 Offset: 0x28696A0 VA: 0x18286ACA0
	public HttpRequest SetUrl(string url) { }

	// RVA: 0x2B9EF70 Offset: 0x2B9D970 VA: 0x182B9EF70
	public HttpRequest SetHeader(string key, string value) { }

	// RVA: 0x2B9F040 Offset: 0x2B9DA40 VA: 0x182B9F040
	public HttpRequest SetHeaders(Dictionary<string, string> headers) { }

	// RVA: 0x2B9EF50 Offset: 0x2B9D950 VA: 0x182B9EF50
	public HttpRequest SetBody(byte[] body) { }

	// RVA: 0x2B9F060 Offset: 0x2B9DA60 VA: 0x182B9F060
	public HttpRequest SetOptions(HttpOptions options) { }

	// RVA: 0x2B9F070 Offset: 0x2B9DA70 VA: 0x182B9F070
	public HttpRequest SetRedirectLimit(int redirectLimit) { }

	// RVA: 0x2B9F080 Offset: 0x2B9DA80 VA: 0x182B9F080
	public HttpRequest SetTimeOutInSeconds(int timeout) { }
}
