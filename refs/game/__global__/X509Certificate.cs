public class X509Certificate : ISerializable // TypeDefIndex: 17491
{
	// Fields
	private ASN1 decoder; // 0x10
	private byte[] m_encodedcert; // 0x18
	private DateTime m_from; // 0x20
	private DateTime m_until; // 0x28
	private ASN1 issuer; // 0x30
	private string m_issuername; // 0x38
	private string m_keyalgo; // 0x40
	private byte[] m_keyalgoparams; // 0x48
	private ASN1 subject; // 0x50
	private string m_subject; // 0x58
	private byte[] m_publickey; // 0x60
	private byte[] signature; // 0x68
	private string m_signaturealgo; // 0x70
	private byte[] m_signaturealgoparams; // 0x78
	private byte[] certhash; // 0x80
	private RSA _rsa; // 0x88
	private DSA _dsa; // 0x90
	private int version; // 0x98
	private byte[] serialnumber; // 0xA0
	private byte[] issuerUniqueID; // 0xA8
	private byte[] subjectUniqueID; // 0xB0
	private X509ExtensionCollection extensions; // 0xB8
	private static string encoding_error; // 0x0

	// Properties
	public DSA DSA { get; set; }
	public X509ExtensionCollection Extensions { get; }
	public byte[] Hash { get; }
	public virtual string IssuerName { get; }
	public virtual string KeyAlgorithm { get; }
	public virtual byte[] KeyAlgorithmParameters { get; set; }
	public virtual byte[] PublicKey { get; }
	public virtual RSA RSA { get; set; }
	public virtual byte[] RawData { get; }
	public virtual byte[] SerialNumber { get; }
	public virtual byte[] Signature { get; }
	public virtual string SubjectName { get; }
	public virtual DateTime ValidFrom { get; }
	public virtual DateTime ValidUntil { get; }
	public int Version { get; }
	public bool IsCurrent { get; }
	public bool IsSelfSigned { get; }

	// Methods

	// RVA: 0x1A680D0 Offset: 0x1A66AD0 VA: 0x181A680D0
	private void Parse(byte[] data) { }

	// RVA: 0x1A68FB0 Offset: 0x1A679B0 VA: 0x181A68FB0
	public void .ctor(byte[] data) { }

	// RVA: 0x1A67F10 Offset: 0x1A66910 VA: 0x181A67F10
	private byte[] GetUnsignedBigInteger(byte[] integer) { }

	// RVA: 0x1A691F0 Offset: 0x1A67BF0 VA: 0x181A691F0
	public DSA get_DSA() { }

	// RVA: 0x1A6A1E0 Offset: 0x1A68BE0 VA: 0x181A6A1E0
	public void set_DSA(DSA value) { }

	// RVA: 0x4B6160 Offset: 0x4B4B60 VA: 0x1804B6160
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x1A69590 Offset: 0x1A67F90 VA: 0x181A69590
	public byte[] get_Hash() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0 Slot: 5
	public virtual string get_IssuerName() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0 Slot: 6
	public virtual string get_KeyAlgorithm() { }

	// RVA: 0x1A69980 Offset: 0x1A68380 VA: 0x181A69980 Slot: 7
	public virtual byte[] get_KeyAlgorithmParameters() { }

	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30 Slot: 8
	public virtual void set_KeyAlgorithmParameters(byte[] value) { }

	// RVA: 0x1A69A00 Offset: 0x1A68400 VA: 0x181A69A00 Slot: 9
	public virtual byte[] get_PublicKey() { }

	// RVA: 0x1A69A80 Offset: 0x1A68480 VA: 0x181A69A80 Slot: 10
	public virtual RSA get_RSA() { }

	// RVA: 0x1A6A230 Offset: 0x1A68C30 VA: 0x181A6A230 Slot: 11
	public virtual void set_RSA(RSA value) { }

	// RVA: 0x1A69CA0 Offset: 0x1A686A0 VA: 0x181A69CA0 Slot: 12
	public virtual byte[] get_RawData() { }

	// RVA: 0x1A69D20 Offset: 0x1A68720 VA: 0x181A69D20 Slot: 13
	public virtual byte[] get_SerialNumber() { }

	// RVA: 0x1A69DB0 Offset: 0x1A687B0 VA: 0x181A69DB0 Slot: 14
	public virtual byte[] get_Signature() { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0 Slot: 15
	public virtual string get_SubjectName() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 16
	public virtual DateTime get_ValidFrom() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0 Slot: 17
	public virtual DateTime get_ValidUntil() { }

	// RVA: 0x4B62D0 Offset: 0x4B4CD0 VA: 0x1804B62D0
	public int get_Version() { }

	// RVA: 0x1A697E0 Offset: 0x1A681E0 VA: 0x181A697E0
	public bool get_IsCurrent() { }

	// RVA: 0x1A68E80 Offset: 0x1A67880 VA: 0x181A68E80
	public bool WasCurrent(DateTime instant) { }

	// RVA: 0x1A68DA0 Offset: 0x1A677A0 VA: 0x181A68DA0
	internal bool VerifySignature(DSA dsa) { }

	// RVA: 0x1A68C70 Offset: 0x1A67670 VA: 0x181A68C70
	internal bool VerifySignature(RSA rsa) { }

	// RVA: 0x1A68A80 Offset: 0x1A67480 VA: 0x181A68A80
	public bool VerifySignature(AsymmetricAlgorithm aa) { }

	// RVA: 0x1A698F0 Offset: 0x1A682F0 VA: 0x181A698F0
	public bool get_IsSelfSigned() { }

	// RVA: 0x1A67EB0 Offset: 0x1A668B0 VA: 0x181A67EB0 Slot: 18
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A67FB0 Offset: 0x1A669B0 VA: 0x181A67FB0
	private static byte[] PEM(string type, byte[] data) { }

	// RVA: 0x1A68F50 Offset: 0x1A67950 VA: 0x181A68F50
	private static void .cctor() { }
}
