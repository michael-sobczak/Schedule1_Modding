internal static class X509Helper // TypeDefIndex: 4257
{
	// Properties
	private static ISystemCertificateProvider CertificateProvider { get; }

	// Methods

	// RVA: 0x1B232E0 Offset: 0x1B21CE0 VA: 0x181B232E0
	private static ISystemCertificateProvider get_CertificateProvider() { }

	// RVA: 0x1B23180 Offset: 0x1B21B80 VA: 0x181B23180
	public static X509CertificateImpl InitFromCertificate(X509Certificate cert) { }

	// RVA: 0x1B23250 Offset: 0x1B21C50 VA: 0x181B23250
	public static X509CertificateImpl InitFromCertificate(X509CertificateImpl impl) { }

	// RVA: 0x1B23270 Offset: 0x1B21C70 VA: 0x181B23270
	public static bool IsValid(X509CertificateImpl impl) { }

	// RVA: 0x1B23290 Offset: 0x1B21C90 VA: 0x181B23290
	internal static void ThrowIfContextInvalid(X509CertificateImpl impl) { }

	// RVA: 0x1B22F40 Offset: 0x1B21940 VA: 0x181B22F40
	internal static Exception GetInvalidContextException() { }

	// RVA: 0x1B230C0 Offset: 0x1B21AC0 VA: 0x181B230C0
	public static X509CertificateImpl Import(byte[] rawData) { }

	// RVA: 0x1B22FB0 Offset: 0x1B219B0 VA: 0x181B22FB0
	public static X509CertificateImpl Import(byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }
}
