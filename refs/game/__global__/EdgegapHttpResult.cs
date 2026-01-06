public class EdgegapHttpResult // TypeDefIndex: 16910
{
	// Fields
	[CompilerGenerated]
	private readonly HttpStatusCode <StatusCode>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <Json>k__BackingField; // 0x18
	public HttpMethod HttpMethod; // 0x20
	[CompilerGenerated]
	private readonly string <ReasonPhrase>k__BackingField; // 0x28
	[CompilerGenerated]
	private EdgegapErrorResult <Error>k__BackingField; // 0x30

	// Properties
	public HttpStatusCode StatusCode { get; }
	public string Json { get; }
	public string ReasonPhrase { get; }
	public bool HasErr { get; }
	public EdgegapErrorResult Error { get; set; }
	public bool IsResultCode200 { get; }
	public bool IsResultCode204 { get; }
	public bool IsResultCode403 { get; }
	public bool IsResultCode409 { get; }
	public bool IsResultCode400 { get; }
	public bool IsResultCode410 { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public HttpStatusCode get_StatusCode() { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Json() { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_ReasonPhrase() { }

	// RVA: 0x99F540 Offset: 0x99DF40 VA: 0x18099F540
	public bool get_HasErr() { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public EdgegapErrorResult get_Error() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_Error(EdgegapErrorResult value) { }

	// RVA: 0xCD82A0 Offset: 0xCD6CA0 VA: 0x180CD82A0
	public bool get_IsResultCode200() { }

	// RVA: 0xCD82B0 Offset: 0xCD6CB0 VA: 0x180CD82B0
	public bool get_IsResultCode204() { }

	// RVA: 0xCD82D0 Offset: 0xCD6CD0 VA: 0x180CD82D0
	public bool get_IsResultCode403() { }

	// RVA: 0xCD82E0 Offset: 0xCD6CE0 VA: 0x180CD82E0
	public bool get_IsResultCode409() { }

	// RVA: 0xCD82C0 Offset: 0xCD6CC0 VA: 0x180CD82C0
	public bool get_IsResultCode400() { }

	// RVA: 0xCD82F0 Offset: 0xCD6CF0 VA: 0x180CD82F0
	public bool get_IsResultCode410() { }

	// RVA: 0xCD8100 Offset: 0xCD6B00 VA: 0x180CD8100
	public void .ctor(HttpResponseMessage httpResponse) { }
}
