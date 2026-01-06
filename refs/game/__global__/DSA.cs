public abstract class DSA : AsymmetricAlgorithm // TypeDefIndex: 4195
{
	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x1AE42C0 Offset: 0x1AE2CC0 VA: 0x181AE42C0
	public static DSA Create() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);

	// RVA: 0x1AE4310 Offset: 0x1AE2D10 VA: 0x181AE4310 Slot: 8
	public override void FromXmlString(string xmlString) { }

	// RVA: 0x1AE4CF0 Offset: 0x1AE36F0 VA: 0x181AE4CF0 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract DSAParameters ExportParameters(bool includePrivateParameters);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void ImportParameters(DSAParameters parameters);
}
