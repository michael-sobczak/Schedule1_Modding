public class MD2Managed : MD2 // TypeDefIndex: 17548
{
	// Fields
	private byte[] state; // 0x28
	private byte[] checksum; // 0x30
	private byte[] buffer; // 0x38
	private int count; // 0x40
	private byte[] x; // 0x48
	private static readonly byte[] PI_SUBST; // 0x0

	// Methods

	// RVA: 0x1A77FD0 Offset: 0x1A769D0 VA: 0x181A77FD0
	private byte[] Padding(int nLength) { }

	// RVA: 0x1A780E0 Offset: 0x1A76AE0 VA: 0x181A780E0
	public void .ctor() { }

	// RVA: 0x1A77C90 Offset: 0x1A76690 VA: 0x181A77C90 Slot: 18
	public override void Initialize() { }

	// RVA: 0x1A77A30 Offset: 0x1A76430 VA: 0x181A77A30 Slot: 16
	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: 0x1A77B30 Offset: 0x1A76530 VA: 0x181A77B30 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x1A77D00 Offset: 0x1A76700 VA: 0x181A77D00
	private void MD2Transform(byte[] state, byte[] checksum, byte[] block, int index) { }

	// RVA: 0x1A78050 Offset: 0x1A76A50 VA: 0x181A78050
	private static void .cctor() { }
}
