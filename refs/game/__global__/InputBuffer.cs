internal sealed class InputBuffer // TypeDefIndex: 17649
{
	// Fields
	private byte[] _buffer; // 0x10
	private int _start; // 0x18
	private int _end; // 0x1C
	private uint _bitBuffer; // 0x20
	private int _bitsInBuffer; // 0x24

	// Properties
	public int AvailableBits { get; }
	public int AvailableBytes { get; }

	// Methods

	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public int get_AvailableBits() { }

	// RVA: 0x21708E0 Offset: 0x216F2E0 VA: 0x1821708E0
	public int get_AvailableBytes() { }

	// RVA: 0x2170660 Offset: 0x216F060 VA: 0x182170660
	public bool EnsureBitsAvailable(int count) { }

	// RVA: 0x2170820 Offset: 0x216F220 VA: 0x182170820
	public uint TryLoad16Bits() { }

	// RVA: 0x2170710 Offset: 0x216F110 VA: 0x182170710
	private uint GetBitMask(int count) { }

	// RVA: 0x2170720 Offset: 0x216F120 VA: 0x182170720
	public int GetBits(int count) { }

	// RVA: 0x21705A0 Offset: 0x216EFA0 VA: 0x1821705A0
	public int CopyTo(byte[] output, int offset, int length) { }

	// RVA: 0xCF72A0 Offset: 0xCF5CA0 VA: 0x180CF72A0
	public bool NeedsInput() { }

	// RVA: 0x2170780 Offset: 0x216F180 VA: 0x182170780
	public void SetInput(byte[] buffer, int offset, int length) { }

	// RVA: 0x21707C0 Offset: 0x216F1C0 VA: 0x1821707C0
	public void SkipBits(int n) { }

	// RVA: 0x21707E0 Offset: 0x216F1E0 VA: 0x1821707E0
	public void SkipToByteBoundary() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
