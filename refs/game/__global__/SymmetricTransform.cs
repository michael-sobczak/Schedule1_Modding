internal abstract class SymmetricTransform : ICryptoTransform, IDisposable // TypeDefIndex: 3519
{
	// Fields
	protected SymmetricAlgorithm algo; // 0x10
	protected bool encrypt; // 0x18
	protected int BlockSizeByte; // 0x1C
	protected byte[] temp; // 0x20
	protected byte[] temp2; // 0x28
	private byte[] workBuff; // 0x30
	private byte[] workout; // 0x38
	protected PaddingMode padmode; // 0x40
	protected int FeedBackByte; // 0x44
	private bool m_disposed; // 0x48
	protected bool lastBlock; // 0x49
	private RandomNumberGenerator _rng; // 0x50

	// Properties
	public virtual bool CanTransformMultipleBlocks { get; }
	public virtual int InputBlockSize { get; }
	public virtual int OutputBlockSize { get; }
	private bool KeepLastBlock { get; }

	// Methods

	// RVA: 0x1AB45A0 Offset: 0x1AB2FA0 VA: 0x181AB45A0
	public void .ctor(SymmetricAlgorithm symmAlgo, bool encryption, byte[] rgbIV) { }

	// RVA: 0x1AB3AF0 Offset: 0x1AB24F0 VA: 0x181AB3AF0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1AB3E70 Offset: 0x1AB2870 VA: 0x181AB3E70 Slot: 9
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AB33F0 Offset: 0x1AB1DF0 VA: 0x181AB33F0 Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 11
	public virtual bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70 Slot: 12
	public virtual int get_InputBlockSize() { }

	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70 Slot: 13
	public virtual int get_OutputBlockSize() { }

	// RVA: 0x1AB4420 Offset: 0x1AB2E20 VA: 0x181AB4420 Slot: 14
	protected virtual void Transform(byte[] input, byte[] output) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void ECB(byte[] input, byte[] output);

	// RVA: 0x1AB2EC0 Offset: 0x1AB18C0 VA: 0x181AB2EC0 Slot: 16
	protected virtual void CBC(byte[] input, byte[] output) { }

	// RVA: 0x1AB3010 Offset: 0x1AB1A10 VA: 0x181AB3010 Slot: 17
	protected virtual void CFB(byte[] input, byte[] output) { }

	// RVA: 0x1AB3D50 Offset: 0x1AB2750 VA: 0x181AB3D50 Slot: 18
	protected virtual void OFB(byte[] input, byte[] output) { }

	// RVA: 0x1AB3200 Offset: 0x1AB1C00 VA: 0x181AB3200 Slot: 19
	protected virtual void CTS(byte[] input, byte[] output) { }

	// RVA: 0x1AB3250 Offset: 0x1AB1C50 VA: 0x181AB3250
	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1AB4030 Offset: 0x1AB2A30 VA: 0x181AB4030 Slot: 20
	public virtual int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x1AB48B0 Offset: 0x1AB32B0 VA: 0x181AB48B0
	private bool get_KeepLastBlock() { }

	// RVA: 0x1AB3B60 Offset: 0x1AB2560 VA: 0x181AB3B60
	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x1AB3DA0 Offset: 0x1AB27A0 VA: 0x181AB3DA0
	private void Random(byte[] buffer, int start, int length) { }

	// RVA: 0x1AB3EE0 Offset: 0x1AB28E0 VA: 0x181AB3EE0
	private void ThrowBadPaddingException(PaddingMode padding, int length, int position) { }

	// RVA: 0x1AB37A0 Offset: 0x1AB21A0 VA: 0x181AB37A0 Slot: 21
	protected virtual byte[] FinalEncrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1AB3460 Offset: 0x1AB1E60 VA: 0x181AB3460 Slot: 22
	protected virtual byte[] FinalDecrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1AB4350 Offset: 0x1AB2D50 VA: 0x181AB4350 Slot: 23
	public virtual byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }
}
