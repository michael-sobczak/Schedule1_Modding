public class RSAManaged : RSA // TypeDefIndex: 17556
{
	// Fields
	private bool isCRTpossible; // 0x20
	private bool keyBlinding; // 0x21
	private bool keypairGenerated; // 0x22
	private bool m_disposed; // 0x23
	private BigInteger d; // 0x28
	private BigInteger p; // 0x30
	private BigInteger q; // 0x38
	private BigInteger dp; // 0x40
	private BigInteger dq; // 0x48
	private BigInteger qInv; // 0x50
	private BigInteger n; // 0x58
	private BigInteger e; // 0x60
	[CompilerGenerated]
	private RSAManaged.KeyGeneratedEventHandler KeyGenerated; // 0x68

	// Properties
	public override int KeySize { get; }
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x1A802A0 Offset: 0x1A7ECA0 VA: 0x181A802A0
	public void .ctor() { }

	// RVA: 0x1A80390 Offset: 0x1A7ED90 VA: 0x181A80390
	public void .ctor(int keySize) { }

	// RVA: 0x4D8670 Offset: 0x4D7070 VA: 0x1804D8670 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1A7EEE0 Offset: 0x1A7D8E0 VA: 0x181A7EEE0
	private void GenerateKeyPair() { }

	// RVA: 0x1A80480 Offset: 0x1A7EE80 VA: 0x181A80480 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x1A80530 Offset: 0x1A7EF30 VA: 0x181A80530
	public bool get_PublicOnly() { }

	// RVA: 0x1A7E8C0 Offset: 0x1A7D2C0 VA: 0x181A7E8C0 Slot: 10
	public override byte[] EncryptValue(byte[] rgb) { }

	// RVA: 0x1A7EAC0 Offset: 0x1A7D4C0 VA: 0x181A7EAC0 Slot: 11
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x1A7F500 Offset: 0x1A7DF00 VA: 0x181A7F500 Slot: 12
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x1A7E4B0 Offset: 0x1A7CEB0 VA: 0x181A7E4B0 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1A7FCC0 Offset: 0x1A7E6C0 VA: 0x181A7FCC0 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: 0x1A7F450 Offset: 0x1A7DE50 VA: 0x181A7F450
	private byte[] GetPaddedValue(BigInteger value, int length) { }
}
