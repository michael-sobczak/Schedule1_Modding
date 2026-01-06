public abstract class HttpMessageHandler : IDisposable // TypeDefIndex: 17708
{
	// Methods

	// RVA: 0x1EA1F90 Offset: 0x1EA0990 VA: 0x181EA1F90 Slot: 4
	public void Dispose() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 6
	protected internal abstract Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
