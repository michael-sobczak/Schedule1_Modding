public class SHA384Managed : SHA384 // TypeDefIndex: 4227
{
	// Fields
	private byte[] _buffer; // 0x28
	private ulong _count; // 0x30
	private ulong[] _stateSHA384; // 0x38
	private ulong[] _W; // 0x40
	private static readonly ulong[] _K; // 0x0

	// Methods

	// RVA: 0x1AFEFA0 Offset: 0x1AFD9A0 VA: 0x181AFEFA0
	public void .ctor() { }

	// RVA: 0x1AFDA00 Offset: 0x1AFC400 VA: 0x181AFDA00 Slot: 18
	public override void Initialize() { }

	// RVA: 0x1AFD8B0 Offset: 0x1AFC2B0 VA: 0x181AFD8B0 Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x1AFD8C0 Offset: 0x1AFC2C0 VA: 0x181AFD8C0 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x1AFD8D0 Offset: 0x1AFC2D0 VA: 0x181AFD8D0
	private void InitializeState() { }

	// RVA: 0x1AFED20 Offset: 0x1AFD720 VA: 0x181AFED20
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x1AFEA50 Offset: 0x1AFD450 VA: 0x181AFEA50
	private byte[] _EndHash() { }

	// RVA: 0x1AFDBF0 Offset: 0x1AFC5F0 VA: 0x181AFDBF0
	private static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block) { }

	// RVA: 0x1AFDA70 Offset: 0x1AFC470 VA: 0x181AFDA70
	private static ulong RotateRight(ulong x, int n) { }

	// RVA: 0x1AFD8A0 Offset: 0x1AFC2A0 VA: 0x181AFD8A0
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	// RVA: 0x1AFDA60 Offset: 0x1AFC460 VA: 0x181AFDA60
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	// RVA: 0x1AFE950 Offset: 0x1AFD350 VA: 0x181AFE950
	private static ulong Sigma_0(ulong x) { }

	// RVA: 0x1AFE9D0 Offset: 0x1AFD3D0 VA: 0x181AFE9D0
	private static ulong Sigma_1(ulong x) { }

	// RVA: 0x1AFF080 Offset: 0x1AFDA80 VA: 0x181AFF080
	private static ulong sigma_0(ulong x) { }

	// RVA: 0x1AFF0F0 Offset: 0x1AFDAF0 VA: 0x181AFF0F0
	private static ulong sigma_1(ulong x) { }

	// RVA: 0x1AFDA90 Offset: 0x1AFC490 VA: 0x181AFDA90
	private static void SHA384Expand(ulong* x) { }

	// RVA: 0x1AFEF10 Offset: 0x1AFD910 VA: 0x181AFEF10
	private static void .cctor() { }
}
