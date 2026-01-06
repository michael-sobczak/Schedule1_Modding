internal class X509CertificateImplBtls : X509Certificate2ImplUnix // TypeDefIndex: 9479
{
	// Fields
	private MonoBtlsX509 x509; // 0xB0
	private MonoBtlsKey nativePrivateKey; // 0xB8
	private X509CertificateImplCollection intermediateCerts; // 0xC0

	// Properties
	public override bool IsValid { get; }
	internal MonoBtlsX509 X509 { get; }
	internal MonoBtlsKey NativePrivateKey { get; }
	internal override X509CertificateImplCollection IntermediateCertificates { get; }
	public override bool HasPrivateKey { get; }
	public override AsymmetricAlgorithm PrivateKey { get; set; }

	// Methods

	// RVA: 0x26109F0 Offset: 0x260F3F0 VA: 0x1826109F0
	internal void .ctor(MonoBtlsX509 x509) { }

	// RVA: 0x2610A40 Offset: 0x260F440 VA: 0x182610A40
	private void .ctor(X509CertificateImplBtls other) { }

	// RVA: 0x2610B20 Offset: 0x260F520 VA: 0x182610B20
	internal void .ctor(byte[] data, MonoBtlsX509Format format) { }

	// RVA: 0x2610B80 Offset: 0x260F580 VA: 0x182610B80
	internal void .ctor(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x2610E10 Offset: 0x260F810 VA: 0x182610E10 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0x2610E50 Offset: 0x260F850 VA: 0x182610E50
	internal MonoBtlsX509 get_X509() { }

	// RVA: 0x2610E30 Offset: 0x260F830 VA: 0x182610E30
	internal MonoBtlsKey get_NativePrivateKey() { }

	// RVA: 0x260FF50 Offset: 0x260E950 VA: 0x18260FF50 Slot: 6
	public override X509CertificateImpl Clone() { }

	// RVA: 0x2610130 Offset: 0x260EB30 VA: 0x182610130 Slot: 33
	protected override byte[] GetRawCertData() { }

	// RVA: 0x4B6140 Offset: 0x4B4B40 VA: 0x1804B6140 Slot: 29
	internal override X509CertificateImplCollection get_IntermediateCertificates() { }

	// RVA: 0x2610060 Offset: 0x260EA60 VA: 0x182610060 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2443310 Offset: 0x2441D10 VA: 0x182443310 Slot: 17
	public override bool get_HasPrivateKey() { }

	// RVA: 0x26100F0 Offset: 0x260EAF0 VA: 0x1826100F0 Slot: 24
	public override AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x2610E70 Offset: 0x260F870 VA: 0x182610E70 Slot: 25
	public override void set_PrivateKey(AsymmetricAlgorithm value) { }

	// RVA: 0x26100F0 Offset: 0x260EAF0 VA: 0x1826100F0 Slot: 18
	public override RSA GetRSAPrivateKey() { }

	// RVA: 0x26100B0 Offset: 0x260EAB0 VA: 0x1826100B0 Slot: 19
	public override DSA GetDSAPrivateKey() { }

	// RVA: 0x26106B0 Offset: 0x260F0B0 VA: 0x1826106B0
	private void Import(byte[] data) { }

	// RVA: 0x2610250 Offset: 0x260EC50 VA: 0x182610250
	private void ImportPkcs12(byte[] data, SafePasswordHandle password) { }

	// RVA: 0x2610170 Offset: 0x260EB70 VA: 0x182610170
	private void ImportAuthenticode(byte[] data) { }

	// RVA: 0x2610710 Offset: 0x260F110 VA: 0x182610710 Slot: 31
	public override bool Verify(X509Certificate2 thisCertificate) { }
}
