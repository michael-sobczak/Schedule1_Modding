internal abstract class MobileTlsProvider : MonoTlsProvider // TypeDefIndex: 9405
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings);

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref SslPolicyErrors errors, ref int status11);

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	protected void .ctor() { }
}
