internal struct CertificateData // TypeDefIndex: 9489
{
	// Fields
	internal byte[] RawData; // 0x0
	internal byte[] SubjectPublicKeyInfo; // 0x8
	internal int Version; // 0x10
	internal byte[] SerialNumber; // 0x18
	internal CertificateData.AlgorithmIdentifier TbsSignature; // 0x20
	internal X500DistinguishedName Issuer; // 0x30
	internal DateTime NotBefore; // 0x38
	internal DateTime NotAfter; // 0x40
	internal X500DistinguishedName Subject; // 0x48
	internal CertificateData.AlgorithmIdentifier PublicKeyAlgorithm; // 0x50
	internal byte[] PublicKey; // 0x60
	internal byte[] IssuerUniqueId; // 0x68
	internal byte[] SubjectUniqueId; // 0x70
	internal List<X509Extension> Extensions; // 0x78
	internal CertificateData.AlgorithmIdentifier SignatureAlgorithm; // 0x80
	internal byte[] SignatureValue; // 0x90

	// Methods

	// RVA: 0x25F7D80 Offset: 0x25F6780 VA: 0x1825F7D80
	internal void .ctor(byte[] rawData) { }

	// RVA: 0x25F7450 Offset: 0x25F5E50 VA: 0x1825F7450
	public string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x25F7980 Offset: 0x25F6380 VA: 0x1825F7980
	private static string GetSimpleNameInfo(X500DistinguishedName name) { }

	// RVA: 0x25F72A0 Offset: 0x25F5CA0 VA: 0x1825F72A0
	private static string FindAltNameMatch(byte[] extensionBytes, GeneralNameType matchType, string otherOid) { }

	[IteratorStateMachine(typeof(CertificateData.<ReadReverseRdns>d__21))]
	// RVA: 0x25F7D00 Offset: 0x25F6700 VA: 0x1825F7D00
	private static IEnumerable<KeyValuePair<string, string>> ReadReverseRdns(X500DistinguishedName name) { }
}
