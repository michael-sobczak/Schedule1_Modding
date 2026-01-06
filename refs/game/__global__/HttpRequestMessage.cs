public class HttpRequestMessage : IDisposable // TypeDefIndex: 17712
{
	// Fields
	private HttpRequestHeaders headers; // 0x10
	private HttpMethod method; // 0x18
	private Version version; // 0x20
	private Uri uri; // 0x28
	private bool is_used; // 0x30
	private bool disposed; // 0x31
	[CompilerGenerated]
	private HttpContent <Content>k__BackingField; // 0x38

	// Properties
	public HttpContent Content { get; set; }
	public HttpRequestHeaders Headers { get; }
	public HttpMethod Method { get; set; }
	public Uri RequestUri { get; set; }
	public Version Version { get; }

	// Methods

	// RVA: 0x218A220 Offset: 0x2188C20 VA: 0x18218A220
	public void .ctor(HttpMethod method, string requestUri) { }

	// RVA: 0x218A2B0 Offset: 0x2188CB0 VA: 0x18218A2B0
	public void .ctor(HttpMethod method, Uri requestUri) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public HttpContent get_Content() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	public void set_Content(HttpContent value) { }

	// RVA: 0x218A380 Offset: 0x2188D80 VA: 0x18218A380
	public HttpRequestHeaders get_Headers() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public HttpMethod get_Method() { }

	// RVA: 0x218A490 Offset: 0x2188E90 VA: 0x18218A490
	public void set_Method(HttpMethod value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public Uri get_RequestUri() { }

	// RVA: 0x218A540 Offset: 0x2188F40 VA: 0x18218A540
	public void set_RequestUri(Uri value) { }

	// RVA: 0x2189DF0 Offset: 0x21887F0 VA: 0x182189DF0
	private static bool IsAllowedAbsoluteUri(Uri uri) { }

	// RVA: 0x218A430 Offset: 0x2188E30 VA: 0x18218A430
	public Version get_Version() { }

	// RVA: 0x1EA1F90 Offset: 0x1EA0990 VA: 0x181EA1F90 Slot: 4
	public void Dispose() { }

	// RVA: 0x2189DC0 Offset: 0x21887C0 VA: 0x182189DC0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2189F50 Offset: 0x2188950 VA: 0x182189F50
	internal bool SetIsUsed() { }

	// RVA: 0x2189F60 Offset: 0x2188960 VA: 0x182189F60 Slot: 3
	public override string ToString() { }
}
