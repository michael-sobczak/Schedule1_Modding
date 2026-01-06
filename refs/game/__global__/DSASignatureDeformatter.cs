public class DSASignatureDeformatter : AsymmetricSignatureDeformatter // TypeDefIndex: 4196
{
	// Fields
	private DSA _dsaKey; // 0x10
	private string _oid; // 0x18

	// Methods

	// RVA: 0x1AE41C0 Offset: 0x1AE2BC0 VA: 0x181AE41C0
	public void .ctor() { }

	// RVA: 0x1AE4050 Offset: 0x1AE2A50 VA: 0x181AE4050
	public void .ctor(AsymmetricAlgorithm key) { }

	// RVA: 0x1AE3E10 Offset: 0x1AE2810 VA: 0x181AE3E10 Slot: 4
	public override void SetKey(AsymmetricAlgorithm key) { }

	// RVA: 0x1AE3D50 Offset: 0x1AE2750 VA: 0x181AE3D50 Slot: 5
	public override void SetHashAlgorithm(string strName) { }

	// RVA: 0x1AE3F20 Offset: 0x1AE2920 VA: 0x181AE3F20 Slot: 6
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }
}
