public abstract class RSA : AsymmetricAlgorithm // TypeDefIndex: 4220
{
	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x1AEB7C0 Offset: 0x1AEA1C0 VA: 0x181AEB7C0
	public static RSA Create() { }

	// RVA: 0x1AEB820 Offset: 0x1AEA220 VA: 0x181AEB820 Slot: 10
	public virtual byte[] EncryptValue(byte[] rgb) { }

	// RVA: 0x1AEB880 Offset: 0x1AEA280 VA: 0x181AEB880 Slot: 8
	public override void FromXmlString(string xmlString) { }

	// RVA: 0x1AEBEB0 Offset: 0x1AEA8B0 VA: 0x181AEBEB0 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract RSAParameters ExportParameters(bool includePrivateParameters);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void ImportParameters(RSAParameters parameters);
}
