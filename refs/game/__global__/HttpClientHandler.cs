public class HttpClientHandler : HttpMessageHandler // TypeDefIndex: 17693
{
	// Fields
	private readonly IMonoHttpClientHandler _delegatingHandler; // 0x10
	private ClientCertificateOption _clientCertificateOptions; // 0x18

	// Properties
	public ClientCertificateOption ClientCertificateOptions { get; set; }
	public X509CertificateCollection ClientCertificates { get; }

	// Methods

	// RVA: 0x2182C80 Offset: 0x2181680 VA: 0x182182C80
	private static IMonoHttpClientHandler CreateDefaultHandler() { }

	// RVA: 0x21832E0 Offset: 0x2181CE0 VA: 0x1821832E0
	public void .ctor() { }

	// RVA: 0x21832A0 Offset: 0x2181CA0 VA: 0x1821832A0
	internal void .ctor(IMonoHttpClientHandler handler) { }

	// RVA: 0x2182E60 Offset: 0x2181860 VA: 0x182182E60 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2183060 Offset: 0x2181A60 VA: 0x182183060
	private void ThrowForModifiedManagedSslOptionsIfStarted() { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public ClientCertificateOption get_ClientCertificateOptions() { }

	// RVA: 0x2183640 Offset: 0x2182040 VA: 0x182183640
	public void set_ClientCertificateOptions(ClientCertificateOption value) { }

	// RVA: 0x21834F0 Offset: 0x2181EF0 VA: 0x1821834F0
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x2182F90 Offset: 0x2181990 VA: 0x182182F90
	internal void SetWebRequestTimeout(TimeSpan timeout) { }

	// RVA: 0x2182EC0 Offset: 0x21818C0 VA: 0x182182EC0 Slot: 6
	protected internal override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

	[CompilerGenerated]
	// RVA: 0x2183140 Offset: 0x2181B40 VA: 0x182183140
	private X509Certificate <set_ClientCertificateOptions>b__23_0(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }
}
