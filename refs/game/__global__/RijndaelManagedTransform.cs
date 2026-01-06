public sealed class RijndaelManagedTransform : ICryptoTransform, IDisposable // TypeDefIndex: 4216
{
	// Fields
	private CipherMode m_cipherMode; // 0x10
	private PaddingMode m_paddingValue; // 0x14
	private RijndaelManagedTransformMode m_transformMode; // 0x18
	private int m_blockSizeBits; // 0x1C
	private int m_blockSizeBytes; // 0x20
	private int m_inputBlockSize; // 0x24
	private int m_outputBlockSize; // 0x28
	private int[] m_encryptKeyExpansion; // 0x30
	private int[] m_decryptKeyExpansion; // 0x38
	private int m_Nr; // 0x40
	private int m_Nb; // 0x44
	private int m_Nk; // 0x48
	private int[] m_encryptindex; // 0x50
	private int[] m_decryptindex; // 0x58
	private int[] m_IV; // 0x60
	private int[] m_lastBlockBuffer; // 0x68
	private byte[] m_depadBuffer; // 0x70
	private byte[] m_shiftRegister; // 0x78
	private static readonly byte[] s_Sbox; // 0x0
	private static readonly int[] s_Rcon; // 0x8
	private static readonly int[] s_T; // 0x10
	private static readonly int[] s_TF; // 0x18
	private static readonly int[] s_iT; // 0x20
	private static readonly int[] s_iTF; // 0x28

	// Properties
	public int InputBlockSize { get; }
	public int OutputBlockSize { get; }
	public bool CanTransformMultipleBlocks { get; }

	// Methods

	// RVA: 0x1AEF790 Offset: 0x1AEE190 VA: 0x181AEF790
	internal void .ctor(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int blockSize, int feedbackSize, PaddingMode PaddingValue, RijndaelManagedTransformMode transformMode) { }

	// RVA: 0x1AED450 Offset: 0x1AEBE50 VA: 0x181AED450 Slot: 9
	public void Dispose() { }

	// RVA: 0x1AED570 Offset: 0x1AEBF70 VA: 0x181AED570
	private void Dispose(bool disposing) { }

	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40 Slot: 4
	public int get_InputBlockSize() { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430 Slot: 5
	public int get_OutputBlockSize() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 6
	public bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x1AEED30 Offset: 0x1AED730 VA: 0x181AEED30 Slot: 7
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x1AEF150 Offset: 0x1AEDB50 VA: 0x181AEF150 Slot: 8
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1AEEBC0 Offset: 0x1AED5C0 VA: 0x181AEEBC0
	public void Reset() { }

	// RVA: 0x1AED8B0 Offset: 0x1AEC2B0 VA: 0x181AED8B0
	private int EncryptData(byte[] inputBuffer, int inputOffset, int inputCount, ref byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	// RVA: 0x1AEC560 Offset: 0x1AEAF60 VA: 0x181AEC560
	private int DecryptData(byte[] inputBuffer, int inputOffset, int inputCount, ref byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	// RVA: 0x1AED6A0 Offset: 0x1AEC0A0 VA: 0x181AED6A0
	private void Enc(int* encryptindex, int* encryptKeyExpansion, int* T, int* TF, int* work, int* temp) { }

	// RVA: 0x1AEC330 Offset: 0x1AEAD30 VA: 0x181AEC330
	private void Dec(int* decryptindex, int* decryptKeyExpansion, int* iT, int* iTF, int* work, int* temp) { }

	// RVA: 0x1AEE560 Offset: 0x1AECF60 VA: 0x181AEE560
	private void GenerateKeyExpansion(byte[] rgbKey) { }

	// RVA: 0x1AEFE60 Offset: 0x1AEE860 VA: 0x181AEFE60
	private static int rot1(int val) { }

	// RVA: 0x1AEFE70 Offset: 0x1AEE870 VA: 0x181AEFE70
	private static int rot2(int val) { }

	// RVA: 0x1AEFE80 Offset: 0x1AEE880 VA: 0x181AEFE80
	private static int rot3(int val) { }

	// RVA: 0x1AEEC40 Offset: 0x1AED640 VA: 0x181AEEC40
	private static int SubWord(int a) { }

	// RVA: 0x1AEEB90 Offset: 0x1AED590 VA: 0x181AEEB90
	private static int MulX(int x) { }

	// RVA: 0x1AEF520 Offset: 0x1AEDF20 VA: 0x181AEF520
	private static void .cctor() { }
}
