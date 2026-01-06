public class SHA1Managed : SHA1 // TypeDefIndex: 4223
{
	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateSHA1; // 0x38
	private uint[] _expandedBuffer; // 0x40

	// Methods

	// RVA: 0x1AFC0C0 Offset: 0x1AFAAC0 VA: 0x181AFC0C0
	public void .ctor() { }

	// RVA: 0x1AFB6B0 Offset: 0x1AFA0B0 VA: 0x181AFB6B0 Slot: 18
	public override void Initialize() { }

	// RVA: 0x1AFB690 Offset: 0x1AFA090 VA: 0x181AFB690 Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x1AFB6A0 Offset: 0x1AFA0A0 VA: 0x181AFB6A0 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x1AE81C0 Offset: 0x1AE6BC0 VA: 0x181AE81C0
	private void InitializeState() { }

	// RVA: 0x1AFBF20 Offset: 0x1AFA920 VA: 0x181AFBF20
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x1AFBCE0 Offset: 0x1AFA6E0 VA: 0x181AFBCE0
	private byte[] _EndHash() { }

	// RVA: 0x1AFB750 Offset: 0x1AFA150 VA: 0x181AFB750
	private static void SHATransform(uint* expandedBuffer, uint* state, byte* block) { }

	// RVA: 0x1AFB710 Offset: 0x1AFA110 VA: 0x181AFB710
	private static void SHAExpand(uint* x) { }
}
