public class AuthenticodeDeformatter : AuthenticodeBase // TypeDefIndex: 17558
{
	// Fields
	private string filename; // 0x40
	private byte[] rawdata; // 0x48
	private byte[] hash; // 0x50
	private X509CertificateCollection coll; // 0x58
	private ASN1 signedHash; // 0x60
	private DateTime timestamp; // 0x68
	private X509Certificate signingCertificate; // 0x70
	private int reason; // 0x78
	private bool trustedRoot; // 0x7C
	private bool trustedTimestampRoot; // 0x7D
	private byte[] entry; // 0x80
	private X509Chain signerChain; // 0x88
	private X509Chain timestampChain; // 0x90

	// Properties
	public byte[] RawData { set; }
	public X509Certificate SigningCertificate { get; }

	// Methods

	// RVA: 0x1A72510 Offset: 0x1A70F10 VA: 0x181A72510
	public void .ctor() { }

	// RVA: 0x1A725F0 Offset: 0x1A70FF0 VA: 0x181A725F0
	public void .ctor(byte[] rawData) { }

	// RVA: 0x1A726F0 Offset: 0x1A710F0 VA: 0x181A726F0
	public void set_RawData(byte[] value) { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public X509Certificate get_SigningCertificate() { }

	// RVA: 0x1A6F6E0 Offset: 0x1A6E0E0 VA: 0x181A6F6E0
	private bool CheckSignature() { }

	// RVA: 0x1A710C0 Offset: 0x1A6FAC0 VA: 0x181A710C0
	private bool CompareIssuerSerial(string issuer, byte[] serial, X509Certificate x509) { }

	// RVA: 0x1A71B80 Offset: 0x1A70580 VA: 0x181A71B80
	private bool VerifySignature(PKCS7.SignedData sd, byte[] calculatedMessageDigest, HashAlgorithm ha) { }

	// RVA: 0x1A712E0 Offset: 0x1A6FCE0 VA: 0x181A712E0
	private bool VerifyCounterSignature(PKCS7.SignerInfo cs, byte[] signature) { }

	// RVA: 0x1A711E0 Offset: 0x1A6FBE0 VA: 0x181A711E0
	private void Reset() { }
}
