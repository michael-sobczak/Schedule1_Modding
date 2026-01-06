public abstract class HashAlgorithm : IDisposable, ICryptoTransform // TypeDefIndex: 4180
{
	// Fields
	private bool _disposed; // 0x10
	protected int HashSizeValue; // 0x14
	protected internal byte[] HashValue; // 0x18
	protected int State; // 0x20

	// Properties
	public virtual int HashSize { get; }
	public virtual byte[] Hash { get; }
	public virtual int InputBlockSize { get; }
	public virtual int OutputBlockSize { get; }
	public virtual bool CanTransformMultipleBlocks { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x1AE6A20 Offset: 0x1AE5420 VA: 0x181AE6A20
	public static HashAlgorithm Create(string hashName) { }

	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70 Slot: 10
	public virtual int get_HashSize() { }

	// RVA: 0x1AE6EF0 Offset: 0x1AE58F0 VA: 0x181AE6EF0 Slot: 11
	public virtual byte[] get_Hash() { }

	// RVA: 0x1AE6760 Offset: 0x1AE5160 VA: 0x181AE6760
	public byte[] ComputeHash(byte[] buffer) { }

	// RVA: 0x1AE6830 Offset: 0x1AE5230 VA: 0x181AE6830
	public byte[] ComputeHash(byte[] buffer, int offset, int count) { }

	// RVA: 0x1AE6660 Offset: 0x1AE5060 VA: 0x181AE6660
	private byte[] CaptureHashCodeAndReinitialize() { }

	// RVA: 0x1AE6AB0 Offset: 0x1AE54B0 VA: 0x181AE6AB0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1AE6720 Offset: 0x1AE5120 VA: 0x181AE6720
	public void Clear() { }

	// RVA: 0x1AE6AA0 Offset: 0x1AE54A0 VA: 0x181AE6AA0 Slot: 12
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 13
	public virtual int get_InputBlockSize() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 14
	public virtual int get_OutputBlockSize() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 15
	public virtual bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x1AE6B20 Offset: 0x1AE5520 VA: 0x181AE6B20 Slot: 8
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x1AE6BD0 Offset: 0x1AE55D0 VA: 0x181AE6BD0 Slot: 9
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1AE6D30 Offset: 0x1AE5730 VA: 0x181AE6D30
	private void ValidateTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void HashCore(byte[] array, int ibStart, int cbSize);

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract byte[] HashFinal();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void Initialize();
}
