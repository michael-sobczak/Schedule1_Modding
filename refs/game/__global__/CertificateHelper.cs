internal static class CertificateHelper // TypeDefIndex: 10224
{
	// Methods

	// RVA: 0x25DA500 Offset: 0x25D8F00 VA: 0x1825DA500
	internal static X509Certificate2 GetEligibleClientCertificate(X509CertificateCollection candidateCerts) { }

	// RVA: 0x25DA460 Offset: 0x25D8E60 VA: 0x1825DA460
	internal static X509Certificate2 GetEligibleClientCertificate(X509Certificate2Collection candidateCerts) { }

	// RVA: 0x25DA7B0 Offset: 0x25D91B0 VA: 0x1825DA7B0
	private static bool IsValidClientCertificate(X509Certificate2 cert) { }

	// RVA: 0x25DA8A0 Offset: 0x25D92A0 VA: 0x1825DA8A0
	private static bool IsValidForClientAuthenticationEKU(X509EnhancedKeyUsageExtension eku) { }

	// RVA: 0x25DA940 Offset: 0x25D9340 VA: 0x1825DA940
	private static bool IsValidForDigitalSignatureUsage(X509KeyUsageExtension ku) { }

	// RVA: 0x25DA610 Offset: 0x25D9010 VA: 0x1825DA610
	internal static X509Certificate2 GetEligibleClientCertificate() { }
}
