public sealed class LocalCertificateSelectionCallback : MulticastDelegate // TypeDefIndex: 10229
{
	// Methods

	// RVA: 0x25DB4B0 Offset: 0x25D9EB0 VA: 0x1825DB4B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x157FF20 Offset: 0x157E920 VA: 0x18157FF20 Slot: 13
	public virtual X509Certificate Invoke(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }
}
