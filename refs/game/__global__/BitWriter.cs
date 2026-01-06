internal class BitWriter // TypeDefIndex: 16641
{
	// Fields
	private uint accumulator; // 0x10
	private int nAccumulatedBits; // 0x14
	private Stream output; // 0x18
	private int totalBytesWrittenOut; // 0x20

	// Properties
	public byte RemainingBits { get; }
	public int NumRemainingBits { get; }
	public int TotalBytesWrittenOut { get; }

	// Methods

	// RVA: 0x7E2C80 Offset: 0x7E1680 VA: 0x1807E2C80
	public void .ctor(Stream s) { }

	// RVA: 0x1E60E50 Offset: 0x1E5F850 VA: 0x181E60E50
	public byte get_RemainingBits() { }

	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	public int get_NumRemainingBits() { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public int get_TotalBytesWrittenOut() { }

	// RVA: 0x1E60CB0 Offset: 0x1E5F6B0 VA: 0x181E60CB0
	public void Reset() { }

	// RVA: 0x1E60D10 Offset: 0x1E5F710 VA: 0x181E60D10
	public void WriteBits(int nbits, uint value) { }

	// RVA: 0x1E60DB0 Offset: 0x1E5F7B0 VA: 0x181E60DB0
	public void WriteByte(byte b) { }

	// RVA: 0x1E60DD0 Offset: 0x1E5F7D0 VA: 0x181E60DD0
	public void WriteInt(uint u) { }

	// RVA: 0x1E60CA0 Offset: 0x1E5F6A0 VA: 0x181E60CA0
	public void Flush() { }

	// RVA: 0x1E60C50 Offset: 0x1E5F650 VA: 0x181E60C50
	public void FinishAndPad() { }
}
