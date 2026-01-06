public class PKCS12 : ICloneable // TypeDefIndex: 17487
{
	// Fields
	private byte[] _password; // 0x10
	private ArrayList _keyBags; // 0x18
	private ArrayList _secretBags; // 0x20
	private X509CertificateCollection _certs; // 0x28
	private bool _keyBagsChanged; // 0x30
	private bool _secretBagsChanged; // 0x31
	private bool _certsChanged; // 0x32
	private int _iterations; // 0x34
	private ArrayList _safeBags; // 0x38
	private RandomNumberGenerator _rng; // 0x40
	private static int password_max_length; // 0x0

	// Properties
	public string Password { set; }
	public int IterationCount { get; set; }
	public ArrayList Keys { get; }
	public X509CertificateCollection Certificates { get; }
	internal RandomNumberGenerator RNG { get; }
	public static int MaximumPasswordLength { get; }

	// Methods

	// RVA: 0x1A629A0 Offset: 0x1A613A0 VA: 0x181A629A0
	public void .ctor() { }

	// RVA: 0x1A62910 Offset: 0x1A61310 VA: 0x181A62910
	public void .ctor(byte[] data) { }

	// RVA: 0x1A628C0 Offset: 0x1A612C0 VA: 0x181A628C0
	public void .ctor(byte[] data, string password) { }

	// RVA: 0x1A5C5D0 Offset: 0x1A5AFD0 VA: 0x181A5C5D0
	private void Decode(byte[] data) { }

	// RVA: 0x1A5DC50 Offset: 0x1A5C650 VA: 0x181A5DC50 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1A63510 Offset: 0x1A61F10 VA: 0x181A63510
	public void set_Password(string value) { }

	// RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00
	public int get_IterationCount() { }

	// RVA: 0x4E2B40 Offset: 0x4E1540 VA: 0x1804E2B40
	public void set_IterationCount(int value) { }

	// RVA: 0x1A62E80 Offset: 0x1A61880 VA: 0x181A62E80
	public ArrayList get_Keys() { }

	// RVA: 0x1A62AA0 Offset: 0x1A614A0 VA: 0x181A62AA0
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x1A634D0 Offset: 0x1A61ED0 VA: 0x181A634D0
	internal RandomNumberGenerator get_RNG() { }

	// RVA: 0x1A5C560 Offset: 0x1A5AF60 VA: 0x181A5C560
	private bool Compare(byte[] expected, byte[] actual) { }

	// RVA: 0x1A60600 Offset: 0x1A5F000 VA: 0x181A60600
	private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount) { }

	// RVA: 0x1A5D0D0 Offset: 0x1A5BAD0 VA: 0x181A5D0D0
	public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData) { }

	// RVA: 0x1A5CF90 Offset: 0x1A5B990 VA: 0x181A5CF90
	public byte[] Decrypt(PKCS7.EncryptedData ed) { }

	// RVA: 0x1A5D210 Offset: 0x1A5BC10 VA: 0x181A5D210
	public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data) { }

	// RVA: 0x1A60330 Offset: 0x1A5ED30 VA: 0x181A60330
	private DSAParameters GetExistingParameters(out bool found) { }

	// RVA: 0x1A5B5F0 Offset: 0x1A59FF0 VA: 0x181A5B5F0
	private void AddPrivateKey(PKCS8.PrivateKeyInfo pki) { }

	// RVA: 0x1A61920 Offset: 0x1A60320 VA: 0x181A61920
	private void ReadSafeBag(ASN1 safeBag) { }

	// RVA: 0x1A60DF0 Offset: 0x1A5F7F0 VA: 0x181A60DF0
	private ASN1 Pkcs8ShroudedKeyBagSafeBag(AsymmetricAlgorithm aa, IDictionary attributes) { }

	// RVA: 0x1A5B890 Offset: 0x1A5A290 VA: 0x181A5B890
	private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes) { }

	// RVA: 0x1A60C40 Offset: 0x1A5F640 VA: 0x181A60C40
	private byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data) { }

	// RVA: 0x1A5DCE0 Offset: 0x1A5C6E0 VA: 0x181A5DCE0
	public byte[] GetBytes() { }

	// RVA: 0x1A5D370 Offset: 0x1A5BD70 VA: 0x181A5D370
	private PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid) { }

	// RVA: 0x1A5AEF0 Offset: 0x1A598F0 VA: 0x181A5AEF0
	public void AddCertificate(X509Certificate cert) { }

	// RVA: 0x1A5AF00 Offset: 0x1A59900 VA: 0x181A5AF00
	public void AddCertificate(X509Certificate cert, IDictionary attributes) { }

	// RVA: 0x1A62870 Offset: 0x1A61270 VA: 0x181A62870
	public void RemoveCertificate(X509Certificate cert) { }

	// RVA: 0x1A62230 Offset: 0x1A60C30 VA: 0x181A62230
	public void RemoveCertificate(X509Certificate cert, IDictionary attrs) { }

	// RVA: 0x1A5C4A0 Offset: 0x1A5AEA0 VA: 0x181A5C4A0
	private bool CompareAsymmetricAlgorithm(AsymmetricAlgorithm a1, AsymmetricAlgorithm a2) { }

	// RVA: 0x1A5B200 Offset: 0x1A59C00 VA: 0x181A5B200
	public void AddPkcs8ShroudedKeyBag(AsymmetricAlgorithm aa, IDictionary attributes) { }

	// RVA: 0x1A5C350 Offset: 0x1A5AD50 VA: 0x181A5C350 Slot: 4
	public object Clone() { }

	// RVA: 0x1A63480 Offset: 0x1A61E80 VA: 0x181A63480
	public static int get_MaximumPasswordLength() { }

	// RVA: 0x1A62880 Offset: 0x1A61280 VA: 0x181A62880
	private static void .cctor() { }
}
