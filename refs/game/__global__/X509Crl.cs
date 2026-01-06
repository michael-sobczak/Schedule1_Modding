public class X509Crl // TypeDefIndex: 17490
{
	// Fields
	private string issuer; // 0x10
	private byte version; // 0x18
	private DateTime thisUpdate; // 0x20
	private DateTime nextUpdate; // 0x28
	private ArrayList entries; // 0x30
	private string signatureOID; // 0x38
	private byte[] signature; // 0x40
	private X509ExtensionCollection extensions; // 0x48
	private byte[] encoded; // 0x50
	private byte[] hash_value; // 0x58

	// Properties
	public X509ExtensionCollection Extensions { get; }
	public byte[] Hash { get; }
	public string IssuerName { get; }
	public DateTime NextUpdate { get; }

	// Methods

	// RVA: 0x1A6C130 Offset: 0x1A6AB30 VA: 0x181A6C130
	public void .ctor(byte[] crl) { }

	// RVA: 0x1A6B340 Offset: 0x1A69D40 VA: 0x181A6B340
	private void Parse(byte[] crl) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x1A6C250 Offset: 0x1A6AC50 VA: 0x181A6C250
	public byte[] get_Hash() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_IssuerName() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public DateTime get_NextUpdate() { }

	// RVA: 0x1A67850 Offset: 0x1A66250 VA: 0x181A67850
	private bool Compare(byte[] array1, byte[] array2) { }

	// RVA: 0x1A6B090 Offset: 0x1A69A90 VA: 0x181A6B090
	public X509Crl.X509CrlEntry GetCrlEntry(X509Certificate x509) { }

	// RVA: 0x1A6B120 Offset: 0x1A69B20 VA: 0x181A6B120
	public X509Crl.X509CrlEntry GetCrlEntry(byte[] serialNumber) { }

	// RVA: 0x1A6BE30 Offset: 0x1A6A830 VA: 0x181A6BE30
	internal bool VerifySignature(DSA dsa) { }

	// RVA: 0x1A6BD50 Offset: 0x1A6A750 VA: 0x181A6BD50
	internal bool VerifySignature(RSA rsa) { }

	// RVA: 0x1A6BAA0 Offset: 0x1A6A4A0 VA: 0x181A6BAA0
	public bool VerifySignature(AsymmetricAlgorithm aa) { }
}
