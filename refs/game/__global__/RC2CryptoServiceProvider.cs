public sealed class RC2CryptoServiceProvider : RC2 // TypeDefIndex: 4212
{
	// Fields
	private bool m_use40bitSalt; // 0x50
	private static KeySizes[] s_legalKeySizes; // 0x0

	// Properties
	public override int EffectiveKeySize { get; }

	// Methods

	// RVA: 0x1AE7CA0 Offset: 0x1AE66A0 VA: 0x181AE7CA0
	public void .ctor() { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50 Slot: 26
	public override int get_EffectiveKeySize() { }

	// RVA: 0x1AE79F0 Offset: 0x1AE63F0 VA: 0x181AE79F0 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x1AE7920 Offset: 0x1AE6320 VA: 0x181AE7920 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x1AE7B40 Offset: 0x1AE6540 VA: 0x181AE7B40 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x1AE7AC0 Offset: 0x1AE64C0 VA: 0x181AE7AC0 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x1AE7BC0 Offset: 0x1AE65C0 VA: 0x181AE7BC0
	private static void .cctor() { }
}
