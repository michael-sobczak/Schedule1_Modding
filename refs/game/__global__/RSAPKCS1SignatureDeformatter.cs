public class RSAPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter // TypeDefIndex: 4247
{
	// Fields
	private RSA rsa; // 0x10
	private string hashName; // 0x18

	// Methods

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }

	// RVA: 0x1AF9C40 Offset: 0x1AF8640 VA: 0x181AF9C40
	public void .ctor(AsymmetricAlgorithm key) { }

	// RVA: 0x1AF98D0 Offset: 0x1AF82D0 VA: 0x181AF98D0 Slot: 5
	public override void SetHashAlgorithm(string strName) { }

	// RVA: 0x1AF9940 Offset: 0x1AF8340 VA: 0x181AF9940 Slot: 4
	public override void SetKey(AsymmetricAlgorithm key) { }

	// RVA: 0x1AF9A50 Offset: 0x1AF8450 VA: 0x181AF9A50 Slot: 6
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }
}
