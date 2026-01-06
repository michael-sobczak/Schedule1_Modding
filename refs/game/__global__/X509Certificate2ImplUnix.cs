internal abstract class X509Certificate2ImplUnix : X509Certificate2Impl // TypeDefIndex: 9632
{
	// Fields
	private bool readCertData; // 0x10
	private CertificateData certData; // 0x18

	// Properties
	public sealed override string KeyAlgorithm { get; }
	public sealed override byte[] KeyAlgorithmParameters { get; }
	public sealed override byte[] PublicKeyValue { get; }
	public sealed override byte[] SerialNumber { get; }
	public sealed override string SignatureAlgorithm { get; }
	public sealed override int Version { get; }
	public sealed override X500DistinguishedName SubjectName { get; }
	public sealed override X500DistinguishedName IssuerName { get; }
	public sealed override string Subject { get; }
	public sealed override string Issuer { get; }
	public sealed override byte[] RawData { get; }
	public sealed override byte[] Thumbprint { get; }
	public sealed override IEnumerable<X509Extension> Extensions { get; }
	public sealed override DateTime NotAfter { get; }
	public sealed override DateTime NotBefore { get; }

	// Methods

	// RVA: 0x264D7B0 Offset: 0x264C1B0 VA: 0x18264D7B0
	private void EnsureCertData() { }

	// RVA: -1 Offset: -1 Slot: 33
	protected abstract byte[] GetRawCertData();

	// RVA: 0x264DF80 Offset: 0x264C980 VA: 0x18264DF80 Slot: 13
	public sealed override string get_KeyAlgorithm() { }

	// RVA: 0x264DF60 Offset: 0x264C960 VA: 0x18264DF60 Slot: 14
	public sealed override byte[] get_KeyAlgorithmParameters() { }

	// RVA: 0x264E060 Offset: 0x264CA60 VA: 0x18264E060 Slot: 15
	public sealed override byte[] get_PublicKeyValue() { }

	// RVA: 0x264E0A0 Offset: 0x264CAA0 VA: 0x18264E0A0 Slot: 16
	public sealed override byte[] get_SerialNumber() { }

	// RVA: 0x264E0C0 Offset: 0x264CAC0 VA: 0x18264E0C0 Slot: 26
	public sealed override string get_SignatureAlgorithm() { }

	// RVA: 0x264E200 Offset: 0x264CC00 VA: 0x18264E200 Slot: 28
	public sealed override int get_Version() { }

	// RVA: 0x264E0E0 Offset: 0x264CAE0 VA: 0x18264E0E0 Slot: 27
	public sealed override X500DistinguishedName get_SubjectName() { }

	// RVA: 0x264DF10 Offset: 0x264C910 VA: 0x18264DF10 Slot: 23
	public sealed override X500DistinguishedName get_IssuerName() { }

	// RVA: 0x264E100 Offset: 0x264CB00 VA: 0x18264E100 Slot: 8
	public sealed override string get_Subject() { }

	// RVA: 0x264DF30 Offset: 0x264C930 VA: 0x18264DF30 Slot: 7
	public sealed override string get_Issuer() { }

	// RVA: 0x264E080 Offset: 0x264CA80 VA: 0x18264E080 Slot: 9
	public sealed override byte[] get_RawData() { }

	// RVA: 0x264E130 Offset: 0x264CB30 VA: 0x18264E130 Slot: 12
	public sealed override byte[] get_Thumbprint() { }

	// RVA: 0x264DEB0 Offset: 0x264C8B0 VA: 0x18264DEB0 Slot: 30
	public sealed override string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x264DEF0 Offset: 0x264C8F0 VA: 0x18264DEF0 Slot: 22
	public sealed override IEnumerable<X509Extension> get_Extensions() { }

	// RVA: 0x264DFA0 Offset: 0x264C9A0 VA: 0x18264DFA0 Slot: 10
	public sealed override DateTime get_NotAfter() { }

	// RVA: 0x264E000 Offset: 0x264CA00 VA: 0x18264E000 Slot: 11
	public sealed override DateTime get_NotBefore() { }

	// RVA: 0x264D720 Offset: 0x264C120 VA: 0x18264D720 Slot: 32
	public sealed override void AppendPrivateKeyInfo(StringBuilder sb) { }

	// RVA: 0x264DD30 Offset: 0x264C730 VA: 0x18264DD30 Slot: 20
	public sealed override byte[] Export(X509ContentType contentType, SafePasswordHandle password) { }

	// RVA: 0x264D8C0 Offset: 0x264C2C0 VA: 0x18264D8C0
	private byte[] ExportPkcs12(SafePasswordHandle password) { }

	// RVA: 0x264D920 Offset: 0x264C320 VA: 0x18264D920
	private byte[] ExportPkcs12(string password) { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	protected void .ctor() { }
}
