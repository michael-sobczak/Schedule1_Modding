public static class Quaternion32Compression // TypeDefIndex: 12523
{
	// Fields
	private const float Maximum = 0.70710653;
	private const int BitsPerAxis = 10;
	private const int LargestComponentShift = 30;
	private const int AShift = 20;
	private const int BShift = 10;
	private const int IntScale = 511;
	private const int IntMask = 1023;

	// Methods

	// RVA: 0xD168A0 Offset: 0xD152A0 VA: 0x180D168A0
	public static uint Compress(Quaternion quaternion) { }

	// RVA: 0xD16D40 Offset: 0xD15740 VA: 0x180D16D40
	private static uint ScaleToUint(float v) { }

	// RVA: 0xD16D10 Offset: 0xD15710 VA: 0x180D16D10
	private static float ScaleToFloat(uint v) { }

	// RVA: 0xD16A30 Offset: 0xD15430 VA: 0x180D16A30
	public static Quaternion Decompress(uint compressed) { }
}
