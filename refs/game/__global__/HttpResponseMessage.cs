public class HttpResponseMessage : IDisposable // TypeDefIndex: 17713
{
	// Fields
	private HttpResponseHeaders headers; // 0x10
	private string reasonPhrase; // 0x18
	private HttpStatusCode statusCode; // 0x20
	private Version version; // 0x28
	private bool disposed; // 0x30
	[CompilerGenerated]
	private HttpContent <Content>k__BackingField; // 0x38
	[CompilerGenerated]
	private HttpRequestMessage <RequestMessage>k__BackingField; // 0x40

	// Properties
	public HttpContent Content { get; set; }
	public HttpResponseHeaders Headers { get; }
	public bool IsSuccessStatusCode { get; }
	public string ReasonPhrase { get; set; }
	public HttpRequestMessage RequestMessage { get; set; }
	public HttpStatusCode StatusCode { get; set; }
	public Version Version { get; }

	// Methods

	// RVA: 0x218AA50 Offset: 0x2189450 VA: 0x18218AA50
	public void .ctor(HttpStatusCode statusCode) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public HttpContent get_Content() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	public void set_Content(HttpContent value) { }

	// RVA: 0x218AAC0 Offset: 0x21894C0 VA: 0x18218AAC0
	public HttpResponseHeaders get_Headers() { }

	// RVA: 0x218AB70 Offset: 0x2189570 VA: 0x18218AB70
	public bool get_IsSuccessStatusCode() { }

	// RVA: 0x218AB90 Offset: 0x2189590 VA: 0x18218AB90
	public string get_ReasonPhrase() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_ReasonPhrase(string value) { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public HttpRequestMessage get_RequestMessage() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	public void set_RequestMessage(HttpRequestMessage value) { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public HttpStatusCode get_StatusCode() { }

	// RVA: 0x218AC10 Offset: 0x2189610 VA: 0x18218AC10
	public void set_StatusCode(HttpStatusCode value) { }

	// RVA: 0x218ABB0 Offset: 0x21895B0 VA: 0x18218ABB0
	public Version get_Version() { }

	// RVA: 0x1EA1F90 Offset: 0x1EA0990 VA: 0x181EA1F90 Slot: 4
	public void Dispose() { }

	// RVA: 0x218A7A0 Offset: 0x21891A0 VA: 0x18218A7A0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x218A7D0 Offset: 0x21891D0 VA: 0x18218A7D0 Slot: 3
	public override string ToString() { }
}
