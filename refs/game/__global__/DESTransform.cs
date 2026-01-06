internal class DESTransform : SymmetricTransform // TypeDefIndex: 4242
{
	// Fields
	internal static readonly int KEY_BIT_SIZE; // 0x0
	internal static readonly int KEY_BYTE_SIZE; // 0x4
	internal static readonly int BLOCK_BIT_SIZE; // 0x8
	internal static readonly int BLOCK_BYTE_SIZE; // 0xC
	private byte[] keySchedule; // 0x58
	private byte[] byteBuff; // 0x60
	private uint[] dwordBuff; // 0x68
	private static readonly uint[] spBoxes; // 0x10
	private static readonly byte[] PC1; // 0x18
	private static readonly byte[] leftRotTotal; // 0x20
	private static readonly byte[] PC2; // 0x28
	internal static readonly uint[] ipTab; // 0x30
	internal static readonly uint[] fpTab; // 0x38

	// Methods

	// RVA: 0x1AF5E40 Offset: 0x1AF4840 VA: 0x181AF5E40
	internal void .ctor(SymmetricAlgorithm symmAlgo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x1AF4B30 Offset: 0x1AF3530 VA: 0x181AF4B30
	private uint CipherFunct(uint r, int n) { }

	// RVA: 0x1AF4F80 Offset: 0x1AF3980 VA: 0x181AF4F80
	internal static void Permutation(byte[] input, byte[] output, uint[] permTab, bool preSwap) { }

	// RVA: 0x1AF4AA0 Offset: 0x1AF34A0 VA: 0x181AF4AA0
	private static void BSwap(byte[] byteBuff) { }

	// RVA: 0x1AF5760 Offset: 0x1AF4160 VA: 0x181AF5760
	internal void SetKey(byte[] key) { }

	// RVA: 0x1AF5310 Offset: 0x1AF3D10 VA: 0x181AF5310
	public void ProcessBlock(byte[] input, byte[] output) { }

	// RVA: 0x1AF4E00 Offset: 0x1AF3800 VA: 0x181AF4E00 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x1AF4ED0 Offset: 0x1AF38D0 VA: 0x181AF4ED0
	internal static byte[] GetStrongKey() { }

	// RVA: 0x1AF5B50 Offset: 0x1AF4550 VA: 0x181AF5B50
	private static void .cctor() { }
}
