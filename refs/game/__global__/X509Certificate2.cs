public class X509Certificate2 : X509Certificate // TypeDefIndex: 9627
{
	// Fields
	private byte[] lazyRawData; // 0x60
	private Oid lazySignatureAlgorithm; // 0x68
	private int lazyVersion; // 0x70
	private X500DistinguishedName lazySubjectName; // 0x78
	private X500DistinguishedName lazyIssuerName; // 0x80
	private PublicKey lazyPublicKey; // 0x88
	private AsymmetricAlgorithm lazyPrivateKey; // 0x90
	private X509ExtensionCollection lazyExtensions; // 0x98

	// Properties
	public X509ExtensionCollection Extensions { get; }
	public bool HasPrivateKey { get; }
	public AsymmetricAlgorithm PrivateKey { get; }
	public X500DistinguishedName IssuerName { get; }
	public DateTime NotAfter { get; }
	public DateTime NotBefore { get; }
	public PublicKey PublicKey { get; }
	public byte[] RawData { get; }
	public string SerialNumber { get; }
	public Oid SignatureAlgorithm { get; }
	public X500DistinguishedName SubjectName { get; }
	public string Thumbprint { get; }
	public int Version { get; }
	internal X509Certificate2Impl Impl { get; }

	// Methods

	// RVA: 0x264E5E0 Offset: 0x264CFE0 VA: 0x18264E5E0 Slot: 7
	public override void Reset() { }

	// RVA: 0x264F560 Offset: 0x264DF60 VA: 0x18264F560
	public void .ctor() { }

	// RVA: 0x264F440 Offset: 0x264DE40 VA: 0x18264F440
	public void .ctor(byte[] rawData) { }

	// RVA: 0x264F420 Offset: 0x264DE20 VA: 0x18264F420
	public void .ctor(byte[] rawData, string password) { }

	// RVA: 0x264F550 Offset: 0x264DF50 VA: 0x18264F550
	internal void .ctor(X509Certificate2Impl impl) { }

	// RVA: 0x264F430 Offset: 0x264DE30 VA: 0x18264F430
	public void .ctor(X509Certificate certificate) { }

	// RVA: 0x264F570 Offset: 0x264DF70 VA: 0x18264F570
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x264F5D0 Offset: 0x264DFD0 VA: 0x18264F5D0
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x264F920 Offset: 0x264E320 VA: 0x18264F920
	public bool get_HasPrivateKey() { }

	// RVA: 0x264FA90 Offset: 0x264E490 VA: 0x18264FA90
	public AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x264F9F0 Offset: 0x264E3F0 VA: 0x18264F9F0
	public X500DistinguishedName get_IssuerName() { }

	// RVA: 0x264FA70 Offset: 0x264E470 VA: 0x18264FA70
	public DateTime get_NotAfter() { }

	// RVA: 0x264FA80 Offset: 0x264E480 VA: 0x18264FA80
	public DateTime get_NotBefore() { }

	// RVA: 0x264FC50 Offset: 0x264E650 VA: 0x18264FC50
	public PublicKey get_PublicKey() { }

	// RVA: 0x264FF70 Offset: 0x264E970 VA: 0x18264FF70
	public byte[] get_RawData() { }

	// RVA: 0xB1E170 Offset: 0xB1CB70 VA: 0x180B1E170
	public string get_SerialNumber() { }

	// RVA: 0x264FFF0 Offset: 0x264E9F0 VA: 0x18264FFF0
	public Oid get_SignatureAlgorithm() { }

	// RVA: 0x2650080 Offset: 0x264EA80 VA: 0x182650080
	public X500DistinguishedName get_SubjectName() { }

	// RVA: 0x2650100 Offset: 0x264EB00 VA: 0x182650100
	public string get_Thumbprint() { }

	// RVA: 0x2650130 Offset: 0x264EB30 VA: 0x182650130
	public int get_Version() { }

	// RVA: 0x264E4F0 Offset: 0x264CEF0 VA: 0x18264E4F0
	public static X509ContentType GetCertContentType(byte[] rawData) { }

	// RVA: 0x264E590 Offset: 0x264CF90 VA: 0x18264E590
	public string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x264F3D0 Offset: 0x264DDD0 VA: 0x18264F3D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x264E6B0 Offset: 0x264D0B0 VA: 0x18264E6B0 Slot: 19
	public override string ToString(bool verbose) { }

	// RVA: 0x264F3E0 Offset: 0x264DDE0 VA: 0x18264F3E0
	public bool Verify() { }

	// RVA: 0x264E220 Offset: 0x264CC20 VA: 0x18264E220
	private static X509Extension CreateCustomExtensionIfAny(Oid oid) { }

	// RVA: 0x264F970 Offset: 0x264E370 VA: 0x18264F970
	internal X509Certificate2Impl get_Impl() { }
}
