internal interface IHttpClient : IServiceComponent // TypeDefIndex: 17802
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string GetBaseUrlFor(string serviceId);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract HttpOptions GetDefaultOptionsFor(string serviceId);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract HttpRequest CreateRequestForService(string serviceId, string resourcePath);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IAsyncOperation<ReadOnlyHttpResponse> Send(HttpRequest request);
}
