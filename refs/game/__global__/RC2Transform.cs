internal class RC2Transform : SymmetricTransform // TypeDefIndex: 4245
{
	// Fields
	private ushort R0; // 0x58
	private ushort R1; // 0x5A
	private ushort R2; // 0x5C
	private ushort R3; // 0x5E
	private ushort[] K; // 0x60
	private int j; // 0x68
	private static readonly byte[] pitable; // 0x0

	// Methods

	// RVA: 0x1AF8CF0 Offset: 0x1AF76F0 VA: 0x181AF8CF0
	public void .ctor(RC2 rc2Algo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x1AF8120 Offset: 0x1AF6B20 VA: 0x181AF8120 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x1AF8C60 Offset: 0x1AF7660 VA: 0x181AF8C60
	private static void .cctor() { }
}
