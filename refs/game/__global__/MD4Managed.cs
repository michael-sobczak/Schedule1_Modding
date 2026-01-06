public class MD4Managed : MD4 // TypeDefIndex: 17550
{
	// Fields
	private uint[] state; // 0x28
	private byte[] buffer; // 0x30
	private uint[] count; // 0x38
	private uint[] x; // 0x40
	private byte[] digest; // 0x48

	// Methods

	// RVA: 0x1A79590 Offset: 0x1A77F90 VA: 0x181A79590
	public void .ctor() { }

	// RVA: 0x1A78990 Offset: 0x1A77390 VA: 0x181A78990 Slot: 18
	public override void Initialize() { }

	// RVA: 0x1A78550 Offset: 0x1A76F50 VA: 0x181A78550 Slot: 16
	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: 0x1A786D0 Offset: 0x1A770D0 VA: 0x181A786D0 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x1A79510 Offset: 0x1A77F10 VA: 0x181A79510
	private byte[] Padding(int nLength) { }

	// RVA: 0x1A78490 Offset: 0x1A76E90 VA: 0x181A78490
	private uint F(uint x, uint y, uint z) { }

	// RVA: 0x1A784F0 Offset: 0x1A76EF0 VA: 0x181A784F0
	private uint G(uint x, uint y, uint z) { }

	// RVA: 0x1A78540 Offset: 0x1A76F40 VA: 0x181A78540
	private uint H(uint x, uint y, uint z) { }

	// RVA: 0x1A79570 Offset: 0x1A77F70 VA: 0x181A79570
	private uint ROL(uint x, byte n) { }

	// RVA: 0x1A78450 Offset: 0x1A76E50 VA: 0x181A78450
	private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x1A784A0 Offset: 0x1A76EA0 VA: 0x181A784A0
	private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x1A78500 Offset: 0x1A76F00 VA: 0x181A78500
	private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x1A783A0 Offset: 0x1A76DA0 VA: 0x181A783A0
	private void Encode(byte[] output, uint[] input) { }

	// RVA: 0x1A782F0 Offset: 0x1A76CF0 VA: 0x181A782F0
	private void Decode(uint[] output, byte[] input, int index) { }

	// RVA: 0x1A78A60 Offset: 0x1A77460 VA: 0x181A78A60
	private void MD4Transform(uint[] state, byte[] block, int index) { }
}
