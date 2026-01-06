internal sealed class MonoSslClientAuthenticationOptions : MonoSslAuthenticationOptions // TypeDefIndex: 9407
{
	// Fields
	[CompilerGenerated]
	private readonly SslClientAuthenticationOptions <Options>k__BackingField; // 0x18

	// Properties
	public SslClientAuthenticationOptions Options { get; }
	public override bool ServerMode { get; }
	public override bool AllowRenegotiation { get; }
	public override X509RevocationMode CertificateRevocationCheckMode { set; }
	public override EncryptionPolicy EncryptionPolicy { set; }
	public override SslProtocols EnabledSslProtocols { get; set; }
	public override string TargetHost { get; set; }
	public override bool ClientCertificateRequired { get; }
	public override X509CertificateCollection ClientCertificates { get; set; }
	public override X509Certificate ServerCertificate { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public SslClientAuthenticationOptions get_Options() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 4
	public override bool get_ServerMode() { }

	// RVA: 0x201BC00 Offset: 0x201A600 VA: 0x18201BC00
	public void .ctor() { }

	// RVA: 0x201BC70 Offset: 0x201A670 VA: 0x18201BC70 Slot: 5
	public override bool get_AllowRenegotiation() { }

	// RVA: 0x201BD10 Offset: 0x201A710 VA: 0x18201BD10 Slot: 9
	public override void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	// RVA: 0x201BD80 Offset: 0x201A780 VA: 0x18201BD80 Slot: 8
	public override void set_EncryptionPolicy(EncryptionPolicy value) { }

	// RVA: 0x11AE000 Offset: 0x11ACA00 VA: 0x1811AE000 Slot: 6
	public override SslProtocols get_EnabledSslProtocols() { }

	// RVA: 0x201BD60 Offset: 0x201A760 VA: 0x18201BD60 Slot: 7
	public override void set_EnabledSslProtocols(SslProtocols value) { }

	// RVA: 0x1DF3CD0 Offset: 0x1DF26D0 VA: 0x181DF3CD0 Slot: 10
	public override string get_TargetHost() { }

	// RVA: 0x201BDA0 Offset: 0x201A7A0 VA: 0x18201BDA0 Slot: 11
	public override void set_TargetHost(string value) { }

	// RVA: 0x201BC90 Offset: 0x201A690 VA: 0x18201BC90 Slot: 15
	public override bool get_ClientCertificateRequired() { }

	// RVA: 0x1DF3CF0 Offset: 0x1DF26F0 VA: 0x181DF3CF0 Slot: 13
	public override X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x201BD30 Offset: 0x201A730 VA: 0x18201BD30 Slot: 14
	public override void set_ClientCertificates(X509CertificateCollection value) { }

	// RVA: 0x201BCD0 Offset: 0x201A6D0 VA: 0x18201BCD0 Slot: 12
	public override X509Certificate get_ServerCertificate() { }
}
