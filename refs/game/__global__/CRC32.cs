public class CRC32 // TypeDefIndex: 16679
{
	// Fields
	private const int BUFFER_SIZE = 8192;
	private uint dwPolynomial; // 0x10
	private long _TotalBytesRead; // 0x18
	private bool reverseBits; // 0x20
	private uint[] crc32Table; // 0x28
	private uint _register; // 0x30

	// Properties
	public long TotalBytesRead { get; }
	public int Crc32Result { get; }

	// Methods

	// RVA: 0x1E70060 Offset: 0x1E6EA60 VA: 0x181E70060
	public void .ctor() { }

	// RVA: 0x1E701A0 Offset: 0x1E6EBA0 VA: 0x181E701A0
	public void .ctor(bool reverseBits) { }

	// RVA: 0x1E6FF10 Offset: 0x1E6E910 VA: 0x181E6FF10
	public void .ctor(int polynomial, bool reverseBits) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public long get_TotalBytesRead() { }

	// RVA: 0x1E702F0 Offset: 0x1E6ECF0 VA: 0x181E702F0
	public int get_Crc32Result() { }

	// RVA: 0x1E6FC90 Offset: 0x1E6E690 VA: 0x181E6FC90
	public int GetCrc32(Stream input) { }

	// RVA: 0x1E6FA10 Offset: 0x1E6E410 VA: 0x181E6FA10
	public int GetCrc32AndCopy(Stream input, Stream output) { }

	// RVA: 0x1E6F8B0 Offset: 0x1E6E2B0 VA: 0x181E6F8B0
	public int ComputeCrc32(int W, byte B) { }

	// RVA: 0x1E6F8B0 Offset: 0x1E6E2B0 VA: 0x181E6F8B0
	internal int _InternalComputeCrc32(uint W, byte B) { }

	// RVA: 0x1E6FD20 Offset: 0x1E6E720 VA: 0x181E6FD20
	public void SlurpBlock(byte[] block, int offset, int count) { }

	// RVA: 0x1E6FEA0 Offset: 0x1E6E8A0 VA: 0x181E6FEA0
	public void UpdateCRC(byte b) { }

	// RVA: 0x1E6FE30 Offset: 0x1E6E830 VA: 0x181E6FE30
	public void UpdateCRC(byte b, int n) { }

	// RVA: 0x1E6FCE0 Offset: 0x1E6E6E0 VA: 0x181E6FCE0
	private static uint ReverseBits(uint data) { }

	// RVA: 0x1E6FCB0 Offset: 0x1E6E6B0 VA: 0x181E6FCB0
	private static byte ReverseBits(byte data) { }

	// RVA: 0x1E6F8F0 Offset: 0x1E6E2F0 VA: 0x181E6F8F0
	private void GenerateLookupTable() { }

	// RVA: 0x1E703A0 Offset: 0x1E6EDA0 VA: 0x181E703A0
	private uint gf2_matrix_times(uint[] matrix, uint vec) { }

	// RVA: 0x1E70300 Offset: 0x1E6ED00 VA: 0x181E70300
	private void gf2_matrix_square(uint[] square, uint[] mat) { }

	// RVA: 0x1E6F5A0 Offset: 0x1E6DFA0 VA: 0x181E6F5A0
	public void Combine(int crc, int length) { }

	// RVA: 0x1E6FCA0 Offset: 0x1E6E6A0 VA: 0x181E6FCA0
	public void Reset() { }
}
