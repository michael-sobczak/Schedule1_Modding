internal class AesTransform : SymmetricTransform // TypeDefIndex: 15041
{
	// Fields
	private uint[] expandedKey; // 0x58
	private int Nk; // 0x60
	private int Nr; // 0x64
	private static readonly uint[] Rcon; // 0x0
	private static readonly byte[] SBox; // 0x8
	private static readonly byte[] iSBox; // 0x10
	private static readonly uint[] T0; // 0x18
	private static readonly uint[] T1; // 0x20
	private static readonly uint[] T2; // 0x28
	private static readonly uint[] T3; // 0x30
	private static readonly uint[] iT0; // 0x38
	private static readonly uint[] iT1; // 0x40
	private static readonly uint[] iT2; // 0x48
	private static readonly uint[] iT3; // 0x50

	// Methods

	// RVA: 0x1F80560 Offset: 0x1F7EF60 VA: 0x181F80560
	public void .ctor(Aes algo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x1F7D210 Offset: 0x1F7BC10 VA: 0x181F7D210 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x1F80010 Offset: 0x1F7EA10 VA: 0x181F80010
	private uint SubByte(uint a) { }

	// RVA: 0x1F7D240 Offset: 0x1F7BC40 VA: 0x181F7D240
	private void Encrypt128(byte[] indata, byte[] outdata, uint[] ekey) { }

	// RVA: 0x1F7A410 Offset: 0x1F78E10 VA: 0x181F7A410
	private void Decrypt128(byte[] indata, byte[] outdata, uint[] ekey) { }

	// RVA: 0x1F80110 Offset: 0x1F7EB10 VA: 0x181F80110
	private static void .cctor() { }
}
