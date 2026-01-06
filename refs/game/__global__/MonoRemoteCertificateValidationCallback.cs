public sealed class MonoRemoteCertificateValidationCallback : MulticastDelegate // TypeDefIndex: 17538
{
	// Methods

	// RVA: 0x1A7AA70 Offset: 0x1A79470 VA: 0x181A7AA70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xC84DF0 Offset: 0xC837F0 VA: 0x180C84DF0 Slot: 13
	public virtual bool Invoke(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors) { }
}
