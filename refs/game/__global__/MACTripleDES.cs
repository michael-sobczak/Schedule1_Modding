public class MACTripleDES : KeyedHashAlgorithm // TypeDefIndex: 4207
{
	// Fields
	private ICryptoTransform m_encryptor; // 0x30
	private CryptoStream _cs; // 0x38
	private TailStream _ts; // 0x40
	private int m_bytesPerBlock; // 0x48
	private TripleDES des; // 0x50

	// Methods

	// RVA: 0x1AE7730 Offset: 0x1AE6130 VA: 0x181AE7730
	public void .ctor() { }

	// RVA: 0xCF2000 Offset: 0xCF0A00 VA: 0x180CF2000 Slot: 18
	public override void Initialize() { }

	// RVA: 0x1AE7380 Offset: 0x1AE5D80 VA: 0x181AE7380 Slot: 16
	protected override void HashCore(byte[] rgbData, int ibStart, int cbSize) { }

	// RVA: 0x1AE7540 Offset: 0x1AE5F40 VA: 0x181AE7540 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x1AE72B0 Offset: 0x1AE5CB0 VA: 0x181AE72B0 Slot: 12
	protected override void Dispose(bool disposing) { }
}
