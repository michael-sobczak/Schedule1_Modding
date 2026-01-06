internal interface IMonoHttpClientHandler : IDisposable // TypeDefIndex: 17694
{
	// Properties
	public abstract SslClientAuthenticationOptions SslOptions { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract SslClientAuthenticationOptions get_SslOptions();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_SslOptions(SslClientAuthenticationOptions value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SetWebRequestTimeout(TimeSpan timeout);
}
