internal class TripleDESTransform : SymmetricTransform // TypeDefIndex: 4251
{
	// Fields
	private DESTransform E1; // 0x58
	private DESTransform D2; // 0x60
	private DESTransform E3; // 0x68
	private DESTransform D1; // 0x70
	private DESTransform E2; // 0x78
	private DESTransform D3; // 0x80

	// Methods

	// RVA: 0x1B1E7A0 Offset: 0x1B1D1A0 VA: 0x181B1E7A0
	public void .ctor(TripleDES algo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x1B1E590 Offset: 0x1B1CF90 VA: 0x181B1E590 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x1B1E6F0 Offset: 0x1B1D0F0 VA: 0x181B1E6F0
	internal static byte[] GetStrongKey() { }
}
