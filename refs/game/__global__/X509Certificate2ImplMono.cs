internal class X509Certificate2ImplMono : X509Certificate2ImplUnix // TypeDefIndex: 9631
{
	// Fields
	private X509CertificateImplCollection intermediateCerts; // 0xB0
	private X509Certificate _cert; // 0xB8
	private static string empty_error; // 0x0
	private static byte[] signedData; // 0x8

	// Properties
	public override bool IsValid { get; }
	private X509Certificate Cert { get; }
	public override bool HasPrivateKey { get; }
	public override AsymmetricAlgorithm PrivateKey { get; set; }
	internal override X509CertificateImplCollection IntermediateCertificates { get; }
	internal X509Certificate MonoCertificate { get; }

	// Methods

	// RVA: 0x2443310 Offset: 0x2441D10 VA: 0x182443310 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0x264CF40 Offset: 0x264B940 VA: 0x18264CF40
	public void .ctor(X509Certificate cert) { }

	// RVA: 0x264CF80 Offset: 0x264B980 VA: 0x18264CF80
	private void .ctor(X509Certificate2ImplMono other) { }

	// RVA: 0x264CCF0 Offset: 0x264B6F0 VA: 0x18264CCF0
	public void .ctor(byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x264C0B0 Offset: 0x264AAB0 VA: 0x18264C0B0 Slot: 6
	public override X509CertificateImpl Clone() { }

	// RVA: 0x2610E30 Offset: 0x260F830 VA: 0x182610E30
	private X509Certificate get_Cert() { }

	// RVA: 0x264C2C0 Offset: 0x264ACC0 VA: 0x18264C2C0 Slot: 33
	protected override byte[] GetRawCertData() { }

	// RVA: 0x264D040 Offset: 0x264BA40 VA: 0x18264D040 Slot: 17
	public override bool get_HasPrivateKey() { }

	// RVA: 0x264D070 Offset: 0x264BA70 VA: 0x18264D070 Slot: 24
	public override AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x264D4C0 Offset: 0x264BEC0 VA: 0x18264D4C0 Slot: 25
	public override void set_PrivateKey(AsymmetricAlgorithm value) { }

	// RVA: 0x264C230 Offset: 0x264AC30 VA: 0x18264C230 Slot: 18
	public override RSA GetRSAPrivateKey() { }

	// RVA: 0x264C1A0 Offset: 0x264ABA0 VA: 0x18264C1A0 Slot: 19
	public override DSA GetDSAPrivateKey() { }

	// RVA: 0x264CA10 Offset: 0x264B410 VA: 0x18264CA10
	private X509Certificate ImportPkcs12(byte[] rawData, SafePasswordHandle password) { }

	// RVA: 0x264C310 Offset: 0x264AD10 VA: 0x18264C310
	private X509Certificate ImportPkcs12(byte[] rawData, string password) { }

	[MonoTODO("by default this depends on the incomplete X509Chain")]
	// RVA: 0x264CA80 Offset: 0x264B480 VA: 0x18264CA80 Slot: 31
	public override bool Verify(X509Certificate2 thisCertificate) { }

	// RVA: 0x4B6150 Offset: 0x4B4B50 VA: 0x1804B6150 Slot: 29
	internal override X509CertificateImplCollection get_IntermediateCertificates() { }

	// RVA: 0x4B6160 Offset: 0x4B4B60 VA: 0x1804B6160
	internal X509Certificate get_MonoCertificate() { }

	// RVA: 0x264CC10 Offset: 0x264B610 VA: 0x18264CC10
	private static void .cctor() { }
}
