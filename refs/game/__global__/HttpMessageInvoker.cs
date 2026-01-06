public class HttpMessageInvoker : IDisposable // TypeDefIndex: 17709
{
	// Fields
	internal HttpMessageHandler handler; // 0x10
	private readonly bool disposeHandler; // 0x18

	// Methods

	// RVA: 0x2188D40 Offset: 0x2187740 VA: 0x182188D40
	public void .ctor(HttpMessageHandler handler, bool disposeHandler) { }

	// RVA: 0x1EA1F90 Offset: 0x1EA0990 VA: 0x181EA1F90 Slot: 4
	public void Dispose() { }

	// RVA: 0x2188CF0 Offset: 0x21876F0 VA: 0x182188CF0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x21842C0 Offset: 0x2182CC0 VA: 0x1821842C0 Slot: 6
	public virtual Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }
}
