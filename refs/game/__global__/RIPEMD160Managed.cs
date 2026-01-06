public class RIPEMD160Managed : RIPEMD160 // TypeDefIndex: 4218
{
	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateMD160; // 0x38
	private uint[] _blockDWords; // 0x40

	// Methods

	// RVA: 0x1AEA6B0 Offset: 0x1AE90B0 VA: 0x181AEA6B0
	public void .ctor() { }

	// RVA: 0x1AE8250 Offset: 0x1AE6C50 VA: 0x181AE8250 Slot: 18
	public override void Initialize() { }

	// RVA: 0x1AE8190 Offset: 0x1AE6B90 VA: 0x181AE8190 Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x1AE81A0 Offset: 0x1AE6BA0 VA: 0x181AE81A0 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x1AE81C0 Offset: 0x1AE6BC0 VA: 0x181AE81C0
	private void InitializeState() { }

	// RVA: 0x1AEA510 Offset: 0x1AE8F10 VA: 0x181AEA510
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x1AEA360 Offset: 0x1AE8D60 VA: 0x181AEA360
	private byte[] _EndHash() { }

	// RVA: 0x1AE82C0 Offset: 0x1AE6CC0 VA: 0x181AE82C0
	private static void MDTransform(uint* blockDWords, uint* state, byte* block) { }

	// RVA: 0x1AE8160 Offset: 0x1AE6B60 VA: 0x181AE8160
	private static uint F(uint x, uint y, uint z) { }

	// RVA: 0x1AE8170 Offset: 0x1AE6B70 VA: 0x181AE8170
	private static uint G(uint x, uint y, uint z) { }

	// RVA: 0x1AE8180 Offset: 0x1AE6B80 VA: 0x181AE8180
	private static uint H(uint x, uint y, uint z) { }

	// RVA: 0x1AE81B0 Offset: 0x1AE6BB0 VA: 0x181AE81B0
	private static uint I(uint x, uint y, uint z) { }

	// RVA: 0x1AE82B0 Offset: 0x1AE6CB0 VA: 0x181AE82B0
	private static uint J(uint x, uint y, uint z) { }
}
