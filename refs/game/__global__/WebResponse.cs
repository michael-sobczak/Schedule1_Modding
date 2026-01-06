internal struct WebResponse // TypeDefIndex: 17993
{
	// Fields
	public readonly string Text; // 0x0
	public readonly bool IsError; // 0x8
	public readonly long HTTPStatusCode; // 0x10

	// Methods

	// RVA: 0x44A9E0 Offset: 0x4493E0 VA: 0x18044A9E0
	public static WebResponse GetResponse(AsyncWebRequestData requestData) { }

	// RVA: 0x44AAC0 Offset: 0x4494C0 VA: 0x18044AAC0
	public void .ctor(string text, bool isError, long httpStatusCode) { }
}
