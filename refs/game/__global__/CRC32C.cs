public static class CRC32C // TypeDefIndex: 12426
{
	// Fields
	public const int ChecksumSize = 4;
	private const uint Poly = 2197175160;
	private static readonly uint[] Table; // 0x0

	// Methods

	// RVA: 0xCF1450 Offset: 0xCEFE50 VA: 0x180CF1450
	private static void .cctor() { }

	// RVA: 0xCF0EA0 Offset: 0xCEF8A0 VA: 0x180CF0EA0
	public static uint Compute(byte[] input, int offset, int length) { }
}
