internal class UnityTlsProvider : MobileTlsProvider // TypeDefIndex: 9379
{
	// Properties
	public override string Name { get; }
	public override Guid ID { get; }
	public override bool SupportsSslStream { get; }
	public override bool SupportsMonoExtensions { get; }
	public override bool SupportsConnectionInfo { get; }
	internal override bool SupportsCleanShutdown { get; }
	public override SslProtocols SupportedProtocols { get; }

	// Methods

	// RVA: 0x2025A60 Offset: 0x2024460 VA: 0x182025A60 Slot: 5
	public override string get_Name() { }

	// RVA: 0x2025A00 Offset: 0x2024400 VA: 0x182025A00 Slot: 4
	public override Guid get_ID() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 6
	public override bool get_SupportsSslStream() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 8
	public override bool get_SupportsMonoExtensions() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 7
	public override bool get_SupportsConnectionInfo() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 10
	internal override bool get_SupportsCleanShutdown() { }

	// RVA: 0x201BBF0 Offset: 0x201A5F0 VA: 0x18201BBF0 Slot: 9
	public override SslProtocols get_SupportedProtocols() { }

	// RVA: 0x2024E90 Offset: 0x2023890 VA: 0x182024E90 Slot: 11
	internal override MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	[MonoPInvokeCallback(typeof(UnityTls.unitytls_x509verify_callback))]
	// RVA: 0x2025A90 Offset: 0x2024490 VA: 0x182025A90
	private static UnityTls.unitytls_x509verify_result x509verify_callback(void* userData, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_x509verify_result result, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x2025080 Offset: 0x2023A80 VA: 0x182025080 Slot: 12
	internal override bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref SslPolicyErrors errors, ref int status11) { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }
}
