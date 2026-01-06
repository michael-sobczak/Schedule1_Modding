public sealed class MD5CryptoServiceProvider : MD5 // TypeDefIndex: 4244
{
	// Fields
	private uint[] _H; // 0x28
	private uint[] buff; // 0x30
	private ulong count; // 0x38
	private byte[] _ProcessingBuffer; // 0x40
	private int _ProcessingBufferCount; // 0x48
	private static readonly uint[] K; // 0x0

	// Methods

	// RVA: 0x1AF8060 Offset: 0x1AF6A60 VA: 0x181AF8060
	public void .ctor() { }

	// RVA: 0x1AF6810 Offset: 0x1AF5210 VA: 0x181AF6810 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1AF6790 Offset: 0x1AF5190 VA: 0x181AF6790 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1AF6880 Offset: 0x1AF5280 VA: 0x181AF6880 Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x1AF69C0 Offset: 0x1AF53C0 VA: 0x181AF69C0 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x1AF6AB0 Offset: 0x1AF54B0 VA: 0x181AF6AB0 Slot: 18
	public override void Initialize() { }

	// RVA: 0x1AF6B30 Offset: 0x1AF5530 VA: 0x181AF6B30
	private void ProcessBlock(byte[] inputBuffer, int inputOffset) { }

	// RVA: 0x1AF7D90 Offset: 0x1AF6790 VA: 0x181AF7D90
	private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1AF66B0 Offset: 0x1AF50B0 VA: 0x181AF66B0
	internal void AddLength(ulong length, byte[] buffer, int position) { }

	// RVA: 0x1AF7FD0 Offset: 0x1AF69D0 VA: 0x181AF7FD0
	private static void .cctor() { }
}
