public sealed class RijndaelManaged : Rijndael // TypeDefIndex: 4214
{
	// Methods

	// RVA: 0x1AF01E0 Offset: 0x1AEEBE0 VA: 0x181AF01E0
	public void .ctor() { }

	// RVA: 0x1AEFF80 Offset: 0x1AEE980 VA: 0x181AEFF80 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x1AEFE90 Offset: 0x1AEE890 VA: 0x181AEFE90 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x1AF00B0 Offset: 0x1AEEAB0 VA: 0x181AF00B0 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x1AF0070 Offset: 0x1AEEA70 VA: 0x181AF0070 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x1AF00F0 Offset: 0x1AEEAF0 VA: 0x181AF00F0
	private ICryptoTransform NewEncryptor(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int feedbackSize, RijndaelManagedTransformMode encryptMode) { }
}
