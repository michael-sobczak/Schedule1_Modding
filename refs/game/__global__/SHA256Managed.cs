public class SHA256Managed : SHA256 // TypeDefIndex: 4225
{
	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateSHA256; // 0x38
	private uint[] _W; // 0x40
	private static readonly uint[] _K; // 0x0

	// Methods

	// RVA: 0x1AFD690 Offset: 0x1AFC090 VA: 0x181AFD690
	public void .ctor() { }

	// RVA: 0x1AFC330 Offset: 0x1AFAD30 VA: 0x181AFC330 Slot: 18
	public override void Initialize() { }

	// RVA: 0x1AFC220 Offset: 0x1AFAC20 VA: 0x181AFC220 Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x1AFC230 Offset: 0x1AFAC30 VA: 0x181AFC230 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x1AFC240 Offset: 0x1AFAC40 VA: 0x181AFC240
	private void InitializeState() { }

	// RVA: 0x1AFD420 Offset: 0x1AFBE20 VA: 0x181AFD420
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x1AFD1E0 Offset: 0x1AFBBE0 VA: 0x181AFD1E0
	private byte[] _EndHash() { }

	// RVA: 0x1AFC500 Offset: 0x1AFAF00 VA: 0x181AFC500
	private static void SHATransform(uint* expandedBuffer, uint* state, byte* block) { }

	// RVA: 0x1AFC3A0 Offset: 0x1AFADA0 VA: 0x181AFC3A0
	private static uint RotateRight(uint x, int n) { }

	// RVA: 0x1AFC210 Offset: 0x1AFAC10 VA: 0x181AFC210
	private static uint Ch(uint x, uint y, uint z) { }

	// RVA: 0x1AFC390 Offset: 0x1AFAD90 VA: 0x181AFC390
	private static uint Maj(uint x, uint y, uint z) { }

	// RVA: 0x1AFD770 Offset: 0x1AFC170 VA: 0x181AFD770
	private static uint sigma_0(uint x) { }

	// RVA: 0x1AFD7D0 Offset: 0x1AFC1D0 VA: 0x181AFD7D0
	private static uint sigma_1(uint x) { }

	// RVA: 0x1AFD100 Offset: 0x1AFBB00 VA: 0x181AFD100
	private static uint Sigma_0(uint x) { }

	// RVA: 0x1AFD170 Offset: 0x1AFBB70 VA: 0x181AFD170
	private static uint Sigma_1(uint x) { }

	// RVA: 0x1AFC3C0 Offset: 0x1AFADC0 VA: 0x181AFC3C0
	private static void SHA256Expand(uint* x) { }

	// RVA: 0x1AFD600 Offset: 0x1AFC000 VA: 0x181AFD600
	private static void .cctor() { }
}
