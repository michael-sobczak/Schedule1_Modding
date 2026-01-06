internal sealed class LocalCertSelectionCallback : MulticastDelegate // TypeDefIndex: 10232
{
	// Methods

	// RVA: 0x1A7A9B0 Offset: 0x1A793B0 VA: 0x181A7A9B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xC84DF0 Offset: 0xC837F0 VA: 0x180C84DF0 Slot: 13
	public virtual X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }
}
