internal class ServerCertValidationCallback // TypeDefIndex: 10042
{
	// Fields
	private readonly RemoteCertificateValidationCallback m_ValidationCallback; // 0x10
	private readonly ExecutionContext m_Context; // 0x18

	// Properties
	internal RemoteCertificateValidationCallback ValidationCallback { get; }

	// Methods

	// RVA: 0x25BB870 Offset: 0x25BA270 VA: 0x1825BB870
	internal void .ctor(RemoteCertificateValidationCallback validationCallback) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal RemoteCertificateValidationCallback get_ValidationCallback() { }

	// RVA: 0x25BB650 Offset: 0x25BA050 VA: 0x1825BB650
	internal void Callback(object state) { }

	// RVA: 0x25BB700 Offset: 0x25BA100 VA: 0x1825BB700
	internal bool Invoke(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }
}
