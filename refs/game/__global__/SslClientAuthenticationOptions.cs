public class SslClientAuthenticationOptions // TypeDefIndex: 10225
{
	// Fields
	private EncryptionPolicy _encryptionPolicy; // 0x10
	private X509RevocationMode _checkCertificateRevocation; // 0x14
	private SslProtocols _enabledSslProtocols; // 0x18
	private bool _allowRenegotiation; // 0x1C
	[CompilerGenerated]
	private LocalCertificateSelectionCallback <LocalCertificateSelectionCallback>k__BackingField; // 0x20
	[CompilerGenerated]
	private RemoteCertificateValidationCallback <RemoteCertificateValidationCallback>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <TargetHost>k__BackingField; // 0x30
	[CompilerGenerated]
	private X509CertificateCollection <ClientCertificates>k__BackingField; // 0x38

	// Properties
	public bool AllowRenegotiation { get; }
	public LocalCertificateSelectionCallback LocalCertificateSelectionCallback { get; set; }
	public RemoteCertificateValidationCallback RemoteCertificateValidationCallback { get; }
	public string TargetHost { get; set; }
	public X509CertificateCollection ClientCertificates { get; set; }
	public X509RevocationMode CertificateRevocationCheckMode { set; }
	public EncryptionPolicy EncryptionPolicy { set; }
	public SslProtocols EnabledSslProtocols { get; set; }

	// Methods

	// RVA: 0x4975B0 Offset: 0x495FB0 VA: 0x1804975B0
	public bool get_AllowRenegotiation() { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public LocalCertificateSelectionCallback get_LocalCertificateSelectionCallback() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_LocalCertificateSelectionCallback(LocalCertificateSelectionCallback value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public RemoteCertificateValidationCallback get_RemoteCertificateValidationCallback() { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_TargetHost() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_TargetHost(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public X509CertificateCollection get_ClientCertificates() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	public void set_ClientCertificates(X509CertificateCollection value) { }

	// RVA: 0x25EF830 Offset: 0x25EE230 VA: 0x1825EF830
	public void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	// RVA: 0x25EF8D0 Offset: 0x25EE2D0 VA: 0x1825EF8D0
	public void set_EncryptionPolicy(EncryptionPolicy value) { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public SslProtocols get_EnabledSslProtocols() { }

	// RVA: 0x49D810 Offset: 0x49C210 VA: 0x18049D810
	public void set_EnabledSslProtocols(SslProtocols value) { }

	// RVA: 0x25EF820 Offset: 0x25EE220 VA: 0x1825EF820
	public void .ctor() { }
}
