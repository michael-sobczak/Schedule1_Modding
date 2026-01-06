public class X509Chain // TypeDefIndex: 17494
{
	// Fields
	private X509CertificateCollection roots; // 0x10
	private X509CertificateCollection certs; // 0x18
	private X509Certificate _root; // 0x20
	private X509CertificateCollection _chain; // 0x28
	private X509ChainStatusFlags _status; // 0x30

	// Properties
	public X509CertificateCollection TrustAnchors { get; }

	// Methods

	// RVA: 0x1A6ADF0 Offset: 0x1A697F0 VA: 0x181A6ADF0
	public void .ctor() { }

	// RVA: 0x1A6AE60 Offset: 0x1A69860 VA: 0x181A6AE60
	public X509CertificateCollection get_TrustAnchors() { }

	// RVA: 0x1A6AD80 Offset: 0x1A69780 VA: 0x181A6AD80
	public void LoadCertificates(X509CertificateCollection collection) { }

	// RVA: 0x1A6A280 Offset: 0x1A68C80 VA: 0x181A6A280
	public bool Build(X509Certificate leaf) { }

	// RVA: 0x1A6ADA0 Offset: 0x1A697A0 VA: 0x181A6ADA0
	public void Reset() { }

	// RVA: 0x1A6ABF0 Offset: 0x1A695F0 VA: 0x181A6ABF0
	private bool IsValid(X509Certificate cert) { }

	// RVA: 0x1A6A660 Offset: 0x1A69060 VA: 0x181A6A660
	private X509Certificate FindCertificateParent(X509Certificate child) { }

	// RVA: 0x1A6A840 Offset: 0x1A69240 VA: 0x181A6A840
	private X509Certificate FindCertificateRoot(X509Certificate potentialRoot) { }

	// RVA: 0x1A6ABB0 Offset: 0x1A695B0 VA: 0x181A6ABB0
	private bool IsTrusted(X509Certificate potentialTrusted) { }

	// RVA: 0x1A6AA30 Offset: 0x1A69430 VA: 0x181A6AA30
	private bool IsParent(X509Certificate child, X509Certificate parent) { }
}
