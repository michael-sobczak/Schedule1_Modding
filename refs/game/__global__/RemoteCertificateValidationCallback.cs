public sealed class RemoteCertificateValidationCallback : MulticastDelegate // TypeDefIndex: 10230
{
	// Methods

	// RVA: 0x25E18C0 Offset: 0x25E02C0 VA: 0x1825E18C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xC84DF0 Offset: 0xC837F0 VA: 0x180C84DF0 Slot: 13
	public virtual bool Invoke(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }
}
