internal class DSAManaged : DSA // TypeDefIndex: 3521
{
	// Fields
	private bool keypairGenerated; // 0x20
	private bool m_disposed; // 0x21
	private BigInteger p; // 0x28
	private BigInteger q; // 0x30
	private BigInteger g; // 0x38
	private BigInteger x; // 0x40
	private BigInteger y; // 0x48
	private BigInteger j; // 0x50
	private BigInteger seed; // 0x58
	private int counter; // 0x60
	private bool j_missing; // 0x64
	private RandomNumberGenerator rng; // 0x68
	[CompilerGenerated]
	private DSAManaged.KeyGeneratedEventHandler KeyGenerated; // 0x70

	// Properties
	private RandomNumberGenerator Random { get; }
	public override int KeySize { get; }
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x1A9C9C0 Offset: 0x1A9B3C0 VA: 0x181A9C9C0
	public void .ctor(int dwKeySize) { }

	// RVA: 0x4D8670 Offset: 0x4D7070 VA: 0x1804D8670 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1A9BED0 Offset: 0x1A9A8D0 VA: 0x181A9BED0
	private void Generate() { }

	// RVA: 0x1A9B2F0 Offset: 0x1A99CF0 VA: 0x181A9B2F0
	private void GenerateKeyPair() { }

	// RVA: 0x1A9CB30 Offset: 0x1A9B530 VA: 0x181A9CB30
	private void add(byte[] a, byte[] b, int value) { }

	// RVA: 0x1A9B540 Offset: 0x1A99F40 VA: 0x181A9B540
	private void GenerateParams(int keyLength) { }

	// RVA: 0x1A9CC60 Offset: 0x1A9B660 VA: 0x181A9CC60
	private RandomNumberGenerator get_Random() { }

	// RVA: 0x1A9CBD0 Offset: 0x1A9B5D0 VA: 0x181A9CBD0 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x1A9CC00 Offset: 0x1A9B600 VA: 0x181A9CC00
	public bool get_PublicOnly() { }

	// RVA: 0x1A9C350 Offset: 0x1A9AD50 VA: 0x181A9C350
	private byte[] NormalizeArray(byte[] array) { }

	// RVA: 0x1A9AF40 Offset: 0x1A99940 VA: 0x181A9AF40 Slot: 11
	public override DSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x1A9BF20 Offset: 0x1A9A920 VA: 0x181A9BF20 Slot: 12
	public override void ImportParameters(DSAParameters parameters) { }

	// RVA: 0x1A9C400 Offset: 0x1A9AE00 VA: 0x181A9C400 Slot: 10
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

	// RVA: 0x1A9AC80 Offset: 0x1A99680 VA: 0x181A9AC80 Slot: 5
	protected override void Dispose(bool disposing) { }

	[CompilerGenerated]
	// RVA: 0x1A9CA90 Offset: 0x1A9B490 VA: 0x181A9CA90
	public void add_KeyGenerated(DSAManaged.KeyGeneratedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1A9CCA0 Offset: 0x1A9B6A0 VA: 0x181A9CCA0
	public void remove_KeyGenerated(DSAManaged.KeyGeneratedEventHandler value) { }
}
