public abstract class AsymmetricSignatureDeformatter // TypeDefIndex: 4183
{
	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SetKey(AsymmetricAlgorithm key);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SetHashAlgorithm(string strName);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);
}
