public class SHA512Managed : SHA512 // TypeDefIndex: 4229
{
	// Fields
	private byte[] _buffer; // 0x28
	private ulong _count; // 0x30
	private ulong[] _stateSHA512; // 0x38
	private ulong[] _W; // 0x40
	private static readonly ulong[] _K; // 0x0

	// Methods

	// RVA: 0x1B00890 Offset: 0x1AFF290 VA: 0x181B00890
	public void .ctor() { }

	// RVA: 0x1AFF320 Offset: 0x1AFDD20 VA: 0x181AFF320 Slot: 18
	public override void Initialize() { }

	// RVA: 0x1AFF1D0 Offset: 0x1AFDBD0 VA: 0x181AFF1D0 Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x1AFF1E0 Offset: 0x1AFDBE0 VA: 0x181AFF1E0 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x1AFF1F0 Offset: 0x1AFDBF0 VA: 0x181AFF1F0
	private void InitializeState() { }

	// RVA: 0x1B00610 Offset: 0x1AFF010 VA: 0x181B00610
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x1B00340 Offset: 0x1AFED40 VA: 0x181B00340
	private byte[] _EndHash() { }

	// RVA: 0x1AFF4E0 Offset: 0x1AFDEE0 VA: 0x181AFF4E0
	private static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block) { }

	// RVA: 0x1AFDA70 Offset: 0x1AFC470 VA: 0x181AFDA70
	private static ulong RotateRight(ulong x, int n) { }

	// RVA: 0x1AFD8A0 Offset: 0x1AFC2A0 VA: 0x181AFD8A0
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	// RVA: 0x1AFDA60 Offset: 0x1AFC460 VA: 0x181AFDA60
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	// RVA: 0x1B00240 Offset: 0x1AFEC40 VA: 0x181B00240
	private static ulong Sigma_0(ulong x) { }

	// RVA: 0x1B002C0 Offset: 0x1AFECC0 VA: 0x181B002C0
	private static ulong Sigma_1(ulong x) { }

	// RVA: 0x1B00970 Offset: 0x1AFF370 VA: 0x181B00970
	private static ulong sigma_0(ulong x) { }

	// RVA: 0x1B009E0 Offset: 0x1AFF3E0 VA: 0x181B009E0
	private static ulong sigma_1(ulong x) { }

	// RVA: 0x1AFF380 Offset: 0x1AFDD80 VA: 0x181AFF380
	private static void SHA512Expand(ulong* x) { }

	// RVA: 0x1B00800 Offset: 0x1AFF200 VA: 0x181B00800
	private static void .cctor() { }
}
