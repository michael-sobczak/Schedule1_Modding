public sealed class HttpContentHeaders : HttpHeaders // TypeDefIndex: 17730
{
	// Fields
	private readonly HttpContent content; // 0x20

	// Properties
	public Nullable<long> ContentLength { get; }
	public MediaTypeHeaderValue ContentType { get; set; }

	// Methods

	// RVA: 0x2184670 Offset: 0x2183070 VA: 0x182184670
	internal void .ctor(HttpContent content) { }

	// RVA: 0x21846E0 Offset: 0x21830E0 VA: 0x1821846E0
	public Nullable<long> get_ContentLength() { }

	// RVA: 0x21848A0 Offset: 0x21832A0 VA: 0x1821848A0
	public MediaTypeHeaderValue get_ContentType() { }

	// RVA: 0x21848F0 Offset: 0x21832F0 VA: 0x1821848F0
	public void set_ContentType(MediaTypeHeaderValue value) { }
}
